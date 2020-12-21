// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FILE_REGION_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint TotalRegionEntryCount;

        [NativeTypeName("DWORD")]
        public uint RegionEntryCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("FILE_REGION_INFO [1]")]
        public _Region_e__FixedBuffer Region;

        public partial struct _Region_e__FixedBuffer
        {
            public FILE_REGION_INFO e0;

            public unsafe ref FILE_REGION_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<FILE_REGION_INFO> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<FILE_REGION_INFO>((FILE_REGION_INFO*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
