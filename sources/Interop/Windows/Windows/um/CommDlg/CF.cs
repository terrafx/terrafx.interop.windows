// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CF
{
    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SCREENFONTS"]/*' />
    [NativeTypeName("#define CF_SCREENFONTS 0x00000001")]
    public const int CF_SCREENFONTS = 0x00000001;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_PRINTERFONTS"]/*' />
    [NativeTypeName("#define CF_PRINTERFONTS 0x00000002")]
    public const int CF_PRINTERFONTS = 0x00000002;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_BOTH"]/*' />
    [NativeTypeName("#define CF_BOTH (CF_SCREENFONTS | CF_PRINTERFONTS)")]
    public const int CF_BOTH = (0x00000001 | 0x00000002);

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SHOWHELP"]/*' />
    [NativeTypeName("#define CF_SHOWHELP 0x00000004L")]
    public const int CF_SHOWHELP = 0x00000004;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_ENABLEHOOK"]/*' />
    [NativeTypeName("#define CF_ENABLEHOOK 0x00000008L")]
    public const int CF_ENABLEHOOK = 0x00000008;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_ENABLETEMPLATE"]/*' />
    [NativeTypeName("#define CF_ENABLETEMPLATE 0x00000010L")]
    public const int CF_ENABLETEMPLATE = 0x00000010;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_ENABLETEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define CF_ENABLETEMPLATEHANDLE 0x00000020L")]
    public const int CF_ENABLETEMPLATEHANDLE = 0x00000020;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_INITTOLOGFONTSTRUCT"]/*' />
    [NativeTypeName("#define CF_INITTOLOGFONTSTRUCT 0x00000040L")]
    public const int CF_INITTOLOGFONTSTRUCT = 0x00000040;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_USESTYLE"]/*' />
    [NativeTypeName("#define CF_USESTYLE 0x00000080L")]
    public const int CF_USESTYLE = 0x00000080;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_EFFECTS"]/*' />
    [NativeTypeName("#define CF_EFFECTS 0x00000100L")]
    public const int CF_EFFECTS = 0x00000100;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_APPLY"]/*' />
    [NativeTypeName("#define CF_APPLY 0x00000200L")]
    public const int CF_APPLY = 0x00000200;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_ANSIONLY"]/*' />
    [NativeTypeName("#define CF_ANSIONLY 0x00000400L")]
    public const int CF_ANSIONLY = 0x00000400;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SCRIPTSONLY"]/*' />
    [NativeTypeName("#define CF_SCRIPTSONLY CF_ANSIONLY")]
    public const int CF_SCRIPTSONLY = 0x00000400;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOVECTORFONTS"]/*' />
    [NativeTypeName("#define CF_NOVECTORFONTS 0x00000800L")]
    public const int CF_NOVECTORFONTS = 0x00000800;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOOEMFONTS"]/*' />
    [NativeTypeName("#define CF_NOOEMFONTS CF_NOVECTORFONTS")]
    public const int CF_NOOEMFONTS = 0x00000800;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOSIMULATIONS"]/*' />
    [NativeTypeName("#define CF_NOSIMULATIONS 0x00001000L")]
    public const int CF_NOSIMULATIONS = 0x00001000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_LIMITSIZE"]/*' />
    [NativeTypeName("#define CF_LIMITSIZE 0x00002000L")]
    public const int CF_LIMITSIZE = 0x00002000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_FIXEDPITCHONLY"]/*' />
    [NativeTypeName("#define CF_FIXEDPITCHONLY 0x00004000L")]
    public const int CF_FIXEDPITCHONLY = 0x00004000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_WYSIWYG"]/*' />
    [NativeTypeName("#define CF_WYSIWYG 0x00008000L")]
    public const int CF_WYSIWYG = 0x00008000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_FORCEFONTEXIST"]/*' />
    [NativeTypeName("#define CF_FORCEFONTEXIST 0x00010000L")]
    public const int CF_FORCEFONTEXIST = 0x00010000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SCALABLEONLY"]/*' />
    [NativeTypeName("#define CF_SCALABLEONLY 0x00020000L")]
    public const int CF_SCALABLEONLY = 0x00020000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_TTONLY"]/*' />
    [NativeTypeName("#define CF_TTONLY 0x00040000L")]
    public const int CF_TTONLY = 0x00040000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOFACESEL"]/*' />
    [NativeTypeName("#define CF_NOFACESEL 0x00080000L")]
    public const int CF_NOFACESEL = 0x00080000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOSTYLESEL"]/*' />
    [NativeTypeName("#define CF_NOSTYLESEL 0x00100000L")]
    public const int CF_NOSTYLESEL = 0x00100000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOSIZESEL"]/*' />
    [NativeTypeName("#define CF_NOSIZESEL 0x00200000L")]
    public const int CF_NOSIZESEL = 0x00200000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SELECTSCRIPT"]/*' />
    [NativeTypeName("#define CF_SELECTSCRIPT 0x00400000L")]
    public const int CF_SELECTSCRIPT = 0x00400000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOSCRIPTSEL"]/*' />
    [NativeTypeName("#define CF_NOSCRIPTSEL 0x00800000L")]
    public const int CF_NOSCRIPTSEL = 0x00800000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_NOVERTFONTS"]/*' />
    [NativeTypeName("#define CF_NOVERTFONTS 0x01000000L")]
    public const int CF_NOVERTFONTS = 0x01000000;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_INACTIVEFONTS"]/*' />
    [NativeTypeName("#define CF_INACTIVEFONTS 0x02000000L")]
    public const int CF_INACTIVEFONTS = 0x02000000;
}
