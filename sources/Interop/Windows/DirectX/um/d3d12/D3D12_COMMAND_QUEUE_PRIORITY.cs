// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PRIORITY"]/*' />
public enum D3D12_COMMAND_QUEUE_PRIORITY
{
    /// <include file='D3D12_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PRIORITY.D3D12_COMMAND_QUEUE_PRIORITY_NORMAL"]/*' />
    D3D12_COMMAND_QUEUE_PRIORITY_NORMAL = 0,

    /// <include file='D3D12_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PRIORITY.D3D12_COMMAND_QUEUE_PRIORITY_HIGH"]/*' />
    D3D12_COMMAND_QUEUE_PRIORITY_HIGH = 100,

    /// <include file='D3D12_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PRIORITY.D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME"]/*' />
    D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME = 10000,
}
