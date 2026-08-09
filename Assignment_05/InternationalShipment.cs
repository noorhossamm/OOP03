using System;

namespace Assignment_05
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + (double)CustomsFee;
            }
        }


        public InternationalShipment(string trackingCode,
                                     string description,
                                     double weight,
                                     double deliveryFee,
                                     DeliveryAddress destination,
                                     string destinationCountry,
                                     decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Description         : {Description}");
            Console.WriteLine($"Weight              : {Weight} ");
            Console.WriteLine($"Delivery Fee        : {DeliveryFee} ");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} ");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report: {TrackingCode} - {DestinationCountry} - Customs Fee: {CustomsFee} ");
        }
    }
}
