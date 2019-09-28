// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct INPUT
    {
        [NativeTypeName("DWORD")]
        public uint type;

        [NativeTypeName("struct (anonymous struct at um/winuser.h:5980:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("MOUSEINPUT")]
            public MOUSEINPUT mi;

            [FieldOffset(0)]
            [NativeTypeName("KEYBDINPUT")]
            public KEYBDINPUT ki;

            [FieldOffset(0)]
            [NativeTypeName("HARDWAREINPUT")]
            public HARDWAREINPUT hi;
        }
    }
}
