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
    public STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.KeyTypeBitmask"]/*' />
    public STORAGE_CRYPTO_KEY_TYPE KeyTypeBitmask;

    /// <include file='STORAGE_CRYPTO_DESCRIPTOR_V2.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR_V2.CryptoCapabilities"]/*' />
    [NativeTypeName("STORAGE_CRYPTO_CAPABILITY_V2[1]")]
    public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;

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
