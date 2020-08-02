// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
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
            public AXISINFOW e0;
            public AXISINFOW e1;
            public AXISINFOW e2;
            public AXISINFOW e3;
            public AXISINFOW e4;
            public AXISINFOW e5;
            public AXISINFOW e6;
            public AXISINFOW e7;
            public AXISINFOW e8;
            public AXISINFOW e9;
            public AXISINFOW e10;
            public AXISINFOW e11;
            public AXISINFOW e12;
            public AXISINFOW e13;
            public AXISINFOW e14;
            public AXISINFOW e15;

            public ref AXISINFOW this[int index] => ref AsSpan()[index];

            public Span<AXISINFOW> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
