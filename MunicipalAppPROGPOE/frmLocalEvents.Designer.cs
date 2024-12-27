namespace MunicipalAppPROGPOE
{
    partial class frmLocalEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalEvents));
            txtLESearchQuery = new TextBox();
            btnLESearchQuery = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            txtLEEventKeywords = new ListBox();
            txtLEEventDate = new ReaLTaiizor.Controls.DungeonLabel();
            txtLEEventName = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            btnLEEventBack = new Button();
            btnLEEventNext = new Button();
            panel5 = new Panel();
            txtLERecomendName = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            btnLERecomendNext = new Button();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMessageBox = new Label();
            lblMeswagebox2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtLESearchQuery
            // 
            txtLESearchQuery.Location = new Point(18, 12);
            txtLESearchQuery.Name = "txtLESearchQuery";
            txtLESearchQuery.Size = new Size(417, 23);
            txtLESearchQuery.TabIndex = 0;
            txtLESearchQuery.Enter += txtLESearchQuery_Enter;
            txtLESearchQuery.Leave += txtLESearchQuery_Leave;
            // 
            // btnLESearchQuery
            // 
            btnLESearchQuery.Location = new Point(455, 10);
            btnLESearchQuery.Name = "btnLESearchQuery";
            btnLESearchQuery.Size = new Size(81, 30);
            btnLESearchQuery.TabIndex = 1;
            btnLESearchQuery.Text = "Search";
            btnLESearchQuery.UseVisualStyleBackColor = true;
            btnLESearchQuery.Click += btnLESearchQuery_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(12, 14);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(521, 46);
            bigLabel1.TabIndex = 6;
            bigLabel1.Text = "Local events and Announcements";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnLESearchQuery);
            panel1.Controls.Add(txtLESearchQuery);
            panel1.Location = new Point(22, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 49);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(250, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 126);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 126);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(503, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 267);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(txtLEEventKeywords);
            panel4.Controls.Add(txtLEEventDate);
            panel4.Controls.Add(txtLEEventName);
            panel4.Controls.Add(btnLEEventBack);
            panel4.Controls.Add(btnLEEventNext);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(22, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(462, 266);
            panel4.TabIndex = 10;
            panel4.Visible = false;
            // 
            // txtLEEventKeywords
            // 
            txtLEEventKeywords.BackColor = SystemColors.ActiveCaptionText;
            txtLEEventKeywords.ForeColor = SystemColors.ButtonFace;
            txtLEEventKeywords.FormattingEnabled = true;
            txtLEEventKeywords.ItemHeight = 15;
            txtLEEventKeywords.Location = new Point(18, 86);
            txtLEEventKeywords.Name = "txtLEEventKeywords";
            txtLEEventKeywords.Size = new Size(120, 94);
            txtLEEventKeywords.TabIndex = 14;
            // 
            // txtLEEventDate
            // 
            txtLEEventDate.AutoSize = true;
            txtLEEventDate.BackColor = Color.Transparent;
            txtLEEventDate.Font = new Font("Segoe UI", 11F);
            txtLEEventDate.ForeColor = Color.White;
            txtLEEventDate.Location = new Point(18, 53);
            txtLEEventDate.Name = "txtLEEventDate";
            txtLEEventDate.Size = new Size(41, 20);
            txtLEEventDate.TabIndex = 12;
            txtLEEventDate.Text = "Date";
            // 
            // txtLEEventName
            // 
            txtLEEventName.AutoSize = true;
            txtLEEventName.BackColor = Color.Transparent;
            txtLEEventName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtLEEventName.ForeColor = Color.White;
            txtLEEventName.Location = new Point(18, 22);
            txtLEEventName.Name = "txtLEEventName";
            txtLEEventName.Size = new Size(48, 20);
            txtLEEventName.TabIndex = 12;
            txtLEEventName.Text = "Event";
            // 
            // btnLEEventBack
            // 
            btnLEEventBack.Location = new Point(18, 212);
            btnLEEventBack.Name = "btnLEEventBack";
            btnLEEventBack.Size = new Size(81, 30);
            btnLEEventBack.TabIndex = 12;
            btnLEEventBack.Text = "Previous";
            btnLEEventBack.UseVisualStyleBackColor = true;
            btnLEEventBack.Click += btnLEEventBack_Click;
            // 
            // btnLEEventNext
            // 
            btnLEEventNext.Location = new Point(152, 212);
            btnLEEventNext.Name = "btnLEEventNext";
            btnLEEventNext.Size = new Size(81, 30);
            btnLEEventNext.TabIndex = 12;
            btnLEEventNext.Text = "Next";
            btnLEEventNext.UseVisualStyleBackColor = true;
            btnLEEventNext.Click += btnLEEventNext_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(txtLERecomendName);
            panel5.Controls.Add(btnLERecomendNext);
            panel5.Controls.Add(dungeonHeaderLabel2);
            panel5.Location = new Point(529, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 174);
            panel5.TabIndex = 11;
            // 
            // txtLERecomendName
            // 
            txtLERecomendName.AutoSize = true;
            txtLERecomendName.BackColor = Color.Transparent;
            txtLERecomendName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtLERecomendName.ForeColor = Color.White;
            txtLERecomendName.Location = new Point(14, 53);
            txtLERecomendName.Name = "txtLERecomendName";
            txtLERecomendName.Size = new Size(48, 20);
            txtLERecomendName.TabIndex = 14;
            txtLERecomendName.Text = "Event";
            // 
            // btnLERecomendNext
            // 
            btnLERecomendNext.Location = new Point(164, 131);
            btnLERecomendNext.Name = "btnLERecomendNext";
            btnLERecomendNext.Size = new Size(81, 30);
            btnLERecomendNext.TabIndex = 13;
            btnLERecomendNext.Text = "Next";
            btnLERecomendNext.UseVisualStyleBackColor = true;
            btnLERecomendNext.Click += btnLERecomendNext_Click;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel2.ForeColor = Color.White;
            dungeonHeaderLabel2.Location = new Point(14, 17);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(130, 20);
            dungeonHeaderLabel2.TabIndex = 13;
            dungeonHeaderLabel2.Text = "Recomendations:";
            // 
            // lblMessageBox
            // 
            lblMessageBox.AutoSize = true;
            lblMessageBox.ForeColor = SystemColors.ControlText;
            lblMessageBox.Location = new Point(602, 103);
            lblMessageBox.Name = "lblMessageBox";
            lblMessageBox.Size = new Size(0, 15);
            lblMessageBox.TabIndex = 12;
            // 
            // lblMeswagebox2
            // 
            lblMeswagebox2.AutoSize = true;
            lblMeswagebox2.Location = new Point(592, 103);
            lblMeswagebox2.Name = "lblMeswagebox2";
            lblMeswagebox2.Size = new Size(38, 15);
            lblMeswagebox2.TabIndex = 13;
            lblMeswagebox2.Text = "label1";
            lblMeswagebox2.Visible = false;
            // 
            // frmLocalEvents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblMeswagebox2);
            Controls.Add(lblMessageBox);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLocalEvents";
            Text = "frmLocalEvents";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLESearchQuery;
        private Button btnLESearchQuery;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ReaLTaiizor.Controls.DungeonLabel txtLEEventDate;
        private ReaLTaiizor.Controls.DungeonHeaderLabel txtLEEventName;
        private Button btnLEEventBack;
        private Button btnLEEventNext;
        private Panel panel5;
        private Button btnLERecomendNext;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel txtLERecomendName;
        private Label lblMessageBox;
        private Label lblMeswagebox2;
        private ListBox txtLEEventKeywords;
        private PictureBox pictureBox1;
    }
}