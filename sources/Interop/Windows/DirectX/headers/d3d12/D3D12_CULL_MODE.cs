// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CULL_MODE.xml' path='doc/member[@name="D3D12_CULL_MODE"]/*' />
public enum D3D12_CULL_MODE
{
    /// <include file='D3D12_CULL_MODE.xml' path='doc/member[@name="D3D12_CULL_MODE.D3D12_CULL_MODE_NONE"]/*' />
    D3D12_CULL_MODE_NONE = 1,

    /// <include file='D3D12_CULL_MODE.xml' path='doc/member[@name="D3D12_CULL_MODE.D3D12_CULL_MODE_FRONT"]/*' />
    D3D12_CULL_MODE_FRONT = 2,

    /// <include file='D3D12_CULL_MODE.xml' path='doc/member[@name="D3D12_CULL_MODE.D3D12_CULL_MODE_BACK"]/*' />
    D3D12_CULL_MODE_BACK = 3,
}
