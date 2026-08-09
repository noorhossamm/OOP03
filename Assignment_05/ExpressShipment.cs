using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;


        #region property
        public decimal ExtraFee
        {
            get { return extraFee; }
            set { extraFee = value >= 0 ? value : 0; }
        }

        #endregion

        #region Consrtuctor
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion

        public override double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + (double)ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} ");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} ");
            Console.WriteLine($"Extra Fee     : {ExtraFee} ");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }


    }
}