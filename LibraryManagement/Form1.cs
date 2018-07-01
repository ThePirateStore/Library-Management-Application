using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

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

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, DashboardButton.Top);
            else
                SidePanel.Top = DashboardButton.Top;

            SidePanel.Height = DashboardButton.Height;
        }

        private void BookIssueButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Book_Issue);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, BookIssueButton.Top);
            else
                SidePanel.Top = BookIssueButton.Top;

            SidePanel.Height = BookIssueButton.Height;
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Members);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, MembersButton.Top);
            else
                SidePanel.Top = MembersButton.Top;

            SidePanel.Height = MembersButton.Height;
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Books);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, BooksButton.Top);
            else
                SidePanel.Top = BooksButton.Top;

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

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Settings);
        }

        private void GradientThemeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (GradientThemeRadio.Checked)
                SolidThemeRadio.Checked = false;
        }

        private void SolidThemeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SolidThemeRadio.Checked)
                GradientThemeRadio.Checked = false;
        }

        private void GradientThemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theme = GradientThemeCombo.SelectedItem.ToString().ToLower();

            SideBoard.Invalidate();
            DemoPanelG.Invalidate();
            switch (theme)
            {
                case "ohhappiness":
                    SideBoard.TopColor = Color.FromArgb(150, 201, 61);
                    SideBoard.BottomColor = Color.FromArgb(0, 176, 155);

                    DemoPanelG.TopColor = Color.FromArgb(150, 201, 61);
                    DemoPanelG.BottomColor = Color.FromArgb(0, 176, 155);
                    break;

                case "orange fun":
                    SideBoard.TopColor = Color.FromArgb(247, 183, 51);
                    SideBoard.BottomColor = Color.FromArgb(252, 74, 26);

                    DemoPanelG.TopColor = Color.FromArgb(247, 183, 51);
                    DemoPanelG.BottomColor = Color.FromArgb(252, 74, 26);
                    break;

                case "rainbow blue":
                    SideBoard.BottomColor = Color.FromArgb(5, 117, 230);
                    SideBoard.TopColor = Color.FromArgb(0, 242, 96);

                    DemoPanelG.BottomColor = Color.FromArgb(5, 117, 230);
                    DemoPanelG.TopColor = Color.FromArgb(0, 242, 96);
                    break;
            }
        }
    }
}
