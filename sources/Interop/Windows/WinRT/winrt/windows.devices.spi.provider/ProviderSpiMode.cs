// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderSpiMode.xml' path='doc/member[@name="ProviderSpiMode"]/*' />
public enum ProviderSpiMode
{
    /// <include file='ProviderSpiMode.xml' path='doc/member[@name="ProviderSpiMode.ProviderSpiMode_Mode0"]/*' />
    ProviderSpiMode_Mode0 = 0,

    /// <include file='ProviderSpiMode.xml' path='doc/member[@name="ProviderSpiMode.ProviderSpiMode_Mode1"]/*' />
    ProviderSpiMode_Mode1 = 1,

    /// <include file='ProviderSpiMode.xml' path='doc/member[@name="ProviderSpiMode.ProviderSpiMode_Mode2"]/*' />
    ProviderSpiMode_Mode2 = 2,

    /// <include file='ProviderSpiMode.xml' path='doc/member[@name="ProviderSpiMode.ProviderSpiMode_Mode3"]/*' />
    ProviderSpiMode_Mode3 = 3,
}
