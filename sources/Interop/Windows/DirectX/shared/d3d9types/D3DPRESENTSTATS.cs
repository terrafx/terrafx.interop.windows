// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS"]/*' />
public partial struct D3DPRESENTSTATS
{
    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.PresentCount"]/*' />
    public uint PresentCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.PresentRefreshCount"]/*' />
    public uint PresentRefreshCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncRefreshCount"]/*' />
    public uint SyncRefreshCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncQPCTime"]/*' />
    public LARGE_INTEGER SyncQPCTime;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncGPUTime"]/*' />
    public LARGE_INTEGER SyncGPUTime;
}
