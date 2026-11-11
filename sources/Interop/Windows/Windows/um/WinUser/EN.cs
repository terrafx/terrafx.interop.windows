// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EN
{
    /// <include file='EN.xml' path='doc/member[@name="EN.EN_SETFOCUS"]/*' />
    [NativeTypeName("#define EN_SETFOCUS 0x0100")]
    public const int EN_SETFOCUS = 0x0100;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_KILLFOCUS"]/*' />
    [NativeTypeName("#define EN_KILLFOCUS 0x0200")]
    public const int EN_KILLFOCUS = 0x0200;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_CHANGE"]/*' />
    [NativeTypeName("#define EN_CHANGE 0x0300")]
    public const int EN_CHANGE = 0x0300;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_UPDATE"]/*' />
    [NativeTypeName("#define EN_UPDATE 0x0400")]
    public const int EN_UPDATE = 0x0400;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_ERRSPACE"]/*' />
    [NativeTypeName("#define EN_ERRSPACE 0x0500")]
    public const int EN_ERRSPACE = 0x0500;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_MAXTEXT"]/*' />
    [NativeTypeName("#define EN_MAXTEXT 0x0501")]
    public const int EN_MAXTEXT = 0x0501;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_HSCROLL"]/*' />
    [NativeTypeName("#define EN_HSCROLL 0x0601")]
    public const int EN_HSCROLL = 0x0601;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_VSCROLL"]/*' />
    [NativeTypeName("#define EN_VSCROLL 0x0602")]
    public const int EN_VSCROLL = 0x0602;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_ALIGN_LTR_EC"]/*' />
    [NativeTypeName("#define EN_ALIGN_LTR_EC 0x0700")]
    public const int EN_ALIGN_LTR_EC = 0x0700;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_ALIGN_RTL_EC"]/*' />
    [NativeTypeName("#define EN_ALIGN_RTL_EC 0x0701")]
    public const int EN_ALIGN_RTL_EC = 0x0701;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_BEFORE_PASTE"]/*' />
    [NativeTypeName("#define EN_BEFORE_PASTE 0x0800")]
    public const int EN_BEFORE_PASTE = 0x0800;

    /// <include file='EN.xml' path='doc/member[@name="EN.EN_AFTER_PASTE"]/*' />
    [NativeTypeName("#define EN_AFTER_PASTE 0x0801")]
    public const int EN_AFTER_PASTE = 0x0801;
}
