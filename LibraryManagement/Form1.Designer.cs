namespace LibraryManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BodyTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.Book_Issue = new System.Windows.Forms.TabPage();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SidePanelSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel2 = new LibraryManagement.GradientPanel();
            this.BookIssueButton = new System.Windows.Forms.Button();
            this.SidePanel = new LibraryManagement.GradientPanel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.DragControl = new LibraryManagement.DragControl();
            this.BodyTabControl.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyTabControl
            // 
            this.BodyTabControl.Controls.Add(this.Dashboard);
            this.BodyTabControl.Controls.Add(this.Book_Issue);
            this.BodyTabControl.Depth = 0;
            this.BodyTabControl.Location = new System.Drawing.Point(191, 64);
            this.BodyTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.BodyTabControl.Name = "BodyTabControl";
            this.BodyTabControl.SelectedIndex = 0;
            this.BodyTabControl.Size = new System.Drawing.Size(744, 457);
            this.BodyTabControl.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(4, 22);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(736, 431);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // Book_Issue
            // 
            this.Book_Issue.Location = new System.Drawing.Point(4, 22);
            this.Book_Issue.Name = "Book_Issue";
            this.Book_Issue.Padding = new System.Windows.Forms.Padding(3);
            this.Book_Issue.Size = new System.Drawing.Size(736, 431);
            this.Book_Issue.TabIndex = 1;
            this.Book_Issue.Text = "Book Issue";
            this.Book_Issue.UseVisualStyleBackColor = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.Minimize);
            this.HeaderPanel.Controls.Add(this.Close);
            this.HeaderPanel.Location = new System.Drawing.Point(175, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(768, 22);
            this.HeaderPanel.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(722, -6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 27);
            this.Minimize.TabIndex = 5;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(738, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.TabIndex = 4;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // SidePanelSlideTimer
            // 
            this.SidePanelSlideTimer.Interval = 1;
            this.SidePanelSlideTimer.Tick += new System.EventHandler(this.SidePanelSlideTimer_Tick);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 45F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.gradientPanel2.Controls.Add(this.BookIssueButton);
            this.gradientPanel2.Controls.Add(this.SidePanel);
            this.gradientPanel2.Controls.Add(this.DashboardButton);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(190, 521);
            this.gradientPanel2.TabIndex = 2;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(61)))));
            // 
            // BookIssueButton
            // 
            this.BookIssueButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.BookIssueButton.BackColor = System.Drawing.Color.Transparent;
            this.BookIssueButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookIssueButton.FlatAppearance.BorderSize = 0;
            this.BookIssueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BookIssueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BookIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssueButton.Font = new System.Drawing.Font("Segoe UI Light", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssueButton.Location = new System.Drawing.Point(3, 111);
            this.BookIssueButton.Name = "BookIssueButton";
            this.BookIssueButton.Size = new System.Drawing.Size(187, 45);
            this.BookIssueButton.TabIndex = 2;
            this.BookIssueButton.Text = "Book Issue";
            this.BookIssueButton.UseVisualStyleBackColor = false;
            this.BookIssueButton.Click += new System.EventHandler(this.BookIssueButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.Angle = 90F;
            this.SidePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(30)))), ((int)(((byte)(148)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 65);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(3, 45);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(47)))), ((int)(((byte)(255)))));
            // 
            // DashboardButton
            // 
            this.DashboardButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI Light", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(3, 65);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(187, 45);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.SelectControl = this.HeaderPanel;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 521);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.BodyTabControl);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Library Manager";
            this.BodyTabControl.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl BodyTabControl;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Book_Issue;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Button DashboardButton;
        private GradientPanel SidePanel;
        private System.Windows.Forms.Button BookIssueButton;
        private DragControl DragControl;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Timer SidePanelSlideTimer;
    }
}

