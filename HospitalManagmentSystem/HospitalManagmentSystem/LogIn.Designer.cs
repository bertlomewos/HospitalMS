using MySql.Data.MySqlClient;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            label2 = new Label();
            txt_user = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_clearLogin = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(393, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(365, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome To HMS \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 258);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.None;
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_user.Location = new Point(383, 246);
            txt_user.Margin = new Padding(4, 5, 4, 5);
            txt_user.MaxLength = 25;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(390, 38);
            txt_user.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.None;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(383, 358);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(390, 38);
            txt_password.TabIndex = 4;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.FromArgb(0, 117, 214);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(383, 487);
            btn_login.Margin = new Padding(4, 5, 4, 5);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(390, 49);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOG IN";
            btn_login.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clearLogin
            // 
            btn_clearLogin.Anchor = AnchorStyles.None;
            btn_clearLogin.AutoSize = true;
            btn_clearLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_clearLogin.BackColor = Color.White;
            btn_clearLogin.FlatAppearance.BorderSize = 0;
            btn_clearLogin.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_clearLogin.FlatAppearance.MouseOverBackColor = Color.White;
            btn_clearLogin.FlatStyle = FlatStyle.Flat;
            btn_clearLogin.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clearLogin.ForeColor = Color.FromArgb(0, 117, 212);
            btn_clearLogin.ImageAlign = ContentAlignment.MiddleRight;
            btn_clearLogin.Location = new Point(639, 437);
            btn_clearLogin.Margin = new Padding(4, 5, 4, 5);
            btn_clearLogin.Name = "btn_clearLogin";
            btn_clearLogin.Size = new Size(128, 34);
            btn_clearLogin.TabIndex = 6;
            btn_clearLogin.Text = "Clear Fields";
            btn_clearLogin.TextAlign = ContentAlignment.MiddleRight;
            btn_clearLogin.UseVisualStyleBackColor = false;
            btn_clearLogin.Click += btn_clearLogin_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(711, 14);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(318, 289);
            label4.Name = "label4";
            label4.Size = new Size(455, 2);
            label4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 353);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(318, 401);
            label3.Name = "label3";
            label3.Size = new Size(455, 2);
            label3.TabIndex = 11;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 720);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_clearLogin);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
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
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();

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

        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}
