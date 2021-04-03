// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
    {
        public ID3D12Resource* pOutputTexture2D;

        [NativeTypeName("UINT")]
        public uint OutputSubresource;

        public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;

        [NativeTypeName("D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        public _Histograms_e__FixedBuffer Histograms;

        public partial struct _Histograms_e__FixedBuffer
        {
            public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e0;
            public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e1;
            public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e2;
            public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e3;

            public ref D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }
}
