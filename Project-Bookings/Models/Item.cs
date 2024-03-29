﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; } // Note: int or double?

        public string Description { get; set; }

        //To allow Many to Many Relations
        public virtual ICollection<Menu> Menus { get; set; }

    }
   
}
