// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_HANDLE_DESCRIPTOR_2
{
    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.Handle"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Handle;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.TypeNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint TypeNameRva;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.ObjectNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint ObjectNameRva;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.Attributes"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Attributes;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.GrantedAccess"]/*' />
    [NativeTypeName("ULONG32")]
    public uint GrantedAccess;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.HandleCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint HandleCount;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.PointerCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint PointerCount;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.ObjectInfoRva"]/*' />
    [NativeTypeName("RVA")]
    public uint ObjectInfoRva;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR_2.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR_2.Reserved0"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Reserved0;
}
