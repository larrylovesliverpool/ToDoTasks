using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TryItOut.Helpers.DataAnnotations
{

    //[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    //public class OddNumbersOnlyAttribute : ValidationAttribute
    //{
    //    public OddNumbersOnlyAttribute()
    //   : base("Must be an odd Non-decimal Number")
    //    {
    //    }

    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        try
    //        {
    //            var number = (int)value;
    //            if (number % 2 == 1)
    //                return ValidationResult.Success;
    //            else
    //                return new ValidationResult("Only odd numbers are valid.");
    //        }
    //        catch (Exception)
    //        {
    //            return new ValidationResult("Not a number.");
    //        }
    //    }
    //}

    //[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    //public class PositiveIntegerAttribute : ValidationAttribute
    //{
    //    public PositiveIntegerAttribute()
    //           : base("Must be a Positive Non-decimal Number")
    //    {
    //    }

    //    public override bool IsValid(object value)
    //    {
    //        if (value == null)
    //        {
    //            return true;
    //        }

    //        int num;
    //        if (int.TryParse(value.ToString(), out num))
    //        {
    //            if (num >= 0)
    //           return true;
    //        }
    //        return false;
    //    }

    //    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, ControllerContext context)
    //    {
    //        string errorMessage = FormatErrorMessage(metadata.GetDisplayName());

    //        yield return new ModelClientValidationRule { ErrorMessage = errorMessage, ValidationType = "custom" };
    //    }

    //}

    //public class PositiveIntegerAdapter : System.Web.Mvc.DataAnnotationsModelValidator<PositiveIntegerAttribute>
    //{
    //    public PositiveIntegerAdapter(System.Web.Mvc.ModelMetadata metadata, ControllerContext context, PositiveIntegerAttribute attribute)
    //        : base(metadata, context, attribute)
    //    {
    //    }

    //    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    //    {
    //        return this.Attribute.GetClientValidationRules(this.Metadata, this.ControllerContext);
    //    }
    //}

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class ValidInteger : ValidationAttribute
    {
        public ValidInteger()
               : base("Must be a Number")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString().Length == 0)
            {
                return ValidationResult.Success;
            }
            int i;

            return !int.TryParse(value.ToString(), out i) ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
        }
    }

    public class ValidIntegerValidator : DataAnnotationsModelValidator<ValidInteger>
    {
        public ValidIntegerValidator(ModelMetadata metadata, ControllerContext context, ValidInteger attribute)
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