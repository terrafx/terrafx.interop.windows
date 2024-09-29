// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_HANDLE_DESCRIPTOR
{
    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.Handle"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Handle;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.TypeNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint TypeNameRva;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.ObjectNameRva"]/*' />
    [NativeTypeName("RVA")]
    public uint ObjectNameRva;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.Attributes"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Attributes;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.GrantedAccess"]/*' />
    [NativeTypeName("ULONG32")]
    public uint GrantedAccess;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.HandleCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint HandleCount;

    /// <include file='MINIDUMP_HANDLE_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_HANDLE_DESCRIPTOR.PointerCount"]/*' />
    [NativeTypeName("ULONG32")]
    public uint PointerCount;
}
