// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CBS
{
    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_SIMPLE"]/*' />
    [NativeTypeName("#define CBS_SIMPLE 0x0001L")]
    public const int CBS_SIMPLE = 0x0001;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_DROPDOWN"]/*' />
    [NativeTypeName("#define CBS_DROPDOWN 0x0002L")]
    public const int CBS_DROPDOWN = 0x0002;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_DROPDOWNLIST"]/*' />
    [NativeTypeName("#define CBS_DROPDOWNLIST 0x0003L")]
    public const int CBS_DROPDOWNLIST = 0x0003;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_OWNERDRAWFIXED"]/*' />
    [NativeTypeName("#define CBS_OWNERDRAWFIXED 0x0010L")]
    public const int CBS_OWNERDRAWFIXED = 0x0010;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_OWNERDRAWVARIABLE"]/*' />
    [NativeTypeName("#define CBS_OWNERDRAWVARIABLE 0x0020L")]
    public const int CBS_OWNERDRAWVARIABLE = 0x0020;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_AUTOHSCROLL"]/*' />
    [NativeTypeName("#define CBS_AUTOHSCROLL 0x0040L")]
    public const int CBS_AUTOHSCROLL = 0x0040;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_OEMCONVERT"]/*' />
    [NativeTypeName("#define CBS_OEMCONVERT 0x0080L")]
    public const int CBS_OEMCONVERT = 0x0080;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_SORT"]/*' />
    [NativeTypeName("#define CBS_SORT 0x0100L")]
    public const int CBS_SORT = 0x0100;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_HASSTRINGS"]/*' />
    [NativeTypeName("#define CBS_HASSTRINGS 0x0200L")]
    public const int CBS_HASSTRINGS = 0x0200;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_NOINTEGRALHEIGHT"]/*' />
    [NativeTypeName("#define CBS_NOINTEGRALHEIGHT 0x0400L")]
    public const int CBS_NOINTEGRALHEIGHT = 0x0400;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_DISABLENOSCROLL"]/*' />
    [NativeTypeName("#define CBS_DISABLENOSCROLL 0x0800L")]
    public const int CBS_DISABLENOSCROLL = 0x0800;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_UPPERCASE"]/*' />
    [NativeTypeName("#define CBS_UPPERCASE 0x2000L")]
    public const int CBS_UPPERCASE = 0x2000;

    /// <include file='CBS.xml' path='doc/member[@name="CBS.CBS_LOWERCASE"]/*' />
    [NativeTypeName("#define CBS_LOWERCASE 0x4000L")]
    public const int CBS_LOWERCASE = 0x4000;
}
