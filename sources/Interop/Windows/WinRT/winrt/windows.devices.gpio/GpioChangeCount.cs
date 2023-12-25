// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioChangeCount.xml' path='doc/member[@name="GpioChangeCount"]/*' />
public partial struct GpioChangeCount
{
    /// <include file='GpioChangeCount.xml' path='doc/member[@name="GpioChangeCount.Count"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Count;

    /// <include file='GpioChangeCount.xml' path='doc/member[@name="GpioChangeCount.RelativeTime"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan RelativeTime;
}
