// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE"]/*' />
public enum D3D12_NODE_OVERRIDES_TYPE
{
    /// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE.D3D12_NODE_OVERRIDES_TYPE_NONE"]/*' />
    D3D12_NODE_OVERRIDES_TYPE_NONE = 0,

    /// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE.D3D12_NODE_OVERRIDES_TYPE_BROADCASTING_LAUNCH"]/*' />
    D3D12_NODE_OVERRIDES_TYPE_BROADCASTING_LAUNCH = 1,

    /// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE.D3D12_NODE_OVERRIDES_TYPE_COALESCING_LAUNCH"]/*' />
    D3D12_NODE_OVERRIDES_TYPE_COALESCING_LAUNCH = 2,

    /// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE.D3D12_NODE_OVERRIDES_TYPE_THREAD_LAUNCH"]/*' />
    D3D12_NODE_OVERRIDES_TYPE_THREAD_LAUNCH = 3,

    /// <include file='D3D12_NODE_OVERRIDES_TYPE.xml' path='doc/member[@name="D3D12_NODE_OVERRIDES_TYPE.D3D12_NODE_OVERRIDES_TYPE_COMMON_COMPUTE"]/*' />
    D3D12_NODE_OVERRIDES_TYPE_COMMON_COMPUTE = 4,
}
