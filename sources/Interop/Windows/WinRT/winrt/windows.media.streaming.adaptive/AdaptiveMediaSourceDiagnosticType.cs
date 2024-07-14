// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType"]/*' />
public enum AdaptiveMediaSourceDiagnosticType
{
    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ManifestUnchangedUponReload"]/*' />
    AdaptiveMediaSourceDiagnosticType_ManifestUnchangedUponReload = 0,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ManifestMismatchUponReload"]/*' />
    AdaptiveMediaSourceDiagnosticType_ManifestMismatchUponReload = 1,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ManifestSignaledEndOfLiveEventUponReload"]/*' />
    AdaptiveMediaSourceDiagnosticType_ManifestSignaledEndOfLiveEventUponReload = 2,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_MediaSegmentSkipped"]/*' />
    AdaptiveMediaSourceDiagnosticType_MediaSegmentSkipped = 3,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ResourceNotFound"]/*' />
    AdaptiveMediaSourceDiagnosticType_ResourceNotFound = 4,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ResourceTimedOut"]/*' />
    AdaptiveMediaSourceDiagnosticType_ResourceTimedOut = 5,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_ResourceParsingError"]/*' />
    AdaptiveMediaSourceDiagnosticType_ResourceParsingError = 6,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_BitrateDisabled"]/*' />
    AdaptiveMediaSourceDiagnosticType_BitrateDisabled = 7,

    /// <include file='AdaptiveMediaSourceDiagnosticType.xml' path='doc/member[@name="AdaptiveMediaSourceDiagnosticType.AdaptiveMediaSourceDiagnosticType_FatalMediaSourceError"]/*' />
    AdaptiveMediaSourceDiagnosticType_FatalMediaSourceError = 8,
}
