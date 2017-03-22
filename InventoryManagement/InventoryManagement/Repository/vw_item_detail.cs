//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_item_detail
    {
        public int item_id { get; set; }
        public string AssetTag { get; set; }
        public string item_name { get; set; }
        public string item_description { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemSubTypeId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal CurrentValue { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> LifeSpan { get; set; }
        public Nullable<int> item_status { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdatedUser { get; set; }
        public Nullable<int> BrandId { get; set; }
        public string item_model { get; set; }
        public string item_serial { get; set; }
        public Nullable<int> CurrentOwner { get; set; }
        public Nullable<int> OsId { get; set; }
        public Nullable<int> ProcessorId { get; set; }
        public Nullable<int> MemoryId { get; set; }
        public Nullable<int> HddId { get; set; }
        public Nullable<int> Hdd2Id { get; set; }
        public Nullable<decimal> SalvageValue { get; set; }
        public string TypeName { get; set; }
        public string SubTypeName { get; set; }
        public string BrandName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Username { get; set; }
        public Nullable<int> UserDepartment { get; set; }
        public Nullable<int> UserCompany { get; set; }
        public Nullable<int> ItemLoginType { get; set; }
        public string UserDepartmentName { get; set; }
        public string UserCompanyName { get; set; }
        public Nullable<int> PrinterType { get; set; }
        public string NetworkIP { get; set; }
        public string NetworkSubnet { get; set; }
        public string NetworkGateway { get; set; }
        public Nullable<System.DateTime> BorrowDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}
