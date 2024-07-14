// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketSslErrorSeverity.xml' path='doc/member[@name="SocketSslErrorSeverity"]/*' />
public enum SocketSslErrorSeverity
{
    /// <include file='SocketSslErrorSeverity.xml' path='doc/member[@name="SocketSslErrorSeverity.SocketSslErrorSeverity_None"]/*' />
    SocketSslErrorSeverity_None = 0,

    /// <include file='SocketSslErrorSeverity.xml' path='doc/member[@name="SocketSslErrorSeverity.SocketSslErrorSeverity_Ignorable"]/*' />
    SocketSslErrorSeverity_Ignorable = 1,

    /// <include file='SocketSslErrorSeverity.xml' path='doc/member[@name="SocketSslErrorSeverity.SocketSslErrorSeverity_Fatal"]/*' />
    SocketSslErrorSeverity_Fatal = 2,
}
