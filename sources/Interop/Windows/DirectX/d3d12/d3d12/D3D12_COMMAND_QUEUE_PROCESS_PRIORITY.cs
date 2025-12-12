// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_QUEUE_PROCESS_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PROCESS_PRIORITY"]/*' />
public enum D3D12_COMMAND_QUEUE_PROCESS_PRIORITY
{
    /// <include file='D3D12_COMMAND_QUEUE_PROCESS_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PROCESS_PRIORITY.D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_NORMAL"]/*' />
    D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_NORMAL = 0,

    /// <include file='D3D12_COMMAND_QUEUE_PROCESS_PRIORITY.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_PROCESS_PRIORITY.D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_HIGH"]/*' />
    D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_HIGH = 1,
}
