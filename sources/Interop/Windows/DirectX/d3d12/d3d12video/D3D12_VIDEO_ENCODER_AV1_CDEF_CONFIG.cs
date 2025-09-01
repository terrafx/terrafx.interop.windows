// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefBits"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CdefBits;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefDampingMinus3"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CdefDampingMinus3;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefYPriStrength"]/*' />
    [NativeTypeName("UINT64[8]")]
    public _CdefYPriStrength_e__FixedBuffer CdefYPriStrength;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefUVPriStrength"]/*' />
    [NativeTypeName("UINT64[8]")]
    public _CdefUVPriStrength_e__FixedBuffer CdefUVPriStrength;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefYSecStrength"]/*' />
    [NativeTypeName("UINT64[8]")]
    public _CdefYSecStrength_e__FixedBuffer CdefYSecStrength;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG.CdefUVSecStrength"]/*' />
    [NativeTypeName("UINT64[8]")]
    public _CdefUVSecStrength_e__FixedBuffer CdefUVSecStrength;

    /// <include file='_CdefYPriStrength_e__FixedBuffer.xml' path='doc/member[@name="_CdefYPriStrength_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _CdefYPriStrength_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_CdefUVPriStrength_e__FixedBuffer.xml' path='doc/member[@name="_CdefUVPriStrength_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _CdefUVPriStrength_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_CdefYSecStrength_e__FixedBuffer.xml' path='doc/member[@name="_CdefYSecStrength_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _CdefYSecStrength_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_CdefUVSecStrength_e__FixedBuffer.xml' path='doc/member[@name="_CdefUVSecStrength_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _CdefUVSecStrength_e__FixedBuffer
    {
        public ulong e0;
    }
}
