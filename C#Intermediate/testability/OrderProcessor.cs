using System;

namespace Testability
{
    public class OrderProcessor
    
    {
        private readonly ShippingCalculator _shippingCalculator;
        
        public OrderProcessor()  // constructor
        {
            _shippingCalculator = new ShippingCalculator();
        }
        public void Process(Order order)
        {
            if (order.IsShipped)  // defensive programming is good
                throw new InvalidOperationException("This order is already shipped");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)  // ship day after submitted
            };
        }
    }
}