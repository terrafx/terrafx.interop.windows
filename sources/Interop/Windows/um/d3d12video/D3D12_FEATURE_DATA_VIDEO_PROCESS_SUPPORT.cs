// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
    {
        [NativeTypeName("UINT")]
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
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e1;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e2;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e3;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e4;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e5;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e6;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e7;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e8;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e9;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e10;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e11;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e12;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e13;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e14;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e15;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e16;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e17;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e18;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e19;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e20;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e21;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e22;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e23;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e24;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e25;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e26;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e27;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e28;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e29;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e30;
            internal D3D12_VIDEO_PROCESS_FILTER_RANGE e31;

            public ref D3D12_VIDEO_PROCESS_FILTER_RANGE this[int index] => ref AsSpan()[index];

            public Span<D3D12_VIDEO_PROCESS_FILTER_RANGE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
