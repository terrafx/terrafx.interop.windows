// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_IMAGE_LOAD_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_IMAGE_LOAD_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11803:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));

        public uint NoRemoteImages
        {
            get
            {
                return Anonymous.Anonymous.NoRemoteImages;
            }

            set
            {
                Anonymous.Anonymous.NoRemoteImages = value;
            }
        }

        public uint NoLowMandatoryLabelImages
        {
            get
            {
                return Anonymous.Anonymous.NoLowMandatoryLabelImages;
            }

            set
            {
                Anonymous.Anonymous.NoLowMandatoryLabelImages = value;
            }
        }

        public uint PreferSystem32Images
        {
            get
            {
                return Anonymous.Anonymous.PreferSystem32Images;
            }

            set
            {
                Anonymous.Anonymous.PreferSystem32Images = value;
            }
        }

        public uint AuditNoRemoteImages
        {
            get
            {
                return Anonymous.Anonymous.AuditNoRemoteImages;
            }

            set
            {
                Anonymous.Anonymous.AuditNoRemoteImages = value;
            }
        }

        public uint AuditNoLowMandatoryLabelImages
        {
            get
            {
                return Anonymous.Anonymous.AuditNoLowMandatoryLabelImages;
            }

            set
            {
                Anonymous.Anonymous.AuditNoLowMandatoryLabelImages = value;
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
            [NativeTypeName("_PROCESS_MITIGATION_IMAGE_LOAD_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11805:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint NoRemoteImages
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
                public uint NoLowMandatoryLabelImages
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
                public uint PreferSystem32Images
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
                public uint AuditNoRemoteImages
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
                public uint AuditNoLowMandatoryLabelImages
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

                [NativeTypeName("DWORD : 27")]
                public uint ReservedFlags
                {
                    get
                    {
                        return (_bitfield >> 5) & 0x7FFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5);
                    }
                }
            }
        }
    }
}
