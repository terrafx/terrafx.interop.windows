// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pOutputTexture2D;

        [NativeTypeName("UINT")]
        public uint OutputSubresource;

        public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;

        [NativeTypeName("D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]")]
        public _Histograms_e__FixedBuffer Histograms;

        public partial struct _Histograms_e__FixedBuffer
        {
            internal D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e0;
            internal D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e1;
            internal D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e2;
            internal D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e3;

            public ref D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM this[int index] => ref AsSpan()[index];

            public Span<D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, unchecked((int)D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS));
        }
    }
}
