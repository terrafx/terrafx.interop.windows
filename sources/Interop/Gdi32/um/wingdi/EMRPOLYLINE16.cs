// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRPOLYLINE16
    {
        public EMR emr;

        [NativeTypeName("RECTL")]
        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cpts;

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
