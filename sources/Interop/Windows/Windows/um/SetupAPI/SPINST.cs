// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPINST
{
    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_LOGCONFIG"]/*' />
    [NativeTypeName("#define SPINST_LOGCONFIG 0x00000001")]
    public const int SPINST_LOGCONFIG = 0x00000001;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_INIFILES"]/*' />
    [NativeTypeName("#define SPINST_INIFILES 0x00000002")]
    public const int SPINST_INIFILES = 0x00000002;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_REGISTRY"]/*' />
    [NativeTypeName("#define SPINST_REGISTRY 0x00000004")]
    public const int SPINST_REGISTRY = 0x00000004;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_INI2REG"]/*' />
    [NativeTypeName("#define SPINST_INI2REG 0x00000008")]
    public const int SPINST_INI2REG = 0x00000008;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_FILES"]/*' />
    [NativeTypeName("#define SPINST_FILES 0x00000010")]
    public const int SPINST_FILES = 0x00000010;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_BITREG"]/*' />
    [NativeTypeName("#define SPINST_BITREG 0x00000020")]
    public const int SPINST_BITREG = 0x00000020;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_REGSVR"]/*' />
    [NativeTypeName("#define SPINST_REGSVR 0x00000040")]
    public const int SPINST_REGSVR = 0x00000040;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_UNREGSVR"]/*' />
    [NativeTypeName("#define SPINST_UNREGSVR 0x00000080")]
    public const int SPINST_UNREGSVR = 0x00000080;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_PROFILEITEMS"]/*' />
    [NativeTypeName("#define SPINST_PROFILEITEMS 0x00000100")]
    public const int SPINST_PROFILEITEMS = 0x00000100;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_COPYINF"]/*' />
    [NativeTypeName("#define SPINST_COPYINF 0x00000200")]
    public const int SPINST_COPYINF = 0x00000200;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_PROPERTIES"]/*' />
    [NativeTypeName("#define SPINST_PROPERTIES 0x00000400")]
    public const int SPINST_PROPERTIES = 0x00000400;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_ALL"]/*' />
    [NativeTypeName("#define SPINST_ALL 0x000007ff")]
    public const int SPINST_ALL = 0x000007ff;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_SINGLESECTION"]/*' />
    [NativeTypeName("#define SPINST_SINGLESECTION 0x00010000")]
    public const int SPINST_SINGLESECTION = 0x00010000;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_LOGCONFIG_IS_FORCED"]/*' />
    [NativeTypeName("#define SPINST_LOGCONFIG_IS_FORCED 0x00020000")]
    public const int SPINST_LOGCONFIG_IS_FORCED = 0x00020000;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_LOGCONFIGS_ARE_OVERRIDES"]/*' />
    [NativeTypeName("#define SPINST_LOGCONFIGS_ARE_OVERRIDES 0x00040000")]
    public const int SPINST_LOGCONFIGS_ARE_OVERRIDES = 0x00040000;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_REGISTERCALLBACKAWARE"]/*' />
    [NativeTypeName("#define SPINST_REGISTERCALLBACKAWARE 0x00080000")]
    public const int SPINST_REGISTERCALLBACKAWARE = 0x00080000;

    /// <include file='SPINST.xml' path='doc/member[@name="SPINST.SPINST_DEVICEINSTALL"]/*' />
    [NativeTypeName("#define SPINST_DEVICEINSTALL 0x00100000")]
    public const int SPINST_DEVICEINSTALL = 0x00100000;
}
