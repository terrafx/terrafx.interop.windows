// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProviderGpioPinValue.xml' path='doc/member[@name="ProviderGpioPinValue"]/*' />
public enum ProviderGpioPinValue
{
    /// <include file='ProviderGpioPinValue.xml' path='doc/member[@name="ProviderGpioPinValue.ProviderGpioPinValue_Low"]/*' />
    ProviderGpioPinValue_Low = 0,

    /// <include file='ProviderGpioPinValue.xml' path='doc/member[@name="ProviderGpioPinValue.ProviderGpioPinValue_High"]/*' />
    ProviderGpioPinValue_High = 1,
}
