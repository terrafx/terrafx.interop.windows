// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FILE_LEVEL_TRIM
    {
        [NativeTypeName("DWORD")]
        public uint Key;

        [NativeTypeName("DWORD")]
        public uint NumRanges;

        [NativeTypeName("FILE_LEVEL_TRIM_RANGE [1]")]
        public _Ranges_e__FixedBuffer Ranges;

        public partial struct _Ranges_e__FixedBuffer
        {
            public FILE_LEVEL_TRIM_RANGE e0;

            public unsafe ref FILE_LEVEL_TRIM_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<FILE_LEVEL_TRIM_RANGE> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<FILE_LEVEL_TRIM_RANGE>((FILE_LEVEL_TRIM_RANGE*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
