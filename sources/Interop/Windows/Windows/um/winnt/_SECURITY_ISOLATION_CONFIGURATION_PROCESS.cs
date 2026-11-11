// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ISOLATION_CONFIGURATION_PROCESS.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_PROCESS"]/*' />
public partial struct _SECURITY_ISOLATION_CONFIGURATION_PROCESS
{
    /// <include file='_SECURITY_ISOLATION_CONFIGURATION_PROCESS.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_PROCESS.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13236_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NeverInheritFromParent"]/*' />
    public uint NeverInheritFromParent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.NeverInheritFromParent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.NeverInheritFromParent = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowInheritFromAnyIdentity"]/*' />
    public uint AllowInheritFromAnyIdentity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.AllowInheritFromAnyIdentity;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AllowInheritFromAnyIdentity = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ShareInstanceWithChildren"]/*' />
    public uint ShareInstanceWithChildren
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.ShareInstanceWithChildren;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.ShareInstanceWithChildren = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.Reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13238_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NeverInheritFromParent"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint NeverInheritFromParent
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowInheritFromAnyIdentity"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AllowInheritFromAnyIdentity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ShareInstanceWithChildren"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint ShareInstanceWithChildren
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 2) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORD : 29")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 3) & 0x1FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                }
            }
        }
    }
}
