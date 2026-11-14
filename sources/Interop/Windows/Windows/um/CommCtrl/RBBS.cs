// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RBBS
{
    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_BREAK"]/*' />
    [NativeTypeName("#define RBBS_BREAK 0x00000001")]
    public const int RBBS_BREAK = 0x00000001;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_FIXEDSIZE"]/*' />
    [NativeTypeName("#define RBBS_FIXEDSIZE 0x00000002")]
    public const int RBBS_FIXEDSIZE = 0x00000002;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_CHILDEDGE"]/*' />
    [NativeTypeName("#define RBBS_CHILDEDGE 0x00000004")]
    public const int RBBS_CHILDEDGE = 0x00000004;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_HIDDEN"]/*' />
    [NativeTypeName("#define RBBS_HIDDEN 0x00000008")]
    public const int RBBS_HIDDEN = 0x00000008;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_NOVERT"]/*' />
    [NativeTypeName("#define RBBS_NOVERT 0x00000010")]
    public const int RBBS_NOVERT = 0x00000010;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_FIXEDBMP"]/*' />
    [NativeTypeName("#define RBBS_FIXEDBMP 0x00000020")]
    public const int RBBS_FIXEDBMP = 0x00000020;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_VARIABLEHEIGHT"]/*' />
    [NativeTypeName("#define RBBS_VARIABLEHEIGHT 0x00000040")]
    public const int RBBS_VARIABLEHEIGHT = 0x00000040;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_GRIPPERALWAYS"]/*' />
    [NativeTypeName("#define RBBS_GRIPPERALWAYS 0x00000080")]
    public const int RBBS_GRIPPERALWAYS = 0x00000080;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_NOGRIPPER"]/*' />
    [NativeTypeName("#define RBBS_NOGRIPPER 0x00000100")]
    public const int RBBS_NOGRIPPER = 0x00000100;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_USECHEVRON"]/*' />
    [NativeTypeName("#define RBBS_USECHEVRON 0x00000200")]
    public const int RBBS_USECHEVRON = 0x00000200;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_HIDETITLE"]/*' />
    [NativeTypeName("#define RBBS_HIDETITLE 0x00000400")]
    public const int RBBS_HIDETITLE = 0x00000400;

    /// <include file='RBBS.xml' path='doc/member[@name="RBBS.RBBS_TOPALIGN"]/*' />
    [NativeTypeName("#define RBBS_TOPALIGN 0x00000800")]
    public const int RBBS_TOPALIGN = 0x00000800;
}
