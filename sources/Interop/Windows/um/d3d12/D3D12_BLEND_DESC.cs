// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public struct D3D12_BLEND_DESC
    {
        public static readonly D3D12_BLEND_DESC DEFAULT = new D3D12_BLEND_DESC() {
            AlphaToCoverageEnable = FALSE, IndependentBlendEnable = FALSE, RenderTarget = new _RenderTarget_e__FixedBuffer() {
                e0 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e1 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e2 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e3 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e4 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e5 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e6 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT, e7 = D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT
            }
        };

        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        [NativeTypeName("BOOL")]
        public int IndependentBlendEnable;

        [NativeTypeName("D3D12_RENDER_TARGET_BLEND_DESC[8]")]
        public _RenderTarget_e__FixedBuffer RenderTarget;

        public unsafe struct _RenderTarget_e__FixedBuffer
        {
            public D3D12_RENDER_TARGET_BLEND_DESC e0;

            public D3D12_RENDER_TARGET_BLEND_DESC e1;

            public D3D12_RENDER_TARGET_BLEND_DESC e2;

            public D3D12_RENDER_TARGET_BLEND_DESC e3;

            public D3D12_RENDER_TARGET_BLEND_DESC e4;

            public D3D12_RENDER_TARGET_BLEND_DESC e5;

            public D3D12_RENDER_TARGET_BLEND_DESC e6;

            public D3D12_RENDER_TARGET_BLEND_DESC e7;

            public ref D3D12_RENDER_TARGET_BLEND_DESC this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<D3D12_RENDER_TARGET_BLEND_DESC> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
