// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct EMRPOLYPOLYLINE16
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nPolys;

        [NativeTypeName("DWORD")]
        public uint cpts;

        [NativeTypeName("DWORD [1]")]
        public fixed uint aPolyCounts[1];

        [NativeTypeName("POINTS [1]")]
        public _apts_e__FixedBuffer apts;

        public partial struct _apts_e__FixedBuffer
        {
            internal POINTS e0;

            public ref POINTS this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<POINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
