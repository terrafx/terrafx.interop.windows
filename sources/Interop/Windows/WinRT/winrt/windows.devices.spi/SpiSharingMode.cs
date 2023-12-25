// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpiSharingMode.xml' path='doc/member[@name="SpiSharingMode"]/*' />
public enum SpiSharingMode
{
    /// <include file='SpiSharingMode.xml' path='doc/member[@name="SpiSharingMode.SpiSharingMode_Exclusive"]/*' />
    SpiSharingMode_Exclusive = 0,

    /// <include file='SpiSharingMode.xml' path='doc/member[@name="SpiSharingMode.SpiSharingMode_Shared"]/*' />
    SpiSharingMode_Shared = 1,
}
