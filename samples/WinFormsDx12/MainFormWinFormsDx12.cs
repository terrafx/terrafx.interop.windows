using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraFX.Interop;
using TerraFX.Samples.DirectX.D3D12;

namespace WinFormsDx12
{
    public partial class MainFormWinFormsDx12 : Form
    {
        private Dx12Viewport _dxVp;

        public MainFormWinFormsDx12()
        {
            InitializeComponent();
            _dxVp = InitDx12();
        }

        private Dx12Viewport InitDx12()
        {
            var dxPanel = new Dx12Panel(MainSplitter.Panel2.Width, MainSplitter.Panel2.Height);
            MainSplitter.Panel2.Controls.Add(dxPanel);
            dxPanel.Dock = DockStyle.Fill;
            return dxPanel.DxVp;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            _dxVp.OnRender();
        }

        private void TextureBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
