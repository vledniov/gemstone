namespace railsFTW
{
    partial class SettingUpTheProjectFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingUpTheProjectFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.testingPage = new System.Windows.Forms.TabPage();
            this.modelPage = new System.Windows.Forms.TabPage();
            this.rpsecTestingChk = new System.Windows.Forms.CheckBox();
            this.rspecDescLbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.capybaraChk = new System.Windows.Forms.CheckBox();
            this.capybaraDescLbl = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.modelNameTxt1 = new System.Windows.Forms.TextBox();
            this.modelNameLbl1 = new System.Windows.Forms.Label();
            this.attributesLbl1 = new System.Windows.Forms.Label();
            this.attributeNameTxt1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.controllerPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controllerLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.testingPage.SuspendLayout();
            this.modelPage.SuspendLayout();
            this.controllerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.testingPage);
            this.tabControl1.Controls.Add(this.modelPage);
            this.tabControl1.Controls.Add(this.controllerPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // testingPage
            // 
            this.testingPage.Controls.Add(this.linkLabel2);
            this.testingPage.Controls.Add(this.capybaraDescLbl);
            this.testingPage.Controls.Add(this.capybaraChk);
            this.testingPage.Controls.Add(this.linkLabel1);
            this.testingPage.Controls.Add(this.rspecDescLbl);
            this.testingPage.Controls.Add(this.rpsecTestingChk);
            this.testingPage.Location = new System.Drawing.Point(4, 25);
            this.testingPage.Name = "testingPage";
            this.testingPage.Padding = new System.Windows.Forms.Padding(3);
            this.testingPage.Size = new System.Drawing.Size(409, 303);
            this.testingPage.TabIndex = 0;
            this.testingPage.Text = "Testing";
            this.testingPage.UseVisualStyleBackColor = true;
            // 
            // modelPage
            // 
            this.modelPage.Controls.Add(this.comboBox1);
            this.modelPage.Controls.Add(this.attributeNameTxt1);
            this.modelPage.Controls.Add(this.attributesLbl1);
            this.modelPage.Controls.Add(this.modelNameLbl1);
            this.modelPage.Controls.Add(this.modelNameTxt1);
            this.modelPage.Location = new System.Drawing.Point(4, 25);
            this.modelPage.Name = "modelPage";
            this.modelPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelPage.Size = new System.Drawing.Size(409, 303);
            this.modelPage.TabIndex = 1;
            this.modelPage.Text = "Models";
            this.modelPage.UseVisualStyleBackColor = true;
            // 
            // rpsecTestingChk
            // 
            this.rpsecTestingChk.AutoSize = true;
            this.rpsecTestingChk.Location = new System.Drawing.Point(16, 19);
            this.rpsecTestingChk.Name = "rpsecTestingChk";
            this.rpsecTestingChk.Size = new System.Drawing.Size(79, 17);
            this.rpsecTestingChk.TabIndex = 1;
            this.rpsecTestingChk.Text = "Use Rspec";
            this.rpsecTestingChk.UseVisualStyleBackColor = true;
            // 
            // rspecDescLbl
            // 
            this.rspecDescLbl.AutoSize = true;
            this.rspecDescLbl.Location = new System.Drawing.Point(13, 39);
            this.rspecDescLbl.Name = "rspecDescLbl";
            this.rspecDescLbl.Size = new System.Drawing.Size(382, 65);
            this.rspecDescLbl.TabIndex = 2;
            this.rspecDescLbl.Text = resources.GetString("rspecDescLbl.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(170, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/rspec/rspec";
            // 
            // capybaraChk
            // 
            this.capybaraChk.AutoSize = true;
            this.capybaraChk.Location = new System.Drawing.Point(16, 118);
            this.capybaraChk.Name = "capybaraChk";
            this.capybaraChk.Size = new System.Drawing.Size(175, 17);
            this.capybaraChk.TabIndex = 4;
            this.capybaraChk.Text = "Use Capybara for feature specs";
            this.capybaraChk.UseVisualStyleBackColor = true;
            // 
            // capybaraDescLbl
            // 
            this.capybaraDescLbl.AutoSize = true;
            this.capybaraDescLbl.Location = new System.Drawing.Point(13, 138);
            this.capybaraDescLbl.Name = "capybaraDescLbl";
            this.capybaraDescLbl.Size = new System.Drawing.Size(340, 26);
            this.capybaraDescLbl.TabIndex = 5;
            this.capybaraDescLbl.Text = "Capybara helps you test web applications by simulating how a real user\r\nwould int" +
                "eract with your app.";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(170, 151);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(184, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/jnicklas/capybara";
            // 
            // modelNameTxt1
            // 
            this.modelNameTxt1.Location = new System.Drawing.Point(8, 29);
            this.modelNameTxt1.Name = "modelNameTxt1";
            this.modelNameTxt1.Size = new System.Drawing.Size(152, 20);
            this.modelNameTxt1.TabIndex = 0;
            // 
            // modelNameLbl1
            // 
            this.modelNameLbl1.AutoSize = true;
            this.modelNameLbl1.Location = new System.Drawing.Point(8, 13);
            this.modelNameLbl1.Name = "modelNameLbl1";
            this.modelNameLbl1.Size = new System.Drawing.Size(65, 13);
            this.modelNameLbl1.TabIndex = 1;
            this.modelNameLbl1.Text = "Model name";
            // 
            // attributesLbl1
            // 
            this.attributesLbl1.AutoSize = true;
            this.attributesLbl1.Location = new System.Drawing.Point(176, 13);
            this.attributesLbl1.Name = "attributesLbl1";
            this.attributesLbl1.Size = new System.Drawing.Size(51, 13);
            this.attributesLbl1.TabIndex = 2;
            this.attributesLbl1.Text = "Attributes";
            // 
            // attributeNameTxt1
            // 
            this.attributeNameTxt1.Location = new System.Drawing.Point(179, 29);
            this.attributeNameTxt1.Name = "attributeNameTxt1";
            this.attributeNameTxt1.Size = new System.Drawing.Size(120, 20);
            this.attributeNameTxt1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "string",
            "text",
            "decimal",
            "integer",
            "date",
            "datetime"});
            this.comboBox1.Location = new System.Drawing.Point(305, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // controllerPage
            // 
            this.controllerPage.Controls.Add(this.controllerLabel1);
            this.controllerPage.Controls.Add(this.textBox1);
            this.controllerPage.Location = new System.Drawing.Point(4, 25);
            this.controllerPage.Name = "controllerPage";
            this.controllerPage.Size = new System.Drawing.Size(409, 303);
            this.controllerPage.TabIndex = 2;
            this.controllerPage.Text = "Controllers";
            this.controllerPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 0;
            // 
            // controllerLabel1
            // 
            this.controllerLabel1.AutoSize = true;
            this.controllerLabel1.Location = new System.Drawing.Point(8, 21);
            this.controllerLabel1.Name = "controllerLabel1";
            this.controllerLabel1.Size = new System.Drawing.Size(80, 13);
            this.controllerLabel1.TabIndex = 1;
            this.controllerLabel1.Text = "Controller name";
            // 
            // SettingUpTheProjectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingUpTheProjectFrm";
            this.Text = "Setting up the project";
            this.tabControl1.ResumeLayout(false);
            this.testingPage.ResumeLayout(false);
            this.testingPage.PerformLayout();
            this.modelPage.ResumeLayout(false);
            this.modelPage.PerformLayout();
            this.controllerPage.ResumeLayout(false);
            this.controllerPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage testingPage;
        private System.Windows.Forms.CheckBox rpsecTestingChk;
        private System.Windows.Forms.TabPage modelPage;
        private System.Windows.Forms.CheckBox capybaraChk;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label rspecDescLbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label capybaraDescLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox attributeNameTxt1;
        private System.Windows.Forms.Label attributesLbl1;
        private System.Windows.Forms.Label modelNameLbl1;
        private System.Windows.Forms.TextBox modelNameTxt1;
        private System.Windows.Forms.TabPage controllerPage;
        private System.Windows.Forms.Label controllerLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}