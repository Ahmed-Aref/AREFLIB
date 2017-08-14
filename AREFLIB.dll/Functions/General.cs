using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.IO;

namespace AREFLIB
{
    public static class General
    {
        //Join two Arrays
        public static string[,] Join_Array(string[,] Array1, string[,] Array2)
        {
            string[,] Big_Array = new string[(Array1.GetLength(0) + Array2.GetLength(0)), Array1.GetLength(1)];

            // Fill First Array
            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                for (int u = 0; u < Array1.GetLength(1); u++)
                {
                    Big_Array[i, u] = Array1[i, u];
                }
            }

            // Fill Second Array
            int A1L = Array1.GetLength(0);
            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int u = 0; u < Array2.GetLength(1); u++)
                {
                    Big_Array[(i + A1L), u] = Array2[i, u];
                }
            }

            return Big_Array;
        }

        //Open Link on Browser
        public static void Browser_URL(string URL)
        {
            System.Diagnostics.Process.Start(URL);
        }

        //Check if App is already_running
        public static bool Already_Runing()
        {
            string ProcName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(ProcName);
            if (processes.Length > 1) { return true; }
            else { return false; }
        }

        //Create CSV File
        public static void Create_CSV(DataTable DT, string strFilePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFilePath, false);

                // First we will write the headers.
                //DataTable dt = m_dsProducts.Tables[0];

                int iColCount = DT.Columns.Count;
                for (int i = 0; i < iColCount; i++)
                {
                    sw.Write(DT.Columns[i]);
                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);

                // Now write all the rows.

                foreach (DataRow dr in DT.Rows)
                {
                    for (int i = 0; i < iColCount; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                            sw.Write(dr[i].ToString());

                        if (i < iColCount - 1)
                            sw.Write(",");
                    }

                    sw.Write(sw.NewLine);
                }
                sw.Close();
            }
            catch { }
        }

        //Close The GUI_App
        public static void Close_GUI_APP()
        {
            System.Windows.Forms.Application.Exit();
        }

        //Register a DLL
        public static void DLLRegister(string DLLPath,bool UnRegist)
        {
            ProcessStartInfo Proc = new ProcessStartInfo();
            Process pStart = new Process();
            Proc.UseShellExecute = true;

            string Command = @" Regsvr32 -s " + "\"" + DLLPath + "\"";

            if(UnRegist)
                Command = @" Regsvr32 -u -s " + "\"" + DLLPath + "\"";

            Proc.Arguments = "/c " + Command;
            pStart = Process.Start(Proc);
            pStart.WaitForExit();
        }
    }
}