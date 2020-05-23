// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

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

                public partial struct _Anonymous_e__Struct
                {
                    internal byte _bitfield;

                    [NativeTypeName("BYTE : 1")]
                    public byte NoDomainAccounting
                    {
                        get
                        {
                            return (byte)(_bitfield & 0x1u);
                        }

                        set
                        {
                            _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                        }
                    }

                    [NativeTypeName("BYTE : 2")]
                    public byte IncreasePolicy
                    {
                        get
                        {
                            return (byte)((_bitfield >> 1) & 0x3u);
                        }

                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 1)) | ((value & 0x3u) << 1));
                        }
                    }

                    [NativeTypeName("BYTE : 2")]
                    public byte DecreasePolicy
                    {
                        get
                        {
                            return (byte)((_bitfield >> 3) & 0x3u);
                        }

                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 3)) | ((value & 0x3u) << 3));
                        }
                    }

                    [NativeTypeName("BYTE : 3")]
                    public byte Reserved
                    {
                        get
                        {
                            return (byte)((_bitfield >> 5) & 0x7u);
                        }

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
