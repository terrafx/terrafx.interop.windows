// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FSCTL_QUERY_REGION_INFO_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("DWORDLONG")]
        public ulong Alignment;

        [NativeTypeName("DWORD")]
        public uint TotalNumberOfRegions;

        [NativeTypeName("DWORD")]
        public uint NumberOfRegionsReturned;

        [NativeTypeName("FILE_STORAGE_TIER_REGION [1]")]
        public _Regions_e__FixedBuffer Regions;

        public partial struct _Regions_e__FixedBuffer
        {
            public FILE_STORAGE_TIER_REGION e0;

            public unsafe ref FILE_STORAGE_TIER_REGION this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<FILE_STORAGE_TIER_REGION> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<FILE_STORAGE_TIER_REGION>((FILE_STORAGE_TIER_REGION*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
