// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS
    {
        [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM [2]")]
        public _InputStream_e__FixedBuffer InputStream;

        public D3D12_VIDEO_PROCESS_TRANSFORM Transform;

        public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;

        public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;

        [NativeTypeName("INT [32]")]
        public fixed int FilterLevels[32];

        public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;

        public partial struct _InputStream_e__FixedBuffer
        {
            public D3D12_VIDEO_PROCESS_INPUT_STREAM e0;
            public D3D12_VIDEO_PROCESS_INPUT_STREAM e1;

            public unsafe ref D3D12_VIDEO_PROCESS_INPUT_STREAM this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<D3D12_VIDEO_PROCESS_INPUT_STREAM> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 2);
#else
                return new Span<D3D12_VIDEO_PROCESS_INPUT_STREAM>((D3D12_VIDEO_PROCESS_INPUT_STREAM*)Unsafe.AsPointer(ref this), 2);
#endif
            }
        }
    }
}
