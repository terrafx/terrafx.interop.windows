// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioPinEdge.xml' path='doc/member[@name="GpioPinEdge"]/*' />
public enum GpioPinEdge
{
    /// <include file='GpioPinEdge.xml' path='doc/member[@name="GpioPinEdge.GpioPinEdge_FallingEdge"]/*' />
    GpioPinEdge_FallingEdge = 0,

    /// <include file='GpioPinEdge.xml' path='doc/member[@name="GpioPinEdge.GpioPinEdge_RisingEdge"]/*' />
    GpioPinEdge_RisingEdge = 1,
}
