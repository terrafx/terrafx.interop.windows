// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RadioKind.xml' path='doc/member[@name="RadioKind"]/*' />
public enum RadioKind
{
    /// <include file='RadioKind.xml' path='doc/member[@name="RadioKind.RadioKind_Other"]/*' />
    RadioKind_Other = 0,

    /// <include file='RadioKind.xml' path='doc/member[@name="RadioKind.RadioKind_WiFi"]/*' />
    RadioKind_WiFi = 1,

    /// <include file='RadioKind.xml' path='doc/member[@name="RadioKind.RadioKind_MobileBroadband"]/*' />
    RadioKind_MobileBroadband = 2,

    /// <include file='RadioKind.xml' path='doc/member[@name="RadioKind.RadioKind_Bluetooth"]/*' />
    RadioKind_Bluetooth = 3,

    /// <include file='RadioKind.xml' path='doc/member[@name="RadioKind.RadioKind_FM"]/*' />
    RadioKind_FM = 4,
}
