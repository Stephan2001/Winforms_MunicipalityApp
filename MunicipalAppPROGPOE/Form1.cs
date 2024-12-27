namespace MunicipalAppPROGPOE
{
    public partial class Form1 : Form
    {
        frmReportIssue rprtIssue;
        frmLocalEvents lclEvents;
        frmServiceRequest srvRequest;
        Home home;
        Rewards rewards;



        public static MultiMap<string, Issues> multiMapIssues = new MultiMap<string, Issues>();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable; // allowing for resizing form

            CloseActiveForm(); // Ensure previous form is closed
            if (home == null)
            {
                home = new Home();
                home.FormClosed += Homw_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                rprtIssue.Activate();
            }
        }

        // timer for expanding/retracting menu sidebar navigation
        private void btnExpandMenu_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        bool sidebarExpand = true; // keeping track of sidebar state

        // sidebar transition
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width <= 80)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width >= 282)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                }
            }
        }

        private void CloseActiveForm()
        {
            // Close the currently active form 
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            CloseActiveForm(); // Ensure previous form is closed
            if (rprtIssue == null)
            {
                rprtIssue = new frmReportIssue();
                rprtIssue.FormClosed += frmReportIssue_FormClosed;
                rprtIssue.MdiParent = this;
                rprtIssue.Dock = DockStyle.Fill;
                rprtIssue.Show();
            }
            else
            {
                rprtIssue.Activate();
            }
        }

        private void frmReportIssue_FormClosed(object sender, FormClosedEventArgs e)
        {
            rprtIssue = null;
        }

        private void Homw_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            CloseActiveForm(); // Ensure previous form is closed
            if (lclEvents == null)
            {
                lclEvents = new frmLocalEvents();
                lclEvents.FormClosed += frmLocalEvents_FormClosed;
                lclEvents.MdiParent = this;
                lclEvents.Dock = DockStyle.Fill;
                lclEvents.Show();
            }
            else
            {
                lclEvents.Activate();
            }
        }

        private void frmLocalEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            lclEvents = null;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            CloseActiveForm(); // Ensure previous form is closed
            if (srvRequest == null)
            {
                srvRequest = new frmServiceRequest();
                srvRequest.FormClosed += frmServiceRequest_FormClosed;
                srvRequest.MdiParent = this;
                srvRequest.Dock = DockStyle.Fill;
                srvRequest.Show();
            }
            else
            {
                srvRequest.Activate();
            }
        }

        private void frmServiceRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            srvRequest = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseActiveForm(); // previous form is closed
            if (rewards == null)
            {
                rewards = new Rewards();
                rewards.FormClosed += button1_FormClosed;
                rewards.MdiParent = this;
                rewards.Dock = DockStyle.Fill;
                rewards.Show();
            }
            else
            {
                rewards.Activate();
            }
        }

        private void button1_FormClosed(object sender, FormClosedEventArgs e)
        {
            rewards = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseActiveForm(); // Ensure previous form is closed
            if (home == null)
            {
                home = new Home();
                home.FormClosed += Homw_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                rprtIssue.Activate();
            }
        }
    }
}
