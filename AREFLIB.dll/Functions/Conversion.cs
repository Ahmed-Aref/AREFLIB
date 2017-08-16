using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AREFLIB.Functions
{
    class Conversion
    {
        //Convert from Datatable to Array[string]
        public static string[,] DataTableToArray(DataTable DT)
        {
            int Row = DT.Rows.Count;
            int Coulmn = DT.Columns.Count;
            string[,] Array = new string[Row, Coulmn];

            for (int R = 0; R < Row; R++)
                for (int C = 0; C < Coulmn; C++)
                    Array[R, C] = DT.Rows[R][C].ToString();

            return Array;
        }

        //Convert from Array to DataTable
        public static DataTable ArrayToDatatable(string[,] Array, string[,] MetaTable,string DateFormat)
        {
            int Row = Array.GetLength(0);
            int Coulmn = Array.GetLength(1);
            DataTable DT = new DataTable();

            //Fill Colmns
            for (int i = 0; i < Coulmn; i++)
            {
                switch (MetaTable[0, i].ToLower())
                {
                    case "string":
                        DT.Columns.Add(MetaTable[1, i], typeof(string));
                        break;

                    case "int":
                        DT.Columns.Add(MetaTable[1, i], typeof(int));
                        break;

                    case "bool":
                        DT.Columns.Add(MetaTable[1, i], typeof(bool));
                        break;

                    case "datetime":
                        DT.Columns.Add(MetaTable[1, i], typeof(DateTime));
                        break;

                    default:
                        DT.Columns.Add(MetaTable[1, i], typeof(string));
                        break;
                }
            }

            //Fill Rows
            DataRow newRow;

            for (int R = 0; R < Row; R++) //Loop Rows
            {
                newRow = DT.NewRow();
                for (int C = 0; C < Coulmn; C++) //Loop Coulmns
                {
                    switch (MetaTable[0, C].ToLower())
                    {
                        case "string":
                            newRow[C] = Array[R, C].ToString();
                            break;

                        case "int":
                            newRow[C] = int.Parse(Array[R, C]);
                            break;

                        case "bool":
                            newRow[C] = bool.Parse(Array[R, C]);
                            break;

                        case "datetime":
                            newRow[C] = DateTime.ParseExact(Array[R, C], DateFormat, System.Globalization.CultureInfo.InvariantCulture);
                            break;

                        default:
                            newRow[C] = Array[R, C].ToString();
                            break;
                    }

                }

                DT.Rows.Add(newRow); //Add the row that we created
            }

            return DT;

        }
    }
}
