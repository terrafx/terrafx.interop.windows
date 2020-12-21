// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCRUB_PARITY_EXTENT_DATA
    {
        [NativeTypeName("WORD")]
        public ushort Size;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("WORD")]
        public ushort NumberOfParityExtents;

        [NativeTypeName("WORD")]
        public ushort MaximumNumberOfParityExtents;

        [NativeTypeName("SCRUB_PARITY_EXTENT [1]")]
        public _ParityExtents_e__FixedBuffer ParityExtents;

        public partial struct _ParityExtents_e__FixedBuffer
        {
            public SCRUB_PARITY_EXTENT e0;

            public unsafe ref SCRUB_PARITY_EXTENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SCRUB_PARITY_EXTENT> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<SCRUB_PARITY_EXTENT>((SCRUB_PARITY_EXTENT*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
