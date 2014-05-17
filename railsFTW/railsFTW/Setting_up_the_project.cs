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
        public static int CONTROLLER_COUNTER = 0;
        public static int MODEL_COUNTER = 0;

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

        private void controllerGenerateBtn_Click(object sender, EventArgs e)
        {
            TextBox txtRun = new TextBox();
            txtRun.Name = "controllerBox" + CONTROLLER_COUNTER++;
            txtRun.Location = new System.Drawing.Point(8, 40+(30*CONTROLLER_COUNTER));
            txtRun.Size = new System.Drawing.Size(225, 25);
            mainTabControl.TabPages["controllerPage"].Controls.Add(txtRun);
        }

        private void modelGenerateBtn_Click(object sender, EventArgs e)
        {
            ComboBox first_box = originalBox();
            TextBox modelName  = new TextBox();
            TextBox attributes = new TextBox();
            ComboBox attrType  = new ComboBox();

            modelName.Name     = "modelNameTxt" + MODEL_COUNTER++;
            modelName.Location = new System.Drawing.Point(10, 50 + (30 * MODEL_COUNTER));
            modelName.Size     = new System.Drawing.Size(152, 25);

            attributes.Name     = "attributeNameTxt" + MODEL_COUNTER;
            attributes.Location = new System.Drawing.Point(180, 50 + (30 * MODEL_COUNTER));
            attributes.Size     = new System.Drawing.Size(120, 25);

            for(int i=0; i<first_box.Items.Count; i++){ attrType.Items.Add(first_box.Items[i]); }
            attrType.DropDownStyle = first_box.DropDownStyle;
            attrType.Name          = "attrTypeBox" + MODEL_COUNTER;
            attrType.Location      = new System.Drawing.Point(309, 50 + (30 * MODEL_COUNTER));
            attrType.Size          = new System.Drawing.Size(95, 25);

            mainTabControl.TabPages["modelPage"].Controls.Add(modelName);
            mainTabControl.TabPages["modelPage"].Controls.Add(attributes);
            mainTabControl.TabPages["modelPage"].Controls.Add(attrType);
        }

        private ComboBox originalBox()
        {
            return (ComboBox)mainTabControl.TabPages["modelPage"].Controls.Find("attrTypeBox0", false)[0];
        }
    }
}
