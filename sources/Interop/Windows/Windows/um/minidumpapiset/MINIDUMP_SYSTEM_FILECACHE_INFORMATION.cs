// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_SYSTEM_FILECACHE_INFORMATION
{
    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.CurrentSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CurrentSize;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.PeakSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakSize;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.PageFaultCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PageFaultCount;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.MinimumWorkingSet"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MinimumWorkingSet;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.MaximumWorkingSet"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MaximumWorkingSet;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.CurrentSizeIncludingTransitionInPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CurrentSizeIncludingTransitionInPages;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.PeakSizeIncludingTransitionInPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakSizeIncludingTransitionInPages;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.TransitionRePurposeCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint TransitionRePurposeCount;

    /// <include file='MINIDUMP_SYSTEM_FILECACHE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_FILECACHE_INFORMATION.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;
}
