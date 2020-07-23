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
            this.lightRadio = new MetroFramework.Controls.MetroRadioButton();
            this.darkRadio = new MetroFramework.Controls.MetroRadioButton();
            this.consoleOutput = new MetroFramework.Controls.MetroTextBox();
            this.forceCheck = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.Enabled = false;
            this.patchButton.Location = new System.Drawing.Point(23, 180);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(437, 45);
            this.patchButton.Style = MetroFramework.MetroColorStyle.White;
            this.patchButton.TabIndex = 24;
            this.patchButton.Text = "PATCH";
            this.patchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.patchButton.UseSelectable = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // selectUnity
            // 
            this.selectUnity.Location = new System.Drawing.Point(23, 145);
            this.selectUnity.Name = "selectUnity";
            this.selectUnity.Size = new System.Drawing.Size(75, 29);
            this.selectUnity.Style = MetroFramework.MetroColorStyle.White;
            this.selectUnity.TabIndex = 25;
            this.selectUnity.Text = "SELECT";
            this.selectUnity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectUnity.UseSelectable = true;
            this.selectUnity.Click += new System.EventHandler(this.SelectClick);
            // 
            // pathTextbox
            // 
            // 
            // 
            // 
            this.pathTextbox.CustomButton.Image = null;
            this.pathTextbox.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.pathTextbox.CustomButton.Name = "";
            this.pathTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pathTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pathTextbox.CustomButton.TabIndex = 1;
            this.pathTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pathTextbox.CustomButton.UseSelectable = true;
            this.pathTextbox.CustomButton.Visible = false;
            this.pathTextbox.Lines = new string[] {
        "Please select your Unity EXE..."};
            this.pathTextbox.Location = new System.Drawing.Point(104, 148);
            this.pathTextbox.MaxLength = 32767;
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.PasswordChar = '\0';
            this.pathTextbox.ReadOnly = true;
            this.pathTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pathTextbox.SelectedText = "";
            this.pathTextbox.SelectionLength = 0;
            this.pathTextbox.SelectionStart = 0;
            this.pathTextbox.ShortcutsEnabled = true;
            this.pathTextbox.Size = new System.Drawing.Size(219, 23);
            this.pathTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.pathTextbox.TabIndex = 23;
            this.pathTextbox.Text = "Please select your Unity EXE...";
            this.pathTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pathTextbox.UseSelectable = true;
            this.pathTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pathTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.unityVersions.Style = MetroFramework.MetroColorStyle.White;
            this.unityVersions.TabIndex = 22;
            this.unityVersions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.unityVersions.UseSelectable = true;
            // 
            // lightRadio
            // 
            this.lightRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.lightRadio.AutoSize = true;
            this.lightRadio.Location = new System.Drawing.Point(371, 124);
            this.lightRadio.Name = "lightRadio";
            this.lightRadio.Size = new System.Drawing.Size(89, 15);
            this.lightRadio.TabIndex = 27;
            this.lightRadio.Text = "Light Theme";
            this.lightRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lightRadio.UseSelectable = true;
            // 
            // darkRadio
            // 
            this.darkRadio.AutoSize = true;
            this.darkRadio.Checked = true;
            this.darkRadio.Location = new System.Drawing.Point(374, 102);
            this.darkRadio.Name = "darkRadio";
            this.darkRadio.Size = new System.Drawing.Size(86, 15);
            this.darkRadio.TabIndex = 28;
            this.darkRadio.TabStop = true;
            this.darkRadio.Text = "Dark Theme";
            this.darkRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.darkRadio.UseSelectable = true;
            // 
            // consoleOutput
            // 
            // 
            // 
            // 
            this.consoleOutput.CustomButton.Image = null;
            this.consoleOutput.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.consoleOutput.CustomButton.Name = "";
            this.consoleOutput.CustomButton.Size = new System.Drawing.Size(289, 289);
            this.consoleOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleOutput.CustomButton.TabIndex = 1;
            this.consoleOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleOutput.CustomButton.UseSelectable = true;
            this.consoleOutput.CustomButton.Visible = false;
            this.consoleOutput.Lines = new string[0];
            this.consoleOutput.Location = new System.Drawing.Point(23, 240);
            this.consoleOutput.MaxLength = 9999999;
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.PasswordChar = '\0';
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleOutput.SelectedText = "";
            this.consoleOutput.SelectionLength = 0;
            this.consoleOutput.SelectionStart = 0;
            this.consoleOutput.ShortcutsEnabled = true;
            this.consoleOutput.Size = new System.Drawing.Size(437, 291);
            this.consoleOutput.Style = MetroFramework.MetroColorStyle.White;
            this.consoleOutput.TabIndex = 29;
            this.consoleOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.consoleOutput.UseSelectable = true;
            this.consoleOutput.Visible = false;
            this.consoleOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // forceCheck
            // 
            this.forceCheck.AutoSize = true;
            this.forceCheck.Location = new System.Drawing.Point(23, 124);
            this.forceCheck.Name = "forceCheck";
            this.forceCheck.Size = new System.Drawing.Size(85, 15);
            this.forceCheck.Style = MetroFramework.MetroColorStyle.White;
            this.forceCheck.TabIndex = 30;
            this.forceCheck.Text = "Force Patch";
            this.forceCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.forceCheck.UseSelectable = true;
            // 
            // PatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 256);
            this.Controls.Add(this.forceCheck);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.darkRadio);
            this.Controls.Add(this.lightRadio);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.selectUnity);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.unityVersions);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatcherForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PatcherFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton patchButton;
        public MetroFramework.Controls.MetroButton selectUnity;
        public MetroFramework.Controls.MetroTextBox pathTextbox;
        public MetroFramework.Controls.MetroComboBox unityVersions;
        private MetroFramework.Controls.MetroRadioButton lightRadio;
        private MetroFramework.Controls.MetroRadioButton darkRadio;
        private MetroFramework.Controls.MetroTextBox consoleOutput;
        private MetroFramework.Controls.MetroCheckBox forceCheck;
    }
}

