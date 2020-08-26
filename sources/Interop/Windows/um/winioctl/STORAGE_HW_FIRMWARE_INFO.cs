// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_HW_FIRMWARE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public byte _bitfield;

        [NativeTypeName("BYTE : 1")]
        public byte SupportUpgrade
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("BYTE : 7")]
        public byte Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (byte)((_bitfield >> 1) & 0x7Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
            }
        }

        [NativeTypeName("BYTE")]
        public byte SlotCount;

        [NativeTypeName("BYTE")]
        public byte ActiveSlot;

        [NativeTypeName("BYTE")]
        public byte PendingActivateSlot;

        [NativeTypeName("BOOLEAN")]
        public byte FirmwareShared;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved[3];

        [NativeTypeName("DWORD")]
        public uint ImagePayloadAlignment;

        [NativeTypeName("DWORD")]
        public uint ImagePayloadMaxSize;

        [NativeTypeName("STORAGE_HW_FIRMWARE_SLOT_INFO [1]")]
        public _Slot_e__FixedBuffer Slot;

        public partial struct _Slot_e__FixedBuffer
        {
            public STORAGE_HW_FIRMWARE_SLOT_INFO e0;

            public ref STORAGE_HW_FIRMWARE_SLOT_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<STORAGE_HW_FIRMWARE_SLOT_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
