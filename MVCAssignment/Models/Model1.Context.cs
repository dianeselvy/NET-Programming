﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAssignment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Community_AssistEntities : DbContext
    {
        public Community_AssistEntities()
            : base("name=Community_AssistEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusinessRule> BusinessRules { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GrantRequest> GrantRequests { get; set; }
        public virtual DbSet<GrantReview> GrantReviews { get; set; }
        public virtual DbSet<GrantReviewComment> GrantReviewComments { get; set; }
        public virtual DbSet<GrantType> GrantTypes { get; set; }
        public virtual DbSet<LoginHistoryTable> LoginHistoryTables { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
    }
}
