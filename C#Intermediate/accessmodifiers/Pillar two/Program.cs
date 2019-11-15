using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
                Console.ReadLine();
            }
                

            else
            {
                Console.WriteLine("Promoted to Level 2");
                Console.ReadLine();
            }
        }

          // had to change caculateRating class from private to protected to get main to work
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
