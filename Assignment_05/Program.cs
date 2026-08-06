using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Theoretical Questions
            #region Question01
            // 1-Class is reference type stored in heap and supports inheritance while struct is value type stored in stack and does not support inheritance
            // Class is better as it support inheritance , polymorphism and better for complex objects, it  avoid copying large amounts of data when passed 
            #endregion

            #region Question02
            // a- Shipment
            // b- ExpressShipment
            //c- it inherits from Shipment class the trackingCode property and it has the ExtraFee property so it contains both properties
            //d-It reduces code duplication , enhances maintainability and reusability of code allowing changes to be made in one place
            #endregion
            #endregion
            DeliveryCenter d = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Shipment {i + 1}");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                double fee = double.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int building = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress( street,city , building);

                Shipment shipment = new Shipment(trackingCode, description, weight,fee,address);

                if (d.AddShipment(shipment))
                    Console.WriteLine("Shipment Added.");
                else
                    Console.WriteLine("Delivery Center is Full.");
            }

            Console.WriteLine("\nStored Shipments:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(d[i]);
            }

            Console.Write("\nEnter Tracking Code: ");
            string code = Console.ReadLine();

            Shipment result = d[code];

            if (string.IsNullOrWhiteSpace(result.TrackingCode))
                Console.WriteLine("Shipment not found.");
            else
                Console.WriteLine(result);

            Console.WriteLine("\nDeliveryAddress Copy Demo");

            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Nasr Street", 12);

            DeliveryAddress address2 = address1;

            address2.city = "Alexandria";

            Console.WriteLine("Original:");
            Console.WriteLine(address1.GetFullAddress());

            Console.WriteLine("Copied:");
            Console.WriteLine(address2.GetFullAddress());
        
    }
    }
}
