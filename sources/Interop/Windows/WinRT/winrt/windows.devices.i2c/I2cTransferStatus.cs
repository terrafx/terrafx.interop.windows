// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus"]/*' />
public enum I2cTransferStatus
{
    /// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus.I2cTransferStatus_FullTransfer"]/*' />
    I2cTransferStatus_FullTransfer = 0,

    /// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus.I2cTransferStatus_PartialTransfer"]/*' />
    I2cTransferStatus_PartialTransfer = 1,

    /// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus.I2cTransferStatus_SlaveAddressNotAcknowledged"]/*' />
    I2cTransferStatus_SlaveAddressNotAcknowledged = 2,

    /// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus.I2cTransferStatus_ClockStretchTimeout"]/*' />
    I2cTransferStatus_ClockStretchTimeout = 3,

    /// <include file='I2cTransferStatus.xml' path='doc/member[@name="I2cTransferStatus.I2cTransferStatus_UnknownError"]/*' />
    I2cTransferStatus_UnknownError = 4,
}
