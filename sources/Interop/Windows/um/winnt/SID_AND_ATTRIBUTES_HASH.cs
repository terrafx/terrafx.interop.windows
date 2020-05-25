// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
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
            internal nuint e0;
            internal nuint e1;
            internal nuint e2;
            internal nuint e3;
            internal nuint e4;
            internal nuint e5;
            internal nuint e6;
            internal nuint e7;
            internal nuint e8;
            internal nuint e9;
            internal nuint e10;
            internal nuint e11;
            internal nuint e12;
            internal nuint e13;
            internal nuint e14;
            internal nuint e15;
            internal nuint e16;
            internal nuint e17;
            internal nuint e18;
            internal nuint e19;
            internal nuint e20;
            internal nuint e21;
            internal nuint e22;
            internal nuint e23;
            internal nuint e24;
            internal nuint e25;
            internal nuint e26;
            internal nuint e27;
            internal nuint e28;
            internal nuint e29;
            internal nuint e30;
            internal nuint e31;

            public ref nuint this[int index] => ref AsSpan()[index];

            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
