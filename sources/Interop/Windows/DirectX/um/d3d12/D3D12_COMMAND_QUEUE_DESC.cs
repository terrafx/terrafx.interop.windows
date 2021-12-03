// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC"]/*' />
public partial struct D3D12_COMMAND_QUEUE_DESC
{
    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Type"]/*' />
    public D3D12_COMMAND_LIST_TYPE Type;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Priority"]/*' />
    public int Priority;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Flags"]/*' />
    public D3D12_COMMAND_QUEUE_FLAGS Flags;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.NodeMask"]/*' />
    public uint NodeMask;
}
