using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientCode.RunDemo1();
        }

        public static class ClientCode
        {
            public static void RunDemo1()
            {
                Item cheese = new Item("Cheese");
                Item bread = new Item("Bread");

                Package bag = new Package("Paper bag");
                bag.AddItem(cheese);
                bag.AddItem(bread);
                bag.RemoveItem(bread);

                Item eggs = new Item("Eggs");
                bag.AddItem(eggs);

                Package bigBag = new Package("Big paper bag");
                bigBag.AddItem(bag);

                Item juice = new Item("Juice");
                bigBag.AddItem(juice);

                bigBag.Pack();
                Console.ReadKey();
            }

            public static void RunDemo2()
            {
                Espresso espresso = new Espresso();
                ICoffee coffee = new Milk(new Espresso());

                coffee.GetCost();
            }
        }
    }
}
