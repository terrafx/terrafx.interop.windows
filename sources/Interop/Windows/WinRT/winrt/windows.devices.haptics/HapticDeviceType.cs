// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType"]/*' />
public enum HapticDeviceType
{
    /// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType.HapticDeviceType_None"]/*' />
    HapticDeviceType_None = 0,

    /// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType.HapticDeviceType_Generic"]/*' />
    HapticDeviceType_Generic = 1,

    /// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType.HapticDeviceType_Pen"]/*' />
    HapticDeviceType_Pen = 2,

    /// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType.HapticDeviceType_Touchpad"]/*' />
    HapticDeviceType_Touchpad = 3,

    /// <include file='HapticDeviceType.xml' path='doc/member[@name="HapticDeviceType.HapticDeviceType_Mouse"]/*' />
    HapticDeviceType_Mouse = 4,
}
