using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Provider
    {
        private string providerName;
        private string providerNumber;
        private string providerStreetAddress;
        private string providerCity;
        private string providerZipCode;

        Provider()
        {
            providerName = null;
            providerNumber = null;
            providerStreetAddress = null;
            providerCity = null;
            providerZipCode = null;
        }

        public bool SetProviderName(string name)
        {
            this.providerName = name;
            return true;
        }

        public bool SetProviderNumber(string number)
        {
            this.providerNumber = number;
            return true;
        }

        public bool SetStreetAddress(string address)
        {
            this.providerStreetAddress = address;
            return true;
        }

        public bool SetProviderCity(string city)
        {
            this.providerCity = city;
            return true;
        }

        public bool SetProviderZipCode(string zipCode)
        {
            this.providerZipCode = zipCode;
            return true;
        }
    }
}
