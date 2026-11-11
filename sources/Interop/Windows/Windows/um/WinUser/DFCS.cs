// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DFCS
{
    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CAPTIONCLOSE"]/*' />
    [NativeTypeName("#define DFCS_CAPTIONCLOSE 0x0000")]
    public const int DFCS_CAPTIONCLOSE = 0x0000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CAPTIONMIN"]/*' />
    [NativeTypeName("#define DFCS_CAPTIONMIN 0x0001")]
    public const int DFCS_CAPTIONMIN = 0x0001;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CAPTIONMAX"]/*' />
    [NativeTypeName("#define DFCS_CAPTIONMAX 0x0002")]
    public const int DFCS_CAPTIONMAX = 0x0002;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CAPTIONRESTORE"]/*' />
    [NativeTypeName("#define DFCS_CAPTIONRESTORE 0x0003")]
    public const int DFCS_CAPTIONRESTORE = 0x0003;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CAPTIONHELP"]/*' />
    [NativeTypeName("#define DFCS_CAPTIONHELP 0x0004")]
    public const int DFCS_CAPTIONHELP = 0x0004;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_MENUARROW"]/*' />
    [NativeTypeName("#define DFCS_MENUARROW 0x0000")]
    public const int DFCS_MENUARROW = 0x0000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_MENUCHECK"]/*' />
    [NativeTypeName("#define DFCS_MENUCHECK 0x0001")]
    public const int DFCS_MENUCHECK = 0x0001;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_MENUBULLET"]/*' />
    [NativeTypeName("#define DFCS_MENUBULLET 0x0002")]
    public const int DFCS_MENUBULLET = 0x0002;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_MENUARROWRIGHT"]/*' />
    [NativeTypeName("#define DFCS_MENUARROWRIGHT 0x0004")]
    public const int DFCS_MENUARROWRIGHT = 0x0004;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLUP"]/*' />
    [NativeTypeName("#define DFCS_SCROLLUP 0x0000")]
    public const int DFCS_SCROLLUP = 0x0000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLDOWN"]/*' />
    [NativeTypeName("#define DFCS_SCROLLDOWN 0x0001")]
    public const int DFCS_SCROLLDOWN = 0x0001;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLLEFT"]/*' />
    [NativeTypeName("#define DFCS_SCROLLLEFT 0x0002")]
    public const int DFCS_SCROLLLEFT = 0x0002;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLRIGHT"]/*' />
    [NativeTypeName("#define DFCS_SCROLLRIGHT 0x0003")]
    public const int DFCS_SCROLLRIGHT = 0x0003;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLCOMBOBOX"]/*' />
    [NativeTypeName("#define DFCS_SCROLLCOMBOBOX 0x0005")]
    public const int DFCS_SCROLLCOMBOBOX = 0x0005;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLSIZEGRIP"]/*' />
    [NativeTypeName("#define DFCS_SCROLLSIZEGRIP 0x0008")]
    public const int DFCS_SCROLLSIZEGRIP = 0x0008;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_SCROLLSIZEGRIPRIGHT"]/*' />
    [NativeTypeName("#define DFCS_SCROLLSIZEGRIPRIGHT 0x0010")]
    public const int DFCS_SCROLLSIZEGRIPRIGHT = 0x0010;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTONCHECK"]/*' />
    [NativeTypeName("#define DFCS_BUTTONCHECK 0x0000")]
    public const int DFCS_BUTTONCHECK = 0x0000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTONRADIOIMAGE"]/*' />
    [NativeTypeName("#define DFCS_BUTTONRADIOIMAGE 0x0001")]
    public const int DFCS_BUTTONRADIOIMAGE = 0x0001;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTONRADIOMASK"]/*' />
    [NativeTypeName("#define DFCS_BUTTONRADIOMASK 0x0002")]
    public const int DFCS_BUTTONRADIOMASK = 0x0002;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTONRADIO"]/*' />
    [NativeTypeName("#define DFCS_BUTTONRADIO 0x0004")]
    public const int DFCS_BUTTONRADIO = 0x0004;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTON3STATE"]/*' />
    [NativeTypeName("#define DFCS_BUTTON3STATE 0x0008")]
    public const int DFCS_BUTTON3STATE = 0x0008;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_BUTTONPUSH"]/*' />
    [NativeTypeName("#define DFCS_BUTTONPUSH 0x0010")]
    public const int DFCS_BUTTONPUSH = 0x0010;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_INACTIVE"]/*' />
    [NativeTypeName("#define DFCS_INACTIVE 0x0100")]
    public const int DFCS_INACTIVE = 0x0100;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_PUSHED"]/*' />
    [NativeTypeName("#define DFCS_PUSHED 0x0200")]
    public const int DFCS_PUSHED = 0x0200;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_CHECKED"]/*' />
    [NativeTypeName("#define DFCS_CHECKED 0x0400")]
    public const int DFCS_CHECKED = 0x0400;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_TRANSPARENT"]/*' />
    [NativeTypeName("#define DFCS_TRANSPARENT 0x0800")]
    public const int DFCS_TRANSPARENT = 0x0800;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_HOT"]/*' />
    [NativeTypeName("#define DFCS_HOT 0x1000")]
    public const int DFCS_HOT = 0x1000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_ADJUSTRECT"]/*' />
    [NativeTypeName("#define DFCS_ADJUSTRECT 0x2000")]
    public const int DFCS_ADJUSTRECT = 0x2000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_FLAT"]/*' />
    [NativeTypeName("#define DFCS_FLAT 0x4000")]
    public const int DFCS_FLAT = 0x4000;

    /// <include file='DFCS.xml' path='doc/member[@name="DFCS.DFCS_MONO"]/*' />
    [NativeTypeName("#define DFCS_MONO 0x8000")]
    public const int DFCS_MONO = 0x8000;
}
