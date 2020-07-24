using System.Drawing;
using System.Windows.Forms;

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
            this.patchButton = new System.Windows.Forms.Button();
            this.selectUnity = new System.Windows.Forms.Button();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.unityVersions = new System.Windows.Forms.ComboBox();
            this.darkRadio = new System.Windows.Forms.RadioButton();
            this.consoleOutput = new System.Windows.Forms.TextBox();
            this.forceCheck = new System.Windows.Forms.CheckBox();
            this.lightRadio = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.Enabled = false;
            this.patchButton.Location = new System.Drawing.Point(23, 180);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(437, 45);
            this.patchButton.BackColor = Color.LightGray;
            this.patchButton.TabIndex = 24;
            this.patchButton.Text = "PATCH";
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // selectUnity
            // 
            this.selectUnity.Location = new System.Drawing.Point(23, 145);
            this.selectUnity.Name = "selectUnity";
            this.selectUnity.Size = new System.Drawing.Size(75, 29);
            this.selectUnity.TabIndex = 25;
            this.selectUnity.Text = "SELECT";
            this.selectUnity.ForeColor = Color.Black;
            this.selectUnity.Click += new System.EventHandler(this.SelectClick);
            this.selectUnity.BackColor = Color.LightGray;
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(104, 148);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.ReadOnly = true;
            this.pathTextbox.Size = new System.Drawing.Size(219, 20);
            this.pathTextbox.TabIndex = 23;
            this.pathTextbox.Text = "Please select your Unity EXE...";
            // 
            // unityVersions
            // 
            this.unityVersions.FormattingEnabled = true;
            this.unityVersions.ItemHeight = 13;
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
            this.unityVersions.Size = new System.Drawing.Size(131, 21);
            this.unityVersions.TabIndex = 22;
            // 
            // darkRadio
            // 
            this.darkRadio.AutoSize = true;
            this.darkRadio.Checked = true;
            this.darkRadio.Location = new System.Drawing.Point(374, 102);
            this.darkRadio.Name = "darkRadio";
            this.darkRadio.Size = new System.Drawing.Size(84, 17);
            this.darkRadio.TabIndex = 28;
            this.darkRadio.Text = "Dark Theme";
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(23, 240);
            this.consoleOutput.MaxLength = 9999999;
            this.consoleOutput.Multiline = true;
            this.consoleOutput.BackColor = Color.FromArgb(38, 42, 43);
            this.consoleOutput.ForeColor = Color.White;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.Size = new System.Drawing.Size(437, 291);
            this.consoleOutput.TabIndex = 29;
            this.consoleOutput.Visible = false;
            // 
            // forceCheck
            // 
            this.forceCheck.AutoSize = true;
            this.forceCheck.Location = new System.Drawing.Point(23, 124);
            this.forceCheck.Name = "forceCheck";
            this.forceCheck.Size = new System.Drawing.Size(84, 17);
            this.forceCheck.TabIndex = 30;
            this.forceCheck.Text = "Force Patch";
            // 
            // lightRadio
            // 
            this.lightRadio.AutoSize = true;
            this.lightRadio.Location = new System.Drawing.Point(374, 125);
            this.lightRadio.Name = "lightRadio";
            this.lightRadio.Size = new System.Drawing.Size(84, 17);
            this.lightRadio.TabIndex = 31;
            this.lightRadio.Text = "Light Theme";
            // 
            // PatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 256);
            this.Controls.Add(this.lightRadio);
            this.Controls.Add(this.forceCheck);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.darkRadio);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.selectUnity);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.unityVersions);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Sizable = false;
            this.Name = "PatcherForm";
            this.Load += new System.EventHandler(this.PatcherFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button patchButton;
        public Button selectUnity;
        public TextBox pathTextbox;
        public ComboBox unityVersions;
        private RadioButton darkRadio;
        private TextBox consoleOutput;
        private CheckBox forceCheck;
        private RadioButton lightRadio;
        private Label nameLabel;
    }
}

