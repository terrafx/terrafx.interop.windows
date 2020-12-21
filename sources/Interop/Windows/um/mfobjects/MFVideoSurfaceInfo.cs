// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MFVideoSurfaceInfo
    {
        [NativeTypeName("DWORD")]
        public uint Format;

        [NativeTypeName("DWORD")]
        public uint PaletteEntries;

        [NativeTypeName("MFPaletteEntry [1]")]
        public _Palette_e__FixedBuffer Palette;

        public partial struct _Palette_e__FixedBuffer
        {
            public MFPaletteEntry e0;

            public unsafe ref MFPaletteEntry this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<MFPaletteEntry> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<MFPaletteEntry>((MFPaletteEntry*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
