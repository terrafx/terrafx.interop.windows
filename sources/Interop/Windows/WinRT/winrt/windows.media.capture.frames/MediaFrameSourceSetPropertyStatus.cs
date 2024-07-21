// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus"]/*' />
public enum MediaFrameSourceSetPropertyStatus
{
    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_Success"]/*' />
    MediaFrameSourceSetPropertyStatus_Success = 0,

    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_UnknownFailure"]/*' />
    MediaFrameSourceSetPropertyStatus_UnknownFailure = 1,

    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_NotSupported"]/*' />
    MediaFrameSourceSetPropertyStatus_NotSupported = 2,

    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_InvalidValue"]/*' />
    MediaFrameSourceSetPropertyStatus_InvalidValue = 3,

    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_DeviceNotAvailable"]/*' />
    MediaFrameSourceSetPropertyStatus_DeviceNotAvailable = 4,

    /// <include file='MediaFrameSourceSetPropertyStatus.xml' path='doc/member[@name="MediaFrameSourceSetPropertyStatus.MediaFrameSourceSetPropertyStatus_NotInControl"]/*' />
    MediaFrameSourceSetPropertyStatus_NotInControl = 5,
}
