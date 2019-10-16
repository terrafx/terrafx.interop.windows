// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11;

namespace TerraFX.Interop
{
    public partial struct D3D11_BLEND_DESC1
    {
        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        [NativeTypeName("BOOL")]
        public int IndependentBlendEnable;

        [NativeTypeName("D3D11_RENDER_TARGET_BLEND_DESC1 [D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT]")]
        public _RenderTarget_e__FixedBuffer RenderTarget;

        public partial struct _RenderTarget_e__FixedBuffer
        {
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e0;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e1;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e2;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e3;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e4;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e5;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e6;
            internal D3D11_RENDER_TARGET_BLEND_DESC1 e7;

            public ref D3D11_RENDER_TARGET_BLEND_DESC1 this[int index] => ref AsSpan()[index];

            public Span<D3D11_RENDER_TARGET_BLEND_DESC1> AsSpan() => MemoryMarshal.CreateSpan(ref e0, unchecked((int)D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT));
        }
    }
}
