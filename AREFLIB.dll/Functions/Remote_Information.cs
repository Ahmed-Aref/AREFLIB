using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ConnectUNCWithCredentials;
using RemoteSysInformation;

namespace AREFLIB
{
    public static class Remote_Information
    {
        //using System.Runtime.InteropServices;
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

        //Get Computer Info
        public static SystemInformation Get_Info(string IP, string User_Name, string Password)
        {
            RemoteSysInformation.SystemInformation sysinfo = new RemoteSysInformation.SystemInformation();
            sysinfo.stderr = Console.OpenStandardOutput();

            try
            {
                if (sysinfo.Get(IP, User_Name, Password) != 0)
                {
                }
                else
                {
                    return sysinfo;
                }
            }
            catch { }

            return sysinfo;
        }

        //Get HDD Info
        public static string[] HDD_Info(string IP, string User_Name, string Password)
        {
            string[] HDD_Arr = new string[2];
            try
            {
                ulong freeSpaceInBytes = 0;
                ulong notUsed = 0;
                ulong notUsed2 = 0;

                GetDiskFreeSpaceEx(@"\\" + IP + @"\c$", out freeSpaceInBytes, out notUsed, out notUsed2);

                HDD_Arr[0] = (freeSpaceInBytes / 1073741824).ToString();
                HDD_Arr[1] = (notUsed / 1073741824).ToString();
            }
            catch { }

            return HDD_Arr;
        }

        //UNC Access
        public static void UNC_Access(string IP, string User_Name, string Password)
        {
            using (UNCAccessWithCredentials unc = new UNCAccessWithCredentials())
            {
                if (unc.NetUseWithCredentials(@"\\" + IP + @"\c$", User_Name, "local", Password))
                { }
            }
        }
    }
}
