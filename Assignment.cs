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

        private void button6_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment();
            assignment.Show();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data updated successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Documents (*.pdf;*.doc;*.docx)|*.pdf;*.doc;*.docx";
                openFileDialog.Title = "Select Assignment Files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = @"D:\Degree\OOP\Mini Project\file store\";

                    foreach (string file in openFileDialog.FileNames)
                    {
                        try
                        {
                            string fileName = Path.GetFileName(file);
                            string destFile = Path.Combine(destinationPath, fileName);

                            // Copy the file
                            File.Copy(file, destFile, true); // true = overwrite if exists
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error uploading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Files uploaded successfully!", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
