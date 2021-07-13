using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSet getset1 = new GetSet();
            //Console.WriteLine(getset1.Name);
            //getset1.Name = "Doni";
            //Console.WriteLine(getset1.Name);

            MenuItems menuItems1 = new MenuItems("Dumblinks", 15.44, 280);
            MenuItems menuItems2 = new MenuItems("BBQ", 38.55, 360);
            MenuItems menuItems3 = new MenuItems("Chocolate Cake", 28.44, 430);
            Menu menu = new Menu();
            menu.AddMenuItem(menuItems1);
            menu.AddMenuItem(menuItems2);
            menu.AddMenuItem(menuItems3);
            menu.PrintMenuItems();
        }
    }
}
