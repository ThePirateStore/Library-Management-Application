using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        int bottom;
        int top;
        int difference;
        int toAdd;

        private string connStr = "Data Source=.;Initial Catalog=dbLibManager;Integrated Security=True";

        private SqlConnection conn;

        bool updown;

        public Form1()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Dashboard);

            //SidePanel.Top = DashboardButton.Top;
            SlidePanel(SidePanel.Top, DashboardButton.Top);

            SidePanel.Height = DashboardButton.Height;
        }

        private void BookIssueButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Book_Issue);

            //SidePanel.Top = BookIssueButton.Top;
            SlidePanel(SidePanel.Top, BookIssueButton.Top);

            SidePanel.Height = BookIssueButton.Height;
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Members);

            //SidePanel.Top = BookIssueButton.Top;
            SlidePanel(SidePanel.Top, MembersButton.Top);

            SidePanel.Height = MembersButton.Height;
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Books);

            //SidePanel.Top = BookIssueButton.Top;
            SlidePanel(SidePanel.Top, BooksButton.Top);

            SidePanel.Height = BooksButton.Height;
        }

        #region Slide Panel
        private void SlidePanel(int sidepanelTop, int buttonTop)
        {
            if (sidepanelTop > buttonTop)
            {
                bottom = sidepanelTop;
                top = buttonTop;

                updown = true;
            }
            else
            {
                bottom = buttonTop;
                top = sidepanelTop;

                updown = false;
            }

            difference = bottom - top;

            toAdd = difference / 23;

            SidePanelSlideTimer.Start();
        }

        private void SidePanelSlideTimer_Tick(object sender, EventArgs e)
        {
            UpdatePosition(updown);
        }

        private void UpdatePosition(bool _updown)
        {
            if (!_updown)
            {
                if (top >= bottom)
                    SidePanelSlideTimer.Stop();
                else
                {
                    top += toAdd;

                    SidePanel.Top = top;
                }
            }
            else
            {
                if (top >= bottom)
                    SidePanelSlideTimer.Stop();
                else
                {
                    bottom -= toAdd;

                    SidePanel.Top = bottom;
                }
            }
        }
        #endregion
    }
}
