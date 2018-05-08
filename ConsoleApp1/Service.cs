using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Service
    {
        private string serviceName;
        private float servicePrice;

        Service()
        {
            serviceName = null;
            servicePrice = 0;
        }

        public bool SetServiceName(string name)
        {
            this.serviceName= name;
            return true;
        }

        public bool SetServicePrice(float price)
        {
            this.servicePrice = price;
            return true;
        }
    }
}
