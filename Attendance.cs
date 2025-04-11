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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment();
            assignment.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentMgt studentMgt = new StudentMgt();
            studentMgt.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LecturerMgt lecturerMgt = new LecturerMgt();
            lecturerMgt.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FacultyMgt facultyMgt = new FacultyMgt();
            facultyMgt.Show();

            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();

            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExamResults examResults = new ExamResults();
            examResults.Show();

            this.Close();
        }
    }
}
