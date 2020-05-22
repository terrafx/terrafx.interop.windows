// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRPOLYTEXTOUTA
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint iGraphicsMode;

        [NativeTypeName("FLOAT")]
        public float exScale;

        [NativeTypeName("FLOAT")]
        public float eyScale;

        [NativeTypeName("LONG")]
        public int cStrings;

        [NativeTypeName("EMRTEXT [1]")]
        public _aemrtext_e__FixedBuffer aemrtext;

        public partial struct _aemrtext_e__FixedBuffer
        {
            internal EMRTEXT e0;

            public ref EMRTEXT this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<EMRTEXT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
