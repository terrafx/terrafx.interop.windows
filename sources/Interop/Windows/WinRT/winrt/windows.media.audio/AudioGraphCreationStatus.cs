// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioGraphCreationStatus.xml' path='doc/member[@name="AudioGraphCreationStatus"]/*' />
public enum AudioGraphCreationStatus
{
    /// <include file='AudioGraphCreationStatus.xml' path='doc/member[@name="AudioGraphCreationStatus.AudioGraphCreationStatus_Success"]/*' />
    AudioGraphCreationStatus_Success = 0,

    /// <include file='AudioGraphCreationStatus.xml' path='doc/member[@name="AudioGraphCreationStatus.AudioGraphCreationStatus_DeviceNotAvailable"]/*' />
    AudioGraphCreationStatus_DeviceNotAvailable = 1,

    /// <include file='AudioGraphCreationStatus.xml' path='doc/member[@name="AudioGraphCreationStatus.AudioGraphCreationStatus_FormatNotSupported"]/*' />
    AudioGraphCreationStatus_FormatNotSupported = 2,

    /// <include file='AudioGraphCreationStatus.xml' path='doc/member[@name="AudioGraphCreationStatus.AudioGraphCreationStatus_UnknownFailure"]/*' />
    AudioGraphCreationStatus_UnknownFailure = 3,
}
