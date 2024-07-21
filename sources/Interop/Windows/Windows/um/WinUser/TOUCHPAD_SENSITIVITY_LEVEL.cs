// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL"]/*' />
public enum TOUCHPAD_SENSITIVITY_LEVEL
{
    /// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL.TOUCHPAD_SENSITIVITY_LEVEL_MOST_SENSITIVE"]/*' />
    TOUCHPAD_SENSITIVITY_LEVEL_MOST_SENSITIVE = 0x00000000,

    /// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL.TOUCHPAD_SENSITIVITY_LEVEL_HIGH_SENSITIVITY"]/*' />
    TOUCHPAD_SENSITIVITY_LEVEL_HIGH_SENSITIVITY = 0x00000001,

    /// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL.TOUCHPAD_SENSITIVITY_LEVEL_MEDIUM_SENSITIVITY"]/*' />
    TOUCHPAD_SENSITIVITY_LEVEL_MEDIUM_SENSITIVITY = 0x00000002,

    /// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL.TOUCHPAD_SENSITIVITY_LEVEL_LOW_SENSITIVITY"]/*' />
    TOUCHPAD_SENSITIVITY_LEVEL_LOW_SENSITIVITY = 0x00000003,

    /// <include file='TOUCHPAD_SENSITIVITY_LEVEL.xml' path='doc/member[@name="TOUCHPAD_SENSITIVITY_LEVEL.TOUCHPAD_SENSITIVITY_LEVEL_LEAST_SENSITIVE"]/*' />
    TOUCHPAD_SENSITIVITY_LEVEL_LEAST_SENSITIVE = 0x00000004,
}
