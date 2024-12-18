﻿using MySql.Data.MySqlClient;

namespace HospitalManagmentSystem
{
    partial class LoginPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_user = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_clearLogin = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(573, 51);
            label1.TabIndex = 0;
            label1.Text = "Welcome To HMS Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 258);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 1;
            label2.Text = "USER NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 362);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 37);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(383, 260);
            txt_user.Margin = new Padding(4, 5, 4, 5);
            txt_user.MaxLength = 25;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(320, 31);
            txt_user.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(383, 362);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(320, 31);
            txt_password.TabIndex = 4;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Control;
            btn_login.Location = new Point(126, 495);
            btn_login.Margin = new Padding(4, 5, 4, 5);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(180, 53);
            btn_login.TabIndex = 5;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clearLogin
            // 
            btn_clearLogin.Location = new Point(524, 495);
            btn_clearLogin.Margin = new Padding(4, 5, 4, 5);
            btn_clearLogin.Name = "btn_clearLogin";
            btn_clearLogin.Size = new Size(180, 53);
            btn_clearLogin.TabIndex = 6;
            btn_clearLogin.Text = "Clear";
            btn_clearLogin.UseVisualStyleBackColor = true;
            btn_clearLogin.Click += btn_clearLogin_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(639, 20);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(941, 727);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_clearLogin);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_clearLogin;
        private DateTimePicker dateTimePicker1;

        // Event handler definitions
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            // Handle password text change if needed
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Add login logic here
            ConnectionManager cm = new ConnectionManager();
            try {

                string username = txt_user.Text.ToString();
                string password = txt_password.Text.ToString();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("No Empty Feilds Allowed!");
                }
                else
                {
                    cm.mySql.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM  admin", cm.mySql);
                    MySqlDataReader read = mySqlCommand.ExecuteReader();
                    while (read.Read())
                    {
                        if (username.Equals(read.GetString("UserName")) && password.Equals(read.GetString("Password")))
                        {
                            MessageBox.Show("Successful Login");
                        }
                        else
                        {
                            MessageBox.Show("Invalide Login");
                        }
                    }
                    cm.mySql.Close();
                }

            }
            catch(Exception ex) { }
            
        }

        private void btn_clearLogin_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Add form load logic if needed
        }
    }
}
