// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_RT_FORMAT_ARRAY
    {
        [NativeTypeName("DXGI_FORMAT [8]")]
        public _RTFormats_e__FixedBuffer RTFormats;

        [NativeTypeName("UINT")]
        public uint NumRenderTargets;

        public partial struct _RTFormats_e__FixedBuffer
        {
            public DXGI_FORMAT e0;
            public DXGI_FORMAT e1;
            public DXGI_FORMAT e2;
            public DXGI_FORMAT e3;
            public DXGI_FORMAT e4;
            public DXGI_FORMAT e5;
            public DXGI_FORMAT e6;
            public DXGI_FORMAT e7;

            public ref DXGI_FORMAT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<DXGI_FORMAT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
