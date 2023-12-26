// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus"]/*' />
public enum MediaFrameSourceGetPropertyStatus
{
    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_Success"]/*' />
    MediaFrameSourceGetPropertyStatus_Success = 0,

    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_UnknownFailure"]/*' />
    MediaFrameSourceGetPropertyStatus_UnknownFailure = 1,

    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_NotSupported"]/*' />
    MediaFrameSourceGetPropertyStatus_NotSupported = 2,

    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_DeviceNotAvailable"]/*' />
    MediaFrameSourceGetPropertyStatus_DeviceNotAvailable = 3,

    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_MaxPropertyValueSizeTooSmall"]/*' />
    MediaFrameSourceGetPropertyStatus_MaxPropertyValueSizeTooSmall = 4,

    /// <include file='MediaFrameSourceGetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceGetPropertyStatus.MediaFrameSourceGetPropertyStatus_MaxPropertyValueSizeRequired"]/*' />
    MediaFrameSourceGetPropertyStatus_MaxPropertyValueSizeRequired = 5,
}
