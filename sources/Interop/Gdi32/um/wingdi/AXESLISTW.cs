// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct AXESLISTW
    {
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        [NativeTypeName("AXISINFOW [16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            internal AXISINFOW e0;
            internal AXISINFOW e1;
            internal AXISINFOW e2;
            internal AXISINFOW e3;
            internal AXISINFOW e4;
            internal AXISINFOW e5;
            internal AXISINFOW e6;
            internal AXISINFOW e7;
            internal AXISINFOW e8;
            internal AXISINFOW e9;
            internal AXISINFOW e10;
            internal AXISINFOW e11;
            internal AXISINFOW e12;
            internal AXISINFOW e13;
            internal AXISINFOW e14;
            internal AXISINFOW e15;

            public ref AXISINFOW this[int index] => ref AsSpan()[index];

            public Span<AXISINFOW> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
