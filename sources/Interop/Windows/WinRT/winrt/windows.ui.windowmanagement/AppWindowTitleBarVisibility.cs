// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppWindowTitleBarVisibility.xml' path='doc/member[@name="AppWindowTitleBarVisibility"]/*' />
public enum AppWindowTitleBarVisibility
{
    /// <include file='AppWindowTitleBarVisibility.xml' path='doc/member[@name="AppWindowTitleBarVisibility.AppWindowTitleBarVisibility_Default"]/*' />
    AppWindowTitleBarVisibility_Default = 0,

    /// <include file='AppWindowTitleBarVisibility.xml' path='doc/member[@name="AppWindowTitleBarVisibility.AppWindowTitleBarVisibility_AlwaysHidden"]/*' />
    AppWindowTitleBarVisibility_AlwaysHidden = 1,
}
