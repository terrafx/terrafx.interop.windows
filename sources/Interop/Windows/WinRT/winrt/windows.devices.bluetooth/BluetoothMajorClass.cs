// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass"]/*' />
public enum BluetoothMajorClass
{
    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Miscellaneous"]/*' />
    BluetoothMajorClass_Miscellaneous = 0,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Computer"]/*' />
    BluetoothMajorClass_Computer = 1,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Phone"]/*' />
    BluetoothMajorClass_Phone = 2,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_NetworkAccessPoint"]/*' />
    BluetoothMajorClass_NetworkAccessPoint = 3,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_AudioVideo"]/*' />
    BluetoothMajorClass_AudioVideo = 4,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Peripheral"]/*' />
    BluetoothMajorClass_Peripheral = 5,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Imaging"]/*' />
    BluetoothMajorClass_Imaging = 6,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Wearable"]/*' />
    BluetoothMajorClass_Wearable = 7,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Toy"]/*' />
    BluetoothMajorClass_Toy = 8,

    /// <include file='BluetoothMajorClass.xml' path='doc/member[@name="BluetoothMajorClass.BluetoothMajorClass_Health"]/*' />
    BluetoothMajorClass_Health = 9,
}
