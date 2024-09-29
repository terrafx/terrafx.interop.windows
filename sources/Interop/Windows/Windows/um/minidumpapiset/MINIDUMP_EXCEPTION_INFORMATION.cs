// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_EXCEPTION_INFORMATION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_EXCEPTION_INFORMATION
{
    /// <include file='MINIDUMP_EXCEPTION_INFORMATION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION.ThreadId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThreadId;

    /// <include file='MINIDUMP_EXCEPTION_INFORMATION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION.ExceptionPointers"]/*' />
    [NativeTypeName("PEXCEPTION_POINTERS")]
    public EXCEPTION_POINTERS* ExceptionPointers;

    /// <include file='MINIDUMP_EXCEPTION_INFORMATION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION_INFORMATION.ClientPointers"]/*' />
    public BOOL ClientPointers;
}
