using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.InterfacesTestibility
{
    class Order
    {
        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped {
            get { return Shipment != null; }
        }
    }
}
