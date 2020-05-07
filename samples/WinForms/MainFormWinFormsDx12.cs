// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX.D3D12;

namespace TerraFX.Samples.WinForms
{
    public partial class MainFormWinFormsDX12 : Form
    {
        private readonly DX12Viewport _dxVp;

        public MainFormWinFormsDX12()
        {
            InitializeComponent();
            _dxVp = InitDx12();
        }

        private DX12Viewport InitDx12()
        {
            var dxPanel = new DX12Panel(MainSplitter.Panel2.Width, MainSplitter.Panel2.Height);
            MainSplitter.Panel2.Controls.Add(dxPanel);
            dxPanel.Dock = DockStyle.Fill;
            return dxPanel.Viewport;
        }

        private void ColorBtn_Click(object sender, EventArgs e) => _dxVp.OnRender();

        private void TextureBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
