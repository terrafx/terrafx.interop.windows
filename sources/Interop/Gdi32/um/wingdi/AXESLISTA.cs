// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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
            internal AXISINFOA e0;
            internal AXISINFOA e1;
            internal AXISINFOA e2;
            internal AXISINFOA e3;
            internal AXISINFOA e4;
            internal AXISINFOA e5;
            internal AXISINFOA e6;
            internal AXISINFOA e7;
            internal AXISINFOA e8;
            internal AXISINFOA e9;
            internal AXISINFOA e10;
            internal AXISINFOA e11;
            internal AXISINFOA e12;
            internal AXISINFOA e13;
            internal AXISINFOA e14;
            internal AXISINFOA e15;

            public ref AXISINFOA this[int index] => ref AsSpan()[index];

            public Span<AXISINFOA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
