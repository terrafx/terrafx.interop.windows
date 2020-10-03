// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESSOR_IDLESTATE_POLICY
    {
        [NativeTypeName("WORD")]
        public ushort Revision;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16586:5)")]
        public _Flags_e__Union Flags;

        [NativeTypeName("DWORD")]
        public uint PolicyCount;

        [NativeTypeName("PROCESSOR_IDLESTATE_INFO [3]")]
        public _Policy_e__FixedBuffer Policy;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Flags_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort AsWORD;

            [FieldOffset(0)]
            [NativeTypeName("PROCESSOR_IDLESTATE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16588:9)")]
            public _Anonymous_e__Struct Anonymous;

            public ushort AllowScaling
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.AllowScaling;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.AllowScaling = value;
                }
            }

            public ushort Disabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.Disabled;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.Disabled = value;
                }
            }

            public ushort Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.Reserved;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.Reserved = value;
                }
            }

            public partial struct _Anonymous_e__Struct
            {
                public ushort _bitfield;

                [NativeTypeName("WORD : 1")]
                public ushort AllowScaling
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)(_bitfield & 0x1u);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
                    }
                }

                [NativeTypeName("WORD : 1")]
                public ushort Disabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)((_bitfield >> 1) & 0x1u);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                    }
                }

                [NativeTypeName("WORD : 14")]
                public ushort Reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)((_bitfield >> 2) & 0x3FFFu);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~(0x3FFFu << 2)) | ((value & 0x3FFFu) << 2));
                    }
                }
            }
        }

        public partial struct _Policy_e__FixedBuffer
        {
            public PROCESSOR_IDLESTATE_INFO e0;
            public PROCESSOR_IDLESTATE_INFO e1;
            public PROCESSOR_IDLESTATE_INFO e2;

            public ref PROCESSOR_IDLESTATE_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PROCESSOR_IDLESTATE_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}
