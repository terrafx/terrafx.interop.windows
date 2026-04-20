// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION"]/*' />
public partial struct NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION
{
    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_memoryapi_L1176_C5")]
    public _Flags_e__Struct Flags;

    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION.MinTransferSizeInBytes"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MinTransferSizeInBytes;

    /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct"]/*' />
    public partial struct _Flags_e__Struct
    {
        public byte _bitfield;

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.MinTransferSizeToAchieveValues"]/*' />
        [NativeTypeName("UCHAR : 1")]
        public byte MinTransferSizeToAchieveValues
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.NonSequentialTransfers"]/*' />
        [NativeTypeName("UCHAR : 1")]
        public byte NonSequentialTransfers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Reserved"]/*' />
        [NativeTypeName("UCHAR : 6")]
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x3Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2));
            }
        }
    }
}
