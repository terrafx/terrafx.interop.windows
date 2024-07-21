// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities"]/*' />
[NativeTypeName("unsigned int")]
public enum BluetoothServiceCapabilities : uint
{
    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_None"]/*' />
    BluetoothServiceCapabilities_None = 0,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_LimitedDiscoverableMode"]/*' />
    BluetoothServiceCapabilities_LimitedDiscoverableMode = 0x1,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_PositioningService"]/*' />
    BluetoothServiceCapabilities_PositioningService = 0x8,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_NetworkingService"]/*' />
    BluetoothServiceCapabilities_NetworkingService = 0x10,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_RenderingService"]/*' />
    BluetoothServiceCapabilities_RenderingService = 0x20,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_CapturingService"]/*' />
    BluetoothServiceCapabilities_CapturingService = 0x40,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_ObjectTransferService"]/*' />
    BluetoothServiceCapabilities_ObjectTransferService = 0x80,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_AudioService"]/*' />
    BluetoothServiceCapabilities_AudioService = 0x100,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_TelephoneService"]/*' />
    BluetoothServiceCapabilities_TelephoneService = 0x200,

    /// <include file='BluetoothServiceCapabilities.xml' path='doc/member[@name="BluetoothServiceCapabilities.BluetoothServiceCapabilities_InformationService"]/*' />
    BluetoothServiceCapabilities_InformationService = 0x400,
}
