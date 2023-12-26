// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketMessageType.xml' path='doc/member[@name="SocketMessageType"]/*' />
public enum SocketMessageType
{
    /// <include file='SocketMessageType.xml' path='doc/member[@name="SocketMessageType.SocketMessageType_Binary"]/*' />
    SocketMessageType_Binary = 0,

    /// <include file='SocketMessageType.xml' path='doc/member[@name="SocketMessageType.SocketMessageType_Utf8"]/*' />
    SocketMessageType_Utf8 = 1,
}
