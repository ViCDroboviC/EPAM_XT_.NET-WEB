using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Customer
    {
        public int balance;

        public string[] wantedPizza;

        Order myOrder;

        public Customer (int balance)
        {
            this.balance = balance;
            wantedPizza = new string[] { "Venezia", "Italiano"};
            Pay += PayTheBill;
            myOrder.OrderConfirmed += Pay;
        }

        public Action Pay;

        
        private void CreateNewOrder()
        {
            myOrder = new Order(wantedPizza);
        }

        private void ConfirmOrder()
        {
            myOrder.Confirm();            
        }

        private void PayTheBill()
        {
            int transfer = myOrder.bill;
            if(balance > transfer)
            {
                balance = -transfer;
                myOrder.payment = +transfer;
            }
            else
            {
                Console.WriteLine("Not enogh money to pay your order!");
            }
        }
    }

}
