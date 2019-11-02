using System.Collections.Generic;

namespace CSharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
        // means we will call Customer() without any parameters
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        // first it is going to call the Customer(int id) first
            : this(id)
        {
            this.Name = name;
        }

        
    }
}