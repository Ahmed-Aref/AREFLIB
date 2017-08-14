namespace AREFLIB.GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Exit = new System.Windows.Forms.Button();
            this.Login_LBL_Password = new System.Windows.Forms.Label();
            this.Login_LBL_ID = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_UserID = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNL1 = new System.Windows.Forms.Panel();
            this.PIC = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PNL1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Exit
            // 
            this.BT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Exit.ForeColor = System.Drawing.Color.Gray;
            this.BT_Exit.Location = new System.Drawing.Point(54, 265);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(76, 27);
            this.BT_Exit.TabIndex = 22;
            this.BT_Exit.Tag = "Press here to login to the system";
            this.BT_Exit.Text = "Exit";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // Login_LBL_Password
            // 
            this.Login_LBL_Password.AutoSize = true;
            this.Login_LBL_Password.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_Password.Location = new System.Drawing.Point(7, 180);
            this.Login_LBL_Password.Name = "Login_LBL_Password";
            this.Login_LBL_Password.Size = new System.Drawing.Size(53, 13);
            this.Login_LBL_Password.TabIndex = 16;
            this.Login_LBL_Password.Text = "Password";
            // 
            // Login_LBL_ID
            // 
            this.Login_LBL_ID.AutoSize = true;
            this.Login_LBL_ID.BackColor = System.Drawing.Color.Transparent;
            this.Login_LBL_ID.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_ID.Location = new System.Drawing.Point(7, 119);
            this.Login_LBL_ID.Name = "Login_LBL_ID";
            this.Login_LBL_ID.Size = new System.Drawing.Size(43, 13);
            this.Login_LBL_ID.TabIndex = 17;
            this.Login_LBL_ID.Text = "User ID";
            // 
            // TB_Password
            // 
            this.TB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Password.BackColor = System.Drawing.Color.DimGray;
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Password.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.ForeColor = System.Drawing.Color.White;
            this.TB_Password.Location = new System.Drawing.Point(9, 196);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(203, 30);
            this.TB_Password.TabIndex = 19;
            this.TB_Password.Tag = "type your password here";
            // 
            // TB_UserID
            // 
            this.TB_UserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_UserID.BackColor = System.Drawing.Color.DimGray;
            this.TB_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_UserID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserID.ForeColor = System.Drawing.Color.White;
            this.TB_UserID.Location = new System.Drawing.Point(9, 135);
            this.TB_UserID.Name = "TB_UserID";
            this.TB_UserID.Size = new System.Drawing.Size(203, 30);
            this.TB_UserID.TabIndex = 18;
            this.TB_UserID.Tag = "Type your user name here";
            // 
            // BT_Login
            // 
            this.BT_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.BT_Login.Location = new System.Drawing.Point(136, 265);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(76, 27);
            this.BT_Login.TabIndex = 21;
            this.BT_Login.Tag = "Press here to login to the system";
            this.BT_Login.Text = "Login";
            this.BT_Login.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PNL1);
            this.panel1.Controls.Add(this.BT_Exit);
            this.panel1.Controls.Add(this.Login_LBL_Password);
            this.panel1.Controls.Add(this.Login_LBL_ID);
            this.panel1.Controls.Add(this.TB_Password);
            this.panel1.Controls.Add(this.TB_UserID);
            this.panel1.Controls.Add(this.BT_Login);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 300);
            this.panel1.TabIndex = 1000;
            // 
            // PNL1
            // 
            this.PNL1.BackColor = System.Drawing.Color.White;
            this.PNL1.Controls.Add(this.PIC);
            this.PNL1.Location = new System.Drawing.Point(71, 13);
            this.PNL1.Name = "PNL1";
            this.PNL1.Size = new System.Drawing.Size(80, 80);
            this.PNL1.TabIndex = 26;
            // 
            // PIC
            // 
            this.PIC.BackColor = System.Drawing.Color.Transparent;
            this.PIC.ErrorImage = null;
            this.PIC.Image = global::AREFLIB.Properties.Resources.Login_Pic;
            this.PIC.InitialImage = null;
            this.PIC.Location = new System.Drawing.Point(4, 4);
            this.PIC.Name = "PIC";
            this.PIC.Size = new System.Drawing.Size(72, 72);
            this.PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC.TabIndex = 23;
            this.PIC.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNL1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Label Login_LBL_Password;
        private System.Windows.Forms.Label Login_LBL_ID;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_UserID;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PNL1;
        private System.Windows.Forms.PictureBox PIC;

    }
}