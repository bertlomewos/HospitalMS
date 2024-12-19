
namespace Doc
{
    partial class DetailedPatientForm
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(52, 259);
            label2.Name = "label2";
            label2.Size = new Size(254, 44);
            label2.TabIndex = 1;
            label2.Text = "Disease";
            // 
            // label3
            // 
            label3.Location = new Point(52, 193);
            label3.Name = "label3";
            label3.Size = new Size(254, 44);
            label3.TabIndex = 2;
            label3.Text = "Blood Group";
            // 
            // button1
            // 
            button1.Location = new Point(52, 337);
            button1.Name = "button1";
            button1.Size = new Size(177, 43);
            button1.TabIndex = 3;
            button1.Text = "Prescribe Medication";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(308, 337);
            button2.Name = "button2";
            button2.Size = new Size(177, 43);
            button2.TabIndex = 4;
            button2.Text = "Request Lab Test";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(52, 57);
            label1.Name = "label1";
            label1.Size = new Size(254, 44);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.Location = new Point(52, 126);
            label4.Name = "label4";
            label4.Size = new Size(254, 44);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // button3
            // 
            button3.Location = new Point(563, 337);
            button3.Name = "button3";
            button3.Size = new Size(177, 43);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // DetailedPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "DetailedPatientForm";
            Text = "DetailedPatientForm";
            Load += DetailedPatientForm_Load;
            ResumeLayout(false);
        }


        #endregion
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label4;
        private Button button3;
    }
}