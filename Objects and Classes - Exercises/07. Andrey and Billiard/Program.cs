using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> BoughtProduct { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] shopProducts = Console.ReadLine().Split('-');
                if (shop.ContainsKey(shopProducts[0]))
                {
                    shop[shopProducts[0]] = decimal.Parse(shopProducts[1]);
                }
                else
                {
                    shop.Add(shopProducts[0], decimal.Parse(shopProducts[1]));
                }
            }

            string customers = Console.ReadLine();
            List<Customer> customerList = new List<Customer>();

            while (customers != "end of clients")
            {
                string[] custString = customers.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Customer customer = new Customer();
                customer.BoughtProduct = new Dictionary<string, int>();
                if (shop.ContainsKey(custString[1]))
                {
                    bool existStudent = false;
                    foreach (var item in customerList)
                    {
                        bool custExist = item.Name == custString[0];
                        if (custExist)
                        {
                            if (item.BoughtProduct.ContainsKey(custString[1]))
                            {
                                item.BoughtProduct[custString[1]] += int.Parse(custString[2]);
                                item.Bill += shop[custString[1]] * int.Parse(custString[2]);
                            }
                            else
                            {
                                item.BoughtProduct.Add(custString[1], int.Parse(custString[2]));
                                item.Bill += shop[custString[1]] * item.BoughtProduct[custString[1]];
                            }
                            existStudent = true;
                        }
                    }
                    if (!existStudent)
                    {
                        customer.Name = custString[0];
                        customer.BoughtProduct.Add(custString[1], int.Parse(custString[2]));
                        customer.Bill = shop[custString[1]] * customer.BoughtProduct[custString[1]];
                        customerList.Add(customer);
                    }
                }
                customers = Console.ReadLine();
            }

            var customersOrdered = customerList.OrderBy(x => x.Name);
            foreach (var item in customersOrdered)
            {
                Console.WriteLine(item.Name);
                foreach (var product in item.BoughtProduct)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {item.Bill:f2}");
            }
                
            Console.WriteLine($"Total bill: {customerList.Sum(x => x.Bill):f2}");
        }
    }
}
