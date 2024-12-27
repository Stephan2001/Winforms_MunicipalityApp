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
using static System.Net.Mime.MediaTypeNames;

namespace MunicipalAppPROGPOE
{
    public partial class frmServiceRequest : Form
    {
        ServiceRequestManager serviceRequestManager = new ServiceRequestManager();
        public frmServiceRequest()
        {
            InitializeComponent();
            LoadData();
            LoadOptions();
            LoadStats();
            LoadIds();
        }

        private void LoadStats()
        {
            var stats = serviceRequestManager.statusStatistics();
            statsCompleted.Text = stats["Completed"].ToString();
            statsIssued.Text = stats["Issued"].ToString();
            statsProgress.Text = stats["In Progress"].ToString();
            statsPending.Text = stats["Pending"].ToString();
            var x = serviceRequestManager.GetLongestDependencyChain();
            statsDependancies.Text = x.Count().ToString();
            string results = "";
            foreach (var item in x)
            {
                results += " - " + item.ServiceRequestID;
            }
            StatsNodes.Text = results;
        }

        private void LoadData()
        {
            // Sample data
            var serviceRequests = serviceRequestManager.defaultDisplay();

            // Bind the list to the DataGridView
            dataGridView1.DataSource = serviceRequests;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["ServiceRequestID"].HeaderText = "Request ID";
            dataGridView1.Columns["DateIssued"].HeaderText = "Date Issued";
            dataGridView1.Columns["ServiceTitle"].HeaderText = "Service";
            dataGridView1.Columns["Location"].HeaderText = "Location";
            dataGridView1.Columns["ResponsibleDepartment"].HeaderText = "Responsible Department";
            dataGridView1.Columns["Status"].HeaderText = "Status";
        }

        private void LoadData(List<ServiceRequest> serviceRequests)
        {
            // Bind the list to the DataGridView
            dataGridView1.DataSource = serviceRequests;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["ServiceRequestID"].HeaderText = "Request ID";
            dataGridView1.Columns["DateIssued"].HeaderText = "Date Issued";
            dataGridView1.Columns["ServiceTitle"].HeaderText = "Service";
            dataGridView1.Columns["Location"].HeaderText = "Location";
            dataGridView1.Columns["ResponsibleDepartment"].HeaderText = "Responsible Department";
            dataGridView1.Columns["Status"].HeaderText = "Status";
        }

        private void btnSRSearchQuery_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSRSearchQuery.Text))
            {
                var x = serviceRequestManager.searchRequest(txtSRSearchQuery.Text.Trim());
                cmbDepartments.SelectedIndex = 0;
                cmbLocations.SelectedIndex = 0;
                txtSRSearchQuery.Text = "";
                if (x != null)
                {
                    LoadData(x);
                }
                else MessageBox.Show("Record not found");

            }
            else
            {
                LoadData();
                MessageBox.Show("Empty search field");
            }
        }

        public void LoadOptions()
        {
            var departments = serviceRequestManager.GetAllDepartments();
            var locations = serviceRequestManager.GetAllLocations();
            cmbDepartments.Items.Add("All");
            foreach (var department in departments)
            {
                cmbDepartments.Items.Add(department);
            }
            cmbLocations.Items.Add("All");
            foreach (var location in locations)
            {
                cmbLocations.Items.Add(location);
            }
            cmbDepartments.SelectedIndex = 0;
            cmbLocations.SelectedIndex = 0;
        }

        public void LoadIds()
        {
            var ids = serviceRequestManager.GetAllIds();
            foreach (var id in ids)
            {
                chkSource.Items.Add(id);
                chkDest.Items.Add(id);
            }
            chkSource.SelectedIndex = 0;
            chkDest.SelectedIndex = 0;
        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocations.SelectedIndex != 0 && cmbDepartments.SelectedIndex == 0)
            {
                var location = serviceRequestManager.searchLocations(cmbLocations.Text);
                LoadData(location);
            }
            else if (cmbLocations.SelectedIndex != 0 && cmbDepartments.SelectedIndex != 0)
            {
                var location = serviceRequestManager.searchJoined(cmbLocations.Text, cmbDepartments.Text);
                LoadData(location);
            }
            else if (cmbLocations.SelectedIndex == 0 && cmbDepartments.SelectedIndex != 0)
            {
                var departments = serviceRequestManager.searchDepartments(cmbDepartments.Text);
                LoadData(departments);
            }
            else
            {
                LoadData();
            }
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartments.SelectedIndex != 0 && cmbLocations.SelectedIndex == 0)
            {
                var departments = serviceRequestManager.searchDepartments(cmbDepartments.Text);
                LoadData(departments);
            }
            else if (cmbDepartments.SelectedIndex != 0 && cmbLocations.SelectedIndex != 0)
            {
                var departments = serviceRequestManager.searchJoined(cmbLocations.Text, cmbDepartments.Text);
                LoadData(departments);
            }
            else if (cmbDepartments.SelectedIndex == 0 && cmbLocations.SelectedIndex != 0)
            {
                var location = serviceRequestManager.searchLocations(cmbLocations.Text);
                LoadData(location);
            }
            else
            {
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(chkSource.Text) && !string.IsNullOrWhiteSpace(chkDest.Text))
            {
                var conected = serviceRequestManager.AreRequestsConnected(chkSource.Text, chkDest.Text);
                if (conected) { MessageBox.Show($"Request {chkSource.Text} IS dependant on {chkDest.Text}!"); }
                else { MessageBox.Show($"Request {chkSource.Text} is NOT dependant on {chkDest.Text}!"); }
            }
        }

        // when the user clicks it shows dependancies for the record if any are present
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow=null;
            try
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells["ServiceRequestID"].Value?.ToString() ?? "N/A";
                var x = serviceRequestManager.GetMyDependancies(id);
                string disp = "";
                foreach (var item in x.Dependencies)
                {
                    disp = disp + " - " + item.ServiceRequestID;
                }
                if (disp != "")
                {
                    MessageBox.Show($"This service request has dependancies!\n{disp}");
                }
            }
            catch { }
            
        }
    }
}


