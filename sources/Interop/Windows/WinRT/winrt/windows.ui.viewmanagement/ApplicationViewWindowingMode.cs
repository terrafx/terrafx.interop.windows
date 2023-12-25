// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode"]/*' />
public enum ApplicationViewWindowingMode
{
    /// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode.ApplicationViewWindowingMode_Auto"]/*' />
    ApplicationViewWindowingMode_Auto = 0,

    /// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode.ApplicationViewWindowingMode_PreferredLaunchViewSize"]/*' />
    ApplicationViewWindowingMode_PreferredLaunchViewSize = 1,

    /// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode.ApplicationViewWindowingMode_FullScreen"]/*' />
    ApplicationViewWindowingMode_FullScreen = 2,

    /// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode.ApplicationViewWindowingMode_CompactOverlay"]/*' />
    ApplicationViewWindowingMode_CompactOverlay = 3,

    /// <include file='ApplicationViewWindowingMode.xml' path='doc/member[@name="ApplicationViewWindowingMode.ApplicationViewWindowingMode_Maximized"]/*' />
    ApplicationViewWindowingMode_Maximized = 4,
}
