// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RAWINPUT
    {
        public RAWINPUTHEADER header;

        [NativeTypeName("union (anonymous union at um/winuser.h:15057:5)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            public RAWMOUSE mouse;

            [FieldOffset(0)]
            public RAWKEYBOARD keyboard;

            [FieldOffset(0)]
            public RAWHID hid;
        }
    }
}
