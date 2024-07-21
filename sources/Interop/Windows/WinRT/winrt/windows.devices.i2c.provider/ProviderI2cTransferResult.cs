// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderI2cTransferResult.xml' path='doc/member[@name="ProviderI2cTransferResult"]/*' />
public partial struct ProviderI2cTransferResult
{
    /// <include file='ProviderI2cTransferResult.xml' path='doc/member[@name="ProviderI2cTransferResult.Status"]/*' />
    [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferStatus")]
    public ProviderI2cTransferStatus Status;

    /// <include file='ProviderI2cTransferResult.xml' path='doc/member[@name="ProviderI2cTransferResult.BytesTransferred"]/*' />
    [NativeTypeName("UINT32")]
    public uint BytesTransferred;
}
