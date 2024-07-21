// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason"]/*' />
public enum AdaptiveMediaSourceDownloadBitrateChangedReason
{
    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_SufficientInboundBitsPerSecond"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_SufficientInboundBitsPerSecond = 0,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_InsufficientInboundBitsPerSecond"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_InsufficientInboundBitsPerSecond = 1,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_LowBufferLevel"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_LowBufferLevel = 2,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_PositionChanged"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_PositionChanged = 3,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_TrackSelectionChanged"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_TrackSelectionChanged = 4,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_DesiredBitratesChanged"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_DesiredBitratesChanged = 5,

    /// <include file='AdaptiveMediaSourceDownloadBitrateChangedReason.xml' path='doc/member[@name="AdaptiveMediaSourceDownloadBitrateChangedReason.AdaptiveMediaSourceDownloadBitrateChangedReason_ErrorInPreviousBitrate"]/*' />
    AdaptiveMediaSourceDownloadBitrateChangedReason_ErrorInPreviousBitrate = 6,
}
