// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR"]/*' />
public partial struct STORAGE_HW_CRYPTO_DESCRIPTOR
{
    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.Header"]/*' />
    public STORAGE_DESCRIPTOR_HEADER Header;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.NumKeysSupported"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumKeysSupported;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.NumCryptoCapabilities"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumCryptoCapabilities;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.OffsetToCryptoCapabilities"]/*' />
    [NativeTypeName("DWORD")]
    public uint OffsetToCryptoCapabilities;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.SizeOfCryptoCapability"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfCryptoCapability;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.IceType"]/*' />
    public STORAGE_ICE_TYPE IceType;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.SecurityComplianceBitmask"]/*' />
    public STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask;

    /// <include file='STORAGE_HW_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_DESCRIPTOR.KeyTypeBitmask"]/*' />
    public STORAGE_CRYPTO_KEY_TYPE KeyTypeBitmask;
}
