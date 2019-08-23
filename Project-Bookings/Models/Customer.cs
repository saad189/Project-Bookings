using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Customer
    {
        public string FirstName, LastName, FullName;
        [Key]
        public string CNIC { get; set; } //Add Tag for Validation.
        public double Credit = 0, Debit = 0;
        ICollection<Booking> _Bookings;
    }
}
