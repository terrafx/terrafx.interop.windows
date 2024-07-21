// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus"]/*' />
public enum MediaFrameReaderStartStatus
{
    /// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus.MediaFrameReaderStartStatus_Success"]/*' />
    MediaFrameReaderStartStatus_Success = 0,

    /// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus.MediaFrameReaderStartStatus_UnknownFailure"]/*' />
    MediaFrameReaderStartStatus_UnknownFailure = 1,

    /// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus.MediaFrameReaderStartStatus_DeviceNotAvailable"]/*' />
    MediaFrameReaderStartStatus_DeviceNotAvailable = 2,

    /// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus.MediaFrameReaderStartStatus_OutputFormatNotSupported"]/*' />
    MediaFrameReaderStartStatus_OutputFormatNotSupported = 3,

    /// <include file='MediaFrameReaderStartStatus.xml' path='doc/member[@name="MediaFrameReaderStartStatus.MediaFrameReaderStartStatus_ExclusiveControlNotAvailable"]/*' />
    MediaFrameReaderStartStatus_ExclusiveControlNotAvailable = 4,
}
