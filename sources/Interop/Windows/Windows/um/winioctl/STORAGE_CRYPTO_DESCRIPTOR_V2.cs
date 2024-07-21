// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2"]/*' />
public partial struct STORAGE_CRYPTO_DESCRIPTOR_V2
{
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.NumKeysSupported"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumKeysSupported;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.NumCryptoCapabilities"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumCryptoCapabilities;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.IceType"]/*' />
    public STORAGE_ICE_TYPE IceType;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.SecurityComplianceBitmask"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L2074_C5")]
    public _SecurityComplianceBitmask_e__Union SecurityComplianceBitmask;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.CryptoCapabilities"]/*' />
    [NativeTypeName("STORAGE_CRYPTO_CAPABILITY_V2[1]")]
    public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;

    /// <include file='_SecurityComplianceBitmask_e__Union.xml' path='doc/member[@name="_SecurityComplianceBitmask_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _SecurityComplianceBitmask_e__Union
    {
        /// <include file='_SecurityComplianceBitmask_e__Union.xml' path='doc/member[@name="_SecurityComplianceBitmask_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2075_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_SecurityComplianceBitmask_e__Union.xml' path='doc/member[@name="_SecurityComplianceBitmask_e__Union.AsUchar"]/*' />
        [FieldOffset(0)]
        public byte AsUchar;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FIPS"]/*' />
        public byte FIPS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.FIPS;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.FIPS = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Reserved = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public byte _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FIPS"]/*' />
            [NativeTypeName("byte : 1")]
            public byte FIPS
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)(_bitfield & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("byte : 7")]
            public byte Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)((_bitfield >> 1) & 0x7Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
                }
            }
        }
    }

    /// <include file='_CryptoCapabilities_e__FixedBuffer.xml' path='doc/member[@name="_CryptoCapabilities_e__FixedBuffer"]/*' />
    public partial struct _CryptoCapabilities_e__FixedBuffer
    {
        public STORAGE_CRYPTO_CAPABILITY_V2 e0;

        [UnscopedRef]
        public ref STORAGE_CRYPTO_CAPABILITY_V2 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_CRYPTO_CAPABILITY_V2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
