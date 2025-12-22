// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_MEMORY_INFO
{
    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.BaseAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseAddress;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.AllocationBase"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong AllocationBase;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.AllocationProtect"]/*' />
    [NativeTypeName("ULONG32")]
    public uint AllocationProtect;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.__alignment1"]/*' />
    [NativeTypeName("ULONG32")]
    public uint __alignment1;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.RegionSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong RegionSize;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.State"]/*' />
    [NativeTypeName("ULONG32")]
    public uint State;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.Protect"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Protect;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.Type"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Type;

    /// <include file='MINIDUMP_MEMORY_INFO.xml' path='doc/member[@name="MINIDUMP_MEMORY_INFO.__alignment2"]/*' />
    [NativeTypeName("ULONG32")]
    public uint __alignment2;
}
