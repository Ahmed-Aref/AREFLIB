using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ServiceProcess;

namespace AREFLIB
{
    public static class IIS
    {
        //IIS Check
        public static bool IIS_Check(string IP) //false = Need restart
        {
            bool infobool, PulseAPIbool, StoreAPIbool = false;
            string infourl, PulseAPIurl, StoreAPIurl = "Free";

            try
            {
                using (WebClient client1 = new WebClient())
                {
                    infourl = client1.DownloadString("http://" + IP + ":59101/RemotePulseAPI/info.aspx"); infobool = true;
                }

            }
            catch
            { infobool = false; }

            try
            {
                using (WebClient client2 = new WebClient())
                {
                    PulseAPIurl = client2.DownloadString("http://" + IP + ":59101/RemotePulseAPI/RemotePulseAPI.WSDL"); PulseAPIbool = true;
                }
            }
            catch
            { PulseAPIbool = false; }

            try
            {
                using (WebClient client3 = new WebClient())
                {
                    StoreAPIurl = client3.DownloadString("http://" + IP + ":59105/Pulse/LiveDataApi/StoreApi.asmx"); StoreAPIbool = true;
                }

            }
            catch
            { StoreAPIbool = false; }

            if (infobool == false || PulseAPIbool == false || StoreAPIbool == false)
                return false;

            else
                return true;
        }

        //IIS Restart
        public static void IIS_Restart(string IP)
        {
            // Service List
            List<string> ilist = new List<string>();
            ilist.Add("W3SVC");
            ilist.Add("HTTPFilter");
            ilist.Add("WPFFontCache_v0400");
            ilist.Add("MSFtpsvc");
            ilist.Add("SMTPSVC");
            ilist.Add("WinHttpAutoProxySvc");
            ilist.Add("LmHosts");
            ilist.Add("W3SVC");
            ilist.Add("IISADMIN");

            foreach (string iService in ilist) // Loop through List with foreach.
            {
                ServiceController sc = new ServiceController(iService, IP);
                try
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);
                }
                catch { }
            }

            foreach (string iService in ilist) // Loop through List with foreach.
            {
                ServiceController sc = new ServiceController(iService, IP);
                try
                {
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                }
                catch { }
            }
        }

        //Service_Start
        public static void Service_Start(string IP, string Service_Name)
        {
            ServiceController sc = new ServiceController(Service_Name, IP);
            try
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
            }
            catch { }
        }

        //Service_Start
        public static void Service_Stop(string IP, string Service_Name)
        {
            ServiceController sc = new ServiceController(Service_Name, IP);
            try
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            catch { }
        }
    }
}

    
