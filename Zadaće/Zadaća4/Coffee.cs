using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća4
{
    //Zadatak 2.
    //Obrasci strukture - dekorater
    public interface ICoffee
    {
        double GetCost();
        String GetDescription();
    }

    public class Espresso : ICoffee
    {

        public double GetCost()
        {
            return 1.99;
        }

        public String GetDescription()
        {
            return "Espresso";
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public double GetCost()
        {
            return coffee.GetCost();
        }

        public string GetDescription()
        {
            return coffee.GetDescription();
        }
    }

    public class Milk : CoffeeDecorator
    {
        public const double price = 0.2;
        public Milk(ICoffee coffee) : base(coffee) 
        {
            this.coffee = coffee;
        }

        public new double GetCost()
        {
            return coffee.GetCost() + price;
        }

        public new string GetDescription()
        {
            return coffee.GetDescription() + " + Milk";
        }
    }
}
