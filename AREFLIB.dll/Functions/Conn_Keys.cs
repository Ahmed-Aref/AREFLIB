using System;
using System.Collections.Generic;
using System.Text;

namespace AREFLIB
{
    public static class Conn_Keys
    {
        private static string Server_username = "DD";
        private static string Server_password = "Bn1zG7q7cx3AUo5GWC6Ykg==";
        private static string Server_IP = "192.168.80.80";
        private static string Server_database = "Dominos_Data";

        private static string Store_SQLusername = "sa";
        private static string Store_SQLpassword = "AACakmzsniDLYF2xq+Erbg==";
        private static string Store_SQLdatabase = "POS";

        private static string Store_Loginusername = "Support";
        private static string Store_Loginpassword = "AACakmzsniDLYF2xq+Erbg==";

        private static string HOST_Loginusername = "Administrator";
        private static string HOST_Loginpassword = "8Wd5gvYpTvpvS4hgr3upVA==";

        public static string Server_username_Request(string password)
        {
            if (password == "My*pA$worD")
                return Server_username;

            else
                return "Null";
        }

        public static string Server_password_Request(string password)
        {
            if (password == "My*pA$worD")
                return Server_password;

            else
                return "Null";
        }

        public static string Server_IP_Request(string password)
        {
            if (password == "My*pA$worD")
                return Server_IP;

            else
                return "Null";
        }

        public static string Server_database_Request(string password)
        {
            if (password == "My*pA$worD")
                return Server_database;

            else
                return "Null";
        }

        public static string Store_SQLusername_Request(string password)
        {
            if (password == "My*pA$worD")
                return Store_SQLusername;

            else
                return "Null";
        }

        public static string Store_SQLpassword_Request(string password)
        {
            if (password == "My*pA$worD")
                return Store_SQLpassword;

            else
                return "Null";
        }

        public static string Store_SQLdatabase_Request(string password)
        {
            if (password == "My*pA$worD")
                return Store_SQLdatabase;

            else
                return "Null";
        }

        public static string Store_Loginusername_Request(string password)
        {
            if (password == "My*pA$worD")
                return Store_Loginusername;

            else
                return "Null";
        }

        public static string Store_Loginpassword_Request(string password)
        {
            if (password == "My*pA$worD")
                return Store_Loginpassword;

            else
                return "Null";
        }

        public static string HOST_Loginusername_Request(string password)
        {
            if (password == "My*pA$worD")
                return HOST_Loginusername;

            else
                return "Null";
        }

        public static string HOST_Loginpassword_Request(string password)
        {
            if (password == "My*pA$worD")
                return HOST_Loginpassword;

            else
                return "Null";
        }

    }
}
