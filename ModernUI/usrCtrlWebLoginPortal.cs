using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class usrCtrlWebLoginPortal : UserControl
    {
        public usrCtrlWebLoginPortal()
        {
            InitializeComponent();

        }

        private void rbGmail_CheckedChanged(object sender, EventArgs e)
        {
            lblSite.Text = "Gmail Login:";
        }

        private void rbBrightspace_CheckedChanged(object sender, EventArgs e)
        {
            lblSite.Text = "Brightspace Login:";
        }

        private void rbGithub_CheckedChanged(object sender, EventArgs e)
        {
            lblSite.Text = "GitHub Login:";
        }

        private void lblSite_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
