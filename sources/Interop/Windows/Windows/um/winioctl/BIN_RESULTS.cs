// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct BIN_RESULTS
{
    [NativeTypeName("DWORD")]
    public uint NumberOfBins;

    [NativeTypeName("BIN_COUNT [1]")]
    public _BinCounts_e__FixedBuffer BinCounts;

    public partial struct _BinCounts_e__FixedBuffer
    {
        public BIN_COUNT e0;

        public ref BIN_COUNT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<BIN_COUNT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
