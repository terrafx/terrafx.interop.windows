// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct RESTOREPOINTINFOW
{
    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.dwEventType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEventType;

    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.dwRestorePtType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;

    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.llSequenceNumber"]/*' />
    [NativeTypeName("INT64")]
    public long llSequenceNumber;

    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.szDescription"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(256)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }
}
