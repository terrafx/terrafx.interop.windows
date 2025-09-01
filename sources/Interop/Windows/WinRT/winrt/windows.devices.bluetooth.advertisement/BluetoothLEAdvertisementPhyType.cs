// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEAdvertisementPhyType.xml' path='doc/member[@name="BluetoothLEAdvertisementPhyType"]/*' />
public enum BluetoothLEAdvertisementPhyType
{
    /// <include file='BluetoothLEAdvertisementPhyType.xml' path='doc/member[@name="BluetoothLEAdvertisementPhyType.BluetoothLEAdvertisementPhyType_Unspecified"]/*' />
    BluetoothLEAdvertisementPhyType_Unspecified = 0,

    /// <include file='BluetoothLEAdvertisementPhyType.xml' path='doc/member[@name="BluetoothLEAdvertisementPhyType.BluetoothLEAdvertisementPhyType_Uncoded1MPhy"]/*' />
    BluetoothLEAdvertisementPhyType_Uncoded1MPhy = 1,

    /// <include file='BluetoothLEAdvertisementPhyType.xml' path='doc/member[@name="BluetoothLEAdvertisementPhyType.BluetoothLEAdvertisementPhyType_Uncoded2MPhy"]/*' />
    BluetoothLEAdvertisementPhyType_Uncoded2MPhy = 2,

    /// <include file='BluetoothLEAdvertisementPhyType.xml' path='doc/member[@name="BluetoothLEAdvertisementPhyType.BluetoothLEAdvertisementPhyType_CodedPhy"]/*' />
    BluetoothLEAdvertisementPhyType_CodedPhy = 3,
}
