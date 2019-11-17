using System;

namespace Testability
{
    public class OrderProcessor
    
    {
        private readonly IShippingCalculator _shippingCalculator;

        // constructor
        public OrderProcessor(IShippingCalculator shippingCalculator)  
        {
            //use constructor
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            // defensive programming, throw exception
            if (order.IsShipped)  
                throw new InvalidOperationException("This order is already shipped");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                // ship day after submitted
                ShippingDate = DateTime.Today.AddDays(1)  
            };
        }
    }
}