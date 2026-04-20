// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER"]/*' />
public partial struct XSAVE_ARM64_SVE_HEADER
{
    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.VectorLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint VectorLength;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.VectorRegisterOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint VectorRegisterOffset;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.PredicateRegisterOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint PredicateRegisterOffset;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L2783_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.Reserved"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _Reserved_e__FixedBuffer Reserved;

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

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Sm"]/*' />
    public uint Sm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.Sm;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Sm = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
    public uint ReservedFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.ReservedFlags;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.ReservedFlags = value;
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
        [NativeTypeName("__AnonymousRecord_winnt_L2785_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Sm"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Sm
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
            [NativeTypeName("DWORD : 31")]
            public uint ReservedFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 1) & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                }
            }
        }
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
