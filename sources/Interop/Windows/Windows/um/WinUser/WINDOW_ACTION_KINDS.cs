// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS"]/*' />
public enum WINDOW_ACTION_KINDS
{
    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_NONE"]/*' />
    WAK_NONE = 0x0000,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_VISIBILITY"]/*' />
    WAK_VISIBILITY = 0x0001,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_POSITION"]/*' />
    WAK_POSITION = 0x0002,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_SIZE"]/*' />
    WAK_SIZE = 0x0004,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_INSERT_AFTER"]/*' />
    WAK_INSERT_AFTER = 0x0008,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_ACTIVATE"]/*' />
    WAK_ACTIVATE = 0x0010,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_PLACEMENT_STATE"]/*' />
    WAK_PLACEMENT_STATE = 0x0020,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_NORMAL_RECT"]/*' />
    WAK_NORMAL_RECT = 0x0040,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_MOVE_TO_MONITOR"]/*' />
    WAK_MOVE_TO_MONITOR = 0x0080,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_FIT_TO_MONITOR"]/*' />
    WAK_FIT_TO_MONITOR = 0x0100,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_DISPLAY_CHANGE"]/*' />
    WAK_DISPLAY_CHANGE = 0x0200,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_SYSTEM_OPERATION"]/*' />
    WAK_SYSTEM_OPERATION = 0x0400,

    /// <include file='WINDOW_ACTION_KINDS.xml' path='doc/member[@name="WINDOW_ACTION_KINDS.WAK_COALESCEABLE"]/*' />
    WAK_COALESCEABLE = WAK_POSITION | WAK_SIZE | WAK_ACTIVATE | WAK_VISIBILITY | WAK_INSERT_AFTER,
}
