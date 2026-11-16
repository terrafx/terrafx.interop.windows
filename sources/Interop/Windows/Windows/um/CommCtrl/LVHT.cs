// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVHT
{
    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_NOWHERE"]/*' />
    [NativeTypeName("#define LVHT_NOWHERE 0x00000001")]
    public const int LVHT_NOWHERE = 0x00000001;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_ONITEMICON"]/*' />
    [NativeTypeName("#define LVHT_ONITEMICON 0x00000002")]
    public const int LVHT_ONITEMICON = 0x00000002;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_ONITEMLABEL"]/*' />
    [NativeTypeName("#define LVHT_ONITEMLABEL 0x00000004")]
    public const int LVHT_ONITEMLABEL = 0x00000004;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_ONITEMSTATEICON"]/*' />
    [NativeTypeName("#define LVHT_ONITEMSTATEICON 0x00000008")]
    public const int LVHT_ONITEMSTATEICON = 0x00000008;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_ONITEM"]/*' />
    [NativeTypeName("#define LVHT_ONITEM (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON)")]
    public const int LVHT_ONITEM = (0x00000002 | 0x00000004 | 0x00000008);

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_ABOVE"]/*' />
    [NativeTypeName("#define LVHT_ABOVE 0x00000008")]
    public const int LVHT_ABOVE = 0x00000008;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_BELOW"]/*' />
    [NativeTypeName("#define LVHT_BELOW 0x00000010")]
    public const int LVHT_BELOW = 0x00000010;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_TORIGHT"]/*' />
    [NativeTypeName("#define LVHT_TORIGHT 0x00000020")]
    public const int LVHT_TORIGHT = 0x00000020;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_TOLEFT"]/*' />
    [NativeTypeName("#define LVHT_TOLEFT 0x00000040")]
    public const int LVHT_TOLEFT = 0x00000040;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_HEADER"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_HEADER 0x10000000")]
    public const int LVHT_EX_GROUP_HEADER = 0x10000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_FOOTER"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_FOOTER 0x20000000")]
    public const int LVHT_EX_GROUP_FOOTER = 0x20000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_COLLAPSE"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_COLLAPSE 0x40000000")]
    public const int LVHT_EX_GROUP_COLLAPSE = 0x40000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_BACKGROUND"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_BACKGROUND 0x80000000")]
    public const uint LVHT_EX_GROUP_BACKGROUND = 0x80000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_STATEICON"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_STATEICON 0x01000000")]
    public const int LVHT_EX_GROUP_STATEICON = 0x01000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP_SUBSETLINK"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP_SUBSETLINK 0x02000000")]
    public const int LVHT_EX_GROUP_SUBSETLINK = 0x02000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_GROUP"]/*' />
    [NativeTypeName("#define LVHT_EX_GROUP (LVHT_EX_GROUP_BACKGROUND | LVHT_EX_GROUP_COLLAPSE | LVHT_EX_GROUP_FOOTER | LVHT_EX_GROUP_HEADER | LVHT_EX_GROUP_STATEICON | LVHT_EX_GROUP_SUBSETLINK)")]
    public const uint LVHT_EX_GROUP = (0x80000000 | 0x40000000 | 0x20000000 | 0x10000000 | 0x01000000 | 0x02000000);

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_ONCONTENTS"]/*' />
    [NativeTypeName("#define LVHT_EX_ONCONTENTS 0x04000000")]
    public const int LVHT_EX_ONCONTENTS = 0x04000000;

    /// <include file='LVHT.xml' path='doc/member[@name="LVHT.LVHT_EX_FOOTER"]/*' />
    [NativeTypeName("#define LVHT_EX_FOOTER 0x08000000")]
    public const int LVHT_EX_FOOTER = 0x08000000;
}
