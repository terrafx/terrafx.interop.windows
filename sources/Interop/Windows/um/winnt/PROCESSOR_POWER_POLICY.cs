// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_POWER_POLICY
    {
        [NativeTypeName("DWORD")]
        public uint Revision;

        [NativeTypeName("BYTE")]
        public byte DynamicThrottle;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Spare[3];

        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint DisableCStates
        {
            get
            {
                return _bitfield & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("DWORD : 31")]
        public uint Reserved
        {
            get
            {
                return (_bitfield >> 1) & 0x7FFFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
            }
        }

        [NativeTypeName("DWORD")]
        public uint PolicyCount;

        [NativeTypeName("PROCESSOR_POWER_POLICY_INFO [3]")]
        public _Policy_e__FixedBuffer Policy;

        public partial struct _Policy_e__FixedBuffer
        {
            public PROCESSOR_POWER_POLICY_INFO e0;
            public PROCESSOR_POWER_POLICY_INFO e1;
            public PROCESSOR_POWER_POLICY_INFO e2;

            public ref PROCESSOR_POWER_POLICY_INFO this[int index] => ref AsSpan()[index];

            public Span<PROCESSOR_POWER_POLICY_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}
