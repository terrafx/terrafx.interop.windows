// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.TransformationType"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION TransformationType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.TransformationMatrix"]/*' />
    [NativeTypeName("INT[8]")]
    public _TransformationMatrix_e__FixedBuffer TransformationMatrix;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO.InvalidAffineSet"]/*' />
    public BOOL InvalidAffineSet;

    /// <include file='_TransformationMatrix_e__FixedBuffer.xml' path='doc/member[@name="_TransformationMatrix_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _TransformationMatrix_e__FixedBuffer
    {
        public int e0;
    }
}
