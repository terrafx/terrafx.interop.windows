// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEPreferredConnectionParametersRequestStatus.xml' path='doc/member[@name="BluetoothLEPreferredConnectionParametersRequestStatus"]/*' />
public enum BluetoothLEPreferredConnectionParametersRequestStatus
{
    /// <include file='BluetoothLEPreferredConnectionParametersRequestStatus.xml' path='doc/member[@name="BluetoothLEPreferredConnectionParametersRequestStatus.BluetoothLEPreferredConnectionParametersRequestStatus_Unspecified"]/*' />
    BluetoothLEPreferredConnectionParametersRequestStatus_Unspecified = 0,

    /// <include file='BluetoothLEPreferredConnectionParametersRequestStatus.xml' path='doc/member[@name="BluetoothLEPreferredConnectionParametersRequestStatus.BluetoothLEPreferredConnectionParametersRequestStatus_Success"]/*' />
    BluetoothLEPreferredConnectionParametersRequestStatus_Success = 1,

    /// <include file='BluetoothLEPreferredConnectionParametersRequestStatus.xml' path='doc/member[@name="BluetoothLEPreferredConnectionParametersRequestStatus.BluetoothLEPreferredConnectionParametersRequestStatus_DeviceNotAvailable"]/*' />
    BluetoothLEPreferredConnectionParametersRequestStatus_DeviceNotAvailable = 2,

    /// <include file='BluetoothLEPreferredConnectionParametersRequestStatus.xml' path='doc/member[@name="BluetoothLEPreferredConnectionParametersRequestStatus.BluetoothLEPreferredConnectionParametersRequestStatus_AccessDenied"]/*' />
    BluetoothLEPreferredConnectionParametersRequestStatus_AccessDenied = 3,
}
