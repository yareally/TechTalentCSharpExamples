using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.InterfacesTestibility.Interfaces;

namespace CSharpDataTypes.InterfacesTestibility
{
    class OrderProcessor
    {
        private readonly IShippingCalculator shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)  // constructor
        {
            this.shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)  // defensive programming is good
                throw new InvalidOperationException("This order is already shipped");

            order.Shipment = new Shipment
            {
                Cost = shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)  // ship day after submitted
            };
        }
    }
}
