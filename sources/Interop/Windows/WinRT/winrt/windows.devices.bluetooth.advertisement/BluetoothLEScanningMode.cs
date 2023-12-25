// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEScanningMode.xml' path='doc/member[@name="BluetoothLEScanningMode"]/*' />
public enum BluetoothLEScanningMode
{
    /// <include file='BluetoothLEScanningMode.xml' path='doc/member[@name="BluetoothLEScanningMode.BluetoothLEScanningMode_Passive"]/*' />
    BluetoothLEScanningMode_Passive = 0,

    /// <include file='BluetoothLEScanningMode.xml' path='doc/member[@name="BluetoothLEScanningMode.BluetoothLEScanningMode_Active"]/*' />
    BluetoothLEScanningMode_Active = 1,

    /// <include file='BluetoothLEScanningMode.xml' path='doc/member[@name="BluetoothLEScanningMode.BluetoothLEScanningMode_None"]/*' />
    BluetoothLEScanningMode_None = 2,
}
