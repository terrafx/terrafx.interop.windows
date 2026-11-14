// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction"]/*' />
public enum TouchpadGlobalAction
{
    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_ThreeFingerTap"]/*' />
    TouchpadGlobalAction_ThreeFingerTap = 0,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FourFingerTap"]/*' />
    TouchpadGlobalAction_FourFingerTap = 1,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FiveFingerTap"]/*' />
    TouchpadGlobalAction_FiveFingerTap = 2,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_ThreeFingerPress"]/*' />
    TouchpadGlobalAction_ThreeFingerPress = 3,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FourFingerPress"]/*' />
    TouchpadGlobalAction_FourFingerPress = 4,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FiveFingerPress"]/*' />
    TouchpadGlobalAction_FiveFingerPress = 5,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_ThreeFingerRelease"]/*' />
    TouchpadGlobalAction_ThreeFingerRelease = 6,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FourFingerRelease"]/*' />
    TouchpadGlobalAction_FourFingerRelease = 7,

    /// <include file='TouchpadGlobalAction.xml' path='doc/member[@name="TouchpadGlobalAction.TouchpadGlobalAction_FiveFingerRelease"]/*' />
    TouchpadGlobalAction_FiveFingerRelease = 8,
}
