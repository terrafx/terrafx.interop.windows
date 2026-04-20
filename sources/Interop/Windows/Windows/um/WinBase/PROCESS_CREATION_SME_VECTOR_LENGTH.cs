// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_CREATION_SME_VECTOR_LENGTH.xml' path='doc/member[@name="PROCESS_CREATION_SME_VECTOR_LENGTH"]/*' />
public partial struct PROCESS_CREATION_SME_VECTOR_LENGTH
{
    /// <include file='PROCESS_CREATION_SME_VECTOR_LENGTH.xml' path='doc/member[@name="PROCESS_CREATION_SME_VECTOR_LENGTH.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winbase_L3640_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='PROCESS_CREATION_SME_VECTOR_LENGTH.xml' path='doc/member[@name="PROCESS_CREATION_SME_VECTOR_LENGTH.Reserved"]/*' />
    [NativeTypeName("ULONG")]
    public uint Reserved;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Data"]/*' />
    [UnscopedRef]
    public ref uint Data
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Data;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.VectorLength"]/*' />
    public uint VectorLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.VectorLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.VectorLength = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FlagsReserved"]/*' />
    public uint FlagsReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.FlagsReserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.FlagsReserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Data"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Data;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winbase_L3642_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.VectorLength"]/*' />
            [NativeTypeName("ULONG : 24")]
            public uint VectorLength
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0xFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFFFu) | (value & 0xFFFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FlagsReserved"]/*' />
            [NativeTypeName("ULONG : 8")]
            public uint FlagsReserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 24) & 0xFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                }
            }
        }
    }
}
