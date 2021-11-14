// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct CHAR_INFO
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincontypes.h:144:5)")]
        public _Char_e__Union Char;

        [NativeTypeName("WORD")]
        public ushort Attributes;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Char_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("WCHAR")]
            public ushort UnicodeChar;

            [FieldOffset(0)]
            [NativeTypeName("CHAR")]
            public sbyte AsciiChar;
        }
    }
}
