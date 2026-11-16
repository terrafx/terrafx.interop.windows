// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ISFB
{
    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_STATE"]/*' />
    [NativeTypeName("#define ISFB_MASK_STATE 0x00000001")]
    public const int ISFB_MASK_STATE = 0x00000001;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_BKCOLOR"]/*' />
    [NativeTypeName("#define ISFB_MASK_BKCOLOR 0x00000002")]
    public const int ISFB_MASK_BKCOLOR = 0x00000002;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_VIEWMODE"]/*' />
    [NativeTypeName("#define ISFB_MASK_VIEWMODE 0x00000004")]
    public const int ISFB_MASK_VIEWMODE = 0x00000004;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_SHELLFOLDER"]/*' />
    [NativeTypeName("#define ISFB_MASK_SHELLFOLDER 0x00000008")]
    public const int ISFB_MASK_SHELLFOLDER = 0x00000008;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_IDLIST"]/*' />
    [NativeTypeName("#define ISFB_MASK_IDLIST 0x00000010")]
    public const int ISFB_MASK_IDLIST = 0x00000010;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_MASK_COLORS"]/*' />
    [NativeTypeName("#define ISFB_MASK_COLORS 0x00000020")]
    public const int ISFB_MASK_COLORS = 0x00000020;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_DEFAULT"]/*' />
    [NativeTypeName("#define ISFB_STATE_DEFAULT 0x00000000")]
    public const int ISFB_STATE_DEFAULT = 0x00000000;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_DEBOSSED"]/*' />
    [NativeTypeName("#define ISFB_STATE_DEBOSSED 0x00000001")]
    public const int ISFB_STATE_DEBOSSED = 0x00000001;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_ALLOWRENAME"]/*' />
    [NativeTypeName("#define ISFB_STATE_ALLOWRENAME 0x00000002")]
    public const int ISFB_STATE_ALLOWRENAME = 0x00000002;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_NOSHOWTEXT"]/*' />
    [NativeTypeName("#define ISFB_STATE_NOSHOWTEXT 0x00000004")]
    public const int ISFB_STATE_NOSHOWTEXT = 0x00000004;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_CHANNELBAR"]/*' />
    [NativeTypeName("#define ISFB_STATE_CHANNELBAR 0x00000010")]
    public const int ISFB_STATE_CHANNELBAR = 0x00000010;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_QLINKSMODE"]/*' />
    [NativeTypeName("#define ISFB_STATE_QLINKSMODE 0x00000020")]
    public const int ISFB_STATE_QLINKSMODE = 0x00000020;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_FULLOPEN"]/*' />
    [NativeTypeName("#define ISFB_STATE_FULLOPEN 0x00000040")]
    public const int ISFB_STATE_FULLOPEN = 0x00000040;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_NONAMESORT"]/*' />
    [NativeTypeName("#define ISFB_STATE_NONAMESORT 0x00000080")]
    public const int ISFB_STATE_NONAMESORT = 0x00000080;

    /// <include file='ISFB.xml' path='doc/member[@name="ISFB.ISFB_STATE_BTNMINSIZE"]/*' />
    [NativeTypeName("#define ISFB_STATE_BTNMINSIZE 0x00000100")]
    public const int ISFB_STATE_BTNMINSIZE = 0x00000100;
}
