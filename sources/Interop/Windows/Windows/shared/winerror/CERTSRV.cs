// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CERTSRV
{
    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_REQUESTSUBJECT"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_REQUESTSUBJECT _HRESULT_TYPEDEF_(0x80094001L)")]
    public const int CERTSRV_E_BAD_REQUESTSUBJECT = unchecked((int)(0x80094001));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_REQUEST"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_REQUEST _HRESULT_TYPEDEF_(0x80094002L)")]
    public const int CERTSRV_E_NO_REQUEST = unchecked((int)(0x80094002));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_REQUESTSTATUS"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_REQUESTSTATUS _HRESULT_TYPEDEF_(0x80094003L)")]
    public const int CERTSRV_E_BAD_REQUESTSTATUS = unchecked((int)(0x80094003));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_PROPERTY_EMPTY"]/*' />
    [NativeTypeName("#define CERTSRV_E_PROPERTY_EMPTY _HRESULT_TYPEDEF_(0x80094004L)")]
    public const int CERTSRV_E_PROPERTY_EMPTY = unchecked((int)(0x80094004));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_CA_CERTIFICATE"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_CA_CERTIFICATE _HRESULT_TYPEDEF_(0x80094005L)")]
    public const int CERTSRV_E_INVALID_CA_CERTIFICATE = unchecked((int)(0x80094005));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SERVER_SUSPENDED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SERVER_SUSPENDED _HRESULT_TYPEDEF_(0x80094006L)")]
    public const int CERTSRV_E_SERVER_SUSPENDED = unchecked((int)(0x80094006));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ENCODING_LENGTH"]/*' />
    [NativeTypeName("#define CERTSRV_E_ENCODING_LENGTH _HRESULT_TYPEDEF_(0x80094007L)")]
    public const int CERTSRV_E_ENCODING_LENGTH = unchecked((int)(0x80094007));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ROLECONFLICT"]/*' />
    [NativeTypeName("#define CERTSRV_E_ROLECONFLICT _HRESULT_TYPEDEF_(0x80094008L)")]
    public const int CERTSRV_E_ROLECONFLICT = unchecked((int)(0x80094008));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_RESTRICTEDOFFICER"]/*' />
    [NativeTypeName("#define CERTSRV_E_RESTRICTEDOFFICER _HRESULT_TYPEDEF_(0x80094009L)")]
    public const int CERTSRV_E_RESTRICTEDOFFICER = unchecked((int)(0x80094009));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED"]/*' />
    [NativeTypeName("#define CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x8009400AL)")]
    public const int CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = unchecked((int)(0x8009400A));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_VALID_KRA"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_VALID_KRA _HRESULT_TYPEDEF_(0x8009400BL)")]
    public const int CERTSRV_E_NO_VALID_KRA = unchecked((int)(0x8009400B));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL _HRESULT_TYPEDEF_(0x8009400CL)")]
    public const int CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = unchecked((int)(0x8009400C));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_CAADMIN_DEFINED"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_CAADMIN_DEFINED _HRESULT_TYPEDEF_(0x8009400DL)")]
    public const int CERTSRV_E_NO_CAADMIN_DEFINED = unchecked((int)(0x8009400D));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE _HRESULT_TYPEDEF_(0x8009400EL)")]
    public const int CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = unchecked((int)(0x8009400E));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_DB_SESSIONS"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_DB_SESSIONS _HRESULT_TYPEDEF_(0x8009400FL)")]
    public const int CERTSRV_E_NO_DB_SESSIONS = unchecked((int)(0x8009400F));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ALIGNMENT_FAULT"]/*' />
    [NativeTypeName("#define CERTSRV_E_ALIGNMENT_FAULT _HRESULT_TYPEDEF_(0x80094010L)")]
    public const int CERTSRV_E_ALIGNMENT_FAULT = unchecked((int)(0x80094010));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ENROLL_DENIED"]/*' />
    [NativeTypeName("#define CERTSRV_E_ENROLL_DENIED _HRESULT_TYPEDEF_(0x80094011L)")]
    public const int CERTSRV_E_ENROLL_DENIED = unchecked((int)(0x80094011));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_TEMPLATE_DENIED"]/*' />
    [NativeTypeName("#define CERTSRV_E_TEMPLATE_DENIED _HRESULT_TYPEDEF_(0x80094012L)")]
    public const int CERTSRV_E_TEMPLATE_DENIED = unchecked((int)(0x80094012));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE"]/*' />
    [NativeTypeName("#define CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE _HRESULT_TYPEDEF_(0x80094013L)")]
    public const int CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = unchecked((int)(0x80094013));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ADMIN_DENIED_REQUEST"]/*' />
    [NativeTypeName("#define CERTSRV_E_ADMIN_DENIED_REQUEST _HRESULT_TYPEDEF_(0x80094014L)")]
    public const int CERTSRV_E_ADMIN_DENIED_REQUEST = unchecked((int)(0x80094014));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_POLICY_SERVER"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_POLICY_SERVER _HRESULT_TYPEDEF_(0x80094015L)")]
    public const int CERTSRV_E_NO_POLICY_SERVER = unchecked((int)(0x80094015));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_WEAK_SIGNATURE_OR_KEY"]/*' />
    [NativeTypeName("#define CERTSRV_E_WEAK_SIGNATURE_OR_KEY _HRESULT_TYPEDEF_(0x80094016L)")]
    public const int CERTSRV_E_WEAK_SIGNATURE_OR_KEY = unchecked((int)(0x80094016));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80094017L)")]
    public const int CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED = unchecked((int)(0x80094017));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ENCRYPTION_CERT_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_ENCRYPTION_CERT_REQUIRED _HRESULT_TYPEDEF_(0x80094018L)")]
    public const int CERTSRV_E_ENCRYPTION_CERT_REQUIRED = unchecked((int)(0x80094018));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_UNSUPPORTED_CERT_TYPE"]/*' />
    [NativeTypeName("#define CERTSRV_E_UNSUPPORTED_CERT_TYPE _HRESULT_TYPEDEF_(0x80094800L)")]
    public const int CERTSRV_E_UNSUPPORTED_CERT_TYPE = unchecked((int)(0x80094800));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_NO_CERT_TYPE"]/*' />
    [NativeTypeName("#define CERTSRV_E_NO_CERT_TYPE _HRESULT_TYPEDEF_(0x80094801L)")]
    public const int CERTSRV_E_NO_CERT_TYPE = unchecked((int)(0x80094801));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_TEMPLATE_CONFLICT"]/*' />
    [NativeTypeName("#define CERTSRV_E_TEMPLATE_CONFLICT _HRESULT_TYPEDEF_(0x80094802L)")]
    public const int CERTSRV_E_TEMPLATE_CONFLICT = unchecked((int)(0x80094802));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED _HRESULT_TYPEDEF_(0x80094803L)")]
    public const int CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = unchecked((int)(0x80094803));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ARCHIVED_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_ARCHIVED_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80094804L)")]
    public const int CERTSRV_E_ARCHIVED_KEY_REQUIRED = unchecked((int)(0x80094804));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SMIME_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SMIME_REQUIRED _HRESULT_TYPEDEF_(0x80094805L)")]
    public const int CERTSRV_E_SMIME_REQUIRED = unchecked((int)(0x80094805));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_RENEWAL_SUBJECT"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_RENEWAL_SUBJECT _HRESULT_TYPEDEF_(0x80094806L)")]
    public const int CERTSRV_E_BAD_RENEWAL_SUBJECT = unchecked((int)(0x80094806));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_BAD_TEMPLATE_VERSION"]/*' />
    [NativeTypeName("#define CERTSRV_E_BAD_TEMPLATE_VERSION _HRESULT_TYPEDEF_(0x80094807L)")]
    public const int CERTSRV_E_BAD_TEMPLATE_VERSION = unchecked((int)(0x80094807));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_TEMPLATE_POLICY_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_TEMPLATE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x80094808L)")]
    public const int CERTSRV_E_TEMPLATE_POLICY_REQUIRED = unchecked((int)(0x80094808));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SIGNATURE_POLICY_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SIGNATURE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x80094809L)")]
    public const int CERTSRV_E_SIGNATURE_POLICY_REQUIRED = unchecked((int)(0x80094809));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SIGNATURE_COUNT"]/*' />
    [NativeTypeName("#define CERTSRV_E_SIGNATURE_COUNT _HRESULT_TYPEDEF_(0x8009480AL)")]
    public const int CERTSRV_E_SIGNATURE_COUNT = unchecked((int)(0x8009480A));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SIGNATURE_REJECTED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SIGNATURE_REJECTED _HRESULT_TYPEDEF_(0x8009480BL)")]
    public const int CERTSRV_E_SIGNATURE_REJECTED = unchecked((int)(0x8009480B));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ISSUANCE_POLICY_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_ISSUANCE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x8009480CL)")]
    public const int CERTSRV_E_ISSUANCE_POLICY_REQUIRED = unchecked((int)(0x8009480C));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SUBJECT_UPN_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SUBJECT_UPN_REQUIRED _HRESULT_TYPEDEF_(0x8009480DL)")]
    public const int CERTSRV_E_SUBJECT_UPN_REQUIRED = unchecked((int)(0x8009480D));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED _HRESULT_TYPEDEF_(0x8009480EL)")]
    public const int CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = unchecked((int)(0x8009480E));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SUBJECT_DNS_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SUBJECT_DNS_REQUIRED _HRESULT_TYPEDEF_(0x8009480FL)")]
    public const int CERTSRV_E_SUBJECT_DNS_REQUIRED = unchecked((int)(0x8009480F));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_ARCHIVED_KEY_UNEXPECTED"]/*' />
    [NativeTypeName("#define CERTSRV_E_ARCHIVED_KEY_UNEXPECTED _HRESULT_TYPEDEF_(0x80094810L)")]
    public const int CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = unchecked((int)(0x80094810));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_KEY_LENGTH"]/*' />
    [NativeTypeName("#define CERTSRV_E_KEY_LENGTH _HRESULT_TYPEDEF_(0x80094811L)")]
    public const int CERTSRV_E_KEY_LENGTH = unchecked((int)(0x80094811));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SUBJECT_EMAIL_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SUBJECT_EMAIL_REQUIRED _HRESULT_TYPEDEF_(0x80094812L)")]
    public const int CERTSRV_E_SUBJECT_EMAIL_REQUIRED = unchecked((int)(0x80094812));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_UNKNOWN_CERT_TYPE"]/*' />
    [NativeTypeName("#define CERTSRV_E_UNKNOWN_CERT_TYPE _HRESULT_TYPEDEF_(0x80094813L)")]
    public const int CERTSRV_E_UNKNOWN_CERT_TYPE = unchecked((int)(0x80094813));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_CERT_TYPE_OVERLAP"]/*' />
    [NativeTypeName("#define CERTSRV_E_CERT_TYPE_OVERLAP _HRESULT_TYPEDEF_(0x80094814L)")]
    public const int CERTSRV_E_CERT_TYPE_OVERLAP = unchecked((int)(0x80094814));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_TOO_MANY_SIGNATURES"]/*' />
    [NativeTypeName("#define CERTSRV_E_TOO_MANY_SIGNATURES _HRESULT_TYPEDEF_(0x80094815L)")]
    public const int CERTSRV_E_TOO_MANY_SIGNATURES = unchecked((int)(0x80094815));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY _HRESULT_TYPEDEF_(0x80094816L)")]
    public const int CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY = unchecked((int)(0x80094816));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_EK"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_EK _HRESULT_TYPEDEF_(0x80094817L)")]
    public const int CERTSRV_E_INVALID_EK = unchecked((int)(0x80094817));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_IDBINDING"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_IDBINDING _HRESULT_TYPEDEF_(0x80094818L)")]
    public const int CERTSRV_E_INVALID_IDBINDING = unchecked((int)(0x80094818));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_ATTESTATION"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_ATTESTATION _HRESULT_TYPEDEF_(0x80094819L)")]
    public const int CERTSRV_E_INVALID_ATTESTATION = unchecked((int)(0x80094819));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_KEY_ATTESTATION"]/*' />
    [NativeTypeName("#define CERTSRV_E_KEY_ATTESTATION _HRESULT_TYPEDEF_(0x8009481AL)")]
    public const int CERTSRV_E_KEY_ATTESTATION = unchecked((int)(0x8009481A));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_CORRUPT_KEY_ATTESTATION"]/*' />
    [NativeTypeName("#define CERTSRV_E_CORRUPT_KEY_ATTESTATION _HRESULT_TYPEDEF_(0x8009481BL)")]
    public const int CERTSRV_E_CORRUPT_KEY_ATTESTATION = unchecked((int)(0x8009481B));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_EXPIRED_CHALLENGE"]/*' />
    [NativeTypeName("#define CERTSRV_E_EXPIRED_CHALLENGE _HRESULT_TYPEDEF_(0x8009481CL)")]
    public const int CERTSRV_E_EXPIRED_CHALLENGE = unchecked((int)(0x8009481C));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_RESPONSE"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_RESPONSE _HRESULT_TYPEDEF_(0x8009481DL)")]
    public const int CERTSRV_E_INVALID_RESPONSE = unchecked((int)(0x8009481D));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_INVALID_REQUESTID"]/*' />
    [NativeTypeName("#define CERTSRV_E_INVALID_REQUESTID _HRESULT_TYPEDEF_(0x8009481EL)")]
    public const int CERTSRV_E_INVALID_REQUESTID = unchecked((int)(0x8009481E));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH"]/*' />
    [NativeTypeName("#define CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH _HRESULT_TYPEDEF_(0x8009481FL)")]
    public const int CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH = unchecked((int)(0x8009481F));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_PENDING_CLIENT_RESPONSE"]/*' />
    [NativeTypeName("#define CERTSRV_E_PENDING_CLIENT_RESPONSE _HRESULT_TYPEDEF_(0x80094820L)")]
    public const int CERTSRV_E_PENDING_CLIENT_RESPONSE = unchecked((int)(0x80094820));

    /// <include file='CERTSRV.xml' path='doc/member[@name="CERTSRV.CERTSRV_E_SEC_EXT_DIRECTORY_SID_REQUIRED"]/*' />
    [NativeTypeName("#define CERTSRV_E_SEC_EXT_DIRECTORY_SID_REQUIRED _HRESULT_TYPEDEF_(0x80094821L)")]
    public const int CERTSRV_E_SEC_EXT_DIRECTORY_SID_REQUIRED = unchecked((int)(0x80094821));
}
