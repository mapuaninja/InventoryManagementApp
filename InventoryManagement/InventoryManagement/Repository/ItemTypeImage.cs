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
    
    public partial class ItemTypeImage
    {
        public int id { get; set; }
        public int type_id { get; set; }
        public byte[] picture { get; set; }
    
        public virtual ItemType ItemType { get; set; }
    }
}
