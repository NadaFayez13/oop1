using System;
using System.Collections.Generic;
using System.Text;

namespace oop_1
{
    public struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            this.description = string.IsNullOrWhiteSpace(description) ? "No Description" : description;
            this.weight = weight > 0 ? weight : 1.0;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 10.0m;
            Destination = destination;
        }


        public string GetTrackingCode()
        {
            return trackingCode;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double value)
        {
            if (value > 0)
            {
                weight = value;
            }
        }

        public decimal GetDeliveryFee()
        {
            return deliveryFee;
        }

        private void SetDeliveryFee(decimal value)
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }

        public decimal GetEstimatedCost()
        {
            return deliveryFee + ((decimal)weight * 5m);
        }
    }
}
