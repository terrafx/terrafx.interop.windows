// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE"]/*' />
public partial struct D3D12_TILED_RESOURCE_COORDINATE
{
    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.X"]/*' />
    public uint X;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Y"]/*' />
    public uint Y;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Z"]/*' />
    public uint Z;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Subresource"]/*' />
    public uint Subresource;
}
