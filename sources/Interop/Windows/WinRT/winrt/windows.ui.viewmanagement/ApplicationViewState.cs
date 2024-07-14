// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewState.xml' path='doc/member[@name="ApplicationViewState"]/*' />
[Obsolete("ApplicationViewState may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.")]
public enum ApplicationViewState
{
    /// <include file='ApplicationViewState.xml' path='doc/member[@name="ApplicationViewState.ApplicationViewState_FullScreenLandscape"]/*' />
    ApplicationViewState_FullScreenLandscape = 0,

    /// <include file='ApplicationViewState.xml' path='doc/member[@name="ApplicationViewState.ApplicationViewState_Filled"]/*' />
    ApplicationViewState_Filled = 1,

    /// <include file='ApplicationViewState.xml' path='doc/member[@name="ApplicationViewState.ApplicationViewState_Snapped"]/*' />
    ApplicationViewState_Snapped = 2,

    /// <include file='ApplicationViewState.xml' path='doc/member[@name="ApplicationViewState.ApplicationViewState_FullScreenPortrait"]/*' />
    ApplicationViewState_FullScreenPortrait = 3,
}
