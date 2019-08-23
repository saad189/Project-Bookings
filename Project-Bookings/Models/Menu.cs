using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Type { get; set; } //Dynamic or Fixed / Customized?

        //For Many to Many Relations
        public virtual ICollection<Item> ItemList { get; set; }

        private readonly List<Item> FixedList;
        public Menu(string t)
        {
            Type = t;
            if (Type == "Fixed")
            {
                ItemList = FixedList;
            }
        }
        public void AddItem(Item I)
        {
            ItemList.Add(I);
        }
        public double GetTotalCost()
        {
            double sum = 0;
            foreach (Item I in ItemList)
            {
                sum += I.Cost;
            }
            return sum;
        }
    }
}
