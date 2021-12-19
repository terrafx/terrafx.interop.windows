// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS"]/*' />
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.OutputStream"]/*' />
    [NativeTypeName("D3D12_VIDEO_PROCESS_OUTPUT_STREAM [2]")]
    public _OutputStream_e__FixedBuffer OutputStream;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.TargetRectangle"]/*' />
    [NativeTypeName("D3D12_RECT")]
    public RECT TargetRectangle;

    /// <include file='_OutputStream_e__FixedBuffer.xml' path='doc/member[@name="_OutputStream_e__FixedBuffer"]/*' />
    public partial struct _OutputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM e0;
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM e1;

        public ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<D3D12_VIDEO_PROCESS_OUTPUT_STREAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
