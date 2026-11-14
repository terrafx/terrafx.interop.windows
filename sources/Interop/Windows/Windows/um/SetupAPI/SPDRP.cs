// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPDRP
{
    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_DEVICEDESC"]/*' />
    [NativeTypeName("#define SPDRP_DEVICEDESC (0x00000000)")]
    public const int SPDRP_DEVICEDESC = (0x00000000);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_HARDWAREID"]/*' />
    [NativeTypeName("#define SPDRP_HARDWAREID (0x00000001)")]
    public const int SPDRP_HARDWAREID = (0x00000001);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_COMPATIBLEIDS"]/*' />
    [NativeTypeName("#define SPDRP_COMPATIBLEIDS (0x00000002)")]
    public const int SPDRP_COMPATIBLEIDS = (0x00000002);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UNUSED0"]/*' />
    [NativeTypeName("#define SPDRP_UNUSED0 (0x00000003)")]
    public const int SPDRP_UNUSED0 = (0x00000003);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_SERVICE"]/*' />
    [NativeTypeName("#define SPDRP_SERVICE (0x00000004)")]
    public const int SPDRP_SERVICE = (0x00000004);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UNUSED1"]/*' />
    [NativeTypeName("#define SPDRP_UNUSED1 (0x00000005)")]
    public const int SPDRP_UNUSED1 = (0x00000005);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UNUSED2"]/*' />
    [NativeTypeName("#define SPDRP_UNUSED2 (0x00000006)")]
    public const int SPDRP_UNUSED2 = (0x00000006);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_CLASS"]/*' />
    [NativeTypeName("#define SPDRP_CLASS (0x00000007)")]
    public const int SPDRP_CLASS = (0x00000007);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_CLASSGUID"]/*' />
    [NativeTypeName("#define SPDRP_CLASSGUID (0x00000008)")]
    public const int SPDRP_CLASSGUID = (0x00000008);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_DRIVER"]/*' />
    [NativeTypeName("#define SPDRP_DRIVER (0x00000009)")]
    public const int SPDRP_DRIVER = (0x00000009);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_CONFIGFLAGS"]/*' />
    [NativeTypeName("#define SPDRP_CONFIGFLAGS (0x0000000A)")]
    public const int SPDRP_CONFIGFLAGS = (0x0000000A);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_MFG"]/*' />
    [NativeTypeName("#define SPDRP_MFG (0x0000000B)")]
    public const int SPDRP_MFG = (0x0000000B);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_FRIENDLYNAME"]/*' />
    [NativeTypeName("#define SPDRP_FRIENDLYNAME (0x0000000C)")]
    public const int SPDRP_FRIENDLYNAME = (0x0000000C);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_LOCATION_INFORMATION"]/*' />
    [NativeTypeName("#define SPDRP_LOCATION_INFORMATION (0x0000000D)")]
    public const int SPDRP_LOCATION_INFORMATION = (0x0000000D);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_PHYSICAL_DEVICE_OBJECT_NAME"]/*' />
    [NativeTypeName("#define SPDRP_PHYSICAL_DEVICE_OBJECT_NAME (0x0000000E)")]
    public const int SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = (0x0000000E);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_CAPABILITIES"]/*' />
    [NativeTypeName("#define SPDRP_CAPABILITIES (0x0000000F)")]
    public const int SPDRP_CAPABILITIES = (0x0000000F);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UI_NUMBER"]/*' />
    [NativeTypeName("#define SPDRP_UI_NUMBER (0x00000010)")]
    public const int SPDRP_UI_NUMBER = (0x00000010);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UPPERFILTERS"]/*' />
    [NativeTypeName("#define SPDRP_UPPERFILTERS (0x00000011)")]
    public const int SPDRP_UPPERFILTERS = (0x00000011);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_LOWERFILTERS"]/*' />
    [NativeTypeName("#define SPDRP_LOWERFILTERS (0x00000012)")]
    public const int SPDRP_LOWERFILTERS = (0x00000012);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_BUSTYPEGUID"]/*' />
    [NativeTypeName("#define SPDRP_BUSTYPEGUID (0x00000013)")]
    public const int SPDRP_BUSTYPEGUID = (0x00000013);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_LEGACYBUSTYPE"]/*' />
    [NativeTypeName("#define SPDRP_LEGACYBUSTYPE (0x00000014)")]
    public const int SPDRP_LEGACYBUSTYPE = (0x00000014);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_BUSNUMBER"]/*' />
    [NativeTypeName("#define SPDRP_BUSNUMBER (0x00000015)")]
    public const int SPDRP_BUSNUMBER = (0x00000015);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_ENUMERATOR_NAME"]/*' />
    [NativeTypeName("#define SPDRP_ENUMERATOR_NAME (0x00000016)")]
    public const int SPDRP_ENUMERATOR_NAME = (0x00000016);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_SECURITY"]/*' />
    [NativeTypeName("#define SPDRP_SECURITY (0x00000017)")]
    public const int SPDRP_SECURITY = (0x00000017);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_SECURITY_SDS"]/*' />
    [NativeTypeName("#define SPDRP_SECURITY_SDS (0x00000018)")]
    public const int SPDRP_SECURITY_SDS = (0x00000018);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_DEVTYPE"]/*' />
    [NativeTypeName("#define SPDRP_DEVTYPE (0x00000019)")]
    public const int SPDRP_DEVTYPE = (0x00000019);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_EXCLUSIVE"]/*' />
    [NativeTypeName("#define SPDRP_EXCLUSIVE (0x0000001A)")]
    public const int SPDRP_EXCLUSIVE = (0x0000001A);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_CHARACTERISTICS"]/*' />
    [NativeTypeName("#define SPDRP_CHARACTERISTICS (0x0000001B)")]
    public const int SPDRP_CHARACTERISTICS = (0x0000001B);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_ADDRESS"]/*' />
    [NativeTypeName("#define SPDRP_ADDRESS (0x0000001C)")]
    public const int SPDRP_ADDRESS = (0x0000001C);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_UI_NUMBER_DESC_FORMAT"]/*' />
    [NativeTypeName("#define SPDRP_UI_NUMBER_DESC_FORMAT (0X0000001D)")]
    public const int SPDRP_UI_NUMBER_DESC_FORMAT = (0X0000001D);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_DEVICE_POWER_DATA"]/*' />
    [NativeTypeName("#define SPDRP_DEVICE_POWER_DATA (0x0000001E)")]
    public const int SPDRP_DEVICE_POWER_DATA = (0x0000001E);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_REMOVAL_POLICY"]/*' />
    [NativeTypeName("#define SPDRP_REMOVAL_POLICY (0x0000001F)")]
    public const int SPDRP_REMOVAL_POLICY = (0x0000001F);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_REMOVAL_POLICY_HW_DEFAULT"]/*' />
    [NativeTypeName("#define SPDRP_REMOVAL_POLICY_HW_DEFAULT (0x00000020)")]
    public const int SPDRP_REMOVAL_POLICY_HW_DEFAULT = (0x00000020);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_REMOVAL_POLICY_OVERRIDE"]/*' />
    [NativeTypeName("#define SPDRP_REMOVAL_POLICY_OVERRIDE (0x00000021)")]
    public const int SPDRP_REMOVAL_POLICY_OVERRIDE = (0x00000021);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_INSTALL_STATE"]/*' />
    [NativeTypeName("#define SPDRP_INSTALL_STATE (0x00000022)")]
    public const int SPDRP_INSTALL_STATE = (0x00000022);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_LOCATION_PATHS"]/*' />
    [NativeTypeName("#define SPDRP_LOCATION_PATHS (0x00000023)")]
    public const int SPDRP_LOCATION_PATHS = (0x00000023);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_BASE_CONTAINERID"]/*' />
    [NativeTypeName("#define SPDRP_BASE_CONTAINERID (0x00000024)")]
    public const int SPDRP_BASE_CONTAINERID = (0x00000024);

    /// <include file='SPDRP.xml' path='doc/member[@name="SPDRP.SPDRP_MAXIMUM_PROPERTY"]/*' />
    [NativeTypeName("#define SPDRP_MAXIMUM_PROPERTY (0x00000025)")]
    public const int SPDRP_MAXIMUM_PROPERTY = (0x00000025);
}
