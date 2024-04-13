using System;
using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers = new List<Customer>();
        private List<MenuItem> _menu = new List<MenuItem>();

        public void AddCustomer(Customer customer)
        { 
            _customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        {
            if(index < 0 || index >= _menu.Count)
            { 
                throw new IndexOutOfRangeException();
            }

            return _menu[index];
        }

        public void AddMenuItem(MenuItem item) 
        { 
            _menu.Add(item); 
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach(MenuItem item in _menu)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayOrderHistory(Customer customer) 
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: {order.GetTotal():F2}");

                foreach (var item in order.Items)
                {
                    Console.WriteLine($" {item}");
                }
            }
        }
    }
}