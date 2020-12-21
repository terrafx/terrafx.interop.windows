// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct AXESLISTA
    {
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        [NativeTypeName("AXISINFOA [16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            public AXISINFOA e0;
            public AXISINFOA e1;
            public AXISINFOA e2;
            public AXISINFOA e3;
            public AXISINFOA e4;
            public AXISINFOA e5;
            public AXISINFOA e6;
            public AXISINFOA e7;
            public AXISINFOA e8;
            public AXISINFOA e9;
            public AXISINFOA e10;
            public AXISINFOA e11;
            public AXISINFOA e12;
            public AXISINFOA e13;
            public AXISINFOA e14;
            public AXISINFOA e15;

            public unsafe ref AXISINFOA this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<AXISINFOA> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 16);
#else
                return new Span<AXISINFOA>((AXISINFOA*)Unsafe.AsPointer(ref this), 16);
#endif
            }
        }
    }
}
