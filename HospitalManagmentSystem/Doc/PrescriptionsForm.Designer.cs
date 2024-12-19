namespace Doc
{
    partial class PrescriptionsForm
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
            MedicationName = new TextBox();
            Dosage = new TextBox();
            Instructions = new TextBox();
            Duration = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // MedicationName
            // 
            MedicationName.Location = new Point(370, 77);
            MedicationName.Multiline = true;
            MedicationName.Name = "MedicationName";
            MedicationName.Size = new Size(226, 44);
            MedicationName.TabIndex = 0;
            MedicationName.TextChanged += textBox1_TextChanged;
            // 
            // Dosage
            // 
            Dosage.Location = new Point(370, 150);
            Dosage.Multiline = true;
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(226, 44);
            Dosage.TabIndex = 1;
            Dosage.TextChanged += textBox2_TextChanged;
            // 
            // Instructions
            // 
            Instructions.Location = new Point(370, 227);
            Instructions.Multiline = true;
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(226, 44);
            Instructions.TabIndex = 2;
            Instructions.TextChanged += textBox3_TextChanged;
            // 
            // Duration
            // 
            Duration.FormattingEnabled = true;
            Duration.Items.AddRange(new object[] { "1 week", "2 weeks", "3 weeks", "4 weeks" });
            Duration.Location = new Point(370, 295);
            Duration.Name = "Duration";
            Duration.Size = new Size(211, 28);
            Duration.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(192, 77);
            label1.Name = "label1";
            label1.Size = new Size(129, 42);
            label1.TabIndex = 4;
            label1.Text = "Medication Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(192, 150);
            label2.Name = "label2";
            label2.Size = new Size(129, 42);
            label2.TabIndex = 5;
            label2.Text = "Dosage";
            // 
            // label3
            // 
            label3.Location = new Point(192, 227);
            label3.Name = "label3";
            label3.Size = new Size(129, 42);
            label3.TabIndex = 6;
            label3.Text = "Instructions";
            // 
            // label4
            // 
            label4.Location = new Point(192, 295);
            label4.Name = "label4";
            label4.Size = new Size(129, 42);
            label4.TabIndex = 7;
            label4.Text = "Duration";
            // 
            // button1
            // 
            button1.Location = new Point(268, 371);
            button1.Name = "button1";
            button1.Size = new Size(204, 36);
            button1.TabIndex = 8;
            button1.Text = "Save Prescription";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrescriptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Duration);
            Controls.Add(Instructions);
            Controls.Add(Dosage);
            Controls.Add(MedicationName);
            Name = "PrescriptionsForm";
            Text = "PrescriptionsForm";
            Load += PrescriptionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MedicationName;
        private TextBox Dosage;
        private TextBox Instructions;
        private ComboBox Duration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}