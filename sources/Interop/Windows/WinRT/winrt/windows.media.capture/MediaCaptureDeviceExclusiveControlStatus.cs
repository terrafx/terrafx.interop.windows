// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCaptureDeviceExclusiveControlStatus.xml' path='doc/member[@name="MediaCaptureDeviceExclusiveControlStatus"]/*' />
public enum MediaCaptureDeviceExclusiveControlStatus
{
    /// <include file='MediaCaptureDeviceExclusiveControlStatus.xml' path='doc/member[@name="MediaCaptureDeviceExclusiveControlStatus.MediaCaptureDeviceExclusiveControlStatus_ExclusiveControlAvailable"]/*' />
    MediaCaptureDeviceExclusiveControlStatus_ExclusiveControlAvailable = 0,

    /// <include file='MediaCaptureDeviceExclusiveControlStatus.xml' path='doc/member[@name="MediaCaptureDeviceExclusiveControlStatus.MediaCaptureDeviceExclusiveControlStatus_SharedReadOnlyAvailable"]/*' />
    MediaCaptureDeviceExclusiveControlStatus_SharedReadOnlyAvailable = 1,
}
