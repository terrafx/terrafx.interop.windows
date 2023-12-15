// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW"]/*' />
public partial struct IMEMENUITEMINFOW
{
    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.fType"]/*' />
    public uint fType;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.fState"]/*' />
    public uint fState;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.wID"]/*' />
    public uint wID;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.hbmpChecked"]/*' />
    public HBITMAP hbmpChecked;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.hbmpUnchecked"]/*' />
    public HBITMAP hbmpUnchecked;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.dwItemData"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwItemData;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.szString"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _szString_e__FixedBuffer szString;

    /// <include file='IMEMENUITEMINFOW.xml' path='doc/member[@name="IMEMENUITEMINFOW.hbmpItem"]/*' />
    public HBITMAP hbmpItem;

    /// <include file='_szString_e__FixedBuffer.xml' path='doc/member[@name="_szString_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    public partial struct _szString_e__FixedBuffer
    {
        public char e0;
    }
}
