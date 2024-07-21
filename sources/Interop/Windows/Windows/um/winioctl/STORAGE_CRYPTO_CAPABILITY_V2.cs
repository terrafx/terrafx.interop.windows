// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2"]/*' />
public partial struct STORAGE_CRYPTO_CAPABILITY_V2
{
    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.CryptoCapabilityIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint CryptoCapabilityIndex;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.AlgorithmId"]/*' />
    public STORAGE_CRYPTO_ALGORITHM_ID AlgorithmId;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.KeySize"]/*' />
    public STORAGE_CRYPTO_KEY_SIZE KeySize;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.DataUnitSizeBitmask"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataUnitSizeBitmask;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.MaxIVBitSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort MaxIVBitSize;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='STORAGE_CRYPTO_CAPABILITY_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_CAPABILITY_V2.SecurityComplianceBitmask"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L1976_C5")]
    public _SecurityComplianceBitmask_e__Union SecurityComplianceBitmask;

    /// <include file='_SecurityComplianceBitmask_e__Union.xml' path='doc/member[@name="_SecurityComplianceBitmask_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _SecurityComplianceBitmask_e__Union
    {
        /// <include file='_SecurityComplianceBitmask_e__Union.xml' path='doc/member[@name="_SecurityComplianceBitmask_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L1977_C9")]
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
}
