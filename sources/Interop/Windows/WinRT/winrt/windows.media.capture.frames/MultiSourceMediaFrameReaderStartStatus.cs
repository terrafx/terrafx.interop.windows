// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus"]/*' />
public enum MultiSourceMediaFrameReaderStartStatus
{
    /// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus.MultiSourceMediaFrameReaderStartStatus_Success"]/*' />
    MultiSourceMediaFrameReaderStartStatus_Success = 0,

    /// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus.MultiSourceMediaFrameReaderStartStatus_NotSupported"]/*' />
    MultiSourceMediaFrameReaderStartStatus_NotSupported = 1,

    /// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus.MultiSourceMediaFrameReaderStartStatus_InsufficientResources"]/*' />
    MultiSourceMediaFrameReaderStartStatus_InsufficientResources = 2,

    /// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus.MultiSourceMediaFrameReaderStartStatus_DeviceNotAvailable"]/*' />
    MultiSourceMediaFrameReaderStartStatus_DeviceNotAvailable = 3,

    /// <include file='MultiSourceMediaFrameReaderStartStatus.xml' path='doc/member[@name="MultiSourceMediaFrameReaderStartStatus.MultiSourceMediaFrameReaderStartStatus_UnknownFailure"]/*' />
    MultiSourceMediaFrameReaderStartStatus_UnknownFailure = 4,
}
