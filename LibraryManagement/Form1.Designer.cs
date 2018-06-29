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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BodyTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.Book_Issue = new System.Windows.Forms.TabPage();
            this.Members = new System.Windows.Forms.TabPage();
            this.Books = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SidePanelSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideBoard = new LibraryManagement.GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MembersButton = new System.Windows.Forms.Button();
            this.BookIssueButton = new System.Windows.Forms.Button();
            this.SidePanel = new LibraryManagement.GradientPanel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.DragControl = new LibraryManagement.DragControl();
            this.toggleSwitch1 = new LibraryManagement.ToggleSwitch();
            this.BodyTabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SideBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyTabControl
            // 
            this.BodyTabControl.Controls.Add(this.Dashboard);
            this.BodyTabControl.Controls.Add(this.Book_Issue);
            this.BodyTabControl.Controls.Add(this.Members);
            this.BodyTabControl.Controls.Add(this.Books);
            this.BodyTabControl.Controls.Add(this.Settings);
            this.BodyTabControl.Depth = 0;
            this.BodyTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BodyTabControl.Location = new System.Drawing.Point(190, 65);
            this.BodyTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.BodyTabControl.Name = "BodyTabControl";
            this.BodyTabControl.SelectedIndex = 0;
            this.BodyTabControl.Size = new System.Drawing.Size(746, 456);
            this.BodyTabControl.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(4, 22);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(738, 430);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // Book_Issue
            // 
            this.Book_Issue.Location = new System.Drawing.Point(4, 22);
            this.Book_Issue.Name = "Book_Issue";
            this.Book_Issue.Padding = new System.Windows.Forms.Padding(3);
            this.Book_Issue.Size = new System.Drawing.Size(738, 430);
            this.Book_Issue.TabIndex = 1;
            this.Book_Issue.Text = "Book Issue";
            this.Book_Issue.UseVisualStyleBackColor = true;
            // 
            // Members
            // 
            this.Members.Location = new System.Drawing.Point(4, 22);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(3);
            this.Members.Size = new System.Drawing.Size(738, 430);
            this.Members.TabIndex = 2;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(4, 22);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(738, 430);
            this.Books.TabIndex = 3;
            this.Books.Text = "Books";
            this.Books.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.toggleSwitch1);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(738, 430);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(190, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(746, 22);
            this.HeaderPanel.TabIndex = 3;
            // 
            // SidePanelSlideTimer
            // 
            this.SidePanelSlideTimer.Interval = 1;
            this.SidePanelSlideTimer.Tick += new System.EventHandler(this.SidePanelSlideTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(190, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 44);
            this.panel1.TabIndex = 4;
            // 
            // SideBoard
            // 
            this.SideBoard.Angle = 45F;
            this.SideBoard.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.SideBoard.Controls.Add(this.button1);
            this.SideBoard.Controls.Add(this.SettingsButton);
            this.SideBoard.Controls.Add(this.MembersButton);
            this.SideBoard.Controls.Add(this.BookIssueButton);
            this.SideBoard.Controls.Add(this.SidePanel);
            this.SideBoard.Controls.Add(this.DashboardButton);
            this.SideBoard.Controls.Add(this.BooksButton);
            this.SideBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBoard.Location = new System.Drawing.Point(0, 0);
            this.SideBoard.Name = "SideBoard";
            this.SideBoard.Size = new System.Drawing.Size(190, 521);
            this.SideBoard.TabIndex = 2;
            this.SideBoard.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(61)))));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.AutoEllipsis = true;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(139, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(38, 35);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // MembersButton
            // 
            this.MembersButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.MembersButton.BackColor = System.Drawing.Color.Transparent;
            this.MembersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MembersButton.FlatAppearance.BorderSize = 0;
            this.MembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.MembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.MembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MembersButton.Font = new System.Drawing.Font("Segoe UI Light", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersButton.Image = ((System.Drawing.Image)(resources.GetObject("MembersButton.Image")));
            this.MembersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MembersButton.Location = new System.Drawing.Point(3, 157);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(187, 46);
            this.MembersButton.TabIndex = 3;
            this.MembersButton.Text = "             Members";
            this.MembersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MembersButton.UseVisualStyleBackColor = false;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
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
            this.BookIssueButton.Image = ((System.Drawing.Image)(resources.GetObject("BookIssueButton.Image")));
            this.BookIssueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookIssueButton.Location = new System.Drawing.Point(3, 111);
            this.BookIssueButton.Name = "BookIssueButton";
            this.BookIssueButton.Size = new System.Drawing.Size(187, 46);
            this.BookIssueButton.TabIndex = 2;
            this.BookIssueButton.Text = "             Book Issue";
            this.BookIssueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookIssueButton.UseVisualStyleBackColor = false;
            this.BookIssueButton.Click += new System.EventHandler(this.BookIssueButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.Angle = 90F;
            this.SidePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(30)))), ((int)(((byte)(148)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 203);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(3, 46);
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
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(3, 65);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(187, 46);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "             Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.BooksButton.BackColor = System.Drawing.Color.Transparent;
            this.BooksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BooksButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BooksButton.FlatAppearance.BorderSize = 0;
            this.BooksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BooksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksButton.Font = new System.Drawing.Font("Segoe UI Light", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksButton.Image = ((System.Drawing.Image)(resources.GetObject("BooksButton.Image")));
            this.BooksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksButton.Location = new System.Drawing.Point(3, 203);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(187, 46);
            this.BooksButton.TabIndex = 4;
            this.BooksButton.Text = "             Books";
            this.BooksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksButton.UseVisualStyleBackColor = false;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.SelectControl = this.HeaderPanel;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.AutoSize = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(643, 24);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Padding = new System.Windows.Forms.Padding(6);
            this.toggleSwitch1.Size = new System.Drawing.Size(70, 29);
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.Text = "toggle ";
            this.toggleSwitch1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BodyTabControl);
            this.Controls.Add(this.SideBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Library Manager";
            this.BodyTabControl.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.SideBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl BodyTabControl;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Book_Issue;
        private GradientPanel SideBoard;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button BookIssueButton;
        private DragControl DragControl;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Timer SidePanelSlideTimer;
        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.TabPage Members;
        private System.Windows.Forms.TabPage Books;
        private System.Windows.Forms.Button BooksButton;
        private GradientPanel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Settings;
        private ToggleSwitch toggleSwitch1;
    }
}

