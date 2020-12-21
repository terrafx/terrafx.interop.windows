// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DEVICE_DSM_REPORT_ZONES_DATA
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint ZoneCount;

        public STORAGE_ZONES_ATTRIBUTES Attributes;

        [NativeTypeName("DWORD")]
        public uint Reserved0;

        [NativeTypeName("STORAGE_ZONE_DESCRIPTOR [1]")]
        public _ZoneDescriptors_e__FixedBuffer ZoneDescriptors;

        public partial struct _ZoneDescriptors_e__FixedBuffer
        {
            public STORAGE_ZONE_DESCRIPTOR e0;

            public unsafe ref STORAGE_ZONE_DESCRIPTOR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<STORAGE_ZONE_DESCRIPTOR> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<STORAGE_ZONE_DESCRIPTOR>((STORAGE_ZONE_DESCRIPTOR*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
