using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace railsFTW
{
    public partial class SettingUpTheProjectFrm : Form
    {

        public SettingUpTheProjectFrm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
        
        }

        private void rpsecTestingChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                Globals.setRspec(true);
            }
            else
            {
                Globals.setRspec(false);
            }
        }

        private void capybaraChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                Globals.setCapybara(true);
            }
            else
            {
                Globals.setCapybara(false);
            }
        }
    }
}
