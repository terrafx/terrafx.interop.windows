// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLOG_BACK"]/*' />
    [NativeTypeName("#define TLOG_BACK -1")]
    public const int TLOG_BACK = -1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLOG_CURRENT"]/*' />
    [NativeTypeName("#define TLOG_CURRENT 0")]
    public const int TLOG_CURRENT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLOG_FORE"]/*' />
    [NativeTypeName("#define TLOG_FORE 1")]
    public const int TLOG_FORE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLMENUF_INCLUDECURRENT"]/*' />
    [NativeTypeName("#define TLMENUF_INCLUDECURRENT 0x00000001")]
    public const int TLMENUF_INCLUDECURRENT = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLMENUF_CHECKCURRENT"]/*' />
    [NativeTypeName("#define TLMENUF_CHECKCURRENT (TLMENUF_INCLUDECURRENT | 0x00000002)")]
    public const int TLMENUF_CHECKCURRENT = (0x00000001 | 0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLMENUF_BACK"]/*' />
    [NativeTypeName("#define TLMENUF_BACK 0x00000010")]
    public const int TLMENUF_BACK = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLMENUF_FORE"]/*' />
    [NativeTypeName("#define TLMENUF_FORE 0x00000020")]
    public const int TLMENUF_FORE = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLMENUF_BACKANDFORTH"]/*' />
    [NativeTypeName("#define TLMENUF_BACKANDFORTH (TLMENUF_BACK | TLMENUF_FORE | TLMENUF_INCLUDECURRENT)")]
    public const int TLMENUF_BACKANDFORTH = (0x00000010 | 0x00000020 | 0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_CALLERUNTRUSTED"]/*' />
    [NativeTypeName("#define HLNF_CALLERUNTRUSTED 0x00200000")]
    public const int HLNF_CALLERUNTRUSTED = 0x00200000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_TRUSTEDFORACTIVEX"]/*' />
    [NativeTypeName("#define HLNF_TRUSTEDFORACTIVEX 0x00400000")]
    public const int HLNF_TRUSTEDFORACTIVEX = 0x00400000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_DISABLEWINDOWRESTRICTIONS"]/*' />
    [NativeTypeName("#define HLNF_DISABLEWINDOWRESTRICTIONS 0x00800000")]
    public const int HLNF_DISABLEWINDOWRESTRICTIONS = 0x00800000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_TRUSTFIRSTDOWNLOAD"]/*' />
    [NativeTypeName("#define HLNF_TRUSTFIRSTDOWNLOAD 0x01000000")]
    public const int HLNF_TRUSTFIRSTDOWNLOAD = 0x01000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_UNTRUSTEDFORDOWNLOAD"]/*' />
    [NativeTypeName("#define HLNF_UNTRUSTEDFORDOWNLOAD 0x02000000")]
    public const int HLNF_UNTRUSTEDFORDOWNLOAD = 0x02000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHHLNF_NOAUTOSELECT"]/*' />
    [NativeTypeName("#define SHHLNF_NOAUTOSELECT 0x04000000")]
    public const int SHHLNF_NOAUTOSELECT = 0x04000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHHLNF_WRITENOHISTORY"]/*' />
    [NativeTypeName("#define SHHLNF_WRITENOHISTORY 0x08000000")]
    public const int SHHLNF_WRITENOHISTORY = 0x08000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_EXTERNALNAVIGATE"]/*' />
    [NativeTypeName("#define HLNF_EXTERNALNAVIGATE 0x10000000")]
    public const int HLNF_EXTERNALNAVIGATE = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_ALLOW_AUTONAVIGATE"]/*' />
    [NativeTypeName("#define HLNF_ALLOW_AUTONAVIGATE 0x20000000")]
    public const int HLNF_ALLOW_AUTONAVIGATE = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HLNF_NEWWINDOWSMANAGED"]/*' />
    [NativeTypeName("#define HLNF_NEWWINDOWSMANAGED 0x80000000")]
    public const uint HLNF_NEWWINDOWSMANAGED = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITB_VIEW"]/*' />
    [NativeTypeName("#define ITB_VIEW ((UINT)-1)")]
    public const uint ITB_VIEW = unchecked((uint)(-1));
}
