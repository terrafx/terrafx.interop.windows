// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CBN
{
    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_ERRSPACE"]/*' />
    [NativeTypeName("#define CBN_ERRSPACE (-1)")]
    public const int CBN_ERRSPACE = (-1);

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_SELCHANGE"]/*' />
    [NativeTypeName("#define CBN_SELCHANGE 1")]
    public const int CBN_SELCHANGE = 1;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_DBLCLK"]/*' />
    [NativeTypeName("#define CBN_DBLCLK 2")]
    public const int CBN_DBLCLK = 2;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_SETFOCUS"]/*' />
    [NativeTypeName("#define CBN_SETFOCUS 3")]
    public const int CBN_SETFOCUS = 3;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_KILLFOCUS"]/*' />
    [NativeTypeName("#define CBN_KILLFOCUS 4")]
    public const int CBN_KILLFOCUS = 4;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_EDITCHANGE"]/*' />
    [NativeTypeName("#define CBN_EDITCHANGE 5")]
    public const int CBN_EDITCHANGE = 5;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_EDITUPDATE"]/*' />
    [NativeTypeName("#define CBN_EDITUPDATE 6")]
    public const int CBN_EDITUPDATE = 6;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_DROPDOWN"]/*' />
    [NativeTypeName("#define CBN_DROPDOWN 7")]
    public const int CBN_DROPDOWN = 7;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_CLOSEUP"]/*' />
    [NativeTypeName("#define CBN_CLOSEUP 8")]
    public const int CBN_CLOSEUP = 8;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_SELENDOK"]/*' />
    [NativeTypeName("#define CBN_SELENDOK 9")]
    public const int CBN_SELENDOK = 9;

    /// <include file='CBN.xml' path='doc/member[@name="CBN.CBN_SELENDCANCEL"]/*' />
    [NativeTypeName("#define CBN_SELENDCANCEL 10")]
    public const int CBN_SELENDCANCEL = 10;
}
