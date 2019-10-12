// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RAWMOUSE
    {
        [NativeTypeName("USHORT")]
        public ushort usFlags;

        [NativeTypeName("struct (anonymous struct at um/winuser.h:14528:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONG")]
        public uint ulRawButtons;

        [NativeTypeName("LONG")]
        public int lLastX;

        [NativeTypeName("LONG")]
        public int lLastY;

        [NativeTypeName("ULONG")]
        public uint ulExtraInformation;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulButtons;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/winuser.h:14530:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("USHORT")]
                public ushort usButtonFlags;

                [NativeTypeName("USHORT")]
                public ushort usButtonData;
            }
        }
    }
}
