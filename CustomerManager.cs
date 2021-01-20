using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public ArrayList customers = new ArrayList();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The customer " + customer.customerName + " " + customer.customerSurname + " is added.");
            ListCustomer();
        }
        public void ListCustomer()
        {
            Console.WriteLine("The customers are:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.customerName + " " + customer.customerSurname + " from " + customer.customerCity);
            }

        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            customers.Remove(customer);
            Console.WriteLine("The customer " + customer.customerName + " " + customer.customerSurname + " is deleted");
            ListCustomer();
        }

    }
}
