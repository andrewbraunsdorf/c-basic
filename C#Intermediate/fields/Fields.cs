using System.Collections.Generic;


namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        // no matter what constructor called the list has a already been initialized
        public List<Order> Orders = new List<Order>();



        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
