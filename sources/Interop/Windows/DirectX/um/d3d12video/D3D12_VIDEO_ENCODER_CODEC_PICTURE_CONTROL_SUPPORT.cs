// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12video.h:5990:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Support"]/*' />
    public ref D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264* pH264Support
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pH264Support;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCSupport"]/*' />
    public ref D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC* pHEVCSupport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pHEVCSupport;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Support"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264* pH264Support;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCSupport"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC* pHEVCSupport;
    }
}
