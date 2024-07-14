// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderI2cBusSpeed.xml' path='doc/member[@name="ProviderI2cBusSpeed"]/*' />
public enum ProviderI2cBusSpeed
{
    /// <include file='ProviderI2cBusSpeed.xml' path='doc/member[@name="ProviderI2cBusSpeed.ProviderI2cBusSpeed_StandardMode"]/*' />
    ProviderI2cBusSpeed_StandardMode = 0,

    /// <include file='ProviderI2cBusSpeed.xml' path='doc/member[@name="ProviderI2cBusSpeed.ProviderI2cBusSpeed_FastMode"]/*' />
    ProviderI2cBusSpeed_FastMode = 1,
}
