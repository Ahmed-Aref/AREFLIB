using System;
using System.Collections.Generic;
using System.Text;

namespace AREFLIB.Functions
{
    class String_Func
    {

        //Make Text in Middle
        public static string Text_in_Middle(string Text, int Total_Char)
        {
            string result = Text;
            int Free = Convert.ToInt32((Total_Char - Text.Length) / 2);

            for (int i = 0; i < Free; i++)
            {
                result = " " + result;
            }
            return result;
        }

        //Add new line before Text
        public static string Add_new_line(string Text, int lines_number)
        {
            string result = Text;
            for (int i = 0; i < lines_number; i++)
            {
                Text = "\n" + Text;
            }
            return Text;
        }

        //Create Menu Lines
        public static string Create_Menu_Line(string English, string Arabic, int Count, string Price, int LineLength)
        {
            string Result = "";
            int MaxLength = LineLength - (9 + Price.ToString().Length);

            string[] words = English.Split(' ');
            StringBuilder line = new StringBuilder();

            if (Count == 0)
            {
                Result += "    ";
            }
            else
            {
                Result += Count + "x";
                for (int i = 0; i < (3 - Count.ToString().Length); i++)
                {
                    Result += " ";
                }
            }

            int rows_count = 0;
            for (int index = 0; index < words.GetLength(0); index++)
            {
                if (words[index].Length + line.Length <= MaxLength)
                {
                    line.Append(words[index] + " ");
                }
                else
                {
                    if (line.Length > 0)
                    {
                        if (rows_count == 0)
                        {
                            Result += line.ToString().Trim();
                            for (int x = 0; x < MaxLength - line.ToString().Trim().Length; x++)
                                Result += " ";

                            Result += "  " + Price + " SR\n";
                        }
                        else Result += "    " + line.ToString().Trim() + "\n";

                        line = new StringBuilder();
                        rows_count++;
                    }

                    string overflow = words[index];
                    while (overflow.Length > MaxLength)
                    {
                        Result += overflow.Substring(0, MaxLength);
                        overflow = overflow.Substring(MaxLength);
                    }
                    line.Append(overflow + " ");
                }

            }
            if (rows_count == 0)
            {
                Result += line.ToString().Trim();

                for (int x = 0; x < MaxLength - line.ToString().Trim().Length; x++)
                    Result += " ";
                Result += "  " + Price + " SR\n";
            }
            else
                Result += "    " + line.ToString().Trim() + ".\n";


            words = Arabic.Split(' ');
            line = new StringBuilder();
            for (int index = 0; index < words.GetLength(0); index++)
            {
                if (words[index].Length + line.Length <= MaxLength + 25)
                {
                    line.Append(words[index] + " ");
                }
                else
                {
                    if (line.Length > 0)
                    {
                        Result += "    " + line.ToString().Trim() + "\n";
                        line = new StringBuilder();
                    }
                    string overflow = words[index];
                    while (overflow.Length > MaxLength)
                    {
                        Result += overflow.Substring(0, MaxLength);
                        overflow = overflow.Substring(MaxLength);
                    }
                    line.Append(overflow + " ");
                }

            }
            Result += "    " + line.ToString().Trim() + "\n";

            return Result;
        }

        //Make text as box
        public static string Text_Aligment(string Text, int whitespace, int totalspace)
        {
            string Result = "";
            int avilable = totalspace - whitespace;

            int index = 0;
            while (index + avilable < Text.Length)
            {
                for (int i = 0; i < whitespace; i++)
                    Result += " ";

                Result += Text.Substring(index, avilable) + "\n";
                index += avilable;
            }
            if (index + avilable >= Text.Length)
            {
                for (int i = 0; i < whitespace; i++)
                    Result += " ";

                Result += Text.Substring(index, Text.Length - index) + "\n";
            }
            return Result;
        }

        //Create Total Part Arabic English
        public static string Total_ENAR(string Sub_Total, string Discount, string Total, int Line_Length, string Currency)
        {
            // Sub Total
            string Result = "";
            int space = 0;

            for (int i = 0; i < Line_Length; i++)
                Result += "-";

            if (Discount != "0.00")
            {
                space = Line_Length - "SubTotal".Length - Sub_Total.Length - " ".Length - Currency.Length;

                Result += "\nSubTotal";

                for (int i = 0; i < space; i++)
                    Result += " ";

                Result += Sub_Total + " " + Currency + "\nÇáãÌãæÚ" + "\n";

                //Discount
                space = Line_Length - "Promotion discount".Length - Discount.Length - " ".Length - "-".Length - Currency.Length;

                Result += "\nPromotion discount";

                for (int i = 0; i < space; i++)
                    Result += " ";

                Result += "-" + Discount + " " + Currency + "\nÎÕã ÇáÚÑÖ" + "\n";
            }

            //Total
            space = Line_Length - "TOTAL".Length - Total.Length - " ".Length - Currency.Length;

            Result += "\nTOTAL";

            for (int i = 0; i < space; i++)
                Result += " ";

            Result += Total + " " + Currency + "\nÇáãÌãæÚ ÇáäåÇÆí";


            return Result;

        }

        //Create Total Part Arabic English
        public static string Total_EN(string Sub_Total, string Discount, string Total, int Line_Length, string Currency)
        {
            // Sub Total
            string Result = "";
            int space = 0;

            for (int i = 0; i < Line_Length; i++)
                Result += "-";

            if (Discount != "0.00")
            {
                space = Line_Length - "SubTotal".Length - Sub_Total.Length - " ".Length - Currency.Length;

                Result += "\nSubTotal";

                for (int i = 0; i < space; i++)
                    Result += " ";

                Result += Sub_Total + " " + Currency + "\n";

                //Discount
                space = Line_Length - "Promotion discount".Length - Discount.Length - " ".Length - "-".Length - Currency.Length;

                Result += "\nPromotion discount";

                for (int i = 0; i < space; i++)
                    Result += " ";

                Result += "-" + Discount + " " + Currency + "\n";
            }

            //Total
            space = Line_Length - "TOTAL".Length - Total.Length - " ".Length - Currency.Length;

            Result += "\nTOTAL";

            for (int i = 0; i < space; i++)
                Result += " ";

            Result += Total + " " + Currency;

            return Result;
        }
    }
}
