namespace MunicipalAppPROGPOE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnExpandMenu = new PictureBox();
            SideBar = new FlowLayoutPanel();
            panel2 = new Panel();
            btnReportIssues = new Button();
            panel3 = new Panel();
            btnLocalEvents = new Button();
            panel4 = new Panel();
            btnService = new Button();
            panel5 = new Panel();
            button1 = new Button();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExpandMenu).BeginInit();
            SideBar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExpandMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 13);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 1;
            label1.Text = "Municipality App";
            // 
            // btnExpandMenu
            // 
            btnExpandMenu.Image = (Image)resources.GetObject("btnExpandMenu.Image");
            btnExpandMenu.Location = new Point(14, 10);
            btnExpandMenu.Name = "btnExpandMenu";
            btnExpandMenu.Size = new Size(47, 32);
            btnExpandMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExpandMenu.TabIndex = 1;
            btnExpandMenu.TabStop = false;
            btnExpandMenu.Click += btnExpandMenu_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(23, 24, 29);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(panel4);
            SideBar.Controls.Add(panel5);
            SideBar.Dock = DockStyle.Left;
            SideBar.FlowDirection = FlowDirection.TopDown;
            SideBar.Location = new Point(0, 50);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(282, 573);
            SideBar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReportIssues);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 72);
            panel2.TabIndex = 3;
            // 
            // btnReportIssues
            // 
            btnReportIssues.BackColor = Color.FromArgb(23, 24, 29);
            btnReportIssues.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnReportIssues.ForeColor = Color.White;
            btnReportIssues.Image = (Image)resources.GetObject("btnReportIssues.Image");
            btnReportIssues.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportIssues.Location = new Point(-6, -18);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Padding = new Padding(16, 0, 0, 0);
            btnReportIssues.Size = new Size(288, 110);
            btnReportIssues.TabIndex = 2;
            btnReportIssues.Text = "                     Report issues";
            btnReportIssues.TextAlign = ContentAlignment.MiddleLeft;
            btnReportIssues.UseVisualStyleBackColor = false;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLocalEvents);
            panel3.Location = new Point(3, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 72);
            panel3.TabIndex = 4;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.BackColor = Color.FromArgb(23, 24, 29);
            btnLocalEvents.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnLocalEvents.ForeColor = Color.White;
            btnLocalEvents.Image = (Image)resources.GetObject("btnLocalEvents.Image");
            btnLocalEvents.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocalEvents.Location = new Point(-6, -18);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Padding = new Padding(18, 0, 0, 0);
            btnLocalEvents.Size = new Size(306, 110);
            btnLocalEvents.TabIndex = 2;
            btnLocalEvents.Text = "        Local events and Announcements";
            btnLocalEvents.UseVisualStyleBackColor = false;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnService);
            panel4.Location = new Point(3, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 72);
            panel4.TabIndex = 5;
            // 
            // btnService
            // 
            btnService.BackColor = Color.FromArgb(23, 24, 29);
            btnService.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnService.ForeColor = Color.White;
            btnService.Image = (Image)resources.GetObject("btnService.Image");
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(-7, -18);
            btnService.Name = "btnService";
            btnService.Padding = new Padding(22, 0, 0, 0);
            btnService.Size = new Size(291, 110);
            btnService.TabIndex = 2;
            btnService.Text = "                   Service Request Status";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.UseVisualStyleBackColor = false;
            btnService.Click += btnService_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 237);
            panel5.Name = "panel5";
            panel5.Size = new Size(264, 69);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -18);
            button1.Name = "button1";
            button1.Padding = new Padding(22, 0, 0, 0);
            button1.Size = new Size(302, 110);
            button1.TabIndex = 3;
            button1.Text = "                   Good samaritans rewards";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(959, 493);
            button2.Name = "button2";
            button2.Size = new Size(110, 82);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 623);
            Controls.Add(button2);
            Controls.Add(SideBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MinimumSize = new Size(1170, 623);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExpandMenu).EndInit();
            SideBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnExpandMenu;
        private Label label1;
        private FlowLayoutPanel SideBar;
        private Button btnReportIssues;
        private Panel panel2;
        private Panel panel3;
        private Button btnLocalEvents;
        private Panel panel4;
        private Button btnService;
        private System.Windows.Forms.Timer SidebarTransition;
        private Button button1;
        private Panel panel5;
        private Button button2;
    }
}
