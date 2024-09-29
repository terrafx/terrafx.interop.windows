// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION
{
    /// <include file='MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.AvailablePages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong AvailablePages;

    /// <include file='MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.CommittedPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CommittedPages;

    /// <include file='MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.CommitLimit"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CommitLimit;

    /// <include file='MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION.PeakCommitment"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakCommitment;
}
