// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType"]/*' />
public enum BluetoothLEAdvertisementType
{
    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_ConnectableUndirected"]/*' />
    BluetoothLEAdvertisementType_ConnectableUndirected = 0,

    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_ConnectableDirected"]/*' />
    BluetoothLEAdvertisementType_ConnectableDirected = 1,

    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_ScannableUndirected"]/*' />
    BluetoothLEAdvertisementType_ScannableUndirected = 2,

    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_NonConnectableUndirected"]/*' />
    BluetoothLEAdvertisementType_NonConnectableUndirected = 3,

    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_ScanResponse"]/*' />
    BluetoothLEAdvertisementType_ScanResponse = 4,

    /// <include file='BluetoothLEAdvertisementType.xml' path='doc/member[@name="BluetoothLEAdvertisementType.BluetoothLEAdvertisementType_Extended"]/*' />
    BluetoothLEAdvertisementType_Extended = 5,
}
