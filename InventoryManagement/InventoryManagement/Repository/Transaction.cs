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
    
    public partial class Transaction
    {
        public int id { get; set; }
        public System.DateTime transaction_date { get; set; }
        public int system_user_id { get; set; }
        public int other_user_id { get; set; }
        public int transaction_type_id { get; set; }
        public string remarks { get; set; }
        public Nullable<int> item_id { get; set; }
    }
}
