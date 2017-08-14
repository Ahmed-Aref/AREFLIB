using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AREFLIB
{
    public static class SQL
    {
        //Perform Local SQL Query
        public static DataTable SQLQueryLocal(string Query)
        {
            DataTable DT;

            using (SqlConnection connection = new SqlConnection("Server= localhost; Database= master;Integrated Security=SSPI;"))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                connection.Open();
                DT = new DataTable();
                DT.Load(command.ExecuteReader());
                connection.Close();
            }
            return DT;
        }

        //Perform SQL Query to Remote Server and Return DataTable
        public static DataTable SQLRemoteQueryDT(string Query, string IP, string DB, string Username, string Password)
        {
            //The Connection String to make a connection
            string connectionString = "Server=" + IP + ";Database=" + DB + ";User Id=" + Username + ";Password=" + Password + ";TrustServerCertificate=True";
            DataTable DT = new DataTable();

            // Send Query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                connection.Open();

                DT.Load(command.ExecuteReader());
                connection.Close();
            }
            return DT;
        }

        //Perform SQL Query to Remote Server and Return Array of Strings
        public static string[,] SQLRemoteQueryArray(string Query, string IP, string DB, string Username, string Password)
        {
            DataTable DT = new DataTable();
            string[,] Array = new String[0, 0];

            int Rows = 0;
            int Coulmn = 0;

            //The Connection String to make a connection
            string connectionString = "Server=" + IP + ";Database=" + DB + ";User Id=" + Username + ";Password=" + Password + ";TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connection);
                    connection.Open();

                    DT.Load(command.ExecuteReader());
                    connection.Close();

                    Rows = DT.Rows.Count;
                    Coulmn = DT.Columns.Count;

                    Array = new String[Rows, Coulmn];

                    for (int i = 0; i < Rows; i++)
                        for (int u = 0; u < Coulmn; u++)
                            Array[i, u] = DT.Rows[i][u].ToString();
                }
                catch { }

                return Array;
            }
        }

    }
}
