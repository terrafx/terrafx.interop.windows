// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINDOW_PLACEMENT_STATE.xml' path='doc/member[@name="WINDOW_PLACEMENT_STATE"]/*' />
public enum WINDOW_PLACEMENT_STATE
{
    /// <include file='WINDOW_PLACEMENT_STATE.xml' path='doc/member[@name="WINDOW_PLACEMENT_STATE.WPS_NORMAL"]/*' />
    WPS_NORMAL = 0,

    /// <include file='WINDOW_PLACEMENT_STATE.xml' path='doc/member[@name="WINDOW_PLACEMENT_STATE.WPS_MAXIMIZED"]/*' />
    WPS_MAXIMIZED = 1,

    /// <include file='WINDOW_PLACEMENT_STATE.xml' path='doc/member[@name="WINDOW_PLACEMENT_STATE.WPS_MINIMIZED"]/*' />
    WPS_MINIMIZED = 2,

    /// <include file='WINDOW_PLACEMENT_STATE.xml' path='doc/member[@name="WINDOW_PLACEMENT_STATE.WPS_ARRANGED"]/*' />
    WPS_ARRANGED = 3,
}
