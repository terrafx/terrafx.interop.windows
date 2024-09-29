// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_EXCEPTION
{
    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.ExceptionCode"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ExceptionCode;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.ExceptionFlags"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ExceptionFlags;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.ExceptionRecord"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ExceptionRecord;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.ExceptionAddress"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ExceptionAddress;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.NumberParameters"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberParameters;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.__unusedAlignment"]/*' />
    [NativeTypeName("ULONG32")]
    public uint __unusedAlignment;

    /// <include file='MINIDUMP_EXCEPTION.xml' path='doc/member[@name="MINIDUMP_EXCEPTION.ExceptionInformation"]/*' />
    [NativeTypeName("ULONG64[15]")]
    public _ExceptionInformation_e__FixedBuffer ExceptionInformation;

    /// <include file='_ExceptionInformation_e__FixedBuffer.xml' path='doc/member[@name="_ExceptionInformation_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [InlineArray(15)]
    public partial struct _ExceptionInformation_e__FixedBuffer
    {
        public ulong e0;
    }
}
