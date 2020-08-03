// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct HIDP_KEYBOARD_MODIFIER_STATE
    {
        [NativeTypeName("_HIDP_KEYBOARD_MODIFIER_STATE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/hidpi.h:1728:4)")]
        public _Anonymous_e__Union Anonymous;

        public uint LeftControl
        {
            get
            {
                return Anonymous.Anonymous.LeftControl;
            }

            set
            {
                Anonymous.Anonymous.LeftControl = value;
            }
        }

        public uint LeftShift
        {
            get
            {
                return Anonymous.Anonymous.LeftShift;
            }

            set
            {
                Anonymous.Anonymous.LeftShift = value;
            }
        }

        public uint LeftAlt
        {
            get
            {
                return Anonymous.Anonymous.LeftAlt;
            }

            set
            {
                Anonymous.Anonymous.LeftAlt = value;
            }
        }

        public uint LeftGUI
        {
            get
            {
                return Anonymous.Anonymous.LeftGUI;
            }

            set
            {
                Anonymous.Anonymous.LeftGUI = value;
            }
        }

        public uint RightControl
        {
            get
            {
                return Anonymous.Anonymous.RightControl;
            }

            set
            {
                Anonymous.Anonymous.RightControl = value;
            }
        }

        public uint RightShift
        {
            get
            {
                return Anonymous.Anonymous.RightShift;
            }

            set
            {
                Anonymous.Anonymous.RightShift = value;
            }
        }

        public uint RightAlt
        {
            get
            {
                return Anonymous.Anonymous.RightAlt;
            }

            set
            {
                Anonymous.Anonymous.RightAlt = value;
            }
        }

        public uint RigthGUI
        {
            get
            {
                return Anonymous.Anonymous.RigthGUI;
            }

            set
            {
                Anonymous.Anonymous.RigthGUI = value;
            }
        }

        public uint CapsLock
        {
            get
            {
                return Anonymous.Anonymous.CapsLock;
            }

            set
            {
                Anonymous.Anonymous.CapsLock = value;
            }
        }

        public uint ScollLock
        {
            get
            {
                return Anonymous.Anonymous.ScollLock;
            }

            set
            {
                Anonymous.Anonymous.ScollLock = value;
            }
        }

        public uint NumLock
        {
            get
            {
                return Anonymous.Anonymous.NumLock;
            }

            set
            {
                Anonymous.Anonymous.NumLock = value;
            }
        }

        public uint Reserved
        {
            get
            {
                return Anonymous.Anonymous.Reserved;
            }

            set
            {
                Anonymous.Anonymous.Reserved = value;
            }
        }

        public ref uint ul => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ul, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_HIDP_KEYBOARD_MODIFIER_STATE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/hidpi.h:1729:7)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ul;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("ULONG : 1")]
                public uint LeftControl
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

                [NativeTypeName("ULONG : 1")]
                public uint LeftShift
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

                [NativeTypeName("ULONG : 1")]
                public uint LeftAlt
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint LeftGUI
                {
                    get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RightControl
                {
                    get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RightShift
                {
                    get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RightAlt
                {
                    get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RigthGUI
                {
                    get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint CapsLock
                {
                    get
                    {
                        return (_bitfield >> 8) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint ScollLock
                {
                    get
                    {
                        return (_bitfield >> 9) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint NumLock
                {
                    get
                    {
                        return (_bitfield >> 10) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
                    }
                }

                [NativeTypeName("ULONG : 21")]
                public uint Reserved
                {
                    get
                    {
                        return (_bitfield >> 11) & 0x1FFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFu << 11)) | ((value & 0x1FFFFFu) << 11);
                    }
                }
            }
        }
    }
}
