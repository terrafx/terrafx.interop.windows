// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioChangePolarity.xml' path='doc/member[@name="GpioChangePolarity"]/*' />
public enum GpioChangePolarity
{
    /// <include file='GpioChangePolarity.xml' path='doc/member[@name="GpioChangePolarity.GpioChangePolarity_Falling"]/*' />
    GpioChangePolarity_Falling = 0,

    /// <include file='GpioChangePolarity.xml' path='doc/member[@name="GpioChangePolarity.GpioChangePolarity_Rising"]/*' />
    GpioChangePolarity_Rising = 1,

    /// <include file='GpioChangePolarity.xml' path='doc/member[@name="GpioChangePolarity.GpioChangePolarity_Both"]/*' />
    GpioChangePolarity_Both = 2,
}
