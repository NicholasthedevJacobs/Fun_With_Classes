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
            //add app to the list on hard drive
            ram.totalGigabytes -= app.requiredRam;
            hardDrive.availableStorage -= app.requiredStorage;
            hardDrive.applicationsInHardDrive.Add(app);
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool canRunProgram = false;
            if (hardDrive.availableStorage > app.requiredStorage && ram.totalGigabytes > app.requiredRam)
            {
                canRunProgram = true;
                Console.WriteLine("Your computer's hardware is sufficient to install and run the program.");
                return canRunProgram;
            }
            else
            {
                canRunProgram = false;
                return canRunProgram;
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
