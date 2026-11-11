// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ISOLATION_CONFIGURATION_SIGNING.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_SIGNING"]/*' />
public partial struct _SECURITY_ISOLATION_CONFIGURATION_SIGNING
{
    /// <include file='_SECURITY_ISOLATION_CONFIGURATION_SIGNING.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_SIGNING.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13277_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_SECURITY_ISOLATION_CONFIGURATION_SIGNING.xml' path='doc/member[@name="_SECURITY_ISOLATION_CONFIGURATION_SIGNING.RequiredSigningLevel"]/*' />
    [NativeTypeName("SE_SIGNING_LEVEL")]
    public byte RequiredSigningLevel;

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

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RequireSigning"]/*' />
    public uint RequireSigning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.RequireSigning;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.RequireSigning = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RequireSignedLibraries"]/*' />
    public uint RequireSignedLibraries
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.RequireSignedLibraries;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.RequireSignedLibraries = value;
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
        [NativeTypeName("__AnonymousRecord_winnt_L13279_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RequireSigning"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint RequireSigning
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RequireSignedLibraries"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint RequireSignedLibraries
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORD : 30")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 2) & 0x3FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                }
            }
        }
    }
}
