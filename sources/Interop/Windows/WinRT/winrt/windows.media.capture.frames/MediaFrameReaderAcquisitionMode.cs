// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaFrameReaderAcquisitionMode.xml' path='doc/member[@name="MediaFrameReaderAcquisitionMode"]/*' />
public enum MediaFrameReaderAcquisitionMode
{
    /// <include file='MediaFrameReaderAcquisitionMode.xml' path='doc/member[@name="MediaFrameReaderAcquisitionMode.MediaFrameReaderAcquisitionMode_Realtime"]/*' />
    MediaFrameReaderAcquisitionMode_Realtime = 0,

    /// <include file='MediaFrameReaderAcquisitionMode.xml' path='doc/member[@name="MediaFrameReaderAcquisitionMode.MediaFrameReaderAcquisitionMode_Buffered"]/*' />
    MediaFrameReaderAcquisitionMode_Buffered = 1,
}
