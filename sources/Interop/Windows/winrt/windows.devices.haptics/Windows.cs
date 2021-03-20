// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [70]")]
        public const string InterfaceName_Windows_Devices_Haptics_IKnownSimpleHapticsControllerWaveformsStatics = "Windows.Devices.Haptics.IKnownSimpleHapticsControllerWaveformsStatics";

        [NativeTypeName("const WCHAR [49]")]
        public const string InterfaceName_Windows_Devices_Haptics_ISimpleHapticsController = "Windows.Devices.Haptics.ISimpleHapticsController";

        [NativeTypeName("const WCHAR [57]")]
        public const string InterfaceName_Windows_Devices_Haptics_ISimpleHapticsControllerFeedback = "Windows.Devices.Haptics.ISimpleHapticsControllerFeedback";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Devices_Haptics_IVibrationDevice = "Windows.Devices.Haptics.IVibrationDevice";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Devices_Haptics_IVibrationDeviceStatics = "Windows.Devices.Haptics.IVibrationDeviceStatics";

        [NativeTypeName("const WCHAR [62]")]
        public const string RuntimeClass_Windows_Devices_Haptics_KnownSimpleHapticsControllerWaveforms = "Windows.Devices.Haptics.KnownSimpleHapticsControllerWaveforms";

        [NativeTypeName("const WCHAR [48]")]
        public const string RuntimeClass_Windows_Devices_Haptics_SimpleHapticsController = "Windows.Devices.Haptics.SimpleHapticsController";

        [NativeTypeName("const WCHAR [56]")]
        public const string RuntimeClass_Windows_Devices_Haptics_SimpleHapticsControllerFeedback = "Windows.Devices.Haptics.SimpleHapticsControllerFeedback";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Devices_Haptics_VibrationDevice = "Windows.Devices.Haptics.VibrationDevice";

        public static readonly Guid IID_IKnownSimpleHapticsControllerWaveformsStatics = new Guid(0x3D577EF7, 0x4CEE, 0x11E6, 0xB5, 0x35, 0x00, 0x1B, 0xDC, 0x06, 0xAB, 0x3B);

        public static readonly Guid IID_ISimpleHapticsController = new Guid(0x3D577EF9, 0x4CEE, 0x11E6, 0xB5, 0x35, 0x00, 0x1B, 0xDC, 0x06, 0xAB, 0x3B);

        public static readonly Guid IID_ISimpleHapticsControllerFeedback = new Guid(0x3D577EF8, 0x4CEE, 0x11E6, 0xB5, 0x35, 0x00, 0x1B, 0xDC, 0x06, 0xAB, 0x3B);

        public static readonly Guid IID_IVibrationDevice = new Guid(0x40F21A3E, 0x8844, 0x47FF, 0xB3, 0x12, 0x06, 0x18, 0x5A, 0x38, 0x44, 0xDA);

        public static readonly Guid IID_IVibrationDeviceStatics = new Guid(0x53E2EDED, 0x2290, 0x4AC9, 0x8E, 0xB3, 0x1A, 0x84, 0x12, 0x2E, 0xB7, 0x1C);
    }
}
