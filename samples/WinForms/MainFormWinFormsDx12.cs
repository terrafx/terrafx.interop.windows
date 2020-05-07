// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;

namespace TerraFX.Samples.WinForms
{
    public partial class MainFormWinFormsDX12 : Form
    {
        private readonly DX12Panel _panel;

        public MainFormWinFormsDX12()
        {
            InitializeComponent();
            _panel = InitDX12Panel();
        }

        private DX12Panel InitDX12Panel()
        {
            var dxPanel = new DX12Panel(MainSplitter.Panel2.Width, MainSplitter.Panel2.Height);
            MainSplitter.Panel2.Controls.Add(dxPanel);
            dxPanel.Dock = DockStyle.Fill;
            return dxPanel;
        }

        private void ColorBtn_Click(object sender, EventArgs e) => _panel.OnRender();

        private void TextureBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
