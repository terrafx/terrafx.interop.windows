// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
    {
        public uint NodeIndex;

        public D3D12_VIDEO_SAMPLE InputSample;

        public D3D12_VIDEO_FIELD_TYPE InputFieldType;

        public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;

        public DXGI_RATIONAL InputFrameRate;

        public D3D12_VIDEO_FORMAT OutputFormat;

        public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;

        public DXGI_RATIONAL OutputFrameRate;

        public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;

        public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;

        public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;

        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;

        public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;

        public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;

        [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

        public partial struct _FilterRangeSupport_e__FixedBuffer
        {
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e1;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e2;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e3;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e4;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e5;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e6;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e7;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e8;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e9;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e10;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e11;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e12;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e13;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e14;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e15;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e16;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e17;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e18;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e19;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e20;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e21;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e22;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e23;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e24;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e25;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e26;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e27;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e28;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e29;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e30;
            public D3D12_VIDEO_PROCESS_FILTER_RANGE e31;

            public ref D3D12_VIDEO_PROCESS_FILTER_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D12_VIDEO_PROCESS_FILTER_RANGE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
