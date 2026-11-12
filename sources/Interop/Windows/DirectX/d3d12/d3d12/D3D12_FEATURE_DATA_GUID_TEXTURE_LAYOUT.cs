// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT
{
    /// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.pDesc"]/*' />
    [NativeTypeName("const D3D12_RESOURCE_DESC2 *")]
    public D3D12_RESOURCE_DESC2* pDesc;

    /// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.Support1"]/*' />
    public D3D12_FORMAT_SUPPORT1 Support1;

    /// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.Support2"]/*' />
    public D3D12_FORMAT_SUPPORT2 Support2;

    /// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.GuidTextureLayoutTier"]/*' />
    public D3D12_GUID_TEXTURE_LAYOUT_TIER GuidTextureLayoutTier;

    /// <include file='D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT.GuidSupported"]/*' />
    public BOOL GuidSupported;
}
