//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buru.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListUser
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int AkunId { get; set; }
    
        public virtual Akun Akun { get; set; }
        public virtual Project Project { get; set; }
    }
}