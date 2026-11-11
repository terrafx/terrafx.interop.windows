// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct COLOR
{
    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_SCROLLBAR"]/*' />
    [NativeTypeName("#define COLOR_SCROLLBAR 0")]
    public const int COLOR_SCROLLBAR = 0;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BACKGROUND"]/*' />
    [NativeTypeName("#define COLOR_BACKGROUND 1")]
    public const int COLOR_BACKGROUND = 1;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_ACTIVECAPTION"]/*' />
    [NativeTypeName("#define COLOR_ACTIVECAPTION 2")]
    public const int COLOR_ACTIVECAPTION = 2;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_INACTIVECAPTION"]/*' />
    [NativeTypeName("#define COLOR_INACTIVECAPTION 3")]
    public const int COLOR_INACTIVECAPTION = 3;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_MENU"]/*' />
    [NativeTypeName("#define COLOR_MENU 4")]
    public const int COLOR_MENU = 4;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_WINDOW"]/*' />
    [NativeTypeName("#define COLOR_WINDOW 5")]
    public const int COLOR_WINDOW = 5;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_WINDOWFRAME"]/*' />
    [NativeTypeName("#define COLOR_WINDOWFRAME 6")]
    public const int COLOR_WINDOWFRAME = 6;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_MENUTEXT"]/*' />
    [NativeTypeName("#define COLOR_MENUTEXT 7")]
    public const int COLOR_MENUTEXT = 7;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_WINDOWTEXT"]/*' />
    [NativeTypeName("#define COLOR_WINDOWTEXT 8")]
    public const int COLOR_WINDOWTEXT = 8;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_CAPTIONTEXT"]/*' />
    [NativeTypeName("#define COLOR_CAPTIONTEXT 9")]
    public const int COLOR_CAPTIONTEXT = 9;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_ACTIVEBORDER"]/*' />
    [NativeTypeName("#define COLOR_ACTIVEBORDER 10")]
    public const int COLOR_ACTIVEBORDER = 10;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_INACTIVEBORDER"]/*' />
    [NativeTypeName("#define COLOR_INACTIVEBORDER 11")]
    public const int COLOR_INACTIVEBORDER = 11;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_APPWORKSPACE"]/*' />
    [NativeTypeName("#define COLOR_APPWORKSPACE 12")]
    public const int COLOR_APPWORKSPACE = 12;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_HIGHLIGHT"]/*' />
    [NativeTypeName("#define COLOR_HIGHLIGHT 13")]
    public const int COLOR_HIGHLIGHT = 13;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_HIGHLIGHTTEXT"]/*' />
    [NativeTypeName("#define COLOR_HIGHLIGHTTEXT 14")]
    public const int COLOR_HIGHLIGHTTEXT = 14;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BTNFACE"]/*' />
    [NativeTypeName("#define COLOR_BTNFACE 15")]
    public const int COLOR_BTNFACE = 15;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BTNSHADOW"]/*' />
    [NativeTypeName("#define COLOR_BTNSHADOW 16")]
    public const int COLOR_BTNSHADOW = 16;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_GRAYTEXT"]/*' />
    [NativeTypeName("#define COLOR_GRAYTEXT 17")]
    public const int COLOR_GRAYTEXT = 17;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BTNTEXT"]/*' />
    [NativeTypeName("#define COLOR_BTNTEXT 18")]
    public const int COLOR_BTNTEXT = 18;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_INACTIVECAPTIONTEXT"]/*' />
    [NativeTypeName("#define COLOR_INACTIVECAPTIONTEXT 19")]
    public const int COLOR_INACTIVECAPTIONTEXT = 19;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BTNHIGHLIGHT"]/*' />
    [NativeTypeName("#define COLOR_BTNHIGHLIGHT 20")]
    public const int COLOR_BTNHIGHLIGHT = 20;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DDKSHADOW"]/*' />
    [NativeTypeName("#define COLOR_3DDKSHADOW 21")]
    public const int COLOR_3DDKSHADOW = 21;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DLIGHT"]/*' />
    [NativeTypeName("#define COLOR_3DLIGHT 22")]
    public const int COLOR_3DLIGHT = 22;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_INFOTEXT"]/*' />
    [NativeTypeName("#define COLOR_INFOTEXT 23")]
    public const int COLOR_INFOTEXT = 23;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_INFOBK"]/*' />
    [NativeTypeName("#define COLOR_INFOBK 24")]
    public const int COLOR_INFOBK = 24;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_HOTLIGHT"]/*' />
    [NativeTypeName("#define COLOR_HOTLIGHT 26")]
    public const int COLOR_HOTLIGHT = 26;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_GRADIENTACTIVECAPTION"]/*' />
    [NativeTypeName("#define COLOR_GRADIENTACTIVECAPTION 27")]
    public const int COLOR_GRADIENTACTIVECAPTION = 27;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_GRADIENTINACTIVECAPTION"]/*' />
    [NativeTypeName("#define COLOR_GRADIENTINACTIVECAPTION 28")]
    public const int COLOR_GRADIENTINACTIVECAPTION = 28;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_MENUHILIGHT"]/*' />
    [NativeTypeName("#define COLOR_MENUHILIGHT 29")]
    public const int COLOR_MENUHILIGHT = 29;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_MENUBAR"]/*' />
    [NativeTypeName("#define COLOR_MENUBAR 30")]
    public const int COLOR_MENUBAR = 30;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_DESKTOP"]/*' />
    [NativeTypeName("#define COLOR_DESKTOP COLOR_BACKGROUND")]
    public const int COLOR_DESKTOP = 1;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DFACE"]/*' />
    [NativeTypeName("#define COLOR_3DFACE COLOR_BTNFACE")]
    public const int COLOR_3DFACE = 15;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DSHADOW"]/*' />
    [NativeTypeName("#define COLOR_3DSHADOW COLOR_BTNSHADOW")]
    public const int COLOR_3DSHADOW = 16;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DHIGHLIGHT"]/*' />
    [NativeTypeName("#define COLOR_3DHIGHLIGHT COLOR_BTNHIGHLIGHT")]
    public const int COLOR_3DHIGHLIGHT = 20;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_3DHILIGHT"]/*' />
    [NativeTypeName("#define COLOR_3DHILIGHT COLOR_BTNHIGHLIGHT")]
    public const int COLOR_3DHILIGHT = 20;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.COLOR_BTNHILIGHT"]/*' />
    [NativeTypeName("#define COLOR_BTNHILIGHT COLOR_BTNHIGHLIGHT")]
    public const int COLOR_BTNHILIGHT = 20;
}
