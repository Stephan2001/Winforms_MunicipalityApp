namespace MunicipalAppPROGPOE
{
    partial class frmServiceRequest
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
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            panel1 = new Panel();
            StatsNodes = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            statsCompleted = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            statsProgress = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            statsPending = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            statsIssued = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel10 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel9 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel8 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel7 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            statsDependancies = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel2 = new Panel();
            btnSRSearchQuery = new Button();
            txtSRSearchQuery = new TextBox();
            cmbLocations = new ComboBox();
            cmbDepartments = new ComboBox();
            panel3 = new Panel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            panel4 = new Panel();
            button1 = new Button();
            chkDest = new ComboBox();
            chkSource = new ComboBox();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel6 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel11 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 175);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(21, 236);
            panel5.Name = "panel5";
            panel5.Size = new Size(767, 202);
            panel5.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(StatsNodes);
            panel1.Controls.Add(statsCompleted);
            panel1.Controls.Add(statsProgress);
            panel1.Controls.Add(statsPending);
            panel1.Controls.Add(statsIssued);
            panel1.Controls.Add(dungeonHeaderLabel10);
            panel1.Controls.Add(dungeonHeaderLabel9);
            panel1.Controls.Add(dungeonHeaderLabel8);
            panel1.Controls.Add(dungeonHeaderLabel7);
            panel1.Controls.Add(statsDependancies);
            panel1.Controls.Add(dungeonHeaderLabel4);
            panel1.Controls.Add(dungeonHeaderLabel2);
            panel1.Location = new Point(536, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 201);
            panel1.TabIndex = 13;
            // 
            // StatsNodes
            // 
            StatsNodes.AutoSize = true;
            StatsNodes.BackColor = Color.Transparent;
            StatsNodes.Font = new Font("Segoe UI", 11F);
            StatsNodes.ForeColor = Color.White;
            StatsNodes.Location = new Point(16, 61);
            StatsNodes.Name = "StatsNodes";
            StatsNodes.Size = new Size(77, 20);
            StatsNodes.TabIndex = 25;
            StatsNodes.Text = "                 ";
            // 
            // statsCompleted
            // 
            statsCompleted.AutoSize = true;
            statsCompleted.BackColor = Color.Transparent;
            statsCompleted.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            statsCompleted.ForeColor = Color.White;
            statsCompleted.Location = new Point(210, 152);
            statsCompleted.Name = "statsCompleted";
            statsCompleted.Size = new Size(18, 20);
            statsCompleted.TabIndex = 24;
            statsCompleted.Text = "0";
            // 
            // statsProgress
            // 
            statsProgress.AutoSize = true;
            statsProgress.BackColor = Color.Transparent;
            statsProgress.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            statsProgress.ForeColor = Color.White;
            statsProgress.Location = new Point(210, 134);
            statsProgress.Name = "statsProgress";
            statsProgress.Size = new Size(18, 20);
            statsProgress.TabIndex = 23;
            statsProgress.Text = "0";
            // 
            // statsPending
            // 
            statsPending.AutoSize = true;
            statsPending.BackColor = Color.Transparent;
            statsPending.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            statsPending.ForeColor = Color.White;
            statsPending.Location = new Point(210, 114);
            statsPending.Name = "statsPending";
            statsPending.Size = new Size(18, 20);
            statsPending.TabIndex = 22;
            statsPending.Text = "0";
            // 
            // statsIssued
            // 
            statsIssued.AutoSize = true;
            statsIssued.BackColor = Color.Transparent;
            statsIssued.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            statsIssued.ForeColor = Color.White;
            statsIssued.Location = new Point(210, 94);
            statsIssued.Name = "statsIssued";
            statsIssued.Size = new Size(18, 20);
            statsIssued.TabIndex = 21;
            statsIssued.Text = "0";
            // 
            // dungeonHeaderLabel10
            // 
            dungeonHeaderLabel10.AutoSize = true;
            dungeonHeaderLabel10.BackColor = Color.Transparent;
            dungeonHeaderLabel10.Font = new Font("Segoe UI", 11F);
            dungeonHeaderLabel10.ForeColor = Color.White;
            dungeonHeaderLabel10.Location = new Point(16, 154);
            dungeonHeaderLabel10.Name = "dungeonHeaderLabel10";
            dungeonHeaderLabel10.Size = new Size(86, 20);
            dungeonHeaderLabel10.TabIndex = 20;
            dungeonHeaderLabel10.Text = "Completed:";
            // 
            // dungeonHeaderLabel9
            // 
            dungeonHeaderLabel9.AutoSize = true;
            dungeonHeaderLabel9.BackColor = Color.Transparent;
            dungeonHeaderLabel9.Font = new Font("Segoe UI", 11F);
            dungeonHeaderLabel9.ForeColor = Color.White;
            dungeonHeaderLabel9.Location = new Point(16, 134);
            dungeonHeaderLabel9.Name = "dungeonHeaderLabel9";
            dungeonHeaderLabel9.Size = new Size(84, 20);
            dungeonHeaderLabel9.TabIndex = 19;
            dungeonHeaderLabel9.Text = "In Progress:";
            // 
            // dungeonHeaderLabel8
            // 
            dungeonHeaderLabel8.AutoSize = true;
            dungeonHeaderLabel8.BackColor = Color.Transparent;
            dungeonHeaderLabel8.Font = new Font("Segoe UI", 11F);
            dungeonHeaderLabel8.ForeColor = Color.White;
            dungeonHeaderLabel8.Location = new Point(16, 114);
            dungeonHeaderLabel8.Name = "dungeonHeaderLabel8";
            dungeonHeaderLabel8.Size = new Size(65, 20);
            dungeonHeaderLabel8.TabIndex = 18;
            dungeonHeaderLabel8.Text = "Pending:";
            // 
            // dungeonHeaderLabel7
            // 
            dungeonHeaderLabel7.AutoSize = true;
            dungeonHeaderLabel7.BackColor = Color.Transparent;
            dungeonHeaderLabel7.Font = new Font("Segoe UI", 11F);
            dungeonHeaderLabel7.ForeColor = Color.White;
            dungeonHeaderLabel7.Location = new Point(16, 94);
            dungeonHeaderLabel7.Name = "dungeonHeaderLabel7";
            dungeonHeaderLabel7.Size = new Size(57, 20);
            dungeonHeaderLabel7.TabIndex = 17;
            dungeonHeaderLabel7.Text = "Issued: ";
            // 
            // statsDependancies
            // 
            statsDependancies.AutoSize = true;
            statsDependancies.BackColor = Color.Transparent;
            statsDependancies.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            statsDependancies.ForeColor = Color.White;
            statsDependancies.Location = new Point(210, 34);
            statsDependancies.Name = "statsDependancies";
            statsDependancies.Size = new Size(18, 20);
            statsDependancies.TabIndex = 15;
            statsDependancies.Text = "0";
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 11F);
            dungeonHeaderLabel4.ForeColor = Color.White;
            dungeonHeaderLabel4.Location = new Point(16, 34);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(188, 20);
            dungeonHeaderLabel4.TabIndex = 14;
            dungeonHeaderLabel4.Text = "Longest depandancy chain:";
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel2.ForeColor = Color.White;
            dungeonHeaderLabel2.Location = new Point(16, 14);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(72, 20);
            dungeonHeaderLabel2.TabIndex = 13;
            dungeonHeaderLabel2.Text = "Statistics";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(12, 10);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(269, 46);
            bigLabel1.TabIndex = 14;
            bigLabel1.Text = "Service Requests";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(btnSRSearchQuery);
            panel2.Controls.Add(txtSRSearchQuery);
            panel2.Location = new Point(21, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 49);
            panel2.TabIndex = 15;
            // 
            // btnSRSearchQuery
            // 
            btnSRSearchQuery.Location = new Point(195, 10);
            btnSRSearchQuery.Name = "btnSRSearchQuery";
            btnSRSearchQuery.Size = new Size(81, 30);
            btnSRSearchQuery.TabIndex = 1;
            btnSRSearchQuery.Text = "Search";
            btnSRSearchQuery.UseVisualStyleBackColor = true;
            btnSRSearchQuery.Click += btnSRSearchQuery_Click;
            // 
            // txtSRSearchQuery
            // 
            txtSRSearchQuery.Location = new Point(18, 12);
            txtSRSearchQuery.Name = "txtSRSearchQuery";
            txtSRSearchQuery.Size = new Size(156, 23);
            txtSRSearchQuery.TabIndex = 0;
            // 
            // cmbLocations
            // 
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(17, 42);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(121, 23);
            cmbLocations.TabIndex = 16;
            cmbLocations.SelectedIndexChanged += cmbLocations_SelectedIndexChanged;
            // 
            // cmbDepartments
            // 
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Location = new Point(156, 42);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(121, 23);
            cmbDepartments.TabIndex = 17;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(dungeonHeaderLabel3);
            panel3.Controls.Add(cmbDepartments);
            panel3.Controls.Add(dungeonHeaderLabel1);
            panel3.Controls.Add(cmbLocations);
            panel3.Location = new Point(21, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 85);
            panel3.TabIndex = 18;
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel3.ForeColor = Color.White;
            dungeonHeaderLabel3.Location = new Point(157, 9);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(94, 20);
            dungeonHeaderLabel3.TabIndex = 14;
            dungeonHeaderLabel3.Text = "Department";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.White;
            dungeonHeaderLabel1.Location = new Point(18, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(69, 20);
            dungeonHeaderLabel1.TabIndex = 13;
            dungeonHeaderLabel1.Text = "Location";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(dungeonHeaderLabel11);
            panel4.Controls.Add(dungeonHeaderLabel6);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(chkDest);
            panel4.Controls.Add(chkSource);
            panel4.Controls.Add(dungeonHeaderLabel5);
            panel4.Location = new Point(323, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 201);
            panel4.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(149, 153);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 17;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkDest
            // 
            chkDest.FormattingEnabled = true;
            chkDest.Location = new Point(14, 154);
            chkDest.Name = "chkDest";
            chkDest.Size = new Size(121, 23);
            chkDest.TabIndex = 15;
            // 
            // chkSource
            // 
            chkSource.FormattingEnabled = true;
            chkSource.Location = new Point(14, 94);
            chkSource.Name = "chkSource";
            chkSource.Size = new Size(121, 23);
            chkSource.TabIndex = 14;
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel5.ForeColor = Color.White;
            dungeonHeaderLabel5.Location = new Point(14, 17);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(138, 20);
            dungeonHeaderLabel5.TabIndex = 13;
            dungeonHeaderLabel5.Text = "Check dependancy";
            // 
            // dungeonHeaderLabel6
            // 
            dungeonHeaderLabel6.AutoSize = true;
            dungeonHeaderLabel6.BackColor = Color.Transparent;
            dungeonHeaderLabel6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel6.ForeColor = Color.White;
            dungeonHeaderLabel6.Location = new Point(14, 61);
            dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            dungeonHeaderLabel6.Size = new Size(56, 20);
            dungeonHeaderLabel6.TabIndex = 18;
            dungeonHeaderLabel6.Text = "Source";
            // 
            // dungeonHeaderLabel11
            // 
            dungeonHeaderLabel11.AutoSize = true;
            dungeonHeaderLabel11.BackColor = Color.Transparent;
            dungeonHeaderLabel11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel11.ForeColor = Color.White;
            dungeonHeaderLabel11.Location = new Point(14, 125);
            dungeonHeaderLabel11.Name = "dungeonHeaderLabel11";
            dungeonHeaderLabel11.Size = new Size(90, 20);
            dungeonHeaderLabel11.TabIndex = 19;
            dungeonHeaderLabel11.Text = "Destination";
            // 
            // frmServiceRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(bigLabel1);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmServiceRequest";
            Text = "frmServiceRequest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel2;
        private Button btnSRSearchQuery;
        private TextBox txtSRSearchQuery;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ComboBox cmbLocations;
        private ComboBox cmbDepartments;
        private Panel panel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel statsDependancies;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel10;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel9;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel8;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel7;
        private ReaLTaiizor.Controls.DungeonHeaderLabel statsCompleted;
        private ReaLTaiizor.Controls.DungeonHeaderLabel statsProgress;
        private ReaLTaiizor.Controls.DungeonHeaderLabel statsPending;
        private ReaLTaiizor.Controls.DungeonHeaderLabel statsIssued;
        private Panel panel4;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ComboBox chkDest;
        private ComboBox chkSource;
        private Button button1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel StatsNodes;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel11;
    }
}