// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus"]/*' />
public enum BluetoothLEAdvertisementPublisherStatus
{
    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Created"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Created = 0,

    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Waiting"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Waiting = 1,

    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Started"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Started = 2,

    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Stopping"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Stopping = 3,

    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Stopped"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Stopped = 4,

    /// <include file='BluetoothLEAdvertisementPublisherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementPublisherStatus.BluetoothLEAdvertisementPublisherStatus_Aborted"]/*' />
    BluetoothLEAdvertisementPublisherStatus_Aborted = 5,
}
