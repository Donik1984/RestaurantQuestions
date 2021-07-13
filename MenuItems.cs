using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class MenuItems
    {
        //public List<string> Ingredients = new List<string>();
        string Name;
        double Price;
        double Calories;

        public MenuItems(string name, double price, double calories)
        {
            Name = name;
            Price = price;
            Calories = calories;
        }
        public void PrintMenu()
        {
            Console.WriteLine($"{Name} - {Price} - {Calories}");
        }
        //public void AddInredient(string ingredient)
        //{
        //    Ingredients.Add(ingredient);
        //}
    }
}
