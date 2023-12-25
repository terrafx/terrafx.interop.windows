// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus"]/*' />
public enum UserWatcherStatus
{
    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_Created"]/*' />
    UserWatcherStatus_Created = 0,

    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_Started"]/*' />
    UserWatcherStatus_Started = 1,

    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_EnumerationCompleted"]/*' />
    UserWatcherStatus_EnumerationCompleted = 2,

    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_Stopping"]/*' />
    UserWatcherStatus_Stopping = 3,

    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_Stopped"]/*' />
    UserWatcherStatus_Stopped = 4,

    /// <include file='UserWatcherStatus.xml' path='doc/member[@name="UserWatcherStatus.UserWatcherStatus_Aborted"]/*' />
    UserWatcherStatus_Aborted = 5,
}
