using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer(1, "Nikhil Londhe");
            Console.WriteLine(customer.Id);
            var order = new Order();

            customer.Orders.Add(order);

            Console.WriteLine(customer.Name);
            
        }
    }
}
