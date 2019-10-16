// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS
    {
        [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM [D3D12_VIDEO_PROCESS_STEREO_VIEWS]")]
        public _InputStream_e__FixedBuffer InputStream;

        public D3D12_VIDEO_PROCESS_TRANSFORM Transform;

        public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;

        public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;

        [NativeTypeName("INT [D3D12_VIDEO_PROCESS_MAX_FILTERS]")]
        public fixed int FilterLevels[unchecked((int)D3D12_VIDEO_PROCESS_MAX_FILTERS)];

        public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;

        public partial struct _InputStream_e__FixedBuffer
        {
            internal D3D12_VIDEO_PROCESS_INPUT_STREAM e0;
            internal D3D12_VIDEO_PROCESS_INPUT_STREAM e1;

            public ref D3D12_VIDEO_PROCESS_INPUT_STREAM this[int index] => ref AsSpan()[index];

            public Span<D3D12_VIDEO_PROCESS_INPUT_STREAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, unchecked((int)D3D12_VIDEO_PROCESS_STEREO_VIEWS));
        }
    }
}
