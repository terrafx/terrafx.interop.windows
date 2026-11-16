// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DBIMF
{
    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_NORMAL"]/*' />
    [NativeTypeName("#define DBIMF_NORMAL 0x0000")]
    public const int DBIMF_NORMAL = 0x0000;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_FIXED"]/*' />
    [NativeTypeName("#define DBIMF_FIXED 0x0001")]
    public const int DBIMF_FIXED = 0x0001;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_FIXEDBMP"]/*' />
    [NativeTypeName("#define DBIMF_FIXEDBMP 0x0004")]
    public const int DBIMF_FIXEDBMP = 0x0004;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_VARIABLEHEIGHT"]/*' />
    [NativeTypeName("#define DBIMF_VARIABLEHEIGHT 0x0008")]
    public const int DBIMF_VARIABLEHEIGHT = 0x0008;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_UNDELETEABLE"]/*' />
    [NativeTypeName("#define DBIMF_UNDELETEABLE 0x0010")]
    public const int DBIMF_UNDELETEABLE = 0x0010;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_DEBOSSED"]/*' />
    [NativeTypeName("#define DBIMF_DEBOSSED 0x0020")]
    public const int DBIMF_DEBOSSED = 0x0020;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_BKCOLOR"]/*' />
    [NativeTypeName("#define DBIMF_BKCOLOR 0x0040")]
    public const int DBIMF_BKCOLOR = 0x0040;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_USECHEVRON"]/*' />
    [NativeTypeName("#define DBIMF_USECHEVRON 0x0080")]
    public const int DBIMF_USECHEVRON = 0x0080;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_BREAK"]/*' />
    [NativeTypeName("#define DBIMF_BREAK 0x0100")]
    public const int DBIMF_BREAK = 0x0100;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_ADDTOFRONT"]/*' />
    [NativeTypeName("#define DBIMF_ADDTOFRONT 0x0200")]
    public const int DBIMF_ADDTOFRONT = 0x0200;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_TOPALIGN"]/*' />
    [NativeTypeName("#define DBIMF_TOPALIGN 0x0400")]
    public const int DBIMF_TOPALIGN = 0x0400;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_NOGRIPPER"]/*' />
    [NativeTypeName("#define DBIMF_NOGRIPPER 0x0800")]
    public const int DBIMF_NOGRIPPER = 0x0800;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_ALWAYSGRIPPER"]/*' />
    [NativeTypeName("#define DBIMF_ALWAYSGRIPPER 0x1000")]
    public const int DBIMF_ALWAYSGRIPPER = 0x1000;

    /// <include file='DBIMF.xml' path='doc/member[@name="DBIMF.DBIMF_NOMARGINS"]/*' />
    [NativeTypeName("#define DBIMF_NOMARGINS 0x2000")]
    public const int DBIMF_NOMARGINS = 0x2000;
}
