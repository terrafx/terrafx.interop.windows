// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class PKCS12
{
    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_IMPORT_SILENT"]/*' />
    [NativeTypeName("#define PKCS12_IMPORT_SILENT 0x00000040")]
    public const int PKCS12_IMPORT_SILENT = 0x00000040;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PREFER_CNG_KSP"]/*' />
    [NativeTypeName("#define PKCS12_PREFER_CNG_KSP 0x00000100")]
    public const int PKCS12_PREFER_CNG_KSP = 0x00000100;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ALWAYS_CNG_KSP"]/*' />
    [NativeTypeName("#define PKCS12_ALWAYS_CNG_KSP 0x00000200")]
    public const int PKCS12_ALWAYS_CNG_KSP = 0x00000200;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ONLY_CERTIFICATES"]/*' />
    [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES 0x00000400")]
    public const int PKCS12_ONLY_CERTIFICATES = 0x00000400;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES"]/*' />
    [NativeTypeName("#define PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES 0x00000800")]
    public const int PKCS12_ONLY_NOT_ENCRYPTED_CERTIFICATES = 0x00000800;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ALLOW_OVERWRITE_KEY"]/*' />
    [NativeTypeName("#define PKCS12_ALLOW_OVERWRITE_KEY 0x00004000")]
    public const int PKCS12_ALLOW_OVERWRITE_KEY = 0x00004000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_NO_PERSIST_KEY"]/*' />
    [NativeTypeName("#define PKCS12_NO_PERSIST_KEY 0x00008000")]
    public const int PKCS12_NO_PERSIST_KEY = 0x00008000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_VIRTUAL_ISOLATION_KEY"]/*' />
    [NativeTypeName("#define PKCS12_VIRTUAL_ISOLATION_KEY 0x00010000")]
    public const int PKCS12_VIRTUAL_ISOLATION_KEY = 0x00010000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_IMPORT_RESERVED_MASK"]/*' />
    [NativeTypeName("#define PKCS12_IMPORT_RESERVED_MASK 0xffff0000")]
    public const uint PKCS12_IMPORT_RESERVED_MASK = 0xffff0000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_NAMED_NO_PERSIST_KEY"]/*' />
    [NativeTypeName("#define PKCS12_NAMED_NO_PERSIST_KEY 0x00020000")]
    public const int PKCS12_NAMED_NO_PERSIST_KEY = 0x00020000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS"]/*' />
    [NativeTypeName("#define PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS ( PKCS12_ALWAYS_CNG_KSP               |   \\\r\n                PKCS12_NO_PERSIST_KEY               |   \\\r\n                PKCS12_IMPORT_SILENT                |   \\\r\n                PKCS12_INCLUDE_EXTENDED_PROPERTIES  )")]
    public const int PKCS12_OBJECT_LOCATOR_ALL_IMPORT_FLAGS = (0x00000200 | 0x00008000 | 0x00000040 | 0x0010);

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE"]/*' />
    [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE 0")]
    public const int PKCS12_ONLY_CERTIFICATES_PROVIDER_TYPE = 0;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME"]/*' />
    [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME L\"PfxProvider\"")]
    public const string PKCS12_ONLY_CERTIFICATES_PROVIDER_NAME = "PfxProvider";

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME"]/*' />
    [NativeTypeName("#define PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME L\"PfxContainer\"")]
    public const string PKCS12_ONLY_CERTIFICATES_CONTAINER_NAME = "PfxContainer";

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_INCLUDE_EXTENDED_PROPERTIES"]/*' />
    [NativeTypeName("#define PKCS12_INCLUDE_EXTENDED_PROPERTIES 0x0010")]
    public const int PKCS12_INCLUDE_EXTENDED_PROPERTIES = 0x0010;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PROTECT_TO_DOMAIN_SIDS"]/*' />
    [NativeTypeName("#define PKCS12_PROTECT_TO_DOMAIN_SIDS 0x0020")]
    public const int PKCS12_PROTECT_TO_DOMAIN_SIDS = 0x0020;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_EXPORT_SILENT"]/*' />
    [NativeTypeName("#define PKCS12_EXPORT_SILENT 0x0040")]
    public const int PKCS12_EXPORT_SILENT = 0x0040;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_EXPORT_PBES2_PARAMS"]/*' />
    [NativeTypeName("#define PKCS12_EXPORT_PBES2_PARAMS 0x0080")]
    public const int PKCS12_EXPORT_PBES2_PARAMS = 0x0080;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_DISABLE_ENCRYPT_CERTIFICATES"]/*' />
    [NativeTypeName("#define PKCS12_DISABLE_ENCRYPT_CERTIFICATES 0x0100")]
    public const int PKCS12_DISABLE_ENCRYPT_CERTIFICATES = 0x0100;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ENCRYPT_CERTIFICATES"]/*' />
    [NativeTypeName("#define PKCS12_ENCRYPT_CERTIFICATES 0x0200")]
    public const int PKCS12_ENCRYPT_CERTIFICATES = 0x0200;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_EXPORT_ECC_CURVE_PARAMETERS"]/*' />
    [NativeTypeName("#define PKCS12_EXPORT_ECC_CURVE_PARAMETERS 0x1000")]
    public const int PKCS12_EXPORT_ECC_CURVE_PARAMETERS = 0x1000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_EXPORT_ECC_CURVE_OID"]/*' />
    [NativeTypeName("#define PKCS12_EXPORT_ECC_CURVE_OID 0x2000")]
    public const int PKCS12_EXPORT_ECC_CURVE_OID = 0x2000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_EXPORT_RESERVED_MASK"]/*' />
    [NativeTypeName("#define PKCS12_EXPORT_RESERVED_MASK 0xffff0000")]
    public const uint PKCS12_EXPORT_RESERVED_MASK = 0xffff0000;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PBKDF2_ID_HMAC_SHA1"]/*' />
    [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA1 \"1.2.840.113549.2.7\"")]
    public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA1 => "1.2.840.113549.2.7"u8;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PBKDF2_ID_HMAC_SHA256"]/*' />
    [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA256 \"1.2.840.113549.2.9\"")]
    public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA256 => "1.2.840.113549.2.9"u8;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PBKDF2_ID_HMAC_SHA384"]/*' />
    [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA384 \"1.2.840.113549.2.10\"")]
    public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA384 => "1.2.840.113549.2.10"u8;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PBKDF2_ID_HMAC_SHA512"]/*' />
    [NativeTypeName("#define PKCS12_PBKDF2_ID_HMAC_SHA512 \"1.2.840.113549.2.11\"")]
    public static ReadOnlySpan<byte> PKCS12_PBKDF2_ID_HMAC_SHA512 => "1.2.840.113549.2.11"u8;

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_PBES2_ALG_AES256_SHA256"]/*' />
    [NativeTypeName("#define PKCS12_PBES2_ALG_AES256_SHA256 L\"AES256-SHA256\"")]
    public const string PKCS12_PBES2_ALG_AES256_SHA256 = "AES256-SHA256";

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_CONFIG_REGPATH"]/*' />
    [NativeTypeName("#define PKCS12_CONFIG_REGPATH L\"Software\\Microsoft\\Windows\\CurrentVersion\\PFX\"")]
    public const string PKCS12_CONFIG_REGPATH = "Software\\Microsoft\\Windows\\CurrentVersion\\PFX";

    /// <include file='PKCS12.xml' path='doc/member[@name="PKCS12.PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME"]/*' />
    [NativeTypeName("#define PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME L\"EncryptCertificates\"")]
    public const string PKCS12_ENCRYPT_CERTIFICATES_VALUE_NAME = "EncryptCertificates";
}
