// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW"]/*' />
public partial struct OSVERSIONINFOEXW
{
    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.dwOSVersionInfoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.dwMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.dwMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.dwBuildNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.dwPlatformId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.szCSDVersion"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szCSDVersion_e__FixedBuffer szCSDVersion;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.wServicePackMajor"]/*' />
    [NativeTypeName("WORD")]
    public ushort wServicePackMajor;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.wServicePackMinor"]/*' />
    [NativeTypeName("WORD")]
    public ushort wServicePackMinor;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.wSuiteMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSuiteMask;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.wProductType"]/*' />
    public byte wProductType;

    /// <include file='OSVERSIONINFOEXW.xml' path='doc/member[@name="OSVERSIONINFOEXW.wReserved"]/*' />
    public byte wReserved;

    /// <include file='_szCSDVersion_e__FixedBuffer.xml' path='doc/member[@name="_szCSDVersion_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szCSDVersion_e__FixedBuffer
    {
        public char e0;
    }
}
