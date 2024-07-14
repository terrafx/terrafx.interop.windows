// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA"]/*' />
public partial struct IMEMENUITEMINFOA
{
    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.cbSize"]/*' />
    public uint cbSize;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.fType"]/*' />
    public uint fType;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.fState"]/*' />
    public uint fState;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.wID"]/*' />
    public uint wID;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpChecked"]/*' />
    public HBITMAP hbmpChecked;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpUnchecked"]/*' />
    public HBITMAP hbmpUnchecked;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.dwItemData"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwItemData;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.szString"]/*' />
    [NativeTypeName("CHAR[80]")]
    public _szString_e__FixedBuffer szString;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpItem"]/*' />
    public HBITMAP hbmpItem;

    /// <include file='_szString_e__FixedBuffer.xml' path='doc/member[@name="_szString_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    public partial struct _szString_e__FixedBuffer
    {
        public sbyte e0;
    }
}
