using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.InterfacesTestibility.Interfaces;

namespace CSharpDataTypes.InterfacesTestibility
{
    class ShippingCalculator : IShippingCalculator
    {
        // we read this as ShippingCalculator implements IShippingCalculator
        // the cost of shipping depends on the value of the order
        public float CalculateShipping(Order order)
        {
            // if the price is under $30, the shipping cost
            // is 10% of the order's total price
            if (order.TotalPrice < 30f) {
                return order.TotalPrice * 0.1f;
            }
            // over $30? Shipping is free! yay!
            return 0;
        }
    }
}
