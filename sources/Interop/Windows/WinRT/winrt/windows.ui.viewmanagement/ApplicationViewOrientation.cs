// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewOrientation.xml' path='doc/member[@name="ApplicationViewOrientation"]/*' />
public enum ApplicationViewOrientation
{
    /// <include file='ApplicationViewOrientation.xml' path='doc/member[@name="ApplicationViewOrientation.ApplicationViewOrientation_Landscape"]/*' />
    ApplicationViewOrientation_Landscape = 0,

    /// <include file='ApplicationViewOrientation.xml' path='doc/member[@name="ApplicationViewOrientation.ApplicationViewOrientation_Portrait"]/*' />
    ApplicationViewOrientation_Portrait = 1,
}
