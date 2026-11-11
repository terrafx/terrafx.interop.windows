// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CRYPT
{
    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_MSG_ERROR"]/*' />
    [NativeTypeName("#define CRYPT_E_MSG_ERROR _HRESULT_TYPEDEF_(0x80091001L)")]
    public const int CRYPT_E_MSG_ERROR = unchecked((int)(0x80091001));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_UNKNOWN_ALGO"]/*' />
    [NativeTypeName("#define CRYPT_E_UNKNOWN_ALGO _HRESULT_TYPEDEF_(0x80091002L)")]
    public const int CRYPT_E_UNKNOWN_ALGO = unchecked((int)(0x80091002));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_OID_FORMAT"]/*' />
    [NativeTypeName("#define CRYPT_E_OID_FORMAT _HRESULT_TYPEDEF_(0x80091003L)")]
    public const int CRYPT_E_OID_FORMAT = unchecked((int)(0x80091003));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_MSG_TYPE"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_MSG_TYPE _HRESULT_TYPEDEF_(0x80091004L)")]
    public const int CRYPT_E_INVALID_MSG_TYPE = unchecked((int)(0x80091004));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_UNEXPECTED_ENCODING"]/*' />
    [NativeTypeName("#define CRYPT_E_UNEXPECTED_ENCODING _HRESULT_TYPEDEF_(0x80091005L)")]
    public const int CRYPT_E_UNEXPECTED_ENCODING = unchecked((int)(0x80091005));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_AUTH_ATTR_MISSING"]/*' />
    [NativeTypeName("#define CRYPT_E_AUTH_ATTR_MISSING _HRESULT_TYPEDEF_(0x80091006L)")]
    public const int CRYPT_E_AUTH_ATTR_MISSING = unchecked((int)(0x80091006));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_HASH_VALUE"]/*' />
    [NativeTypeName("#define CRYPT_E_HASH_VALUE _HRESULT_TYPEDEF_(0x80091007L)")]
    public const int CRYPT_E_HASH_VALUE = unchecked((int)(0x80091007));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_INDEX"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_INDEX _HRESULT_TYPEDEF_(0x80091008L)")]
    public const int CRYPT_E_INVALID_INDEX = unchecked((int)(0x80091008));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ALREADY_DECRYPTED"]/*' />
    [NativeTypeName("#define CRYPT_E_ALREADY_DECRYPTED _HRESULT_TYPEDEF_(0x80091009L)")]
    public const int CRYPT_E_ALREADY_DECRYPTED = unchecked((int)(0x80091009));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NOT_DECRYPTED"]/*' />
    [NativeTypeName("#define CRYPT_E_NOT_DECRYPTED _HRESULT_TYPEDEF_(0x8009100AL)")]
    public const int CRYPT_E_NOT_DECRYPTED = unchecked((int)(0x8009100A));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_RECIPIENT_NOT_FOUND"]/*' />
    [NativeTypeName("#define CRYPT_E_RECIPIENT_NOT_FOUND _HRESULT_TYPEDEF_(0x8009100BL)")]
    public const int CRYPT_E_RECIPIENT_NOT_FOUND = unchecked((int)(0x8009100B));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_CONTROL_TYPE"]/*' />
    [NativeTypeName("#define CRYPT_E_CONTROL_TYPE _HRESULT_TYPEDEF_(0x8009100CL)")]
    public const int CRYPT_E_CONTROL_TYPE = unchecked((int)(0x8009100C));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ISSUER_SERIALNUMBER"]/*' />
    [NativeTypeName("#define CRYPT_E_ISSUER_SERIALNUMBER _HRESULT_TYPEDEF_(0x8009100DL)")]
    public const int CRYPT_E_ISSUER_SERIALNUMBER = unchecked((int)(0x8009100D));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_SIGNER_NOT_FOUND"]/*' />
    [NativeTypeName("#define CRYPT_E_SIGNER_NOT_FOUND _HRESULT_TYPEDEF_(0x8009100EL)")]
    public const int CRYPT_E_SIGNER_NOT_FOUND = unchecked((int)(0x8009100E));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ATTRIBUTES_MISSING"]/*' />
    [NativeTypeName("#define CRYPT_E_ATTRIBUTES_MISSING _HRESULT_TYPEDEF_(0x8009100FL)")]
    public const int CRYPT_E_ATTRIBUTES_MISSING = unchecked((int)(0x8009100F));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_STREAM_MSG_NOT_READY"]/*' />
    [NativeTypeName("#define CRYPT_E_STREAM_MSG_NOT_READY _HRESULT_TYPEDEF_(0x80091010L)")]
    public const int CRYPT_E_STREAM_MSG_NOT_READY = unchecked((int)(0x80091010));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_STREAM_INSUFFICIENT_DATA"]/*' />
    [NativeTypeName("#define CRYPT_E_STREAM_INSUFFICIENT_DATA _HRESULT_TYPEDEF_(0x80091011L)")]
    public const int CRYPT_E_STREAM_INSUFFICIENT_DATA = unchecked((int)(0x80091011));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_I_NEW_PROTECTION_REQUIRED"]/*' />
    [NativeTypeName("#define CRYPT_I_NEW_PROTECTION_REQUIRED _HRESULT_TYPEDEF_(0x00091012L)")]
    public const int CRYPT_I_NEW_PROTECTION_REQUIRED = ((int)(0x00091012));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_BAD_LEN"]/*' />
    [NativeTypeName("#define CRYPT_E_BAD_LEN _HRESULT_TYPEDEF_(0x80092001L)")]
    public const int CRYPT_E_BAD_LEN = unchecked((int)(0x80092001));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_BAD_ENCODE"]/*' />
    [NativeTypeName("#define CRYPT_E_BAD_ENCODE _HRESULT_TYPEDEF_(0x80092002L)")]
    public const int CRYPT_E_BAD_ENCODE = unchecked((int)(0x80092002));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_FILE_ERROR"]/*' />
    [NativeTypeName("#define CRYPT_E_FILE_ERROR _HRESULT_TYPEDEF_(0x80092003L)")]
    public const int CRYPT_E_FILE_ERROR = unchecked((int)(0x80092003));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NOT_FOUND"]/*' />
    [NativeTypeName("#define CRYPT_E_NOT_FOUND _HRESULT_TYPEDEF_(0x80092004L)")]
    public const int CRYPT_E_NOT_FOUND = unchecked((int)(0x80092004));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_EXISTS"]/*' />
    [NativeTypeName("#define CRYPT_E_EXISTS _HRESULT_TYPEDEF_(0x80092005L)")]
    public const int CRYPT_E_EXISTS = unchecked((int)(0x80092005));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_PROVIDER"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_PROVIDER _HRESULT_TYPEDEF_(0x80092006L)")]
    public const int CRYPT_E_NO_PROVIDER = unchecked((int)(0x80092006));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_SELF_SIGNED"]/*' />
    [NativeTypeName("#define CRYPT_E_SELF_SIGNED _HRESULT_TYPEDEF_(0x80092007L)")]
    public const int CRYPT_E_SELF_SIGNED = unchecked((int)(0x80092007));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_DELETED_PREV"]/*' />
    [NativeTypeName("#define CRYPT_E_DELETED_PREV _HRESULT_TYPEDEF_(0x80092008L)")]
    public const int CRYPT_E_DELETED_PREV = unchecked((int)(0x80092008));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_MATCH"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_MATCH _HRESULT_TYPEDEF_(0x80092009L)")]
    public const int CRYPT_E_NO_MATCH = unchecked((int)(0x80092009));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_UNEXPECTED_MSG_TYPE"]/*' />
    [NativeTypeName("#define CRYPT_E_UNEXPECTED_MSG_TYPE _HRESULT_TYPEDEF_(0x8009200AL)")]
    public const int CRYPT_E_UNEXPECTED_MSG_TYPE = unchecked((int)(0x8009200A));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_KEY_PROPERTY"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_KEY_PROPERTY _HRESULT_TYPEDEF_(0x8009200BL)")]
    public const int CRYPT_E_NO_KEY_PROPERTY = unchecked((int)(0x8009200B));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_DECRYPT_CERT"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_DECRYPT_CERT _HRESULT_TYPEDEF_(0x8009200CL)")]
    public const int CRYPT_E_NO_DECRYPT_CERT = unchecked((int)(0x8009200C));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_BAD_MSG"]/*' />
    [NativeTypeName("#define CRYPT_E_BAD_MSG _HRESULT_TYPEDEF_(0x8009200DL)")]
    public const int CRYPT_E_BAD_MSG = unchecked((int)(0x8009200D));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_SIGNER"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_SIGNER _HRESULT_TYPEDEF_(0x8009200EL)")]
    public const int CRYPT_E_NO_SIGNER = unchecked((int)(0x8009200E));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_PENDING_CLOSE"]/*' />
    [NativeTypeName("#define CRYPT_E_PENDING_CLOSE _HRESULT_TYPEDEF_(0x8009200FL)")]
    public const int CRYPT_E_PENDING_CLOSE = unchecked((int)(0x8009200F));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_REVOKED"]/*' />
    [NativeTypeName("#define CRYPT_E_REVOKED _HRESULT_TYPEDEF_(0x80092010L)")]
    public const int CRYPT_E_REVOKED = unchecked((int)(0x80092010));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_REVOCATION_DLL"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_REVOCATION_DLL _HRESULT_TYPEDEF_(0x80092011L)")]
    public const int CRYPT_E_NO_REVOCATION_DLL = unchecked((int)(0x80092011));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_REVOCATION_CHECK"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_REVOCATION_CHECK _HRESULT_TYPEDEF_(0x80092012L)")]
    public const int CRYPT_E_NO_REVOCATION_CHECK = unchecked((int)(0x80092012));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_REVOCATION_OFFLINE"]/*' />
    [NativeTypeName("#define CRYPT_E_REVOCATION_OFFLINE _HRESULT_TYPEDEF_(0x80092013L)")]
    public const int CRYPT_E_REVOCATION_OFFLINE = unchecked((int)(0x80092013));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NOT_IN_REVOCATION_DATABASE"]/*' />
    [NativeTypeName("#define CRYPT_E_NOT_IN_REVOCATION_DATABASE _HRESULT_TYPEDEF_(0x80092014L)")]
    public const int CRYPT_E_NOT_IN_REVOCATION_DATABASE = unchecked((int)(0x80092014));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_NUMERIC_STRING"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_NUMERIC_STRING _HRESULT_TYPEDEF_(0x80092020L)")]
    public const int CRYPT_E_INVALID_NUMERIC_STRING = unchecked((int)(0x80092020));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_PRINTABLE_STRING"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_PRINTABLE_STRING _HRESULT_TYPEDEF_(0x80092021L)")]
    public const int CRYPT_E_INVALID_PRINTABLE_STRING = unchecked((int)(0x80092021));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_IA5_STRING"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_IA5_STRING _HRESULT_TYPEDEF_(0x80092022L)")]
    public const int CRYPT_E_INVALID_IA5_STRING = unchecked((int)(0x80092022));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_INVALID_X500_STRING"]/*' />
    [NativeTypeName("#define CRYPT_E_INVALID_X500_STRING _HRESULT_TYPEDEF_(0x80092023L)")]
    public const int CRYPT_E_INVALID_X500_STRING = unchecked((int)(0x80092023));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NOT_CHAR_STRING"]/*' />
    [NativeTypeName("#define CRYPT_E_NOT_CHAR_STRING _HRESULT_TYPEDEF_(0x80092024L)")]
    public const int CRYPT_E_NOT_CHAR_STRING = unchecked((int)(0x80092024));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_FILERESIZED"]/*' />
    [NativeTypeName("#define CRYPT_E_FILERESIZED _HRESULT_TYPEDEF_(0x80092025L)")]
    public const int CRYPT_E_FILERESIZED = unchecked((int)(0x80092025));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_SECURITY_SETTINGS"]/*' />
    [NativeTypeName("#define CRYPT_E_SECURITY_SETTINGS _HRESULT_TYPEDEF_(0x80092026L)")]
    public const int CRYPT_E_SECURITY_SETTINGS = unchecked((int)(0x80092026));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_VERIFY_USAGE_DLL"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_VERIFY_USAGE_DLL _HRESULT_TYPEDEF_(0x80092027L)")]
    public const int CRYPT_E_NO_VERIFY_USAGE_DLL = unchecked((int)(0x80092027));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_VERIFY_USAGE_CHECK"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_VERIFY_USAGE_CHECK _HRESULT_TYPEDEF_(0x80092028L)")]
    public const int CRYPT_E_NO_VERIFY_USAGE_CHECK = unchecked((int)(0x80092028));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_VERIFY_USAGE_OFFLINE"]/*' />
    [NativeTypeName("#define CRYPT_E_VERIFY_USAGE_OFFLINE _HRESULT_TYPEDEF_(0x80092029L)")]
    public const int CRYPT_E_VERIFY_USAGE_OFFLINE = unchecked((int)(0x80092029));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NOT_IN_CTL"]/*' />
    [NativeTypeName("#define CRYPT_E_NOT_IN_CTL _HRESULT_TYPEDEF_(0x8009202AL)")]
    public const int CRYPT_E_NOT_IN_CTL = unchecked((int)(0x8009202A));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_NO_TRUSTED_SIGNER"]/*' />
    [NativeTypeName("#define CRYPT_E_NO_TRUSTED_SIGNER _HRESULT_TYPEDEF_(0x8009202BL)")]
    public const int CRYPT_E_NO_TRUSTED_SIGNER = unchecked((int)(0x8009202B));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_MISSING_PUBKEY_PARA"]/*' />
    [NativeTypeName("#define CRYPT_E_MISSING_PUBKEY_PARA _HRESULT_TYPEDEF_(0x8009202CL)")]
    public const int CRYPT_E_MISSING_PUBKEY_PARA = unchecked((int)(0x8009202C));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_OBJECT_LOCATOR_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define CRYPT_E_OBJECT_LOCATOR_OBJECT_NOT_FOUND _HRESULT_TYPEDEF_(0x8009202DL)")]
    public const int CRYPT_E_OBJECT_LOCATOR_OBJECT_NOT_FOUND = unchecked((int)(0x8009202D));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_OSS_ERROR"]/*' />
    [NativeTypeName("#define CRYPT_E_OSS_ERROR _HRESULT_TYPEDEF_(0x80093000L)")]
    public const int CRYPT_E_OSS_ERROR = unchecked((int)(0x80093000));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_ERROR"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_ERROR _HRESULT_TYPEDEF_(0x80093100L)")]
    public const int CRYPT_E_ASN1_ERROR = unchecked((int)(0x80093100));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_INTERNAL"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_INTERNAL _HRESULT_TYPEDEF_(0x80093101L)")]
    public const int CRYPT_E_ASN1_INTERNAL = unchecked((int)(0x80093101));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_EOD"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_EOD _HRESULT_TYPEDEF_(0x80093102L)")]
    public const int CRYPT_E_ASN1_EOD = unchecked((int)(0x80093102));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_CORRUPT"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_CORRUPT _HRESULT_TYPEDEF_(0x80093103L)")]
    public const int CRYPT_E_ASN1_CORRUPT = unchecked((int)(0x80093103));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_LARGE"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_LARGE _HRESULT_TYPEDEF_(0x80093104L)")]
    public const int CRYPT_E_ASN1_LARGE = unchecked((int)(0x80093104));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_CONSTRAINT"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_CONSTRAINT _HRESULT_TYPEDEF_(0x80093105L)")]
    public const int CRYPT_E_ASN1_CONSTRAINT = unchecked((int)(0x80093105));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_MEMORY"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_MEMORY _HRESULT_TYPEDEF_(0x80093106L)")]
    public const int CRYPT_E_ASN1_MEMORY = unchecked((int)(0x80093106));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_OVERFLOW"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_OVERFLOW _HRESULT_TYPEDEF_(0x80093107L)")]
    public const int CRYPT_E_ASN1_OVERFLOW = unchecked((int)(0x80093107));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_BADPDU"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_BADPDU _HRESULT_TYPEDEF_(0x80093108L)")]
    public const int CRYPT_E_ASN1_BADPDU = unchecked((int)(0x80093108));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_BADARGS"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_BADARGS _HRESULT_TYPEDEF_(0x80093109L)")]
    public const int CRYPT_E_ASN1_BADARGS = unchecked((int)(0x80093109));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_BADREAL"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_BADREAL _HRESULT_TYPEDEF_(0x8009310AL)")]
    public const int CRYPT_E_ASN1_BADREAL = unchecked((int)(0x8009310A));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_BADTAG"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_BADTAG _HRESULT_TYPEDEF_(0x8009310BL)")]
    public const int CRYPT_E_ASN1_BADTAG = unchecked((int)(0x8009310B));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_CHOICE"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_CHOICE _HRESULT_TYPEDEF_(0x8009310CL)")]
    public const int CRYPT_E_ASN1_CHOICE = unchecked((int)(0x8009310C));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_RULE"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_RULE _HRESULT_TYPEDEF_(0x8009310DL)")]
    public const int CRYPT_E_ASN1_RULE = unchecked((int)(0x8009310D));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_UTF8"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_UTF8 _HRESULT_TYPEDEF_(0x8009310EL)")]
    public const int CRYPT_E_ASN1_UTF8 = unchecked((int)(0x8009310E));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_PDU_TYPE"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_PDU_TYPE _HRESULT_TYPEDEF_(0x80093133L)")]
    public const int CRYPT_E_ASN1_PDU_TYPE = unchecked((int)(0x80093133));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_NYI"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_NYI _HRESULT_TYPEDEF_(0x80093134L)")]
    public const int CRYPT_E_ASN1_NYI = unchecked((int)(0x80093134));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_EXTENDED"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_EXTENDED _HRESULT_TYPEDEF_(0x80093201L)")]
    public const int CRYPT_E_ASN1_EXTENDED = unchecked((int)(0x80093201));

    /// <include file='CRYPT.xml' path='doc/member[@name="CRYPT.CRYPT_E_ASN1_NOEOD"]/*' />
    [NativeTypeName("#define CRYPT_E_ASN1_NOEOD _HRESULT_TYPEDEF_(0x80093202L)")]
    public const int CRYPT_E_ASN1_NOEOD = unchecked((int)(0x80093202));
}
