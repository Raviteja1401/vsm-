﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EMPDBEntities : DbContext
    {
        public EMPDBEntities()
            : base("name=EMPDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DeptMaster> DeptMasters { get; set; }
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; }
        public virtual DbSet<SalaryInfo> SalaryInfoes { get; set; }
        public virtual DbSet<SELECT_EMP_WITH_SALARY> SELECT_EMP_WITH_SALARY { get; set; }
    
        public virtual int DeptMaster_Delete(Nullable<int> deptCode)
        {
            var deptCodeParameter = deptCode.HasValue ?
                new ObjectParameter("DeptCode", deptCode) :
                new ObjectParameter("DeptCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeptMaster_Delete", deptCodeParameter);
        }
    
        public virtual int DeptMaster_Insert(Nullable<int> deptCode, string deptName)
        {
            var deptCodeParameter = deptCode.HasValue ?
                new ObjectParameter("DeptCode", deptCode) :
                new ObjectParameter("DeptCode", typeof(int));
    
            var deptNameParameter = deptName != null ?
                new ObjectParameter("DeptName", deptName) :
                new ObjectParameter("DeptName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeptMaster_Insert", deptCodeParameter, deptNameParameter);
        }
    
        public virtual int DeptMaster_Update(Nullable<int> deptCode, string deptName)
        {
            var deptCodeParameter = deptCode.HasValue ?
                new ObjectParameter("DeptCode", deptCode) :
                new ObjectParameter("DeptCode", typeof(int));
    
            var deptNameParameter = deptName != null ?
                new ObjectParameter("DeptName", deptName) :
                new ObjectParameter("DeptName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeptMaster_Update", deptCodeParameter, deptNameParameter);
        }
    
        public virtual ObjectResult<SelectEmpByCode_Result> SelectEmpByCode(Nullable<int> empCode)
        {
            var empCodeParameter = empCode.HasValue ?
                new ObjectParameter("EmpCode", empCode) :
                new ObjectParameter("EmpCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEmpByCode_Result>("SelectEmpByCode", empCodeParameter);
        }
    }
}
