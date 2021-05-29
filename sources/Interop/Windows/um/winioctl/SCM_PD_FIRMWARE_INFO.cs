// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_PD_FIRMWARE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BYTE")]
        public byte ActiveSlot;

        [NativeTypeName("BYTE")]
        public byte NextActiveSlot;

        [NativeTypeName("BYTE")]
        public byte SlotCount;

        [NativeTypeName("SCM_PD_FIRMWARE_SLOT_INFO [1]")]
        public _Slots_e__FixedBuffer Slots;

        public partial struct _Slots_e__FixedBuffer
        {
            public SCM_PD_FIRMWARE_SLOT_INFO e0;

            public ref SCM_PD_FIRMWARE_SLOT_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SCM_PD_FIRMWARE_SLOT_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
