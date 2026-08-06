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

        public double EstimatedCost
        {
            get { return DeliveryFee + (double)ExtraFee + ((double)Weight * 5); }
        }
        #endregion

        #region Consrtuctor
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion


    }
}