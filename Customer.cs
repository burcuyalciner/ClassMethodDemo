using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Customer
    {
        public Customer(string name, string surname, string type, string id, int age, string city)
        {
            customerName = name;
            customerSurname = surname;
            customerType = type;
            customerId = id;
            customerAge = age;
            customerCity = city;
        }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerType { get; set; }
        public string customerId { get; set; }
        public int customerAge { get; set; }
        public string customerCity { get; set; }

    }
}
