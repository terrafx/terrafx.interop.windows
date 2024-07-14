// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA"]/*' />
public partial struct SHFILEINFOA
{
    /// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA.iIcon"]/*' />
    public int iIcon;

    /// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA.dwAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    /// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA.szDisplayName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    /// <include file='SHFILEINFOA.xml' path='doc/member[@name="SHFILEINFOA.szTypeName"]/*' />
    [NativeTypeName("CHAR[80]")]
    public _szTypeName_e__FixedBuffer szTypeName;

    /// <include file='_szDisplayName_e__FixedBuffer.xml' path='doc/member[@name="_szDisplayName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szTypeName_e__FixedBuffer.xml' path='doc/member[@name="_szTypeName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    public partial struct _szTypeName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
