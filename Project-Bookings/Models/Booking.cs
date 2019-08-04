using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Booking :IWithHoldingTaxCalculator
    {
        public DateTime BookingDate { get; set; }
        public DateTime FunctionDate { get; set; }
        public int NumberofPeople { get; set; }
        public double CostPerHead { get; set; }
        public double Tax_Percentage { get; set; } = 0.01; // Maybe Change it???

        private Customer _Customer; //For DB Purposes, Maybe expose CNIC
       
        Booking(Customer C)
        {
            _Customer = C; //Make Sure the right customer gets here????
        }

        public double CalculateTax(double Amount)
        {
            return Amount * Tax_Percentage;
        }
    }
}
