// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_FORMAT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_INFO"]/*' />
public partial struct D3D12_FEATURE_DATA_FORMAT_INFO
{
    /// <include file='D3D12_FEATURE_DATA_FORMAT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_INFO.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FEATURE_DATA_FORMAT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_INFO.PlaneCount"]/*' />
    [NativeTypeName("UINT8")]
    public byte PlaneCount;
}
