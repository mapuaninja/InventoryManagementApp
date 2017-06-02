﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryLib.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InventoryManagementEntities : DbContext
    {
        public InventoryManagementEntities()
            : base("name=InventoryManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<hdd> hdds { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<item_image> item_image { get; set; }
        public virtual DbSet<item_subtype> item_subtype { get; set; }
        public virtual DbSet<item_subtype_image> item_subtype_image { get; set; }
        public virtual DbSet<item_type> item_type { get; set; }
        public virtual DbSet<item_type_image> item_type_image { get; set; }
        public virtual DbSet<memory> memories { get; set; }
        public virtual DbSet<operation_system> operation_system { get; set; }
        public virtual DbSet<processor> processors { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transaciton> transacitons { get; set; }
        public virtual DbSet<transaction_type> transaction_type { get; set; }
        public virtual DbSet<transmital> transmitals { get; set; }
        public virtual DbSet<transmittal_items> transmittal_items { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<vw_brand_summary> vw_brand_summary { get; set; }
        public virtual DbSet<vw_item_detail> vw_item_detail { get; set; }
        public virtual DbSet<vw_item_log> vw_item_log { get; set; }
        public virtual DbSet<vw_item_schedule_summary> vw_item_schedule_summary { get; set; }
        public virtual DbSet<vw_item_subtype_count> vw_item_subtype_count { get; set; }
        public virtual DbSet<vw_item_subtype_summary> vw_item_subtype_summary { get; set; }
        public virtual DbSet<vw_item_type_summary> vw_item_type_summary { get; set; }
        public virtual DbSet<vw_request_details> vw_request_details { get; set; }
        public virtual DbSet<vw_transaction_log> vw_transaction_log { get; set; }
        public virtual DbSet<vw_transaction_summary> vw_transaction_summary { get; set; }
        public virtual DbSet<vw_transmittal_details> vw_transmittal_details { get; set; }
        public virtual DbSet<vw_transmittal_items_details> vw_transmittal_items_details { get; set; }
        public virtual DbSet<vw_user_membership_detail> vw_user_membership_detail { get; set; }
    }
}