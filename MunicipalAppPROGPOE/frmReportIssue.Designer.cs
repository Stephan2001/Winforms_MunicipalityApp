namespace MunicipalAppPROGPOE
{
    partial class frmReportIssue
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
            components = new System.ComponentModel.Container();
            txtLocation = new TextBox();
            lbCategory = new ListBox();
            rtbDescription = new RichTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            button1 = new Button();
            Progress = new System.Windows.Forms.Timer(components);
            aloneProgressBar1 = new ReaLTaiizor.Controls.AloneProgressBar();
            lblIssuesResult = new Label();
            btnUploadFile = new Button();
            lblFile = new Label();
            panel2 = new Panel();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            panel1 = new Panel();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(92, 12);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 0;
            // 
            // lbCategory
            // 
            lbCategory.FormattingEnabled = true;
            lbCategory.ItemHeight = 15;
            lbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities" });
            lbCategory.Location = new Point(298, 15);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(100, 49);
            lbCategory.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(127, 18);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(633, 68);
            rtbDescription.TabIndex = 4;
            rtbDescription.Text = "";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(12, 18);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(204, 46);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "Report Issue";
            // 
            // button1
            // 
            button1.Location = new Point(31, 317);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Progress
            // 
            Progress.Enabled = true;
            Progress.Interval = 5;
            Progress.Tick += Progress_Tick;
            // 
            // aloneProgressBar1
            // 
            aloneProgressBar1.BackColor = Color.Transparent;
            aloneProgressBar1.BackgroundColor = Color.RoyalBlue;
            aloneProgressBar1.BaseColor = Color.White;
            aloneProgressBar1.BorderColor = Color.DodgerBlue;
            aloneProgressBar1.ForeColor = SystemColors.ButtonFace;
            aloneProgressBar1.Location = new Point(503, 11);
            aloneProgressBar1.Maximum = 100;
            aloneProgressBar1.Minimum = 0;
            aloneProgressBar1.Name = "aloneProgressBar1";
            aloneProgressBar1.Size = new Size(147, 23);
            aloneProgressBar1.Stripes = Color.Black;
            aloneProgressBar1.TabIndex = 10;
            aloneProgressBar1.Text = "aloneProgressBar1";
            aloneProgressBar1.Value = 50;
            // 
            // lblIssuesResult
            // 
            lblIssuesResult.AutoSize = true;
            lblIssuesResult.Location = new Point(123, 317);
            lblIssuesResult.Name = "lblIssuesResult";
            lblIssuesResult.Size = new Size(70, 15);
            lblIssuesResult.TabIndex = 12;
            lblIssuesResult.Text = "Description:";
            lblIssuesResult.Visible = false;
            // 
            // btnUploadFile
            // 
            btnUploadFile.Location = new Point(92, 41);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(75, 23);
            btnUploadFile.TabIndex = 13;
            btnUploadFile.Text = "Choose file";
            btnUploadFile.UseVisualStyleBackColor = true;
            btnUploadFile.Click += btnUploadFile_Click;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.ForeColor = SystemColors.ButtonFace;
            lblFile.Location = new Point(92, 77);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(28, 15);
            lblFile.TabIndex = 14;
            lblFile.Text = "File:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(dungeonHeaderLabel3);
            panel2.Controls.Add(dungeonHeaderLabel2);
            panel2.Controls.Add(dungeonHeaderLabel1);
            panel2.Controls.Add(aloneProgressBar1);
            panel2.Controls.Add(dungeonHeaderLabel5);
            panel2.Controls.Add(lblFile);
            panel2.Controls.Add(txtLocation);
            panel2.Controls.Add(btnUploadFile);
            panel2.Controls.Add(lbCategory);
            panel2.Location = new Point(12, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 111);
            panel2.TabIndex = 16;
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel5.ForeColor = Color.White;
            dungeonHeaderLabel5.Location = new Point(13, 11);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(73, 20);
            dungeonHeaderLabel5.TabIndex = 17;
            dungeonHeaderLabel5.Text = "Location:";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.White;
            dungeonHeaderLabel1.Location = new Point(13, 44);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(37, 20);
            dungeonHeaderLabel1.TabIndex = 18;
            dungeonHeaderLabel1.Text = "File:";
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel2.ForeColor = Color.White;
            dungeonHeaderLabel2.Location = new Point(219, 12);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(77, 20);
            dungeonHeaderLabel2.TabIndex = 19;
            dungeonHeaderLabel2.Text = "Category:";
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel3.ForeColor = Color.White;
            dungeonHeaderLabel3.Location = new Point(427, 12);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(74, 20);
            dungeonHeaderLabel3.TabIndex = 20;
            dungeonHeaderLabel3.Text = "Progress:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(dungeonHeaderLabel4);
            panel1.Controls.Add(rtbDescription);
            panel1.Location = new Point(12, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 103);
            panel1.TabIndex = 17;
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel4.ForeColor = Color.White;
            dungeonHeaderLabel4.Location = new Point(19, 6);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(93, 20);
            dungeonHeaderLabel4.TabIndex = 19;
            dungeonHeaderLabel4.Text = "Description:";
            // 
            // frmReportIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lblIssuesResult);
            Controls.Add(button1);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportIssue";
            Text = "frmReportIssue";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocation;
        private ListBox lbCategory;
        private RichTextBox rtbDescription;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button button1;
        private System.Windows.Forms.Timer Progress;
        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar1;
        private Label lblIssuesResult;
        private Button btnUploadFile;
        private Label lblFile;
        private Panel panel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
    }
}