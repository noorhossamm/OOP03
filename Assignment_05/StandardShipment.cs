using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode) : base(trackingCode)
        {

        }

        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} ");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} ");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} ");
        }
    }
}
