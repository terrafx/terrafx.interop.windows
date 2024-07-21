// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='GpioChangeRecord.xml' path='doc/member[@name="GpioChangeRecord"]/*' />
public partial struct GpioChangeRecord
{
    /// <include file='GpioChangeRecord.xml' path='doc/member[@name="GpioChangeRecord.RelativeTime"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan RelativeTime;

    /// <include file='GpioChangeRecord.xml' path='doc/member[@name="GpioChangeRecord.Edge"]/*' />
    [NativeTypeName("ABI::Windows::Devices::Gpio::GpioPinEdge")]
    public GpioPinEdge Edge;
}
