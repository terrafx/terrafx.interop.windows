// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile"]/*' />
public enum KnownVideoProfile
{
    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_VideoRecording"]/*' />
    KnownVideoProfile_VideoRecording = 0,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_HighQualityPhoto"]/*' />
    KnownVideoProfile_HighQualityPhoto = 1,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_BalancedVideoAndPhoto"]/*' />
    KnownVideoProfile_BalancedVideoAndPhoto = 2,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_VideoConferencing"]/*' />
    KnownVideoProfile_VideoConferencing = 3,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_PhotoSequence"]/*' />
    KnownVideoProfile_PhotoSequence = 4,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_HighFrameRate"]/*' />
    KnownVideoProfile_HighFrameRate = 5,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_VariablePhotoSequence"]/*' />
    KnownVideoProfile_VariablePhotoSequence = 6,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_HdrWithWcgVideo"]/*' />
    KnownVideoProfile_HdrWithWcgVideo = 7,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_HdrWithWcgPhoto"]/*' />
    KnownVideoProfile_HdrWithWcgPhoto = 8,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_VideoHdr8"]/*' />
    KnownVideoProfile_VideoHdr8 = 9,

    /// <include file='KnownVideoProfile.xml' path='doc/member[@name="KnownVideoProfile.KnownVideoProfile_CompressedCamera"]/*' />
    KnownVideoProfile_CompressedCamera = 10,
}
