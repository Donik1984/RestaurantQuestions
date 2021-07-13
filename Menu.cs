using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Menu
    {
        public List<MenuItems> listOfMenuItems = new List<MenuItems>();
        public void AddMenuItem(MenuItems item)
        {
            this.listOfMenuItems.Add(item);
        }
        public void PrintMenuItems()
        {
            foreach(MenuItems item in this.listOfMenuItems)
            {
                item.PrintMenu();
            }
        }
    }
}
