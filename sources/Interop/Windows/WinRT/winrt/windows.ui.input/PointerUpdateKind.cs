// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind"]/*' />
public enum PointerUpdateKind
{
    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_Other"]/*' />
    PointerUpdateKind_Other = 0,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_LeftButtonPressed"]/*' />
    PointerUpdateKind_LeftButtonPressed = 1,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_LeftButtonReleased"]/*' />
    PointerUpdateKind_LeftButtonReleased = 2,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_RightButtonPressed"]/*' />
    PointerUpdateKind_RightButtonPressed = 3,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_RightButtonReleased"]/*' />
    PointerUpdateKind_RightButtonReleased = 4,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_MiddleButtonPressed"]/*' />
    PointerUpdateKind_MiddleButtonPressed = 5,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_MiddleButtonReleased"]/*' />
    PointerUpdateKind_MiddleButtonReleased = 6,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_XButton1Pressed"]/*' />
    PointerUpdateKind_XButton1Pressed = 7,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_XButton1Released"]/*' />
    PointerUpdateKind_XButton1Released = 8,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_XButton2Pressed"]/*' />
    PointerUpdateKind_XButton2Pressed = 9,

    /// <include file='PointerUpdateKind.xml' path='doc/member[@name="PointerUpdateKind.PointerUpdateKind_XButton2Released"]/*' />
    PointerUpdateKind_XButton2Released = 10,
}
