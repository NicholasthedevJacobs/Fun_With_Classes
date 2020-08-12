using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesWorksheet
{
    class Motherboard
    {
        //member variables
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        //constructor
        public Motherboard(string manufacturer, CPU processor, RAM temporaryMemory, HardDrive hardDrive, GPU gpu)
        {
            Applications slack = new Applications("Slack", "Messaging Service", 4.0, 0.512);
            
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            storage = hardDrive;
            graphics = gpu;
        }

        //member methods
        public void InstallApplication(Applications application)
        {

            if (temporaryMemory.totalGigabytes > application.requiredRam)
            {
                storage.applicationsInHardDrive.Add(application);
            }
            else
            {
                Console.WriteLine("Not enough RAM to run program");
            }


        }
    }

}
