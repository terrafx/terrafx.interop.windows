// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SET
{
    /// <include file='SET.xml' path='doc/member[@name="SET.SET_REPAIR_ENABLED"]/*' />
    [NativeTypeName("#define SET_REPAIR_ENABLED (0x00000001)")]
    public const int SET_REPAIR_ENABLED = (0x00000001);

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_REPAIR_WARN_ABOUT_DATA_LOSS"]/*' />
    [NativeTypeName("#define SET_REPAIR_WARN_ABOUT_DATA_LOSS (0x00000008)")]
    public const int SET_REPAIR_WARN_ABOUT_DATA_LOSS = (0x00000008);

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT"]/*' />
    [NativeTypeName("#define SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT (0x00000010)")]
    public const int SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT = (0x00000010);

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_REPAIR_VALID_MASK"]/*' />
    [NativeTypeName("#define SET_REPAIR_VALID_MASK (0x00000019)")]
    public const int SET_REPAIR_VALID_MASK = (0x00000019);

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_PURGE_FAILURE_MODE_ENABLED"]/*' />
    [NativeTypeName("#define SET_PURGE_FAILURE_MODE_ENABLED 0x00000001")]
    public const int SET_PURGE_FAILURE_MODE_ENABLED = 0x00000001;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_PURGE_FAILURE_MODE_DISABLED"]/*' />
    [NativeTypeName("#define SET_PURGE_FAILURE_MODE_DISABLED 0x00000002")]
    public const int SET_PURGE_FAILURE_MODE_DISABLED = 0x00000002;
}
