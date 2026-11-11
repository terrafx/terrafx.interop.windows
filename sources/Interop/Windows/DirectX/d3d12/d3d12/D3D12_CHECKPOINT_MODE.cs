// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CHECKPOINT_MODE.xml' path='doc/member[@name="D3D12_CHECKPOINT_MODE"]/*' />
public enum D3D12_CHECKPOINT_MODE
{
    /// <include file='D3D12_CHECKPOINT_MODE.xml' path='doc/member[@name="D3D12_CHECKPOINT_MODE.D3D12_CHECKPOINT_MODE_PASSIVE"]/*' />
    D3D12_CHECKPOINT_MODE_PASSIVE = 0,

    /// <include file='D3D12_CHECKPOINT_MODE.xml' path='doc/member[@name="D3D12_CHECKPOINT_MODE.D3D12_CHECKPOINT_MODE_FULL"]/*' />
    D3D12_CHECKPOINT_MODE_FULL = 1,

    /// <include file='D3D12_CHECKPOINT_MODE.xml' path='doc/member[@name="D3D12_CHECKPOINT_MODE.D3D12_CHECKPOINT_MODE_RESTART"]/*' />
    D3D12_CHECKPOINT_MODE_RESTART = 2,

    /// <include file='D3D12_CHECKPOINT_MODE.xml' path='doc/member[@name="D3D12_CHECKPOINT_MODE.D3D12_CHECKPOINT_MODE_TRUNCATE"]/*' />
    D3D12_CHECKPOINT_MODE_TRUNCATE = 3,
}
