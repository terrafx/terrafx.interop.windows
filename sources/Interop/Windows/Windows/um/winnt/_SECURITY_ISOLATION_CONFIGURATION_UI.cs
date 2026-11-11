// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ISOLATION_CONFIGURATION_UI.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_UI"]/*' />
public partial struct _SECURITY_ISOLATION_CONFIGURATION_UI
{
    /// <include file='_SECURITY_ISOLATION_CONFIGURATION_UI.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_UI.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13177_C5")]
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

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BlockUiAccess"]/*' />
    public uint BlockUiAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.BlockUiAccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.BlockUiAccess = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowExternalHook"]/*' />
    public uint AllowExternalHook
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.AllowExternalHook;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AllowExternalHook = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowHandleAccess"]/*' />
    public uint AllowHandleAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.AllowHandleAccess;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AllowHandleAccess = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowWindowMessages"]/*' />
    public uint AllowWindowMessages
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.AllowWindowMessages;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AllowWindowMessages = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowSyntheticInput"]/*' />
    public uint AllowSyntheticInput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.AllowSyntheticInput;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AllowSyntheticInput = value;
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
        [NativeTypeName("__AnonymousRecord_winnt_L13179_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BlockUiAccess"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint BlockUiAccess
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowExternalHook"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AllowExternalHook
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowHandleAccess"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AllowHandleAccess
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowWindowMessages"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AllowWindowMessages
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 3) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowSyntheticInput"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AllowSyntheticInput
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 4) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORD : 27")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 5) & 0x7FFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5);
                }
            }
        }
    }
}
