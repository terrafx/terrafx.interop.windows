// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DISPATCH_MODE.xml' path='doc/member[@name="D3D12_DISPATCH_MODE"]/*' />
public enum D3D12_DISPATCH_MODE
{
    /// <include file='D3D12_DISPATCH_MODE.xml' path='doc/member[@name="D3D12_DISPATCH_MODE.D3D12_DISPATCH_MODE_NODE_CPU_INPUT"]/*' />
    D3D12_DISPATCH_MODE_NODE_CPU_INPUT = 0,

    /// <include file='D3D12_DISPATCH_MODE.xml' path='doc/member[@name="D3D12_DISPATCH_MODE.D3D12_DISPATCH_MODE_NODE_GPU_INPUT"]/*' />
    D3D12_DISPATCH_MODE_NODE_GPU_INPUT = 1,

    /// <include file='D3D12_DISPATCH_MODE.xml' path='doc/member[@name="D3D12_DISPATCH_MODE.D3D12_DISPATCH_MODE_MULTI_NODE_CPU_INPUT"]/*' />
    D3D12_DISPATCH_MODE_MULTI_NODE_CPU_INPUT = 2,

    /// <include file='D3D12_DISPATCH_MODE.xml' path='doc/member[@name="D3D12_DISPATCH_MODE.D3D12_DISPATCH_MODE_MULTI_NODE_GPU_INPUT"]/*' />
    D3D12_DISPATCH_MODE_MULTI_NODE_GPU_INPUT = 3,
}
