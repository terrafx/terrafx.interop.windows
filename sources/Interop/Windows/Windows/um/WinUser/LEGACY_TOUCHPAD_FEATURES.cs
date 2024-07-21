// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='LEGACY_TOUCHPAD_FEATURES.xml' path='doc/member[@name="LEGACY_TOUCHPAD_FEATURES"]/*' />
public enum LEGACY_TOUCHPAD_FEATURES
{
    /// <include file='LEGACY_TOUCHPAD_FEATURES.xml' path='doc/member[@name="LEGACY_TOUCHPAD_FEATURES.LEGACY_TOUCHPAD_FEATURE_NONE"]/*' />
    LEGACY_TOUCHPAD_FEATURE_NONE = 0x00000000,

    /// <include file='LEGACY_TOUCHPAD_FEATURES.xml' path='doc/member[@name="LEGACY_TOUCHPAD_FEATURES.LEGACY_TOUCHPAD_FEATURE_ENABLE_DISABLE"]/*' />
    LEGACY_TOUCHPAD_FEATURE_ENABLE_DISABLE = 0x00000001,

    /// <include file='LEGACY_TOUCHPAD_FEATURES.xml' path='doc/member[@name="LEGACY_TOUCHPAD_FEATURES.LEGACY_TOUCHPAD_FEATURE_REVERSE_SCROLL_DIRECTION"]/*' />
    LEGACY_TOUCHPAD_FEATURE_REVERSE_SCROLL_DIRECTION = 0x00000004,
}
