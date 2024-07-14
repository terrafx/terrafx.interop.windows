// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothCacheMode.xml' path='doc/member[@name="BluetoothCacheMode"]/*' />
public enum BluetoothCacheMode
{
    /// <include file='BluetoothCacheMode.xml' path='doc/member[@name="BluetoothCacheMode.BluetoothCacheMode_Cached"]/*' />
    BluetoothCacheMode_Cached = 0,

    /// <include file='BluetoothCacheMode.xml' path='doc/member[@name="BluetoothCacheMode.BluetoothCacheMode_Uncached"]/*' />
    BluetoothCacheMode_Uncached = 1,
}
