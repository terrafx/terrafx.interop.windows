// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus"]/*' />
public enum DeviceWatcherStatus
{
    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_Created"]/*' />
    DeviceWatcherStatus_Created = 0,

    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_Started"]/*' />
    DeviceWatcherStatus_Started = 1,

    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_EnumerationCompleted"]/*' />
    DeviceWatcherStatus_EnumerationCompleted = 2,

    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_Stopping"]/*' />
    DeviceWatcherStatus_Stopping = 3,

    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_Stopped"]/*' />
    DeviceWatcherStatus_Stopped = 4,

    /// <include file='DeviceWatcherStatus.xml' path='doc/member[@name="DeviceWatcherStatus.DeviceWatcherStatus_Aborted"]/*' />
    DeviceWatcherStatus_Aborted = 5,
}
