// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderI2cTransferStatus.xml' path='doc/member[@name="ProviderI2cTransferStatus"]/*' />
public enum ProviderI2cTransferStatus
{
    /// <include file='ProviderI2cTransferStatus.xml' path='doc/member[@name="ProviderI2cTransferStatus.ProviderI2cTransferStatus_FullTransfer"]/*' />
    ProviderI2cTransferStatus_FullTransfer = 0,

    /// <include file='ProviderI2cTransferStatus.xml' path='doc/member[@name="ProviderI2cTransferStatus.ProviderI2cTransferStatus_PartialTransfer"]/*' />
    ProviderI2cTransferStatus_PartialTransfer = 1,

    /// <include file='ProviderI2cTransferStatus.xml' path='doc/member[@name="ProviderI2cTransferStatus.ProviderI2cTransferStatus_SlaveAddressNotAcknowledged"]/*' />
    ProviderI2cTransferStatus_SlaveAddressNotAcknowledged = 2,
}
