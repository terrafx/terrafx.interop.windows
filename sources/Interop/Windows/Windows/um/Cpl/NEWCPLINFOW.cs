// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NEWCPLINFOW
{
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwHelpContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHelpContext;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.lData"]/*' />
    [NativeTypeName("LONG_PTR")]
    public nint lData;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szInfo"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szInfo_e__FixedBuffer szInfo;

    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szHelpFile"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szHelpFile_e__FixedBuffer szHelpFile;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szInfo_e__FixedBuffer.xml' path='doc/member[@name="_szInfo_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szHelpFile_e__FixedBuffer.xml' path='doc/member[@name="_szHelpFile_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _szHelpFile_e__FixedBuffer
    {
        public char e0;
    }
}
