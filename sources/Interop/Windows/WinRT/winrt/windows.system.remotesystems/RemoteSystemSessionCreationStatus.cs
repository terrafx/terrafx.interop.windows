// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionCreationStatus.xml' path='doc/member[@name="RemoteSystemSessionCreationStatus"]/*' />
public enum RemoteSystemSessionCreationStatus
{
    /// <include file='RemoteSystemSessionCreationStatus.xml' path='doc/member[@name="RemoteSystemSessionCreationStatus.RemoteSystemSessionCreationStatus_Success"]/*' />
    RemoteSystemSessionCreationStatus_Success = 0,

    /// <include file='RemoteSystemSessionCreationStatus.xml' path='doc/member[@name="RemoteSystemSessionCreationStatus.RemoteSystemSessionCreationStatus_SessionLimitsExceeded"]/*' />
    RemoteSystemSessionCreationStatus_SessionLimitsExceeded = 1,

    /// <include file='RemoteSystemSessionCreationStatus.xml' path='doc/member[@name="RemoteSystemSessionCreationStatus.RemoteSystemSessionCreationStatus_OperationAborted"]/*' />
    RemoteSystemSessionCreationStatus_OperationAborted = 2,
}
