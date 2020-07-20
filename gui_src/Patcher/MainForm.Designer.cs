namespace Patcher
{
    partial class PatcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatcherForm));
            this.patchButton = new MetroFramework.Controls.MetroButton();
            this.selectUnity = new MetroFramework.Controls.MetroButton();
            this.pathTextbox = new MetroFramework.Controls.MetroTextBox();
            this.unityVersions = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.Enabled = false;
            this.patchButton.Location = new System.Drawing.Point(23, 180);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(437, 45);
            this.patchButton.Style = MetroFramework.MetroColorStyle.Green;
            this.patchButton.TabIndex = 24;
            this.patchButton.Text = "PATCH";
            this.patchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // selectUnity
            // 
            this.selectUnity.Location = new System.Drawing.Point(23, 145);
            this.selectUnity.Name = "selectUnity";
            this.selectUnity.Size = new System.Drawing.Size(75, 29);
            this.selectUnity.Style = MetroFramework.MetroColorStyle.Green;
            this.selectUnity.TabIndex = 25;
            this.selectUnity.Text = "SELECT";
            this.selectUnity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectUnity.Click += new System.EventHandler(this.SelectClick);
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(104, 148);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.ReadOnly = true;
            this.pathTextbox.Size = new System.Drawing.Size(219, 23);
            this.pathTextbox.Style = MetroFramework.MetroColorStyle.Green;
            this.pathTextbox.TabIndex = 23;
            this.pathTextbox.Text = "Please select your Unity EXE...";
            this.pathTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // unityVersions
            // 
            this.unityVersions.FormattingEnabled = true;
            this.unityVersions.ItemHeight = 23;
            this.unityVersions.Items.AddRange(new object[] {
            "2020.1b",
            "2019.4",
            "2019.3",
            "2019.2",
            "2019.1",
            "2018.4",
            "2018.3",
            "2018.2"});
            this.unityVersions.Location = new System.Drawing.Point(329, 145);
            this.unityVersions.Name = "unityVersions";
            this.unityVersions.Size = new System.Drawing.Size(131, 29);
            this.unityVersions.Style = MetroFramework.MetroColorStyle.Green;
            this.unityVersions.TabIndex = 22;
            this.unityVersions.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Patcher.Properties.Resources.external_content_duckduckgo;
            this.pictureBox1.Location = new System.Drawing.Point(180, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // PatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 256);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.selectUnity);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.unityVersions);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatcherForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PatcherFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton patchButton;
        public MetroFramework.Controls.MetroButton selectUnity;
        public MetroFramework.Controls.MetroTextBox pathTextbox;
        public MetroFramework.Controls.MetroComboBox unityVersions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

