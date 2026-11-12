// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC"]/*' />
public unsafe partial struct D3D12_FILL_BUFFER_DESC
{
    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.pBuffer"]/*' />
    public ID3D12Resource* pBuffer;

    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.FillValue"]/*' />
    public D3D12_CLEAR_DATA FillValue;

    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.RawPatternSizeInBytes"]/*' />
    public uint RawPatternSizeInBytes;

    /// <include file='D3D12_FILL_BUFFER_DESC.xml' path='doc/member[@name="D3D12_FILL_BUFFER_DESC.RepeatCount"]/*' />
    public uint RepeatCount;
}
