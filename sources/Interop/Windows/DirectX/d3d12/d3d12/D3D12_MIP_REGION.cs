// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MIP_REGION.xml' path='doc/member[@name="D3D12_MIP_REGION"]/*' />
public partial struct D3D12_MIP_REGION
{
    /// <include file='D3D12_MIP_REGION.xml' path='doc/member[@name="D3D12_MIP_REGION.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_MIP_REGION.xml' path='doc/member[@name="D3D12_MIP_REGION.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_MIP_REGION.xml' path='doc/member[@name="D3D12_MIP_REGION.Depth"]/*' />
    public uint Depth;
}
