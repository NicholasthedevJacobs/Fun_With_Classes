using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesWorksheet
{
    class HardDrive
    {
        //member variables
        public double totalStorage;
        public double availableStorage;
        public List<Applications> applicationsInHardDrive;

        //constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            applicationsInHardDrive = new List<Applications>();
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
            
            

        }

        //member methods
        
    }

    
}
        
