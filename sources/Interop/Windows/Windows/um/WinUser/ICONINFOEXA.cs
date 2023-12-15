// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA"]/*' />
public partial struct ICONINFOEXA
{
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.fIcon"]/*' />
    public BOOL fIcon;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.xHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint xHotspot;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.yHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint yHotspot;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.hbmMask"]/*' />
    public HBITMAP hbmMask;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.hbmColor"]/*' />
    public HBITMAP hbmColor;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.wResID"]/*' />
    [NativeTypeName("WORD")]
    public ushort wResID;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.szModName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szModName_e__FixedBuffer szModName;

    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.szResName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szResName_e__FixedBuffer szResName;

    /// <include file='_szModName_e__FixedBuffer.xml' path='doc/member[@name="_szModName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szModName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szResName_e__FixedBuffer.xml' path='doc/member[@name="_szResName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szResName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
