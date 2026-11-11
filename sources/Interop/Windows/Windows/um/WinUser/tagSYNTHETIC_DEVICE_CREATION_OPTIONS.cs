// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='tagSYNTHETIC_DEVICE_CREATION_OPTIONS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_OPTIONS"]/*' />
public enum tagSYNTHETIC_DEVICE_CREATION_OPTIONS
{
    /// <include file='tagSYNTHETIC_DEVICE_CREATION_OPTIONS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_OPTIONS.SDCO_NONE"]/*' />
    SDCO_NONE = 0x0,

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_OPTIONS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_OPTIONS.SDCO_PHYSICAL_SIZE"]/*' />
    SDCO_PHYSICAL_SIZE = 0x1,

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_OPTIONS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_OPTIONS.SDCO_TOUCHPAD_GESTURE_ONLY"]/*' />
    SDCO_TOUCHPAD_GESTURE_ONLY = 0x2,
}
