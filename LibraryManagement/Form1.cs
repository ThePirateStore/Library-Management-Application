using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Dashboard);

            SidePanel.Top = DashboardButton.Top;
            SidePanel.Height = DashboardButton.Height;
        }

        private void BookIssueButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Book_Issue);

            SidePanel.Top = BookIssueButton.Top;
            SidePanel.Height = BookIssueButton.Height;
        }
    }
}
