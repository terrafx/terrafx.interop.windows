// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP"]/*' />
public enum D3D12_PREDICATION_OP
{
    /// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP.D3D12_PREDICATION_OP_EQUAL_ZERO"]/*' />
    D3D12_PREDICATION_OP_EQUAL_ZERO = 0,

    /// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP.D3D12_PREDICATION_OP_NOT_EQUAL_ZERO"]/*' />
    D3D12_PREDICATION_OP_NOT_EQUAL_ZERO = 1,
}
