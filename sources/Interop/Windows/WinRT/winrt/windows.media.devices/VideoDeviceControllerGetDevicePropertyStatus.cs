// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus"]/*' />
public enum VideoDeviceControllerGetDevicePropertyStatus
{
    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_Success"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_Success = 0,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_UnknownFailure"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_UnknownFailure = 1,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_BufferTooSmall"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_BufferTooSmall = 2,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_NotSupported"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_NotSupported = 3,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_DeviceNotAvailable"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_DeviceNotAvailable = 4,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeTooSmall"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeTooSmall = 5,

    /// <include file='VideoDeviceControllerGetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerGetDevicePropertyStatus.VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeRequired"]/*' />
    VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeRequired = 6,
}
