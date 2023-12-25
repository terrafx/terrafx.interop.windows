// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppWindowClosedReason.xml' path='doc/member[@name="AppWindowClosedReason"]/*' />
public enum AppWindowClosedReason
{
    /// <include file='AppWindowClosedReason.xml' path='doc/member[@name="AppWindowClosedReason.AppWindowClosedReason_Other"]/*' />
    AppWindowClosedReason_Other = 0,

    /// <include file='AppWindowClosedReason.xml' path='doc/member[@name="AppWindowClosedReason.AppWindowClosedReason_AppInitiated"]/*' />
    AppWindowClosedReason_AppInitiated = 1,

    /// <include file='AppWindowClosedReason.xml' path='doc/member[@name="AppWindowClosedReason.AppWindowClosedReason_UserInitiated"]/*' />
    AppWindowClosedReason_UserInitiated = 2,
}
