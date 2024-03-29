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
    
    public partial class Booking_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking_Details()
        {
            this.Payment_Info = new HashSet<Payment_Info>();
            this.Seat_Details = new HashSet<Seat_Details>();
        }
    
        public int Ticket_Id { get; set; }
        public string TK_ID { get; set; }
        public int Customer_Id { get; set; }
        public Nullable<int> Employee_Id { get; set; }
        public int Show_Id { get; set; }
        public int No_Of_Tickets { get; set; }
        public System.DateTime Booking_Date { get; set; }
    
        public virtual Customer_Info Customer_Info { get; set; }
        public virtual Show_Info Show_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment_Info> Payment_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat_Details> Seat_Details { get; set; }
    }
}
