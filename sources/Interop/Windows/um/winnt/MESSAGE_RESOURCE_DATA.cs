// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MESSAGE_RESOURCE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfBlocks;

        [NativeTypeName("MESSAGE_RESOURCE_BLOCK [1]")]
        public _Blocks_e__FixedBuffer Blocks;

        public partial struct _Blocks_e__FixedBuffer
        {
            public MESSAGE_RESOURCE_BLOCK e0;

            public ref MESSAGE_RESOURCE_BLOCK this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MESSAGE_RESOURCE_BLOCK> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
