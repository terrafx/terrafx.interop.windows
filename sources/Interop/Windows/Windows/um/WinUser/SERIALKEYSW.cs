// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW"]/*' />
public unsafe partial struct SERIALKEYSW
{
    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.lpszActivePort"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpszActivePort;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.lpszPort"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpszPort;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.iBaudRate"]/*' />
    public uint iBaudRate;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.iPortState"]/*' />
    public uint iPortState;

    /// <include file='SERIALKEYSW.xml' path='doc/member[@name="SERIALKEYSW.iActive"]/*' />
    public uint iActive;
}
