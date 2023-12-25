// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus"]/*' />
public enum AppResourceGroupInfoWatcherStatus
{
    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_Created"]/*' />
    AppResourceGroupInfoWatcherStatus_Created = 0,

    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_Started"]/*' />
    AppResourceGroupInfoWatcherStatus_Started = 1,

    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_EnumerationCompleted"]/*' />
    AppResourceGroupInfoWatcherStatus_EnumerationCompleted = 2,

    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_Stopping"]/*' />
    AppResourceGroupInfoWatcherStatus_Stopping = 3,

    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_Stopped"]/*' />
    AppResourceGroupInfoWatcherStatus_Stopped = 4,

    /// <include file='AppResourceGroupInfoWatcherStatus.xml' path='doc/member[@name="AppResourceGroupInfoWatcherStatus.AppResourceGroupInfoWatcherStatus_Aborted"]/*' />
    AppResourceGroupInfoWatcherStatus_Aborted = 5,
}
