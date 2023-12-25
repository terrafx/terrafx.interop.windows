// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType"]/*' />
public enum NetworkEncryptionType
{
    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_None"]/*' />
    NetworkEncryptionType_None = 0,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Unknown"]/*' />
    NetworkEncryptionType_Unknown = 1,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Wep"]/*' />
    NetworkEncryptionType_Wep = 2,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Wep40"]/*' />
    NetworkEncryptionType_Wep40 = 3,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Wep104"]/*' />
    NetworkEncryptionType_Wep104 = 4,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Tkip"]/*' />
    NetworkEncryptionType_Tkip = 5,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Ccmp"]/*' />
    NetworkEncryptionType_Ccmp = 6,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_WpaUseGroup"]/*' />
    NetworkEncryptionType_WpaUseGroup = 7,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_RsnUseGroup"]/*' />
    NetworkEncryptionType_RsnUseGroup = 8,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Ihv"]/*' />
    NetworkEncryptionType_Ihv = 9,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Gcmp"]/*' />
    NetworkEncryptionType_Gcmp = 10,

    /// <include file='NetworkEncryptionType.xml' path='doc/member[@name="NetworkEncryptionType.NetworkEncryptionType_Gcmp256"]/*' />
    NetworkEncryptionType_Gcmp256 = 11,
}
