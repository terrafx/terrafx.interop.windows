// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1
{
    /// <include file='D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1.NotificationMode"]/*' />
    public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE NotificationMode;

    /// <include file='D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L10217_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FrameOutputBuffer"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM FrameOutputBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FrameOutputBuffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SubregionOutputBuffers"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM SubregionOutputBuffers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SubregionOutputBuffers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FrameOutputBuffer"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM FrameOutputBuffer;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SubregionOutputBuffers"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM SubregionOutputBuffers;
    }
}
