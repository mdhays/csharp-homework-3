using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Agency
    {
        private string agencyName;
        private string country;
        private int organizationSize;

        public string AgencyName
        {
            get { return agencyName; }
            set { agencyName = value; }
        }
        
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int OrganizationSize
        {
            get { return organizationSize; }
            set { organizationSize = value; }
        }

        public string GetAgencyInfo()
        {
            string message = "";

            return message;
        }
    }
}
