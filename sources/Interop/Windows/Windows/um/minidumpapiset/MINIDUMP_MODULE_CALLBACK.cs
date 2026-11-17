// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_MODULE_CALLBACK
{
    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.FullPath"]/*' />
    [NativeTypeName("PWCHAR")]
    public char* FullPath;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.BaseOfImage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseOfImage;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.SizeOfImage"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfImage;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.CheckSum"]/*' />
    [NativeTypeName("ULONG")]
    public uint CheckSum;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.TimeDateStamp"]/*' />
    [NativeTypeName("ULONG")]
    public uint TimeDateStamp;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.VersionInfo"]/*' />
    public VS_FIXEDFILEINFO VersionInfo;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.CvRecord"]/*' />
    [NativeTypeName("PVOID")]
    public void* CvRecord;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.SizeOfCvRecord"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfCvRecord;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.MiscRecord"]/*' />
    [NativeTypeName("PVOID")]
    public void* MiscRecord;

    /// <include file='MINIDUMP_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_MODULE_CALLBACK.SizeOfMiscRecord"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfMiscRecord;
}
