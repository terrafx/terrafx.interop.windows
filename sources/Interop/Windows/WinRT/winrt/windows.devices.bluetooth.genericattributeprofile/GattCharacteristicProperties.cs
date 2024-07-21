// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties"]/*' />
[NativeTypeName("unsigned int")]
public enum GattCharacteristicProperties : uint
{
    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_None"]/*' />
    GattCharacteristicProperties_None = 0,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_Broadcast"]/*' />
    GattCharacteristicProperties_Broadcast = 0x1,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_Read"]/*' />
    GattCharacteristicProperties_Read = 0x2,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_WriteWithoutResponse"]/*' />
    GattCharacteristicProperties_WriteWithoutResponse = 0x4,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_Write"]/*' />
    GattCharacteristicProperties_Write = 0x8,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_Notify"]/*' />
    GattCharacteristicProperties_Notify = 0x10,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_Indicate"]/*' />
    GattCharacteristicProperties_Indicate = 0x20,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_AuthenticatedSignedWrites"]/*' />
    GattCharacteristicProperties_AuthenticatedSignedWrites = 0x40,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_ExtendedProperties"]/*' />
    GattCharacteristicProperties_ExtendedProperties = 0x80,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_ReliableWrites"]/*' />
    GattCharacteristicProperties_ReliableWrites = 0x100,

    /// <include file='GattCharacteristicProperties.xml' path='doc/member[@name="GattCharacteristicProperties.GattCharacteristicProperties_WritableAuxiliaries"]/*' />
    GattCharacteristicProperties_WritableAuxiliaries = 0x200,
}
