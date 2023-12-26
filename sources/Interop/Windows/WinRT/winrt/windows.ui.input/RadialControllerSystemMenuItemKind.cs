// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind"]/*' />
public enum RadialControllerSystemMenuItemKind
{
    /// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind.RadialControllerSystemMenuItemKind_Scroll"]/*' />
    RadialControllerSystemMenuItemKind_Scroll = 0,

    /// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind.RadialControllerSystemMenuItemKind_Zoom"]/*' />
    RadialControllerSystemMenuItemKind_Zoom = 1,

    /// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind.RadialControllerSystemMenuItemKind_UndoRedo"]/*' />
    RadialControllerSystemMenuItemKind_UndoRedo = 2,

    /// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind.RadialControllerSystemMenuItemKind_Volume"]/*' />
    RadialControllerSystemMenuItemKind_Volume = 3,

    /// <include file='RadialControllerSystemMenuItemKind.xml' path='doc/member[@name="RadialControllerSystemMenuItemKind.RadialControllerSystemMenuItemKind_NextPreviousTrack"]/*' />
    RadialControllerSystemMenuItemKind_NextPreviousTrack = 4,
}
