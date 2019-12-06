// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESS_HEAP_ENTRY
    {
        [NativeTypeName("PVOID")]
        public void* lpData;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE")]
        public byte cbOverhead;

        [NativeTypeName("BYTE")]
        public byte iRegionIndex;

        [NativeTypeName("WORD")]
        public ushort wFlags;
        [NativeTypeName("PROCESS_HEAP_ENTRY::(anonymous union at um/minwinbase.h:242:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/minwinbase.h:243:9)")]
            public _Block_e__Struct Block;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/minwinbase.h:247:9)")]
            public _Region_e__Struct Region;

            public unsafe partial struct _Block_e__Struct
            {
                [NativeTypeName("HANDLE")]
                public IntPtr hMem;

                [NativeTypeName("DWORD [3]")]
                public fixed uint dwReserved[3];
            }

            public unsafe partial struct _Region_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwCommittedSize;

                [NativeTypeName("DWORD")]
                public uint dwUnCommittedSize;

                [NativeTypeName("LPVOID")]
                public void* lpFirstBlock;

                [NativeTypeName("LPVOID")]
                public void* lpLastBlock;
            }
        }
    }
}
