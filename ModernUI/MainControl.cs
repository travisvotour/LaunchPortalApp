using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            HideSubMenu();
            panMain.Controls.Clear();
            UserControl homePage = new usrCtrlHomePage();
            panMain.Controls.Add(homePage);
            homePage.Location = new Point(0, 0);
            homePage.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            if (SubMenuCourses.Visible == true)
            {
                SubMenuCourses.Visible = false;
            }
            else SubMenuCourses.Visible = true;
            lblTitleMain.Text = "Course Portal";
        }

        private void HideSubMenu()
        {
            SubMenuApplication.Visible = false;
            SubMenuCourses.Visible = false;
            SubMenuResources.Visible = false;
        }

        private void btnStudentResources_Click(object sender, EventArgs e)
        {
            if (SubMenuResources.Visible == true)
            {
                SubMenuResources.Visible = false;
            }
            else SubMenuResources.Visible = true;
            lblTitleMain.Text = "Resource Portal";

        }

        private void btnLauncher_Click(object sender, EventArgs e)
        {
            if (SubMenuApplication.Visible == true)
            {
                SubMenuApplication.Visible = false;
            }
            else SubMenuApplication.Visible = true;
            lblTitleMain.Text = "Application Portal";

        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            lblTitleMain.Text = "Grade Portal";

        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            lblTitleMain.Text = "TV Launch Portal";
            panMain.Controls.Clear();
            UserControl homePage = new usrCtrlHomePage();
            panMain.Controls.Add(homePage);
            homePage.Location = new Point(0, 0);
            homePage.Show();
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            UserControl webPortal = new usrCtrlWebLoginPortal();
            panMain.Controls.Add(webPortal);
            webPortal.Location = new Point(0, 0);
            webPortal.Show();

        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            UserControl programPortal = new usrCtrlProgramLauncher();
            panMain.Controls.Add(programPortal);
            programPortal.Location = new Point(0, 0);
            programPortal.Show();
        }
    }
}
