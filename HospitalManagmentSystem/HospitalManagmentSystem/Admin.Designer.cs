namespace HospitalManagmentSystem
{
    partial class Admin
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
            menuStrip1 = new MenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            doctorToolStripMenuItem = new ToolStripMenuItem();
            nurseToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            hRToolStripMenuItem = new ToolStripMenuItem();
            financeToolStripMenuItem = new ToolStripMenuItem();
            pharmasiteToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, listToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doctorToolStripMenuItem, nurseToolStripMenuItem, operationsToolStripMenuItem, hRToolStripMenuItem, financeToolStripMenuItem, pharmasiteToolStripMenuItem, adminToolStripMenuItem });
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(37, 20);
            listToolStripMenuItem.Text = "List";
            // 
            // button1
            // 
            button1.Location = new Point(713, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doctorToolStripMenuItem
            // 
            doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            doctorToolStripMenuItem.Size = new Size(180, 22);
            doctorToolStripMenuItem.Text = "Doctor";
            // 
            // nurseToolStripMenuItem
            // 
            nurseToolStripMenuItem.Name = "nurseToolStripMenuItem";
            nurseToolStripMenuItem.Size = new Size(180, 22);
            nurseToolStripMenuItem.Text = "Nurse";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(180, 22);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // hRToolStripMenuItem
            // 
            hRToolStripMenuItem.Name = "hRToolStripMenuItem";
            hRToolStripMenuItem.Size = new Size(180, 22);
            hRToolStripMenuItem.Text = "HR";
            // 
            // financeToolStripMenuItem
            // 
            financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            financeToolStripMenuItem.Size = new Size(180, 22);
            financeToolStripMenuItem.Text = "Finance";
            // 
            // pharmasiteToolStripMenuItem
            // 
            pharmasiteToolStripMenuItem.Name = "pharmasiteToolStripMenuItem";
            pharmasiteToolStripMenuItem.Size = new Size(180, 22);
            pharmasiteToolStripMenuItem.Text = "Pharmasite";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(180, 22);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Admin";
            Text = "Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem doctorToolStripMenuItem;
        private ToolStripMenuItem nurseToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem hRToolStripMenuItem;
        private ToolStripMenuItem financeToolStripMenuItem;
        private ToolStripMenuItem pharmasiteToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}