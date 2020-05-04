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

        [NativeTypeName("_PROCESS_HEAP_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/minwinbase.h:242:5)")]
        public _Anonymous_e__Union1 Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/minwinbase.h:243:9)")]
            public _Anonymous_e__Union2 Block;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/minwinbase.h:247:9)")]
            public _Anonymous_e__Union3 Region;

            public unsafe partial struct _Anonymous_e__Union2
            {
                [NativeTypeName("HANDLE")]
                public IntPtr hMem;

                [NativeTypeName("DWORD [3]")]
                public fixed uint dwReserved[3];
            }

            public unsafe partial struct _Anonymous_e__Union3
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
