// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TTPOLYCURVE
    {
        [NativeTypeName("WORD")]
        public ushort wType;

        [NativeTypeName("WORD")]
        public ushort cpfx;

        [NativeTypeName("POINTFX [1]")]
        public _apfx_e__FixedBuffer apfx;

        public partial struct _apfx_e__FixedBuffer
        {
            internal POINTFX e0;

            public ref POINTFX this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<POINTFX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
