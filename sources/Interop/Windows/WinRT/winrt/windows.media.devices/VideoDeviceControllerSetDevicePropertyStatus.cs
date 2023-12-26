// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus"]/*' />
public enum VideoDeviceControllerSetDevicePropertyStatus
{
    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_Success"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_Success = 0,

    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_UnknownFailure"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_UnknownFailure = 1,

    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_NotSupported"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_NotSupported = 2,

    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_InvalidValue"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_InvalidValue = 3,

    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_DeviceNotAvailable"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_DeviceNotAvailable = 4,

    /// <include file='VideoDeviceControllerSetDevicePropertyStatus.xml' path='doc/member[@name="VideoDeviceControllerSetDevicePropertyStatus.VideoDeviceControllerSetDevicePropertyStatus_NotInControl"]/*' />
    VideoDeviceControllerSetDevicePropertyStatus_NotInControl = 5,
}
