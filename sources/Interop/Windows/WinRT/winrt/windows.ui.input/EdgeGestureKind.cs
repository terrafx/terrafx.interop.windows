// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EdgeGestureKind.xml' path='doc/member[@name="EdgeGestureKind"]/*' />
public enum EdgeGestureKind
{
    /// <include file='EdgeGestureKind.xml' path='doc/member[@name="EdgeGestureKind.EdgeGestureKind_Touch"]/*' />
    EdgeGestureKind_Touch = 0,

    /// <include file='EdgeGestureKind.xml' path='doc/member[@name="EdgeGestureKind.EdgeGestureKind_Keyboard"]/*' />
    EdgeGestureKind_Keyboard = 1,

    /// <include file='EdgeGestureKind.xml' path='doc/member[@name="EdgeGestureKind.EdgeGestureKind_Mouse"]/*' />
    EdgeGestureKind_Mouse = 2,
}
