// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1"]/*' />
public partial struct D3D12_ROOT_DESCRIPTOR1
{
    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.ShaderRegister"]/*' />
    public uint ShaderRegister;

    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.RegisterSpace"]/*' />
    public uint RegisterSpace;

    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.Flags"]/*' />
    public D3D12_ROOT_DESCRIPTOR_FLAGS Flags;
}
