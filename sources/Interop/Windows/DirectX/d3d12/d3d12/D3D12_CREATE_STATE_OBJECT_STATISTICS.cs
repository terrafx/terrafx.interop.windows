// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CREATE_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_CREATE_STATE_OBJECT_STATISTICS"]/*' />
public partial struct D3D12_CREATE_STATE_OBJECT_STATISTICS
{
    /// <include file='D3D12_CREATE_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_CREATE_STATE_OBJECT_STATISTICS.NumCreated"]/*' />
    public uint NumCreated;

    /// <include file='D3D12_CREATE_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_CREATE_STATE_OBJECT_STATISTICS.NumPSDBCacheMissed"]/*' />
    public uint NumPSDBCacheMissed;

    /// <include file='D3D12_CREATE_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_CREATE_STATE_OBJECT_STATISTICS.NumTotalCacheMissed"]/*' />
    public uint NumTotalCacheMissed;

    /// <include file='D3D12_CREATE_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_CREATE_STATE_OBJECT_STATISTICS.NumCacheUnknown"]/*' />
    public uint NumCacheUnknown;
}
