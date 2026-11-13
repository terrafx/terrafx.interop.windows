// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Globalization;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define HCCE_CURRENT_USER ((HCERTCHAINENGINE)NULL)")]
    public static HCERTCHAINENGINE HCCE_CURRENT_USER => ((HCERTCHAINENGINE)(NULL));

    [NativeTypeName("#define HCCE_LOCAL_MACHINE ((HCERTCHAINENGINE)0x1)")]
    public static HCERTCHAINENGINE HCCE_LOCAL_MACHINE => ((HCERTCHAINENGINE)(0x1));

    [NativeTypeName("#define HCCE_SERIAL_LOCAL_MACHINE ((HCERTCHAINENGINE)0x2)")]
    public static HCERTCHAINENGINE HCCE_SERIAL_LOCAL_MACHINE => ((HCERTCHAINENGINE)(0x2));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_ALG_CLASS(uint x) => x & (7u << 13);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_ALG_TYPE(uint x) => x & (15u << 9);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_ALG_SID(uint x) => x & 0x1FFu;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_ENCODING_TYPE(uint x) => x & (uint)CERT.CERT_ENCODING_TYPE_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CMSG_ENCODING_TYPE(uint x) => x & CMSG.CMSG_ENCODING_TYPE_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_UNICODE_RDN_ERR_INDEX(uint x)
        => (x >> CERT.CERT_UNICODE_RDN_ERR_INDEX_SHIFT) & (uint)CERT.CERT_UNICODE_RDN_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_UNICODE_ATTR_ERR_INDEX(uint x)
        => (x >> CERT.CERT_UNICODE_ATTR_ERR_INDEX_SHIFT) & (uint)CERT.CERT_UNICODE_ATTR_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_UNICODE_VALUE_ERR_INDEX(uint x)
        => x & (uint)CERT.CERT_UNICODE_VALUE_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_ALT_NAME_ENTRY_ERR_INDEX(uint x)
        => (x >> CERT.CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT) & (uint)CERT.CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CERT_ALT_NAME_VALUE_ERR_INDEX(uint x)
        => x & (uint)CERT.CERT_ALT_NAME_VALUE_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CRL_DIST_POINT_ERR_INDEX(uint x)
        => (x >> CRL.CRL_DIST_POINT_ERR_INDEX_SHIFT) & (uint)CRL.CRL_DIST_POINT_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_CROSS_CERT_DIST_POINT_ERR_INDEX(uint x)
        => (x >> CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT) & (uint)CROSS_CERT_DIST_POINT_ERR_INDEX_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_CRL_DIST_POINT_ERR_CRL_ISSUER(uint x)
        => (x & CRL.CRL_DIST_POINT_ERR_CRL_ISSUER_BIT) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_CERT_EXCLUDED_SUBTREE(uint x)
        => (x & CERT.CERT_EXCLUDED_SUBTREE_BIT) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_CERT_RDN_CHAR_STRING(uint x)
        => (x & (uint)CERT.CERT_RDN_TYPE_MASK) >= (uint)CERT.CERT_RDN_NUMERIC_STRING;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_SPECIAL_OID_INFO_ALGID(uint algid)
        => algid >= CALG.CALG_OID_INFO_PQ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_CERT_HASH_PROP_ID(uint x)
        => (x == (uint)CERT.CERT_SHA1_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_MD5_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SHA256_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SHA1_SHA256_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SIGNATURE_HASH_PROP_ID);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_PUBKEY_HASH_PROP_ID(uint x)
        => (x == (uint)CERT.CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_PIN_SHA256_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_CHAIN_HASH_PROP_ID(uint x)
        => (x == (uint)CERT.CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID)
        || (x == (uint)CERT.CERT_SUBJECT_NAME_MD5_HASH_PROP_ID);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_STRONG_SIGN_PROP_ID(uint x)
        => (x == (uint)CERT.CERT_SIGN_HASH_CNG_ALG_PROP_ID)
        || (x == (uint)CERT.CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID)
        || (x == (uint)CERT.CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool RCRYPT_SUCCEEDED(int rt) => rt == CRYPT.CRYPT_SUCCEED;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool RCRYPT_FAILED(int rt) => rt == CRYPT.CRYPT_FAILED;

    public static string szOID_CERT_PROP_ID(uint PropId)
        => string.Concat("1.3.6.1.4.1.311.10.11.", PropId.ToString(CultureInfo.InvariantCulture));

    public static string wszOID_CERT_PROP_ID(uint PropId)
        => szOID_CERT_PROP_ID(PropId);
}
