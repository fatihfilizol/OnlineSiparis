//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TableId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int StatusId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual Tables Tables { get; set; }
    }
}
