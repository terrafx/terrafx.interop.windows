// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO"]/*' />
public partial struct D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO
{
    /// <include file='D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.Dimension"]/*' />
    public D3D12_RESOURCE_DIMENSION Dimension;

    /// <include file='D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.DestHeapProperties"]/*' />
    public D3D12_HEAP_PROPERTIES DestHeapProperties;

    /// <include file='D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO.Supported"]/*' />
    public BOOL Supported;
}
