// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus"]/*' />
public enum RemoteSystemSessionParticipantWatcherStatus
{
    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_Created"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_Created = 0,

    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_Started"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_Started = 1,

    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_EnumerationCompleted"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_EnumerationCompleted = 2,

    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_Stopping"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_Stopping = 3,

    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_Stopped"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_Stopped = 4,

    /// <include file='RemoteSystemSessionParticipantWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionParticipantWatcherStatus.RemoteSystemSessionParticipantWatcherStatus_Aborted"]/*' />
    RemoteSystemSessionParticipantWatcherStatus_Aborted = 5,
}
