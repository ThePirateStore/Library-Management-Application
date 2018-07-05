using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        private int bottom;
        private int top;
        private int difference;
        private int toAdd;
        private int prvIndexG;
        private int prvIndexS;

        Color backColor;

        private string connStr = "Data Source=.;Initial Catalog=dbLibManager;Integrated Security=True";

        private SqlConnection conn;

        bool updown;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SolidThemeCombo.SelectedIndex = 0;
            GradientThemeCombo.SelectedIndex = 0;

            GradientThemeRadio.Checked = true;

            prvIndexG = GradientThemeCombo.SelectedIndex;
            prvIndexS = SolidThemeCombo.SelectedIndex;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Dashboard);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, DashboardButton.Top);
            else
                SidePanel.Top = DashboardButton.Top;

            SidePanel.Height = DashboardButton.Height;

            ResetTheme();
        }

        private void BookIssueButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Book_Issue);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, BookIssueButton.Top);
            else
                SidePanel.Top = BookIssueButton.Top;

            SidePanel.Height = BookIssueButton.Height;

            ResetTheme();
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Members);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, MembersButton.Top);
            else
                SidePanel.Top = MembersButton.Top;

            SidePanel.Height = MembersButton.Height;

            ResetTheme();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            BodyTabControl.SelectTab(Books);

            if (SlidingTbiSwitch.Checked)
                SlidePanel(SidePanel.Top, BooksButton.Top);
            else
                SidePanel.Top = BooksButton.Top;

            SidePanel.Height = BooksButton.Height;

            ResetTheme();
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
            {
                SolidThemeCombo.Enabled = false;
                GradientThemeCombo.Enabled = true;

                ChangeTheme(GradientThemeCombo);
            }
                
        }

        private void SolidThemeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SolidThemeRadio.Checked)
            {
                GradientThemeCombo.Enabled = false;
                SolidThemeCombo.Enabled = true;

                ChangeTheme(SolidThemeCombo);
            }
                
        }

        private void GradientThemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTheme(GradientThemeCombo);
        }

        private void SolidThemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTheme(SolidThemeCombo);
        }

        private void ChangeTheme(ComboBox combo)
        {
            string theme = combo.SelectedItem.ToString().ToLower();

            using (conn = new SqlConnection(connStr))
            {
                conn.Open();

                DemoPanel.Invalidate();

                SqlCommand cm = new SqlCommand("Select Case @color when 'top' then ColorTop when 'bottom' then ColorBottom when 'txt' then TextColor when 'app' then AppColor End as Coloumn From Theme Where [Name] = @name", conn);

                cm.Parameters.Add("@name", SqlDbType.VarChar);
                cm.Parameters.Add("@color", SqlDbType.VarChar);

                cm.Parameters["@name"].Value = theme;

                cm.Parameters["@color"].Value = "top";
                string top = cm.ExecuteScalar().ToString();

                cm.Parameters["@color"].Value = "bottom";
                string bottom = cm.ExecuteScalar().ToString();

                cm.Parameters["@color"].Value = "txt";
                string txtcolor = cm.ExecuteScalar().ToString();

                cm.Parameters["@color"].Value = "app";
                string appcolor = cm.ExecuteScalar().ToString();
                
                DemoPanel.TopColor = ColorTranslator.FromHtml(top);
                DemoPanel.BottomColor = ColorTranslator.FromHtml(bottom);

                DemoPanel.ForeColor = ColorTranslator.FromHtml(txtcolor);

                backColor = ColorTranslator.FromHtml(appcolor);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SideBoard.Invalidate();
            Control[] controls = { DashboardButton, BooksButton, BookIssueButton, MembersButton, BodyTabControl, HeaderPanel };

            for (int i = 0; i < BodyTabControl.TabCount; i++)
            {
                BodyTabControl.TabPages[i].BackColor = backColor;
            }

            SideBoard.TopColor = DemoPanel.TopColor;
            SideBoard.BottomColor = DemoPanel.BottomColor;

            foreach (Control c in controls)
            {
                c.ForeColor = DemoPanel.ForeColor;
            }

            DemoPanel.BackColor = Color.Transparent;

            prvIndexS = SolidThemeCombo.SelectedIndex;
            prvIndexG = GradientThemeCombo.SelectedIndex;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetTheme();
        }

        private void ResetTheme()
        {
            DemoPanel.Invalidate();

            SolidThemeCombo.SelectedIndex = prvIndexS;
            GradientThemeCombo.SelectedIndex = prvIndexG;

            DemoPanel.TopColor = SideBoard.TopColor;
            DemoPanel.BottomColor = SideBoard.BottomColor;

            DemoPanel.ForeColor = DashboardButton.ForeColor;

            if (SideBoard.TopColor == SideBoard.BottomColor)
                SolidThemeRadio.Checked = true;
            else
                GradientThemeRadio.Checked = true;
        }
    }
}
