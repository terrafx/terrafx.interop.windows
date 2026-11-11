// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SBSP
{
    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_DEFBROWSER"]/*' />
    [NativeTypeName("#define SBSP_DEFBROWSER 0x0000")]
    public const int SBSP_DEFBROWSER = 0x0000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_SAMEBROWSER"]/*' />
    [NativeTypeName("#define SBSP_SAMEBROWSER 0x0001")]
    public const int SBSP_SAMEBROWSER = 0x0001;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_NEWBROWSER"]/*' />
    [NativeTypeName("#define SBSP_NEWBROWSER 0x0002")]
    public const int SBSP_NEWBROWSER = 0x0002;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_DEFMODE"]/*' />
    [NativeTypeName("#define SBSP_DEFMODE 0x0000")]
    public const int SBSP_DEFMODE = 0x0000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_OPENMODE"]/*' />
    [NativeTypeName("#define SBSP_OPENMODE 0x0010")]
    public const int SBSP_OPENMODE = 0x0010;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_EXPLOREMODE"]/*' />
    [NativeTypeName("#define SBSP_EXPLOREMODE 0x0020")]
    public const int SBSP_EXPLOREMODE = 0x0020;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_HELPMODE"]/*' />
    [NativeTypeName("#define SBSP_HELPMODE 0x0040")]
    public const int SBSP_HELPMODE = 0x0040;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_NOTRANSFERHIST"]/*' />
    [NativeTypeName("#define SBSP_NOTRANSFERHIST 0x0080")]
    public const int SBSP_NOTRANSFERHIST = 0x0080;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_ABSOLUTE"]/*' />
    [NativeTypeName("#define SBSP_ABSOLUTE 0x0000")]
    public const int SBSP_ABSOLUTE = 0x0000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_RELATIVE"]/*' />
    [NativeTypeName("#define SBSP_RELATIVE 0x1000")]
    public const int SBSP_RELATIVE = 0x1000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_PARENT"]/*' />
    [NativeTypeName("#define SBSP_PARENT 0x2000")]
    public const int SBSP_PARENT = 0x2000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_NAVIGATEBACK"]/*' />
    [NativeTypeName("#define SBSP_NAVIGATEBACK 0x4000")]
    public const int SBSP_NAVIGATEBACK = 0x4000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_NAVIGATEFORWARD"]/*' />
    [NativeTypeName("#define SBSP_NAVIGATEFORWARD 0x8000")]
    public const int SBSP_NAVIGATEFORWARD = 0x8000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_ALLOW_AUTONAVIGATE"]/*' />
    [NativeTypeName("#define SBSP_ALLOW_AUTONAVIGATE 0x00010000")]
    public const int SBSP_ALLOW_AUTONAVIGATE = 0x00010000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_KEEPSAMETEMPLATE"]/*' />
    [NativeTypeName("#define SBSP_KEEPSAMETEMPLATE 0x00020000")]
    public const int SBSP_KEEPSAMETEMPLATE = 0x00020000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_KEEPWORDWHEELTEXT"]/*' />
    [NativeTypeName("#define SBSP_KEEPWORDWHEELTEXT 0x00040000")]
    public const int SBSP_KEEPWORDWHEELTEXT = 0x00040000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_ACTIVATE_NOFOCUS"]/*' />
    [NativeTypeName("#define SBSP_ACTIVATE_NOFOCUS 0x00080000")]
    public const int SBSP_ACTIVATE_NOFOCUS = 0x00080000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_CREATENOHISTORY"]/*' />
    [NativeTypeName("#define SBSP_CREATENOHISTORY 0x00100000")]
    public const int SBSP_CREATENOHISTORY = 0x00100000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_PLAYNOSOUND"]/*' />
    [NativeTypeName("#define SBSP_PLAYNOSOUND 0x00200000")]
    public const int SBSP_PLAYNOSOUND = 0x00200000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_CALLERUNTRUSTED"]/*' />
    [NativeTypeName("#define SBSP_CALLERUNTRUSTED 0x00800000")]
    public const int SBSP_CALLERUNTRUSTED = 0x00800000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_TRUSTFIRSTDOWNLOAD"]/*' />
    [NativeTypeName("#define SBSP_TRUSTFIRSTDOWNLOAD 0x01000000")]
    public const int SBSP_TRUSTFIRSTDOWNLOAD = 0x01000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_UNTRUSTEDFORDOWNLOAD"]/*' />
    [NativeTypeName("#define SBSP_UNTRUSTEDFORDOWNLOAD 0x02000000")]
    public const int SBSP_UNTRUSTEDFORDOWNLOAD = 0x02000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_NOAUTOSELECT"]/*' />
    [NativeTypeName("#define SBSP_NOAUTOSELECT 0x04000000")]
    public const int SBSP_NOAUTOSELECT = 0x04000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_WRITENOHISTORY"]/*' />
    [NativeTypeName("#define SBSP_WRITENOHISTORY 0x08000000")]
    public const int SBSP_WRITENOHISTORY = 0x08000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_TRUSTEDFORACTIVEX"]/*' />
    [NativeTypeName("#define SBSP_TRUSTEDFORACTIVEX 0x10000000")]
    public const int SBSP_TRUSTEDFORACTIVEX = 0x10000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_FEEDNAVIGATION"]/*' />
    [NativeTypeName("#define SBSP_FEEDNAVIGATION 0x20000000")]
    public const int SBSP_FEEDNAVIGATION = 0x20000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_REDIRECT"]/*' />
    [NativeTypeName("#define SBSP_REDIRECT 0x40000000")]
    public const int SBSP_REDIRECT = 0x40000000;

    /// <include file='SBSP.xml' path='doc/member[@name="SBSP.SBSP_INITIATEDBYHLINKFRAME"]/*' />
    [NativeTypeName("#define SBSP_INITIATEDBYHLINKFRAME 0x80000000")]
    public const uint SBSP_INITIATEDBYHLINKFRAME = 0x80000000;
}
