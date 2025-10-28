// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_EXCEPTION_INFORMATION64.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION64"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_EXCEPTION_INFORMATION64
{
    /// <include file='MINIDUMP_EXCEPTION_INFORMATION64.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION64.ThreadId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThreadId;

    /// <include file='MINIDUMP_EXCEPTION_INFORMATION64.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION64.ExceptionRecord"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ExceptionRecord;

    /// <include file='MINIDUMP_EXCEPTION_INFORMATION64.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION64.ContextRecord"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ContextRecord;

    /// <include file='MINIDUMP_EXCEPTION_INFORMATION64.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION64.ClientPointers"]/*' />
    public BOOL ClientPointers;
}
