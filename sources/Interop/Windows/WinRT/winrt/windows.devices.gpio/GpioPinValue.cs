// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioPinValue.xml' path='doc/member[@name="GpioPinValue"]/*' />
public enum GpioPinValue
{
    /// <include file='GpioPinValue.xml' path='doc/member[@name="GpioPinValue.GpioPinValue_Low"]/*' />
    GpioPinValue_Low = 0,

    /// <include file='GpioPinValue.xml' path='doc/member[@name="GpioPinValue.GpioPinValue_High"]/*' />
    GpioPinValue_High = 1,
}
