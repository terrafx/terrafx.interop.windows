// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct REFS_VOLUME_DATA_BUFFER
    {
        [NativeTypeName("DWORD")]
        public uint ByteCount;

        [NativeTypeName("DWORD")]
        public uint MajorVersion;

        [NativeTypeName("DWORD")]
        public uint MinorVersion;

        [NativeTypeName("DWORD")]
        public uint BytesPerPhysicalSector;

        public LARGE_INTEGER VolumeSerialNumber;

        public LARGE_INTEGER NumberSectors;

        public LARGE_INTEGER TotalClusters;

        public LARGE_INTEGER FreeClusters;

        public LARGE_INTEGER TotalReserved;

        [NativeTypeName("DWORD")]
        public uint BytesPerSector;

        [NativeTypeName("DWORD")]
        public uint BytesPerCluster;

        public LARGE_INTEGER MaximumSizeOfResidentFile;

        [NativeTypeName("WORD")]
        public ushort FastTierDataFillRatio;

        [NativeTypeName("WORD")]
        public ushort SlowTierDataFillRatio;

        [NativeTypeName("DWORD")]
        public uint DestagesFastTierToSlowTierRate;

        [NativeTypeName("LARGE_INTEGER [9]")]
        public _Reserved_e__FixedBuffer Reserved;

        public partial struct _Reserved_e__FixedBuffer
        {
            public LARGE_INTEGER e0;
            public LARGE_INTEGER e1;
            public LARGE_INTEGER e2;
            public LARGE_INTEGER e3;
            public LARGE_INTEGER e4;
            public LARGE_INTEGER e5;
            public LARGE_INTEGER e6;
            public LARGE_INTEGER e7;
            public LARGE_INTEGER e8;

            public ref LARGE_INTEGER this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<LARGE_INTEGER> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 9);
        }
    }
}
