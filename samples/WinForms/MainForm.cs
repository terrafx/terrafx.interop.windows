// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX;

namespace TerraFX.Samples.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            _samplesListBox.Items.AddRange(DXSample.Samples);
        }

        private void samplesListBox_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            _dxPanel.BackColor = colorDialog1.Color;
            _dxPanel.DXSample = _samplesListBox.SelectedItem as DXSample;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _dxPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}
