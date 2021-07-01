// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DRIVE_LAYOUT_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint PartitionCount;

        [NativeTypeName("DWORD")]
        public uint Signature;

        [NativeTypeName("PARTITION_INFORMATION [1]")]
        public _PartitionEntry_e__FixedBuffer PartitionEntry;

        public partial struct _PartitionEntry_e__FixedBuffer
        {
            public PARTITION_INFORMATION e0;

            public ref PARTITION_INFORMATION this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PARTITION_INFORMATION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
