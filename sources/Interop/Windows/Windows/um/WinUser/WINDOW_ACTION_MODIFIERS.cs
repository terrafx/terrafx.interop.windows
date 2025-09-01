// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS"]/*' />
public enum WINDOW_ACTION_MODIFIERS
{
    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_NONE"]/*' />
    WAM_NONE = 0x0000,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_FRAME_BOUNDS"]/*' />
    WAM_FRAME_BOUNDS = 0x0001,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_ACTIVATE_FOREGROUND"]/*' />
    WAM_ACTIVATE_FOREGROUND = 0x0002,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_ACTIVATE_INPUT"]/*' />
    WAM_ACTIVATE_INPUT = 0x0004,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_ACTIVATE_NO_ZORDER"]/*' />
    WAM_ACTIVATE_NO_ZORDER = 0x0008,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_INSERT_AFTER_NO_OWNER"]/*' />
    WAM_INSERT_AFTER_NO_OWNER = 0x0010,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_RESTORE_TO_NORMAL"]/*' />
    WAM_RESTORE_TO_NORMAL = 0x0020,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_RESTORE_TO_MAXIMIZED"]/*' />
    WAM_RESTORE_TO_MAXIMIZED = 0x0040,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_RESTORE_TO_ARRANGED"]/*' />
    WAM_RESTORE_TO_ARRANGED = 0x0080,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_WORK_AREA"]/*' />
    WAM_WORK_AREA = 0x0100,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_DPI"]/*' />
    WAM_DPI = 0x0200,

    /// <include file='WINDOW_ACTION_MODIFIERS.xml' path='doc/member[@name="WINDOW_ACTION_MODIFIERS.WAM_SCALED_TO_MONITOR"]/*' />
    WAM_SCALED_TO_MONITOR = 0x0400,
}
