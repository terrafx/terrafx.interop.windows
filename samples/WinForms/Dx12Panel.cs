// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Windows.Forms;
using TerraFX.Samples.DirectX.D3D12;
namespace TerraFX.Samples.WinForms
{
    public class DX12Panel : Panel
    {
        private readonly DX12Viewport _viewport;
        public DX12Viewport Viewport => _viewport;

        public DX12Panel(int width, int height) : base()
        {
            _viewport = InitializeViewport(width, height);
            Resize += OnResize;
        }

        private DX12Viewport InitializeViewport(int width, int height)
        {
            if (width <= 0 || height <= 0) throw new ArgumentException("width and height must be positive and non-zero");
            var viewport = new DX12Viewport((uint)width, (uint)height, Handle);
            viewport.OnInit();
            return viewport;
        }

        private void OnResize(object? sender, EventArgs eventArgs)
        {
            Viewport.OnResize((uint)Width, (uint)Height);
            // Viewport.OnInit(); // IB: crashes on resoure reinitialization, needs instead a _dxVp.OnResize that updates existing resources
            Viewport.OnRender();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Viewport.OnRender();
        }
    }
}
