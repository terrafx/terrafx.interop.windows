// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ROOT_CONSTANTS.xml' path='doc/member[@name="D3D12_ROOT_CONSTANTS"]/*' />
public partial struct D3D12_ROOT_CONSTANTS
{
    /// <include file='D3D12_ROOT_CONSTANTS.xml' path='doc/member[@name="D3D12_ROOT_CONSTANTS.ShaderRegister"]/*' />
    public uint ShaderRegister;

    /// <include file='D3D12_ROOT_CONSTANTS.xml' path='doc/member[@name="D3D12_ROOT_CONSTANTS.RegisterSpace"]/*' />
    public uint RegisterSpace;

    /// <include file='D3D12_ROOT_CONSTANTS.xml' path='doc/member[@name="D3D12_ROOT_CONSTANTS.Num32BitValues"]/*' />
    public uint Num32BitValues;
}
