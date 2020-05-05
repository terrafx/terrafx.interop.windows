using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using TerraFX.Samples.DirectX.D3D12;


namespace WinFormsDx12
{
    class Dx12Panel : Panel
    {
        private Dx12Viewport _dxVp;
        public Dx12Viewport DxVp { get => _dxVp; }

        public Dx12Panel(int width, int height) : base()
        {
            _dxVp = InitDxVp(width, height);
            this.Resize += Dx12Panel_Resize;
        }

        private Dx12Viewport InitDxVp(int width, int height)
        {
            IntPtr hWnd = this.Handle;
            var dxVp = new Dx12Viewport((uint)width, (uint)height, "Dx12Vp", hWnd);
            dxVp.OnInit();
            return dxVp;
        }

        private void Dx12Panel_Resize(object? sender, EventArgs e)
        {
            _dxVp.OnResize((uint)Width, (uint)Height);
            // _dxVp.OnInit(); // IB: crashes on resoure reinitialization, needs instead a _dxVp.OnResize that updates existing resources
            _dxVp.OnRender();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _dxVp.OnRender();
        }
    }
}
