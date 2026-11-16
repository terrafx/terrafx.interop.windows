// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SEC
{
    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_OK"]/*' />
    [NativeTypeName("#define SEC_E_OK ((HRESULT)0x00000000L)")]
    public const int SEC_E_OK = ((int)(0x00000000));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INSUFFICIENT_MEMORY"]/*' />
    [NativeTypeName("#define SEC_E_INSUFFICIENT_MEMORY _HRESULT_TYPEDEF_(0x80090300L)")]
    public const int SEC_E_INSUFFICIENT_MEMORY = unchecked((int)(0x80090300));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define SEC_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80090301L)")]
    public const int SEC_E_INVALID_HANDLE = unchecked((int)(0x80090301));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_UNSUPPORTED_FUNCTION"]/*' />
    [NativeTypeName("#define SEC_E_UNSUPPORTED_FUNCTION _HRESULT_TYPEDEF_(0x80090302L)")]
    public const int SEC_E_UNSUPPORTED_FUNCTION = unchecked((int)(0x80090302));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_TARGET_UNKNOWN"]/*' />
    [NativeTypeName("#define SEC_E_TARGET_UNKNOWN _HRESULT_TYPEDEF_(0x80090303L)")]
    public const int SEC_E_TARGET_UNKNOWN = unchecked((int)(0x80090303));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define SEC_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80090304L)")]
    public const int SEC_E_INTERNAL_ERROR = unchecked((int)(0x80090304));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SECPKG_NOT_FOUND"]/*' />
    [NativeTypeName("#define SEC_E_SECPKG_NOT_FOUND _HRESULT_TYPEDEF_(0x80090305L)")]
    public const int SEC_E_SECPKG_NOT_FOUND = unchecked((int)(0x80090305));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NOT_OWNER"]/*' />
    [NativeTypeName("#define SEC_E_NOT_OWNER _HRESULT_TYPEDEF_(0x80090306L)")]
    public const int SEC_E_NOT_OWNER = unchecked((int)(0x80090306));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CANNOT_INSTALL"]/*' />
    [NativeTypeName("#define SEC_E_CANNOT_INSTALL _HRESULT_TYPEDEF_(0x80090307L)")]
    public const int SEC_E_CANNOT_INSTALL = unchecked((int)(0x80090307));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INVALID_TOKEN"]/*' />
    [NativeTypeName("#define SEC_E_INVALID_TOKEN _HRESULT_TYPEDEF_(0x80090308L)")]
    public const int SEC_E_INVALID_TOKEN = unchecked((int)(0x80090308));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CANNOT_PACK"]/*' />
    [NativeTypeName("#define SEC_E_CANNOT_PACK _HRESULT_TYPEDEF_(0x80090309L)")]
    public const int SEC_E_CANNOT_PACK = unchecked((int)(0x80090309));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_QOP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define SEC_E_QOP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009030AL)")]
    public const int SEC_E_QOP_NOT_SUPPORTED = unchecked((int)(0x8009030A));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_IMPERSONATION"]/*' />
    [NativeTypeName("#define SEC_E_NO_IMPERSONATION _HRESULT_TYPEDEF_(0x8009030BL)")]
    public const int SEC_E_NO_IMPERSONATION = unchecked((int)(0x8009030B));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_LOGON_DENIED"]/*' />
    [NativeTypeName("#define SEC_E_LOGON_DENIED _HRESULT_TYPEDEF_(0x8009030CL)")]
    public const int SEC_E_LOGON_DENIED = unchecked((int)(0x8009030C));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_UNKNOWN_CREDENTIALS"]/*' />
    [NativeTypeName("#define SEC_E_UNKNOWN_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030DL)")]
    public const int SEC_E_UNKNOWN_CREDENTIALS = unchecked((int)(0x8009030D));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_CREDENTIALS"]/*' />
    [NativeTypeName("#define SEC_E_NO_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030EL)")]
    public const int SEC_E_NO_CREDENTIALS = unchecked((int)(0x8009030E));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_MESSAGE_ALTERED"]/*' />
    [NativeTypeName("#define SEC_E_MESSAGE_ALTERED _HRESULT_TYPEDEF_(0x8009030FL)")]
    public const int SEC_E_MESSAGE_ALTERED = unchecked((int)(0x8009030F));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_OUT_OF_SEQUENCE"]/*' />
    [NativeTypeName("#define SEC_E_OUT_OF_SEQUENCE _HRESULT_TYPEDEF_(0x80090310L)")]
    public const int SEC_E_OUT_OF_SEQUENCE = unchecked((int)(0x80090310));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_AUTHENTICATING_AUTHORITY"]/*' />
    [NativeTypeName("#define SEC_E_NO_AUTHENTICATING_AUTHORITY _HRESULT_TYPEDEF_(0x80090311L)")]
    public const int SEC_E_NO_AUTHENTICATING_AUTHORITY = unchecked((int)(0x80090311));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_CONTINUE_NEEDED"]/*' />
    [NativeTypeName("#define SEC_I_CONTINUE_NEEDED _HRESULT_TYPEDEF_(0x00090312L)")]
    public const int SEC_I_CONTINUE_NEEDED = ((int)(0x00090312));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_COMPLETE_NEEDED"]/*' />
    [NativeTypeName("#define SEC_I_COMPLETE_NEEDED _HRESULT_TYPEDEF_(0x00090313L)")]
    public const int SEC_I_COMPLETE_NEEDED = ((int)(0x00090313));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_COMPLETE_AND_CONTINUE"]/*' />
    [NativeTypeName("#define SEC_I_COMPLETE_AND_CONTINUE _HRESULT_TYPEDEF_(0x00090314L)")]
    public const int SEC_I_COMPLETE_AND_CONTINUE = ((int)(0x00090314));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_LOCAL_LOGON"]/*' />
    [NativeTypeName("#define SEC_I_LOCAL_LOGON _HRESULT_TYPEDEF_(0x00090315L)")]
    public const int SEC_I_LOCAL_LOGON = ((int)(0x00090315));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_GENERIC_EXTENSION_RECEIVED"]/*' />
    [NativeTypeName("#define SEC_I_GENERIC_EXTENSION_RECEIVED _HRESULT_TYPEDEF_(0x00090316L)")]
    public const int SEC_I_GENERIC_EXTENSION_RECEIVED = ((int)(0x00090316));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_BAD_PKGID"]/*' />
    [NativeTypeName("#define SEC_E_BAD_PKGID _HRESULT_TYPEDEF_(0x80090316L)")]
    public const int SEC_E_BAD_PKGID = unchecked((int)(0x80090316));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CONTEXT_EXPIRED"]/*' />
    [NativeTypeName("#define SEC_E_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x80090317L)")]
    public const int SEC_E_CONTEXT_EXPIRED = unchecked((int)(0x80090317));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_CONTEXT_EXPIRED"]/*' />
    [NativeTypeName("#define SEC_I_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x00090317L)")]
    public const int SEC_I_CONTEXT_EXPIRED = ((int)(0x00090317));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INCOMPLETE_MESSAGE"]/*' />
    [NativeTypeName("#define SEC_E_INCOMPLETE_MESSAGE _HRESULT_TYPEDEF_(0x80090318L)")]
    public const int SEC_E_INCOMPLETE_MESSAGE = unchecked((int)(0x80090318));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INCOMPLETE_CREDENTIALS"]/*' />
    [NativeTypeName("#define SEC_E_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x80090320L)")]
    public const int SEC_E_INCOMPLETE_CREDENTIALS = unchecked((int)(0x80090320));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define SEC_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80090321L)")]
    public const int SEC_E_BUFFER_TOO_SMALL = unchecked((int)(0x80090321));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_INCOMPLETE_CREDENTIALS"]/*' />
    [NativeTypeName("#define SEC_I_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x00090320L)")]
    public const int SEC_I_INCOMPLETE_CREDENTIALS = ((int)(0x00090320));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_RENEGOTIATE"]/*' />
    [NativeTypeName("#define SEC_I_RENEGOTIATE _HRESULT_TYPEDEF_(0x00090321L)")]
    public const int SEC_I_RENEGOTIATE = ((int)(0x00090321));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_WRONG_PRINCIPAL"]/*' />
    [NativeTypeName("#define SEC_E_WRONG_PRINCIPAL _HRESULT_TYPEDEF_(0x80090322L)")]
    public const int SEC_E_WRONG_PRINCIPAL = unchecked((int)(0x80090322));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_NO_LSA_CONTEXT"]/*' />
    [NativeTypeName("#define SEC_I_NO_LSA_CONTEXT _HRESULT_TYPEDEF_(0x00090323L)")]
    public const int SEC_I_NO_LSA_CONTEXT = ((int)(0x00090323));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_TIME_SKEW"]/*' />
    [NativeTypeName("#define SEC_E_TIME_SKEW _HRESULT_TYPEDEF_(0x80090324L)")]
    public const int SEC_E_TIME_SKEW = unchecked((int)(0x80090324));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_UNTRUSTED_ROOT"]/*' />
    [NativeTypeName("#define SEC_E_UNTRUSTED_ROOT _HRESULT_TYPEDEF_(0x80090325L)")]
    public const int SEC_E_UNTRUSTED_ROOT = unchecked((int)(0x80090325));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ILLEGAL_MESSAGE"]/*' />
    [NativeTypeName("#define SEC_E_ILLEGAL_MESSAGE _HRESULT_TYPEDEF_(0x80090326L)")]
    public const int SEC_E_ILLEGAL_MESSAGE = unchecked((int)(0x80090326));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CERT_UNKNOWN"]/*' />
    [NativeTypeName("#define SEC_E_CERT_UNKNOWN _HRESULT_TYPEDEF_(0x80090327L)")]
    public const int SEC_E_CERT_UNKNOWN = unchecked((int)(0x80090327));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define SEC_E_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090328L)")]
    public const int SEC_E_CERT_EXPIRED = unchecked((int)(0x80090328));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ENCRYPT_FAILURE"]/*' />
    [NativeTypeName("#define SEC_E_ENCRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090329L)")]
    public const int SEC_E_ENCRYPT_FAILURE = unchecked((int)(0x80090329));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_DECRYPT_FAILURE"]/*' />
    [NativeTypeName("#define SEC_E_DECRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090330L)")]
    public const int SEC_E_DECRYPT_FAILURE = unchecked((int)(0x80090330));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ALGORITHM_MISMATCH"]/*' />
    [NativeTypeName("#define SEC_E_ALGORITHM_MISMATCH _HRESULT_TYPEDEF_(0x80090331L)")]
    public const int SEC_E_ALGORITHM_MISMATCH = unchecked((int)(0x80090331));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SECURITY_QOS_FAILED"]/*' />
    [NativeTypeName("#define SEC_E_SECURITY_QOS_FAILED _HRESULT_TYPEDEF_(0x80090332L)")]
    public const int SEC_E_SECURITY_QOS_FAILED = unchecked((int)(0x80090332));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_UNFINISHED_CONTEXT_DELETED"]/*' />
    [NativeTypeName("#define SEC_E_UNFINISHED_CONTEXT_DELETED _HRESULT_TYPEDEF_(0x80090333L)")]
    public const int SEC_E_UNFINISHED_CONTEXT_DELETED = unchecked((int)(0x80090333));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_TGT_REPLY"]/*' />
    [NativeTypeName("#define SEC_E_NO_TGT_REPLY _HRESULT_TYPEDEF_(0x80090334L)")]
    public const int SEC_E_NO_TGT_REPLY = unchecked((int)(0x80090334));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_IP_ADDRESSES"]/*' />
    [NativeTypeName("#define SEC_E_NO_IP_ADDRESSES _HRESULT_TYPEDEF_(0x80090335L)")]
    public const int SEC_E_NO_IP_ADDRESSES = unchecked((int)(0x80090335));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_WRONG_CREDENTIAL_HANDLE"]/*' />
    [NativeTypeName("#define SEC_E_WRONG_CREDENTIAL_HANDLE _HRESULT_TYPEDEF_(0x80090336L)")]
    public const int SEC_E_WRONG_CREDENTIAL_HANDLE = unchecked((int)(0x80090336));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CRYPTO_SYSTEM_INVALID"]/*' />
    [NativeTypeName("#define SEC_E_CRYPTO_SYSTEM_INVALID _HRESULT_TYPEDEF_(0x80090337L)")]
    public const int SEC_E_CRYPTO_SYSTEM_INVALID = unchecked((int)(0x80090337));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_MAX_REFERRALS_EXCEEDED"]/*' />
    [NativeTypeName("#define SEC_E_MAX_REFERRALS_EXCEEDED _HRESULT_TYPEDEF_(0x80090338L)")]
    public const int SEC_E_MAX_REFERRALS_EXCEEDED = unchecked((int)(0x80090338));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_MUST_BE_KDC"]/*' />
    [NativeTypeName("#define SEC_E_MUST_BE_KDC _HRESULT_TYPEDEF_(0x80090339L)")]
    public const int SEC_E_MUST_BE_KDC = unchecked((int)(0x80090339));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_STRONG_CRYPTO_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define SEC_E_STRONG_CRYPTO_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009033AL)")]
    public const int SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)(0x8009033A));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_TOO_MANY_PRINCIPALS"]/*' />
    [NativeTypeName("#define SEC_E_TOO_MANY_PRINCIPALS _HRESULT_TYPEDEF_(0x8009033BL)")]
    public const int SEC_E_TOO_MANY_PRINCIPALS = unchecked((int)(0x8009033B));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_PA_DATA"]/*' />
    [NativeTypeName("#define SEC_E_NO_PA_DATA _HRESULT_TYPEDEF_(0x8009033CL)")]
    public const int SEC_E_NO_PA_DATA = unchecked((int)(0x8009033C));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_PKINIT_NAME_MISMATCH"]/*' />
    [NativeTypeName("#define SEC_E_PKINIT_NAME_MISMATCH _HRESULT_TYPEDEF_(0x8009033DL)")]
    public const int SEC_E_PKINIT_NAME_MISMATCH = unchecked((int)(0x8009033D));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SMARTCARD_LOGON_REQUIRED"]/*' />
    [NativeTypeName("#define SEC_E_SMARTCARD_LOGON_REQUIRED _HRESULT_TYPEDEF_(0x8009033EL)")]
    public const int SEC_E_SMARTCARD_LOGON_REQUIRED = unchecked((int)(0x8009033E));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define SEC_E_SHUTDOWN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8009033FL)")]
    public const int SEC_E_SHUTDOWN_IN_PROGRESS = unchecked((int)(0x8009033F));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_KDC_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define SEC_E_KDC_INVALID_REQUEST _HRESULT_TYPEDEF_(0x80090340L)")]
    public const int SEC_E_KDC_INVALID_REQUEST = unchecked((int)(0x80090340));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_KDC_UNABLE_TO_REFER"]/*' />
    [NativeTypeName("#define SEC_E_KDC_UNABLE_TO_REFER _HRESULT_TYPEDEF_(0x80090341L)")]
    public const int SEC_E_KDC_UNABLE_TO_REFER = unchecked((int)(0x80090341));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_KDC_UNKNOWN_ETYPE"]/*' />
    [NativeTypeName("#define SEC_E_KDC_UNKNOWN_ETYPE _HRESULT_TYPEDEF_(0x80090342L)")]
    public const int SEC_E_KDC_UNKNOWN_ETYPE = unchecked((int)(0x80090342));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_UNSUPPORTED_PREAUTH"]/*' />
    [NativeTypeName("#define SEC_E_UNSUPPORTED_PREAUTH _HRESULT_TYPEDEF_(0x80090343L)")]
    public const int SEC_E_UNSUPPORTED_PREAUTH = unchecked((int)(0x80090343));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_DELEGATION_REQUIRED"]/*' />
    [NativeTypeName("#define SEC_E_DELEGATION_REQUIRED _HRESULT_TYPEDEF_(0x80090345L)")]
    public const int SEC_E_DELEGATION_REQUIRED = unchecked((int)(0x80090345));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_BAD_BINDINGS"]/*' />
    [NativeTypeName("#define SEC_E_BAD_BINDINGS _HRESULT_TYPEDEF_(0x80090346L)")]
    public const int SEC_E_BAD_BINDINGS = unchecked((int)(0x80090346));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_MULTIPLE_ACCOUNTS"]/*' />
    [NativeTypeName("#define SEC_E_MULTIPLE_ACCOUNTS _HRESULT_TYPEDEF_(0x80090347L)")]
    public const int SEC_E_MULTIPLE_ACCOUNTS = unchecked((int)(0x80090347));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_KERB_KEY"]/*' />
    [NativeTypeName("#define SEC_E_NO_KERB_KEY _HRESULT_TYPEDEF_(0x80090348L)")]
    public const int SEC_E_NO_KERB_KEY = unchecked((int)(0x80090348));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CERT_WRONG_USAGE"]/*' />
    [NativeTypeName("#define SEC_E_CERT_WRONG_USAGE _HRESULT_TYPEDEF_(0x80090349L)")]
    public const int SEC_E_CERT_WRONG_USAGE = unchecked((int)(0x80090349));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_DOWNGRADE_DETECTED"]/*' />
    [NativeTypeName("#define SEC_E_DOWNGRADE_DETECTED _HRESULT_TYPEDEF_(0x80090350L)")]
    public const int SEC_E_DOWNGRADE_DETECTED = unchecked((int)(0x80090350));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SMARTCARD_CERT_REVOKED"]/*' />
    [NativeTypeName("#define SEC_E_SMARTCARD_CERT_REVOKED _HRESULT_TYPEDEF_(0x80090351L)")]
    public const int SEC_E_SMARTCARD_CERT_REVOKED = unchecked((int)(0x80090351));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ISSUING_CA_UNTRUSTED"]/*' />
    [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED _HRESULT_TYPEDEF_(0x80090352L)")]
    public const int SEC_E_ISSUING_CA_UNTRUSTED = unchecked((int)(0x80090352));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_REVOCATION_OFFLINE_C"]/*' />
    [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_C _HRESULT_TYPEDEF_(0x80090353L)")]
    public const int SEC_E_REVOCATION_OFFLINE_C = unchecked((int)(0x80090353));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_PKINIT_CLIENT_FAILURE"]/*' />
    [NativeTypeName("#define SEC_E_PKINIT_CLIENT_FAILURE _HRESULT_TYPEDEF_(0x80090354L)")]
    public const int SEC_E_PKINIT_CLIENT_FAILURE = unchecked((int)(0x80090354));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_SMARTCARD_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define SEC_E_SMARTCARD_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090355L)")]
    public const int SEC_E_SMARTCARD_CERT_EXPIRED = unchecked((int)(0x80090355));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_S4U_PROT_SUPPORT"]/*' />
    [NativeTypeName("#define SEC_E_NO_S4U_PROT_SUPPORT _HRESULT_TYPEDEF_(0x80090356L)")]
    public const int SEC_E_NO_S4U_PROT_SUPPORT = unchecked((int)(0x80090356));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_CROSSREALM_DELEGATION_FAILURE"]/*' />
    [NativeTypeName("#define SEC_E_CROSSREALM_DELEGATION_FAILURE _HRESULT_TYPEDEF_(0x80090357L)")]
    public const int SEC_E_CROSSREALM_DELEGATION_FAILURE = unchecked((int)(0x80090357));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_REVOCATION_OFFLINE_KDC"]/*' />
    [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_KDC _HRESULT_TYPEDEF_(0x80090358L)")]
    public const int SEC_E_REVOCATION_OFFLINE_KDC = unchecked((int)(0x80090358));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ISSUING_CA_UNTRUSTED_KDC"]/*' />
    [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED_KDC _HRESULT_TYPEDEF_(0x80090359L)")]
    public const int SEC_E_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)(0x80090359));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_KDC_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define SEC_E_KDC_CERT_EXPIRED _HRESULT_TYPEDEF_(0x8009035AL)")]
    public const int SEC_E_KDC_CERT_EXPIRED = unchecked((int)(0x8009035A));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_KDC_CERT_REVOKED"]/*' />
    [NativeTypeName("#define SEC_E_KDC_CERT_REVOKED _HRESULT_TYPEDEF_(0x8009035BL)")]
    public const int SEC_E_KDC_CERT_REVOKED = unchecked((int)(0x8009035B));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_SIGNATURE_NEEDED"]/*' />
    [NativeTypeName("#define SEC_I_SIGNATURE_NEEDED _HRESULT_TYPEDEF_(0x0009035CL)")]
    public const int SEC_I_SIGNATURE_NEEDED = ((int)(0x0009035C));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define SEC_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x8009035DL)")]
    public const int SEC_E_INVALID_PARAMETER = unchecked((int)(0x8009035D));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_DELEGATION_POLICY"]/*' />
    [NativeTypeName("#define SEC_E_DELEGATION_POLICY _HRESULT_TYPEDEF_(0x8009035EL)")]
    public const int SEC_E_DELEGATION_POLICY = unchecked((int)(0x8009035E));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_POLICY_NLTM_ONLY"]/*' />
    [NativeTypeName("#define SEC_E_POLICY_NLTM_ONLY _HRESULT_TYPEDEF_(0x8009035FL)")]
    public const int SEC_E_POLICY_NLTM_ONLY = unchecked((int)(0x8009035F));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_NO_RENEGOTIATION"]/*' />
    [NativeTypeName("#define SEC_I_NO_RENEGOTIATION _HRESULT_TYPEDEF_(0x00090360L)")]
    public const int SEC_I_NO_RENEGOTIATION = ((int)(0x00090360));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_CONTEXT"]/*' />
    [NativeTypeName("#define SEC_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x80090361L)")]
    public const int SEC_E_NO_CONTEXT = unchecked((int)(0x80090361));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_PKU2U_CERT_FAILURE"]/*' />
    [NativeTypeName("#define SEC_E_PKU2U_CERT_FAILURE _HRESULT_TYPEDEF_(0x80090362L)")]
    public const int SEC_E_PKU2U_CERT_FAILURE = unchecked((int)(0x80090362));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_MUTUAL_AUTH_FAILED"]/*' />
    [NativeTypeName("#define SEC_E_MUTUAL_AUTH_FAILED _HRESULT_TYPEDEF_(0x80090363L)")]
    public const int SEC_E_MUTUAL_AUTH_FAILED = unchecked((int)(0x80090363));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_MESSAGE_FRAGMENT"]/*' />
    [NativeTypeName("#define SEC_I_MESSAGE_FRAGMENT _HRESULT_TYPEDEF_(0x00090364L)")]
    public const int SEC_I_MESSAGE_FRAGMENT = ((int)(0x00090364));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_ONLY_HTTPS_ALLOWED"]/*' />
    [NativeTypeName("#define SEC_E_ONLY_HTTPS_ALLOWED _HRESULT_TYPEDEF_(0x80090365L)")]
    public const int SEC_E_ONLY_HTTPS_ALLOWED = unchecked((int)(0x80090365));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_CONTINUE_NEEDED_MESSAGE_OK"]/*' />
    [NativeTypeName("#define SEC_I_CONTINUE_NEEDED_MESSAGE_OK _HRESULT_TYPEDEF_(0x00090366L)")]
    public const int SEC_I_CONTINUE_NEEDED_MESSAGE_OK = ((int)(0x00090366));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_APPLICATION_PROTOCOL_MISMATCH"]/*' />
    [NativeTypeName("#define SEC_E_APPLICATION_PROTOCOL_MISMATCH _HRESULT_TYPEDEF_(0x80090367L)")]
    public const int SEC_E_APPLICATION_PROTOCOL_MISMATCH = unchecked((int)(0x80090367));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_ASYNC_CALL_PENDING"]/*' />
    [NativeTypeName("#define SEC_I_ASYNC_CALL_PENDING _HRESULT_TYPEDEF_(0x00090368L)")]
    public const int SEC_I_ASYNC_CALL_PENDING = ((int)(0x00090368));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INVALID_UPN_NAME"]/*' />
    [NativeTypeName("#define SEC_E_INVALID_UPN_NAME _HRESULT_TYPEDEF_(0x80090369L)")]
    public const int SEC_E_INVALID_UPN_NAME = unchecked((int)(0x80090369));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_EXT_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define SEC_E_EXT_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x8009036AL)")]
    public const int SEC_E_EXT_BUFFER_TOO_SMALL = unchecked((int)(0x8009036A));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_INSUFFICIENT_BUFFERS"]/*' />
    [NativeTypeName("#define SEC_E_INSUFFICIENT_BUFFERS _HRESULT_TYPEDEF_(0x8009036BL)")]
    public const int SEC_E_INSUFFICIENT_BUFFERS = unchecked((int)(0x8009036B));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_I_INVALID_SESSION_STATE"]/*' />
    [NativeTypeName("#define SEC_I_INVALID_SESSION_STATE _HRESULT_TYPEDEF_(0x8009036CL)")]
    public const int SEC_I_INVALID_SESSION_STATE = unchecked((int)(0x8009036C));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NO_SPM"]/*' />
    [NativeTypeName("#define SEC_E_NO_SPM SEC_E_INTERNAL_ERROR")]
    public const int SEC_E_NO_SPM = unchecked((int)(0x80090304));

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_E_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define SEC_E_NOT_SUPPORTED SEC_E_UNSUPPORTED_FUNCTION")]
    public const int SEC_E_NOT_SUPPORTED = unchecked((int)(0x80090302));
}
