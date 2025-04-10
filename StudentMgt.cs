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
    public partial class StudentMgt : Form
    {
        public StudentMgt()
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

        private void button1_Click(object sender, EventArgs e)
        {
            login LoginForm = new login();
            LoginForm.Show();

            this.Close();
        }

        private void StudentMgt_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LecturerMgt lecturerMgt = new LecturerMgt();
            lecturerMgt.Show();

            this.Hide();
        }
    }
}
