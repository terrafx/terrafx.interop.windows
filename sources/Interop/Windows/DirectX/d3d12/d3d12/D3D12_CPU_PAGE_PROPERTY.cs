// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY"]/*' />
public enum D3D12_CPU_PAGE_PROPERTY
{
    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_UNKNOWN"]/*' />
    D3D12_CPU_PAGE_PROPERTY_UNKNOWN = 0,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE"]/*' />
    D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE = 1,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE"]/*' />
    D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE = 2,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_WRITE_BACK"]/*' />
    D3D12_CPU_PAGE_PROPERTY_WRITE_BACK = 3,
}
