// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoStabilizationEffectEnabledChangedReason.xml' path='doc/member[@name="VideoStabilizationEffectEnabledChangedReason"]/*' />
public enum VideoStabilizationEffectEnabledChangedReason
{
    /// <include file='VideoStabilizationEffectEnabledChangedReason.xml' path='doc/member[@name="VideoStabilizationEffectEnabledChangedReason.VideoStabilizationEffectEnabledChangedReason_Programmatic"]/*' />
    VideoStabilizationEffectEnabledChangedReason_Programmatic = 0,

    /// <include file='VideoStabilizationEffectEnabledChangedReason.xml' path='doc/member[@name="VideoStabilizationEffectEnabledChangedReason.VideoStabilizationEffectEnabledChangedReason_PixelRateTooHigh"]/*' />
    VideoStabilizationEffectEnabledChangedReason_PixelRateTooHigh = 1,

    /// <include file='VideoStabilizationEffectEnabledChangedReason.xml' path='doc/member[@name="VideoStabilizationEffectEnabledChangedReason.VideoStabilizationEffectEnabledChangedReason_RunningSlowly"]/*' />
    VideoStabilizationEffectEnabledChangedReason_RunningSlowly = 2,
}
