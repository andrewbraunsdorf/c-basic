namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    // this is NOT inheritance
    public class ShippingCalculator : IShippingCalculator  
    {  // we read this as ShippingCalculator implements IShippingCalculator
        // the cost of shipping depends on the value of the order
        // if $30 or less 10% of order otherwise its free
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}