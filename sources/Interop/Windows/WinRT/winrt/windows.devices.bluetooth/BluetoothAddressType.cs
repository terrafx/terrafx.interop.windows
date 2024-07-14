// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothAddressType.xml' path='doc/member[@name="BluetoothAddressType"]/*' />
public enum BluetoothAddressType
{
    /// <include file='BluetoothAddressType.xml' path='doc/member[@name="BluetoothAddressType.BluetoothAddressType_Public"]/*' />
    BluetoothAddressType_Public = 0,

    /// <include file='BluetoothAddressType.xml' path='doc/member[@name="BluetoothAddressType.BluetoothAddressType_Random"]/*' />
    BluetoothAddressType_Random = 1,

    /// <include file='BluetoothAddressType.xml' path='doc/member[@name="BluetoothAddressType.BluetoothAddressType_Unspecified"]/*' />
    BluetoothAddressType_Unspecified = 2,
}
