// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.LoopFilterLevel"]/*' />
    [NativeTypeName("UINT64[2]")]
    public _LoopFilterLevel_e__FixedBuffer LoopFilterLevel;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.LoopFilterLevelU"]/*' />
    [NativeTypeName("UINT64")]
    public ulong LoopFilterLevelU;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.LoopFilterLevelV"]/*' />
    [NativeTypeName("UINT64")]
    public ulong LoopFilterLevelV;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.LoopFilterSharpnessLevel"]/*' />
    [NativeTypeName("UINT64")]
    public ulong LoopFilterSharpnessLevel;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.LoopFilterDeltaEnabled"]/*' />
    [NativeTypeName("UINT64")]
    public ulong LoopFilterDeltaEnabled;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.UpdateRefDelta"]/*' />
    [NativeTypeName("UINT64")]
    public ulong UpdateRefDelta;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.RefDeltas"]/*' />
    [NativeTypeName("INT64[8]")]
    public _RefDeltas_e__FixedBuffer RefDeltas;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.UpdateModeDelta"]/*' />
    [NativeTypeName("UINT64")]
    public ulong UpdateModeDelta;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG.ModeDeltas"]/*' />
    [NativeTypeName("INT64[2]")]
    public _ModeDeltas_e__FixedBuffer ModeDeltas;

    /// <include file='_LoopFilterLevel_e__FixedBuffer.xml' path='doc/member[@name="_LoopFilterLevel_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _LoopFilterLevel_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_RefDeltas_e__FixedBuffer.xml' path='doc/member[@name="_RefDeltas_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _RefDeltas_e__FixedBuffer
    {
        public long e0;
    }

    /// <include file='_ModeDeltas_e__FixedBuffer.xml' path='doc/member[@name="_ModeDeltas_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _ModeDeltas_e__FixedBuffer
    {
        public long e0;
    }
}
