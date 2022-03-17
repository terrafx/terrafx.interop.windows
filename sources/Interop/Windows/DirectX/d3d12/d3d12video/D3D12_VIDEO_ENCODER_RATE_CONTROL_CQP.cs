// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_FullIntracodedFrame"]/*' />
    public uint ConstantQP_FullIntracodedFrame;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_InterPredictedFrame_PrevRefOnly"]/*' />
    public uint ConstantQP_InterPredictedFrame_PrevRefOnly;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_InterPredictedFrame_BiDirectionalRef"]/*' />
    public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
}
