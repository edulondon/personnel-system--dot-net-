﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace niaps_ver_1._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class niapsEntities1 : DbContext
    {
        public niapsEntities1()
            : base("name=niapsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<adminUser> adminUsers { get; set; }
        public DbSet<answerToQuestion> answerToQuestions { get; set; }
        public DbSet<assetRecord> assetRecords { get; set; }
        public DbSet<assetUpdateHistory> assetUpdateHistories { get; set; }
        public DbSet<currentStaffRecord> currentStaffRecords { get; set; }
        public DbSet<employmentRecord> employmentRecords { get; set; }
        public DbSet<insuranceCompany> insuranceCompanies { get; set; }
        public DbSet<issuedQuery> issuedQueries { get; set; }
        public DbSet<leave> leaves { get; set; }
        public DbSet<leaveDay> leaveDays { get; set; }
        public DbSet<LGA> LGAs { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<pendingLeave> pendingLeaves { get; set; }
        public DbSet<qualification> qualifications { get; set; }
        public DbSet<query> queries { get; set; }
        public DbSet<question> questions { get; set; }
        public DbSet<staffNextOfKin> staffNextOfKins { get; set; }
        public DbSet<staffRecord> staffRecords { get; set; }
        public DbSet<staffReview> staffReviews { get; set; }
        public DbSet<staffUpdateHistory> staffUpdateHistories { get; set; }
        public DbSet<state> states { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<activateReview> activateReviews { get; set; }
        public DbSet<indicator> indicators { get; set; }
    }
}