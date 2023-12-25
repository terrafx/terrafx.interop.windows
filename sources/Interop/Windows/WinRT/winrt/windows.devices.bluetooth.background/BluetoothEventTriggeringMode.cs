// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothEventTriggeringMode.xml' path='doc/member[@name="BluetoothEventTriggeringMode"]/*' />
public enum BluetoothEventTriggeringMode
{
    /// <include file='BluetoothEventTriggeringMode.xml' path='doc/member[@name="BluetoothEventTriggeringMode.BluetoothEventTriggeringMode_Serial"]/*' />
    BluetoothEventTriggeringMode_Serial = 0,

    /// <include file='BluetoothEventTriggeringMode.xml' path='doc/member[@name="BluetoothEventTriggeringMode.BluetoothEventTriggeringMode_Batch"]/*' />
    BluetoothEventTriggeringMode_Batch = 1,

    /// <include file='BluetoothEventTriggeringMode.xml' path='doc/member[@name="BluetoothEventTriggeringMode.BluetoothEventTriggeringMode_KeepLatest"]/*' />
    BluetoothEventTriggeringMode_KeepLatest = 2,
}
