// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus"]/*' />
public enum AdaptiveMediaSourceCreationStatus
{
    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_Success"]/*' />
    AdaptiveMediaSourceCreationStatus_Success = 0,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_ManifestDownloadFailure"]/*' />
    AdaptiveMediaSourceCreationStatus_ManifestDownloadFailure = 1,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_ManifestParseFailure"]/*' />
    AdaptiveMediaSourceCreationStatus_ManifestParseFailure = 2,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_UnsupportedManifestContentType"]/*' />
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestContentType = 3,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_UnsupportedManifestVersion"]/*' />
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestVersion = 4,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_UnsupportedManifestProfile"]/*' />
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestProfile = 5,

    /// <include file='AdaptiveMediaSourceCreationStatus.xml' path='doc/member[@name="AdaptiveMediaSourceCreationStatus.AdaptiveMediaSourceCreationStatus_UnknownFailure"]/*' />
    AdaptiveMediaSourceCreationStatus_UnknownFailure = 6,
}
