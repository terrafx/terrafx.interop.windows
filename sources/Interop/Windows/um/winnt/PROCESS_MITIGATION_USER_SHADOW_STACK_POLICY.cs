// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_USER_SHADOW_STACK_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_USER_SHADOW_STACK_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:12942:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
            }
        }

        public uint EnableUserShadowStack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableUserShadowStack;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableUserShadowStack = value;
            }
        }

        public uint AuditUserShadowStack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditUserShadowStack;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditUserShadowStack = value;
            }
        }

        public uint SetContextIpValidation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.SetContextIpValidation;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.SetContextIpValidation = value;
            }
        }

        public uint AuditSetContextIpValidation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditSetContextIpValidation;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditSetContextIpValidation = value;
            }
        }

        public uint EnableUserShadowStackStrictMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableUserShadowStackStrictMode;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableUserShadowStackStrictMode = value;
            }
        }

        public uint BlockNonCetBinaries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.BlockNonCetBinaries;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.BlockNonCetBinaries = value;
            }
        }

        public uint BlockNonCetBinariesNonEhcont
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.BlockNonCetBinariesNonEhcont;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.BlockNonCetBinariesNonEhcont = value;
            }
        }

        public uint AuditBlockNonCetBinaries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditBlockNonCetBinaries;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditBlockNonCetBinaries = value;
            }
        }

        public uint CetDynamicApisOutOfProcOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.CetDynamicApisOutOfProcOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.CetDynamicApisOutOfProcOnly = value;
            }
        }

        public uint SetContextIpValidationRelaxedMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.SetContextIpValidationRelaxedMode;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.SetContextIpValidationRelaxedMode = value;
            }
        }

        public uint ReservedFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.ReservedFlags;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            [NativeTypeName("_PROCESS_MITIGATION_USER_SHADOW_STACK_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:12944:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint EnableUserShadowStack
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint AuditUserShadowStack
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint SetContextIpValidation
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint AuditSetContextIpValidation
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint EnableUserShadowStackStrictMode
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint BlockNonCetBinaries
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint BlockNonCetBinariesNonEhcont
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint AuditBlockNonCetBinaries
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint CetDynamicApisOutOfProcOnly
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 8) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint SetContextIpValidationRelaxedMode
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 9) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                    }
                }

                [NativeTypeName("DWORD : 22")]
                public uint ReservedFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 10) & 0x3FFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFu << 10)) | ((value & 0x3FFFFFu) << 10);
                    }
                }
            }
        }
    }
}
