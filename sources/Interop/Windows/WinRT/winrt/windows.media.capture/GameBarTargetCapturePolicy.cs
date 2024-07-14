// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy"]/*' />
public enum GameBarTargetCapturePolicy
{
    /// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy.GameBarTargetCapturePolicy_EnabledBySystem"]/*' />
    GameBarTargetCapturePolicy_EnabledBySystem = 0,

    /// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy.GameBarTargetCapturePolicy_EnabledByUser"]/*' />
    GameBarTargetCapturePolicy_EnabledByUser = 1,

    /// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy.GameBarTargetCapturePolicy_NotEnabled"]/*' />
    GameBarTargetCapturePolicy_NotEnabled = 2,

    /// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy.GameBarTargetCapturePolicy_ProhibitedBySystem"]/*' />
    GameBarTargetCapturePolicy_ProhibitedBySystem = 3,

    /// <include file='GameBarTargetCapturePolicy.xml' path='doc/member[@name="GameBarTargetCapturePolicy.GameBarTargetCapturePolicy_ProhibitedByPublisher"]/*' />
    GameBarTargetCapturePolicy_ProhibitedByPublisher = 4,
}
