// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
    {
        [NativeTypeName("UINT")]
        public uint NumFrameArguments;

        [NativeTypeName("D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        public _FrameArguments_e__FixedBuffer FrameArguments;

        public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;

        public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;

        [NativeTypeName("ID3D12VideoDecoderHeap *")]
        public ID3D12VideoDecoderHeap* pHeap;

        public partial struct _FrameArguments_e__FixedBuffer
        {
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e0;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e1;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e2;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e3;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e4;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e5;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e6;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e7;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e8;
            internal D3D12_VIDEO_DECODE_FRAME_ARGUMENT e9;

            public ref D3D12_VIDEO_DECODE_FRAME_ARGUMENT this[int index] => ref AsSpan()[index];

            public Span<D3D12_VIDEO_DECODE_FRAME_ARGUMENT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 10);
        }
    }
}
