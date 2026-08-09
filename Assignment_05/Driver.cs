using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05
{
    internal class Driver
    {
        public int DriverId;
        public string FullName;
        public string PhoneNumber;

        public Driver(int driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
