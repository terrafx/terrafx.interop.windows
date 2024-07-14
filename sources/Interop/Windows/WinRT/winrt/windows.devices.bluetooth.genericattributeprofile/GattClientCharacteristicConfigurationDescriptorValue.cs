// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattClientCharacteristicConfigurationDescriptorValue.xml' path='doc/member[@name="GattClientCharacteristicConfigurationDescriptorValue"]/*' />
public enum GattClientCharacteristicConfigurationDescriptorValue
{
    /// <include file='GattClientCharacteristicConfigurationDescriptorValue.xml' path='doc/member[@name="GattClientCharacteristicConfigurationDescriptorValue.GattClientCharacteristicConfigurationDescriptorValue_None"]/*' />
    GattClientCharacteristicConfigurationDescriptorValue_None = 0,

    /// <include file='GattClientCharacteristicConfigurationDescriptorValue.xml' path='doc/member[@name="GattClientCharacteristicConfigurationDescriptorValue.GattClientCharacteristicConfigurationDescriptorValue_Notify"]/*' />
    GattClientCharacteristicConfigurationDescriptorValue_Notify = 1,

    /// <include file='GattClientCharacteristicConfigurationDescriptorValue.xml' path='doc/member[@name="GattClientCharacteristicConfigurationDescriptorValue.GattClientCharacteristicConfigurationDescriptorValue_Indicate"]/*' />
    GattClientCharacteristicConfigurationDescriptorValue_Indicate = 2,
}
