using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;
        private DeliveryAddress destination;
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public double DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
        public Shipment(string tCode)
        {
            TrackingCode = tCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("street1", "city1", 0);
        }
        public Shipment(string tCode, string desc, double w, double dFee, DeliveryAddress destination)
        {
            TrackingCode = tCode;
            Description = desc;
            Weight = w;
            DeliveryFee = dFee;
            Destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = (double)newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"EstimatedCost : {EstimatedCost}");
        }



    }
}
