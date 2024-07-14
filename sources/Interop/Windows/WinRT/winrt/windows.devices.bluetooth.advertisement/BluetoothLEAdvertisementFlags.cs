// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags"]/*' />
[NativeTypeName("unsigned int")]
public enum BluetoothLEAdvertisementFlags : uint
{
    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_None"]/*' />
    BluetoothLEAdvertisementFlags_None = 0,

    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_LimitedDiscoverableMode"]/*' />
    BluetoothLEAdvertisementFlags_LimitedDiscoverableMode = 0x1,

    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_GeneralDiscoverableMode"]/*' />
    BluetoothLEAdvertisementFlags_GeneralDiscoverableMode = 0x2,

    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_ClassicNotSupported"]/*' />
    BluetoothLEAdvertisementFlags_ClassicNotSupported = 0x4,

    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_DualModeControllerCapable"]/*' />
    BluetoothLEAdvertisementFlags_DualModeControllerCapable = 0x8,

    /// <include file='BluetoothLEAdvertisementFlags.xml' path='doc/member[@name="BluetoothLEAdvertisementFlags.BluetoothLEAdvertisementFlags_DualModeHostCapable"]/*' />
    BluetoothLEAdvertisementFlags_DualModeHostCapable = 0x10,
}
