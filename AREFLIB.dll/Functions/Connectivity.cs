using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace AREFLIB
{
    public static class Connectivity
    {

        //Read Connection From AREFCONN
        public static void GET_CONN(string Password)
        {
            AREFLIB.Variables.Server_username = Conn_Keys.Server_username_Request(Password);
            AREFLIB.Variables.Server_password = Encryption.DecryptString(Conn_Keys.Server_password_Request(Password));
            AREFLIB.Variables.Server_IP = Conn_Keys.Server_IP_Request(Password);
            AREFLIB.Variables.Server_database = Conn_Keys.Server_database_Request(Password);

            AREFLIB.Variables.Store_SQLusername = Conn_Keys.Store_SQLusername_Request(Password);
            AREFLIB.Variables.Store_SQLpassword = Encryption.DecryptString(Conn_Keys.Store_SQLpassword_Request(Password));
            AREFLIB.Variables.Store_SQLdatabase = Conn_Keys.Store_SQLdatabase_Request(Password);

            AREFLIB.Variables.Store_Loginusername = Conn_Keys.Store_Loginusername_Request(Password);
            AREFLIB.Variables.Store_Loginpassword = Encryption.DecryptString(Conn_Keys.Store_Loginpassword_Request(Password));

            AREFLIB.Variables.HOST_Loginusername = Conn_Keys.HOST_Loginusername_Request(Password);
            AREFLIB.Variables.HOST_Loginpassword = Encryption.DecryptString(Conn_Keys.HOST_Loginpassword_Request(Password));
        }

        //Ping
        public static bool Ping(string IP, int Time_Out)
        {
            Ping Ping = new Ping();
            bool result = false;

            try
            {
                PingReply iPingReplay = Ping.Send(IP, Time_Out);
                if (iPingReplay.Status == IPStatus.Success)
                    result = true;
            }
            catch { }

            return result;
        } //true = Pinging

        //Start CMD_Ping
        public static void CMD_Ping(string IP)
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c Ping " + IP);
            Process.Start(start);
        }

        //Start CMD_Ping_T
        public static void CMD_Ping_T(string IP)
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c Ping " + IP + " -t");
            Process.Start(start);
        }

        //RDP Admin
        public static void RDP_Admin(string IP, string User_Name, string Password)
        {
            String szCmd = "/c cmdkey.exe /add:" + IP + "/admin /user:" + User_Name + " /pass:" + Password + "& mstsc.exe /v " + IP + " /admin";
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe", szCmd);
            Process proc = new Process();
            proc.StartInfo = info;
            proc.Start();
        }

        //RDP 
        public static void RDP(string IP)
        {
            String szCmd = "/c cmdkey.exe /add:" + IP + "& mstsc.exe /v " + IP;
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe", szCmd);
            Process proc = new Process();
            proc.StartInfo = info;
            proc.Start();
        }

        // Increase IP
        public static string IP_Increment(string IP, int increment)
        {
            return IP.Split('.')[0] + "." + IP.Split('.')[1] + "." + IP.Split('.')[2] + "." + (int.Parse(IP.Split('.')[3]) + increment);
        }

    }
}
