// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS"]/*' />
public partial struct D3DRESOURCESTATS
{
    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.bThrashing"]/*' />
    public BOOL bThrashing;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.ApproxBytesDownloaded"]/*' />
    [NativeTypeName("DWORD")]
    public uint ApproxBytesDownloaded;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.NumEvicts"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumEvicts;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.NumVidCreates"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumVidCreates;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.LastPri"]/*' />
    [NativeTypeName("DWORD")]
    public uint LastPri;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.NumUsed"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumUsed;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.NumUsedInVidMem"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumUsedInVidMem;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.WorkingSet"]/*' />
    [NativeTypeName("DWORD")]
    public uint WorkingSet;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.WorkingSetBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint WorkingSetBytes;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.TotalManaged"]/*' />
    [NativeTypeName("DWORD")]
    public uint TotalManaged;

    /// <include file='D3DRESOURCESTATS.xml' path='doc/member[@name="D3DRESOURCESTATS.TotalBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint TotalBytes;
}
