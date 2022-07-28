using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //default constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        //overload constructor
        public Customer(int id)
            :this()
        {
            this.Id = id;
            
        }

        //overload constructor
        public Customer(int id, string name)
            :this()
        {  
            this.Id=id;
            this.Name = name;
        }
    }
}
