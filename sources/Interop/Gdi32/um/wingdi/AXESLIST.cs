// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct AXESLIST
    {
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        [NativeTypeName("AXISINFOW [16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            internal AXISINFO e0;
            internal AXISINFO e1;
            internal AXISINFO e2;
            internal AXISINFO e3;
            internal AXISINFO e4;
            internal AXISINFO e5;
            internal AXISINFO e6;
            internal AXISINFO e7;
            internal AXISINFO e8;
            internal AXISINFO e9;
            internal AXISINFO e10;
            internal AXISINFO e11;
            internal AXISINFO e12;
            internal AXISINFO e13;
            internal AXISINFO e14;
            internal AXISINFO e15;

            public ref AXISINFO this[int index] => ref AsSpan()[index];

            public Span<AXISINFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
