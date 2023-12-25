// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothConnectionStatus.xml' path='doc/member[@name="BluetoothConnectionStatus"]/*' />
public enum BluetoothConnectionStatus
{
    /// <include file='BluetoothConnectionStatus.xml' path='doc/member[@name="BluetoothConnectionStatus.BluetoothConnectionStatus_Disconnected"]/*' />
    BluetoothConnectionStatus_Disconnected = 0,

    /// <include file='BluetoothConnectionStatus.xml' path='doc/member[@name="BluetoothConnectionStatus.BluetoothConnectionStatus_Connected"]/*' />
    BluetoothConnectionStatus_Connected = 1,
}
