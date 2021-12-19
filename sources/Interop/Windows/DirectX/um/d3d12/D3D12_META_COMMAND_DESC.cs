// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_META_COMMAND_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_DESC"]/*' />
public unsafe partial struct D3D12_META_COMMAND_DESC
{
    /// <include file='D3D12_META_COMMAND_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_DESC.Id"]/*' />
    public Guid Id;

    /// <include file='D3D12_META_COMMAND_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_DESC.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_META_COMMAND_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_DESC.InitializationDirtyState"]/*' />
    public D3D12_GRAPHICS_STATES InitializationDirtyState;

    /// <include file='D3D12_META_COMMAND_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_DESC.ExecutionDirtyState"]/*' />
    public D3D12_GRAPHICS_STATES ExecutionDirtyState;
}
