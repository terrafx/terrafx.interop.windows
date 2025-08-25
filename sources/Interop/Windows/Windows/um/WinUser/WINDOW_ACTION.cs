// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION"]/*' />
public partial struct WINDOW_ACTION
{
    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.kinds"]/*' />
    public WINDOW_ACTION_KINDS kinds;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.modifiers"]/*' />
    public WINDOW_ACTION_MODIFIERS modifiers;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.visible"]/*' />
    public BOOL visible;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.position"]/*' />
    public POINT position;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.size"]/*' />
    public SIZE size;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.insertAfter"]/*' />
    public HWND insertAfter;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.placementState"]/*' />
    public WINDOW_PLACEMENT_STATE placementState;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.normalRect"]/*' />
    public RECT normalRect;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.workArea"]/*' />
    public RECT workArea;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.dpi"]/*' />
    public uint dpi;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.pointOnMonitor"]/*' />
    public POINT pointOnMonitor;

    /// <include file='WINDOW_ACTION.xml' path='doc/member[@name="WINDOW_ACTION.monitorTopologyId"]/*' />
    public uint monitorTopologyId;
}
