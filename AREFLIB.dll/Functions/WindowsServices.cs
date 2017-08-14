using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceProcess;
using System.Diagnostics;

namespace AREFLIB.Functions
{
    class WindowsServices
    {
        //Restart a service
        public static void ServiceRestart(ServiceController controller)
        {
            List<ServiceController> dependencies = new List<ServiceController>();
            FillDependencyTreeLeaves(controller, dependencies);
            controller.Stop();
            controller.WaitForStatus(ServiceControllerStatus.Stopped);
            foreach (ServiceController dependency in dependencies)
            {
                try
                {
                    dependency.Start();
                    dependency.WaitForStatus(ServiceControllerStatus.Running);
                }
                catch { }
            }
        }
        //This one used for ServiceRestart Function
        public static void FillDependencyTreeLeaves(ServiceController controller, List<ServiceController> controllers)
        {
            bool dependencyAdded = false;
            foreach (ServiceController dependency in controller.DependentServices)
            {
                ServiceControllerStatus status = dependency.Status;
                // add only those that are actually running
                if (status != ServiceControllerStatus.Stopped && status != ServiceControllerStatus.StopPending)
                {
                    dependencyAdded = true;
                    FillDependencyTreeLeaves(dependency, controllers);
                }
            }
            // if no dependency has been added, the service is dependency tree's leaf
            if (!dependencyAdded && !controllers.Contains(controller))
            {
                controllers.Add(controller);
            }
        }

        //Stop Windows Service
        public static void ServiceControl(string ServiceName,bool Stop)
        {
            ProcessStartInfo Proc = new ProcessStartInfo();
            Process pStart = new Process();
            Proc.UseShellExecute = true;

            string Command = @" net start " + ServiceName + " /yes";

            if(Stop)
                Command = @" net stop " + ServiceName + " /yes";
            
            Proc.Arguments = "/c " + Command;
            pStart = Process.Start(Proc);
            pStart.WaitForExit();
        }
    }
}
