using MaterialThemeCore;
using MaterialThemeCore.MaterialControls;
using MaterialThemeCore.Animations;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Patcher
{
    public partial class PatcherForm : MaterialThemeForm
    {
        private string unityExePath;

        public PatcherForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialTheme.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialTheme.Themes.DARK;
            materialSkinManager.MaterialColor = new MaterialColor(Primary.Grey700, Primary.Grey700, Primary.Orange700, Accent.Blue100, TextShade.WHITE);
        }

        private void PatcherFormLoad(object sender, EventArgs e)
        {
            unityVersions.SelectedIndex = 0;
        }

        private void SelectClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Unity Editor|Unity.exe";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    unityExePath = openFileDialog.FileName;
                    pathTextbox.Text = unityExePath;

                    patchButton.Enabled = true;
                }
            }
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            string theme = null;

            if (darkRadio.Checked)
                theme = "dark";
            else if (lightRadio.Checked)
                theme = "light";
            else
                Error("Theme has not been selected, please select one and try again.");

            ShowConsole();

            #region StartInfo
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.ErrorDialog = false;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.FileName = "Patcher.exe";
            if (forceCheck.Checked)
                processStartInfo.Arguments = $"--windows --version={unityVersions.SelectedItem} --t={theme} --e={unityExePath} --force";
            else
                processStartInfo.Arguments = $"--windows --version={unityVersions.SelectedItem} --t={theme} --e={unityExePath}";
            #endregion

            #region Execution
            Process process = new Process();
            process.StartInfo = processStartInfo;
            bool processStarted = process.Start();
            if (processStarted)
            {
                StreamReader outputReader = process.StandardOutput;
                process.WaitForExit();

                string displayText = "";
                displayText += outputReader.ReadToEnd();
                consoleOutput.Text = displayText;
            }
            #endregion
        }

        private void ShowConsole()
        {
            // Original Size: 492, 256
            Height = 544;
            consoleOutput.Visible = true;
        }

        private void Error(string message)
        {
            var msgBox = MessageBox.Show(message, "An error has occured", MessageBoxButtons.OKCancel);
            if (msgBox == DialogResult.Cancel)
                Environment.Exit(0);
        }
    }
}