// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D10_BLEND_DESC1
    {
        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        [NativeTypeName("BOOL")]
        public int IndependentBlendEnable;

        [NativeTypeName("D3D10_RENDER_TARGET_BLEND_DESC1 [8]")]
        public _RenderTarget_e__FixedBuffer RenderTarget;

        public partial struct _RenderTarget_e__FixedBuffer
        {
            public D3D10_RENDER_TARGET_BLEND_DESC1 e0;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e1;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e2;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e3;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e4;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e5;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e6;
            public D3D10_RENDER_TARGET_BLEND_DESC1 e7;

            public ref D3D10_RENDER_TARGET_BLEND_DESC1 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D10_RENDER_TARGET_BLEND_DESC1> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
