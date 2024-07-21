// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='I2cSharingMode.xml' path='doc/member[@name="I2cSharingMode"]/*' />
public enum I2cSharingMode
{
    /// <include file='I2cSharingMode.xml' path='doc/member[@name="I2cSharingMode.I2cSharingMode_Exclusive"]/*' />
    I2cSharingMode_Exclusive = 0,

    /// <include file='I2cSharingMode.xml' path='doc/member[@name="I2cSharingMode.I2cSharingMode_Shared"]/*' />
    I2cSharingMode_Shared = 1,
}
