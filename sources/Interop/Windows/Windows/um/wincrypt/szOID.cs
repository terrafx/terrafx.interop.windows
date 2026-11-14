// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class szOID
{
    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA"]/*' />
    [NativeTypeName("#define szOID_RSA \"1.2.840.113549\"")]
    public static ReadOnlySpan<byte> szOID_RSA => "1.2.840.113549"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS"]/*' />
    [NativeTypeName("#define szOID_PKCS \"1.2.840.113549.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS => "1.2.840.113549.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_HASH"]/*' />
    [NativeTypeName("#define szOID_RSA_HASH \"1.2.840.113549.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_HASH => "1.2.840.113549.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_ENCRYPT"]/*' />
    [NativeTypeName("#define szOID_RSA_ENCRYPT \"1.2.840.113549.3\"")]
    public static ReadOnlySpan<byte> szOID_RSA_ENCRYPT => "1.2.840.113549.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_1"]/*' />
    [NativeTypeName("#define szOID_PKCS_1 \"1.2.840.113549.1.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_1 => "1.2.840.113549.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_2"]/*' />
    [NativeTypeName("#define szOID_PKCS_2 \"1.2.840.113549.1.2\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_2 => "1.2.840.113549.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_3"]/*' />
    [NativeTypeName("#define szOID_PKCS_3 \"1.2.840.113549.1.3\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_3 => "1.2.840.113549.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_4"]/*' />
    [NativeTypeName("#define szOID_PKCS_4 \"1.2.840.113549.1.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_4 => "1.2.840.113549.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_5"]/*' />
    [NativeTypeName("#define szOID_PKCS_5 \"1.2.840.113549.1.5\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_5 => "1.2.840.113549.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_6"]/*' />
    [NativeTypeName("#define szOID_PKCS_6 \"1.2.840.113549.1.6\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_6 => "1.2.840.113549.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7"]/*' />
    [NativeTypeName("#define szOID_PKCS_7 \"1.2.840.113549.1.7\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7 => "1.2.840.113549.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_8"]/*' />
    [NativeTypeName("#define szOID_PKCS_8 \"1.2.840.113549.1.8\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_8 => "1.2.840.113549.1.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_9"]/*' />
    [NativeTypeName("#define szOID_PKCS_9 \"1.2.840.113549.1.9\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_9 => "1.2.840.113549.1.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_10"]/*' />
    [NativeTypeName("#define szOID_PKCS_10 \"1.2.840.113549.1.10\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_10 => "1.2.840.113549.1.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12"]/*' />
    [NativeTypeName("#define szOID_PKCS_12 \"1.2.840.113549.1.12\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12 => "1.2.840.113549.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_RSA \"1.2.840.113549.1.1.1\"")]
    public static ReadOnlySpan<byte> szOID_RSA_RSA => "1.2.840.113549.1.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD2RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_MD2RSA \"1.2.840.113549.1.1.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD2RSA => "1.2.840.113549.1.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD4RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_MD4RSA \"1.2.840.113549.1.1.3\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD4RSA => "1.2.840.113549.1.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD5RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_MD5RSA \"1.2.840.113549.1.1.4\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD5RSA => "1.2.840.113549.1.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SHA1RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_SHA1RSA \"1.2.840.113549.1.1.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SHA1RSA => "1.2.840.113549.1.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SETOAEP_RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_SETOAEP_RSA \"1.2.840.113549.1.1.6\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SETOAEP_RSA => "1.2.840.113549.1.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSAES_OAEP"]/*' />
    [NativeTypeName("#define szOID_RSAES_OAEP \"1.2.840.113549.1.1.7\"")]
    public static ReadOnlySpan<byte> szOID_RSAES_OAEP => "1.2.840.113549.1.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MGF1"]/*' />
    [NativeTypeName("#define szOID_RSA_MGF1 \"1.2.840.113549.1.1.8\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MGF1 => "1.2.840.113549.1.1.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_PSPECIFIED"]/*' />
    [NativeTypeName("#define szOID_RSA_PSPECIFIED \"1.2.840.113549.1.1.9\"")]
    public static ReadOnlySpan<byte> szOID_RSA_PSPECIFIED => "1.2.840.113549.1.1.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SSA_PSS"]/*' />
    [NativeTypeName("#define szOID_RSA_SSA_PSS \"1.2.840.113549.1.1.10\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SSA_PSS => "1.2.840.113549.1.1.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SHA256RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_SHA256RSA \"1.2.840.113549.1.1.11\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SHA256RSA => "1.2.840.113549.1.1.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SHA384RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_SHA384RSA \"1.2.840.113549.1.1.12\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SHA384RSA => "1.2.840.113549.1.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SHA512RSA"]/*' />
    [NativeTypeName("#define szOID_RSA_SHA512RSA \"1.2.840.113549.1.1.13\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SHA512RSA => "1.2.840.113549.1.1.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_DH"]/*' />
    [NativeTypeName("#define szOID_RSA_DH \"1.2.840.113549.1.3.1\"")]
    public static ReadOnlySpan<byte> szOID_RSA_DH => "1.2.840.113549.1.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_data"]/*' />
    [NativeTypeName("#define szOID_RSA_data \"1.2.840.113549.1.7.1\"")]
    public static ReadOnlySpan<byte> szOID_RSA_data => "1.2.840.113549.1.7.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_signedData"]/*' />
    [NativeTypeName("#define szOID_RSA_signedData \"1.2.840.113549.1.7.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_signedData => "1.2.840.113549.1.7.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_envelopedData"]/*' />
    [NativeTypeName("#define szOID_RSA_envelopedData \"1.2.840.113549.1.7.3\"")]
    public static ReadOnlySpan<byte> szOID_RSA_envelopedData => "1.2.840.113549.1.7.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_authEnvelopedData"]/*' />
    [NativeTypeName("#define szOID_RSA_authEnvelopedData \"1.2.840.113549.1.9.16.1.23\"")]
    public static ReadOnlySpan<byte> szOID_RSA_authEnvelopedData => "1.2.840.113549.1.9.16.1.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_signEnvData"]/*' />
    [NativeTypeName("#define szOID_RSA_signEnvData \"1.2.840.113549.1.7.4\"")]
    public static ReadOnlySpan<byte> szOID_RSA_signEnvData => "1.2.840.113549.1.7.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_digestedData"]/*' />
    [NativeTypeName("#define szOID_RSA_digestedData \"1.2.840.113549.1.7.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_digestedData => "1.2.840.113549.1.7.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_hashedData"]/*' />
    [NativeTypeName("#define szOID_RSA_hashedData \"1.2.840.113549.1.7.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_hashedData => "1.2.840.113549.1.7.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_encryptedData"]/*' />
    [NativeTypeName("#define szOID_RSA_encryptedData \"1.2.840.113549.1.7.6\"")]
    public static ReadOnlySpan<byte> szOID_RSA_encryptedData => "1.2.840.113549.1.7.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_emailAddr"]/*' />
    [NativeTypeName("#define szOID_RSA_emailAddr \"1.2.840.113549.1.9.1\"")]
    public static ReadOnlySpan<byte> szOID_RSA_emailAddr => "1.2.840.113549.1.9.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_unstructName"]/*' />
    [NativeTypeName("#define szOID_RSA_unstructName \"1.2.840.113549.1.9.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_unstructName => "1.2.840.113549.1.9.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_contentType"]/*' />
    [NativeTypeName("#define szOID_RSA_contentType \"1.2.840.113549.1.9.3\"")]
    public static ReadOnlySpan<byte> szOID_RSA_contentType => "1.2.840.113549.1.9.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_messageDigest"]/*' />
    [NativeTypeName("#define szOID_RSA_messageDigest \"1.2.840.113549.1.9.4\"")]
    public static ReadOnlySpan<byte> szOID_RSA_messageDigest => "1.2.840.113549.1.9.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_signingTime"]/*' />
    [NativeTypeName("#define szOID_RSA_signingTime \"1.2.840.113549.1.9.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_signingTime => "1.2.840.113549.1.9.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_counterSign"]/*' />
    [NativeTypeName("#define szOID_RSA_counterSign \"1.2.840.113549.1.9.6\"")]
    public static ReadOnlySpan<byte> szOID_RSA_counterSign => "1.2.840.113549.1.9.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_challengePwd"]/*' />
    [NativeTypeName("#define szOID_RSA_challengePwd \"1.2.840.113549.1.9.7\"")]
    public static ReadOnlySpan<byte> szOID_RSA_challengePwd => "1.2.840.113549.1.9.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_unstructAddr"]/*' />
    [NativeTypeName("#define szOID_RSA_unstructAddr \"1.2.840.113549.1.9.8\"")]
    public static ReadOnlySpan<byte> szOID_RSA_unstructAddr => "1.2.840.113549.1.9.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_extCertAttrs"]/*' />
    [NativeTypeName("#define szOID_RSA_extCertAttrs \"1.2.840.113549.1.9.9\"")]
    public static ReadOnlySpan<byte> szOID_RSA_extCertAttrs => "1.2.840.113549.1.9.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_certExtensions"]/*' />
    [NativeTypeName("#define szOID_RSA_certExtensions \"1.2.840.113549.1.9.14\"")]
    public static ReadOnlySpan<byte> szOID_RSA_certExtensions => "1.2.840.113549.1.9.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SMIMECapabilities"]/*' />
    [NativeTypeName("#define szOID_RSA_SMIMECapabilities \"1.2.840.113549.1.9.15\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SMIMECapabilities => "1.2.840.113549.1.9.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_preferSignedData"]/*' />
    [NativeTypeName("#define szOID_RSA_preferSignedData \"1.2.840.113549.1.9.15.1\"")]
    public static ReadOnlySpan<byte> szOID_RSA_preferSignedData => "1.2.840.113549.1.9.15.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TIMESTAMP_TOKEN"]/*' />
    [NativeTypeName("#define szOID_TIMESTAMP_TOKEN \"1.2.840.113549.1.9.16.1.4\"")]
    public static ReadOnlySpan<byte> szOID_TIMESTAMP_TOKEN => "1.2.840.113549.1.9.16.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RFC3161_counterSign"]/*' />
    [NativeTypeName("#define szOID_RFC3161_counterSign \"1.3.6.1.4.1.311.3.3.1\"")]
    public static ReadOnlySpan<byte> szOID_RFC3161_counterSign => "1.3.6.1.4.1.311.3.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RFC3161v21_counterSign"]/*' />
    [NativeTypeName("#define szOID_RFC3161v21_counterSign \"1.3.6.1.4.1.311.3.3.2\"")]
    public static ReadOnlySpan<byte> szOID_RFC3161v21_counterSign => "1.3.6.1.4.1.311.3.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RFC3161v21_thumbprints"]/*' />
    [NativeTypeName("#define szOID_RFC3161v21_thumbprints \"1.3.6.1.4.1.311.3.3.3\"")]
    public static ReadOnlySpan<byte> szOID_RFC3161v21_thumbprints => "1.3.6.1.4.1.311.3.3.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SMIMEalg"]/*' />
    [NativeTypeName("#define szOID_RSA_SMIMEalg \"1.2.840.113549.1.9.16.3\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SMIMEalg => "1.2.840.113549.1.9.16.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SMIMEalgESDH"]/*' />
    [NativeTypeName("#define szOID_RSA_SMIMEalgESDH \"1.2.840.113549.1.9.16.3.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgESDH => "1.2.840.113549.1.9.16.3.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SMIMEalgCMS3DESwrap"]/*' />
    [NativeTypeName("#define szOID_RSA_SMIMEalgCMS3DESwrap \"1.2.840.113549.1.9.16.3.6\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgCMS3DESwrap => "1.2.840.113549.1.9.16.3.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_SMIMEalgCMSRC2wrap"]/*' />
    [NativeTypeName("#define szOID_RSA_SMIMEalgCMSRC2wrap \"1.2.840.113549.1.9.16.3.7\"")]
    public static ReadOnlySpan<byte> szOID_RSA_SMIMEalgCMSRC2wrap => "1.2.840.113549.1.9.16.3.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_HKDF_WITH_SHA256"]/*' />
    [NativeTypeName("#define szOID_RSA_HKDF_WITH_SHA256 \"1.2.840.113549.1.9.16.3.28\"")]
    public static ReadOnlySpan<byte> szOID_RSA_HKDF_WITH_SHA256 => "1.2.840.113549.1.9.16.3.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD2"]/*' />
    [NativeTypeName("#define szOID_RSA_MD2 \"1.2.840.113549.2.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD2 => "1.2.840.113549.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD4"]/*' />
    [NativeTypeName("#define szOID_RSA_MD4 \"1.2.840.113549.2.4\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD4 => "1.2.840.113549.2.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_MD5"]/*' />
    [NativeTypeName("#define szOID_RSA_MD5 \"1.2.840.113549.2.5\"")]
    public static ReadOnlySpan<byte> szOID_RSA_MD5 => "1.2.840.113549.2.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_RC2CBC"]/*' />
    [NativeTypeName("#define szOID_RSA_RC2CBC \"1.2.840.113549.3.2\"")]
    public static ReadOnlySpan<byte> szOID_RSA_RC2CBC => "1.2.840.113549.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_RC4"]/*' />
    [NativeTypeName("#define szOID_RSA_RC4 \"1.2.840.113549.3.4\"")]
    public static ReadOnlySpan<byte> szOID_RSA_RC4 => "1.2.840.113549.3.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_DES_EDE3_CBC"]/*' />
    [NativeTypeName("#define szOID_RSA_DES_EDE3_CBC \"1.2.840.113549.3.7\"")]
    public static ReadOnlySpan<byte> szOID_RSA_DES_EDE3_CBC => "1.2.840.113549.3.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RSA_RC5_CBCPad"]/*' />
    [NativeTypeName("#define szOID_RSA_RC5_CBCPad \"1.2.840.113549.3.9\"")]
    public static ReadOnlySpan<byte> szOID_RSA_RC5_CBCPad => "1.2.840.113549.3.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ANSI_X942"]/*' />
    [NativeTypeName("#define szOID_ANSI_X942 \"1.2.840.10046\"")]
    public static ReadOnlySpan<byte> szOID_ANSI_X942 => "1.2.840.10046"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ANSI_X942_DH"]/*' />
    [NativeTypeName("#define szOID_ANSI_X942_DH \"1.2.840.10046.2.1\"")]
    public static ReadOnlySpan<byte> szOID_ANSI_X942_DH => "1.2.840.10046.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_X957"]/*' />
    [NativeTypeName("#define szOID_X957 \"1.2.840.10040\"")]
    public static ReadOnlySpan<byte> szOID_X957 => "1.2.840.10040"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_X957_DSA"]/*' />
    [NativeTypeName("#define szOID_X957_DSA \"1.2.840.10040.4.1\"")]
    public static ReadOnlySpan<byte> szOID_X957_DSA => "1.2.840.10040.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_X957_SHA1DSA"]/*' />
    [NativeTypeName("#define szOID_X957_SHA1DSA \"1.2.840.10040.4.3\"")]
    public static ReadOnlySpan<byte> szOID_X957_SHA1DSA => "1.2.840.10040.4.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define szOID_ECC_PUBLIC_KEY \"1.2.840.10045.2.1\"")]
    public static ReadOnlySpan<byte> szOID_ECC_PUBLIC_KEY => "1.2.840.10045.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_P256"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_P256 \"1.2.840.10045.3.1.7\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_P256 => "1.2.840.10045.3.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_P384"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_P384 \"1.3.132.0.34\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_P384 => "1.3.132.0.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_P521"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_P521 \"1.3.132.0.35\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_P521 => "1.3.132.0.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP160R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP160R1 \"1.3.36.3.3.2.8.1.1.1\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP160R1 => "1.3.36.3.3.2.8.1.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP160T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP160T1 \"1.3.36.3.3.2.8.1.1.2\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP160T1 => "1.3.36.3.3.2.8.1.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP192R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP192R1 \"1.3.36.3.3.2.8.1.1.3\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP192R1 => "1.3.36.3.3.2.8.1.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP192T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP192T1 \"1.3.36.3.3.2.8.1.1.4\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP192T1 => "1.3.36.3.3.2.8.1.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP224R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP224R1 \"1.3.36.3.3.2.8.1.1.5\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP224R1 => "1.3.36.3.3.2.8.1.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP224T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP224T1 \"1.3.36.3.3.2.8.1.1.6\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP224T1 => "1.3.36.3.3.2.8.1.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP256R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP256R1 \"1.3.36.3.3.2.8.1.1.7\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP256R1 => "1.3.36.3.3.2.8.1.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP256T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP256T1 \"1.3.36.3.3.2.8.1.1.8\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP256T1 => "1.3.36.3.3.2.8.1.1.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP320R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP320R1 \"1.3.36.3.3.2.8.1.1.9\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP320R1 => "1.3.36.3.3.2.8.1.1.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP320T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP320T1 \"1.3.36.3.3.2.8.1.1.10\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP320T1 => "1.3.36.3.3.2.8.1.1.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP384R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP384R1 \"1.3.36.3.3.2.8.1.1.11\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP384R1 => "1.3.36.3.3.2.8.1.1.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP384T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP384T1 \"1.3.36.3.3.2.8.1.1.12\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP384T1 => "1.3.36.3.3.2.8.1.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP512R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP512R1 \"1.3.36.3.3.2.8.1.1.13\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP512R1 => "1.3.36.3.3.2.8.1.1.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_BRAINPOOLP512T1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_BRAINPOOLP512T1 \"1.3.36.3.3.2.8.1.1.14\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_BRAINPOOLP512T1 => "1.3.36.3.3.2.8.1.1.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_EC192WAPI"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_EC192WAPI \"1.2.156.11235.1.1.2.1\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_EC192WAPI => "1.2.156.11235.1.1.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CN_ECDSA_SHA256"]/*' />
    [NativeTypeName("#define szOID_CN_ECDSA_SHA256 \"1.2.156.11235.1.1.1\"")]
    public static ReadOnlySpan<byte> szOID_CN_ECDSA_SHA256 => "1.2.156.11235.1.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_NISTP192"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_NISTP192 \"1.2.840.10045.3.1.1\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP192 => "1.2.840.10045.3.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_NISTP224"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_NISTP224 \"1.3.132.0.33\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP224 => "1.3.132.0.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_NISTP256"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_NISTP256 szOID_ECC_CURVE_P256")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP256 => "1.2.840.10045.3.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_NISTP384"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_NISTP384 szOID_ECC_CURVE_P384")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP384 => "1.3.132.0.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_NISTP521"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_NISTP521 szOID_ECC_CURVE_P521")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_NISTP521 => "1.3.132.0.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP160K1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP160K1 \"1.3.132.0.9\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160K1 => "1.3.132.0.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP160R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP160R1 \"1.3.132.0.8\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160R1 => "1.3.132.0.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP160R2"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP160R2 \"1.3.132.0.30\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP160R2 => "1.3.132.0.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP192K1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP192K1 \"1.3.132.0.31\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP192K1 => "1.3.132.0.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP192R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP192R1 szOID_ECC_CURVE_NISTP192")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP192R1 => "1.2.840.10045.3.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP224K1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP224K1 \"1.3.132.0.32\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP224K1 => "1.3.132.0.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP224R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP224R1 szOID_ECC_CURVE_NISTP224")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP224R1 => "1.3.132.0.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP256K1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP256K1 \"1.3.132.0.10\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP256K1 => "1.3.132.0.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP256R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP256R1 szOID_ECC_CURVE_P256")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP256R1 => "1.2.840.10045.3.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP384R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP384R1 szOID_ECC_CURVE_P384")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP384R1 => "1.3.132.0.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_SECP521R1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_SECP521R1 szOID_ECC_CURVE_P521")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_SECP521R1 => "1.3.132.0.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_WTLS7"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_WTLS7 szOID_ECC_CURVE_SECP160R2")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS7 => "1.3.132.0.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_WTLS9"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_WTLS9 \"2.23.43.1.4.9\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS9 => "2.23.43.1.4.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_WTLS12"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_WTLS12 szOID_ECC_CURVE_NISTP224")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_WTLS12 => "1.3.132.0.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P192V1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P192V1 \"1.2.840.10045.3.1.1\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V1 => "1.2.840.10045.3.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P192V2"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P192V2 \"1.2.840.10045.3.1.2\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V2 => "1.2.840.10045.3.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P192V3"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P192V3 \"1.2.840.10045.3.1.3\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P192V3 => "1.2.840.10045.3.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P239V1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P239V1 \"1.2.840.10045.3.1.4\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V1 => "1.2.840.10045.3.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P239V2"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P239V2 \"1.2.840.10045.3.1.5\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V2 => "1.2.840.10045.3.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P239V3"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P239V3 \"1.2.840.10045.3.1.6\"")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P239V3 => "1.2.840.10045.3.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECC_CURVE_X962P256V1"]/*' />
    [NativeTypeName("#define szOID_ECC_CURVE_X962P256V1 szOID_ECC_CURVE_P256")]
    public static ReadOnlySpan<byte> szOID_ECC_CURVE_X962P256V1 => "1.2.840.10045.3.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECDSA_SHA1"]/*' />
    [NativeTypeName("#define szOID_ECDSA_SHA1 \"1.2.840.10045.4.1\"")]
    public static ReadOnlySpan<byte> szOID_ECDSA_SHA1 => "1.2.840.10045.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECDSA_SPECIFIED"]/*' />
    [NativeTypeName("#define szOID_ECDSA_SPECIFIED \"1.2.840.10045.4.3\"")]
    public static ReadOnlySpan<byte> szOID_ECDSA_SPECIFIED => "1.2.840.10045.4.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECDSA_SHA256"]/*' />
    [NativeTypeName("#define szOID_ECDSA_SHA256 \"1.2.840.10045.4.3.2\"")]
    public static ReadOnlySpan<byte> szOID_ECDSA_SHA256 => "1.2.840.10045.4.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECDSA_SHA384"]/*' />
    [NativeTypeName("#define szOID_ECDSA_SHA384 \"1.2.840.10045.4.3.3\"")]
    public static ReadOnlySpan<byte> szOID_ECDSA_SHA384 => "1.2.840.10045.4.3.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ECDSA_SHA512"]/*' />
    [NativeTypeName("#define szOID_ECDSA_SHA512 \"1.2.840.10045.4.3.4\"")]
    public static ReadOnlySpan<byte> szOID_ECDSA_SHA512 => "1.2.840.10045.4.3.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES128_CBC"]/*' />
    [NativeTypeName("#define szOID_NIST_AES128_CBC \"2.16.840.1.101.3.4.1.2\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES128_CBC => "2.16.840.1.101.3.4.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES192_CBC"]/*' />
    [NativeTypeName("#define szOID_NIST_AES192_CBC \"2.16.840.1.101.3.4.1.22\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES192_CBC => "2.16.840.1.101.3.4.1.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES256_CBC"]/*' />
    [NativeTypeName("#define szOID_NIST_AES256_CBC \"2.16.840.1.101.3.4.1.42\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES256_CBC => "2.16.840.1.101.3.4.1.42"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES128_WRAP"]/*' />
    [NativeTypeName("#define szOID_NIST_AES128_WRAP \"2.16.840.1.101.3.4.1.5\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES128_WRAP => "2.16.840.1.101.3.4.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES192_WRAP"]/*' />
    [NativeTypeName("#define szOID_NIST_AES192_WRAP \"2.16.840.1.101.3.4.1.25\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES192_WRAP => "2.16.840.1.101.3.4.1.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES256_WRAP"]/*' />
    [NativeTypeName("#define szOID_NIST_AES256_WRAP \"2.16.840.1.101.3.4.1.45\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES256_WRAP => "2.16.840.1.101.3.4.1.45"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES128_CCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES128_CCM \"2.16.840.1.101.3.4.1.7\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES128_CCM => "2.16.840.1.101.3.4.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES192_CCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES192_CCM \"2.16.840.1.101.3.4.1.27\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES192_CCM => "2.16.840.1.101.3.4.1.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES256_CCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES256_CCM \"2.16.840.1.101.3.4.1.47\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES256_CCM => "2.16.840.1.101.3.4.1.47"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES128_GCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES128_GCM \"2.16.840.1.101.3.4.1.6\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES128_GCM => "2.16.840.1.101.3.4.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES192_GCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES192_GCM \"2.16.840.1.101.3.4.1.67\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES192_GCM => "2.16.840.1.101.3.4.1.67"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_AES256_GCM"]/*' />
    [NativeTypeName("#define szOID_NIST_AES256_GCM \"2.16.840.1.101.3.4.1.46\"")]
    public static ReadOnlySpan<byte> szOID_NIST_AES256_GCM => "2.16.840.1.101.3.4.1.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF"]/*' />
    [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF \"1.3.133.16.840.63.0.2\"")]
    public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA1_KDF => "1.3.133.16.840.63.0.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF"]/*' />
    [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF \"1.3.132.1.11.1\"")]
    public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA256_KDF => "1.3.132.1.11.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF"]/*' />
    [NativeTypeName("#define szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF \"1.3.132.1.11.2\"")]
    public static ReadOnlySpan<byte> szOID_DH_SINGLE_PASS_STDDH_SHA384_KDF => "1.3.132.1.11.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DS"]/*' />
    [NativeTypeName("#define szOID_DS \"2.5\"")]
    public static ReadOnlySpan<byte> szOID_DS => "2.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DSALG"]/*' />
    [NativeTypeName("#define szOID_DSALG \"2.5.8\"")]
    public static ReadOnlySpan<byte> szOID_DSALG => "2.5.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DSALG_CRPT"]/*' />
    [NativeTypeName("#define szOID_DSALG_CRPT \"2.5.8.1\"")]
    public static ReadOnlySpan<byte> szOID_DSALG_CRPT => "2.5.8.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DSALG_HASH"]/*' />
    [NativeTypeName("#define szOID_DSALG_HASH \"2.5.8.2\"")]
    public static ReadOnlySpan<byte> szOID_DSALG_HASH => "2.5.8.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DSALG_SIGN"]/*' />
    [NativeTypeName("#define szOID_DSALG_SIGN \"2.5.8.3\"")]
    public static ReadOnlySpan<byte> szOID_DSALG_SIGN => "2.5.8.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DSALG_RSA"]/*' />
    [NativeTypeName("#define szOID_DSALG_RSA \"2.5.8.1.1\"")]
    public static ReadOnlySpan<byte> szOID_DSALG_RSA => "2.5.8.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIW"]/*' />
    [NativeTypeName("#define szOID_OIW \"1.3.14\"")]
    public static ReadOnlySpan<byte> szOID_OIW => "1.3.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC"]/*' />
    [NativeTypeName("#define szOID_OIWSEC \"1.3.14.3.2\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC => "1.3.14.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_md4RSA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_md4RSA \"1.3.14.3.2.2\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_md4RSA => "1.3.14.3.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_md5RSA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_md5RSA \"1.3.14.3.2.3\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_md5RSA => "1.3.14.3.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_md4RSA2"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_md4RSA2 \"1.3.14.3.2.4\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_md4RSA2 => "1.3.14.3.2.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desECB"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desECB \"1.3.14.3.2.6\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desECB => "1.3.14.3.2.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desCBC"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desCBC \"1.3.14.3.2.7\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desCBC => "1.3.14.3.2.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desOFB"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desOFB \"1.3.14.3.2.8\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desOFB => "1.3.14.3.2.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desCFB"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desCFB \"1.3.14.3.2.9\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desCFB => "1.3.14.3.2.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desMAC"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desMAC \"1.3.14.3.2.10\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desMAC => "1.3.14.3.2.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_rsaSign"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_rsaSign \"1.3.14.3.2.11\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_rsaSign => "1.3.14.3.2.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dsa"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dsa \"1.3.14.3.2.12\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dsa => "1.3.14.3.2.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_shaDSA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_shaDSA \"1.3.14.3.2.13\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_shaDSA => "1.3.14.3.2.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_mdc2RSA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_mdc2RSA \"1.3.14.3.2.14\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_mdc2RSA => "1.3.14.3.2.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_shaRSA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_shaRSA \"1.3.14.3.2.15\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_shaRSA => "1.3.14.3.2.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dhCommMod"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dhCommMod \"1.3.14.3.2.16\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dhCommMod => "1.3.14.3.2.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_desEDE"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_desEDE \"1.3.14.3.2.17\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_desEDE => "1.3.14.3.2.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_sha"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_sha \"1.3.14.3.2.18\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_sha => "1.3.14.3.2.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_mdc2"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_mdc2 \"1.3.14.3.2.19\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_mdc2 => "1.3.14.3.2.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dsaComm"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dsaComm \"1.3.14.3.2.20\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dsaComm => "1.3.14.3.2.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dsaCommSHA"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dsaCommSHA \"1.3.14.3.2.21\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dsaCommSHA => "1.3.14.3.2.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_rsaXchg"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_rsaXchg \"1.3.14.3.2.22\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_rsaXchg => "1.3.14.3.2.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_keyHashSeal"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_keyHashSeal \"1.3.14.3.2.23\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_keyHashSeal => "1.3.14.3.2.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_md2RSASign"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_md2RSASign \"1.3.14.3.2.24\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_md2RSASign => "1.3.14.3.2.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_md5RSASign"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_md5RSASign \"1.3.14.3.2.25\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_md5RSASign => "1.3.14.3.2.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_sha1"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_sha1 \"1.3.14.3.2.26\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_sha1 => "1.3.14.3.2.26"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dsaSHA1"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dsaSHA1 \"1.3.14.3.2.27\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dsaSHA1 => "1.3.14.3.2.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_dsaCommSHA1"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_dsaCommSHA1 \"1.3.14.3.2.28\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_dsaCommSHA1 => "1.3.14.3.2.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWSEC_sha1RSASign"]/*' />
    [NativeTypeName("#define szOID_OIWSEC_sha1RSASign \"1.3.14.3.2.29\"")]
    public static ReadOnlySpan<byte> szOID_OIWSEC_sha1RSASign => "1.3.14.3.2.29"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR"]/*' />
    [NativeTypeName("#define szOID_OIWDIR \"1.3.14.7.2\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR => "1.3.14.7.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR_CRPT"]/*' />
    [NativeTypeName("#define szOID_OIWDIR_CRPT \"1.3.14.7.2.1\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR_CRPT => "1.3.14.7.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR_HASH"]/*' />
    [NativeTypeName("#define szOID_OIWDIR_HASH \"1.3.14.7.2.2\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR_HASH => "1.3.14.7.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR_SIGN"]/*' />
    [NativeTypeName("#define szOID_OIWDIR_SIGN \"1.3.14.7.2.3\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR_SIGN => "1.3.14.7.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR_md2"]/*' />
    [NativeTypeName("#define szOID_OIWDIR_md2 \"1.3.14.7.2.2.1\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR_md2 => "1.3.14.7.2.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OIWDIR_md2RSA"]/*' />
    [NativeTypeName("#define szOID_OIWDIR_md2RSA \"1.3.14.7.2.3.1\"")]
    public static ReadOnlySpan<byte> szOID_OIWDIR_md2RSA => "1.3.14.7.2.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC"]/*' />
    [NativeTypeName("#define szOID_INFOSEC \"2.16.840.1.101.2.1\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC => "2.16.840.1.101.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsSignature"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsSignature \"2.16.840.1.101.2.1.1.1\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsSignature => "2.16.840.1.101.2.1.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicSignature"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicSignature \"2.16.840.1.101.2.1.1.2\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicSignature => "2.16.840.1.101.2.1.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsConfidentiality"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsConfidentiality \"2.16.840.1.101.2.1.1.3\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsConfidentiality => "2.16.840.1.101.2.1.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicConfidentiality"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicConfidentiality \"2.16.840.1.101.2.1.1.4\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicConfidentiality => "2.16.840.1.101.2.1.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsIntegrity"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsIntegrity \"2.16.840.1.101.2.1.1.5\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsIntegrity => "2.16.840.1.101.2.1.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicIntegrity"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicIntegrity \"2.16.840.1.101.2.1.1.6\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicIntegrity => "2.16.840.1.101.2.1.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsTokenProtection"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsTokenProtection \"2.16.840.1.101.2.1.1.7\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsTokenProtection => "2.16.840.1.101.2.1.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicTokenProtection"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicTokenProtection \"2.16.840.1.101.2.1.1.8\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicTokenProtection => "2.16.840.1.101.2.1.1.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsKeyManagement"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsKeyManagement \"2.16.840.1.101.2.1.1.9\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsKeyManagement => "2.16.840.1.101.2.1.1.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicKeyManagement"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicKeyManagement \"2.16.840.1.101.2.1.1.10\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKeyManagement => "2.16.840.1.101.2.1.1.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_sdnsKMandSig"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_sdnsKMandSig \"2.16.840.1.101.2.1.1.11\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_sdnsKMandSig => "2.16.840.1.101.2.1.1.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicKMandSig"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicKMandSig \"2.16.840.1.101.2.1.1.12\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKMandSig => "2.16.840.1.101.2.1.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteASignature"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteASignature \"2.16.840.1.101.2.1.1.13\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteASignature => "2.16.840.1.101.2.1.1.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteAConfidentiality"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteAConfidentiality \"2.16.840.1.101.2.1.1.14\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAConfidentiality => "2.16.840.1.101.2.1.1.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteAIntegrity"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteAIntegrity \"2.16.840.1.101.2.1.1.15\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAIntegrity => "2.16.840.1.101.2.1.1.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteATokenProtection"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteATokenProtection \"2.16.840.1.101.2.1.1.16\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteATokenProtection => "2.16.840.1.101.2.1.1.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteAKeyManagement"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteAKeyManagement \"2.16.840.1.101.2.1.1.17\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAKeyManagement => "2.16.840.1.101.2.1.1.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_SuiteAKMandSig"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_SuiteAKMandSig \"2.16.840.1.101.2.1.1.18\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_SuiteAKMandSig => "2.16.840.1.101.2.1.1.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicUpdatedSig"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicUpdatedSig \"2.16.840.1.101.2.1.1.19\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicUpdatedSig => "2.16.840.1.101.2.1.1.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicKMandUpdSig"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicKMandUpdSig \"2.16.840.1.101.2.1.1.20\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicKMandUpdSig => "2.16.840.1.101.2.1.1.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INFOSEC_mosaicUpdatedInteg"]/*' />
    [NativeTypeName("#define szOID_INFOSEC_mosaicUpdatedInteg \"2.16.840.1.101.2.1.1.21\"")]
    public static ReadOnlySpan<byte> szOID_INFOSEC_mosaicUpdatedInteg => "2.16.840.1.101.2.1.1.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_sha256"]/*' />
    [NativeTypeName("#define szOID_NIST_sha256 \"2.16.840.1.101.3.4.2.1\"")]
    public static ReadOnlySpan<byte> szOID_NIST_sha256 => "2.16.840.1.101.3.4.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_sha384"]/*' />
    [NativeTypeName("#define szOID_NIST_sha384 \"2.16.840.1.101.3.4.2.2\"")]
    public static ReadOnlySpan<byte> szOID_NIST_sha384 => "2.16.840.1.101.3.4.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_sha512 \"2.16.840.1.101.3.4.2.3\"")]
    public static ReadOnlySpan<byte> szOID_NIST_sha512 => "2.16.840.1.101.3.4.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_shake128"]/*' />
    [NativeTypeName("#define szOID_NIST_shake128 \"2.16.840.1.101.3.4.2.11\"")]
    public static ReadOnlySpan<byte> szOID_NIST_shake128 => "2.16.840.1.101.3.4.2.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_shake256"]/*' />
    [NativeTypeName("#define szOID_NIST_shake256 \"2.16.840.1.101.3.4.2.12\"")]
    public static ReadOnlySpan<byte> szOID_NIST_shake256 => "2.16.840.1.101.3.4.2.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_dsa_44"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_dsa_44 \"2.16.840.1.101.3.4.3.17\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_dsa_44 => "2.16.840.1.101.3.4.3.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_dsa_65"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_dsa_65 \"2.16.840.1.101.3.4.3.18\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_dsa_65 => "2.16.840.1.101.3.4.3.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_dsa_87"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_dsa_87 \"2.16.840.1.101.3.4.3.19\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_dsa_87 => "2.16.840.1.101.3.4.3.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_ml_dsa_44_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_ml_dsa_44_with_sha512 \"2.16.840.1.101.3.4.3.32\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_ml_dsa_44_with_sha512 => "2.16.840.1.101.3.4.3.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_ml_dsa_65_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_ml_dsa_65_with_sha512 \"2.16.840.1.101.3.4.3.33\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_ml_dsa_65_with_sha512 => "2.16.840.1.101.3.4.3.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_ml_dsa_87_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_ml_dsa_87_with_sha512 \"2.16.840.1.101.3.4.3.34\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_ml_dsa_87_with_sha512 => "2.16.840.1.101.3.4.3.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_kem_512"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_kem_512 \"2.16.840.1.101.3.4.4.1\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_kem_512 => "2.16.840.1.101.3.4.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_kem_768"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_kem_768 \"2.16.840.1.101.3.4.4.2\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_kem_768 => "2.16.840.1.101.3.4.4.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_ml_kem_1024"]/*' />
    [NativeTypeName("#define szOID_NIST_ml_kem_1024 \"2.16.840.1.101.3.4.4.3\"")]
    public static ReadOnlySpan<byte> szOID_NIST_ml_kem_1024 => "2.16.840.1.101.3.4.4.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_128s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_128s \"2.16.840.1.101.3.4.3.20\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_128s => "2.16.840.1.101.3.4.3.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_128f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_128f \"2.16.840.1.101.3.4.3.21\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_128f => "2.16.840.1.101.3.4.3.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_192s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_192s \"2.16.840.1.101.3.4.3.22\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_192s => "2.16.840.1.101.3.4.3.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_192f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_192f \"2.16.840.1.101.3.4.3.23\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_192f => "2.16.840.1.101.3.4.3.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_256s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_256s \"2.16.840.1.101.3.4.3.24\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_256s => "2.16.840.1.101.3.4.3.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_sha2_256f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_sha2_256f \"2.16.840.1.101.3.4.3.25\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_sha2_256f => "2.16.840.1.101.3.4.3.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_128s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_128s \"2.16.840.1.101.3.4.3.26\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_128s => "2.16.840.1.101.3.4.3.26"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_128f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_128f \"2.16.840.1.101.3.4.3.27\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_128f => "2.16.840.1.101.3.4.3.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_192s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_192s \"2.16.840.1.101.3.4.3.28\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_192s => "2.16.840.1.101.3.4.3.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_192f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_192f \"2.16.840.1.101.3.4.3.29\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_192f => "2.16.840.1.101.3.4.3.29"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_256s"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_256s \"2.16.840.1.101.3.4.3.30\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_256s => "2.16.840.1.101.3.4.3.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_slh_dsa_shake_256f"]/*' />
    [NativeTypeName("#define szOID_NIST_slh_dsa_shake_256f \"2.16.840.1.101.3.4.3.31\"")]
    public static ReadOnlySpan<byte> szOID_NIST_slh_dsa_shake_256f => "2.16.840.1.101.3.4.3.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_128s_with_sha256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_128s_with_sha256 \"2.16.840.1.101.3.4.3.35\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_128s_with_sha256 => "2.16.840.1.101.3.4.3.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_128f_with_sha256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_128f_with_sha256 \"2.16.840.1.101.3.4.3.36\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_128f_with_sha256 => "2.16.840.1.101.3.4.3.36"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_192s_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_192s_with_sha512 \"2.16.840.1.101.3.4.3.37\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_192s_with_sha512 => "2.16.840.1.101.3.4.3.37"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_192f_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_192f_with_sha512 \"2.16.840.1.101.3.4.3.38\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_192f_with_sha512 => "2.16.840.1.101.3.4.3.38"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_256s_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_256s_with_sha512 \"2.16.840.1.101.3.4.3.39\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_256s_with_sha512 => "2.16.840.1.101.3.4.3.39"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_sha2_256f_with_sha512"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_sha2_256f_with_sha512 \"2.16.840.1.101.3.4.3.40\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_sha2_256f_with_sha512 => "2.16.840.1.101.3.4.3.40"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_128s_with_shake128"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_128s_with_shake128 \"2.16.840.1.101.3.4.3.41\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_128s_with_shake128 => "2.16.840.1.101.3.4.3.41"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_128f_with_shake128"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_128f_with_shake128 \"2.16.840.1.101.3.4.3.42\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_128f_with_shake128 => "2.16.840.1.101.3.4.3.42"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_192s_with_shake256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_192s_with_shake256 \"2.16.840.1.101.3.4.3.43\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_192s_with_shake256 => "2.16.840.1.101.3.4.3.43"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_192f_with_shake256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_192f_with_shake256 \"2.16.840.1.101.3.4.3.44\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_192f_with_shake256 => "2.16.840.1.101.3.4.3.44"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_256s_with_shake256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_256s_with_shake256 \"2.16.840.1.101.3.4.3.45\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_256s_with_shake256 => "2.16.840.1.101.3.4.3.45"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NIST_hash_slh_dsa_shake_256f_with_shake256"]/*' />
    [NativeTypeName("#define szOID_NIST_hash_slh_dsa_shake_256f_with_shake256 \"2.16.840.1.101.3.4.3.46\"")]
    public static ReadOnlySpan<byte> szOID_NIST_hash_slh_dsa_shake_256f_with_shake256 => "2.16.840.1.101.3.4.3.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLDSA44_ECDSA_P256_SHA256"]/*' />
    [NativeTypeName("#define szOID_MLDSA44_ECDSA_P256_SHA256 \"1.3.6.1.5.5.7.6.40\"")]
    public static ReadOnlySpan<byte> szOID_MLDSA44_ECDSA_P256_SHA256 => "1.3.6.1.5.5.7.6.40"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLDSA65_ECDSA_P256_SHA512"]/*' />
    [NativeTypeName("#define szOID_MLDSA65_ECDSA_P256_SHA512 \"1.3.6.1.5.5.7.6.45\"")]
    public static ReadOnlySpan<byte> szOID_MLDSA65_ECDSA_P256_SHA512 => "1.3.6.1.5.5.7.6.45"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLDSA65_ECDSA_P384_SHA512"]/*' />
    [NativeTypeName("#define szOID_MLDSA65_ECDSA_P384_SHA512 \"1.3.6.1.5.5.7.6.46\"")]
    public static ReadOnlySpan<byte> szOID_MLDSA65_ECDSA_P384_SHA512 => "1.3.6.1.5.5.7.6.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLDSA87_ECDSA_P384_SHA512"]/*' />
    [NativeTypeName("#define szOID_MLDSA87_ECDSA_P384_SHA512 \"1.3.6.1.5.5.7.6.49\"")]
    public static ReadOnlySpan<byte> szOID_MLDSA87_ECDSA_P384_SHA512 => "1.3.6.1.5.5.7.6.49"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLKEM768_X25519_SHA3_256"]/*' />
    [NativeTypeName("#define szOID_MLKEM768_X25519_SHA3_256 \"1.3.6.1.5.5.7.6.58\"")]
    public static ReadOnlySpan<byte> szOID_MLKEM768_X25519_SHA3_256 => "1.3.6.1.5.5.7.6.58"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLKEM768_ECDH_P256_SHA3_256"]/*' />
    [NativeTypeName("#define szOID_MLKEM768_ECDH_P256_SHA3_256 \"1.3.6.1.5.5.7.6.59\"")]
    public static ReadOnlySpan<byte> szOID_MLKEM768_ECDH_P256_SHA3_256 => "1.3.6.1.5.5.7.6.59"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MLKEM1024_ECDH_P384_SHA3_256"]/*' />
    [NativeTypeName("#define szOID_MLKEM1024_ECDH_P384_SHA3_256 \"1.3.6.1.5.5.7.6.63\"")]
    public static ReadOnlySpan<byte> szOID_MLKEM1024_ECDH_P384_SHA3_256 => "1.3.6.1.5.5.7.6.63"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_COMMON_NAME"]/*' />
    [NativeTypeName("#define szOID_COMMON_NAME \"2.5.4.3\"")]
    public static ReadOnlySpan<byte> szOID_COMMON_NAME => "2.5.4.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUR_NAME"]/*' />
    [NativeTypeName("#define szOID_SUR_NAME \"2.5.4.4\"")]
    public static ReadOnlySpan<byte> szOID_SUR_NAME => "2.5.4.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DEVICE_SERIAL_NUMBER"]/*' />
    [NativeTypeName("#define szOID_DEVICE_SERIAL_NUMBER \"2.5.4.5\"")]
    public static ReadOnlySpan<byte> szOID_DEVICE_SERIAL_NUMBER => "2.5.4.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_COUNTRY_NAME"]/*' />
    [NativeTypeName("#define szOID_COUNTRY_NAME \"2.5.4.6\"")]
    public static ReadOnlySpan<byte> szOID_COUNTRY_NAME => "2.5.4.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LOCALITY_NAME"]/*' />
    [NativeTypeName("#define szOID_LOCALITY_NAME \"2.5.4.7\"")]
    public static ReadOnlySpan<byte> szOID_LOCALITY_NAME => "2.5.4.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_STATE_OR_PROVINCE_NAME"]/*' />
    [NativeTypeName("#define szOID_STATE_OR_PROVINCE_NAME \"2.5.4.8\"")]
    public static ReadOnlySpan<byte> szOID_STATE_OR_PROVINCE_NAME => "2.5.4.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_STREET_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_STREET_ADDRESS \"2.5.4.9\"")]
    public static ReadOnlySpan<byte> szOID_STREET_ADDRESS => "2.5.4.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ORGANIZATION_NAME"]/*' />
    [NativeTypeName("#define szOID_ORGANIZATION_NAME \"2.5.4.10\"")]
    public static ReadOnlySpan<byte> szOID_ORGANIZATION_NAME => "2.5.4.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ORGANIZATIONAL_UNIT_NAME"]/*' />
    [NativeTypeName("#define szOID_ORGANIZATIONAL_UNIT_NAME \"2.5.4.11\"")]
    public static ReadOnlySpan<byte> szOID_ORGANIZATIONAL_UNIT_NAME => "2.5.4.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TITLE"]/*' />
    [NativeTypeName("#define szOID_TITLE \"2.5.4.12\"")]
    public static ReadOnlySpan<byte> szOID_TITLE => "2.5.4.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DESCRIPTION"]/*' />
    [NativeTypeName("#define szOID_DESCRIPTION \"2.5.4.13\"")]
    public static ReadOnlySpan<byte> szOID_DESCRIPTION => "2.5.4.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SEARCH_GUIDE"]/*' />
    [NativeTypeName("#define szOID_SEARCH_GUIDE \"2.5.4.14\"")]
    public static ReadOnlySpan<byte> szOID_SEARCH_GUIDE => "2.5.4.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BUSINESS_CATEGORY"]/*' />
    [NativeTypeName("#define szOID_BUSINESS_CATEGORY \"2.5.4.15\"")]
    public static ReadOnlySpan<byte> szOID_BUSINESS_CATEGORY => "2.5.4.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_POSTAL_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_POSTAL_ADDRESS \"2.5.4.16\"")]
    public static ReadOnlySpan<byte> szOID_POSTAL_ADDRESS => "2.5.4.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_POSTAL_CODE"]/*' />
    [NativeTypeName("#define szOID_POSTAL_CODE \"2.5.4.17\"")]
    public static ReadOnlySpan<byte> szOID_POSTAL_CODE => "2.5.4.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_POST_OFFICE_BOX"]/*' />
    [NativeTypeName("#define szOID_POST_OFFICE_BOX \"2.5.4.18\"")]
    public static ReadOnlySpan<byte> szOID_POST_OFFICE_BOX => "2.5.4.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PHYSICAL_DELIVERY_OFFICE_NAME"]/*' />
    [NativeTypeName("#define szOID_PHYSICAL_DELIVERY_OFFICE_NAME \"2.5.4.19\"")]
    public static ReadOnlySpan<byte> szOID_PHYSICAL_DELIVERY_OFFICE_NAME => "2.5.4.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TELEPHONE_NUMBER"]/*' />
    [NativeTypeName("#define szOID_TELEPHONE_NUMBER \"2.5.4.20\"")]
    public static ReadOnlySpan<byte> szOID_TELEPHONE_NUMBER => "2.5.4.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TELEX_NUMBER"]/*' />
    [NativeTypeName("#define szOID_TELEX_NUMBER \"2.5.4.21\"")]
    public static ReadOnlySpan<byte> szOID_TELEX_NUMBER => "2.5.4.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TELETEXT_TERMINAL_IDENTIFIER"]/*' />
    [NativeTypeName("#define szOID_TELETEXT_TERMINAL_IDENTIFIER \"2.5.4.22\"")]
    public static ReadOnlySpan<byte> szOID_TELETEXT_TERMINAL_IDENTIFIER => "2.5.4.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_FACSIMILE_TELEPHONE_NUMBER"]/*' />
    [NativeTypeName("#define szOID_FACSIMILE_TELEPHONE_NUMBER \"2.5.4.23\"")]
    public static ReadOnlySpan<byte> szOID_FACSIMILE_TELEPHONE_NUMBER => "2.5.4.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_X21_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_X21_ADDRESS \"2.5.4.24\"")]
    public static ReadOnlySpan<byte> szOID_X21_ADDRESS => "2.5.4.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INTERNATIONAL_ISDN_NUMBER"]/*' />
    [NativeTypeName("#define szOID_INTERNATIONAL_ISDN_NUMBER \"2.5.4.25\"")]
    public static ReadOnlySpan<byte> szOID_INTERNATIONAL_ISDN_NUMBER => "2.5.4.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REGISTERED_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_REGISTERED_ADDRESS \"2.5.4.26\"")]
    public static ReadOnlySpan<byte> szOID_REGISTERED_ADDRESS => "2.5.4.26"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DESTINATION_INDICATOR"]/*' />
    [NativeTypeName("#define szOID_DESTINATION_INDICATOR \"2.5.4.27\"")]
    public static ReadOnlySpan<byte> szOID_DESTINATION_INDICATOR => "2.5.4.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PREFERRED_DELIVERY_METHOD"]/*' />
    [NativeTypeName("#define szOID_PREFERRED_DELIVERY_METHOD \"2.5.4.28\"")]
    public static ReadOnlySpan<byte> szOID_PREFERRED_DELIVERY_METHOD => "2.5.4.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PRESENTATION_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_PRESENTATION_ADDRESS \"2.5.4.29\"")]
    public static ReadOnlySpan<byte> szOID_PRESENTATION_ADDRESS => "2.5.4.29"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUPPORTED_APPLICATION_CONTEXT"]/*' />
    [NativeTypeName("#define szOID_SUPPORTED_APPLICATION_CONTEXT \"2.5.4.30\"")]
    public static ReadOnlySpan<byte> szOID_SUPPORTED_APPLICATION_CONTEXT => "2.5.4.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MEMBER"]/*' />
    [NativeTypeName("#define szOID_MEMBER \"2.5.4.31\"")]
    public static ReadOnlySpan<byte> szOID_MEMBER => "2.5.4.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OWNER"]/*' />
    [NativeTypeName("#define szOID_OWNER \"2.5.4.32\"")]
    public static ReadOnlySpan<byte> szOID_OWNER => "2.5.4.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROLE_OCCUPANT"]/*' />
    [NativeTypeName("#define szOID_ROLE_OCCUPANT \"2.5.4.33\"")]
    public static ReadOnlySpan<byte> szOID_ROLE_OCCUPANT => "2.5.4.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SEE_ALSO"]/*' />
    [NativeTypeName("#define szOID_SEE_ALSO \"2.5.4.34\"")]
    public static ReadOnlySpan<byte> szOID_SEE_ALSO => "2.5.4.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_USER_PASSWORD"]/*' />
    [NativeTypeName("#define szOID_USER_PASSWORD \"2.5.4.35\"")]
    public static ReadOnlySpan<byte> szOID_USER_PASSWORD => "2.5.4.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_USER_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_USER_CERTIFICATE \"2.5.4.36\"")]
    public static ReadOnlySpan<byte> szOID_USER_CERTIFICATE => "2.5.4.36"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CA_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_CA_CERTIFICATE \"2.5.4.37\"")]
    public static ReadOnlySpan<byte> szOID_CA_CERTIFICATE => "2.5.4.37"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_AUTHORITY_REVOCATION_LIST"]/*' />
    [NativeTypeName("#define szOID_AUTHORITY_REVOCATION_LIST \"2.5.4.38\"")]
    public static ReadOnlySpan<byte> szOID_AUTHORITY_REVOCATION_LIST => "2.5.4.38"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTIFICATE_REVOCATION_LIST"]/*' />
    [NativeTypeName("#define szOID_CERTIFICATE_REVOCATION_LIST \"2.5.4.39\"")]
    public static ReadOnlySpan<byte> szOID_CERTIFICATE_REVOCATION_LIST => "2.5.4.39"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CROSS_CERTIFICATE_PAIR"]/*' />
    [NativeTypeName("#define szOID_CROSS_CERTIFICATE_PAIR \"2.5.4.40\"")]
    public static ReadOnlySpan<byte> szOID_CROSS_CERTIFICATE_PAIR => "2.5.4.40"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_GIVEN_NAME"]/*' />
    [NativeTypeName("#define szOID_GIVEN_NAME \"2.5.4.42\"")]
    public static ReadOnlySpan<byte> szOID_GIVEN_NAME => "2.5.4.42"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INITIALS"]/*' />
    [NativeTypeName("#define szOID_INITIALS \"2.5.4.43\"")]
    public static ReadOnlySpan<byte> szOID_INITIALS => "2.5.4.43"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DN_QUALIFIER"]/*' />
    [NativeTypeName("#define szOID_DN_QUALIFIER \"2.5.4.46\"")]
    public static ReadOnlySpan<byte> szOID_DN_QUALIFIER => "2.5.4.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DOMAIN_COMPONENT"]/*' />
    [NativeTypeName("#define szOID_DOMAIN_COMPONENT \"0.9.2342.19200300.100.1.25\"")]
    public static ReadOnlySpan<byte> szOID_DOMAIN_COMPONENT => "0.9.2342.19200300.100.1.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_FRIENDLY_NAME_ATTR"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_FRIENDLY_NAME_ATTR \"1.2.840.113549.1.9.20\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_FRIENDLY_NAME_ATTR => "1.2.840.113549.1.9.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_LOCAL_KEY_ID"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_LOCAL_KEY_ID \"1.2.840.113549.1.9.21\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_LOCAL_KEY_ID => "1.2.840.113549.1.9.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR \"1.3.6.1.4.1.311.17.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR => "1.3.6.1.4.1.311.17.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LOCAL_MACHINE_KEYSET"]/*' />
    [NativeTypeName("#define szOID_LOCAL_MACHINE_KEYSET \"1.3.6.1.4.1.311.17.2\"")]
    public static ReadOnlySpan<byte> szOID_LOCAL_MACHINE_KEYSET => "1.3.6.1.4.1.311.17.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_EXTENDED_ATTRIBUTES"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_EXTENDED_ATTRIBUTES \"1.3.6.1.4.1.311.17.3\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_EXTENDED_ATTRIBUTES => "1.3.6.1.4.1.311.17.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID \"1.3.6.1.4.1.311.17.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_PROTECTED_PASSWORD_SECRET_BAG_TYPE_ID => "1.3.6.1.4.1.311.17.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KEYID_RDN"]/*' />
    [NativeTypeName("#define szOID_KEYID_RDN \"1.3.6.1.4.1.311.10.7.1\"")]
    public static ReadOnlySpan<byte> szOID_KEYID_RDN => "1.3.6.1.4.1.311.10.7.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EV_RDN_LOCALE"]/*' />
    [NativeTypeName("#define szOID_EV_RDN_LOCALE \"1.3.6.1.4.1.311.60.2.1.1\"")]
    public static ReadOnlySpan<byte> szOID_EV_RDN_LOCALE => "1.3.6.1.4.1.311.60.2.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EV_RDN_STATE_OR_PROVINCE"]/*' />
    [NativeTypeName("#define szOID_EV_RDN_STATE_OR_PROVINCE \"1.3.6.1.4.1.311.60.2.1.2\"")]
    public static ReadOnlySpan<byte> szOID_EV_RDN_STATE_OR_PROVINCE => "1.3.6.1.4.1.311.60.2.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EV_RDN_COUNTRY"]/*' />
    [NativeTypeName("#define szOID_EV_RDN_COUNTRY \"1.3.6.1.4.1.311.60.2.1.3\"")]
    public static ReadOnlySpan<byte> szOID_EV_RDN_COUNTRY => "1.3.6.1.4.1.311.60.2.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_AUTHORITY_KEY_IDENTIFIER"]/*' />
    [NativeTypeName("#define szOID_AUTHORITY_KEY_IDENTIFIER \"2.5.29.1\"")]
    public static ReadOnlySpan<byte> szOID_AUTHORITY_KEY_IDENTIFIER => "2.5.29.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KEY_ATTRIBUTES"]/*' />
    [NativeTypeName("#define szOID_KEY_ATTRIBUTES \"2.5.29.2\"")]
    public static ReadOnlySpan<byte> szOID_KEY_ATTRIBUTES => "2.5.29.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_POLICIES_95"]/*' />
    [NativeTypeName("#define szOID_CERT_POLICIES_95 \"2.5.29.3\"")]
    public static ReadOnlySpan<byte> szOID_CERT_POLICIES_95 => "2.5.29.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KEY_USAGE_RESTRICTION"]/*' />
    [NativeTypeName("#define szOID_KEY_USAGE_RESTRICTION \"2.5.29.4\"")]
    public static ReadOnlySpan<byte> szOID_KEY_USAGE_RESTRICTION => "2.5.29.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUBJECT_ALT_NAME"]/*' />
    [NativeTypeName("#define szOID_SUBJECT_ALT_NAME \"2.5.29.7\"")]
    public static ReadOnlySpan<byte> szOID_SUBJECT_ALT_NAME => "2.5.29.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ISSUER_ALT_NAME"]/*' />
    [NativeTypeName("#define szOID_ISSUER_ALT_NAME \"2.5.29.8\"")]
    public static ReadOnlySpan<byte> szOID_ISSUER_ALT_NAME => "2.5.29.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BASIC_CONSTRAINTS"]/*' />
    [NativeTypeName("#define szOID_BASIC_CONSTRAINTS \"2.5.29.10\"")]
    public static ReadOnlySpan<byte> szOID_BASIC_CONSTRAINTS => "2.5.29.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KEY_USAGE"]/*' />
    [NativeTypeName("#define szOID_KEY_USAGE \"2.5.29.15\"")]
    public static ReadOnlySpan<byte> szOID_KEY_USAGE => "2.5.29.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PRIVATEKEY_USAGE_PERIOD"]/*' />
    [NativeTypeName("#define szOID_PRIVATEKEY_USAGE_PERIOD \"2.5.29.16\"")]
    public static ReadOnlySpan<byte> szOID_PRIVATEKEY_USAGE_PERIOD => "2.5.29.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BASIC_CONSTRAINTS2"]/*' />
    [NativeTypeName("#define szOID_BASIC_CONSTRAINTS2 \"2.5.29.19\"")]
    public static ReadOnlySpan<byte> szOID_BASIC_CONSTRAINTS2 => "2.5.29.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_POLICIES"]/*' />
    [NativeTypeName("#define szOID_CERT_POLICIES \"2.5.29.32\"")]
    public static ReadOnlySpan<byte> szOID_CERT_POLICIES => "2.5.29.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ANY_CERT_POLICY"]/*' />
    [NativeTypeName("#define szOID_ANY_CERT_POLICY \"2.5.29.32.0\"")]
    public static ReadOnlySpan<byte> szOID_ANY_CERT_POLICY => "2.5.29.32.0"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INHIBIT_ANY_POLICY"]/*' />
    [NativeTypeName("#define szOID_INHIBIT_ANY_POLICY \"2.5.29.54\"")]
    public static ReadOnlySpan<byte> szOID_INHIBIT_ANY_POLICY => "2.5.29.54"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_AUTHORITY_KEY_IDENTIFIER2"]/*' />
    [NativeTypeName("#define szOID_AUTHORITY_KEY_IDENTIFIER2 \"2.5.29.35\"")]
    public static ReadOnlySpan<byte> szOID_AUTHORITY_KEY_IDENTIFIER2 => "2.5.29.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUBJECT_KEY_IDENTIFIER"]/*' />
    [NativeTypeName("#define szOID_SUBJECT_KEY_IDENTIFIER \"2.5.29.14\"")]
    public static ReadOnlySpan<byte> szOID_SUBJECT_KEY_IDENTIFIER => "2.5.29.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUBJECT_ALT_NAME2"]/*' />
    [NativeTypeName("#define szOID_SUBJECT_ALT_NAME2 \"2.5.29.17\"")]
    public static ReadOnlySpan<byte> szOID_SUBJECT_ALT_NAME2 => "2.5.29.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ISSUER_ALT_NAME2"]/*' />
    [NativeTypeName("#define szOID_ISSUER_ALT_NAME2 \"2.5.29.18\"")]
    public static ReadOnlySpan<byte> szOID_ISSUER_ALT_NAME2 => "2.5.29.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_REASON_CODE"]/*' />
    [NativeTypeName("#define szOID_CRL_REASON_CODE \"2.5.29.21\"")]
    public static ReadOnlySpan<byte> szOID_CRL_REASON_CODE => "2.5.29.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REASON_CODE_HOLD"]/*' />
    [NativeTypeName("#define szOID_REASON_CODE_HOLD \"2.5.29.23\"")]
    public static ReadOnlySpan<byte> szOID_REASON_CODE_HOLD => "2.5.29.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_DIST_POINTS"]/*' />
    [NativeTypeName("#define szOID_CRL_DIST_POINTS \"2.5.29.31\"")]
    public static ReadOnlySpan<byte> szOID_CRL_DIST_POINTS => "2.5.29.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENHANCED_KEY_USAGE"]/*' />
    [NativeTypeName("#define szOID_ENHANCED_KEY_USAGE \"2.5.29.37\"")]
    public static ReadOnlySpan<byte> szOID_ENHANCED_KEY_USAGE => "2.5.29.37"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ANY_ENHANCED_KEY_USAGE"]/*' />
    [NativeTypeName("#define szOID_ANY_ENHANCED_KEY_USAGE \"2.5.29.37.0\"")]
    public static ReadOnlySpan<byte> szOID_ANY_ENHANCED_KEY_USAGE => "2.5.29.37.0"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_NUMBER"]/*' />
    [NativeTypeName("#define szOID_CRL_NUMBER \"2.5.29.20\"")]
    public static ReadOnlySpan<byte> szOID_CRL_NUMBER => "2.5.29.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DELTA_CRL_INDICATOR"]/*' />
    [NativeTypeName("#define szOID_DELTA_CRL_INDICATOR \"2.5.29.27\"")]
    public static ReadOnlySpan<byte> szOID_DELTA_CRL_INDICATOR => "2.5.29.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ISSUING_DIST_POINT"]/*' />
    [NativeTypeName("#define szOID_ISSUING_DIST_POINT \"2.5.29.28\"")]
    public static ReadOnlySpan<byte> szOID_ISSUING_DIST_POINT => "2.5.29.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_FRESHEST_CRL"]/*' />
    [NativeTypeName("#define szOID_FRESHEST_CRL \"2.5.29.46\"")]
    public static ReadOnlySpan<byte> szOID_FRESHEST_CRL => "2.5.29.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NAME_CONSTRAINTS"]/*' />
    [NativeTypeName("#define szOID_NAME_CONSTRAINTS \"2.5.29.30\"")]
    public static ReadOnlySpan<byte> szOID_NAME_CONSTRAINTS => "2.5.29.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_POLICY_MAPPINGS"]/*' />
    [NativeTypeName("#define szOID_POLICY_MAPPINGS \"2.5.29.33\"")]
    public static ReadOnlySpan<byte> szOID_POLICY_MAPPINGS => "2.5.29.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LEGACY_POLICY_MAPPINGS"]/*' />
    [NativeTypeName("#define szOID_LEGACY_POLICY_MAPPINGS \"2.5.29.5\"")]
    public static ReadOnlySpan<byte> szOID_LEGACY_POLICY_MAPPINGS => "2.5.29.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_POLICY_CONSTRAINTS"]/*' />
    [NativeTypeName("#define szOID_POLICY_CONSTRAINTS \"2.5.29.36\"")]
    public static ReadOnlySpan<byte> szOID_POLICY_CONSTRAINTS => "2.5.29.36"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RENEWAL_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_RENEWAL_CERTIFICATE \"1.3.6.1.4.1.311.13.1\"")]
    public static ReadOnlySpan<byte> szOID_RENEWAL_CERTIFICATE => "1.3.6.1.4.1.311.13.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLLMENT_NAME_VALUE_PAIR"]/*' />
    [NativeTypeName("#define szOID_ENROLLMENT_NAME_VALUE_PAIR \"1.3.6.1.4.1.311.13.2.1\"")]
    public static ReadOnlySpan<byte> szOID_ENROLLMENT_NAME_VALUE_PAIR => "1.3.6.1.4.1.311.13.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLLMENT_CSP_PROVIDER"]/*' />
    [NativeTypeName("#define szOID_ENROLLMENT_CSP_PROVIDER \"1.3.6.1.4.1.311.13.2.2\"")]
    public static ReadOnlySpan<byte> szOID_ENROLLMENT_CSP_PROVIDER => "1.3.6.1.4.1.311.13.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OS_VERSION"]/*' />
    [NativeTypeName("#define szOID_OS_VERSION \"1.3.6.1.4.1.311.13.2.3\"")]
    public static ReadOnlySpan<byte> szOID_OS_VERSION => "1.3.6.1.4.1.311.13.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLLMENT_AGENT"]/*' />
    [NativeTypeName("#define szOID_ENROLLMENT_AGENT \"1.3.6.1.4.1.311.20.2.1\"")]
    public static ReadOnlySpan<byte> szOID_ENROLLMENT_AGENT => "1.3.6.1.4.1.311.20.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX"]/*' />
    [NativeTypeName("#define szOID_PKIX \"1.3.6.1.5.5.7\"")]
    public static ReadOnlySpan<byte> szOID_PKIX => "1.3.6.1.5.5.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_PE"]/*' />
    [NativeTypeName("#define szOID_PKIX_PE \"1.3.6.1.5.5.7.1\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_PE => "1.3.6.1.5.5.7.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_AUTHORITY_INFO_ACCESS"]/*' />
    [NativeTypeName("#define szOID_AUTHORITY_INFO_ACCESS \"1.3.6.1.5.5.7.1.1\"")]
    public static ReadOnlySpan<byte> szOID_AUTHORITY_INFO_ACCESS => "1.3.6.1.5.5.7.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUBJECT_INFO_ACCESS"]/*' />
    [NativeTypeName("#define szOID_SUBJECT_INFO_ACCESS \"1.3.6.1.5.5.7.1.11\"")]
    public static ReadOnlySpan<byte> szOID_SUBJECT_INFO_ACCESS => "1.3.6.1.5.5.7.1.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BIOMETRIC_EXT"]/*' />
    [NativeTypeName("#define szOID_BIOMETRIC_EXT \"1.3.6.1.5.5.7.1.2\"")]
    public static ReadOnlySpan<byte> szOID_BIOMETRIC_EXT => "1.3.6.1.5.5.7.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_QC_STATEMENTS_EXT"]/*' />
    [NativeTypeName("#define szOID_QC_STATEMENTS_EXT \"1.3.6.1.5.5.7.1.3\"")]
    public static ReadOnlySpan<byte> szOID_QC_STATEMENTS_EXT => "1.3.6.1.5.5.7.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LOGOTYPE_EXT"]/*' />
    [NativeTypeName("#define szOID_LOGOTYPE_EXT \"1.3.6.1.5.5.7.1.12\"")]
    public static ReadOnlySpan<byte> szOID_LOGOTYPE_EXT => "1.3.6.1.5.5.7.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_TLS_FEATURES_EXT"]/*' />
    [NativeTypeName("#define szOID_TLS_FEATURES_EXT \"1.3.6.1.5.5.7.1.24\"")]
    public static ReadOnlySpan<byte> szOID_TLS_FEATURES_EXT => "1.3.6.1.5.5.7.1.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_EXTENSIONS"]/*' />
    [NativeTypeName("#define szOID_CERT_EXTENSIONS \"1.3.6.1.4.1.311.2.1.14\"")]
    public static ReadOnlySpan<byte> szOID_CERT_EXTENSIONS => "1.3.6.1.4.1.311.2.1.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NEXT_UPDATE_LOCATION"]/*' />
    [NativeTypeName("#define szOID_NEXT_UPDATE_LOCATION \"1.3.6.1.4.1.311.10.2\"")]
    public static ReadOnlySpan<byte> szOID_NEXT_UPDATE_LOCATION => "1.3.6.1.4.1.311.10.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REMOVE_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_REMOVE_CERTIFICATE \"1.3.6.1.4.1.311.10.8.1\"")]
    public static ReadOnlySpan<byte> szOID_REMOVE_CERTIFICATE => "1.3.6.1.4.1.311.10.8.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CROSS_CERT_DIST_POINTS"]/*' />
    [NativeTypeName("#define szOID_CROSS_CERT_DIST_POINTS \"1.3.6.1.4.1.311.10.9.1\"")]
    public static ReadOnlySpan<byte> szOID_CROSS_CERT_DIST_POINTS => "1.3.6.1.4.1.311.10.9.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CTL"]/*' />
    [NativeTypeName("#define szOID_CTL \"1.3.6.1.4.1.311.10.1\"")]
    public static ReadOnlySpan<byte> szOID_CTL => "1.3.6.1.4.1.311.10.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SORTED_CTL"]/*' />
    [NativeTypeName("#define szOID_SORTED_CTL \"1.3.6.1.4.1.311.10.1.1\"")]
    public static ReadOnlySpan<byte> szOID_SORTED_CTL => "1.3.6.1.4.1.311.10.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SERIALIZED"]/*' />
    [NativeTypeName("#define szOID_SERIALIZED \"1.3.6.1.4.1.311.10.3.3.1\"")]
    public static ReadOnlySpan<byte> szOID_SERIALIZED => "1.3.6.1.4.1.311.10.3.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NT_PRINCIPAL_NAME"]/*' />
    [NativeTypeName("#define szOID_NT_PRINCIPAL_NAME \"1.3.6.1.4.1.311.20.2.3\"")]
    public static ReadOnlySpan<byte> szOID_NT_PRINCIPAL_NAME => "1.3.6.1.4.1.311.20.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_INTERNATIONALIZED_EMAIL_ADDRESS"]/*' />
    [NativeTypeName("#define szOID_INTERNATIONALIZED_EMAIL_ADDRESS \"1.3.6.1.4.1.311.20.2.4\"")]
    public static ReadOnlySpan<byte> szOID_INTERNATIONALIZED_EMAIL_ADDRESS => "1.3.6.1.4.1.311.20.2.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PRODUCT_UPDATE"]/*' />
    [NativeTypeName("#define szOID_PRODUCT_UPDATE \"1.3.6.1.4.1.311.31.1\"")]
    public static ReadOnlySpan<byte> szOID_PRODUCT_UPDATE => "1.3.6.1.4.1.311.31.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ANY_APPLICATION_POLICY"]/*' />
    [NativeTypeName("#define szOID_ANY_APPLICATION_POLICY \"1.3.6.1.4.1.311.10.12.1\"")]
    public static ReadOnlySpan<byte> szOID_ANY_APPLICATION_POLICY => "1.3.6.1.4.1.311.10.12.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_AUTO_ENROLL_CTL_USAGE"]/*' />
    [NativeTypeName("#define szOID_AUTO_ENROLL_CTL_USAGE \"1.3.6.1.4.1.311.20.1\"")]
    public static ReadOnlySpan<byte> szOID_AUTO_ENROLL_CTL_USAGE => "1.3.6.1.4.1.311.20.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_CERTTYPE_EXTENSION"]/*' />
    [NativeTypeName("#define szOID_ENROLL_CERTTYPE_EXTENSION \"1.3.6.1.4.1.311.20.2\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_CERTTYPE_EXTENSION => "1.3.6.1.4.1.311.20.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_MANIFOLD"]/*' />
    [NativeTypeName("#define szOID_CERT_MANIFOLD \"1.3.6.1.4.1.311.20.3\"")]
    public static ReadOnlySpan<byte> szOID_CERT_MANIFOLD => "1.3.6.1.4.1.311.20.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTSRV_CA_VERSION"]/*' />
    [NativeTypeName("#define szOID_CERTSRV_CA_VERSION \"1.3.6.1.4.1.311.21.1\"")]
    public static ReadOnlySpan<byte> szOID_CERTSRV_CA_VERSION => "1.3.6.1.4.1.311.21.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTSRV_PREVIOUS_CERT_HASH"]/*' />
    [NativeTypeName("#define szOID_CERTSRV_PREVIOUS_CERT_HASH \"1.3.6.1.4.1.311.21.2\"")]
    public static ReadOnlySpan<byte> szOID_CERTSRV_PREVIOUS_CERT_HASH => "1.3.6.1.4.1.311.21.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_VIRTUAL_BASE"]/*' />
    [NativeTypeName("#define szOID_CRL_VIRTUAL_BASE \"1.3.6.1.4.1.311.21.3\"")]
    public static ReadOnlySpan<byte> szOID_CRL_VIRTUAL_BASE => "1.3.6.1.4.1.311.21.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_NEXT_PUBLISH"]/*' />
    [NativeTypeName("#define szOID_CRL_NEXT_PUBLISH \"1.3.6.1.4.1.311.21.4\"")]
    public static ReadOnlySpan<byte> szOID_CRL_NEXT_PUBLISH => "1.3.6.1.4.1.311.21.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_CA_EXCHANGE"]/*' />
    [NativeTypeName("#define szOID_KP_CA_EXCHANGE \"1.3.6.1.4.1.311.21.5\"")]
    public static ReadOnlySpan<byte> szOID_KP_CA_EXCHANGE => "1.3.6.1.4.1.311.21.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_PRIVACY_CA"]/*' />
    [NativeTypeName("#define szOID_KP_PRIVACY_CA \"1.3.6.1.4.1.311.21.36\"")]
    public static ReadOnlySpan<byte> szOID_KP_PRIVACY_CA => "1.3.6.1.4.1.311.21.36"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_KEY_RECOVERY_AGENT"]/*' />
    [NativeTypeName("#define szOID_KP_KEY_RECOVERY_AGENT \"1.3.6.1.4.1.311.21.6\"")]
    public static ReadOnlySpan<byte> szOID_KP_KEY_RECOVERY_AGENT => "1.3.6.1.4.1.311.21.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTIFICATE_TEMPLATE"]/*' />
    [NativeTypeName("#define szOID_CERTIFICATE_TEMPLATE \"1.3.6.1.4.1.311.21.7\"")]
    public static ReadOnlySpan<byte> szOID_CERTIFICATE_TEMPLATE => "1.3.6.1.4.1.311.21.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENTERPRISE_OID_ROOT"]/*' />
    [NativeTypeName("#define szOID_ENTERPRISE_OID_ROOT \"1.3.6.1.4.1.311.21.8\"")]
    public static ReadOnlySpan<byte> szOID_ENTERPRISE_OID_ROOT => "1.3.6.1.4.1.311.21.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_DUMMY_SIGNER"]/*' />
    [NativeTypeName("#define szOID_RDN_DUMMY_SIGNER \"1.3.6.1.4.1.311.21.9\"")]
    public static ReadOnlySpan<byte> szOID_RDN_DUMMY_SIGNER => "1.3.6.1.4.1.311.21.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_APPLICATION_CERT_POLICIES"]/*' />
    [NativeTypeName("#define szOID_APPLICATION_CERT_POLICIES \"1.3.6.1.4.1.311.21.10\"")]
    public static ReadOnlySpan<byte> szOID_APPLICATION_CERT_POLICIES => "1.3.6.1.4.1.311.21.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_APPLICATION_POLICY_MAPPINGS"]/*' />
    [NativeTypeName("#define szOID_APPLICATION_POLICY_MAPPINGS \"1.3.6.1.4.1.311.21.11\"")]
    public static ReadOnlySpan<byte> szOID_APPLICATION_POLICY_MAPPINGS => "1.3.6.1.4.1.311.21.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_APPLICATION_POLICY_CONSTRAINTS"]/*' />
    [NativeTypeName("#define szOID_APPLICATION_POLICY_CONSTRAINTS \"1.3.6.1.4.1.311.21.12\"")]
    public static ReadOnlySpan<byte> szOID_APPLICATION_POLICY_CONSTRAINTS => "1.3.6.1.4.1.311.21.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ARCHIVED_KEY_ATTR"]/*' />
    [NativeTypeName("#define szOID_ARCHIVED_KEY_ATTR \"1.3.6.1.4.1.311.21.13\"")]
    public static ReadOnlySpan<byte> szOID_ARCHIVED_KEY_ATTR => "1.3.6.1.4.1.311.21.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CRL_SELF_CDP"]/*' />
    [NativeTypeName("#define szOID_CRL_SELF_CDP \"1.3.6.1.4.1.311.21.14\"")]
    public static ReadOnlySpan<byte> szOID_CRL_SELF_CDP => "1.3.6.1.4.1.311.21.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REQUIRE_CERT_CHAIN_POLICY"]/*' />
    [NativeTypeName("#define szOID_REQUIRE_CERT_CHAIN_POLICY \"1.3.6.1.4.1.311.21.15\"")]
    public static ReadOnlySpan<byte> szOID_REQUIRE_CERT_CHAIN_POLICY => "1.3.6.1.4.1.311.21.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ARCHIVED_KEY_CERT_HASH"]/*' />
    [NativeTypeName("#define szOID_ARCHIVED_KEY_CERT_HASH \"1.3.6.1.4.1.311.21.16\"")]
    public static ReadOnlySpan<byte> szOID_ARCHIVED_KEY_CERT_HASH => "1.3.6.1.4.1.311.21.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ISSUED_CERT_HASH"]/*' />
    [NativeTypeName("#define szOID_ISSUED_CERT_HASH \"1.3.6.1.4.1.311.21.17\"")]
    public static ReadOnlySpan<byte> szOID_ISSUED_CERT_HASH => "1.3.6.1.4.1.311.21.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DS_EMAIL_REPLICATION"]/*' />
    [NativeTypeName("#define szOID_DS_EMAIL_REPLICATION \"1.3.6.1.4.1.311.21.19\"")]
    public static ReadOnlySpan<byte> szOID_DS_EMAIL_REPLICATION => "1.3.6.1.4.1.311.21.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REQUEST_CLIENT_INFO"]/*' />
    [NativeTypeName("#define szOID_REQUEST_CLIENT_INFO \"1.3.6.1.4.1.311.21.20\"")]
    public static ReadOnlySpan<byte> szOID_REQUEST_CLIENT_INFO => "1.3.6.1.4.1.311.21.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENCRYPTED_KEY_HASH"]/*' />
    [NativeTypeName("#define szOID_ENCRYPTED_KEY_HASH \"1.3.6.1.4.1.311.21.21\"")]
    public static ReadOnlySpan<byte> szOID_ENCRYPTED_KEY_HASH => "1.3.6.1.4.1.311.21.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTSRV_CROSSCA_VERSION"]/*' />
    [NativeTypeName("#define szOID_CERTSRV_CROSSCA_VERSION \"1.3.6.1.4.1.311.21.22\"")]
    public static ReadOnlySpan<byte> szOID_CERTSRV_CROSSCA_VERSION => "1.3.6.1.4.1.311.21.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NTDS_REPLICATION"]/*' />
    [NativeTypeName("#define szOID_NTDS_REPLICATION \"1.3.6.1.4.1.311.25.1\"")]
    public static ReadOnlySpan<byte> szOID_NTDS_REPLICATION => "1.3.6.1.4.1.311.25.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NTDS_CA_SECURITY_EXT"]/*' />
    [NativeTypeName("#define szOID_NTDS_CA_SECURITY_EXT \"1.3.6.1.4.1.311.25.2\"")]
    public static ReadOnlySpan<byte> szOID_NTDS_CA_SECURITY_EXT => "1.3.6.1.4.1.311.25.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NTDS_OBJECTSID"]/*' />
    [NativeTypeName("#define szOID_NTDS_OBJECTSID \"1.3.6.1.4.1.311.25.2.1\"")]
    public static ReadOnlySpan<byte> szOID_NTDS_OBJECTSID => "1.3.6.1.4.1.311.25.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SUBJECT_DIR_ATTRS"]/*' />
    [NativeTypeName("#define szOID_SUBJECT_DIR_ATTRS \"2.5.29.9\"")]
    public static ReadOnlySpan<byte> szOID_SUBJECT_DIR_ATTRS => "2.5.29.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP \"1.3.6.1.5.5.7.3\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP => "1.3.6.1.5.5.7.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_SERVER_AUTH"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_SERVER_AUTH \"1.3.6.1.5.5.7.3.1\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_SERVER_AUTH => "1.3.6.1.5.5.7.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_CLIENT_AUTH"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_CLIENT_AUTH \"1.3.6.1.5.5.7.3.2\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_CLIENT_AUTH => "1.3.6.1.5.5.7.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_CODE_SIGNING"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_CODE_SIGNING \"1.3.6.1.5.5.7.3.3\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_CODE_SIGNING => "1.3.6.1.5.5.7.3.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_EMAIL_PROTECTION"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_EMAIL_PROTECTION \"1.3.6.1.5.5.7.3.4\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_EMAIL_PROTECTION => "1.3.6.1.5.5.7.3.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_IPSEC_END_SYSTEM"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_IPSEC_END_SYSTEM \"1.3.6.1.5.5.7.3.5\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_END_SYSTEM => "1.3.6.1.5.5.7.3.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_IPSEC_TUNNEL"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_IPSEC_TUNNEL \"1.3.6.1.5.5.7.3.6\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_TUNNEL => "1.3.6.1.5.5.7.3.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_IPSEC_USER"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_IPSEC_USER \"1.3.6.1.5.5.7.3.7\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_IPSEC_USER => "1.3.6.1.5.5.7.3.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_TIMESTAMP_SIGNING"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_TIMESTAMP_SIGNING \"1.3.6.1.5.5.7.3.8\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_TIMESTAMP_SIGNING => "1.3.6.1.5.5.7.3.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_KP_OCSP_SIGNING"]/*' />
    [NativeTypeName("#define szOID_PKIX_KP_OCSP_SIGNING \"1.3.6.1.5.5.7.3.9\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_KP_OCSP_SIGNING => "1.3.6.1.5.5.7.3.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_OCSP_NOCHECK"]/*' />
    [NativeTypeName("#define szOID_PKIX_OCSP_NOCHECK \"1.3.6.1.5.5.7.48.1.5\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_OCSP_NOCHECK => "1.3.6.1.5.5.7.48.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_OCSP_NONCE"]/*' />
    [NativeTypeName("#define szOID_PKIX_OCSP_NONCE \"1.3.6.1.5.5.7.48.1.2\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_OCSP_NONCE => "1.3.6.1.5.5.7.48.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_IPSEC_KP_IKE_INTERMEDIATE"]/*' />
    [NativeTypeName("#define szOID_IPSEC_KP_IKE_INTERMEDIATE \"1.3.6.1.5.5.8.2.2\"")]
    public static ReadOnlySpan<byte> szOID_IPSEC_KP_IKE_INTERMEDIATE => "1.3.6.1.5.5.8.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKINIT_KP_KDC"]/*' />
    [NativeTypeName("#define szOID_PKINIT_KP_KDC \"1.3.6.1.5.2.3.5\"")]
    public static ReadOnlySpan<byte> szOID_PKINIT_KP_KDC => "1.3.6.1.5.2.3.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_CTL_USAGE_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_CTL_USAGE_SIGNING \"1.3.6.1.4.1.311.10.3.1\"")]
    public static ReadOnlySpan<byte> szOID_KP_CTL_USAGE_SIGNING => "1.3.6.1.4.1.311.10.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_TIME_STAMP_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_TIME_STAMP_SIGNING \"1.3.6.1.4.1.311.10.3.2\"")]
    public static ReadOnlySpan<byte> szOID_KP_TIME_STAMP_SIGNING => "1.3.6.1.4.1.311.10.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SERVER_GATED_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_SERVER_GATED_CRYPTO \"1.3.6.1.4.1.311.10.3.3\"")]
    public static ReadOnlySpan<byte> szOID_SERVER_GATED_CRYPTO => "1.3.6.1.4.1.311.10.3.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SGC_NETSCAPE"]/*' />
    [NativeTypeName("#define szOID_SGC_NETSCAPE \"2.16.840.1.113730.4.1\"")]
    public static ReadOnlySpan<byte> szOID_SGC_NETSCAPE => "2.16.840.1.113730.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_EFS"]/*' />
    [NativeTypeName("#define szOID_KP_EFS \"1.3.6.1.4.1.311.10.3.4\"")]
    public static ReadOnlySpan<byte> szOID_KP_EFS => "1.3.6.1.4.1.311.10.3.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EFS_RECOVERY"]/*' />
    [NativeTypeName("#define szOID_EFS_RECOVERY \"1.3.6.1.4.1.311.10.3.4.1\"")]
    public static ReadOnlySpan<byte> szOID_EFS_RECOVERY => "1.3.6.1.4.1.311.10.3.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WHQL_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.5\"")]
    public static ReadOnlySpan<byte> szOID_WHQL_CRYPTO => "1.3.6.1.4.1.311.10.3.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ATTEST_WHQL_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_ATTEST_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.5.1\"")]
    public static ReadOnlySpan<byte> szOID_ATTEST_WHQL_CRYPTO => "1.3.6.1.4.1.311.10.3.5.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NT5_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_NT5_CRYPTO \"1.3.6.1.4.1.311.10.3.6\"")]
    public static ReadOnlySpan<byte> szOID_NT5_CRYPTO => "1.3.6.1.4.1.311.10.3.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_OEM_WHQL_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_OEM_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.7\"")]
    public static ReadOnlySpan<byte> szOID_OEM_WHQL_CRYPTO => "1.3.6.1.4.1.311.10.3.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EMBEDDED_NT_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_EMBEDDED_NT_CRYPTO \"1.3.6.1.4.1.311.10.3.8\"")]
    public static ReadOnlySpan<byte> szOID_EMBEDDED_NT_CRYPTO => "1.3.6.1.4.1.311.10.3.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROOT_LIST_SIGNER"]/*' />
    [NativeTypeName("#define szOID_ROOT_LIST_SIGNER \"1.3.6.1.4.1.311.10.3.9\"")]
    public static ReadOnlySpan<byte> szOID_ROOT_LIST_SIGNER => "1.3.6.1.4.1.311.10.3.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_QUALIFIED_SUBORDINATION"]/*' />
    [NativeTypeName("#define szOID_KP_QUALIFIED_SUBORDINATION \"1.3.6.1.4.1.311.10.3.10\"")]
    public static ReadOnlySpan<byte> szOID_KP_QUALIFIED_SUBORDINATION => "1.3.6.1.4.1.311.10.3.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_KEY_RECOVERY"]/*' />
    [NativeTypeName("#define szOID_KP_KEY_RECOVERY \"1.3.6.1.4.1.311.10.3.11\"")]
    public static ReadOnlySpan<byte> szOID_KP_KEY_RECOVERY => "1.3.6.1.4.1.311.10.3.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_DOCUMENT_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_DOCUMENT_SIGNING \"1.3.6.1.4.1.311.10.3.12\"")]
    public static ReadOnlySpan<byte> szOID_KP_DOCUMENT_SIGNING => "1.3.6.1.4.1.311.10.3.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_LIFETIME_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_LIFETIME_SIGNING \"1.3.6.1.4.1.311.10.3.13\"")]
    public static ReadOnlySpan<byte> szOID_KP_LIFETIME_SIGNING => "1.3.6.1.4.1.311.10.3.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_MOBILE_DEVICE_SOFTWARE"]/*' />
    [NativeTypeName("#define szOID_KP_MOBILE_DEVICE_SOFTWARE \"1.3.6.1.4.1.311.10.3.14\"")]
    public static ReadOnlySpan<byte> szOID_KP_MOBILE_DEVICE_SOFTWARE => "1.3.6.1.4.1.311.10.3.14"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_SMART_DISPLAY"]/*' />
    [NativeTypeName("#define szOID_KP_SMART_DISPLAY \"1.3.6.1.4.1.311.10.3.15\"")]
    public static ReadOnlySpan<byte> szOID_KP_SMART_DISPLAY => "1.3.6.1.4.1.311.10.3.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_CSP_SIGNATURE"]/*' />
    [NativeTypeName("#define szOID_KP_CSP_SIGNATURE \"1.3.6.1.4.1.311.10.3.16\"")]
    public static ReadOnlySpan<byte> szOID_KP_CSP_SIGNATURE => "1.3.6.1.4.1.311.10.3.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_FLIGHT_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_FLIGHT_SIGNING \"1.3.6.1.4.1.311.10.3.27\"")]
    public static ReadOnlySpan<byte> szOID_KP_FLIGHT_SIGNING => "1.3.6.1.4.1.311.10.3.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PLATFORM_MANIFEST_BINARY_ID"]/*' />
    [NativeTypeName("#define szOID_PLATFORM_MANIFEST_BINARY_ID \"1.3.6.1.4.1.311.10.3.28\"")]
    public static ReadOnlySpan<byte> szOID_PLATFORM_MANIFEST_BINARY_ID => "1.3.6.1.4.1.311.10.3.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DRM"]/*' />
    [NativeTypeName("#define szOID_DRM \"1.3.6.1.4.1.311.10.5.1\"")]
    public static ReadOnlySpan<byte> szOID_DRM => "1.3.6.1.4.1.311.10.5.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DRM_INDIVIDUALIZATION"]/*' />
    [NativeTypeName("#define szOID_DRM_INDIVIDUALIZATION \"1.3.6.1.4.1.311.10.5.2\"")]
    public static ReadOnlySpan<byte> szOID_DRM_INDIVIDUALIZATION => "1.3.6.1.4.1.311.10.5.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LICENSES"]/*' />
    [NativeTypeName("#define szOID_LICENSES \"1.3.6.1.4.1.311.10.6.1\"")]
    public static ReadOnlySpan<byte> szOID_LICENSES => "1.3.6.1.4.1.311.10.6.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LICENSE_SERVER"]/*' />
    [NativeTypeName("#define szOID_LICENSE_SERVER \"1.3.6.1.4.1.311.10.6.2\"")]
    public static ReadOnlySpan<byte> szOID_LICENSE_SERVER => "1.3.6.1.4.1.311.10.6.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_SMARTCARD_LOGON"]/*' />
    [NativeTypeName("#define szOID_KP_SMARTCARD_LOGON \"1.3.6.1.4.1.311.20.2.2\"")]
    public static ReadOnlySpan<byte> szOID_KP_SMARTCARD_LOGON => "1.3.6.1.4.1.311.20.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_KERNEL_MODE_CODE_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_KERNEL_MODE_CODE_SIGNING \"1.3.6.1.4.1.311.61.1.1\"")]
    public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_CODE_SIGNING => "1.3.6.1.4.1.311.61.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING \"1.3.6.1.4.1.311.61.4.1\"")]
    public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_TRUSTED_BOOT_SIGNING => "1.3.6.1.4.1.311.61.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_REVOKED_LIST_SIGNER"]/*' />
    [NativeTypeName("#define szOID_REVOKED_LIST_SIGNER \"1.3.6.1.4.1.311.10.3.19\"")]
    public static ReadOnlySpan<byte> szOID_REVOKED_LIST_SIGNER => "1.3.6.1.4.1.311.10.3.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_KITS_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_KITS_SIGNER \"1.3.6.1.4.1.311.10.3.20\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_KITS_SIGNER => "1.3.6.1.4.1.311.10.3.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_RT_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_RT_SIGNER \"1.3.6.1.4.1.311.10.3.21\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_RT_SIGNER => "1.3.6.1.4.1.311.10.3.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PROTECTED_PROCESS_LIGHT_SIGNER"]/*' />
    [NativeTypeName("#define szOID_PROTECTED_PROCESS_LIGHT_SIGNER \"1.3.6.1.4.1.311.10.3.22\"")]
    public static ReadOnlySpan<byte> szOID_PROTECTED_PROCESS_LIGHT_SIGNER => "1.3.6.1.4.1.311.10.3.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_TCB_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_TCB_SIGNER \"1.3.6.1.4.1.311.10.3.23\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_TCB_SIGNER => "1.3.6.1.4.1.311.10.3.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PROTECTED_PROCESS_SIGNER"]/*' />
    [NativeTypeName("#define szOID_PROTECTED_PROCESS_SIGNER \"1.3.6.1.4.1.311.10.3.24\"")]
    public static ReadOnlySpan<byte> szOID_PROTECTED_PROCESS_SIGNER => "1.3.6.1.4.1.311.10.3.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER \"1.3.6.1.4.1.311.10.3.25\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_THIRD_PARTY_COMPONENT_SIGNER => "1.3.6.1.4.1.311.10.3.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER \"1.3.6.1.4.1.311.10.3.26\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_SOFTWARE_EXTENSION_SIGNER => "1.3.6.1.4.1.311.10.3.26"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DISALLOWED_LIST"]/*' />
    [NativeTypeName("#define szOID_DISALLOWED_LIST \"1.3.6.1.4.1.311.10.3.30\"")]
    public static ReadOnlySpan<byte> szOID_DISALLOWED_LIST => "1.3.6.1.4.1.311.10.3.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PIN_RULES_SIGNER"]/*' />
    [NativeTypeName("#define szOID_PIN_RULES_SIGNER \"1.3.6.1.4.1.311.10.3.31\"")]
    public static ReadOnlySpan<byte> szOID_PIN_RULES_SIGNER => "1.3.6.1.4.1.311.10.3.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PIN_RULES_CTL"]/*' />
    [NativeTypeName("#define szOID_PIN_RULES_CTL \"1.3.6.1.4.1.311.10.3.32\"")]
    public static ReadOnlySpan<byte> szOID_PIN_RULES_CTL => "1.3.6.1.4.1.311.10.3.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PIN_RULES_EXT"]/*' />
    [NativeTypeName("#define szOID_PIN_RULES_EXT \"1.3.6.1.4.1.311.10.3.33\"")]
    public static ReadOnlySpan<byte> szOID_PIN_RULES_EXT => "1.3.6.1.4.1.311.10.3.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PIN_RULES_DOMAIN_NAME"]/*' />
    [NativeTypeName("#define szOID_PIN_RULES_DOMAIN_NAME \"1.3.6.1.4.1.311.10.3.34\"")]
    public static ReadOnlySpan<byte> szOID_PIN_RULES_DOMAIN_NAME => "1.3.6.1.4.1.311.10.3.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PIN_RULES_LOG_END_DATE_EXT"]/*' />
    [NativeTypeName("#define szOID_PIN_RULES_LOG_END_DATE_EXT \"1.3.6.1.4.1.311.10.3.35\"")]
    public static ReadOnlySpan<byte> szOID_PIN_RULES_LOG_END_DATE_EXT => "1.3.6.1.4.1.311.10.3.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_IUM_SIGNING"]/*' />
    [NativeTypeName("#define szOID_IUM_SIGNING \"1.3.6.1.4.1.311.10.3.37\"")]
    public static ReadOnlySpan<byte> szOID_IUM_SIGNING => "1.3.6.1.4.1.311.10.3.37"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_EV_WHQL_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_EV_WHQL_CRYPTO \"1.3.6.1.4.1.311.10.3.39\"")]
    public static ReadOnlySpan<byte> szOID_EV_WHQL_CRYPTO => "1.3.6.1.4.1.311.10.3.39"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BIOMETRIC_SIGNING"]/*' />
    [NativeTypeName("#define szOID_BIOMETRIC_SIGNING \"1.3.6.1.4.1.311.10.3.41\"")]
    public static ReadOnlySpan<byte> szOID_BIOMETRIC_SIGNING => "1.3.6.1.4.1.311.10.3.41"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENCLAVE_SIGNING"]/*' />
    [NativeTypeName("#define szOID_ENCLAVE_SIGNING \"1.3.6.1.4.1.311.10.3.42\"")]
    public static ReadOnlySpan<byte> szOID_ENCLAVE_SIGNING => "1.3.6.1.4.1.311.10.3.42"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SYNC_ROOT_CTL_EXT"]/*' />
    [NativeTypeName("#define szOID_SYNC_ROOT_CTL_EXT \"1.3.6.1.4.1.311.10.3.50\"")]
    public static ReadOnlySpan<byte> szOID_SYNC_ROOT_CTL_EXT => "1.3.6.1.4.1.311.10.3.50"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_FLIGHT_CTL_EXT"]/*' />
    [NativeTypeName("#define szOID_FLIGHT_CTL_EXT \"1.3.6.1.4.1.311.10.3.51\"")]
    public static ReadOnlySpan<byte> szOID_FLIGHT_CTL_EXT => "1.3.6.1.4.1.311.10.3.51"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_LOG_LIST_EXT"]/*' />
    [NativeTypeName("#define szOID_CERT_LOG_LIST_EXT \"1.3.6.1.4.1.311.10.3.52\"")]
    public static ReadOnlySpan<byte> szOID_CERT_LOG_LIST_EXT => "1.3.6.1.4.1.311.10.3.52"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_HPKP_DOMAIN_NAME_CTL"]/*' />
    [NativeTypeName("#define szOID_HPKP_DOMAIN_NAME_CTL \"1.3.6.1.4.1.311.10.3.60\"")]
    public static ReadOnlySpan<byte> szOID_HPKP_DOMAIN_NAME_CTL => "1.3.6.1.4.1.311.10.3.60"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_HPKP_HEADER_VALUE_CTL"]/*' />
    [NativeTypeName("#define szOID_HPKP_HEADER_VALUE_CTL \"1.3.6.1.4.1.311.10.3.61\"")]
    public static ReadOnlySpan<byte> szOID_HPKP_HEADER_VALUE_CTL => "1.3.6.1.4.1.311.10.3.61"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING"]/*' />
    [NativeTypeName("#define szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING \"1.3.6.1.4.1.311.61.5.1\"")]
    public static ReadOnlySpan<byte> szOID_KP_KERNEL_MODE_HAL_EXTENSION_SIGNING => "1.3.6.1.4.1.311.61.5.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_WINDOWS_STORE_SIGNER"]/*' />
    [NativeTypeName("#define szOID_WINDOWS_STORE_SIGNER \"1.3.6.1.4.1.311.76.3.1\"")]
    public static ReadOnlySpan<byte> szOID_WINDOWS_STORE_SIGNER => "1.3.6.1.4.1.311.76.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DYNAMIC_CODE_GEN_SIGNER"]/*' />
    [NativeTypeName("#define szOID_DYNAMIC_CODE_GEN_SIGNER \"1.3.6.1.4.1.311.76.5.1\"")]
    public static ReadOnlySpan<byte> szOID_DYNAMIC_CODE_GEN_SIGNER => "1.3.6.1.4.1.311.76.5.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_MICROSOFT_PUBLISHER_SIGNER"]/*' />
    [NativeTypeName("#define szOID_MICROSOFT_PUBLISHER_SIGNER \"1.3.6.1.4.1.311.76.8.1\"")]
    public static ReadOnlySpan<byte> szOID_MICROSOFT_PUBLISHER_SIGNER => "1.3.6.1.4.1.311.76.8.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_YESNO_TRUST_ATTR"]/*' />
    [NativeTypeName("#define szOID_YESNO_TRUST_ATTR \"1.3.6.1.4.1.311.10.4.1\"")]
    public static ReadOnlySpan<byte> szOID_YESNO_TRUST_ATTR => "1.3.6.1.4.1.311.10.4.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SITE_PIN_RULES_INDEX_ATTR"]/*' />
    [NativeTypeName("#define szOID_SITE_PIN_RULES_INDEX_ATTR \"1.3.6.1.4.1.311.10.4.2\"")]
    public static ReadOnlySpan<byte> szOID_SITE_PIN_RULES_INDEX_ATTR => "1.3.6.1.4.1.311.10.4.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_SITE_PIN_RULES_FLAGS_ATTR"]/*' />
    [NativeTypeName("#define szOID_SITE_PIN_RULES_FLAGS_ATTR \"1.3.6.1.4.1.311.10.4.3\"")]
    public static ReadOnlySpan<byte> szOID_SITE_PIN_RULES_FLAGS_ATTR => "1.3.6.1.4.1.311.10.4.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_POLICY_QUALIFIER_CPS"]/*' />
    [NativeTypeName("#define szOID_PKIX_POLICY_QUALIFIER_CPS \"1.3.6.1.5.5.7.2.1\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_POLICY_QUALIFIER_CPS => "1.3.6.1.5.5.7.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_POLICY_QUALIFIER_USERNOTICE"]/*' />
    [NativeTypeName("#define szOID_PKIX_POLICY_QUALIFIER_USERNOTICE \"1.3.6.1.5.5.7.2.2\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_POLICY_QUALIFIER_USERNOTICE => "1.3.6.1.5.5.7.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROOT_PROGRAM_FLAGS"]/*' />
    [NativeTypeName("#define szOID_ROOT_PROGRAM_FLAGS \"1.3.6.1.4.1.311.60.1.1\"")]
    public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_FLAGS => "1.3.6.1.4.1.311.60.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_POLICIES_95_QUALIFIER1"]/*' />
    [NativeTypeName("#define szOID_CERT_POLICIES_95_QUALIFIER1 \"2.16.840.1.113733.1.7.1.1\"")]
    public static ReadOnlySpan<byte> szOID_CERT_POLICIES_95_QUALIFIER1 => "2.16.840.1.113733.1.7.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TPM_MANUFACTURER"]/*' />
    [NativeTypeName("#define szOID_RDN_TPM_MANUFACTURER \"2.23.133.2.1\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TPM_MANUFACTURER => "2.23.133.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TPM_MODEL"]/*' />
    [NativeTypeName("#define szOID_RDN_TPM_MODEL \"2.23.133.2.2\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TPM_MODEL => "2.23.133.2.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TPM_VERSION"]/*' />
    [NativeTypeName("#define szOID_RDN_TPM_VERSION \"2.23.133.2.3\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TPM_VERSION => "2.23.133.2.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TCG_PLATFORM_MANUFACTURER"]/*' />
    [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_MANUFACTURER \"2.23.133.2.4\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_MANUFACTURER => "2.23.133.2.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TCG_PLATFORM_MODEL"]/*' />
    [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_MODEL \"2.23.133.2.5\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_MODEL => "2.23.133.2.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_RDN_TCG_PLATFORM_VERSION"]/*' />
    [NativeTypeName("#define szOID_RDN_TCG_PLATFORM_VERSION \"2.23.133.2.6\"")]
    public static ReadOnlySpan<byte> szOID_RDN_TCG_PLATFORM_VERSION => "2.23.133.2.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CT_CERT_SCTLIST"]/*' />
    [NativeTypeName("#define szOID_CT_CERT_SCTLIST \"1.3.6.1.4.1.11129.2.4.2\"")]
    public static ReadOnlySpan<byte> szOID_CT_CERT_SCTLIST => "1.3.6.1.4.1.11129.2.4.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EK_INFO"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EK_INFO \"1.3.6.1.4.1.311.21.23\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EK_INFO => "1.3.6.1.4.1.311.21.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_AIK_INFO"]/*' />
    [NativeTypeName("#define szOID_ENROLL_AIK_INFO \"1.3.6.1.4.1.311.21.39\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_AIK_INFO => "1.3.6.1.4.1.311.21.39"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_ATTESTATION_STATEMENT"]/*' />
    [NativeTypeName("#define szOID_ENROLL_ATTESTATION_STATEMENT \"1.3.6.1.4.1.311.21.24\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_ATTESTATION_STATEMENT => "1.3.6.1.4.1.311.21.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_KSP_NAME"]/*' />
    [NativeTypeName("#define szOID_ENROLL_KSP_NAME \"1.3.6.1.4.1.311.21.25\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_KSP_NAME => "1.3.6.1.4.1.311.21.25"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EKPUB_CHALLENGE"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EKPUB_CHALLENGE \"1.3.6.1.4.1.311.21.26\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EKPUB_CHALLENGE => "1.3.6.1.4.1.311.21.26"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_CAXCHGCERT_HASH"]/*' />
    [NativeTypeName("#define szOID_ENROLL_CAXCHGCERT_HASH \"1.3.6.1.4.1.311.21.27\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_CAXCHGCERT_HASH => "1.3.6.1.4.1.311.21.27"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_ATTESTATION_CHALLENGE"]/*' />
    [NativeTypeName("#define szOID_ENROLL_ATTESTATION_CHALLENGE \"1.3.6.1.4.1.311.21.28\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_ATTESTATION_CHALLENGE => "1.3.6.1.4.1.311.21.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_ENCRYPTION_ALGORITHM"]/*' />
    [NativeTypeName("#define szOID_ENROLL_ENCRYPTION_ALGORITHM \"1.3.6.1.4.1.311.21.29\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_ENCRYPTION_ALGORITHM => "1.3.6.1.4.1.311.21.29"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_TPM_EK_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_KP_TPM_EK_CERTIFICATE \"2.23.133.8.1\"")]
    public static ReadOnlySpan<byte> szOID_KP_TPM_EK_CERTIFICATE => "2.23.133.8.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_TPM_PLATFORM_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_KP_TPM_PLATFORM_CERTIFICATE \"2.23.133.8.2\"")]
    public static ReadOnlySpan<byte> szOID_KP_TPM_PLATFORM_CERTIFICATE => "2.23.133.8.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_KP_TPM_AIK_CERTIFICATE"]/*' />
    [NativeTypeName("#define szOID_KP_TPM_AIK_CERTIFICATE \"2.23.133.8.3\"")]
    public static ReadOnlySpan<byte> szOID_KP_TPM_AIK_CERTIFICATE => "2.23.133.8.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EKVERIFYKEY"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EKVERIFYKEY \"1.3.6.1.4.1.311.21.30\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYKEY => "1.3.6.1.4.1.311.21.30"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EKVERIFYCERT"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EKVERIFYCERT \"1.3.6.1.4.1.311.21.31\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYCERT => "1.3.6.1.4.1.311.21.31"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EKVERIFYCREDS"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EKVERIFYCREDS \"1.3.6.1.4.1.311.21.32\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EKVERIFYCREDS => "1.3.6.1.4.1.311.21.32"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_ERROR"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_ERROR \"1.3.6.1.4.1.311.21.33\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_ERROR => "1.3.6.1.4.1.311.21.33"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_SERVER_STATE"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_STATE \"1.3.6.1.4.1.311.21.34\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_STATE => "1.3.6.1.4.1.311.21.34"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_CHALLENGE_ANSWER"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_CHALLENGE_ANSWER \"1.3.6.1.4.1.311.21.35\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_CHALLENGE_ANSWER => "1.3.6.1.4.1.311.21.35"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_CLIENT_REQUEST"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_CLIENT_REQUEST \"1.3.6.1.4.1.311.21.37\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_CLIENT_REQUEST => "1.3.6.1.4.1.311.21.37"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_SERVER_MESSAGE"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_MESSAGE \"1.3.6.1.4.1.311.21.38\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_MESSAGE => "1.3.6.1.4.1.311.21.38"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_SERVER_SECRET"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_SERVER_SECRET \"1.3.6.1.4.1.311.21.40\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SERVER_SECRET => "1.3.6.1.4.1.311.21.40"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_KEY_AFFINITY"]/*' />
    [NativeTypeName("#define szOID_ENROLL_KEY_AFFINITY \"1.3.6.1.4.1.311.21.41\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_KEY_AFFINITY => "1.3.6.1.4.1.311.21.41"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_SCEP_SIGNER_HASH"]/*' />
    [NativeTypeName("#define szOID_ENROLL_SCEP_SIGNER_HASH \"1.3.6.1.4.1.311.21.42\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_SCEP_SIGNER_HASH => "1.3.6.1.4.1.311.21.42"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_EK_CA_KEYID"]/*' />
    [NativeTypeName("#define szOID_ENROLL_EK_CA_KEYID \"1.3.6.1.4.1.311.21.43\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_EK_CA_KEYID => "1.3.6.1.4.1.311.21.43"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_V2_CONTAINER_NAME"]/*' />
    [NativeTypeName("#define szOID_ENROLL_V2_CONTAINER_NAME \"1.3.6.1.4.1.311.21.44\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_V2_CONTAINER_NAME => "1.3.6.1.4.1.311.21.44"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_V2_EK_ALGORITHM"]/*' />
    [NativeTypeName("#define szOID_ENROLL_V2_EK_ALGORITHM \"1.3.6.1.4.1.311.21.45\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_V2_EK_ALGORITHM => "1.3.6.1.4.1.311.21.45"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_V2_EK_PARAMETER"]/*' />
    [NativeTypeName("#define szOID_ENROLL_V2_EK_PARAMETER \"1.3.6.1.4.1.311.21.46\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_V2_EK_PARAMETER => "1.3.6.1.4.1.311.21.46"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_V2_AIK_INFO"]/*' />
    [NativeTypeName("#define szOID_ENROLL_V2_AIK_INFO \"1.3.6.1.4.1.311.21.47\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_V2_AIK_INFO => "1.3.6.1.4.1.311.21.47"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ENROLL_V2_ATTESTATION_STATEMENT"]/*' />
    [NativeTypeName("#define szOID_ENROLL_V2_ATTESTATION_STATEMENT \"1.3.6.1.4.1.311.21.48\"")]
    public static ReadOnlySpan<byte> szOID_ENROLL_V2_ATTESTATION_STATEMENT => "1.3.6.1.4.1.311.21.48"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERTSRV_V2_ATTESTATION_VERIFIED"]/*' />
    [NativeTypeName("#define szOID_CERTSRV_V2_ATTESTATION_VERIFIED \"1.3.6.1.4.1.311.21.49\"")]
    public static ReadOnlySpan<byte> szOID_CERTSRV_V2_ATTESTATION_VERIFIED => "1.3.6.1.4.1.311.21.49"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ATTR_SUPPORTED_ALGORITHMS"]/*' />
    [NativeTypeName("#define szOID_ATTR_SUPPORTED_ALGORITHMS \"2.5.4.52\"")]
    public static ReadOnlySpan<byte> szOID_ATTR_SUPPORTED_ALGORITHMS => "2.5.4.52"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ATTR_TPM_SPECIFICATION"]/*' />
    [NativeTypeName("#define szOID_ATTR_TPM_SPECIFICATION \"2.23.133.2.16\"")]
    public static ReadOnlySpan<byte> szOID_ATTR_TPM_SPECIFICATION => "2.23.133.2.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ATTR_PLATFORM_SPECIFICATION"]/*' />
    [NativeTypeName("#define szOID_ATTR_PLATFORM_SPECIFICATION \"2.23.133.2.17\"")]
    public static ReadOnlySpan<byte> szOID_ATTR_PLATFORM_SPECIFICATION => "2.23.133.2.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ATTR_TPM_SECURITY_ASSERTIONS"]/*' />
    [NativeTypeName("#define szOID_ATTR_TPM_SECURITY_ASSERTIONS \"2.23.133.2.18\"")]
    public static ReadOnlySpan<byte> szOID_ATTR_TPM_SECURITY_ASSERTIONS => "2.23.133.2.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_ACC_DESCR"]/*' />
    [NativeTypeName("#define szOID_PKIX_ACC_DESCR \"1.3.6.1.5.5.7.48\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_ACC_DESCR => "1.3.6.1.5.5.7.48"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_OCSP"]/*' />
    [NativeTypeName("#define szOID_PKIX_OCSP \"1.3.6.1.5.5.7.48.1\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_OCSP => "1.3.6.1.5.5.7.48.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_CA_ISSUERS"]/*' />
    [NativeTypeName("#define szOID_PKIX_CA_ISSUERS \"1.3.6.1.5.5.7.48.2\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_CA_ISSUERS => "1.3.6.1.5.5.7.48.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_TIME_STAMPING"]/*' />
    [NativeTypeName("#define szOID_PKIX_TIME_STAMPING \"1.3.6.1.5.5.7.48.3\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_TIME_STAMPING => "1.3.6.1.5.5.7.48.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_CA_REPOSITORY"]/*' />
    [NativeTypeName("#define szOID_PKIX_CA_REPOSITORY \"1.3.6.1.5.5.7.48.5\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_CA_REPOSITORY => "1.3.6.1.5.5.7.48.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_QC_EU_COMPLIANCE"]/*' />
    [NativeTypeName("#define szOID_QC_EU_COMPLIANCE \"0.4.0.1862.1.1\"")]
    public static ReadOnlySpan<byte> szOID_QC_EU_COMPLIANCE => "0.4.0.1862.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_QC_SSCD"]/*' />
    [NativeTypeName("#define szOID_QC_SSCD \"0.4.0.1862.1.4\"")]
    public static ReadOnlySpan<byte> szOID_QC_SSCD => "0.4.0.1862.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_VERISIGN_PRIVATE_6_9"]/*' />
    [NativeTypeName("#define szOID_VERISIGN_PRIVATE_6_9 \"2.16.840.1.113733.1.6.9\"")]
    public static ReadOnlySpan<byte> szOID_VERISIGN_PRIVATE_6_9 => "2.16.840.1.113733.1.6.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_VERISIGN_ONSITE_JURISDICTION_HASH"]/*' />
    [NativeTypeName("#define szOID_VERISIGN_ONSITE_JURISDICTION_HASH \"2.16.840.1.113733.1.6.11\"")]
    public static ReadOnlySpan<byte> szOID_VERISIGN_ONSITE_JURISDICTION_HASH => "2.16.840.1.113733.1.6.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_VERISIGN_BITSTRING_6_13"]/*' />
    [NativeTypeName("#define szOID_VERISIGN_BITSTRING_6_13 \"2.16.840.1.113733.1.6.13\"")]
    public static ReadOnlySpan<byte> szOID_VERISIGN_BITSTRING_6_13 => "2.16.840.1.113733.1.6.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_VERISIGN_ISS_STRONG_CRYPTO"]/*' />
    [NativeTypeName("#define szOID_VERISIGN_ISS_STRONG_CRYPTO \"2.16.840.1.113733.1.8.1\"")]
    public static ReadOnlySpan<byte> szOID_VERISIGN_ISS_STRONG_CRYPTO => "2.16.840.1.113733.1.8.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE \"2.16.840.1.113730\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE => "2.16.840.1.113730"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CERT_EXTENSION"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CERT_EXTENSION \"2.16.840.1.113730.1\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_EXTENSION => "2.16.840.1.113730.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CERT_TYPE"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CERT_TYPE \"2.16.840.1.113730.1.1\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_TYPE => "2.16.840.1.113730.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_BASE_URL"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_BASE_URL \"2.16.840.1.113730.1.2\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_BASE_URL => "2.16.840.1.113730.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_REVOCATION_URL"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_REVOCATION_URL \"2.16.840.1.113730.1.3\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_REVOCATION_URL => "2.16.840.1.113730.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CA_REVOCATION_URL"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CA_REVOCATION_URL \"2.16.840.1.113730.1.4\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CA_REVOCATION_URL => "2.16.840.1.113730.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CERT_RENEWAL_URL"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CERT_RENEWAL_URL \"2.16.840.1.113730.1.7\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_RENEWAL_URL => "2.16.840.1.113730.1.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CA_POLICY_URL"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CA_POLICY_URL \"2.16.840.1.113730.1.8\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CA_POLICY_URL => "2.16.840.1.113730.1.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_SSL_SERVER_NAME"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_SSL_SERVER_NAME \"2.16.840.1.113730.1.12\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_SSL_SERVER_NAME => "2.16.840.1.113730.1.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_COMMENT"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_COMMENT \"2.16.840.1.113730.1.13\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_COMMENT => "2.16.840.1.113730.1.13"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_DATA_TYPE"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_DATA_TYPE \"2.16.840.1.113730.2\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_DATA_TYPE => "2.16.840.1.113730.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NETSCAPE_CERT_SEQUENCE"]/*' />
    [NativeTypeName("#define szOID_NETSCAPE_CERT_SEQUENCE \"2.16.840.1.113730.2.5\"")]
    public static ReadOnlySpan<byte> szOID_NETSCAPE_CERT_SEQUENCE => "2.16.840.1.113730.2.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CT_PKI_DATA"]/*' />
    [NativeTypeName("#define szOID_CT_PKI_DATA \"1.3.6.1.5.5.7.12.2\"")]
    public static ReadOnlySpan<byte> szOID_CT_PKI_DATA => "1.3.6.1.5.5.7.12.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CT_PKI_RESPONSE"]/*' />
    [NativeTypeName("#define szOID_CT_PKI_RESPONSE \"1.3.6.1.5.5.7.12.3\"")]
    public static ReadOnlySpan<byte> szOID_CT_PKI_RESPONSE => "1.3.6.1.5.5.7.12.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_NO_SIGNATURE"]/*' />
    [NativeTypeName("#define szOID_PKIX_NO_SIGNATURE \"1.3.6.1.5.5.7.6.2\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_NO_SIGNATURE => "1.3.6.1.5.5.7.6.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC"]/*' />
    [NativeTypeName("#define szOID_CMC \"1.3.6.1.5.5.7.7\"")]
    public static ReadOnlySpan<byte> szOID_CMC => "1.3.6.1.5.5.7.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_STATUS_INFO"]/*' />
    [NativeTypeName("#define szOID_CMC_STATUS_INFO \"1.3.6.1.5.5.7.7.1\"")]
    public static ReadOnlySpan<byte> szOID_CMC_STATUS_INFO => "1.3.6.1.5.5.7.7.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_IDENTIFICATION"]/*' />
    [NativeTypeName("#define szOID_CMC_IDENTIFICATION \"1.3.6.1.5.5.7.7.2\"")]
    public static ReadOnlySpan<byte> szOID_CMC_IDENTIFICATION => "1.3.6.1.5.5.7.7.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_IDENTITY_PROOF"]/*' />
    [NativeTypeName("#define szOID_CMC_IDENTITY_PROOF \"1.3.6.1.5.5.7.7.3\"")]
    public static ReadOnlySpan<byte> szOID_CMC_IDENTITY_PROOF => "1.3.6.1.5.5.7.7.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_DATA_RETURN"]/*' />
    [NativeTypeName("#define szOID_CMC_DATA_RETURN \"1.3.6.1.5.5.7.7.4\"")]
    public static ReadOnlySpan<byte> szOID_CMC_DATA_RETURN => "1.3.6.1.5.5.7.7.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_TRANSACTION_ID"]/*' />
    [NativeTypeName("#define szOID_CMC_TRANSACTION_ID \"1.3.6.1.5.5.7.7.5\"")]
    public static ReadOnlySpan<byte> szOID_CMC_TRANSACTION_ID => "1.3.6.1.5.5.7.7.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_SENDER_NONCE"]/*' />
    [NativeTypeName("#define szOID_CMC_SENDER_NONCE \"1.3.6.1.5.5.7.7.6\"")]
    public static ReadOnlySpan<byte> szOID_CMC_SENDER_NONCE => "1.3.6.1.5.5.7.7.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_RECIPIENT_NONCE"]/*' />
    [NativeTypeName("#define szOID_CMC_RECIPIENT_NONCE \"1.3.6.1.5.5.7.7.7\"")]
    public static ReadOnlySpan<byte> szOID_CMC_RECIPIENT_NONCE => "1.3.6.1.5.5.7.7.7"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ADD_EXTENSIONS"]/*' />
    [NativeTypeName("#define szOID_CMC_ADD_EXTENSIONS \"1.3.6.1.5.5.7.7.8\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ADD_EXTENSIONS => "1.3.6.1.5.5.7.7.8"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ENCRYPTED_POP"]/*' />
    [NativeTypeName("#define szOID_CMC_ENCRYPTED_POP \"1.3.6.1.5.5.7.7.9\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ENCRYPTED_POP => "1.3.6.1.5.5.7.7.9"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_DECRYPTED_POP"]/*' />
    [NativeTypeName("#define szOID_CMC_DECRYPTED_POP \"1.3.6.1.5.5.7.7.10\"")]
    public static ReadOnlySpan<byte> szOID_CMC_DECRYPTED_POP => "1.3.6.1.5.5.7.7.10"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_LRA_POP_WITNESS"]/*' />
    [NativeTypeName("#define szOID_CMC_LRA_POP_WITNESS \"1.3.6.1.5.5.7.7.11\"")]
    public static ReadOnlySpan<byte> szOID_CMC_LRA_POP_WITNESS => "1.3.6.1.5.5.7.7.11"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_GET_CERT"]/*' />
    [NativeTypeName("#define szOID_CMC_GET_CERT \"1.3.6.1.5.5.7.7.15\"")]
    public static ReadOnlySpan<byte> szOID_CMC_GET_CERT => "1.3.6.1.5.5.7.7.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_GET_CRL"]/*' />
    [NativeTypeName("#define szOID_CMC_GET_CRL \"1.3.6.1.5.5.7.7.16\"")]
    public static ReadOnlySpan<byte> szOID_CMC_GET_CRL => "1.3.6.1.5.5.7.7.16"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_REVOKE_REQUEST"]/*' />
    [NativeTypeName("#define szOID_CMC_REVOKE_REQUEST \"1.3.6.1.5.5.7.7.17\"")]
    public static ReadOnlySpan<byte> szOID_CMC_REVOKE_REQUEST => "1.3.6.1.5.5.7.7.17"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_REG_INFO"]/*' />
    [NativeTypeName("#define szOID_CMC_REG_INFO \"1.3.6.1.5.5.7.7.18\"")]
    public static ReadOnlySpan<byte> szOID_CMC_REG_INFO => "1.3.6.1.5.5.7.7.18"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_RESPONSE_INFO"]/*' />
    [NativeTypeName("#define szOID_CMC_RESPONSE_INFO \"1.3.6.1.5.5.7.7.19\"")]
    public static ReadOnlySpan<byte> szOID_CMC_RESPONSE_INFO => "1.3.6.1.5.5.7.7.19"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_QUERY_PENDING"]/*' />
    [NativeTypeName("#define szOID_CMC_QUERY_PENDING \"1.3.6.1.5.5.7.7.21\"")]
    public static ReadOnlySpan<byte> szOID_CMC_QUERY_PENDING => "1.3.6.1.5.5.7.7.21"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ID_POP_LINK_RANDOM"]/*' />
    [NativeTypeName("#define szOID_CMC_ID_POP_LINK_RANDOM \"1.3.6.1.5.5.7.7.22\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ID_POP_LINK_RANDOM => "1.3.6.1.5.5.7.7.22"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ID_POP_LINK_WITNESS"]/*' />
    [NativeTypeName("#define szOID_CMC_ID_POP_LINK_WITNESS \"1.3.6.1.5.5.7.7.23\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ID_POP_LINK_WITNESS => "1.3.6.1.5.5.7.7.23"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE"]/*' />
    [NativeTypeName("#define szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE \"1.3.6.1.5.5.7.7.24\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE => "1.3.6.1.5.5.7.7.24"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CMC_ADD_ATTRIBUTES"]/*' />
    [NativeTypeName("#define szOID_CMC_ADD_ATTRIBUTES \"1.3.6.1.4.1.311.10.10.1\"")]
    public static ReadOnlySpan<byte> szOID_CMC_ADD_ATTRIBUTES => "1.3.6.1.4.1.311.10.10.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_LOYALTY_OTHER_LOGOTYPE"]/*' />
    [NativeTypeName("#define szOID_LOYALTY_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.1\"")]
    public static ReadOnlySpan<byte> szOID_LOYALTY_OTHER_LOGOTYPE => "1.3.6.1.5.5.7.20.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_BACKGROUND_OTHER_LOGOTYPE"]/*' />
    [NativeTypeName("#define szOID_BACKGROUND_OTHER_LOGOTYPE \"1.3.6.1.5.5.7.20.2\"")]
    public static ReadOnlySpan<byte> szOID_BACKGROUND_OTHER_LOGOTYPE => "1.3.6.1.5.5.7.20.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE"]/*' />
    [NativeTypeName("#define szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE \"1.3.6.1.5.5.7.48.1.1\"")]
    public static ReadOnlySpan<byte> szOID_PKIX_OCSP_BASIC_SIGNED_RESPONSE => "1.3.6.1.5.5.7.48.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_SIGN_OS_PREFIX"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_PREFIX \"1.3.6.1.4.1.311.72.1.\"")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_PREFIX => "1.3.6.1.4.1.311.72.1."u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_SIGN_OS_1"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_1 \"1.3.6.1.4.1.311.72.1.1\"")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_1 => "1.3.6.1.4.1.311.72.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_SIGN_OS_CURRENT"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_SIGN_OS_CURRENT szOID_CERT_STRONG_SIGN_OS_1")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_SIGN_OS_CURRENT => "1.3.6.1.4.1.311.72.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_KEY_OS_PREFIX"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_PREFIX \"1.3.6.1.4.1.311.72.2.\"")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_PREFIX => "1.3.6.1.4.1.311.72.2."u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_KEY_OS_1"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_1 \"1.3.6.1.4.1.311.72.2.1\"")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_1 => "1.3.6.1.4.1.311.72.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_STRONG_KEY_OS_CURRENT"]/*' />
    [NativeTypeName("#define szOID_CERT_STRONG_KEY_OS_CURRENT szOID_CERT_STRONG_KEY_OS_1")]
    public static ReadOnlySpan<byte> szOID_CERT_STRONG_KEY_OS_CURRENT => "1.3.6.1.4.1.311.72.2.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_NO_HASH"]/*' />
    [NativeTypeName("#define szOID_NO_HASH \"1.3.6.1.4.1.311.73.1\"")]
    public static ReadOnlySpan<byte> szOID_NO_HASH => "1.3.6.1.4.1.311.73.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PREHASH"]/*' />
    [NativeTypeName("#define szOID_PREHASH \"1.3.6.1.4.1.311.73.2\"")]
    public static ReadOnlySpan<byte> szOID_PREHASH => "1.3.6.1.4.1.311.73.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_DATA"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_DATA \"1.2.840.113549.1.7.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_DATA => "1.2.840.113549.1.7.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_SIGNED"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_SIGNED \"1.2.840.113549.1.7.2\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_SIGNED => "1.2.840.113549.1.7.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_ENVELOPED"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_ENVELOPED \"1.2.840.113549.1.7.3\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_ENVELOPED => "1.2.840.113549.1.7.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_SIGNEDANDENVELOPED"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_SIGNEDANDENVELOPED \"1.2.840.113549.1.7.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_SIGNEDANDENVELOPED => "1.2.840.113549.1.7.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_DIGESTED"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_DIGESTED \"1.2.840.113549.1.7.5\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_DIGESTED => "1.2.840.113549.1.7.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_7_ENCRYPTED"]/*' />
    [NativeTypeName("#define szOID_PKCS_7_ENCRYPTED \"1.2.840.113549.1.7.6\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_7_ENCRYPTED => "1.2.840.113549.1.7.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_9_CONTENT_TYPE"]/*' />
    [NativeTypeName("#define szOID_PKCS_9_CONTENT_TYPE \"1.2.840.113549.1.9.3\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_9_CONTENT_TYPE => "1.2.840.113549.1.9.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_9_MESSAGE_DIGEST"]/*' />
    [NativeTypeName("#define szOID_PKCS_9_MESSAGE_DIGEST \"1.2.840.113549.1.9.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_9_MESSAGE_DIGEST => "1.2.840.113549.1.9.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ORI_KEM"]/*' />
    [NativeTypeName("#define szOID_ORI_KEM \"1.2.840.113549.1.9.16.13.3\"")]
    public static ReadOnlySpan<byte> szOID_ORI_KEM => "1.2.840.113549.1.9.16.13.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_PROP_ID_PREFIX"]/*' />
    [NativeTypeName("#define szOID_CERT_PROP_ID_PREFIX \"1.3.6.1.4.1.311.10.11.\"")]
    public static ReadOnlySpan<byte> szOID_CERT_PROP_ID_PREFIX => "1.3.6.1.4.1.311.10.11."u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_KEY_IDENTIFIER_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_KEY_IDENTIFIER_PROP_ID \"1.3.6.1.4.1.311.10.11.20\"")]
    public static ReadOnlySpan<byte> szOID_CERT_KEY_IDENTIFIER_PROP_ID => "1.3.6.1.4.1.311.10.11.20"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.28\"")]
    public static ReadOnlySpan<byte> szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID => "1.3.6.1.4.1.311.10.11.28"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.29\"")]
    public static ReadOnlySpan<byte> szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID => "1.3.6.1.4.1.311.10.11.29"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_MD5_HASH_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_MD5_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.4\"")]
    public static ReadOnlySpan<byte> szOID_CERT_MD5_HASH_PROP_ID => "1.3.6.1.4.1.311.10.11.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_SHA256_HASH_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_SHA256_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.107\"")]
    public static ReadOnlySpan<byte> szOID_CERT_SHA256_HASH_PROP_ID => "1.3.6.1.4.1.311.10.11.107"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_SIGNATURE_HASH_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_SIGNATURE_HASH_PROP_ID \"1.3.6.1.4.1.311.10.11.15\"")]
    public static ReadOnlySpan<byte> szOID_CERT_SIGNATURE_HASH_PROP_ID => "1.3.6.1.4.1.311.10.11.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_DISALLOWED_HASH"]/*' />
    [NativeTypeName("#define szOID_DISALLOWED_HASH szOID_CERT_SIGNATURE_HASH_PROP_ID")]
    public static ReadOnlySpan<byte> szOID_DISALLOWED_HASH => "1.3.6.1.4.1.311.10.11.15"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_DISALLOWED_FILETIME_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_DISALLOWED_FILETIME_PROP_ID \"1.3.6.1.4.1.311.10.11.104\"")]
    public static ReadOnlySpan<byte> szOID_CERT_DISALLOWED_FILETIME_PROP_ID => "1.3.6.1.4.1.311.10.11.104"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_CERT_DISALLOWED_CA_FILETIME_PROP_ID"]/*' />
    [NativeTypeName("#define szOID_CERT_DISALLOWED_CA_FILETIME_PROP_ID \"1.3.6.1.4.1.311.10.11.128\"")]
    public static ReadOnlySpan<byte> szOID_CERT_DISALLOWED_CA_FILETIME_PROP_ID => "1.3.6.1.4.1.311.10.11.128"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION"]/*' />
    [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION \"1.3.6.1.4.1.311.60.3.1\"")]
    public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION => "1.3.6.1.4.1.311.60.3.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION"]/*' />
    [NativeTypeName("#define szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION \"1.3.6.1.4.1.311.60.3.2\"")]
    public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION => "1.3.6.1.4.1.311.60.3.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL"]/*' />
    [NativeTypeName("#define szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL \"1.3.6.1.4.1.311.60.3.3\"")]
    public static ReadOnlySpan<byte> szOID_ROOT_PROGRAM_NO_OCSP_FAILOVER_TO_CRL => "1.3.6.1.4.1.311.60.3.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_PbeIds"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_PbeIds \"1.2.840.113549.1.12.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_PbeIds => "1.2.840.113549.1.12.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And128BitRC4"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And128BitRC4 \"1.2.840.113549.1.12.1.1\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And128BitRC4 => "1.2.840.113549.1.12.1.1"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And40BitRC4"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And40BitRC4 \"1.2.840.113549.1.12.1.2\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And40BitRC4 => "1.2.840.113549.1.12.1.2"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES \"1.2.840.113549.1.12.1.3\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And3KeyTripleDES => "1.2.840.113549.1.12.1.3"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES \"1.2.840.113549.1.12.1.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And2KeyTripleDES => "1.2.840.113549.1.12.1.4"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And128BitRC2"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And128BitRC2 \"1.2.840.113549.1.12.1.5\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And128BitRC2 => "1.2.840.113549.1.12.1.5"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_12_pbeWithSHA1And40BitRC2"]/*' />
    [NativeTypeName("#define szOID_PKCS_12_pbeWithSHA1And40BitRC2 \"1.2.840.113549.1.12.1.6\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_12_pbeWithSHA1And40BitRC2 => "1.2.840.113549.1.12.1.6"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_5_PBKDF2"]/*' />
    [NativeTypeName("#define szOID_PKCS_5_PBKDF2 \"1.2.840.113549.1.5.12\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_5_PBKDF2 => "1.2.840.113549.1.5.12"u8;

    /// <include file='szOID.xml' path='doc/member[@name="szOID.szOID_PKCS_5_PBES2"]/*' />
    [NativeTypeName("#define szOID_PKCS_5_PBES2 \"1.2.840.113549.1.5.13\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_5_PBES2 => "1.2.840.113549.1.5.13"u8;
}
