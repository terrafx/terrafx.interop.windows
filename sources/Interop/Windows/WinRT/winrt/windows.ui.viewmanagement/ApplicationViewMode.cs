// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewMode.xml' path='doc/member[@name="ApplicationViewMode"]/*' />
public enum ApplicationViewMode
{
    /// <include file='ApplicationViewMode.xml' path='doc/member[@name="ApplicationViewMode.ApplicationViewMode_Default"]/*' />
    ApplicationViewMode_Default = 0,

    /// <include file='ApplicationViewMode.xml' path='doc/member[@name="ApplicationViewMode.ApplicationViewMode_CompactOverlay"]/*' />
    ApplicationViewMode_CompactOverlay = 1,
}
