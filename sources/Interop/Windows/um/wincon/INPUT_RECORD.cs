// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct INPUT_RECORD
    {
        [NativeTypeName("WORD")]
        public ushort EventType;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincontypes.h:124:5)")]
        public _Event_e__Union Event;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Event_e__Union
        {
            [FieldOffset(0)]
            public KEY_EVENT_RECORD KeyEvent;

            [FieldOffset(0)]
            public MOUSE_EVENT_RECORD MouseEvent;

            [FieldOffset(0)]
            public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

            [FieldOffset(0)]
            public MENU_EVENT_RECORD MenuEvent;

            [FieldOffset(0)]
            public FOCUS_EVENT_RECORD FocusEvent;
        }
    }
}
