// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum UserWatcherStatus
    {
        UserWatcherStatus_Created = 0,
        UserWatcherStatus_Started = 1,
        UserWatcherStatus_EnumerationCompleted = 2,
        UserWatcherStatus_Stopping = 3,
        UserWatcherStatus_Stopped = 4,
        UserWatcherStatus_Aborted = 5,
    }
}
