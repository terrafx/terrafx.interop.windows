// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds"]/*' />
[NativeTypeName("unsigned int")]
public enum TouchpadGlobalGestureKinds : uint
{
    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_None"]/*' />
    TouchpadGlobalGestureKinds_None = 0,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_ThreeFingerManipulations"]/*' />
    TouchpadGlobalGestureKinds_ThreeFingerManipulations = 0x1,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_FourFingerManipulations"]/*' />
    TouchpadGlobalGestureKinds_FourFingerManipulations = 0x2,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_FiveFingerManipulations"]/*' />
    TouchpadGlobalGestureKinds_FiveFingerManipulations = 0x4,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_ThreeFingerActions"]/*' />
    TouchpadGlobalGestureKinds_ThreeFingerActions = 0x8,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_FourFingerActions"]/*' />
    TouchpadGlobalGestureKinds_FourFingerActions = 0x10,

    /// <include file='TouchpadGlobalGestureKinds.xml' path='doc/member[@name="TouchpadGlobalGestureKinds.TouchpadGlobalGestureKinds_FiveFingerActions"]/*' />
    TouchpadGlobalGestureKinds_FiveFingerActions = 0x20,
}
