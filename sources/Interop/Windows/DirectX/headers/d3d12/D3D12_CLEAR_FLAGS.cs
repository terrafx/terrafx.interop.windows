// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CLEAR_FLAGS.xml' path='doc/member[@name="D3D12_CLEAR_FLAGS"]/*' />
[Flags]
public enum D3D12_CLEAR_FLAGS
{
    /// <include file='D3D12_CLEAR_FLAGS.xml' path='doc/member[@name="D3D12_CLEAR_FLAGS.D3D12_CLEAR_FLAG_DEPTH"]/*' />
    D3D12_CLEAR_FLAG_DEPTH = 0x1,

    /// <include file='D3D12_CLEAR_FLAGS.xml' path='doc/member[@name="D3D12_CLEAR_FLAGS.D3D12_CLEAR_FLAG_STENCIL"]/*' />
    D3D12_CLEAR_FLAG_STENCIL = 0x2,
}
