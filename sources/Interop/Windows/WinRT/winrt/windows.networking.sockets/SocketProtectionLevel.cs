// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel"]/*' />
public enum SocketProtectionLevel
{
    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_PlainSocket"]/*' />
    SocketProtectionLevel_PlainSocket = 0,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Ssl"]/*' />
    [Obsolete("Ssl may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.")]
    SocketProtectionLevel_Ssl = 1,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_SslAllowNullEncryption"]/*' />
    SocketProtectionLevel_SslAllowNullEncryption = 2,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_BluetoothEncryptionAllowNullAuthentication"]/*' />
    SocketProtectionLevel_BluetoothEncryptionAllowNullAuthentication = 3,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_BluetoothEncryptionWithAuthentication"]/*' />
    SocketProtectionLevel_BluetoothEncryptionWithAuthentication = 4,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Ssl3AllowWeakEncryption"]/*' />
    [Obsolete("Ssl3AllowWeakEncryption may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.")]
    SocketProtectionLevel_Ssl3AllowWeakEncryption = 5,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Tls10"]/*' />
    SocketProtectionLevel_Tls10 = 6,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Tls11"]/*' />
    SocketProtectionLevel_Tls11 = 7,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Tls12"]/*' />
    SocketProtectionLevel_Tls12 = 8,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Unspecified"]/*' />
    SocketProtectionLevel_Unspecified = 9,

    /// <include file='SocketProtectionLevel.xml' path='doc/member[@name="SocketProtectionLevel.SocketProtectionLevel_Tls13"]/*' />
    SocketProtectionLevel_Tls13 = 10,
}
