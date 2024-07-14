// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderGpioSharingMode.xml' path='doc/member[@name="ProviderGpioSharingMode"]/*' />
public enum ProviderGpioSharingMode
{
    /// <include file='ProviderGpioSharingMode.xml' path='doc/member[@name="ProviderGpioSharingMode.ProviderGpioSharingMode_Exclusive"]/*' />
    ProviderGpioSharingMode_Exclusive = 0,

    /// <include file='ProviderGpioSharingMode.xml' path='doc/member[@name="ProviderGpioSharingMode.ProviderGpioSharingMode_SharedReadOnly"]/*' />
    ProviderGpioSharingMode_SharedReadOnly = 1,
}
