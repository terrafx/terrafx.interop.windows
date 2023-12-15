// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA"]/*' />
public partial struct OSVERSIONINFOEXA
{
    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwOSVersionInfoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwBuildNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwPlatformId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.szCSDVersion"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _szCSDVersion_e__FixedBuffer szCSDVersion;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wServicePackMajor"]/*' />
    [NativeTypeName("WORD")]
    public ushort wServicePackMajor;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wServicePackMinor"]/*' />
    [NativeTypeName("WORD")]
    public ushort wServicePackMinor;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wSuiteMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSuiteMask;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wProductType"]/*' />
    public byte wProductType;

    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wReserved"]/*' />
    public byte wReserved;

    /// <include file='_szCSDVersion_e__FixedBuffer.xml' path='doc/member[@name="_szCSDVersion_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szCSDVersion_e__FixedBuffer
    {
        public sbyte e0;
    }
}
