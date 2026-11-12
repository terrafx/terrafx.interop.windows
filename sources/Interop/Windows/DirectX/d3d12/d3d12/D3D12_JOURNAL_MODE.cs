// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_JOURNAL_MODE.xml' path='doc/member[@name="D3D12_JOURNAL_MODE"]/*' />
public enum D3D12_JOURNAL_MODE
{
    /// <include file='D3D12_JOURNAL_MODE.xml' path='doc/member[@name="D3D12_JOURNAL_MODE.D3D12_JOURNAL_MODE_DEFAULT"]/*' />
    D3D12_JOURNAL_MODE_DEFAULT = 0,

    /// <include file='D3D12_JOURNAL_MODE.xml' path='doc/member[@name="D3D12_JOURNAL_MODE.D3D12_JOURNAL_MODE_DELETE"]/*' />
    D3D12_JOURNAL_MODE_DELETE = 1,

    /// <include file='D3D12_JOURNAL_MODE.xml' path='doc/member[@name="D3D12_JOURNAL_MODE.D3D12_JOURNAL_MODE_WAL"]/*' />
    D3D12_JOURNAL_MODE_WAL = 2,
}
