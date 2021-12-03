// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS"]/*' />
[Flags]
public enum D3D12_RLDO_FLAGS
{
    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_NONE"]/*' />
    D3D12_RLDO_NONE = 0,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_SUMMARY"]/*' />
    D3D12_RLDO_SUMMARY = 0x1,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_DETAIL"]/*' />
    D3D12_RLDO_DETAIL = 0x2,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_IGNORE_INTERNAL"]/*' />
    D3D12_RLDO_IGNORE_INTERNAL = 0x4,
}
