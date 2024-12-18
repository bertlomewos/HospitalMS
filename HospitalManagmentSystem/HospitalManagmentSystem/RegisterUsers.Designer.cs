namespace HospitalManagmentSystem
{
    partial class RegisterUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_lastName = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            cmb_gender = new ComboBox();
            birthDate = new DateTimePicker();
            btn_register = new Button();
            btn_clearRigster = new Button();
            label1 = new Label();
            txt_firstName = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 122);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 223);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 3;
            label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 280);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 344);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 5;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 400);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 6;
            label7.Text = "Occupation";
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(203, 124);
            txt_lastName.MaxLength = 25;
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(263, 23);
            txt_lastName.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(203, 278);
            txt_email.MaxLength = 50;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(263, 23);
            txt_email.TabIndex = 11;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(203, 342);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(263, 23);
            txt_password.TabIndex = 12;
            // 
            // cmb_gender
            // 
            cmb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cmb_gender.Location = new Point(203, 178);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(263, 23);
            cmb_gender.TabIndex = 15;
            // 
            // birthDate
            // 
            birthDate.CustomFormat = "dd/MM/yyyy";
            birthDate.Format = DateTimePickerFormat.Custom;
            birthDate.Location = new Point(203, 223);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(263, 23);
            birthDate.TabIndex = 16;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(99, 486);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(105, 31);
            btn_register.TabIndex = 17;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_clearRigster
            // 
            btn_clearRigster.Location = new Point(361, 496);
            btn_clearRigster.Name = "btn_clearRigster";
            btn_clearRigster.Size = new Size(105, 31);
            btn_clearRigster.TabIndex = 18;
            btn_clearRigster.Text = "Clear";
            btn_clearRigster.UseVisualStyleBackColor = true;
            btn_clearRigster.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 75);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Location = new Point(203, 77);
            txt_firstName.MaxLength = 25;
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(263, 23);
            txt_firstName.TabIndex = 7;
            txt_firstName.TextChanged += txt_firstName_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Doctor", "Nurse", "HR", "OPs", "MLS", "Pharmasiste" });
            comboBox1.Location = new Point(203, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // RegisterUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(544, 642);
            Controls.Add(comboBox1);
            Controls.Add(btn_clearRigster);
            Controls.Add(btn_register);
            Controls.Add(birthDate);
            Controls.Add(cmb_gender);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_lastName);
            Controls.Add(txt_firstName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUsers";
            Load += RegisterUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_lastName;
        private TextBox txt_email;
        private TextBox txt_password;
        private ComboBox cmb_gender;
        private DateTimePicker birthDate;
        private Button btn_register;
        private Button btn_clearRigster;
        private Label label1;
        private TextBox txt_firstName;
        private ComboBox comboBox1;
    }
}
