using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Order
    {
        private static int i = 0;

        public int orderNumber;

        public bool confirmed;

        public List<String> orderList;

        public int bill;

        public int payment;

        public Order( string[] pizzaList)
        {
            i++;

            orderNumber = i;

            confirmed = false;

            payment = 0;

            foreach(var pizza in pizzaList)
            {
                orderList.Add(pizza);
            }
        }

        public event Action OrderConfirmed;

        public void CheckPayment()
        {
            if(bill == payment)
            {
                Pizzeria.CookThePizza(orderList, orderNumber);
            }
        }

        public void Confirm()
        {
            confirmed = true;
            OrderConfirmed?.Invoke();
        }
    }
}
