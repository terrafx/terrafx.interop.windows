// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.HeapDesc"]/*' />
    public D3D12_VIDEO_ENCODER_HEAP_DESC1 HeapDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.MemoryPoolL0Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1.MemoryPoolL1Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
