// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/reason.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHTDN
{
    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_COMMENT_REQUIRED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_COMMENT_REQUIRED 0x01000000")]
    public const int SHTDN_REASON_FLAG_COMMENT_REQUIRED = 0x01000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED 0x02000000")]
    public const int SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED = 0x02000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_CLEAN_UI"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_CLEAN_UI 0x04000000")]
    public const int SHTDN_REASON_FLAG_CLEAN_UI = 0x04000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_DIRTY_UI"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_DIRTY_UI 0x08000000")]
    public const int SHTDN_REASON_FLAG_DIRTY_UI = 0x08000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_MOBILE_UI_RESERVED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_MOBILE_UI_RESERVED 0x10000000")]
    public const int SHTDN_REASON_FLAG_MOBILE_UI_RESERVED = 0x10000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_USER_DEFINED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_USER_DEFINED 0x40000000")]
    public const int SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_FLAG_PLANNED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_FLAG_PLANNED 0x80000000")]
    public const uint SHTDN_REASON_FLAG_PLANNED = 0x80000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_OTHER"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_OTHER 0x00000000")]
    public const int SHTDN_REASON_MAJOR_OTHER = 0x00000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_NONE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_NONE 0x00000000")]
    public const int SHTDN_REASON_MAJOR_NONE = 0x00000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_HARDWARE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_HARDWARE 0x00010000")]
    public const int SHTDN_REASON_MAJOR_HARDWARE = 0x00010000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_OPERATINGSYSTEM"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_OPERATINGSYSTEM 0x00020000")]
    public const int SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_SOFTWARE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_SOFTWARE 0x00030000")]
    public const int SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_APPLICATION"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_APPLICATION 0x00040000")]
    public const int SHTDN_REASON_MAJOR_APPLICATION = 0x00040000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_SYSTEM"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_SYSTEM 0x00050000")]
    public const int SHTDN_REASON_MAJOR_SYSTEM = 0x00050000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_POWER"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_POWER 0x00060000")]
    public const int SHTDN_REASON_MAJOR_POWER = 0x00060000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MAJOR_LEGACY_API"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MAJOR_LEGACY_API 0x00070000")]
    public const int SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_OTHER"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_OTHER 0x00000000")]
    public const int SHTDN_REASON_MINOR_OTHER = 0x00000000;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_NONE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_NONE 0x000000ff")]
    public const int SHTDN_REASON_MINOR_NONE = 0x000000ff;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_MAINTENANCE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_MAINTENANCE 0x00000001")]
    public const int SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_INSTALLATION"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_INSTALLATION 0x00000002")]
    public const int SHTDN_REASON_MINOR_INSTALLATION = 0x00000002;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_UPGRADE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_UPGRADE 0x00000003")]
    public const int SHTDN_REASON_MINOR_UPGRADE = 0x00000003;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_RECONFIG"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_RECONFIG 0x00000004")]
    public const int SHTDN_REASON_MINOR_RECONFIG = 0x00000004;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_HUNG"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_HUNG 0x00000005")]
    public const int SHTDN_REASON_MINOR_HUNG = 0x00000005;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_UNSTABLE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_UNSTABLE 0x00000006")]
    public const int SHTDN_REASON_MINOR_UNSTABLE = 0x00000006;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_DISK"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_DISK 0x00000007")]
    public const int SHTDN_REASON_MINOR_DISK = 0x00000007;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_PROCESSOR"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_PROCESSOR 0x00000008")]
    public const int SHTDN_REASON_MINOR_PROCESSOR = 0x00000008;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_NETWORKCARD"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_NETWORKCARD 0x00000009")]
    public const int SHTDN_REASON_MINOR_NETWORKCARD = 0x00000009;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_POWER_SUPPLY"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_POWER_SUPPLY 0x0000000a")]
    public const int SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000a;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_CORDUNPLUGGED"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_CORDUNPLUGGED 0x0000000b")]
    public const int SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000b;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_ENVIRONMENT"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_ENVIRONMENT 0x0000000c")]
    public const int SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000c;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_HARDWARE_DRIVER"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_HARDWARE_DRIVER 0x0000000d")]
    public const int SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000d;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_OTHERDRIVER"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_OTHERDRIVER 0x0000000e")]
    public const int SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000e;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_BLUESCREEN"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_BLUESCREEN 0x0000000F")]
    public const int SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000F;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SERVICEPACK"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SERVICEPACK 0x00000010")]
    public const int SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_HOTFIX"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_HOTFIX 0x00000011")]
    public const int SHTDN_REASON_MINOR_HOTFIX = 0x00000011;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SECURITYFIX"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SECURITYFIX 0x00000012")]
    public const int SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SECURITY"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SECURITY 0x00000013")]
    public const int SHTDN_REASON_MINOR_SECURITY = 0x00000013;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY 0x00000014")]
    public const int SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_WMI"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_WMI 0x00000015")]
    public const int SHTDN_REASON_MINOR_WMI = 0x00000015;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL 0x00000016")]
    public const int SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_HOTFIX_UNINSTALL"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_HOTFIX_UNINSTALL 0x00000017")]
    public const int SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL 0x00000018")]
    public const int SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_MMC"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_MMC 0x00000019")]
    public const int SHTDN_REASON_MINOR_MMC = 0x00000019;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_SYSTEMRESTORE"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_SYSTEMRESTORE 0x0000001a")]
    public const int SHTDN_REASON_MINOR_SYSTEMRESTORE = 0x0000001a;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_TERMSRV"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_TERMSRV 0x00000020")]
    public const int SHTDN_REASON_MINOR_TERMSRV = 0x00000020;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_DC_PROMOTION"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_DC_PROMOTION 0x00000021")]
    public const int SHTDN_REASON_MINOR_DC_PROMOTION = 0x00000021;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_MINOR_DC_DEMOTION"]/*' />
    [NativeTypeName("#define SHTDN_REASON_MINOR_DC_DEMOTION 0x00000022")]
    public const int SHTDN_REASON_MINOR_DC_DEMOTION = 0x00000022;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_UNKNOWN"]/*' />
    [NativeTypeName("#define SHTDN_REASON_UNKNOWN SHTDN_REASON_MINOR_NONE")]
    public const int SHTDN_REASON_UNKNOWN = 0x000000ff;

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_LEGACY_API"]/*' />
    [NativeTypeName("#define SHTDN_REASON_LEGACY_API (SHTDN_REASON_MAJOR_LEGACY_API | SHTDN_REASON_FLAG_PLANNED)")]
    public const uint SHTDN_REASON_LEGACY_API = (0x00070000 | 0x80000000);

    /// <include file='SHTDN.xml' path='doc/member[@name="SHTDN.SHTDN_REASON_VALID_BIT_MASK"]/*' />
    [NativeTypeName("#define SHTDN_REASON_VALID_BIT_MASK 0xc0ffffff")]
    public const uint SHTDN_REASON_VALID_BIT_MASK = 0xc0ffffff;
}
