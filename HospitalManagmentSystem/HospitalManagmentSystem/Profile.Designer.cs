namespace Doc
{
    partial class Profile
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
            browseBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(27, 156);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 5;
            browseBtn.Text = "browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(242, 74);
            label1.Name = "label1";
            label1.Size = new Size(293, 50);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(242, 141);
            label2.Name = "label2";
            label2.Size = new Size(293, 50);
            label2.TabIndex = 7;
            label2.Text = "Specialization";
            // 
            // label3
            // 
            label3.Location = new Point(242, 277);
            label3.Name = "label3";
            label3.Size = new Size(293, 50);
            label3.TabIndex = 8;
            label3.Text = "PhoneNum";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(242, 212);
            label4.Name = "label4";
            label4.Size = new Size(293, 50);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // button2
            // 
            button2.Location = new Point(432, 355);
            button2.Name = "button2";
            button2.Size = new Size(177, 29);
            button2.TabIndex = 15;
            button2.Text = "Edit Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(browseBtn);
            Controls.Add(pictureBox1);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button browseBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}