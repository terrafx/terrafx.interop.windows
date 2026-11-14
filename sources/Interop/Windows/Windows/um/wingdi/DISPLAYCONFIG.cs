// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISPLAYCONFIG
{
    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_MAXPATH"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_MAXPATH 1024")]
    public const int DISPLAYCONFIG_MAXPATH = 1024;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_MODE_IDX_INVALID"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_MODE_IDX_INVALID 0xffffffff")]
    public const uint DISPLAYCONFIG_PATH_MODE_IDX_INVALID = 0xffffffff;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID 0xffff")]
    public const int DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID = 0xffff;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID 0xffff")]
    public const int DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID = 0xffff;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID 0xffff")]
    public const int DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID = 0xffff;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID 0xffff")]
    public const int DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID = 0xffff;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_SOURCE_IN_USE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_SOURCE_IN_USE 0x00000001")]
    public const int DISPLAYCONFIG_SOURCE_IN_USE = 0x00000001;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_IN_USE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_IN_USE 0x00000001")]
    public const int DISPLAYCONFIG_TARGET_IN_USE = 0x00000001;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_FORCIBLE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCIBLE 0x00000002")]
    public const int DISPLAYCONFIG_TARGET_FORCIBLE = 0x00000002;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT 0x00000004")]
    public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT = 0x00000004;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH 0x00000008")]
    public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH = 0x00000008;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM 0x00000010")]
    public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM = 0x00000010;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_TARGET_IS_HMD"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_TARGET_IS_HMD 0x00000020")]
    public const int DISPLAYCONFIG_TARGET_IS_HMD = 0x00000020;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_ACTIVE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_ACTIVE 0x00000001")]
    public const int DISPLAYCONFIG_PATH_ACTIVE = 0x00000001;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_PREFERRED_UNSCALED"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_PREFERRED_UNSCALED 0x00000004")]
    public const int DISPLAYCONFIG_PATH_PREFERRED_UNSCALED = 0x00000004;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE 0x00000008")]
    public const int DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE = 0x00000008;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_BOOST_REFRESH_RATE"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_BOOST_REFRESH_RATE 0x00000010")]
    public const int DISPLAYCONFIG_PATH_BOOST_REFRESH_RATE = 0x00000010;

    /// <include file='DISPLAYCONFIG.xml' path='doc/member[@name="DISPLAYCONFIG.DISPLAYCONFIG_PATH_VALID_FLAGS"]/*' />
    [NativeTypeName("#define DISPLAYCONFIG_PATH_VALID_FLAGS 0x0000001D")]
    public const int DISPLAYCONFIG_PATH_VALID_FLAGS = 0x0000001D;
}
