using System;
using System.Collections;


namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager myCustomerManager = new CustomerManager();
            Customer customer1 = new Customer("Ayşe", "Balcı", "Gold", "12345", 25, "Ankara");
            myCustomerManager.AddCustomer(customer1);
            Customer customer2 = new Customer("Ahmet", "Korkut", "Bronz", "54321", 28, "İzmir");
            myCustomerManager.AddCustomer(customer2);
            Customer customer3 = new Customer("Leyla", "Sönmez", "Platinum", "85462", 35, "Antalya");
            myCustomerManager.AddCustomer(customer3);
            Customer customer4 = new Customer("Sevgi", "Eryılmaz", "Bronz", "74526", 45, "Diyarbakır");
            myCustomerManager.AddCustomer(customer4);

            myCustomerManager.ListCustomer();

            Customer customer5 = new Customer("Ali", "Kısa", "Gold", "85412", 52, "Muş");
            myCustomerManager.AddCustomer(customer5);

            //Delete the customer3 from the list
            myCustomerManager.DeleteCustomer(customer3);

            //Delete the customer3 from the list
            myCustomerManager.DeleteCustomer(customer2);

        }
    }
}
