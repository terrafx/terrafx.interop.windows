// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW"]/*' />
public partial struct ICONINFOEXW
{
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.fIcon"]/*' />
    public BOOL fIcon;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.xHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint xHotspot;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.yHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint yHotspot;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmMask"]/*' />
    public HBITMAP hbmMask;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmColor"]/*' />
    public HBITMAP hbmColor;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.wResID"]/*' />
    [NativeTypeName("WORD")]
    public ushort wResID;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szModName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szModName_e__FixedBuffer szModName;

    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szResName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szResName_e__FixedBuffer szResName;

    /// <include file='_szModName_e__FixedBuffer.xml' path='doc/member[@name="_szModName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szModName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szResName_e__FixedBuffer.xml' path='doc/member[@name="_szResName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szResName_e__FixedBuffer
    {
        public char e0;
    }
}
