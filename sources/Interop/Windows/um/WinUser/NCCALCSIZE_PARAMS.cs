// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct NCCALCSIZE_PARAMS
    {
        [NativeTypeName("RECT [3]")]
        public _rgrc_e__FixedBuffer rgrc;

        [NativeTypeName("PWINDOWPOS")]
        public WINDOWPOS* lppos;

        public partial struct _rgrc_e__FixedBuffer
        {
            public RECT e0;
            public RECT e1;
            public RECT e2;

            public unsafe ref RECT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<RECT> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 3);
#else
                return new Span<RECT>((RECT*)Unsafe.AsPointer(ref this), 3);
#endif
            }
        }
    }
}
