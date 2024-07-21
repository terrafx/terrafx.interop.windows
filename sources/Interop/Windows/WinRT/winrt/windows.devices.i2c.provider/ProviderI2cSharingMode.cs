// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderI2cSharingMode.xml' path='doc/member[@name="ProviderI2cSharingMode"]/*' />
public enum ProviderI2cSharingMode
{
    /// <include file='ProviderI2cSharingMode.xml' path='doc/member[@name="ProviderI2cSharingMode.ProviderI2cSharingMode_Exclusive"]/*' />
    ProviderI2cSharingMode_Exclusive = 0,

    /// <include file='ProviderI2cSharingMode.xml' path='doc/member[@name="ProviderI2cSharingMode.ProviderI2cSharingMode_Shared"]/*' />
    ProviderI2cSharingMode_Shared = 1,
}
