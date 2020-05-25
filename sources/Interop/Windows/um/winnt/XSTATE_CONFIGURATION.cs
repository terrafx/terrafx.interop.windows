// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XSTATE_CONFIGURATION
    {
        [NativeTypeName("DWORD64")]
        public ulong EnabledFeatures;

        [NativeTypeName("DWORD64")]
        public ulong EnabledVolatileFeatures;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12817:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("XSTATE_FEATURE [64]")]
        public _Features_e__FixedBuffer Features;

        [NativeTypeName("DWORD64")]
        public ulong EnabledSupervisorFeatures;

        [NativeTypeName("DWORD64")]
        public ulong AlignedFeatures;

        [NativeTypeName("DWORD")]
        public uint AllFeatureSize;

        [NativeTypeName("DWORD [64]")]
        public fixed uint AllFeatures[64];

        [NativeTypeName("DWORD64")]
        public ulong EnabledUserVisibleSupervisorFeatures;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ControlFlags;

            [FieldOffset(0)]
            [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12819:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint OptimizedSave
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

                [NativeTypeName("DWORD : 1")]
                public uint CompactionEnabled
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }
            }
        }

        public partial struct _Features_e__FixedBuffer
        {
            internal XSTATE_FEATURE e0;
            internal XSTATE_FEATURE e1;
            internal XSTATE_FEATURE e2;
            internal XSTATE_FEATURE e3;
            internal XSTATE_FEATURE e4;
            internal XSTATE_FEATURE e5;
            internal XSTATE_FEATURE e6;
            internal XSTATE_FEATURE e7;
            internal XSTATE_FEATURE e8;
            internal XSTATE_FEATURE e9;
            internal XSTATE_FEATURE e10;
            internal XSTATE_FEATURE e11;
            internal XSTATE_FEATURE e12;
            internal XSTATE_FEATURE e13;
            internal XSTATE_FEATURE e14;
            internal XSTATE_FEATURE e15;
            internal XSTATE_FEATURE e16;
            internal XSTATE_FEATURE e17;
            internal XSTATE_FEATURE e18;
            internal XSTATE_FEATURE e19;
            internal XSTATE_FEATURE e20;
            internal XSTATE_FEATURE e21;
            internal XSTATE_FEATURE e22;
            internal XSTATE_FEATURE e23;
            internal XSTATE_FEATURE e24;
            internal XSTATE_FEATURE e25;
            internal XSTATE_FEATURE e26;
            internal XSTATE_FEATURE e27;
            internal XSTATE_FEATURE e28;
            internal XSTATE_FEATURE e29;
            internal XSTATE_FEATURE e30;
            internal XSTATE_FEATURE e31;
            internal XSTATE_FEATURE e32;
            internal XSTATE_FEATURE e33;
            internal XSTATE_FEATURE e34;
            internal XSTATE_FEATURE e35;
            internal XSTATE_FEATURE e36;
            internal XSTATE_FEATURE e37;
            internal XSTATE_FEATURE e38;
            internal XSTATE_FEATURE e39;
            internal XSTATE_FEATURE e40;
            internal XSTATE_FEATURE e41;
            internal XSTATE_FEATURE e42;
            internal XSTATE_FEATURE e43;
            internal XSTATE_FEATURE e44;
            internal XSTATE_FEATURE e45;
            internal XSTATE_FEATURE e46;
            internal XSTATE_FEATURE e47;
            internal XSTATE_FEATURE e48;
            internal XSTATE_FEATURE e49;
            internal XSTATE_FEATURE e50;
            internal XSTATE_FEATURE e51;
            internal XSTATE_FEATURE e52;
            internal XSTATE_FEATURE e53;
            internal XSTATE_FEATURE e54;
            internal XSTATE_FEATURE e55;
            internal XSTATE_FEATURE e56;
            internal XSTATE_FEATURE e57;
            internal XSTATE_FEATURE e58;
            internal XSTATE_FEATURE e59;
            internal XSTATE_FEATURE e60;
            internal XSTATE_FEATURE e61;
            internal XSTATE_FEATURE e62;
            internal XSTATE_FEATURE e63;

            public ref XSTATE_FEATURE this[int index] => ref AsSpan()[index];

            public Span<XSTATE_FEATURE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 64);
        }
    }
}
