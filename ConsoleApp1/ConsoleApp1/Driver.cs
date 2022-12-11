using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Driver: Human
    {
        private int driversLicenseId;

        //public Driver(string name, int age, string sex) : base(name, age, sex)
        //{
        //}

        public int DriversLicenseId { get { return driversLicenseId; } set { driversLicenseId = value; } }
    }
}
