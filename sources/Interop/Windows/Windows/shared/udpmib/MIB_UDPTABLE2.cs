// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct MIB_UDPTABLE2
{
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    [NativeTypeName("MIB_UDPROW2 [1]")]
    public _table_e__FixedBuffer table;

    public partial struct _table_e__FixedBuffer
    {
        public MIB_UDPROW2 e0;

        public ref MIB_UDPROW2 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<MIB_UDPROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
