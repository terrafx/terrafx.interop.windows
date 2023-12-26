// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='I2cTransferResult.xml' path='doc/member[@name="I2cTransferResult"]/*' />
public partial struct I2cTransferResult
{
    /// <include file='I2cTransferResult.xml' path='doc/member[@name="I2cTransferResult.Status"]/*' />
    [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferStatus")]
    public I2cTransferStatus Status;

    /// <include file='I2cTransferResult.xml' path='doc/member[@name="I2cTransferResult.BytesTransferred"]/*' />
    [NativeTypeName("UINT32")]
    public uint BytesTransferred;
}
