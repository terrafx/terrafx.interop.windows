// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SS
{
    /// <include file='SS.xml' path='doc/member[@name="SS.SS_LEFT"]/*' />
    [NativeTypeName("#define SS_LEFT 0x00000000L")]
    public const int SS_LEFT = 0x00000000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_CENTER"]/*' />
    [NativeTypeName("#define SS_CENTER 0x00000001L")]
    public const int SS_CENTER = 0x00000001;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_RIGHT"]/*' />
    [NativeTypeName("#define SS_RIGHT 0x00000002L")]
    public const int SS_RIGHT = 0x00000002;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ICON"]/*' />
    [NativeTypeName("#define SS_ICON 0x00000003L")]
    public const int SS_ICON = 0x00000003;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_BLACKRECT"]/*' />
    [NativeTypeName("#define SS_BLACKRECT 0x00000004L")]
    public const int SS_BLACKRECT = 0x00000004;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_GRAYRECT"]/*' />
    [NativeTypeName("#define SS_GRAYRECT 0x00000005L")]
    public const int SS_GRAYRECT = 0x00000005;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_WHITERECT"]/*' />
    [NativeTypeName("#define SS_WHITERECT 0x00000006L")]
    public const int SS_WHITERECT = 0x00000006;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_BLACKFRAME"]/*' />
    [NativeTypeName("#define SS_BLACKFRAME 0x00000007L")]
    public const int SS_BLACKFRAME = 0x00000007;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_GRAYFRAME"]/*' />
    [NativeTypeName("#define SS_GRAYFRAME 0x00000008L")]
    public const int SS_GRAYFRAME = 0x00000008;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_WHITEFRAME"]/*' />
    [NativeTypeName("#define SS_WHITEFRAME 0x00000009L")]
    public const int SS_WHITEFRAME = 0x00000009;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_USERITEM"]/*' />
    [NativeTypeName("#define SS_USERITEM 0x0000000AL")]
    public const int SS_USERITEM = 0x0000000A;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_SIMPLE"]/*' />
    [NativeTypeName("#define SS_SIMPLE 0x0000000BL")]
    public const int SS_SIMPLE = 0x0000000B;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_LEFTNOWORDWRAP"]/*' />
    [NativeTypeName("#define SS_LEFTNOWORDWRAP 0x0000000CL")]
    public const int SS_LEFTNOWORDWRAP = 0x0000000C;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_OWNERDRAW"]/*' />
    [NativeTypeName("#define SS_OWNERDRAW 0x0000000DL")]
    public const int SS_OWNERDRAW = 0x0000000D;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_BITMAP"]/*' />
    [NativeTypeName("#define SS_BITMAP 0x0000000EL")]
    public const int SS_BITMAP = 0x0000000E;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ENHMETAFILE"]/*' />
    [NativeTypeName("#define SS_ENHMETAFILE 0x0000000FL")]
    public const int SS_ENHMETAFILE = 0x0000000F;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ETCHEDHORZ"]/*' />
    [NativeTypeName("#define SS_ETCHEDHORZ 0x00000010L")]
    public const int SS_ETCHEDHORZ = 0x00000010;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ETCHEDVERT"]/*' />
    [NativeTypeName("#define SS_ETCHEDVERT 0x00000011L")]
    public const int SS_ETCHEDVERT = 0x00000011;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ETCHEDFRAME"]/*' />
    [NativeTypeName("#define SS_ETCHEDFRAME 0x00000012L")]
    public const int SS_ETCHEDFRAME = 0x00000012;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_TYPEMASK"]/*' />
    [NativeTypeName("#define SS_TYPEMASK 0x0000001FL")]
    public const int SS_TYPEMASK = 0x0000001F;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_REALSIZECONTROL"]/*' />
    [NativeTypeName("#define SS_REALSIZECONTROL 0x00000040L")]
    public const int SS_REALSIZECONTROL = 0x00000040;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_NOPREFIX"]/*' />
    [NativeTypeName("#define SS_NOPREFIX 0x00000080L")]
    public const int SS_NOPREFIX = 0x00000080;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_NOTIFY"]/*' />
    [NativeTypeName("#define SS_NOTIFY 0x00000100L")]
    public const int SS_NOTIFY = 0x00000100;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_CENTERIMAGE"]/*' />
    [NativeTypeName("#define SS_CENTERIMAGE 0x00000200L")]
    public const int SS_CENTERIMAGE = 0x00000200;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_RIGHTJUST"]/*' />
    [NativeTypeName("#define SS_RIGHTJUST 0x00000400L")]
    public const int SS_RIGHTJUST = 0x00000400;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_REALSIZEIMAGE"]/*' />
    [NativeTypeName("#define SS_REALSIZEIMAGE 0x00000800L")]
    public const int SS_REALSIZEIMAGE = 0x00000800;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_SUNKEN"]/*' />
    [NativeTypeName("#define SS_SUNKEN 0x00001000L")]
    public const int SS_SUNKEN = 0x00001000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_EDITCONTROL"]/*' />
    [NativeTypeName("#define SS_EDITCONTROL 0x00002000L")]
    public const int SS_EDITCONTROL = 0x00002000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ENDELLIPSIS"]/*' />
    [NativeTypeName("#define SS_ENDELLIPSIS 0x00004000L")]
    public const int SS_ENDELLIPSIS = 0x00004000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_PATHELLIPSIS"]/*' />
    [NativeTypeName("#define SS_PATHELLIPSIS 0x00008000L")]
    public const int SS_PATHELLIPSIS = 0x00008000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_WORDELLIPSIS"]/*' />
    [NativeTypeName("#define SS_WORDELLIPSIS 0x0000C000L")]
    public const int SS_WORDELLIPSIS = 0x0000C000;

    /// <include file='SS.xml' path='doc/member[@name="SS.SS_ELLIPSISMASK"]/*' />
    [NativeTypeName("#define SS_ELLIPSISMASK 0x0000C000L")]
    public const int SS_ELLIPSISMASK = 0x0000C000;
}
