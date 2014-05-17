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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.testingPage = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.capybaraDescLbl = new System.Windows.Forms.Label();
            this.capybaraChk = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rspecDescLbl = new System.Windows.Forms.Label();
            this.rpsecTestingChk = new System.Windows.Forms.CheckBox();
            this.modelPage = new System.Windows.Forms.TabPage();
            this.modelGenerateBtn = new System.Windows.Forms.Button();
            this.attrTypeBox0 = new System.Windows.Forms.ComboBox();
            this.attributeNameTxt0 = new System.Windows.Forms.TextBox();
            this.attributesLbl1 = new System.Windows.Forms.Label();
            this.modelNameLbl1 = new System.Windows.Forms.Label();
            this.modelNameTxt0 = new System.Windows.Forms.TextBox();
            this.controllerPage = new System.Windows.Forms.TabPage();
            this.controllerGenerateBtn = new System.Windows.Forms.Button();
            this.controllerLabel1 = new System.Windows.Forms.Label();
            this.controllerBox0 = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.testingPage.SuspendLayout();
            this.modelPage.SuspendLayout();
            this.controllerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.testingPage);
            this.mainTabControl.Controls.Add(this.modelPage);
            this.mainTabControl.Controls.Add(this.controllerPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(417, 332);
            this.mainTabControl.TabIndex = 0;
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
            // capybaraChk
            // 
            this.capybaraChk.AutoSize = true;
            this.capybaraChk.Location = new System.Drawing.Point(16, 118);
            this.capybaraChk.Name = "capybaraChk";
            this.capybaraChk.Size = new System.Drawing.Size(175, 17);
            this.capybaraChk.TabIndex = 4;
            this.capybaraChk.Text = "Use Capybara for feature specs";
            this.capybaraChk.UseVisualStyleBackColor = true;
            this.capybaraChk.CheckedChanged += new System.EventHandler(this.capybaraChk_CheckedChanged);
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
            // rspecDescLbl
            // 
            this.rspecDescLbl.AutoSize = true;
            this.rspecDescLbl.Location = new System.Drawing.Point(13, 39);
            this.rspecDescLbl.Name = "rspecDescLbl";
            this.rspecDescLbl.Size = new System.Drawing.Size(382, 65);
            this.rspecDescLbl.TabIndex = 2;
            this.rspecDescLbl.Text = resources.GetString("rspecDescLbl.Text");
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
            this.rpsecTestingChk.CheckedChanged += new System.EventHandler(this.rpsecTestingChk_CheckedChanged);
            // 
            // modelPage
            // 
            this.modelPage.Controls.Add(this.modelGenerateBtn);
            this.modelPage.Controls.Add(this.attrTypeBox0);
            this.modelPage.Controls.Add(this.attributeNameTxt0);
            this.modelPage.Controls.Add(this.attributesLbl1);
            this.modelPage.Controls.Add(this.modelNameLbl1);
            this.modelPage.Controls.Add(this.modelNameTxt0);
            this.modelPage.Location = new System.Drawing.Point(4, 25);
            this.modelPage.Name = "modelPage";
            this.modelPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelPage.Size = new System.Drawing.Size(409, 303);
            this.modelPage.TabIndex = 1;
            this.modelPage.Text = "Models";
            this.modelPage.UseVisualStyleBackColor = true;
            // 
            // modelGenerateBtn
            // 
            this.modelGenerateBtn.Location = new System.Drawing.Point(309, 18);
            this.modelGenerateBtn.Name = "modelGenerateBtn";
            this.modelGenerateBtn.Size = new System.Drawing.Size(94, 23);
            this.modelGenerateBtn.TabIndex = 5;
            this.modelGenerateBtn.Text = "Generate new";
            this.modelGenerateBtn.UseVisualStyleBackColor = true;
            this.modelGenerateBtn.Click += new System.EventHandler(this.modelGenerateBtn_Click);
            // 
            // attrTypeBox0
            // 
            this.attrTypeBox0.AllowDrop = true;
            this.attrTypeBox0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attrTypeBox0.FormattingEnabled = true;
            this.attrTypeBox0.Items.AddRange(new object[] {
            "string",
            "text",
            "decimal",
            "integer",
            "date",
            "datetime"});
            this.attrTypeBox0.Location = new System.Drawing.Point(309, 53);
            this.attrTypeBox0.Name = "attrTypeBox0";
            this.attrTypeBox0.Size = new System.Drawing.Size(94, 21);
            this.attrTypeBox0.TabIndex = 4;
            // 
            // attributeNameTxt0
            // 
            this.attributeNameTxt0.Location = new System.Drawing.Point(179, 54);
            this.attributeNameTxt0.Name = "attributeNameTxt0";
            this.attributeNameTxt0.Size = new System.Drawing.Size(120, 20);
            this.attributeNameTxt0.TabIndex = 3;
            // 
            // attributesLbl1
            // 
            this.attributesLbl1.AutoSize = true;
            this.attributesLbl1.Location = new System.Drawing.Point(176, 28);
            this.attributesLbl1.Name = "attributesLbl1";
            this.attributesLbl1.Size = new System.Drawing.Size(51, 13);
            this.attributesLbl1.TabIndex = 2;
            this.attributesLbl1.Text = "Attributes";
            // 
            // modelNameLbl1
            // 
            this.modelNameLbl1.AutoSize = true;
            this.modelNameLbl1.Location = new System.Drawing.Point(8, 28);
            this.modelNameLbl1.Name = "modelNameLbl1";
            this.modelNameLbl1.Size = new System.Drawing.Size(65, 13);
            this.modelNameLbl1.TabIndex = 1;
            this.modelNameLbl1.Text = "Model name";
            // 
            // modelNameTxt0
            // 
            this.modelNameTxt0.Location = new System.Drawing.Point(11, 54);
            this.modelNameTxt0.Name = "modelNameTxt0";
            this.modelNameTxt0.Size = new System.Drawing.Size(152, 20);
            this.modelNameTxt0.TabIndex = 0;
            // 
            // controllerPage
            // 
            this.controllerPage.Controls.Add(this.controllerGenerateBtn);
            this.controllerPage.Controls.Add(this.controllerLabel1);
            this.controllerPage.Controls.Add(this.controllerBox0);
            this.controllerPage.Location = new System.Drawing.Point(4, 25);
            this.controllerPage.Name = "controllerPage";
            this.controllerPage.Size = new System.Drawing.Size(409, 303);
            this.controllerPage.TabIndex = 2;
            this.controllerPage.Text = "Controllers";
            this.controllerPage.UseVisualStyleBackColor = true;
            // 
            // controllerGenerateBtn
            // 
            this.controllerGenerateBtn.Location = new System.Drawing.Point(278, 34);
            this.controllerGenerateBtn.Name = "controllerGenerateBtn";
            this.controllerGenerateBtn.Size = new System.Drawing.Size(102, 23);
            this.controllerGenerateBtn.TabIndex = 2;
            this.controllerGenerateBtn.Text = "Generate new";
            this.controllerGenerateBtn.UseVisualStyleBackColor = true;
            this.controllerGenerateBtn.Click += new System.EventHandler(this.controllerGenerateBtn_Click);
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
            // controllerBox0
            // 
            this.controllerBox0.Location = new System.Drawing.Point(8, 37);
            this.controllerBox0.Name = "controllerBox0";
            this.controllerBox0.Size = new System.Drawing.Size(225, 20);
            this.controllerBox0.TabIndex = 0;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(282, 355);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(102, 24);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate project";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // SettingUpTheProjectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 412);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.mainTabControl);
            this.Name = "SettingUpTheProjectFrm";
            this.Text = "Setting up the project";
            this.mainTabControl.ResumeLayout(false);
            this.testingPage.ResumeLayout(false);
            this.testingPage.PerformLayout();
            this.modelPage.ResumeLayout(false);
            this.modelPage.PerformLayout();
            this.controllerPage.ResumeLayout(false);
            this.controllerPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage testingPage;
        private System.Windows.Forms.CheckBox rpsecTestingChk;
        private System.Windows.Forms.TabPage modelPage;
        private System.Windows.Forms.CheckBox capybaraChk;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label rspecDescLbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label capybaraDescLbl;
        private System.Windows.Forms.ComboBox attrTypeBox0;
        private System.Windows.Forms.TextBox attributeNameTxt0;
        private System.Windows.Forms.Label attributesLbl1;
        private System.Windows.Forms.Label modelNameLbl1;
        private System.Windows.Forms.TextBox modelNameTxt0;
        private System.Windows.Forms.TabPage controllerPage;
        private System.Windows.Forms.Label controllerLabel1;
        private System.Windows.Forms.TextBox controllerBox0;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button controllerGenerateBtn;
        private System.Windows.Forms.Button modelGenerateBtn;
    }
}