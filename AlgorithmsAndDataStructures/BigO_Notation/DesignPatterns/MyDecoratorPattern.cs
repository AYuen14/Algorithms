using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.DesignPatterns
{
    public interface Pizza
    {
        string GetDescription();
        double Getcost();
    }

    public class PlainPizza : Pizza
    {

        public double Getcost()
        {
            return 4.50;
        }

        public string GetDescription()
        {
            return "Plain Dough";
        }
    }

    public abstract class ToppingDecorator : Pizza
    {
        protected Pizza _pizza;

        protected double _cost = 0.00;
        protected string _ingrediants = "Undefined";

        public ToppingDecorator(Pizza pizza)
        {
            this._pizza = pizza;
        }

        public double Getcost()
        {
            return this._pizza.Getcost() + _cost;
        }

        public string GetDescription()
        {
            return string.Format("{0}, {1}", this._pizza.GetDescription(), _ingrediants);
        }
    }

    public class Mozarella : ToppingDecorator
    {
        public Mozarella(Pizza newPizza) : base(newPizza)
        {
            base._ingrediants = "Mozarella";
            base._cost = .50;
        }
    }

    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            base._ingrediants = "Tomato Sauce";
            base._cost = .50;
        }
    }
}
