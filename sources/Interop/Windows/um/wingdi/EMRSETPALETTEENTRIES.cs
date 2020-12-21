// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRSETPALETTEENTRIES
    {
        public EMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPal;

        [NativeTypeName("DWORD")]
        public uint iStart;

        [NativeTypeName("DWORD")]
        public uint cEntries;

        [NativeTypeName("PALETTEENTRY [1]")]
        public _aPalEntries_e__FixedBuffer aPalEntries;

        public partial struct _aPalEntries_e__FixedBuffer
        {
            public PALETTEENTRY e0;

            public unsafe ref PALETTEENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PALETTEENTRY> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<PALETTEENTRY>((PALETTEENTRY*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
