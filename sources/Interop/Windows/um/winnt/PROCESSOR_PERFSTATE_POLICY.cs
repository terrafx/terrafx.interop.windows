// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESSOR_PERFSTATE_POLICY
    {
        [NativeTypeName("DWORD")]
        public uint Revision;

        [NativeTypeName("BYTE")]
        public byte MaxThrottle;

        [NativeTypeName("BYTE")]
        public byte MinThrottle;

        [NativeTypeName("BYTE")]
        public byte BusyAdjThreshold;

        [NativeTypeName("PROCESSOR_PERFSTATE_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16660:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref byte Spare
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Spare, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Spare;
#endif
            }
        }

        public unsafe ref _Anonymous_e__Union._Flags_e__Union Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Flags;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        [NativeTypeName("DWORD")]
        public uint IncreaseTime;

        [NativeTypeName("DWORD")]
        public uint DecreaseTime;

        [NativeTypeName("DWORD")]
        public uint IncreasePercent;

        [NativeTypeName("DWORD")]
        public uint DecreasePercent;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("BYTE")]
            public byte Spare;

            [FieldOffset(0)]
            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16662:9)")]
            public _Flags_e__Union Flags;

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Flags_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("BYTE")]
                public byte AsBYTE;

                [FieldOffset(0)]
                [NativeTypeName("PROCESSOR_PERFSTATE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16664:13)")]
                public _Anonymous_e__Struct Anonymous;

                public unsafe byte NoDomainAccounting
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.NoDomainAccounting;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.NoDomainAccounting = value;
                    }
                }

                public unsafe byte IncreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.IncreasePolicy;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.IncreasePolicy = value;
                    }
                }

                public unsafe byte DecreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.DecreasePolicy;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.DecreasePolicy = value;
                    }
                }

                public unsafe byte Reserved
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
                    public byte _bitfield;

                    [NativeTypeName("BYTE : 1")]
                    public byte NoDomainAccounting
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

                    [NativeTypeName("BYTE : 2")]
                    public byte IncreasePolicy
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 1) & 0x3u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 1)) | ((value & 0x3u) << 1));
                        }
                    }

                    [NativeTypeName("BYTE : 2")]
                    public byte DecreasePolicy
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 3) & 0x3u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 3)) | ((value & 0x3u) << 3));
                        }
                    }

                    [NativeTypeName("BYTE : 3")]
                    public byte Reserved
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 5) & 0x7u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5));
                        }
                    }
                }
            }
        }
    }
}
