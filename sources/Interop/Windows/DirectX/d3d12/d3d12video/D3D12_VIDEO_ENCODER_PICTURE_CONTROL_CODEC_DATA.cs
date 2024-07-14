// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L8352_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264PicData"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264* pH264PicData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264PicData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCPicData"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC* pHEVCPicData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCPicData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAV1PicData"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA* pAV1PicData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pAV1PicData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264PicData"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264* pH264PicData;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCPicData"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC* pHEVCPicData;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAV1PicData"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA* pAV1PicData;
    }
}
