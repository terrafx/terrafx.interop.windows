// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus"]/*' />
public enum AudioDeviceNodeCreationStatus
{
    /// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus.AudioDeviceNodeCreationStatus_Success"]/*' />
    AudioDeviceNodeCreationStatus_Success = 0,

    /// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus.AudioDeviceNodeCreationStatus_DeviceNotAvailable"]/*' />
    AudioDeviceNodeCreationStatus_DeviceNotAvailable = 1,

    /// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus.AudioDeviceNodeCreationStatus_FormatNotSupported"]/*' />
    AudioDeviceNodeCreationStatus_FormatNotSupported = 2,

    /// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus.AudioDeviceNodeCreationStatus_UnknownFailure"]/*' />
    AudioDeviceNodeCreationStatus_UnknownFailure = 3,

    /// <include file='AudioDeviceNodeCreationStatus.xml' path='doc/member[@name="AudioDeviceNodeCreationStatus.AudioDeviceNodeCreationStatus_AccessDenied"]/*' />
    AudioDeviceNodeCreationStatus_AccessDenied = 4,
}
