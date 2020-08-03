// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PRIVILEGE_SET
    {
        [NativeTypeName("DWORD")]
        public uint PrivilegeCount;

        [NativeTypeName("DWORD")]
        public uint Control;

        [NativeTypeName("LUID_AND_ATTRIBUTES [1]")]
        public _Privilege_e__FixedBuffer Privilege;

        public partial struct _Privilege_e__FixedBuffer
        {
            public LUID_AND_ATTRIBUTES e0;

            public ref LUID_AND_ATTRIBUTES this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<LUID_AND_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
