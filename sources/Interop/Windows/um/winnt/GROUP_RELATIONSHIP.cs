// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct GROUP_RELATIONSHIP
    {
        [NativeTypeName("WORD")]
        public ushort MaximumGroupCount;

        [NativeTypeName("WORD")]
        public ushort ActiveGroupCount;

        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        [NativeTypeName("PROCESSOR_GROUP_INFO [1]")]
        public _GroupInfo_e__FixedBuffer GroupInfo;

        public partial struct _GroupInfo_e__FixedBuffer
        {
            public PROCESSOR_GROUP_INFO e0;

            public unsafe ref PROCESSOR_GROUP_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PROCESSOR_GROUP_INFO> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<PROCESSOR_GROUP_INFO>((PROCESSOR_GROUP_INFO*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
