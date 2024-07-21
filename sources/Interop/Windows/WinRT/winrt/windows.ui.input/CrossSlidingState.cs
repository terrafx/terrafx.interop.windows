// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState"]/*' />
public enum CrossSlidingState
{
    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_Started"]/*' />
    CrossSlidingState_Started = 0,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_Dragging"]/*' />
    CrossSlidingState_Dragging = 1,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_Selecting"]/*' />
    CrossSlidingState_Selecting = 2,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_SelectSpeedBumping"]/*' />
    CrossSlidingState_SelectSpeedBumping = 3,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_SpeedBumping"]/*' />
    CrossSlidingState_SpeedBumping = 4,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_Rearranging"]/*' />
    CrossSlidingState_Rearranging = 5,

    /// <include file='CrossSlidingState.xml' path='doc/member[@name="CrossSlidingState.CrossSlidingState_Completed"]/*' />
    CrossSlidingState_Completed = 6,
}
