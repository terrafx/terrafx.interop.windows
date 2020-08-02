// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PERSISTENT_RESERVE_COMMAND
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("_PERSISTENT_RESERVE_COMMAND::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5615:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._PR_IN_e__Struct PR_IN => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.PR_IN, 1));

        public ref _Anonymous_e__Union._PR_OUT_e__Struct PR_OUT => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.PR_OUT, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5617:9)")]
            public _PR_IN_e__Struct PR_IN;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5634:9)")]
            public _PR_OUT_e__Struct PR_OUT;

            public partial struct _PR_IN_e__Struct
            {
                public byte _bitfield;

                [NativeTypeName("BYTE : 5")]
                public byte ServiceAction
                {
                    get
                    {
                        return (byte)(_bitfield & 0x1Fu);
                    }

                    set
                    {
                        _bitfield = (byte)((_bitfield & ~0x1Fu) | (value & 0x1Fu));
                    }
                }

                [NativeTypeName("BYTE : 3")]
                public byte Reserved1
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

                [NativeTypeName("WORD")]
                public ushort AllocationLength;
            }

            public unsafe partial struct _PR_OUT_e__Struct
            {
                public byte _bitfield1;

                [NativeTypeName("BYTE : 5")]
                public byte ServiceAction
                {
                    get
                    {
                        return (byte)(_bitfield1 & 0x1Fu);
                    }

                    set
                    {
                        _bitfield1 = (byte)((_bitfield1 & ~0x1Fu) | (value & 0x1Fu));
                    }
                }

                [NativeTypeName("BYTE : 3")]
                public byte Reserved1
                {
                    get
                    {
                        return (byte)((_bitfield1 >> 5) & 0x7u);
                    }

                    set
                    {
                        _bitfield1 = (byte)((_bitfield1 & ~(0x7u << 5)) | ((value & 0x7u) << 5));
                    }
                }

                public byte _bitfield2;

                [NativeTypeName("BYTE : 4")]
                public byte Type
                {
                    get
                    {
                        return (byte)(_bitfield2 & 0xFu);
                    }

                    set
                    {
                        _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu));
                    }
                }

                [NativeTypeName("BYTE : 4")]
                public byte Scope
                {
                    get
                    {
                        return (byte)((_bitfield2 >> 4) & 0xFu);
                    }

                    set
                    {
                        _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                    }
                }

                [NativeTypeName("BYTE [0]")]
                public fixed byte ParameterList[1];
            }
        }
    }
}
