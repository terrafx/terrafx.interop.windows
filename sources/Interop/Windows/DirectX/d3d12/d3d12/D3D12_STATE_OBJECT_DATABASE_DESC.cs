// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_STATE_OBJECT_DATABASE_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DATABASE_DESC"]/*' />
public partial struct D3D12_STATE_OBJECT_DATABASE_DESC
{
    /// <include file='D3D12_STATE_OBJECT_DATABASE_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DATABASE_DESC.Flags"]/*' />
    public D3D12_STATE_OBJECT_DATABASE_FLAGS Flags;

    /// <include file='D3D12_STATE_OBJECT_DATABASE_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DATABASE_DESC.JournalMode"]/*' />
    public D3D12_JOURNAL_MODE JournalMode;

    /// <include file='D3D12_STATE_OBJECT_DATABASE_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DATABASE_DESC.BusyTimeoutMs"]/*' />
    public uint BusyTimeoutMs;
}
