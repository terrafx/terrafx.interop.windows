// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX.D3D12;
namespace TerraFX.Samples.WinForms
{
    public class Dx12Panel : Panel
    {
        private readonly Dx12Viewport _dxVp;
        public Dx12Viewport DxVp => _dxVp;

        public Dx12Panel(int width, int height) : base()
        {
            _dxVp = InitDxVp(width, height);
            Resize += Dx12Panel_Resize;
        }

        private Dx12Viewport InitDxVp(int width, int height)
        {
            var dxVp = new Dx12Viewport((uint)width, (uint)height, "Dx12Vp", Handle);
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
