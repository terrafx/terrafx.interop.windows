// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct STORAGE_DEVICE_MANAGEMENT_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public STORAGE_DISK_HEALTH_STATUS Health;

        [NativeTypeName("DWORD")]
        public uint NumberOfOperationalStatus;

        [NativeTypeName("DWORD")]
        public uint NumberOfAdditionalReasons;

        [NativeTypeName("STORAGE_DISK_OPERATIONAL_STATUS [16]")]
        public _OperationalStatus_e__FixedBuffer OperationalStatus;

        [NativeTypeName("STORAGE_OPERATIONAL_REASON [1]")]
        public _AdditionalReasons_e__FixedBuffer AdditionalReasons;

        public partial struct _OperationalStatus_e__FixedBuffer
        {
            public STORAGE_DISK_OPERATIONAL_STATUS e0;
            public STORAGE_DISK_OPERATIONAL_STATUS e1;
            public STORAGE_DISK_OPERATIONAL_STATUS e2;
            public STORAGE_DISK_OPERATIONAL_STATUS e3;
            public STORAGE_DISK_OPERATIONAL_STATUS e4;
            public STORAGE_DISK_OPERATIONAL_STATUS e5;
            public STORAGE_DISK_OPERATIONAL_STATUS e6;
            public STORAGE_DISK_OPERATIONAL_STATUS e7;
            public STORAGE_DISK_OPERATIONAL_STATUS e8;
            public STORAGE_DISK_OPERATIONAL_STATUS e9;
            public STORAGE_DISK_OPERATIONAL_STATUS e10;
            public STORAGE_DISK_OPERATIONAL_STATUS e11;
            public STORAGE_DISK_OPERATIONAL_STATUS e12;
            public STORAGE_DISK_OPERATIONAL_STATUS e13;
            public STORAGE_DISK_OPERATIONAL_STATUS e14;
            public STORAGE_DISK_OPERATIONAL_STATUS e15;

            public ref STORAGE_DISK_OPERATIONAL_STATUS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<STORAGE_DISK_OPERATIONAL_STATUS> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }

        public partial struct _AdditionalReasons_e__FixedBuffer
        {
            public STORAGE_OPERATIONAL_REASON e0;

            public ref STORAGE_OPERATIONAL_REASON this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<STORAGE_OPERATIONAL_REASON> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
