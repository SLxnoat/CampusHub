namespace CampusHub
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            tbLoginPw = new TextBox();
            tbLoginUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(764, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 15, 0, 0);
            label1.Size = new Size(394, 75);
            label1.TabIndex = 0;
            label1.Text = "© 2025 H M C M Bandara\nDesigned & Developed by ArtXpert-Code\nAll rights reserved. Unauthorized duplication is prohibited.";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 602);
            panel2.Name = "panel2";
            panel2.Size = new Size(1158, 82);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.DarkOrange;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbLoginPw);
            panel1.Controls.Add(tbLoginUser);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 602);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 446);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 152);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label5.Location = new Point(61, 9);
            label5.Name = "label5";
            label5.Size = new Size(228, 32);
            label5.TabIndex = 5;
            label5.Text = "Forgotten password?";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label6.Location = new Point(55, 41);
            label6.Name = "label6";
            label6.Size = new Size(234, 32);
            label6.TabIndex = 6;
            label6.Text = "create a new account";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(42, 376);
            button1.Name = "button1";
            button1.Size = new Size(247, 50);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbLoginPw
            // 
            tbLoginPw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbLoginPw.BorderStyle = BorderStyle.None;
            tbLoginPw.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            tbLoginPw.Location = new Point(19, 314);
            tbLoginPw.Name = "tbLoginPw";
            tbLoginPw.PasswordChar = '*';
            tbLoginPw.Size = new Size(301, 31);
            tbLoginPw.TabIndex = 3;
            // 
            // tbLoginUser
            // 
            tbLoginUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbLoginUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbLoginUser.BorderStyle = BorderStyle.None;
            tbLoginUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            tbLoginUser.Location = new Point(19, 219);
            tbLoginUser.Name = "tbLoginUser";
            tbLoginUser.Size = new Size(301, 31);
            tbLoginUser.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(19, 280);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 2;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(19, 185);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 1;
            label3.Text = "User ID :";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 105);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOrange;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(15);
            label2.Size = new Size(336, 104);
            label2.TabIndex = 0;
            label2.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrange;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(340, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 602);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 684);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "login";
            Text = "login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox tbLoginPw;
        private TextBox tbLoginUser;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label6;
        private Label label5;
        private Panel panel4;
    }
}
