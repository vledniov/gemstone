namespace railsFTW
{
    partial class welcomeScreenFrm
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
            this.newProjectBtn = new System.Windows.Forms.Button();
            this.loadExistingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Location = new System.Drawing.Point(82, 66);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(145, 34);
            this.newProjectBtn.TabIndex = 0;
            this.newProjectBtn.Text = " Create new project";
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // loadExistingBtn
            // 
            this.loadExistingBtn.Location = new System.Drawing.Point(82, 163);
            this.loadExistingBtn.Name = "loadExistingBtn";
            this.loadExistingBtn.Size = new System.Drawing.Size(145, 31);
            this.loadExistingBtn.TabIndex = 1;
            this.loadExistingBtn.Text = "Load...";
            this.loadExistingBtn.UseVisualStyleBackColor = true;
            this.loadExistingBtn.Click += new System.EventHandler(this.loadExistingBtn_Click);
            // 
            // welcomeScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 281);
            this.Controls.Add(this.loadExistingBtn);
            this.Controls.Add(this.newProjectBtn);
            this.Name = "welcomeScreenFrm";
            this.Text = "Welcome to railsFTW";
            this.Load += new System.EventHandler(this.welcomeScreenFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newProjectBtn;
        private System.Windows.Forms.Button loadExistingBtn;
    }
}

