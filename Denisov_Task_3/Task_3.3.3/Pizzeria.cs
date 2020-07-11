using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public static class Pizzeria
    {

        public static void CookThePizza(List<string> pizzaOrderList, int n)
        {
            foreach (var pizza in pizzaOrderList)
            {
                var type = (PizzaTypes)Enum.Parse(typeof(PizzaTypes), pizza);
                switch (type)
                {
                    case PizzaTypes.Venezia:
                        new Venezia();
                        break;
                    case PizzaTypes.Italiano:
                        new Italiano();
                        break;
                    case PizzaTypes.Roman:
                        new Roman();
                        break;
                    case PizzaTypes.Margarita:
                        new Margarita();
                        break;

                }

            }
        }

        private enum PizzaTypes
        {
            Venezia,
            Italiano,
            Roman,
            Margarita
        }
    }
}
