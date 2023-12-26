// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason"]/*' />
public enum BackgroundTaskCancellationReason
{
    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_Abort"]/*' />
    BackgroundTaskCancellationReason_Abort = 0,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_Terminating"]/*' />
    BackgroundTaskCancellationReason_Terminating = 1,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_LoggingOff"]/*' />
    BackgroundTaskCancellationReason_LoggingOff = 2,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_ServicingUpdate"]/*' />
    BackgroundTaskCancellationReason_ServicingUpdate = 3,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_IdleTask"]/*' />
    BackgroundTaskCancellationReason_IdleTask = 4,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_Uninstall"]/*' />
    BackgroundTaskCancellationReason_Uninstall = 5,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_ConditionLoss"]/*' />
    BackgroundTaskCancellationReason_ConditionLoss = 6,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_SystemPolicy"]/*' />
    BackgroundTaskCancellationReason_SystemPolicy = 7,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_QuietHoursEntered"]/*' />
    [Obsolete("QuietHoursEntered is deprecated after Windows 8.1")]
    BackgroundTaskCancellationReason_QuietHoursEntered = 8,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_ExecutionTimeExceeded"]/*' />
    BackgroundTaskCancellationReason_ExecutionTimeExceeded = 9,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_ResourceRevocation"]/*' />
    BackgroundTaskCancellationReason_ResourceRevocation = 10,

    /// <include file='BackgroundTaskCancellationReason.xml' path='doc/member[@name="BackgroundTaskCancellationReason.BackgroundTaskCancellationReason_EnergySaver"]/*' />
    BackgroundTaskCancellationReason_EnergySaver = 11,
}
