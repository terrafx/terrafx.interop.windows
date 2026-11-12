// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TRANSACTION_TYPE.xml' path='doc/member[@name="D3D12_TRANSACTION_TYPE"]/*' />
public enum D3D12_TRANSACTION_TYPE
{
    /// <include file='D3D12_TRANSACTION_TYPE.xml' path='doc/member[@name="D3D12_TRANSACTION_TYPE.D3D12_TRANSACTION_TYPE_DEFERRED"]/*' />
    D3D12_TRANSACTION_TYPE_DEFERRED = 0,

    /// <include file='D3D12_TRANSACTION_TYPE.xml' path='doc/member[@name="D3D12_TRANSACTION_TYPE.D3D12_TRANSACTION_TYPE_IMMEDIATE"]/*' />
    D3D12_TRANSACTION_TYPE_IMMEDIATE = 1,

    /// <include file='D3D12_TRANSACTION_TYPE.xml' path='doc/member[@name="D3D12_TRANSACTION_TYPE.D3D12_TRANSACTION_TYPE_EXCLUSIVE"]/*' />
    D3D12_TRANSACTION_TYPE_EXCLUSIVE = 2,

    /// <include file='D3D12_TRANSACTION_TYPE.xml' path='doc/member[@name="D3D12_TRANSACTION_TYPE.D3D12_TRANSACTION_TYPE_SAVEPOINT"]/*' />
    D3D12_TRANSACTION_TYPE_SAVEPOINT = 3,
}
