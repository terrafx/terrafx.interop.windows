// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.pOutputStreamDesc"]/*' />
    [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
    public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.NumInputStreamDescs"]/*' />
    public uint NumInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.pInputStreamDescs"]/*' />
    [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1 *")]
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1* pInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.Protected"]/*' />
    public BOOL Protected;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.MemoryPoolL0Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE2.MemoryPoolL1Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
