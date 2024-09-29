// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_MODULE
{
    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.BaseOfImage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseOfImage;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.SizeOfImage"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfImage;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.CheckSum"]/*' />
    [NativeTypeName("ULONG32")]
    public uint CheckSum;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.TimeDateStamp"]/*' />
    [NativeTypeName("ULONG32")]
    public uint TimeDateStamp;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.ModuleNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint ModuleNameRva;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.VersionInfo"]/*' />
    public VS_FIXEDFILEINFO VersionInfo;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.CvRecord"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR CvRecord;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.MiscRecord"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR MiscRecord;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.Reserved0"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Reserved0;

    /// <include file='MINIDUMP_MODULE.xml' path='doc/member[@name="MINIDUMP_MODULE.Reserved1"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Reserved1;
}
