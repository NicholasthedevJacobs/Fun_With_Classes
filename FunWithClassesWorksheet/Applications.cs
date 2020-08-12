using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesWorksheet
{
    class Applications
    {
        //member variables
        public string applicationName;
        public string applicationType;
        public double requiredRam;
        public double requiredStorage;

        //constructor
        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging Service";
            requiredRam = 4.0;  // in GB
            requiredStorage = 0.512;  //in GB
        }
    }
}
