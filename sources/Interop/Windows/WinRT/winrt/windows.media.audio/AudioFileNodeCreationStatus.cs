// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus"]/*' />
public enum AudioFileNodeCreationStatus
{
    /// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus.AudioFileNodeCreationStatus_Success"]/*' />
    AudioFileNodeCreationStatus_Success = 0,

    /// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus.AudioFileNodeCreationStatus_FileNotFound"]/*' />
    AudioFileNodeCreationStatus_FileNotFound = 1,

    /// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus.AudioFileNodeCreationStatus_InvalidFileType"]/*' />
    AudioFileNodeCreationStatus_InvalidFileType = 2,

    /// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus.AudioFileNodeCreationStatus_FormatNotSupported"]/*' />
    AudioFileNodeCreationStatus_FormatNotSupported = 3,

    /// <include file='AudioFileNodeCreationStatus.xml' path='doc/member[@name="AudioFileNodeCreationStatus.AudioFileNodeCreationStatus_UnknownFailure"]/*' />
    AudioFileNodeCreationStatus_UnknownFailure = 4,
}
