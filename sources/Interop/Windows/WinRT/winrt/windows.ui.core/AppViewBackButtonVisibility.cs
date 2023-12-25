// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppViewBackButtonVisibility.xml' path='doc/member[@name="AppViewBackButtonVisibility"]/*' />
public enum AppViewBackButtonVisibility
{
    /// <include file='AppViewBackButtonVisibility.xml' path='doc/member[@name="AppViewBackButtonVisibility.AppViewBackButtonVisibility_Visible"]/*' />
    AppViewBackButtonVisibility_Visible = 0,

    /// <include file='AppViewBackButtonVisibility.xml' path='doc/member[@name="AppViewBackButtonVisibility.AppViewBackButtonVisibility_Collapsed"]/*' />
    AppViewBackButtonVisibility_Collapsed = 1,

    /// <include file='AppViewBackButtonVisibility.xml' path='doc/member[@name="AppViewBackButtonVisibility.AppViewBackButtonVisibility_Disabled"]/*' />
    AppViewBackButtonVisibility_Disabled = 2,
}
