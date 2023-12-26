// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattProtectionLevel.xml' path='doc/member[@name="GattProtectionLevel"]/*' />
public enum GattProtectionLevel
{
    /// <include file='GattProtectionLevel.xml' path='doc/member[@name="GattProtectionLevel.GattProtectionLevel_Plain"]/*' />
    GattProtectionLevel_Plain = 0,

    /// <include file='GattProtectionLevel.xml' path='doc/member[@name="GattProtectionLevel.GattProtectionLevel_AuthenticationRequired"]/*' />
    GattProtectionLevel_AuthenticationRequired = 1,

    /// <include file='GattProtectionLevel.xml' path='doc/member[@name="GattProtectionLevel.GattProtectionLevel_EncryptionRequired"]/*' />
    GattProtectionLevel_EncryptionRequired = 2,

    /// <include file='GattProtectionLevel.xml' path='doc/member[@name="GattProtectionLevel.GattProtectionLevel_EncryptionAndAuthenticationRequired"]/*' />
    GattProtectionLevel_EncryptionAndAuthenticationRequired = 3,
}
