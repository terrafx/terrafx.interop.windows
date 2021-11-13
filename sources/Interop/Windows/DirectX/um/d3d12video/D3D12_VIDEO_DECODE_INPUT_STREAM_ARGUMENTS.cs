// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
    {
        public uint NumFrameArguments;

        [NativeTypeName("D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        public _FrameArguments_e__FixedBuffer FrameArguments;

        public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;

        public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;

        public ID3D12VideoDecoderHeap* pHeap;

        public partial struct _FrameArguments_e__FixedBuffer
        {
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e0;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e1;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e2;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e3;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e4;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e5;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e6;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e7;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e8;
            public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e9;

            public ref D3D12_VIDEO_DECODE_FRAME_ARGUMENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D12_VIDEO_DECODE_FRAME_ARGUMENT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 10);
        }
    }
}
