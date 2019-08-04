using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    interface IWithHoldingTaxCalculator
    {
        double Tax_Percentage { get; set; }
        double CalculateTax(double Amount);
        
    }
}
