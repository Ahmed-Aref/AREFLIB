using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simple_Ticketing_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int CountLogin = 0;

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "STS";
            Login_LBL_Version.Text = "v" + (double.Parse(AST.Functions.App_Version.ToString()) / 10);

            //Make sure it's clean.
            CountLogin = 0;

            // Read Login Cradintials
            try
            {
                System.IO.StreamReader File = new System.IO.StreamReader(@"" + AppDomain.CurrentDomain.BaseDirectory + "login.udb");

                string TempLine = File.ReadLine();
                AST.Functions.SQLusername = TempLine.Split('#')[1];

                TempLine = File.ReadLine();
                AST.Functions.SQLpassword = AST.Functions.DecryptString(TempLine.Split('#')[1]);

                TempLine = File.ReadLine();
                AST.Functions.SQLserver = TempLine.Split('#')[1];

                TempLine = File.ReadLine();
                AST.Functions.SQLdatabase = TempLine.Split('#')[1];

                File.Close();
                this.Focus();
                Login_TB_ID.Focus();

                // Read Login Table from database
                try
                {
                    AST.Functions.Read_Login();
                }
                catch
                {
                    MessageBox.Show("There is an issue with Database access,\nPlease contact your Administrator.", "Error - STS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error while reading configuration File! ,\nPlease contact your Administrator.", "Fatal Error - STS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            Login_TB_ID.Focus();

            if (Check_Update())
            {
                MessageBox.Show("There is a new STS version released, Please update the Application before you continue.", "New Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                System.Windows.Forms.Application.Exit();
            }

            // Fill Shift ComboBox
            Fill_Shift();
        }
    
        private void Login_BT_OK_Click(object sender, EventArgs e)
        {
            if (Login_TB_ID.Text == "" || Login_TB_Password.Text == "")
            {
                MessageBox.Show("Please check User ID and Password.", "STS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int exist = -1;
                for (int i = 0; i < AST.Functions.Array_Login.GetLength(0); i++)
                {
                    
                    if (AST.Functions.Array_Login[i, 0] == Login_TB_ID.Text && AST.Functions.Array_Login[i, 1] == AST.Functions.EncryptString(Login_TB_Password.Text))
                    {
                        exist = i;
                    }
                }

                if (exist != -1)
                {
                    AST.Functions.Lid = AST.Functions.Array_Login[exist, 0];
                    AST.Functions.Lname = AST.Functions.Array_Login[exist, 2];
                    AST.Functions.Ltype = AST.Functions.Array_Login[exist, 3];


                    //MessageBox.Show(Login_CM_Shift.SelectedIndex.ToString() + " - " + (AST.Functions.Array_Shift_Active.GetLength(0) - 1));
                    if (Login_CM_Shift.SelectedIndex > (AST.Functions.Array_Shift_Active.GetLength(0) - 1))
                        AST.Functions.Lshift = -1;
                    else
                        AST.Functions.Lshift = Login_CM_Shift.SelectedIndex;


                    // Start the Main Home Window
                    Home HForm = new Home();
                    HForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Try Again.");
                    CountLogin++;
                    Login_TB_Password.Clear();
                    Login_TB_Password.Focus();
                    if (CountLogin > 4)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }

        private void Login_TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_BT_OK_Click(this, new EventArgs());
            }
        }

        private void Login_TB_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        bool Check_Update()
        {
            if (int.Parse(AST.Functions.Query_To_Array("Select Max(App_ver) from Help")[0, 0]) > AST.Functions.App_Version)
            {
                return  true;
            }
            else
            {
                return false;

            }
        }

        void Fill_Shift()
        {
            // Shift
            AST.Functions.Array_Shift_Active = AST.Functions.Query_To_Array(@"select Shift_ID,Shift_Name,Start_Hour,End_Hour from shift where Shift_Active = 1");
            // Fill Shift
            Login_CM_Shift.Items.Clear();
            for (int i = 0; i < AST.Functions.Array_Shift_Active.GetLength(0); i++)
            {
                Login_CM_Shift.Items.Add(AST.Functions.Array_Shift_Active[i, 1]);
            }
            Login_CM_Shift.Items.Add("Undefined");
            Login_CM_Shift.SelectedIndex = Login_CM_Shift.Items.Count - 1;
        }

        private void Login_BT_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_TB_ID_Leave(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = (byte[])AST.Functions.Query_Request(@" select User_Pic from users where user_id = " + Login_TB_ID.Text).Rows[0][0];

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);
                    Login_PIC_1.Image = bmp;
                }
            }
            catch {
                Login_PIC_1.Image = Simple_Ticketing_System.Properties.Resources.Login_Pic;
            }

        }

    }
}
