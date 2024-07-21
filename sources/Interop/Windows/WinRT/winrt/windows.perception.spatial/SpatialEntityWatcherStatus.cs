// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus"]/*' />
public enum SpatialEntityWatcherStatus
{
    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_Created"]/*' />
    SpatialEntityWatcherStatus_Created = 0,

    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_Started"]/*' />
    SpatialEntityWatcherStatus_Started = 1,

    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_EnumerationCompleted"]/*' />
    SpatialEntityWatcherStatus_EnumerationCompleted = 2,

    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_Stopping"]/*' />
    SpatialEntityWatcherStatus_Stopping = 3,

    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_Stopped"]/*' />
    SpatialEntityWatcherStatus_Stopped = 4,

    /// <include file='SpatialEntityWatcherStatus.xml' path='doc/member[@name="SpatialEntityWatcherStatus.SpatialEntityWatcherStatus_Aborted"]/*' />
    SpatialEntityWatcherStatus_Aborted = 5,
}
