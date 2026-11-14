// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BN
{
    /// <include file='BN.xml' path='doc/member[@name="BN.BN_CLICKED"]/*' />
    [NativeTypeName("#define BN_CLICKED 0")]
    public const int BN_CLICKED = 0;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_PAINT"]/*' />
    [NativeTypeName("#define BN_PAINT 1")]
    public const int BN_PAINT = 1;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_HILITE"]/*' />
    [NativeTypeName("#define BN_HILITE 2")]
    public const int BN_HILITE = 2;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_UNHILITE"]/*' />
    [NativeTypeName("#define BN_UNHILITE 3")]
    public const int BN_UNHILITE = 3;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_DISABLE"]/*' />
    [NativeTypeName("#define BN_DISABLE 4")]
    public const int BN_DISABLE = 4;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_DOUBLECLICKED"]/*' />
    [NativeTypeName("#define BN_DOUBLECLICKED 5")]
    public const int BN_DOUBLECLICKED = 5;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_PUSHED"]/*' />
    [NativeTypeName("#define BN_PUSHED BN_HILITE")]
    public const int BN_PUSHED = 2;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_UNPUSHED"]/*' />
    [NativeTypeName("#define BN_UNPUSHED BN_UNHILITE")]
    public const int BN_UNPUSHED = 3;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_DBLCLK"]/*' />
    [NativeTypeName("#define BN_DBLCLK BN_DOUBLECLICKED")]
    public const int BN_DBLCLK = 5;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_SETFOCUS"]/*' />
    [NativeTypeName("#define BN_SETFOCUS 6")]
    public const int BN_SETFOCUS = 6;

    /// <include file='BN.xml' path='doc/member[@name="BN.BN_KILLFOCUS"]/*' />
    [NativeTypeName("#define BN_KILLFOCUS 7")]
    public const int BN_KILLFOCUS = 7;
}
