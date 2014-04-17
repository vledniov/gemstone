using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace railsFTW
{
    public partial class welcomeScreenFrm : Form
    {
        public welcomeScreenFrm()
        {
            InitializeComponent();
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            var new_project = new SettingUpTheProjectFrm();
            new_project.Show();
        }

        private void welcomeScreenFrm_Load(object sender, EventArgs e)
        {

        }

        private void loadExistingBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
