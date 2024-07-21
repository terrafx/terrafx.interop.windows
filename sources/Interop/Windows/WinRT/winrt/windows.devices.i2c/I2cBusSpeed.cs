// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='I2cBusSpeed.xml' path='doc/member[@name="I2cBusSpeed"]/*' />
public enum I2cBusSpeed
{
    /// <include file='I2cBusSpeed.xml' path='doc/member[@name="I2cBusSpeed.I2cBusSpeed_StandardMode"]/*' />
    I2cBusSpeed_StandardMode = 0,

    /// <include file='I2cBusSpeed.xml' path='doc/member[@name="I2cBusSpeed.I2cBusSpeed_FastMode"]/*' />
    I2cBusSpeed_FastMode = 1,
}
