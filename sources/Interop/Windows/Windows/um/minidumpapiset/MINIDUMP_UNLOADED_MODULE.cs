// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_UNLOADED_MODULE
{
    /// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE.BaseOfImage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseOfImage;

    /// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE.SizeOfImage"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfImage;

    /// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE.CheckSum"]/*' />
    [NativeTypeName("ULONG32")]
    public uint CheckSum;

    /// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE.TimeDateStamp"]/*' />
    [NativeTypeName("ULONG32")]
    public uint TimeDateStamp;

    /// <include file='MINIDUMP_UNLOADED_MODULE.xml' path='doc/member[@name="MINIDUMP_UNLOADED_MODULE.ModuleNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint ModuleNameRva;
}
