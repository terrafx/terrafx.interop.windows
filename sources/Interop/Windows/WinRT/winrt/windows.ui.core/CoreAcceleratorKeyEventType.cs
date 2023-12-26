// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType"]/*' />
public enum CoreAcceleratorKeyEventType
{
    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_Character"]/*' />
    CoreAcceleratorKeyEventType_Character = 2,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_DeadCharacter"]/*' />
    CoreAcceleratorKeyEventType_DeadCharacter = 3,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_KeyDown"]/*' />
    CoreAcceleratorKeyEventType_KeyDown = 0,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_KeyUp"]/*' />
    CoreAcceleratorKeyEventType_KeyUp = 1,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_SystemCharacter"]/*' />
    CoreAcceleratorKeyEventType_SystemCharacter = 6,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_SystemDeadCharacter"]/*' />
    CoreAcceleratorKeyEventType_SystemDeadCharacter = 7,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_SystemKeyDown"]/*' />
    CoreAcceleratorKeyEventType_SystemKeyDown = 4,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_SystemKeyUp"]/*' />
    CoreAcceleratorKeyEventType_SystemKeyUp = 5,

    /// <include file='CoreAcceleratorKeyEventType.xml' path='doc/member[@name="CoreAcceleratorKeyEventType.CoreAcceleratorKeyEventType_UnicodeCharacter"]/*' />
    CoreAcceleratorKeyEventType_UnicodeCharacter = 8,
}
