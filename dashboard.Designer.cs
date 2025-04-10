namespace CampusHub
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 88);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1022, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(136, 88);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(25, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "00/00/0000";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "00:00";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 88);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(8, 6, 110, 0);
            label3.Size = new Size(188, 34);
            label3.TabIndex = 2;
            label3.Text = "Hello...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            label4.Location = new Point(0, 26);
            label4.Name = "label4";
            label4.Size = new Size(180, 62);
            label4.TabIndex = 0;
            label4.Text = "Admin";
            // 
            // panel2
            // 
            panel2.Location = new Point(-2, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 639);
            panel4.Name = "panel4";
            panel4.Size = new Size(1158, 45);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(80, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(110, 10, 110, 10);
            label5.Size = new Size(998, 37);
            label5.TabIndex = 0;
            label5.Text = "© 2025 H M C M Bandara    Designed & Developed by ArtXpert-Code    All rights reserved.    Unauthorized duplication is prohibited.";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 684);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "dashboard";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
    }
}