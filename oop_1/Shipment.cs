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

        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("alex", "default Street", 1))
        {
        }
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
            this.weight = weight > 0 ? weight : 1;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
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

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"tracking code:  {trackingCode}");
            Console.WriteLine($"description:  {description}");
            Console.WriteLine($"weight:  {weight} kg");
            Console.WriteLine($"delivery fee:  {deliveryFee:C}");
            Console.WriteLine($"destination:  {Destination.GetFullAddress()}");
            Console.WriteLine($"estimated cost:  {GetEstimatedCost():C}");
        }
    }
}
