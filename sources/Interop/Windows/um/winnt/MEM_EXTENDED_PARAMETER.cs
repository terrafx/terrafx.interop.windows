// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MEM_EXTENDED_PARAMETER
    {
        [NativeTypeName("MEM_EXTENDED_PARAMETER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:12924:5)")]
        public _Anonymous_e__Union1 Anonymous1;

        [NativeTypeName("MEM_EXTENDED_PARAMETER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:12929:5)")]
        public _Anonymous_e__Union2 Anonymous2;

        public partial struct _Anonymous_e__Union1
        {
            internal ulong _bitfield;

            [NativeTypeName("DWORD64 : 8")]
            public ulong Type
            {
                get
                {
                    return _bitfield & 0xFFUL;
                }

                set
                {
                    _bitfield = (_bitfield & ~0xFFUL) | (value & 0xFFUL);
                }
            }

            [NativeTypeName("DWORD64 : 56")]
            public ulong Reserved
            {
                get
                {
                    return (_bitfield >> 8) & 0xFFFFFFUL;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFFFUL << 8)) | ((value & 0xFFFFFFUL) << 8);
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union2
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong ULong64;

            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* Pointer;

            [FieldOffset(0)]
            [NativeTypeName("SIZE_T")]
            public UIntPtr Size;

            [FieldOffset(0)]
            [NativeTypeName("HANDLE")]
            public IntPtr Handle;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ULong;
        }
    }
}
