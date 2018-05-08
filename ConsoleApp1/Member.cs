using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Member 
    {
        private string memberName;
        private string memberNumber;
        private string memberStreetAddress;
        private string memberCity;
        private string memberZipCode;

        Member()
        {
            memberName = null;
            memberNumber = null;
            memberStreetAddress = null;
            memberCity = null;
            memberZipCode = null;
        }

        public bool SetProviderName(string name)
        {
            this.memberName = name;
            return true;
        }

        public bool SetProviderNumber(string number)
        {
            this.memberNumber = number;
            return true;
        }

        public bool SetStreetAddress(string address)
        {
            this.memberStreetAddress = address;
            return true;
        }

        public bool SetProviderCity(string city)
        {
            this.memberCity = city;
            return true;
        }

        public bool SetProviderZipCode(string zipCode)
        {
            this.memberZipCode = zipCode;
            return true;
        }
    }
}
