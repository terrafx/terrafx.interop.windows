// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpiMode.xml' path='doc/member[@name="SpiMode"]/*' />
public enum SpiMode
{
    /// <include file='SpiMode.xml' path='doc/member[@name="SpiMode.SpiMode_Mode0"]/*' />
    SpiMode_Mode0 = 0,

    /// <include file='SpiMode.xml' path='doc/member[@name="SpiMode.SpiMode_Mode1"]/*' />
    SpiMode_Mode1 = 1,

    /// <include file='SpiMode.xml' path='doc/member[@name="SpiMode.SpiMode_Mode2"]/*' />
    SpiMode_Mode2 = 2,

    /// <include file='SpiMode.xml' path='doc/member[@name="SpiMode.SpiMode_Mode3"]/*' />
    SpiMode_Mode3 = 3,
}
