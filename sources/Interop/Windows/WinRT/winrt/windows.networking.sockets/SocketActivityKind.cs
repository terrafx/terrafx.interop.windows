// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketActivityKind.xml' path='doc/member[@name="SocketActivityKind"]/*' />
public enum SocketActivityKind
{
    /// <include file='SocketActivityKind.xml' path='doc/member[@name="SocketActivityKind.SocketActivityKind_None"]/*' />
    SocketActivityKind_None = 0,

    /// <include file='SocketActivityKind.xml' path='doc/member[@name="SocketActivityKind.SocketActivityKind_StreamSocketListener"]/*' />
    SocketActivityKind_StreamSocketListener = 1,

    /// <include file='SocketActivityKind.xml' path='doc/member[@name="SocketActivityKind.SocketActivityKind_DatagramSocket"]/*' />
    SocketActivityKind_DatagramSocket = 2,

    /// <include file='SocketActivityKind.xml' path='doc/member[@name="SocketActivityKind.SocketActivityKind_StreamSocket"]/*' />
    SocketActivityKind_StreamSocket = 3,
}
