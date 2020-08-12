using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesWorksheet
{
    class CPU
    {
        //member variables
        public string manufacturer;
        public string name;

        //constructor
        public CPU()
        {
            
        }

        //member variables
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (hardDrive.availableStorage > app.requiredStorage && ram.totalGigabytes > app.requiredRam)
            {
                Console.WriteLine("Your computer's hardware is sufficient to install and run the program.");
            }
        }
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
