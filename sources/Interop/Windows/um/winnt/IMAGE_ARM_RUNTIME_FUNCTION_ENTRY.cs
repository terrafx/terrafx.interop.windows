// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_ARM_RUNTIME_FUNCTION_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint BeginAddress;

        [NativeTypeName("_IMAGE_ARM_RUNTIME_FUNCTION_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18732:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint UnwindData => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UnwindData, 1));

        public uint Flag
        {
            get
            {
                return Anonymous.Anonymous.Flag;
            }

            set
            {
                Anonymous.Anonymous.Flag = value;
            }
        }

        public uint FunctionLength
        {
            get
            {
                return Anonymous.Anonymous.FunctionLength;
            }

            set
            {
                Anonymous.Anonymous.FunctionLength = value;
            }
        }

        public uint Ret
        {
            get
            {
                return Anonymous.Anonymous.Ret;
            }

            set
            {
                Anonymous.Anonymous.Ret = value;
            }
        }

        public uint H
        {
            get
            {
                return Anonymous.Anonymous.H;
            }

            set
            {
                Anonymous.Anonymous.H = value;
            }
        }

        public uint Reg
        {
            get
            {
                return Anonymous.Anonymous.Reg;
            }

            set
            {
                Anonymous.Anonymous.Reg = value;
            }
        }

        public uint R
        {
            get
            {
                return Anonymous.Anonymous.R;
            }

            set
            {
                Anonymous.Anonymous.R = value;
            }
        }

        public uint L
        {
            get
            {
                return Anonymous.Anonymous.L;
            }

            set
            {
                Anonymous.Anonymous.L = value;
            }
        }

        public uint C
        {
            get
            {
                return Anonymous.Anonymous.C;
            }

            set
            {
                Anonymous.Anonymous.C = value;
            }
        }

        public uint StackAdjust
        {
            get
            {
                return Anonymous.Anonymous.StackAdjust;
            }

            set
            {
                Anonymous.Anonymous.StackAdjust = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint UnwindData;

            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_ARM_RUNTIME_FUNCTION_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18734:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 2")]
                public uint Flag
                {
                    get
                    {
                        return _bitfield & 0x3u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x3u) | (value & 0x3u);
                    }
                }

                [NativeTypeName("DWORD : 11")]
                public uint FunctionLength
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x7FFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFu << 2)) | ((value & 0x7FFu) << 2);
                    }
                }

                [NativeTypeName("DWORD : 2")]
                public uint Ret
                {
                    get
                    {
                        return (_bitfield >> 13) & 0x3u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint H
                {
                    get
                    {
                        return (_bitfield >> 15) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
                    }
                }

                [NativeTypeName("DWORD : 3")]
                public uint Reg
                {
                    get
                    {
                        return (_bitfield >> 16) & 0x7u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7u << 16)) | ((value & 0x7u) << 16);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint R
                {
                    get
                    {
                        return (_bitfield >> 19) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint L
                {
                    get
                    {
                        return (_bitfield >> 20) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint C
                {
                    get
                    {
                        return (_bitfield >> 21) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
                    }
                }

                [NativeTypeName("DWORD : 10")]
                public uint StackAdjust
                {
                    get
                    {
                        return (_bitfield >> 22) & 0x3FFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22);
                    }
                }
            }
        }
    }
}
