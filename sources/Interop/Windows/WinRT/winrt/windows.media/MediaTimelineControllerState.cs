// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaTimelineControllerState.xml' path='doc/member[@name="MediaTimelineControllerState"]/*' />
public enum MediaTimelineControllerState
{
    /// <include file='MediaTimelineControllerState.xml' path='doc/member[@name="MediaTimelineControllerState.MediaTimelineControllerState_Paused"]/*' />
    MediaTimelineControllerState_Paused = 0,

    /// <include file='MediaTimelineControllerState.xml' path='doc/member[@name="MediaTimelineControllerState.MediaTimelineControllerState_Running"]/*' />
    MediaTimelineControllerState_Running = 1,

    /// <include file='MediaTimelineControllerState.xml' path='doc/member[@name="MediaTimelineControllerState.MediaTimelineControllerState_Stalled"]/*' />
    MediaTimelineControllerState_Stalled = 2,

    /// <include file='MediaTimelineControllerState.xml' path='doc/member[@name="MediaTimelineControllerState.MediaTimelineControllerState_Error"]/*' />
    MediaTimelineControllerState_Error = 3,
}
