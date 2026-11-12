// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT"]/*' />
public unsafe partial struct D3D12_VIDEO_PROCESS_TRANSFORM_LUT
{
    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.Configuration"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION Configuration;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.UpdateFlags"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS UpdateFlags;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.pCSCMatrix"]/*' />
    [NativeTypeName("float[4][3]")]
    public _pCSCMatrix_e__FixedBuffer pCSCMatrix;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.p1DLUTtransform"]/*' />
    public ID3D12Resource* p1DLUTtransform;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.Subresource1DLUT"]/*' />
    public uint Subresource1DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.p1DLUTInputSpacing"]/*' />
    public ID3D12Resource* p1DLUTInputSpacing;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.Subresource1DLUTInputSpacing"]/*' />
    public uint Subresource1DLUTInputSpacing;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM_LUT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM_LUT.p3DLUTTransform"]/*' />
    public ID3D12Resource* p3DLUTTransform;

    /// <include file='_pCSCMatrix_e__FixedBuffer.xml' path='doc/member[@name="_pCSCMatrix_e__FixedBuffer"]/*' />
    [InlineArray(4 * 3)]
    public partial struct _pCSCMatrix_e__FixedBuffer
    {
        public float e0_0;
    }
}
