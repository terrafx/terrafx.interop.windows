// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.InputSample"]/*' />
    public D3D12_VIDEO_SAMPLE InputSample;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.InputFieldType"]/*' />
    public D3D12_VIDEO_FIELD_TYPE InputFieldType;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.InputStereoFormat"]/*' />
    public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.InputFrameRate"]/*' />
    public DXGI_RATIONAL InputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.OutputFormat"]/*' />
    public D3D12_VIDEO_FORMAT OutputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.OutputStereoFormat"]/*' />
    public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.OutputFrameRate"]/*' />
    public DXGI_RATIONAL OutputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.SupportFlags"]/*' />
    public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.ScaleSupport"]/*' />
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.FeatureSupport"]/*' />
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.DeinterlaceSupport"]/*' />
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.AutoProcessingSupport"]/*' />
    public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.FilterSupport"]/*' />
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.FilterRangeSupport"]/*' />
    [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
    public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT1.SupportLUT"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_SUPPORT SupportLUT;

    /// <include file='_FilterRangeSupport_e__FixedBuffer.xml' path='doc/member[@name="_FilterRangeSupport_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _FilterRangeSupport_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
    }
}
