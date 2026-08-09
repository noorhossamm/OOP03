using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using System.Xml.Linq;
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
            //DeliveryCenter center = new DeliveryCenter();

            //Console.Write("Enter Center Name: ");
            //center.CenterName = Console.ReadLine();



            //Console.WriteLine("\nStandard Shipment");

            //Console.Write("Tracking Code: ");
            //string code = Console.ReadLine();

            //Console.Write("Description: ");
            //string desc = Console.ReadLine();

            //Console.Write("Weight: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //double fee = double.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //string city = Console.ReadLine();

            //Console.Write("Street: ");
            //string street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int building = int.Parse(Console.ReadLine());

            //DeliveryAddress address = new DeliveryAddress(street, city, building);

            //StandardShipment s1 =
            //    new StandardShipment(code, desc, weight, fee, address);

            //center.AddShipment(s1);


            //Console.WriteLine("\nExpress Shipment");

            //Console.Write("Tracking Code: ");
            //code = Console.ReadLine();

            //Console.Write("Description: ");
            //desc = Console.ReadLine();

            //Console.Write("Weight: ");
            //weight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //fee = double.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //city = Console.ReadLine();

            //Console.Write("Street: ");
            //street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //building = int.Parse(Console.ReadLine());

            //Console.Write("Extra Fee: ");
            //decimal extra = decimal.Parse(Console.ReadLine());

            //address = new DeliveryAddress(street, city, building);
            //ExpressShipment s2 =
            //    new ExpressShipment(extra, code, desc, weight, fee, address);

            //center.AddShipment(s2);

            //Console.WriteLine("\nInternational Shipment");

            //Console.Write("Tracking Code: ");
            //code = Console.ReadLine();

            //Console.Write("Description: ");
            //desc = Console.ReadLine();

            //Console.Write("Weight: ");
            //weight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //fee = double.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //city = Console.ReadLine();

            //Console.Write("Street: ");
            //street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //building = int.Parse(Console.ReadLine());

            //Console.Write("Destination Country: ");
            //string country = Console.ReadLine();

            //Console.Write("Customs Fee: ");
            //decimal customs = decimal.Parse(Console.ReadLine());

            //address = new DeliveryAddress(street, city, building);

            //InternationalShipment s3 =
            //    new InternationalShipment(code, desc, weight, fee, address, country, customs);

            //center.AddShipment(s3);



            //Console.WriteLine("\nAll Shipments");
            //center.PrintAllShipments();


            //Console.Write("\nEnter Tracking Code To Search: ");
            //string search = Console.ReadLine();

            //Shipment found = center[search];

            //if (found != null)
            //    found.PrintShipment();
            //else
            //    Console.WriteLine("Shipment not found.");


            //Console.Write("\nEnter Tracking Code To Remove: ");
            //string remove = Console.ReadLine();

            //if (center.RemoveShipment(remove))
            //    Console.WriteLine("Shipment Removed.");
            //else
            //  Console.WriteLine("Shipment Not Found.");
            //Console.WriteLine("\nRemaining Shipments");
            //center.PrintAllShipments();


            // Practical Questions (Assignment 3)
            #region Question01
            //part1

            // Method Overloading is having multiple methods with the same name but different parameters in the same class. It is compile-time polymorphism.
            // Method Overriding: A derived class provides a new implementation for a method inherited from the base class. It is run-time polymorphism
            //-----------------------------------
            // Static Binding: The method call is determined at compile time. It is commonly used with method overloading.
            // Dynamic Binding: The method call is determined at run time based on the actual object type. It is used with method overriding

            //part2
            //a)Prevents a class from being inherited by another class. It stops the inheritance chain completely.
            //b)Sealed class: Prevents other classes from inheriting from it.
            //Sealed method: Prevents further derived classes from overriding that method
            // c) No. A sealed method cannot be overridden because the sealed keyword prevents any further overriding of that method
            #endregion

            Driver driver = new Driver( 123, "Ahmed Omar","010");

            DeliveryCenter c = new DeliveryCenter();
            c.CenterName = "Smart Delivery";
            c.Driver = driver;


            #region Standard Shipment
            DeliveryAddress address1 = new DeliveryAddress("Street 1", "Cairo", 10);
            StandardShipment ss1 = new StandardShipment("SH001", "Laptop", 3, 80, address1);
            #endregion


            #region Express Shipment
            DeliveryAddress address2 =new DeliveryAddress("Street 2", "Giza", 20);
            ExpressShipment ss2 = new ExpressShipment(30, "SH002", "Mobile Phone", 2,60,address2);
            #endregion


            #region International Shipment
            DeliveryAddress address3 =new DeliveryAddress("Street 3", "Alexandria", 30);
            InternationalShipment ss3 =new InternationalShipment("SH003","Television",8,120, address3,"Germany",100);
            #endregion


            #region Add Shipments
            c.AddShipment(ss1);
            c.AddShipment(ss2);
            c.AddShipment(ss3);
            #endregion


            #region Print Shipments
            Console.WriteLine("------------------------------------------");
            c.PrintAllShipments();
            #endregion


            #region DeliveryHelper
            Console.WriteLine("Printing DeliveryHelper...");
            Console.WriteLine("------------------------------------------");

            DeliveryHelper.PrintShipmentDetails(ss1);

            DeliveryHelper.PrintShipmentDetails(ss2);

            DeliveryHelper.PrintShipmentDetails(ss3);

            #endregion


            #region Weight Update
            Console.WriteLine(" Weight:- ");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"Original Weight : {ss1.Weight} ");
            ss1.UpdateWeight(5);
            Console.WriteLine( $"Updated Weight : {ss1.Weight}");


            ss1.UpdateWeight(5, 0.5);
            Console.WriteLine($"Updated Weight: {ss1.Weight}");
            #endregion


            Console.WriteLine();
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("==========================================");

            Shipment[] shipments =
            {
                ss1,
                ss2,
                ss3
            };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }


            #region Sealed Class
            // another class cannot inherit from it.

            CompletedShipment completedShipment =
                new CompletedShipment(
                    "SH004",
                    "Computer",
                    4,
                    90,
                    new DeliveryAddress(
                        "Street 4",
                        "Cairo",
                        40));

            #endregion


            #region Sealed Method

            PriorityInternationalShipment priorityShipment =new PriorityInternationalShipment("SH005","Camera",5,150,new DeliveryAddress(
                        "Street 5",
                        "Cairo",
                        50),"France", 120);

            priorityShipment.GenerateCustomsReport();

            #endregion
        }


    }
    }



