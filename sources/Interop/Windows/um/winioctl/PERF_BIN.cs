// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
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

            public ref BIN_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<BIN_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
