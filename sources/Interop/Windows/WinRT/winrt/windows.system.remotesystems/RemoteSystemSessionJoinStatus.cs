// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus"]/*' />
public enum RemoteSystemSessionJoinStatus
{
    /// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus.RemoteSystemSessionJoinStatus_Success"]/*' />
    RemoteSystemSessionJoinStatus_Success = 0,

    /// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus.RemoteSystemSessionJoinStatus_SessionLimitsExceeded"]/*' />
    RemoteSystemSessionJoinStatus_SessionLimitsExceeded = 1,

    /// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus.RemoteSystemSessionJoinStatus_OperationAborted"]/*' />
    RemoteSystemSessionJoinStatus_OperationAborted = 2,

    /// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus.RemoteSystemSessionJoinStatus_SessionUnavailable"]/*' />
    RemoteSystemSessionJoinStatus_SessionUnavailable = 3,

    /// <include file='RemoteSystemSessionJoinStatus.xml' path='doc/member[@name="RemoteSystemSessionJoinStatus.RemoteSystemSessionJoinStatus_RejectedByController"]/*' />
    RemoteSystemSessionJoinStatus_RejectedByController = 4,
}
