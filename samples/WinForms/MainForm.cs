// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX;

namespace TerraFX.Samples.WinForms
{
    public partial class MainForm : Form
    {
        private uint _lastFramesPerSecond;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            _samplesListBox.Items.AddRange(DXSample.Samples);
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object? sender, EventArgs e)
        {
            var dxSample = _dxPanel.DXSample;

            if (dxSample is null)
            {
                return;
            }

            var delta = dxSample.OnBeginFrame();
            dxSample.OnUpdate(delta);

            var framesPerSecond = dxSample.FramesPerSecond;

            if (framesPerSecond != _lastFramesPerSecond)
            {
                Text = $"{dxSample.Name} ({framesPerSecond} fps)";
                _lastFramesPerSecond = framesPerSecond;
            }

            if (dxSample.IsWindowVisible)
            {
                dxSample.OnRender();
                _dxPanel.Invalidate();
            }
        }

        private void samplesListBox_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            _dxPanel.BackColor = colorDialog1.Color;
            _dxPanel.DXSample = _samplesListBox.SelectedItem as DXSample;
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _dxPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}
