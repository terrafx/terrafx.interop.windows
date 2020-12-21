// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PERF_BIN
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfBins;

        [NativeTypeName("DWORD")]
        public uint TypeOfBin;

        [NativeTypeName("BIN_RANGE [1]")]
        public _BinsRanges_e__FixedBuffer BinsRanges;

        public partial struct _BinsRanges_e__FixedBuffer
        {
            public BIN_RANGE e0;

            public unsafe ref BIN_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<BIN_RANGE> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<BIN_RANGE>((BIN_RANGE*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
