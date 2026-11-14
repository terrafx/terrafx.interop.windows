// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DNF
{
    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_DUPDESC"]/*' />
    [NativeTypeName("#define DNF_DUPDESC 0x00000001")]
    public const int DNF_DUPDESC = 0x00000001;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_OLDDRIVER"]/*' />
    [NativeTypeName("#define DNF_OLDDRIVER 0x00000002")]
    public const int DNF_OLDDRIVER = 0x00000002;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_EXCLUDEFROMLIST"]/*' />
    [NativeTypeName("#define DNF_EXCLUDEFROMLIST 0x00000004")]
    public const int DNF_EXCLUDEFROMLIST = 0x00000004;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_NODRIVER"]/*' />
    [NativeTypeName("#define DNF_NODRIVER 0x00000008")]
    public const int DNF_NODRIVER = 0x00000008;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_LEGACYINF"]/*' />
    [NativeTypeName("#define DNF_LEGACYINF 0x00000010")]
    public const int DNF_LEGACYINF = 0x00000010;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_CLASS_DRIVER"]/*' />
    [NativeTypeName("#define DNF_CLASS_DRIVER 0x00000020")]
    public const int DNF_CLASS_DRIVER = 0x00000020;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_COMPATIBLE_DRIVER"]/*' />
    [NativeTypeName("#define DNF_COMPATIBLE_DRIVER 0x00000040")]
    public const int DNF_COMPATIBLE_DRIVER = 0x00000040;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_INET_DRIVER"]/*' />
    [NativeTypeName("#define DNF_INET_DRIVER 0x00000080")]
    public const int DNF_INET_DRIVER = 0x00000080;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED1"]/*' />
    [NativeTypeName("#define DNF_UNUSED1 0x00000100")]
    public const int DNF_UNUSED1 = 0x00000100;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED2"]/*' />
    [NativeTypeName("#define DNF_UNUSED2 0x00000200")]
    public const int DNF_UNUSED2 = 0x00000200;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_OLD_INET_DRIVER"]/*' />
    [NativeTypeName("#define DNF_OLD_INET_DRIVER 0x00000400")]
    public const int DNF_OLD_INET_DRIVER = 0x00000400;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_BAD_DRIVER"]/*' />
    [NativeTypeName("#define DNF_BAD_DRIVER 0x00000800")]
    public const int DNF_BAD_DRIVER = 0x00000800;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_DUPPROVIDER"]/*' />
    [NativeTypeName("#define DNF_DUPPROVIDER 0x00001000")]
    public const int DNF_DUPPROVIDER = 0x00001000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_INF_IS_SIGNED"]/*' />
    [NativeTypeName("#define DNF_INF_IS_SIGNED 0x00002000")]
    public const int DNF_INF_IS_SIGNED = 0x00002000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_OEM_F6_INF"]/*' />
    [NativeTypeName("#define DNF_OEM_F6_INF 0x00004000")]
    public const int DNF_OEM_F6_INF = 0x00004000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_DUPDRIVERVER"]/*' />
    [NativeTypeName("#define DNF_DUPDRIVERVER 0x00008000")]
    public const int DNF_DUPDRIVERVER = 0x00008000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_BASIC_DRIVER"]/*' />
    [NativeTypeName("#define DNF_BASIC_DRIVER 0x00010000")]
    public const int DNF_BASIC_DRIVER = 0x00010000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_AUTHENTICODE_SIGNED"]/*' />
    [NativeTypeName("#define DNF_AUTHENTICODE_SIGNED 0x00020000")]
    public const int DNF_AUTHENTICODE_SIGNED = 0x00020000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_INSTALLEDDRIVER"]/*' />
    [NativeTypeName("#define DNF_INSTALLEDDRIVER 0x00040000")]
    public const int DNF_INSTALLEDDRIVER = 0x00040000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_ALWAYSEXCLUDEFROMLIST"]/*' />
    [NativeTypeName("#define DNF_ALWAYSEXCLUDEFROMLIST 0x00080000")]
    public const int DNF_ALWAYSEXCLUDEFROMLIST = 0x00080000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_INBOX_DRIVER"]/*' />
    [NativeTypeName("#define DNF_INBOX_DRIVER 0x00100000")]
    public const int DNF_INBOX_DRIVER = 0x00100000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_REQUESTADDITIONALSOFTWARE"]/*' />
    [NativeTypeName("#define DNF_REQUESTADDITIONALSOFTWARE 0x00200000")]
    public const int DNF_REQUESTADDITIONALSOFTWARE = 0x00200000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_22"]/*' />
    [NativeTypeName("#define DNF_UNUSED_22 0x00400000")]
    public const int DNF_UNUSED_22 = 0x00400000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_23"]/*' />
    [NativeTypeName("#define DNF_UNUSED_23 0x00800000")]
    public const int DNF_UNUSED_23 = 0x00800000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_24"]/*' />
    [NativeTypeName("#define DNF_UNUSED_24 0x01000000")]
    public const int DNF_UNUSED_24 = 0x01000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_25"]/*' />
    [NativeTypeName("#define DNF_UNUSED_25 0x02000000")]
    public const int DNF_UNUSED_25 = 0x02000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_26"]/*' />
    [NativeTypeName("#define DNF_UNUSED_26 0x04000000")]
    public const int DNF_UNUSED_26 = 0x04000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_27"]/*' />
    [NativeTypeName("#define DNF_UNUSED_27 0x08000000")]
    public const int DNF_UNUSED_27 = 0x08000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_28"]/*' />
    [NativeTypeName("#define DNF_UNUSED_28 0x10000000")]
    public const int DNF_UNUSED_28 = 0x10000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_29"]/*' />
    [NativeTypeName("#define DNF_UNUSED_29 0x20000000")]
    public const int DNF_UNUSED_29 = 0x20000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_30"]/*' />
    [NativeTypeName("#define DNF_UNUSED_30 0x40000000")]
    public const int DNF_UNUSED_30 = 0x40000000;

    /// <include file='DNF.xml' path='doc/member[@name="DNF.DNF_UNUSED_31"]/*' />
    [NativeTypeName("#define DNF_UNUSED_31 0x80000000")]
    public const uint DNF_UNUSED_31 = 0x80000000;
}
