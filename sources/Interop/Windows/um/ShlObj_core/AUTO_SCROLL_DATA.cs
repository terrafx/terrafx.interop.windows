// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct AUTO_SCROLL_DATA
    {
        public int iNextSample;

        [NativeTypeName("DWORD")]
        public uint dwLastScroll;

        public BOOL bFull;

        [NativeTypeName("POINT [3]")]
        public _pts_e__FixedBuffer pts;

        [NativeTypeName("DWORD [3]")]
        public fixed uint dwTimes[3];

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _pts_e__FixedBuffer
        {
            public POINT e0;
            public POINT e1;
            public POINT e2;

            public ref POINT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<POINT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}
