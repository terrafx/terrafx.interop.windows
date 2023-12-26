// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattWriteOption.xml' path='doc/member[@name="GattWriteOption"]/*' />
public enum GattWriteOption
{
    /// <include file='GattWriteOption.xml' path='doc/member[@name="GattWriteOption.GattWriteOption_WriteWithResponse"]/*' />
    GattWriteOption_WriteWithResponse = 0,

    /// <include file='GattWriteOption.xml' path='doc/member[@name="GattWriteOption.GattWriteOption_WriteWithoutResponse"]/*' />
    GattWriteOption_WriteWithoutResponse = 1,
}
