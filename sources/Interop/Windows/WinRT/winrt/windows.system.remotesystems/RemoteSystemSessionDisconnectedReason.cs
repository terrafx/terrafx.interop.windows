// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionDisconnectedReason.xml' path='doc/member[@name="RemoteSystemSessionDisconnectedReason"]/*' />
public enum RemoteSystemSessionDisconnectedReason
{
    /// <include file='RemoteSystemSessionDisconnectedReason.xml' path='doc/member[@name="RemoteSystemSessionDisconnectedReason.RemoteSystemSessionDisconnectedReason_SessionUnavailable"]/*' />
    RemoteSystemSessionDisconnectedReason_SessionUnavailable = 0,

    /// <include file='RemoteSystemSessionDisconnectedReason.xml' path='doc/member[@name="RemoteSystemSessionDisconnectedReason.RemoteSystemSessionDisconnectedReason_RemovedByController"]/*' />
    RemoteSystemSessionDisconnectedReason_RemovedByController = 1,

    /// <include file='RemoteSystemSessionDisconnectedReason.xml' path='doc/member[@name="RemoteSystemSessionDisconnectedReason.RemoteSystemSessionDisconnectedReason_SessionClosed"]/*' />
    RemoteSystemSessionDisconnectedReason_SessionClosed = 2,
}
