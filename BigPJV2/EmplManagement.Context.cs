﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigPJV2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmplManagementEntities : DbContext
    {
        public EmplManagementEntities()
            : base("name=EmplManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<v_getEmployeeInfo> v_getEmployeeInfo { get; set; }
        public virtual DbSet<v_getEmployeeSalaryMax> v_getEmployeeSalaryMax { get; set; }
    
        public virtual int addEmployeetInfo(string name, string email, string phone, string address, Nullable<byte> gender, Nullable<System.DateTime> birthday, Nullable<int> levelId, Nullable<int> departmentID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(byte));
    
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("birthday", birthday) :
                new ObjectParameter("birthday", typeof(System.DateTime));
    
            var levelIdParameter = levelId.HasValue ?
                new ObjectParameter("levelId", levelId) :
                new ObjectParameter("levelId", typeof(int));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addEmployeetInfo", nameParameter, emailParameter, phoneParameter, addressParameter, genderParameter, birthdayParameter, levelIdParameter, departmentIDParameter);
        }
    
        public virtual ObjectResult<getEmployeePaginate_Result> getEmployeePaginate(Nullable<int> limit, Nullable<int> page)
        {
            var limitParameter = limit.HasValue ?
                new ObjectParameter("limit", limit) :
                new ObjectParameter("limit", typeof(int));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("page", page) :
                new ObjectParameter("page", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmployeePaginate_Result>("getEmployeePaginate", limitParameter, pageParameter);
        }
    }
}
