using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusHub
{
    public partial class Assignment : Form
    {
        public Assignment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentMgt studentMgt = new StudentMgt();
            studentMgt.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LecturerMgt lecturerMgt = new LecturerMgt();
            lecturerMgt.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FacultyMgt facultyMgt = new FacultyMgt();
            facultyMgt.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Close();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
