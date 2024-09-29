// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2"]/*' />
public partial struct _MINIDUMP_SYSTEM_MEMORY_INFO_2
{
    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.Revision"]/*' />
    public ushort Revision;

    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.Flags"]/*' />
    public ushort Flags;

    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.BasicInfo"]/*' />
    public MINIDUMP_SYSTEM_BASIC_INFORMATION BasicInfo;

    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.FileCacheInfo"]/*' />
    public MINIDUMP_SYSTEM_FILECACHE_INFORMATION FileCacheInfo;

    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.BasicPerfInfo"]/*' />
    public MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION BasicPerfInfo;

    /// <include file='_MINIDUMP_SYSTEM_MEMORY_INFO_2.xml' path='doc/member[@name="_MINIDUMP_SYSTEM_MEMORY_INFO_2.PerfInfo"]/*' />
    [NativeTypeName("MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2")]
    public _MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION_2 PerfInfo;
}
