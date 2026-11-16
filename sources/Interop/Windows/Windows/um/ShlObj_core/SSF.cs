// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SSF
{
    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWALLOBJECTS"]/*' />
    [NativeTypeName("#define SSF_SHOWALLOBJECTS 0x00000001")]
    public const int SSF_SHOWALLOBJECTS = 0x00000001;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWEXTENSIONS"]/*' />
    [NativeTypeName("#define SSF_SHOWEXTENSIONS 0x00000002")]
    public const int SSF_SHOWEXTENSIONS = 0x00000002;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_HIDDENFILEEXTS"]/*' />
    [NativeTypeName("#define SSF_HIDDENFILEEXTS 0x00000004")]
    public const int SSF_HIDDENFILEEXTS = 0x00000004;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SERVERADMINUI"]/*' />
    [NativeTypeName("#define SSF_SERVERADMINUI 0x00000004")]
    public const int SSF_SERVERADMINUI = 0x00000004;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWCOMPCOLOR"]/*' />
    [NativeTypeName("#define SSF_SHOWCOMPCOLOR 0x00000008")]
    public const int SSF_SHOWCOMPCOLOR = 0x00000008;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SORTCOLUMNS"]/*' />
    [NativeTypeName("#define SSF_SORTCOLUMNS 0x00000010")]
    public const int SSF_SORTCOLUMNS = 0x00000010;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWSYSFILES"]/*' />
    [NativeTypeName("#define SSF_SHOWSYSFILES 0x00000020")]
    public const int SSF_SHOWSYSFILES = 0x00000020;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_DOUBLECLICKINWEBVIEW"]/*' />
    [NativeTypeName("#define SSF_DOUBLECLICKINWEBVIEW 0x00000080")]
    public const int SSF_DOUBLECLICKINWEBVIEW = 0x00000080;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWATTRIBCOL"]/*' />
    [NativeTypeName("#define SSF_SHOWATTRIBCOL 0x00000100")]
    public const int SSF_SHOWATTRIBCOL = 0x00000100;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_DESKTOPHTML"]/*' />
    [NativeTypeName("#define SSF_DESKTOPHTML 0x00000200")]
    public const int SSF_DESKTOPHTML = 0x00000200;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_WIN95CLASSIC"]/*' />
    [NativeTypeName("#define SSF_WIN95CLASSIC 0x00000400")]
    public const int SSF_WIN95CLASSIC = 0x00000400;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_DONTPRETTYPATH"]/*' />
    [NativeTypeName("#define SSF_DONTPRETTYPATH 0x00000800")]
    public const int SSF_DONTPRETTYPATH = 0x00000800;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWINFOTIP"]/*' />
    [NativeTypeName("#define SSF_SHOWINFOTIP 0x00002000")]
    public const int SSF_SHOWINFOTIP = 0x00002000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_MAPNETDRVBUTTON"]/*' />
    [NativeTypeName("#define SSF_MAPNETDRVBUTTON 0x00001000")]
    public const int SSF_MAPNETDRVBUTTON = 0x00001000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_NOCONFIRMRECYCLE"]/*' />
    [NativeTypeName("#define SSF_NOCONFIRMRECYCLE 0x00008000")]
    public const int SSF_NOCONFIRMRECYCLE = 0x00008000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_HIDEICONS"]/*' />
    [NativeTypeName("#define SSF_HIDEICONS 0x00004000")]
    public const int SSF_HIDEICONS = 0x00004000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_FILTER"]/*' />
    [NativeTypeName("#define SSF_FILTER 0x00010000")]
    public const int SSF_FILTER = 0x00010000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_WEBVIEW"]/*' />
    [NativeTypeName("#define SSF_WEBVIEW 0x00020000")]
    public const int SSF_WEBVIEW = 0x00020000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWSUPERHIDDEN"]/*' />
    [NativeTypeName("#define SSF_SHOWSUPERHIDDEN 0x00040000")]
    public const int SSF_SHOWSUPERHIDDEN = 0x00040000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SEPPROCESS"]/*' />
    [NativeTypeName("#define SSF_SEPPROCESS 0x00080000")]
    public const int SSF_SEPPROCESS = 0x00080000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_NONETCRAWLING"]/*' />
    [NativeTypeName("#define SSF_NONETCRAWLING 0x00100000")]
    public const int SSF_NONETCRAWLING = 0x00100000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_STARTPANELON"]/*' />
    [NativeTypeName("#define SSF_STARTPANELON 0x00200000")]
    public const int SSF_STARTPANELON = 0x00200000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWSTARTPAGE"]/*' />
    [NativeTypeName("#define SSF_SHOWSTARTPAGE 0x00400000")]
    public const int SSF_SHOWSTARTPAGE = 0x00400000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_AUTOCHECKSELECT"]/*' />
    [NativeTypeName("#define SSF_AUTOCHECKSELECT 0x00800000")]
    public const int SSF_AUTOCHECKSELECT = 0x00800000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_ICONSONLY"]/*' />
    [NativeTypeName("#define SSF_ICONSONLY 0x01000000")]
    public const int SSF_ICONSONLY = 0x01000000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWTYPEOVERLAY"]/*' />
    [NativeTypeName("#define SSF_SHOWTYPEOVERLAY 0x02000000")]
    public const int SSF_SHOWTYPEOVERLAY = 0x02000000;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SHOWSTATUSBAR"]/*' />
    [NativeTypeName("#define SSF_SHOWSTATUSBAR 0x04000000")]
    public const int SSF_SHOWSTATUSBAR = 0x04000000;
}
