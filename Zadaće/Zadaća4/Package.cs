using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća4
{
    //Zadatak 1.
    //Obrasci strukture - kompozit
    interface IPackable
    {
        void Pack();
    }

    class Item : IPackable
    {
        string name;
        public Item(string name)
        {
            this.name = name;
        }
        public void Pack()
        {
            Console.WriteLine($"Pack item {name}");
        }
    }

    class Package : IPackable
    {
        string name;
        List<IPackable> packables;
        public Package(string name)
        {
            this.name = name;
            packables = new List<IPackable>();
        }

        public void Pack()
        {
            Console.WriteLine($"Packing items in {name}:");

            foreach(var packable in packables) 
            { 
                packable.Pack();
            }
        }

        public void AddItem(IPackable item)
        {
            packables.Add(item);
        }

        public void RemoveItem(IPackable item)
        {
            packables.Remove(item);
        }
    }
}
