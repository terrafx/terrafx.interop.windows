// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MOVEREGION_INFO
    {
        [NativeTypeName("UINT")]
        public uint FrameNumber;

        [NativeTypeName("UINT")]
        public uint NumMoveRegions;

        [NativeTypeName("MOVE_RECT [1]")]
        public _MoveRegions_e__FixedBuffer MoveRegions;

        public partial struct _MoveRegions_e__FixedBuffer
        {
            public MOVE_RECT e0;

            public unsafe ref MOVE_RECT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<MOVE_RECT> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<MOVE_RECT>((MOVE_RECT*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
