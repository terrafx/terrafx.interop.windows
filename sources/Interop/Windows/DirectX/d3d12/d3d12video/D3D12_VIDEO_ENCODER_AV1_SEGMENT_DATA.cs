// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA.EnabledFeatures"]/*' />
    [NativeTypeName("UINT64")]
    public ulong EnabledFeatures;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA.FeatureValue"]/*' />
    [NativeTypeName("INT64[8]")]
    public _FeatureValue_e__FixedBuffer FeatureValue;

    /// <include file='_FeatureValue_e__FixedBuffer.xml' path='doc/member[@name="_FeatureValue_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _FeatureValue_e__FixedBuffer
    {
        public long e0;
    }
}
