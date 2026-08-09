using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode,string description,double weight,double deliveryFee, DeliveryAddress destination,string destinationCountry,decimal customsFee)
    : base(trackingCode,description,weight,deliveryFee,destination,destinationCountry,customsFee)
        {
        }

    }
}
