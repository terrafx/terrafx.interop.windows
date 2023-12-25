// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus"]/*' />
public enum RemoteSystemSessionWatcherStatus
{
    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_Created"]/*' />
    RemoteSystemSessionWatcherStatus_Created = 0,

    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_Started"]/*' />
    RemoteSystemSessionWatcherStatus_Started = 1,

    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_EnumerationCompleted"]/*' />
    RemoteSystemSessionWatcherStatus_EnumerationCompleted = 2,

    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_Stopping"]/*' />
    RemoteSystemSessionWatcherStatus_Stopping = 3,

    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_Stopped"]/*' />
    RemoteSystemSessionWatcherStatus_Stopped = 4,

    /// <include file='RemoteSystemSessionWatcherStatus.xml' path='doc/member[@name="RemoteSystemSessionWatcherStatus.RemoteSystemSessionWatcherStatus_Aborted"]/*' />
    RemoteSystemSessionWatcherStatus_Aborted = 5,
}
