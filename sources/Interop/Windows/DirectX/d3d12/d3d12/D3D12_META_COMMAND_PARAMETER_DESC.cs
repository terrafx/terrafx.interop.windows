// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC"]/*' />
public unsafe partial struct D3D12_META_COMMAND_PARAMETER_DESC
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Type"]/*' />
    public D3D12_META_COMMAND_PARAMETER_TYPE Type;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Flags"]/*' />
    public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.RequiredResourceState"]/*' />
    public D3D12_RESOURCE_STATES RequiredResourceState;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.StructureOffset"]/*' />
    public uint StructureOffset;
}
