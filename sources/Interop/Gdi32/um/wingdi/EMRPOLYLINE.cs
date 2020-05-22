// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRPOLYLINE
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("POINTL [1]")]
        public _aptl_e__FixedBuffer aptl;

        public partial struct _aptl_e__FixedBuffer
        {
            internal POINTL e0;

            public ref POINTL this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
