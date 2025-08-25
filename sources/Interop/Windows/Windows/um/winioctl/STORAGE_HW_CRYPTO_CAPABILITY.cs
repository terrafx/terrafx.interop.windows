// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY"]/*' />
public partial struct STORAGE_HW_CRYPTO_CAPABILITY
{
    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.CryptoCapabilityIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint CryptoCapabilityIndex;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.AlgorithmId"]/*' />
    public STORAGE_CRYPTO_ALGORITHM_ID AlgorithmId;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.KeySize"]/*' />
    public STORAGE_CRYPTO_KEY_SIZE KeySize;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.DataUnitSizeBitmask"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataUnitSizeBitmask;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.MaxIVBitSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort MaxIVBitSize;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='STORAGE_HW_CRYPTO_CAPABILITY.xml' path='doc/member[@name="STORAGE_HW_CRYPTO_CAPABILITY.SecurityComplianceBitmask"]/*' />
    public STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask;
}
