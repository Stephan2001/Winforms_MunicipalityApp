using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalAppPROGPOE
{
    public partial class frmReportIssue : Form
    {
        private byte[] fileContent;
        private string fileName;

        public frmReportIssue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string response = "Result: "; // display error messages
            var location = txtLocation.Text;
            var category = lbCategory.Text;
            var Description = rtbDescription.Text;

            // input validations
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                response += "Please enter Location ";
                MessageBox.Show("Invalid - Please enter Location.");
                lblIssuesResult.Text = response;
                lblIssuesResult.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(lbCategory.Text))
            {
                response += "Please select category ";
                MessageBox.Show("Invalid - Please enter category.");
                lblIssuesResult.Text = response;
                lblIssuesResult.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(rtbDescription.Text))
            {
                response += "Please enter description ";
                MessageBox.Show("Invalid - Please enter description.");
                lblIssuesResult.Text = response;
                lblIssuesResult.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                response += "Please upload file ";
                MessageBox.Show("Invalid - Please upload file.");
                lblIssuesResult.Text = response;
                lblIssuesResult.Visible = true;
                return;
            }
            lblFile.Text = "";
            response += "Issue has been creaeted";
            lblIssuesResult.Text = response;
            lblIssuesResult.Visible = true;
            Issues issues = new Issues(location, category, Description, fileContent);
            Form1.multiMapIssues.Add(location, issues);
            Debug.WriteLine("Issue submitted, current count " + Form1.multiMapIssues.Count);
            MessageBox.Show("Issue has been submitted.");

            // clear all fields
            fileName = "";
            txtLocation.Text = "";
            rtbDescription.Text = "";
            lbCategory.Text = "";
        }

        // timer/progressbar keeping track of form completion
        private void Progress_Tick(object sender, EventArgs e)
        {
            aloneProgressBar1.Minimum = 0;
            aloneProgressBar1.Maximum = 100;

            aloneProgressBar1.Value = 0;

            if (!string.IsNullOrEmpty(txtLocation.Text))
            {
                aloneProgressBar1.Value += 25;
            }

            if (!string.IsNullOrEmpty(lbCategory.Text))
            {
                aloneProgressBar1.Value += 25;
            }

            if (!string.IsNullOrEmpty(rtbDescription.Text))
            {
                aloneProgressBar1.Value += 25;
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                aloneProgressBar1.Value += 25;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;

                    try
                    {
                        fileContent = File.ReadAllBytes(fileName);
                        lblFile.Text = fileName;
                        MessageBox.Show("File uploaded successfully.");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
            }
        }
    }
}
