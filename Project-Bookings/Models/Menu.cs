using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bookings.Models
{
    public class Menu
    {
        public string type; //Dynamic or Fixed / Customized?
        public List<Item> ItemList = new List<Item>();

        public void AddItem(Item I)
        {
            ItemList.Add(I);
        }
    }
}
