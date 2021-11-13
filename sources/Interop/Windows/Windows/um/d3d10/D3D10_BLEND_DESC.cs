// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D10_BLEND_DESC
    {
        public BOOL AlphaToCoverageEnable;

        [NativeTypeName("BOOL [8]")]
        public _BlendEnable_e__FixedBuffer BlendEnable;

        public D3D10_BLEND SrcBlend;

        public D3D10_BLEND DestBlend;

        public D3D10_BLEND_OP BlendOp;

        public D3D10_BLEND SrcBlendAlpha;

        public D3D10_BLEND DestBlendAlpha;

        public D3D10_BLEND_OP BlendOpAlpha;

        [NativeTypeName("UINT8 [8]")]
        public fixed byte RenderTargetWriteMask[8];

        public partial struct _BlendEnable_e__FixedBuffer
        {
            public BOOL e0;
            public BOOL e1;
            public BOOL e2;
            public BOOL e3;
            public BOOL e4;
            public BOOL e5;
            public BOOL e6;
            public BOOL e7;

            public ref BOOL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<BOOL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
