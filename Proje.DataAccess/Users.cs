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
    
    public partial class Users
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
    
        public virtual Rank Rank { get; set; }
    }
}