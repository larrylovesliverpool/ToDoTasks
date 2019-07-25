using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TryItOut.Helpers.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ValidateAgeAttribute : ValidationAttribute, IClientValidatable
    {
        private const string DefaultErrorMessage = "Your age is invalid, your {0} should fall between {1} and {2}";

        public DateTime MinimumDateProperty { get; private set; }
        public DateTime MaximumDateProperty { get; private set; }

        public ValidateAgeAttribute(
            int minimumAgeProperty,
            int maximumAgeProperty)
            : base(DefaultErrorMessage)
        {
            MaximumDateProperty = DateTime.Now.AddYears(minimumAgeProperty * -1);
            MinimumDateProperty = DateTime.Now.AddYears(maximumAgeProperty * -1);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime parsedValue = (DateTime)value;

                if (parsedValue <= MinimumDateProperty || parsedValue >= MaximumDateProperty)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
            return ValidationResult.Success;

        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule()
            {
                ValidationType = "validateage",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
            };

            rule.ValidationParameters.Add("minumumdate", MinimumDateProperty.ToShortDateString());
            rule.ValidationParameters.Add("maximumdate", MaximumDateProperty.ToShortDateString());

            yield return rule;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinimumDateProperty.ToShortDateString(), MaximumDateProperty.ToShortDateString());
        }
    }

    public class ValidAgeValidator : DataAnnotationsModelValidator<ValidateAgeAttribute>
    {
        public ValidAgeValidator(ModelMetadata metadata, ControllerContext context, ValidateAgeAttribute attribute)
            : base(metadata, context, attribute)
        {
            if (!attribute.IsValid(context.HttpContext.Request.Form[metadata.PropertyName]))
            {
                var propertyName = metadata.PropertyName;
                context.Controller.ViewData.ModelState[propertyName].Errors.Clear();
                context.Controller.ViewData.ModelState[propertyName].Errors.Add(attribute.ErrorMessage);
            }
        }
    }
}