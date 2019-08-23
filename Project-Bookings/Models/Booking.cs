using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project_Bookings.Models
{
  
    public class Booking : IWithHoldingTaxCalculator {

        //private:
        private static readonly string Pending = "pending";
        private static readonly string Completed = "completed";
        public double CalculateTax(double totalCost)
        {
            return totalCost * Tax_Percentage;
        }


        public int BookingId { get; set; }
        public string BookingState { get; set; } = Pending; //pending | completed.
        public DateTime BookingDate { get; set; }
        public DateTime FunctionDate { get; set; }
        public int NumberofPeople { get; set; }
        public double CostPerHead { get; set; }
        public double Tax_Percentage { get; set; } = 0.01; // Maybe Change it???

        double Total_Cost { get; set; } = 0;
        double Paid { get; set; } = 0;
        double Debit { get; }  //Add Pagination Total Pages Implementation here.

        Menu _Menu; //This can either be fixed or dynamic

        private Customer _Customer; //For DB Purposes, Maybe expose CNIC

        string Status { get; set; } //Should Only be InProgress or Complete
       public Booking(Customer C)
        {
            _Customer = C; //Make Sure the right customer gets here????
        }

        public double GetPaidAmount()
        {
            return Paid;
        }
        public double GetRemainingCost()
        {
            return Total_Cost - Paid;
        }
        public double GetCostWithoutTax()
        {
            return Total_Cost;
        }
        public double GetCostWithTax()
        {
            return CalculateTax(Total_Cost);
        }     
    }

}
