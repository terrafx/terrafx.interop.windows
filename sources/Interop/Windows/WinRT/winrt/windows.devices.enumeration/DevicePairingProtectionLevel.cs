// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DevicePairingProtectionLevel.xml' path='doc/member[@name="DevicePairingProtectionLevel"]/*' />
public enum DevicePairingProtectionLevel
{
    /// <include file='DevicePairingProtectionLevel.xml' path='doc/member[@name="DevicePairingProtectionLevel.DevicePairingProtectionLevel_Default"]/*' />
    DevicePairingProtectionLevel_Default = 0,

    /// <include file='DevicePairingProtectionLevel.xml' path='doc/member[@name="DevicePairingProtectionLevel.DevicePairingProtectionLevel_None"]/*' />
    DevicePairingProtectionLevel_None = 1,

    /// <include file='DevicePairingProtectionLevel.xml' path='doc/member[@name="DevicePairingProtectionLevel.DevicePairingProtectionLevel_Encryption"]/*' />
    DevicePairingProtectionLevel_Encryption = 2,

    /// <include file='DevicePairingProtectionLevel.xml' path='doc/member[@name="DevicePairingProtectionLevel.DevicePairingProtectionLevel_EncryptionAndAuthentication"]/*' />
    DevicePairingProtectionLevel_EncryptionAndAuthentication = 3,
}
