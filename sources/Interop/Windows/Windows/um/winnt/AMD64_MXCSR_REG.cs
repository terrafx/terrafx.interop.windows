// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AMD64_MXCSR_REG.xml' path='doc/member[@name="AMD64_MXCSR_REG"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct AMD64_MXCSR_REG
{
    /// <include file='AMD64_MXCSR_REG.xml' path='doc/member[@name="AMD64_MXCSR_REG.Value"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint Value;

    /// <include file='AMD64_MXCSR_REG.xml' path='doc/member[@name="AMD64_MXCSR_REG.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("_AMD64_MXCSR_REG::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:6802:5)")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IE"]/*' />
    public uint IE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.IE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.IE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DE"]/*' />
    public uint DE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.DE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.DE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ZE"]/*' />
    public uint ZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.ZE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.ZE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OE"]/*' />
    public uint OE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.OE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.OE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UE"]/*' />
    public uint UE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.UE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.UE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PE"]/*' />
    public uint PE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.PE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.PE = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DAZ"]/*' />
    public uint DAZ
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.DAZ;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.DAZ = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IM"]/*' />
    public uint IM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.IM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.IM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DM"]/*' />
    public uint DM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.DM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.DM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ZM"]/*' />
    public uint ZM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.ZM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.ZM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OM"]/*' />
    public uint OM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.OM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.OM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UM"]/*' />
    public uint UM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.UM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.UM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PM"]/*' />
    public uint PM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.PM;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.PM = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RC"]/*' />
    public uint RC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.RC;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.RC = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FZ"]/*' />
    public uint FZ
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.FZ;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.FZ = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.res"]/*' />
    public uint res
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.res;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.res = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint IE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint DE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ZE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint ZE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint OE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint UE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PE"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint PE
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DAZ"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint DAZ
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint IM
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint DM
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ZM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint ZM
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint OM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 10) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint UM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 11) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PM"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint PM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 12) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RC"]/*' />
        [NativeTypeName("DWORD : 2")]
        public uint RC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 13) & 0x3u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FZ"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint FZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 15) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.res"]/*' />
        [NativeTypeName("DWORD : 16")]
        public uint res
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 16) & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
            }
        }
    }
}
