using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AREFLIB
{
    public static class SQL
    {

        //Read From main server
        public static string[,] Read_From_Server(String Query)
        {
            DataTable dt = new DataTable();
            string[,] Array = new String[0, 0];

            int Rows = 0;
            int Coulmn = 0;

            //The Connection String to make a connection
            string connectionString = "Server=" + AREFLIB.Variables.Server_IP + "; Database=" + AREFLIB.Variables.Server_database + "; User Id=" + AREFLIB.Variables.Server_username + "; Password=" + AREFLIB.Variables.Server_password + "; TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connection);
                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                    Rows = dt.Rows.Count;
                    Coulmn = dt.Columns.Count;

                    Array = new String[Rows, Coulmn];

                    for (int i = 0; i < Rows; i++)
                    {
                        for (int u = 0; u < Coulmn; u++)
                        {
                            Array[i, u] = dt.Rows[i][u].ToString();
                        }
                    }
                }
                catch { }

                return Array;
            }
        }

        //Read to Array
        public static string[,] SQLQuery_Arry(String Query, string IP)
        {
            DataTable dt = new DataTable();
            string[,] Array = new String[0, 0];

            int Rows = 0;
            int Coulmn = 0;

            //The Connection String to make a connection
            string connectionString = "Server=" + IP + "; Database=" + AREFLIB.Variables.Store_SQLdatabase + "; User Id=" + AREFLIB.Variables.Store_SQLusername + "; Password=" + AREFLIB.Variables.Store_SQLpassword + "; TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connection);
                    connection.Open();

                    dt.Load(command.ExecuteReader());
                    connection.Close();

                    Rows = dt.Rows.Count;
                    Coulmn = dt.Columns.Count;

                    Array = new String[Rows, Coulmn];

                    for (int i = 0; i < Rows; i++)
                    {
                        for (int u = 0; u < Coulmn; u++)
                            Array[i, u] = dt.Rows[i][u].ToString();
                    }
                }
                catch { }

                return Array;
            }
        }

        //Read to DT
        public static DataTable SQLQuery_DT(String Query, string IP)
        {
            //The Connection String to make a connection
            string connectionString = "Server=" + IP + ";Database=" + AREFLIB.Variables.Store_SQLdatabase + ";User Id=" + AREFLIB.Variables.Store_SQLusername + ";Password=" + AREFLIB.Variables.Store_SQLpassword + ";TrustServerCertificate=True";
            DataTable dt = new DataTable();

            // Send Query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connection);
                    connection.Open();

                    try
                    {
                        dt.Load(command.ExecuteReader());
                        connection.Close();
                    }
                    catch { } // Unkown error 
                }
                catch { } // Means wrong Username and Passsword
            }
            return dt;
        }

        //Read Stores
        public static void Read_Stores(bool ksa_only)
        {
            string Query = "";
            if (ksa_only == true)
            {
                // Read All Stores
                Query = @"SELECT STR.Store_Number,STR.Store_Name,STR.Store_IP,STR.Region_ID,
                             STR.Store_Lat,STR.Store_Long,STR.Meraki_Serial 
                             FROM Store as STR
                             WHERE Region_ID in (1,2,3,4,5,10) and STR.Store_Active = 1 ORDER BY Store_Number";
            }
            else
            {
                Query = @"SELECT STR.Store_Number,STR.Store_Name,STR.Store_IP,STR.Region_ID,
                                 STR.Store_Lat,STR.Store_Long,STR.Meraki_Serial 
                                 FROM Store as STR
                                 WHERE ISNUMERIC(STR.Store_Number) <> 0 and  STR.Store_Active = 1 ORDER BY Store_Number";
            }

            AREFLIB.Variables.Store_Array = AREFLIB.SQL.Read_From_Server(Query);

            Query = @"SELECT Region_ID,Region_Name FROM Region";
            AREFLIB.Variables.Region_Array = AREFLIB.SQL.Read_From_Server(Query);
        }
    }
}
