// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppWindowPresentationKind.xml' path='doc/member[@name="AppWindowPresentationKind"]/*' />
public enum AppWindowPresentationKind
{
    /// <include file='AppWindowPresentationKind.xml' path='doc/member[@name="AppWindowPresentationKind.AppWindowPresentationKind_Default"]/*' />
    AppWindowPresentationKind_Default = 0,

    /// <include file='AppWindowPresentationKind.xml' path='doc/member[@name="AppWindowPresentationKind.AppWindowPresentationKind_CompactOverlay"]/*' />
    AppWindowPresentationKind_CompactOverlay = 1,

    /// <include file='AppWindowPresentationKind.xml' path='doc/member[@name="AppWindowPresentationKind.AppWindowPresentationKind_FullScreen"]/*' />
    AppWindowPresentationKind_FullScreen = 2,
}
