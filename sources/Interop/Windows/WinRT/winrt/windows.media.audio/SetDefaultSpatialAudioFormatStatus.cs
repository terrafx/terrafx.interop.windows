// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus"]/*' />
public enum SetDefaultSpatialAudioFormatStatus
{
    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_Succeeded"]/*' />
    SetDefaultSpatialAudioFormatStatus_Succeeded = 0,

    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_AccessDenied"]/*' />
    SetDefaultSpatialAudioFormatStatus_AccessDenied = 1,

    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_LicenseExpired"]/*' />
    SetDefaultSpatialAudioFormatStatus_LicenseExpired = 2,

    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_LicenseNotValidForAudioEndpoint"]/*' />
    SetDefaultSpatialAudioFormatStatus_LicenseNotValidForAudioEndpoint = 3,

    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_NotSupportedOnAudioEndpoint"]/*' />
    SetDefaultSpatialAudioFormatStatus_NotSupportedOnAudioEndpoint = 4,

    /// <include file='SetDefaultSpatialAudioFormatStatus.xml' path='doc/member[@name="SetDefaultSpatialAudioFormatStatus.SetDefaultSpatialAudioFormatStatus_UnknownError"]/*' />
    SetDefaultSpatialAudioFormatStatus_UnknownError = 5,
}
