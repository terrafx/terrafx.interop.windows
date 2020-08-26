// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TOKEN_GROUPS
    {
        [NativeTypeName("DWORD")]
        public uint GroupCount;

        [NativeTypeName("SID_AND_ATTRIBUTES [1]")]
        public _Groups_e__FixedBuffer Groups;

        public partial struct _Groups_e__FixedBuffer
        {
            public SID_AND_ATTRIBUTES e0;

            public ref SID_AND_ATTRIBUTES this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SID_AND_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
