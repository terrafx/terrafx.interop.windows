// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
{
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Name"]/*' />
    [NativeTypeName("DWORD")]
    public uint Name;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueType"]/*' />
    [NativeTypeName("WORD")]
    public ushort ValueType;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ValueCount;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Values"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L12035_C5")]
    public _Values_e__Union Values;

    /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Values_e__Union
    {
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pInt64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pInt64_e__FixedBuffer pInt64;

        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pUint64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pUint64_e__FixedBuffer pUint64;

        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.ppString"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _ppString_e__FixedBuffer ppString;

        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pFqbn"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pFqbn_e__FixedBuffer pFqbn;

        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pOctetString"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pOctetString_e__FixedBuffer pOctetString;

        /// <include file='_pInt64_e__FixedBuffer.xml' path='doc/member[@name="_pInt64_e__FixedBuffer"]/*' />
        public partial struct _pInt64_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_pUint64_e__FixedBuffer.xml' path='doc/member[@name="_pUint64_e__FixedBuffer"]/*' />
        public partial struct _pUint64_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_ppString_e__FixedBuffer.xml' path='doc/member[@name="_ppString_e__FixedBuffer"]/*' />
        public partial struct _ppString_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_pFqbn_e__FixedBuffer.xml' path='doc/member[@name="_pFqbn_e__FixedBuffer"]/*' />
        public partial struct _pFqbn_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_pOctetString_e__FixedBuffer.xml' path='doc/member[@name="_pOctetString_e__FixedBuffer"]/*' />
        public partial struct _pOctetString_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
