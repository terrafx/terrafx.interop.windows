// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1"]/*' />
public partial struct MINIDUMP_SYSTEM_MEMORY_INFO_1
{
    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.Revision"]/*' />
    public ushort Revision;

    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.Flags"]/*' />
    public ushort Flags;

    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.BasicInfo"]/*' />
    public MINIDUMP_SYSTEM_BASIC_INFORMATION BasicInfo;

    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.FileCacheInfo"]/*' />
    public MINIDUMP_SYSTEM_FILECACHE_INFORMATION FileCacheInfo;

    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.BasicPerfInfo"]/*' />
    public MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION BasicPerfInfo;

    /// <include file='MINIDUMP_SYSTEM_MEMORY_INFO_1.xml' path='doc/member[@name="MINIDUMP_SYSTEM_MEMORY_INFO_1.PerfInfo"]/*' />
    public MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION PerfInfo;
}
