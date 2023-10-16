// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD"]/*' />
public unsafe partial struct EXCEPTION_RECORD
{
    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;

    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExceptionFlags;

    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionRecord"]/*' />
    [NativeTypeName("struct _EXCEPTION_RECORD *")]
    public EXCEPTION_RECORD* ExceptionRecord;

    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionAddress"]/*' />
    [NativeTypeName("PVOID")]
    public void* ExceptionAddress;

    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.NumberParameters"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberParameters;

    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionInformation"]/*' />
    [NativeTypeName("ULONG_PTR[15]")]
    public _ExceptionInformation_e__FixedBuffer ExceptionInformation;

    /// <include file='_ExceptionInformation_e__FixedBuffer.xml' path='doc/member[@name="_ExceptionInformation_e__FixedBuffer"]/*' />
    [InlineArray(15)]
    public partial struct _ExceptionInformation_e__FixedBuffer
    {
        public nuint e0;
    }
}
