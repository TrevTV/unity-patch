using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patcher
{
    public partial class PatcherForm : MetroFramework.Forms.MetroForm
    {
        string unityExePath;

        public PatcherForm()
        {
            InitializeComponent();
        }

        private void PatcherFormLoad(object sender, EventArgs e)
        {
            unityVersions.SelectedIndex = 0;
        }

        private void SelectClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Unity Editor (*.exe)|*.exe";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    unityExePath = openFileDialog.FileName;
                    pathTextbox.Text = unityExePath;
                }
            }
        }
    }
}
