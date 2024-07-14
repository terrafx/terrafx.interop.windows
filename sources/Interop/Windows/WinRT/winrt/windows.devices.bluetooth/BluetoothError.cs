// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError"]/*' />
public enum BluetoothError
{
    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_Success"]/*' />
    BluetoothError_Success = 0,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_RadioNotAvailable"]/*' />
    BluetoothError_RadioNotAvailable = 1,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_ResourceInUse"]/*' />
    BluetoothError_ResourceInUse = 2,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_DeviceNotConnected"]/*' />
    BluetoothError_DeviceNotConnected = 3,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_OtherError"]/*' />
    BluetoothError_OtherError = 4,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_DisabledByPolicy"]/*' />
    BluetoothError_DisabledByPolicy = 5,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_NotSupported"]/*' />
    BluetoothError_NotSupported = 6,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_DisabledByUser"]/*' />
    BluetoothError_DisabledByUser = 7,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_ConsentRequired"]/*' />
    BluetoothError_ConsentRequired = 8,

    /// <include file='BluetoothError.xml' path='doc/member[@name="BluetoothError.BluetoothError_TransportNotSupported"]/*' />
    BluetoothError_TransportNotSupported = 9,
}
