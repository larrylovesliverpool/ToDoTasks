﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItOut.DataAccessEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class larrylovesliverpoolEntities1 : DbContext
    {
        public larrylovesliverpoolEntities1()
            : base("name=larrylovesliverpoolEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<LocomotiveDetailsAll_Result> LocomotiveDetailsAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LocomotiveDetailsAll_Result>("LocomotiveDetailsAll");
        }
    }
}
