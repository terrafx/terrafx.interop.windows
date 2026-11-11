// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WM
{
    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHOOSEFONT_GETLOGFONT"]/*' />
    [NativeTypeName("#define WM_CHOOSEFONT_GETLOGFONT (WM_USER + 1)")]
    public const int WM_CHOOSEFONT_GETLOGFONT = (0x0400 + 1);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHOOSEFONT_SETLOGFONT"]/*' />
    [NativeTypeName("#define WM_CHOOSEFONT_SETLOGFONT (WM_USER + 101)")]
    public const int WM_CHOOSEFONT_SETLOGFONT = (0x0400 + 101);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHOOSEFONT_SETFLAGS"]/*' />
    [NativeTypeName("#define WM_CHOOSEFONT_SETFLAGS (WM_USER + 102)")]
    public const int WM_CHOOSEFONT_SETFLAGS = (0x0400 + 102);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_PAGESETUPDLG"]/*' />
    [NativeTypeName("#define WM_PSD_PAGESETUPDLG (WM_USER  )")]
    public const int WM_PSD_PAGESETUPDLG = (0x0400);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_FULLPAGERECT"]/*' />
    [NativeTypeName("#define WM_PSD_FULLPAGERECT (WM_USER+1)")]
    public const int WM_PSD_FULLPAGERECT = (0x0400 + 1);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_MINMARGINRECT"]/*' />
    [NativeTypeName("#define WM_PSD_MINMARGINRECT (WM_USER+2)")]
    public const int WM_PSD_MINMARGINRECT = (0x0400 + 2);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_MARGINRECT"]/*' />
    [NativeTypeName("#define WM_PSD_MARGINRECT (WM_USER+3)")]
    public const int WM_PSD_MARGINRECT = (0x0400 + 3);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_GREEKTEXTRECT"]/*' />
    [NativeTypeName("#define WM_PSD_GREEKTEXTRECT (WM_USER+4)")]
    public const int WM_PSD_GREEKTEXTRECT = (0x0400 + 4);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_ENVSTAMPRECT"]/*' />
    [NativeTypeName("#define WM_PSD_ENVSTAMPRECT (WM_USER+5)")]
    public const int WM_PSD_ENVSTAMPRECT = (0x0400 + 5);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PSD_YAFULLPAGERECT"]/*' />
    [NativeTypeName("#define WM_PSD_YAFULLPAGERECT (WM_USER+6)")]
    public const int WM_PSD_YAFULLPAGERECT = (0x0400 + 6);
}
