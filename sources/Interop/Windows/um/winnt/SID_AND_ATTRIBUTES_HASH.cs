// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SID_AND_ATTRIBUTES_HASH
    {
        [NativeTypeName("DWORD")]
        public uint SidCount;

        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* SidAttr;

        [NativeTypeName("SID_HASH_ENTRY [32]")]
        public _Hash_e__FixedBuffer Hash;

        public partial struct _Hash_e__FixedBuffer
        {
            internal UIntPtr e0;
            internal UIntPtr e1;
            internal UIntPtr e2;
            internal UIntPtr e3;
            internal UIntPtr e4;
            internal UIntPtr e5;
            internal UIntPtr e6;
            internal UIntPtr e7;
            internal UIntPtr e8;
            internal UIntPtr e9;
            internal UIntPtr e10;
            internal UIntPtr e11;
            internal UIntPtr e12;
            internal UIntPtr e13;
            internal UIntPtr e14;
            internal UIntPtr e15;
            internal UIntPtr e16;
            internal UIntPtr e17;
            internal UIntPtr e18;
            internal UIntPtr e19;
            internal UIntPtr e20;
            internal UIntPtr e21;
            internal UIntPtr e22;
            internal UIntPtr e23;
            internal UIntPtr e24;
            internal UIntPtr e25;
            internal UIntPtr e26;
            internal UIntPtr e27;
            internal UIntPtr e28;
            internal UIntPtr e29;
            internal UIntPtr e30;
            internal UIntPtr e31;

            public ref UIntPtr this[int index] => ref AsSpan()[index];

            public Span<UIntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
