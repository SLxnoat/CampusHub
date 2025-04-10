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
    public partial class LecturerMgt : Form
    {
        public LecturerMgt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogin LoginForm = new login();
            LoginForm.Show();

            this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            login LoginForm = new login();
            LoginForm.Show();

            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
