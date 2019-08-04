using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Item
    {
        public string Name;
        public double cost; // Note: int or double?

    }
    public class Extra_Items: Item
    {
        //For Decorations, etc...
    }

}
