namespace Simple_Ticketing_System
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
            this.Login_TB_Password = new System.Windows.Forms.TextBox();
            this.Login_LBL_Shift = new System.Windows.Forms.Label();
            this.Login_CM_Shift = new System.Windows.Forms.ComboBox();
            this.Login_BT_OK = new System.Windows.Forms.Button();
            this.Login_BT_Exit = new System.Windows.Forms.Button();
            this.Login_LBL_ID = new System.Windows.Forms.Label();
            this.Login_LBL_Password = new System.Windows.Forms.Label();
            this.Login_LBL_Version = new System.Windows.Forms.Label();
            this.Login_TB_ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_PIC_1 = new System.Windows.Forms.PictureBox();
            this.PNL1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PIC_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_TB_Password
            // 
            this.Login_TB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_TB_Password.BackColor = System.Drawing.Color.DimGray;
            this.Login_TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TB_Password.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_Password.ForeColor = System.Drawing.Color.White;
            this.Login_TB_Password.Location = new System.Drawing.Point(20, 182);
            this.Login_TB_Password.Name = "Login_TB_Password";
            this.Login_TB_Password.PasswordChar = '*';
            this.Login_TB_Password.Size = new System.Drawing.Size(211, 30);
            this.Login_TB_Password.TabIndex = 2;
            this.Login_TB_Password.Tag = "type your password here";
            this.Login_TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_TB_Password_KeyDown);
            // 
            // Login_LBL_Shift
            // 
            this.Login_LBL_Shift.AutoSize = true;
            this.Login_LBL_Shift.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_Shift.Location = new System.Drawing.Point(18, 220);
            this.Login_LBL_Shift.Name = "Login_LBL_Shift";
            this.Login_LBL_Shift.Size = new System.Drawing.Size(29, 13);
            this.Login_LBL_Shift.TabIndex = 0;
            this.Login_LBL_Shift.Text = "Shift";
            // 
            // Login_CM_Shift
            // 
            this.Login_CM_Shift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_CM_Shift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Login_CM_Shift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Login_CM_Shift.BackColor = System.Drawing.Color.DimGray;
            this.Login_CM_Shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login_CM_Shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_CM_Shift.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_CM_Shift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login_CM_Shift.FormattingEnabled = true;
            this.Login_CM_Shift.IntegralHeight = false;
            this.Login_CM_Shift.ItemHeight = 23;
            this.Login_CM_Shift.Location = new System.Drawing.Point(20, 237);
            this.Login_CM_Shift.MaxDropDownItems = 36;
            this.Login_CM_Shift.Name = "Login_CM_Shift";
            this.Login_CM_Shift.Size = new System.Drawing.Size(211, 31);
            this.Login_CM_Shift.TabIndex = 3;
            // 
            // Login_BT_OK
            // 
            this.Login_BT_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_BT_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BT_OK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BT_OK.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Login_BT_OK.Location = new System.Drawing.Point(155, 290);
            this.Login_BT_OK.Name = "Login_BT_OK";
            this.Login_BT_OK.Size = new System.Drawing.Size(76, 27);
            this.Login_BT_OK.TabIndex = 4;
            this.Login_BT_OK.Tag = "Press here to login to the system";
            this.Login_BT_OK.Text = "Login";
            this.Login_BT_OK.UseVisualStyleBackColor = true;
            this.Login_BT_OK.Click += new System.EventHandler(this.Login_BT_OK_Click);
            // 
            // Login_BT_Exit
            // 
            this.Login_BT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BT_Exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BT_Exit.ForeColor = System.Drawing.Color.Gray;
            this.Login_BT_Exit.Location = new System.Drawing.Point(73, 290);
            this.Login_BT_Exit.Name = "Login_BT_Exit";
            this.Login_BT_Exit.Size = new System.Drawing.Size(76, 27);
            this.Login_BT_Exit.TabIndex = 5;
            this.Login_BT_Exit.Tag = "Press here to login to the system";
            this.Login_BT_Exit.Text = "Exit";
            this.Login_BT_Exit.UseVisualStyleBackColor = true;
            this.Login_BT_Exit.Click += new System.EventHandler(this.Login_BT_Exit_Click);
            // 
            // Login_LBL_ID
            // 
            this.Login_LBL_ID.AutoSize = true;
            this.Login_LBL_ID.BackColor = System.Drawing.Color.Transparent;
            this.Login_LBL_ID.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_ID.Location = new System.Drawing.Point(18, 114);
            this.Login_LBL_ID.Name = "Login_LBL_ID";
            this.Login_LBL_ID.Size = new System.Drawing.Size(43, 13);
            this.Login_LBL_ID.TabIndex = 0;
            this.Login_LBL_ID.Text = "User ID";
            // 
            // Login_LBL_Password
            // 
            this.Login_LBL_Password.AutoSize = true;
            this.Login_LBL_Password.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_Password.Location = new System.Drawing.Point(18, 166);
            this.Login_LBL_Password.Name = "Login_LBL_Password";
            this.Login_LBL_Password.Size = new System.Drawing.Size(53, 13);
            this.Login_LBL_Password.TabIndex = 0;
            this.Login_LBL_Password.Text = "Password";
            // 
            // Login_LBL_Version
            // 
            this.Login_LBL_Version.AutoSize = true;
            this.Login_LBL_Version.ForeColor = System.Drawing.Color.Silver;
            this.Login_LBL_Version.Location = new System.Drawing.Point(197, 17);
            this.Login_LBL_Version.Name = "Login_LBL_Version";
            this.Login_LBL_Version.Size = new System.Drawing.Size(13, 13);
            this.Login_LBL_Version.TabIndex = 12;
            this.Login_LBL_Version.Text = "v";
            // 
            // Login_TB_ID
            // 
            this.Login_TB_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_TB_ID.BackColor = System.Drawing.Color.DimGray;
            this.Login_TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TB_ID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_ID.ForeColor = System.Drawing.Color.White;
            this.Login_TB_ID.Location = new System.Drawing.Point(20, 130);
            this.Login_TB_ID.Name = "Login_TB_ID";
            this.Login_TB_ID.Size = new System.Drawing.Size(211, 30);
            this.Login_TB_ID.TabIndex = 1;
            this.Login_TB_ID.Tag = "Type your user name here";
            this.Login_TB_ID.Leave += new System.EventHandler(this.Login_TB_ID_Leave);
            this.Login_TB_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_TB_ID_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simple_Ticketing_System.Properties.Resources.STSBG;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login_PIC_1
            // 
            this.Login_PIC_1.Image = global::Simple_Ticketing_System.Properties.Resources.Login_Pic;
            this.Login_PIC_1.Location = new System.Drawing.Point(91, 28);
            this.Login_PIC_1.Name = "Login_PIC_1";
            this.Login_PIC_1.Size = new System.Drawing.Size(72, 72);
            this.Login_PIC_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_PIC_1.TabIndex = 11;
            this.Login_PIC_1.TabStop = false;
            // 
            // PNL1
            // 
            this.PNL1.BackColor = System.Drawing.Color.White;
            this.PNL1.Location = new System.Drawing.Point(87, 24);
            this.PNL1.Name = "PNL1";
            this.PNL1.Size = new System.Drawing.Size(80, 80);
            this.PNL1.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 340);
            this.Controls.Add(this.Login_PIC_1);
            this.Controls.Add(this.PNL1);
            this.Controls.Add(this.Login_LBL_Version);
            this.Controls.Add(this.Login_BT_Exit);
            this.Controls.Add(this.Login_LBL_Shift);
            this.Controls.Add(this.Login_CM_Shift);
            this.Controls.Add(this.Login_LBL_Password);
            this.Controls.Add(this.Login_LBL_ID);
            this.Controls.Add(this.Login_TB_Password);
            this.Controls.Add(this.Login_TB_ID);
            this.Controls.Add(this.Login_BT_OK);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - STS";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PIC_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_TB_Password;
        private System.Windows.Forms.Button Login_BT_OK;
        private System.Windows.Forms.PictureBox Login_PIC_1;
        private System.Windows.Forms.Label Login_LBL_Shift;
        private System.Windows.Forms.ComboBox Login_CM_Shift;
        private System.Windows.Forms.Button Login_BT_Exit;
        private System.Windows.Forms.Label Login_LBL_ID;
        private System.Windows.Forms.Label Login_LBL_Password;
        private System.Windows.Forms.Label Login_LBL_Version;
        private System.Windows.Forms.TextBox Login_TB_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PNL1;

    }
}

