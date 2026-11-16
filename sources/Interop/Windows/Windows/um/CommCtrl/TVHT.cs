// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TVHT
{
    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_NOWHERE"]/*' />
    [NativeTypeName("#define TVHT_NOWHERE 0x0001")]
    public const int TVHT_NOWHERE = 0x0001;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMICON"]/*' />
    [NativeTypeName("#define TVHT_ONITEMICON 0x0002")]
    public const int TVHT_ONITEMICON = 0x0002;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMLABEL"]/*' />
    [NativeTypeName("#define TVHT_ONITEMLABEL 0x0004")]
    public const int TVHT_ONITEMLABEL = 0x0004;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEM"]/*' />
    [NativeTypeName("#define TVHT_ONITEM (TVHT_ONITEMICON | TVHT_ONITEMLABEL | TVHT_ONITEMSTATEICON)")]
    public const int TVHT_ONITEM = (0x0002 | 0x0004 | 0x0040);

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMINDENT"]/*' />
    [NativeTypeName("#define TVHT_ONITEMINDENT 0x0008")]
    public const int TVHT_ONITEMINDENT = 0x0008;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMBUTTON"]/*' />
    [NativeTypeName("#define TVHT_ONITEMBUTTON 0x0010")]
    public const int TVHT_ONITEMBUTTON = 0x0010;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMRIGHT"]/*' />
    [NativeTypeName("#define TVHT_ONITEMRIGHT 0x0020")]
    public const int TVHT_ONITEMRIGHT = 0x0020;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ONITEMSTATEICON"]/*' />
    [NativeTypeName("#define TVHT_ONITEMSTATEICON 0x0040")]
    public const int TVHT_ONITEMSTATEICON = 0x0040;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_ABOVE"]/*' />
    [NativeTypeName("#define TVHT_ABOVE 0x0100")]
    public const int TVHT_ABOVE = 0x0100;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_BELOW"]/*' />
    [NativeTypeName("#define TVHT_BELOW 0x0200")]
    public const int TVHT_BELOW = 0x0200;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_TORIGHT"]/*' />
    [NativeTypeName("#define TVHT_TORIGHT 0x0400")]
    public const int TVHT_TORIGHT = 0x0400;

    /// <include file='TVHT.xml' path='doc/member[@name="TVHT.TVHT_TOLEFT"]/*' />
    [NativeTypeName("#define TVHT_TOLEFT 0x0800")]
    public const int TVHT_TOLEFT = 0x0800;
}
