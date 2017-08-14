using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;

namespace AREFLIB.Functions.Receipt
{
    class Go_Print
    {
        // Variables
        static Image Final_logo;
        static string Final_Info;
        static string Final_Order_Number;
        static string Final_Customer_Name;
        static string Final_Body;
        static string Final_Tail;
        static Image Final_Background;
        static Image Final_öAdv;
        static string Final_Customer_info;
        static string Final_Coupon_Name;

        // fonts
        static Font Info_Font = new Font("Courier New", 7, FontStyle.Bold);//8Consolas
        static Font Order_Font = new Font("Consolas", 55, FontStyle.Bold);//50
        static Font Customer_Font = new Font("Consolas", 20, FontStyle.Bold);//14
        static Font Body_Font = new Font("Consolas", 8);
        static Font Tail_font = new Font("Consolas", 8, FontStyle.Bold);
        static Font Customer_Details_Font = new Font("Consolas", 8);


        // Printer Part
        public static void Print(string PrinterName, Image logo, string Info, string Order_Number,string Customer_Name, string Body,
                                 string Tail, string Customer_Info,Image Background, Image Adv, string coupon)
        {

            Final_logo = logo;
            Final_Info = Info;
            Final_Order_Number = Order_Number;
            Final_Customer_Name = Customer_Name;
            Final_Body = Body;
            Final_Tail = Tail;
            Final_Background = Background;
            Final_öAdv = Adv;
            Final_Customer_info = Customer_Info;
            Final_Coupon_Name = coupon;

            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrinterSettings.PrinterName = PrinterName;
                doc.PrintController = new StandardPrintController();
                doc.PrintPage += new PrintPageEventHandler(PrintHandler);
                doc.Print();
            }
            catch {}
        }

        public static void PrintHandler(object sender, PrintPageEventArgs Args)
        {
            Graphics GFX = Args.Graphics;
            Rectangle m = Args.MarginBounds;

            if ((double)Final_logo.Width / (double)Final_logo.Height > (double)m.Width / (double)m.Height) m.Height = (int)((double)Final_logo.Height / (double)Final_logo.Width * (double)m.Width);
            else m.Width = (int)((double)Final_logo.Width / (double)Final_logo.Height * (double)m.Height);

            // Background
            Args.Graphics.DrawImage(Final_Background, 0, 120, Final_Background.Width, Final_Background.Height);

            // Logo
            Args.Graphics.DrawImage(Final_logo, 0, 0, Final_logo.Width, Final_logo.Height);

            // Info
            GFX.DrawString(Final_Info, Info_Font, Brushes.Black, 0, 105, new StringFormat());

            //Order_Number
            GFX.DrawString(Final_Order_Number, Order_Font, Brushes.Black, -10, 90, new StringFormat());

            //Customer_Name
            GFX.DrawString(Final_Customer_Name, Customer_Font, Brushes.Black, 0, 165, new StringFormat());

            //Body
            GFX.DrawString(Final_Body, Body_Font, Brushes.Black, 0, 190, new StringFormat());

            //TOTAL
            string Final_Tail_Extra = String_Func.Add_new_line(Final_Tail, Final_Body.Split('\n').Length);
            GFX.DrawString(Final_Tail_Extra, Tail_font, Brushes.Black, 0, 180, new StringFormat());

            //Adv.
            Args.Graphics.DrawImage(Final_öAdv, 0, 190 + (13 * Final_Tail_Extra.Split('\n').Length), Final_öAdv.Width / 4, Final_öAdv.Height / 4);

            //Coupon
            GFX.DrawString(String_Func.Add_new_line(Final_Coupon_Name, 18), Customer_Font, Brushes.Black, 0, 300 + (13 * Final_Tail_Extra.Split('\n').Length), new StringFormat());

            //Image QRPic = QR("http://maps.google.com/maps?daddr=24.6889269,46.6866785&amp;ll=");
            //Args.Graphics.DrawImage(QRPic, 0, 200 + (13 * Final_Tail_Extra.Split('\n').Length) + (Final_öAdv.Height / 4), QRPic.Width, QRPic.Height);

            GFX.DrawString(Final_Customer_info, Customer_Details_Font, Brushes.Black, 0, 200 + Final_öAdv.Height / 4 + (13 * Final_Tail_Extra.Split('\n').Length), new StringFormat());
        }
    }
}
