// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TPMAPI
{
    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_STATE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_STATE _HRESULT_TYPEDEF_(0x80290100L)")]
    public const int TPMAPI_E_INVALID_STATE = unchecked((int)(0x80290100));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_NOT_ENOUGH_DATA"]/*' />
    [NativeTypeName("#define TPMAPI_E_NOT_ENOUGH_DATA _HRESULT_TYPEDEF_(0x80290101L)")]
    public const int TPMAPI_E_NOT_ENOUGH_DATA = unchecked((int)(0x80290101));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_TOO_MUCH_DATA"]/*' />
    [NativeTypeName("#define TPMAPI_E_TOO_MUCH_DATA _HRESULT_TYPEDEF_(0x80290102L)")]
    public const int TPMAPI_E_TOO_MUCH_DATA = unchecked((int)(0x80290102));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_OUTPUT_POINTER"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80290103L)")]
    public const int TPMAPI_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80290103));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290104L)")]
    public const int TPMAPI_E_INVALID_PARAMETER = unchecked((int)(0x80290104));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_OUT_OF_MEMORY"]/*' />
    [NativeTypeName("#define TPMAPI_E_OUT_OF_MEMORY _HRESULT_TYPEDEF_(0x80290105L)")]
    public const int TPMAPI_E_OUT_OF_MEMORY = unchecked((int)(0x80290105));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define TPMAPI_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290106L)")]
    public const int TPMAPI_E_BUFFER_TOO_SMALL = unchecked((int)(0x80290106));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define TPMAPI_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80290107L)")]
    public const int TPMAPI_E_INTERNAL_ERROR = unchecked((int)(0x80290107));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define TPMAPI_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80290108L)")]
    public const int TPMAPI_E_ACCESS_DENIED = unchecked((int)(0x80290108));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_AUTHORIZATION_FAILED"]/*' />
    [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_FAILED _HRESULT_TYPEDEF_(0x80290109L)")]
    public const int TPMAPI_E_AUTHORIZATION_FAILED = unchecked((int)(0x80290109));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_CONTEXT_HANDLE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_HANDLE _HRESULT_TYPEDEF_(0x8029010AL)")]
    public const int TPMAPI_E_INVALID_CONTEXT_HANDLE = unchecked((int)(0x8029010A));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_TBS_COMMUNICATION_ERROR"]/*' />
    [NativeTypeName("#define TPMAPI_E_TBS_COMMUNICATION_ERROR _HRESULT_TYPEDEF_(0x8029010BL)")]
    public const int TPMAPI_E_TBS_COMMUNICATION_ERROR = unchecked((int)(0x8029010B));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_TPM_COMMAND_ERROR"]/*' />
    [NativeTypeName("#define TPMAPI_E_TPM_COMMAND_ERROR _HRESULT_TYPEDEF_(0x8029010CL)")]
    public const int TPMAPI_E_TPM_COMMAND_ERROR = unchecked((int)(0x8029010C));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_MESSAGE_TOO_LARGE"]/*' />
    [NativeTypeName("#define TPMAPI_E_MESSAGE_TOO_LARGE _HRESULT_TYPEDEF_(0x8029010DL)")]
    public const int TPMAPI_E_MESSAGE_TOO_LARGE = unchecked((int)(0x8029010D));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_ENCODING"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_ENCODING _HRESULT_TYPEDEF_(0x8029010EL)")]
    public const int TPMAPI_E_INVALID_ENCODING = unchecked((int)(0x8029010E));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_KEY_SIZE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_SIZE _HRESULT_TYPEDEF_(0x8029010FL)")]
    public const int TPMAPI_E_INVALID_KEY_SIZE = unchecked((int)(0x8029010F));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_ENCRYPTION_FAILED"]/*' />
    [NativeTypeName("#define TPMAPI_E_ENCRYPTION_FAILED _HRESULT_TYPEDEF_(0x80290110L)")]
    public const int TPMAPI_E_ENCRYPTION_FAILED = unchecked((int)(0x80290110));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_KEY_PARAMS"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_PARAMS _HRESULT_TYPEDEF_(0x80290111L)")]
    public const int TPMAPI_E_INVALID_KEY_PARAMS = unchecked((int)(0x80290111));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB _HRESULT_TYPEDEF_(0x80290112L)")]
    public const int TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB = unchecked((int)(0x80290112));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_PCR_INDEX"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_PCR_INDEX _HRESULT_TYPEDEF_(0x80290113L)")]
    public const int TPMAPI_E_INVALID_PCR_INDEX = unchecked((int)(0x80290113));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_DELEGATE_BLOB"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_DELEGATE_BLOB _HRESULT_TYPEDEF_(0x80290114L)")]
    public const int TPMAPI_E_INVALID_DELEGATE_BLOB = unchecked((int)(0x80290114));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_CONTEXT_PARAMS"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_PARAMS _HRESULT_TYPEDEF_(0x80290115L)")]
    public const int TPMAPI_E_INVALID_CONTEXT_PARAMS = unchecked((int)(0x80290115));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_KEY_BLOB"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_BLOB _HRESULT_TYPEDEF_(0x80290116L)")]
    public const int TPMAPI_E_INVALID_KEY_BLOB = unchecked((int)(0x80290116));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_PCR_DATA"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_PCR_DATA _HRESULT_TYPEDEF_(0x80290117L)")]
    public const int TPMAPI_E_INVALID_PCR_DATA = unchecked((int)(0x80290117));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_OWNER_AUTH"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_OWNER_AUTH _HRESULT_TYPEDEF_(0x80290118L)")]
    public const int TPMAPI_E_INVALID_OWNER_AUTH = unchecked((int)(0x80290118));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_FIPS_RNG_CHECK_FAILED"]/*' />
    [NativeTypeName("#define TPMAPI_E_FIPS_RNG_CHECK_FAILED _HRESULT_TYPEDEF_(0x80290119L)")]
    public const int TPMAPI_E_FIPS_RNG_CHECK_FAILED = unchecked((int)(0x80290119));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_EMPTY_TCG_LOG"]/*' />
    [NativeTypeName("#define TPMAPI_E_EMPTY_TCG_LOG _HRESULT_TYPEDEF_(0x8029011AL)")]
    public const int TPMAPI_E_EMPTY_TCG_LOG = unchecked((int)(0x8029011A));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_TCG_LOG_ENTRY"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_TCG_LOG_ENTRY _HRESULT_TYPEDEF_(0x8029011BL)")]
    public const int TPMAPI_E_INVALID_TCG_LOG_ENTRY = unchecked((int)(0x8029011B));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_TCG_SEPARATOR_ABSENT"]/*' />
    [NativeTypeName("#define TPMAPI_E_TCG_SEPARATOR_ABSENT _HRESULT_TYPEDEF_(0x8029011CL)")]
    public const int TPMAPI_E_TCG_SEPARATOR_ABSENT = unchecked((int)(0x8029011C));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_TCG_INVALID_DIGEST_ENTRY"]/*' />
    [NativeTypeName("#define TPMAPI_E_TCG_INVALID_DIGEST_ENTRY _HRESULT_TYPEDEF_(0x8029011DL)")]
    public const int TPMAPI_E_TCG_INVALID_DIGEST_ENTRY = unchecked((int)(0x8029011D));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_POLICY_DENIES_OPERATION"]/*' />
    [NativeTypeName("#define TPMAPI_E_POLICY_DENIES_OPERATION _HRESULT_TYPEDEF_(0x8029011EL)")]
    public const int TPMAPI_E_POLICY_DENIES_OPERATION = unchecked((int)(0x8029011E));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_NV_BITS_NOT_DEFINED"]/*' />
    [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_DEFINED _HRESULT_TYPEDEF_(0x8029011FL)")]
    public const int TPMAPI_E_NV_BITS_NOT_DEFINED = unchecked((int)(0x8029011F));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_NV_BITS_NOT_READY"]/*' />
    [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_READY _HRESULT_TYPEDEF_(0x80290120L)")]
    public const int TPMAPI_E_NV_BITS_NOT_READY = unchecked((int)(0x80290120));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_SEALING_KEY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define TPMAPI_E_SEALING_KEY_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290121L)")]
    public const int TPMAPI_E_SEALING_KEY_NOT_AVAILABLE = unchecked((int)(0x80290121));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND"]/*' />
    [NativeTypeName("#define TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND _HRESULT_TYPEDEF_(0x80290122L)")]
    public const int TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND = unchecked((int)(0x80290122));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290123L)")]
    public const int TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE = unchecked((int)(0x80290123));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_OWNER_AUTH_NOT_NULL"]/*' />
    [NativeTypeName("#define TPMAPI_E_OWNER_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290124L)")]
    public const int TPMAPI_E_OWNER_AUTH_NOT_NULL = unchecked((int)(0x80290124));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL"]/*' />
    [NativeTypeName("#define TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290125L)")]
    public const int TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL = unchecked((int)(0x80290125));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_AUTHORIZATION_REVOKED"]/*' />
    [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_REVOKED _HRESULT_TYPEDEF_(0x80290126L)")]
    public const int TPMAPI_E_AUTHORIZATION_REVOKED = unchecked((int)(0x80290126));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_MALFORMED_AUTHORIZATION_KEY"]/*' />
    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_KEY _HRESULT_TYPEDEF_(0x80290127L)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_KEY = unchecked((int)(0x80290127));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290128L)")]
    public const int TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED = unchecked((int)(0x80290128));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE _HRESULT_TYPEDEF_(0x80290129L)")]
    public const int TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE = unchecked((int)(0x80290129));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY"]/*' />
    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY _HRESULT_TYPEDEF_(0x8029012AL)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY = unchecked((int)(0x8029012A));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER"]/*' />
    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER _HRESULT_TYPEDEF_(0x8029012BL)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER = unchecked((int)(0x8029012B));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_SEALING_KEY_CHANGED"]/*' />
    [NativeTypeName("#define TPMAPI_E_SEALING_KEY_CHANGED _HRESULT_TYPEDEF_(0x8029012CL)")]
    public const int TPMAPI_E_SEALING_KEY_CHANGED = unchecked((int)(0x8029012C));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_TPM_VERSION"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_TPM_VERSION _HRESULT_TYPEDEF_(0x8029012DL)")]
    public const int TPMAPI_E_INVALID_TPM_VERSION = unchecked((int)(0x8029012D));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE _HRESULT_TYPEDEF_(0x8029012EL)")]
    public const int TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE = unchecked((int)(0x8029012E));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_TAG"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_TAG _HRESULT_TYPEDEF_(0x80290130L)")]
    public const int TPMAPI_E_INVALID_TAG = unchecked((int)(0x80290130));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_STRUCT_SIZE"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_STRUCT_SIZE _HRESULT_TYPEDEF_(0x80290131L)")]
    public const int TPMAPI_E_INVALID_STRUCT_SIZE = unchecked((int)(0x80290131));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_AUTH_CHAIN_ERROR"]/*' />
    [NativeTypeName("#define TPMAPI_E_AUTH_CHAIN_ERROR _HRESULT_TYPEDEF_(0x80290132L)")]
    public const int TPMAPI_E_AUTH_CHAIN_ERROR = unchecked((int)(0x80290132));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_COUNTER_CORRUPTED"]/*' />
    [NativeTypeName("#define TPMAPI_E_COUNTER_CORRUPTED _HRESULT_TYPEDEF_(0x80290133L)")]
    public const int TPMAPI_E_COUNTER_CORRUPTED = unchecked((int)(0x80290133));

    /// <include file='TPMAPI.xml' path='doc/member[@name="TPMAPI.TPMAPI_E_INVALID_ALGORITHM"]/*' />
    [NativeTypeName("#define TPMAPI_E_INVALID_ALGORITHM _HRESULT_TYPEDEF_(0x80290134L)")]
    public const int TPMAPI_E_INVALID_ALGORITHM = unchecked((int)(0x80290134));
}
