//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication10
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_Info
    {
        public int Employee_Id { get; set; }
        public int Theater_Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phone_No { get; set; }
        public string Address { get; set; }
    
        public virtual Theater_Info Theater_Info { get; set; }
    }
}
