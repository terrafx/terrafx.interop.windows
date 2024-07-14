// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason"]/*' />
public enum SocketActivityTriggerReason
{
    /// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason.SocketActivityTriggerReason_None"]/*' />
    SocketActivityTriggerReason_None = 0,

    /// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason.SocketActivityTriggerReason_SocketActivity"]/*' />
    SocketActivityTriggerReason_SocketActivity = 1,

    /// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason.SocketActivityTriggerReason_ConnectionAccepted"]/*' />
    SocketActivityTriggerReason_ConnectionAccepted = 2,

    /// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason.SocketActivityTriggerReason_KeepAliveTimerExpired"]/*' />
    SocketActivityTriggerReason_KeepAliveTimerExpired = 3,

    /// <include file='SocketActivityTriggerReason.xml' path='doc/member[@name="SocketActivityTriggerReason.SocketActivityTriggerReason_SocketClosed"]/*' />
    SocketActivityTriggerReason_SocketClosed = 4,
}
