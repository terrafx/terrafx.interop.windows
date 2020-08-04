// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11827:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));

        public uint EnableExportAddressFilter
        {
            get
            {
                return Anonymous.Anonymous.EnableExportAddressFilter;
            }

            set
            {
                Anonymous.Anonymous.EnableExportAddressFilter = value;
            }
        }

        public uint AuditExportAddressFilter
        {
            get
            {
                return Anonymous.Anonymous.AuditExportAddressFilter;
            }

            set
            {
                Anonymous.Anonymous.AuditExportAddressFilter = value;
            }
        }

        public uint EnableExportAddressFilterPlus
        {
            get
            {
                return Anonymous.Anonymous.EnableExportAddressFilterPlus;
            }

            set
            {
                Anonymous.Anonymous.EnableExportAddressFilterPlus = value;
            }
        }

        public uint AuditExportAddressFilterPlus
        {
            get
            {
                return Anonymous.Anonymous.AuditExportAddressFilterPlus;
            }

            set
            {
                Anonymous.Anonymous.AuditExportAddressFilterPlus = value;
            }
        }

        public uint EnableImportAddressFilter
        {
            get
            {
                return Anonymous.Anonymous.EnableImportAddressFilter;
            }

            set
            {
                Anonymous.Anonymous.EnableImportAddressFilter = value;
            }
        }

        public uint AuditImportAddressFilter
        {
            get
            {
                return Anonymous.Anonymous.AuditImportAddressFilter;
            }

            set
            {
                Anonymous.Anonymous.AuditImportAddressFilter = value;
            }
        }

        public uint EnableRopStackPivot
        {
            get
            {
                return Anonymous.Anonymous.EnableRopStackPivot;
            }

            set
            {
                Anonymous.Anonymous.EnableRopStackPivot = value;
            }
        }

        public uint AuditRopStackPivot
        {
            get
            {
                return Anonymous.Anonymous.AuditRopStackPivot;
            }

            set
            {
                Anonymous.Anonymous.AuditRopStackPivot = value;
            }
        }

        public uint EnableRopCallerCheck
        {
            get
            {
                return Anonymous.Anonymous.EnableRopCallerCheck;
            }

            set
            {
                Anonymous.Anonymous.EnableRopCallerCheck = value;
            }
        }

        public uint AuditRopCallerCheck
        {
            get
            {
                return Anonymous.Anonymous.AuditRopCallerCheck;
            }

            set
            {
                Anonymous.Anonymous.AuditRopCallerCheck = value;
            }
        }

        public uint EnableRopSimExec
        {
            get
            {
                return Anonymous.Anonymous.EnableRopSimExec;
            }

            set
            {
                Anonymous.Anonymous.EnableRopSimExec = value;
            }
        }

        public uint AuditRopSimExec
        {
            get
            {
                return Anonymous.Anonymous.AuditRopSimExec;
            }

            set
            {
                Anonymous.Anonymous.AuditRopSimExec = value;
            }
        }

        public uint ReservedFlags
        {
            get
            {
                return Anonymous.Anonymous.ReservedFlags;
            }

            set
            {
                Anonymous.Anonymous.ReservedFlags = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("_PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11829:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint EnableExportAddressFilter
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
                public uint AuditExportAddressFilter
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

                [NativeTypeName("DWORD : 1")]
                public uint EnableExportAddressFilterPlus
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditExportAddressFilterPlus
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

                [NativeTypeName("DWORD : 1")]
                public uint EnableImportAddressFilter
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditImportAddressFilter
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

                [NativeTypeName("DWORD : 1")]
                public uint EnableRopStackPivot
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditRopStackPivot
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

                [NativeTypeName("DWORD : 1")]
                public uint EnableRopCallerCheck
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditRopCallerCheck
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

                [NativeTypeName("DWORD : 1")]
                public uint EnableRopSimExec
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditRopSimExec
                {
                    get
                    {
                        return (_bitfield >> 11) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
                    }
                }

                [NativeTypeName("DWORD : 20")]
                public uint ReservedFlags
                {
                    get
                    {
                        return (_bitfield >> 12) & 0xFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFu << 12)) | ((value & 0xFFFFFu) << 12);
                    }
                }
            }
        }
    }
}
