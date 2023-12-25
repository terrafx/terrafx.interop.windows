// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DevicePickerDisplayStatusOptions.xml' path='doc/member[@name="DevicePickerDisplayStatusOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum DevicePickerDisplayStatusOptions : uint
{
    /// <include file='DevicePickerDisplayStatusOptions.xml' path='doc/member[@name="DevicePickerDisplayStatusOptions.DevicePickerDisplayStatusOptions_None"]/*' />
    DevicePickerDisplayStatusOptions_None = 0,

    /// <include file='DevicePickerDisplayStatusOptions.xml' path='doc/member[@name="DevicePickerDisplayStatusOptions.DevicePickerDisplayStatusOptions_ShowProgress"]/*' />
    DevicePickerDisplayStatusOptions_ShowProgress = 0x1,

    /// <include file='DevicePickerDisplayStatusOptions.xml' path='doc/member[@name="DevicePickerDisplayStatusOptions.DevicePickerDisplayStatusOptions_ShowDisconnectButton"]/*' />
    DevicePickerDisplayStatusOptions_ShowDisconnectButton = 0x2,

    /// <include file='DevicePickerDisplayStatusOptions.xml' path='doc/member[@name="DevicePickerDisplayStatusOptions.DevicePickerDisplayStatusOptions_ShowRetryButton"]/*' />
    DevicePickerDisplayStatusOptions_ShowRetryButton = 0x4,
}
