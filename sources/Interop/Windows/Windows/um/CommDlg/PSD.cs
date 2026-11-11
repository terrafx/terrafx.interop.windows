// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PSD
{
    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DEFAULTMINMARGINS"]/*' />
    [NativeTypeName("#define PSD_DEFAULTMINMARGINS 0x00000000")]
    public const int PSD_DEFAULTMINMARGINS = 0x00000000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_INWININIINTLMEASURE"]/*' />
    [NativeTypeName("#define PSD_INWININIINTLMEASURE 0x00000000")]
    public const int PSD_INWININIINTLMEASURE = 0x00000000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_MINMARGINS"]/*' />
    [NativeTypeName("#define PSD_MINMARGINS 0x00000001")]
    public const int PSD_MINMARGINS = 0x00000001;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_MARGINS"]/*' />
    [NativeTypeName("#define PSD_MARGINS 0x00000002")]
    public const int PSD_MARGINS = 0x00000002;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_INTHOUSANDTHSOFINCHES"]/*' />
    [NativeTypeName("#define PSD_INTHOUSANDTHSOFINCHES 0x00000004")]
    public const int PSD_INTHOUSANDTHSOFINCHES = 0x00000004;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_INHUNDREDTHSOFMILLIMETERS"]/*' />
    [NativeTypeName("#define PSD_INHUNDREDTHSOFMILLIMETERS 0x00000008")]
    public const int PSD_INHUNDREDTHSOFMILLIMETERS = 0x00000008;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DISABLEMARGINS"]/*' />
    [NativeTypeName("#define PSD_DISABLEMARGINS 0x00000010")]
    public const int PSD_DISABLEMARGINS = 0x00000010;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DISABLEPRINTER"]/*' />
    [NativeTypeName("#define PSD_DISABLEPRINTER 0x00000020")]
    public const int PSD_DISABLEPRINTER = 0x00000020;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_NOWARNING"]/*' />
    [NativeTypeName("#define PSD_NOWARNING 0x00000080")]
    public const int PSD_NOWARNING = 0x00000080;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DISABLEORIENTATION"]/*' />
    [NativeTypeName("#define PSD_DISABLEORIENTATION 0x00000100")]
    public const int PSD_DISABLEORIENTATION = 0x00000100;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_RETURNDEFAULT"]/*' />
    [NativeTypeName("#define PSD_RETURNDEFAULT 0x00000400")]
    public const int PSD_RETURNDEFAULT = 0x00000400;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DISABLEPAPER"]/*' />
    [NativeTypeName("#define PSD_DISABLEPAPER 0x00000200")]
    public const int PSD_DISABLEPAPER = 0x00000200;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_SHOWHELP"]/*' />
    [NativeTypeName("#define PSD_SHOWHELP 0x00000800")]
    public const int PSD_SHOWHELP = 0x00000800;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_ENABLEPAGESETUPHOOK"]/*' />
    [NativeTypeName("#define PSD_ENABLEPAGESETUPHOOK 0x00002000")]
    public const int PSD_ENABLEPAGESETUPHOOK = 0x00002000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_ENABLEPAGESETUPTEMPLATE"]/*' />
    [NativeTypeName("#define PSD_ENABLEPAGESETUPTEMPLATE 0x00008000")]
    public const int PSD_ENABLEPAGESETUPTEMPLATE = 0x00008000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_ENABLEPAGESETUPTEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define PSD_ENABLEPAGESETUPTEMPLATEHANDLE 0x00020000")]
    public const int PSD_ENABLEPAGESETUPTEMPLATEHANDLE = 0x00020000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_ENABLEPAGEPAINTHOOK"]/*' />
    [NativeTypeName("#define PSD_ENABLEPAGEPAINTHOOK 0x00040000")]
    public const int PSD_ENABLEPAGEPAINTHOOK = 0x00040000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_DISABLEPAGEPAINTING"]/*' />
    [NativeTypeName("#define PSD_DISABLEPAGEPAINTING 0x00080000")]
    public const int PSD_DISABLEPAGEPAINTING = 0x00080000;

    /// <include file='PSD.xml' path='doc/member[@name="PSD.PSD_NONETWORKBUTTON"]/*' />
    [NativeTypeName("#define PSD_NONETWORKBUTTON 0x00200000")]
    public const int PSD_NONETWORKBUTTON = 0x00200000;
}
