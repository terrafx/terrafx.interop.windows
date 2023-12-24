// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW"]/*' />
public partial struct SHFILEINFOW
{
    /// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW.iIcon"]/*' />
    public int iIcon;

    /// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW.dwAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    /// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW.szDisplayName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    /// <include file='SHFILEINFOW.xml' path='doc/member[@name="SHFILEINFOW.szTypeName"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _szTypeName_e__FixedBuffer szTypeName;

    /// <include file='_szDisplayName_e__FixedBuffer.xml' path='doc/member[@name="_szDisplayName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szTypeName_e__FixedBuffer.xml' path='doc/member[@name="_szTypeName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    public partial struct _szTypeName_e__FixedBuffer
    {
        public char e0;
    }
}
