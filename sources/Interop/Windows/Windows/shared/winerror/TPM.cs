// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TPM
{
    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_ERROR_MASK"]/*' />
    [NativeTypeName("#define TPM_E_ERROR_MASK _HRESULT_TYPEDEF_(0x80280000L)")]
    public const int TPM_E_ERROR_MASK = unchecked((int)(0x80280000));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUTHFAIL"]/*' />
    [NativeTypeName("#define TPM_E_AUTHFAIL _HRESULT_TYPEDEF_(0x80280001L)")]
    public const int TPM_E_AUTHFAIL = unchecked((int)(0x80280001));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BADINDEX"]/*' />
    [NativeTypeName("#define TPM_E_BADINDEX _HRESULT_TYPEDEF_(0x80280002L)")]
    public const int TPM_E_BADINDEX = unchecked((int)(0x80280002));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_PARAMETER"]/*' />
    [NativeTypeName("#define TPM_E_BAD_PARAMETER _HRESULT_TYPEDEF_(0x80280003L)")]
    public const int TPM_E_BAD_PARAMETER = unchecked((int)(0x80280003));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUDITFAILURE"]/*' />
    [NativeTypeName("#define TPM_E_AUDITFAILURE _HRESULT_TYPEDEF_(0x80280004L)")]
    public const int TPM_E_AUDITFAILURE = unchecked((int)(0x80280004));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_CLEAR_DISABLED"]/*' />
    [NativeTypeName("#define TPM_E_CLEAR_DISABLED _HRESULT_TYPEDEF_(0x80280005L)")]
    public const int TPM_E_CLEAR_DISABLED = unchecked((int)(0x80280005));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DEACTIVATED"]/*' />
    [NativeTypeName("#define TPM_E_DEACTIVATED _HRESULT_TYPEDEF_(0x80280006L)")]
    public const int TPM_E_DEACTIVATED = unchecked((int)(0x80280006));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DISABLED"]/*' />
    [NativeTypeName("#define TPM_E_DISABLED _HRESULT_TYPEDEF_(0x80280007L)")]
    public const int TPM_E_DISABLED = unchecked((int)(0x80280007));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DISABLED_CMD"]/*' />
    [NativeTypeName("#define TPM_E_DISABLED_CMD _HRESULT_TYPEDEF_(0x80280008L)")]
    public const int TPM_E_DISABLED_CMD = unchecked((int)(0x80280008));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_FAIL"]/*' />
    [NativeTypeName("#define TPM_E_FAIL _HRESULT_TYPEDEF_(0x80280009L)")]
    public const int TPM_E_FAIL = unchecked((int)(0x80280009));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_ORDINAL"]/*' />
    [NativeTypeName("#define TPM_E_BAD_ORDINAL _HRESULT_TYPEDEF_(0x8028000AL)")]
    public const int TPM_E_BAD_ORDINAL = unchecked((int)(0x8028000A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INSTALL_DISABLED"]/*' />
    [NativeTypeName("#define TPM_E_INSTALL_DISABLED _HRESULT_TYPEDEF_(0x8028000BL)")]
    public const int TPM_E_INSTALL_DISABLED = unchecked((int)(0x8028000B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_KEYHANDLE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_KEYHANDLE _HRESULT_TYPEDEF_(0x8028000CL)")]
    public const int TPM_E_INVALID_KEYHANDLE = unchecked((int)(0x8028000C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEYNOTFOUND"]/*' />
    [NativeTypeName("#define TPM_E_KEYNOTFOUND _HRESULT_TYPEDEF_(0x8028000DL)")]
    public const int TPM_E_KEYNOTFOUND = unchecked((int)(0x8028000D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INAPPROPRIATE_ENC"]/*' />
    [NativeTypeName("#define TPM_E_INAPPROPRIATE_ENC _HRESULT_TYPEDEF_(0x8028000EL)")]
    public const int TPM_E_INAPPROPRIATE_ENC = unchecked((int)(0x8028000E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MIGRATEFAIL"]/*' />
    [NativeTypeName("#define TPM_E_MIGRATEFAIL _HRESULT_TYPEDEF_(0x8028000FL)")]
    public const int TPM_E_MIGRATEFAIL = unchecked((int)(0x8028000F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_PCR_INFO"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_PCR_INFO _HRESULT_TYPEDEF_(0x80280010L)")]
    public const int TPM_E_INVALID_PCR_INFO = unchecked((int)(0x80280010));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOSPACE"]/*' />
    [NativeTypeName("#define TPM_E_NOSPACE _HRESULT_TYPEDEF_(0x80280011L)")]
    public const int TPM_E_NOSPACE = unchecked((int)(0x80280011));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOSRK"]/*' />
    [NativeTypeName("#define TPM_E_NOSRK _HRESULT_TYPEDEF_(0x80280012L)")]
    public const int TPM_E_NOSRK = unchecked((int)(0x80280012));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOTSEALED_BLOB"]/*' />
    [NativeTypeName("#define TPM_E_NOTSEALED_BLOB _HRESULT_TYPEDEF_(0x80280013L)")]
    public const int TPM_E_NOTSEALED_BLOB = unchecked((int)(0x80280013));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_OWNER_SET"]/*' />
    [NativeTypeName("#define TPM_E_OWNER_SET _HRESULT_TYPEDEF_(0x80280014L)")]
    public const int TPM_E_OWNER_SET = unchecked((int)(0x80280014));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_RESOURCES"]/*' />
    [NativeTypeName("#define TPM_E_RESOURCES _HRESULT_TYPEDEF_(0x80280015L)")]
    public const int TPM_E_RESOURCES = unchecked((int)(0x80280015));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_SHORTRANDOM"]/*' />
    [NativeTypeName("#define TPM_E_SHORTRANDOM _HRESULT_TYPEDEF_(0x80280016L)")]
    public const int TPM_E_SHORTRANDOM = unchecked((int)(0x80280016));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_SIZE"]/*' />
    [NativeTypeName("#define TPM_E_SIZE _HRESULT_TYPEDEF_(0x80280017L)")]
    public const int TPM_E_SIZE = unchecked((int)(0x80280017));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_WRONGPCRVAL"]/*' />
    [NativeTypeName("#define TPM_E_WRONGPCRVAL _HRESULT_TYPEDEF_(0x80280018L)")]
    public const int TPM_E_WRONGPCRVAL = unchecked((int)(0x80280018));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_PARAM_SIZE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_PARAM_SIZE _HRESULT_TYPEDEF_(0x80280019L)")]
    public const int TPM_E_BAD_PARAM_SIZE = unchecked((int)(0x80280019));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_SHA_THREAD"]/*' />
    [NativeTypeName("#define TPM_E_SHA_THREAD _HRESULT_TYPEDEF_(0x8028001AL)")]
    public const int TPM_E_SHA_THREAD = unchecked((int)(0x8028001A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_SHA_ERROR"]/*' />
    [NativeTypeName("#define TPM_E_SHA_ERROR _HRESULT_TYPEDEF_(0x8028001BL)")]
    public const int TPM_E_SHA_ERROR = unchecked((int)(0x8028001B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_FAILEDSELFTEST"]/*' />
    [NativeTypeName("#define TPM_E_FAILEDSELFTEST _HRESULT_TYPEDEF_(0x8028001CL)")]
    public const int TPM_E_FAILEDSELFTEST = unchecked((int)(0x8028001C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUTH2FAIL"]/*' />
    [NativeTypeName("#define TPM_E_AUTH2FAIL _HRESULT_TYPEDEF_(0x8028001DL)")]
    public const int TPM_E_AUTH2FAIL = unchecked((int)(0x8028001D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BADTAG"]/*' />
    [NativeTypeName("#define TPM_E_BADTAG _HRESULT_TYPEDEF_(0x8028001EL)")]
    public const int TPM_E_BADTAG = unchecked((int)(0x8028001E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_IOERROR"]/*' />
    [NativeTypeName("#define TPM_E_IOERROR _HRESULT_TYPEDEF_(0x8028001FL)")]
    public const int TPM_E_IOERROR = unchecked((int)(0x8028001F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_ENCRYPT_ERROR"]/*' />
    [NativeTypeName("#define TPM_E_ENCRYPT_ERROR _HRESULT_TYPEDEF_(0x80280020L)")]
    public const int TPM_E_ENCRYPT_ERROR = unchecked((int)(0x80280020));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DECRYPT_ERROR"]/*' />
    [NativeTypeName("#define TPM_E_DECRYPT_ERROR _HRESULT_TYPEDEF_(0x80280021L)")]
    public const int TPM_E_DECRYPT_ERROR = unchecked((int)(0x80280021));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_AUTHHANDLE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_AUTHHANDLE _HRESULT_TYPEDEF_(0x80280022L)")]
    public const int TPM_E_INVALID_AUTHHANDLE = unchecked((int)(0x80280022));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NO_ENDORSEMENT"]/*' />
    [NativeTypeName("#define TPM_E_NO_ENDORSEMENT _HRESULT_TYPEDEF_(0x80280023L)")]
    public const int TPM_E_NO_ENDORSEMENT = unchecked((int)(0x80280023));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_KEYUSAGE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_KEYUSAGE _HRESULT_TYPEDEF_(0x80280024L)")]
    public const int TPM_E_INVALID_KEYUSAGE = unchecked((int)(0x80280024));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_WRONG_ENTITYTYPE"]/*' />
    [NativeTypeName("#define TPM_E_WRONG_ENTITYTYPE _HRESULT_TYPEDEF_(0x80280025L)")]
    public const int TPM_E_WRONG_ENTITYTYPE = unchecked((int)(0x80280025));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_POSTINIT"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_POSTINIT _HRESULT_TYPEDEF_(0x80280026L)")]
    public const int TPM_E_INVALID_POSTINIT = unchecked((int)(0x80280026));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INAPPROPRIATE_SIG"]/*' />
    [NativeTypeName("#define TPM_E_INAPPROPRIATE_SIG _HRESULT_TYPEDEF_(0x80280027L)")]
    public const int TPM_E_INAPPROPRIATE_SIG = unchecked((int)(0x80280027));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_KEY_PROPERTY"]/*' />
    [NativeTypeName("#define TPM_E_BAD_KEY_PROPERTY _HRESULT_TYPEDEF_(0x80280028L)")]
    public const int TPM_E_BAD_KEY_PROPERTY = unchecked((int)(0x80280028));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_MIGRATION"]/*' />
    [NativeTypeName("#define TPM_E_BAD_MIGRATION _HRESULT_TYPEDEF_(0x80280029L)")]
    public const int TPM_E_BAD_MIGRATION = unchecked((int)(0x80280029));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_SCHEME"]/*' />
    [NativeTypeName("#define TPM_E_BAD_SCHEME _HRESULT_TYPEDEF_(0x8028002AL)")]
    public const int TPM_E_BAD_SCHEME = unchecked((int)(0x8028002A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_DATASIZE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_DATASIZE _HRESULT_TYPEDEF_(0x8028002BL)")]
    public const int TPM_E_BAD_DATASIZE = unchecked((int)(0x8028002B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_MODE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_MODE _HRESULT_TYPEDEF_(0x8028002CL)")]
    public const int TPM_E_BAD_MODE = unchecked((int)(0x8028002C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_PRESENCE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_PRESENCE _HRESULT_TYPEDEF_(0x8028002DL)")]
    public const int TPM_E_BAD_PRESENCE = unchecked((int)(0x8028002D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_VERSION"]/*' />
    [NativeTypeName("#define TPM_E_BAD_VERSION _HRESULT_TYPEDEF_(0x8028002EL)")]
    public const int TPM_E_BAD_VERSION = unchecked((int)(0x8028002E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NO_WRAP_TRANSPORT"]/*' />
    [NativeTypeName("#define TPM_E_NO_WRAP_TRANSPORT _HRESULT_TYPEDEF_(0x8028002FL)")]
    public const int TPM_E_NO_WRAP_TRANSPORT = unchecked((int)(0x8028002F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUDITFAIL_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define TPM_E_AUDITFAIL_UNSUCCESSFUL _HRESULT_TYPEDEF_(0x80280030L)")]
    public const int TPM_E_AUDITFAIL_UNSUCCESSFUL = unchecked((int)(0x80280030));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUDITFAIL_SUCCESSFUL"]/*' />
    [NativeTypeName("#define TPM_E_AUDITFAIL_SUCCESSFUL _HRESULT_TYPEDEF_(0x80280031L)")]
    public const int TPM_E_AUDITFAIL_SUCCESSFUL = unchecked((int)(0x80280031));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOTRESETABLE"]/*' />
    [NativeTypeName("#define TPM_E_NOTRESETABLE _HRESULT_TYPEDEF_(0x80280032L)")]
    public const int TPM_E_NOTRESETABLE = unchecked((int)(0x80280032));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOTLOCAL"]/*' />
    [NativeTypeName("#define TPM_E_NOTLOCAL _HRESULT_TYPEDEF_(0x80280033L)")]
    public const int TPM_E_NOTLOCAL = unchecked((int)(0x80280033));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_TYPE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_TYPE _HRESULT_TYPEDEF_(0x80280034L)")]
    public const int TPM_E_BAD_TYPE = unchecked((int)(0x80280034));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_RESOURCE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_RESOURCE _HRESULT_TYPEDEF_(0x80280035L)")]
    public const int TPM_E_INVALID_RESOURCE = unchecked((int)(0x80280035));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOTFIPS"]/*' />
    [NativeTypeName("#define TPM_E_NOTFIPS _HRESULT_TYPEDEF_(0x80280036L)")]
    public const int TPM_E_NOTFIPS = unchecked((int)(0x80280036));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_FAMILY"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_FAMILY _HRESULT_TYPEDEF_(0x80280037L)")]
    public const int TPM_E_INVALID_FAMILY = unchecked((int)(0x80280037));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NO_NV_PERMISSION"]/*' />
    [NativeTypeName("#define TPM_E_NO_NV_PERMISSION _HRESULT_TYPEDEF_(0x80280038L)")]
    public const int TPM_E_NO_NV_PERMISSION = unchecked((int)(0x80280038));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_REQUIRES_SIGN"]/*' />
    [NativeTypeName("#define TPM_E_REQUIRES_SIGN _HRESULT_TYPEDEF_(0x80280039L)")]
    public const int TPM_E_REQUIRES_SIGN = unchecked((int)(0x80280039));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_NOTSUPPORTED _HRESULT_TYPEDEF_(0x8028003AL)")]
    public const int TPM_E_KEY_NOTSUPPORTED = unchecked((int)(0x8028003A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AUTH_CONFLICT"]/*' />
    [NativeTypeName("#define TPM_E_AUTH_CONFLICT _HRESULT_TYPEDEF_(0x8028003BL)")]
    public const int TPM_E_AUTH_CONFLICT = unchecked((int)(0x8028003B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_AREA_LOCKED"]/*' />
    [NativeTypeName("#define TPM_E_AREA_LOCKED _HRESULT_TYPEDEF_(0x8028003CL)")]
    public const int TPM_E_AREA_LOCKED = unchecked((int)(0x8028003C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_LOCALITY"]/*' />
    [NativeTypeName("#define TPM_E_BAD_LOCALITY _HRESULT_TYPEDEF_(0x8028003DL)")]
    public const int TPM_E_BAD_LOCALITY = unchecked((int)(0x8028003D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_READ_ONLY"]/*' />
    [NativeTypeName("#define TPM_E_READ_ONLY _HRESULT_TYPEDEF_(0x8028003EL)")]
    public const int TPM_E_READ_ONLY = unchecked((int)(0x8028003E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PER_NOWRITE"]/*' />
    [NativeTypeName("#define TPM_E_PER_NOWRITE _HRESULT_TYPEDEF_(0x8028003FL)")]
    public const int TPM_E_PER_NOWRITE = unchecked((int)(0x8028003F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_FAMILYCOUNT"]/*' />
    [NativeTypeName("#define TPM_E_FAMILYCOUNT _HRESULT_TYPEDEF_(0x80280040L)")]
    public const int TPM_E_FAMILYCOUNT = unchecked((int)(0x80280040));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_WRITE_LOCKED"]/*' />
    [NativeTypeName("#define TPM_E_WRITE_LOCKED _HRESULT_TYPEDEF_(0x80280041L)")]
    public const int TPM_E_WRITE_LOCKED = unchecked((int)(0x80280041));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_ATTRIBUTES"]/*' />
    [NativeTypeName("#define TPM_E_BAD_ATTRIBUTES _HRESULT_TYPEDEF_(0x80280042L)")]
    public const int TPM_E_BAD_ATTRIBUTES = unchecked((int)(0x80280042));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_STRUCTURE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_STRUCTURE _HRESULT_TYPEDEF_(0x80280043L)")]
    public const int TPM_E_INVALID_STRUCTURE = unchecked((int)(0x80280043));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_OWNER_CONTROL"]/*' />
    [NativeTypeName("#define TPM_E_KEY_OWNER_CONTROL _HRESULT_TYPEDEF_(0x80280044L)")]
    public const int TPM_E_KEY_OWNER_CONTROL = unchecked((int)(0x80280044));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_COUNTER"]/*' />
    [NativeTypeName("#define TPM_E_BAD_COUNTER _HRESULT_TYPEDEF_(0x80280045L)")]
    public const int TPM_E_BAD_COUNTER = unchecked((int)(0x80280045));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOT_FULLWRITE"]/*' />
    [NativeTypeName("#define TPM_E_NOT_FULLWRITE _HRESULT_TYPEDEF_(0x80280046L)")]
    public const int TPM_E_NOT_FULLWRITE = unchecked((int)(0x80280046));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_CONTEXT_GAP"]/*' />
    [NativeTypeName("#define TPM_E_CONTEXT_GAP _HRESULT_TYPEDEF_(0x80280047L)")]
    public const int TPM_E_CONTEXT_GAP = unchecked((int)(0x80280047));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MAXNVWRITES"]/*' />
    [NativeTypeName("#define TPM_E_MAXNVWRITES _HRESULT_TYPEDEF_(0x80280048L)")]
    public const int TPM_E_MAXNVWRITES = unchecked((int)(0x80280048));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOOPERATOR"]/*' />
    [NativeTypeName("#define TPM_E_NOOPERATOR _HRESULT_TYPEDEF_(0x80280049L)")]
    public const int TPM_E_NOOPERATOR = unchecked((int)(0x80280049));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_RESOURCEMISSING"]/*' />
    [NativeTypeName("#define TPM_E_RESOURCEMISSING _HRESULT_TYPEDEF_(0x8028004AL)")]
    public const int TPM_E_RESOURCEMISSING = unchecked((int)(0x8028004A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DELEGATE_LOCK"]/*' />
    [NativeTypeName("#define TPM_E_DELEGATE_LOCK _HRESULT_TYPEDEF_(0x8028004BL)")]
    public const int TPM_E_DELEGATE_LOCK = unchecked((int)(0x8028004B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DELEGATE_FAMILY"]/*' />
    [NativeTypeName("#define TPM_E_DELEGATE_FAMILY _HRESULT_TYPEDEF_(0x8028004CL)")]
    public const int TPM_E_DELEGATE_FAMILY = unchecked((int)(0x8028004C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DELEGATE_ADMIN"]/*' />
    [NativeTypeName("#define TPM_E_DELEGATE_ADMIN _HRESULT_TYPEDEF_(0x8028004DL)")]
    public const int TPM_E_DELEGATE_ADMIN = unchecked((int)(0x8028004D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_TRANSPORT_NOTEXCLUSIVE"]/*' />
    [NativeTypeName("#define TPM_E_TRANSPORT_NOTEXCLUSIVE _HRESULT_TYPEDEF_(0x8028004EL)")]
    public const int TPM_E_TRANSPORT_NOTEXCLUSIVE = unchecked((int)(0x8028004E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_OWNER_CONTROL"]/*' />
    [NativeTypeName("#define TPM_E_OWNER_CONTROL _HRESULT_TYPEDEF_(0x8028004FL)")]
    public const int TPM_E_OWNER_CONTROL = unchecked((int)(0x8028004F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_RESOURCES"]/*' />
    [NativeTypeName("#define TPM_E_DAA_RESOURCES _HRESULT_TYPEDEF_(0x80280050L)")]
    public const int TPM_E_DAA_RESOURCES = unchecked((int)(0x80280050));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_INPUT_DATA0"]/*' />
    [NativeTypeName("#define TPM_E_DAA_INPUT_DATA0 _HRESULT_TYPEDEF_(0x80280051L)")]
    public const int TPM_E_DAA_INPUT_DATA0 = unchecked((int)(0x80280051));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_INPUT_DATA1"]/*' />
    [NativeTypeName("#define TPM_E_DAA_INPUT_DATA1 _HRESULT_TYPEDEF_(0x80280052L)")]
    public const int TPM_E_DAA_INPUT_DATA1 = unchecked((int)(0x80280052));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_ISSUER_SETTINGS"]/*' />
    [NativeTypeName("#define TPM_E_DAA_ISSUER_SETTINGS _HRESULT_TYPEDEF_(0x80280053L)")]
    public const int TPM_E_DAA_ISSUER_SETTINGS = unchecked((int)(0x80280053));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_TPM_SETTINGS"]/*' />
    [NativeTypeName("#define TPM_E_DAA_TPM_SETTINGS _HRESULT_TYPEDEF_(0x80280054L)")]
    public const int TPM_E_DAA_TPM_SETTINGS = unchecked((int)(0x80280054));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_STAGE"]/*' />
    [NativeTypeName("#define TPM_E_DAA_STAGE _HRESULT_TYPEDEF_(0x80280055L)")]
    public const int TPM_E_DAA_STAGE = unchecked((int)(0x80280055));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_ISSUER_VALIDITY"]/*' />
    [NativeTypeName("#define TPM_E_DAA_ISSUER_VALIDITY _HRESULT_TYPEDEF_(0x80280056L)")]
    public const int TPM_E_DAA_ISSUER_VALIDITY = unchecked((int)(0x80280056));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DAA_WRONG_W"]/*' />
    [NativeTypeName("#define TPM_E_DAA_WRONG_W _HRESULT_TYPEDEF_(0x80280057L)")]
    public const int TPM_E_DAA_WRONG_W = unchecked((int)(0x80280057));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_HANDLE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_HANDLE _HRESULT_TYPEDEF_(0x80280058L)")]
    public const int TPM_E_BAD_HANDLE = unchecked((int)(0x80280058));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_DELEGATE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_DELEGATE _HRESULT_TYPEDEF_(0x80280059L)")]
    public const int TPM_E_BAD_DELEGATE = unchecked((int)(0x80280059));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BADCONTEXT"]/*' />
    [NativeTypeName("#define TPM_E_BADCONTEXT _HRESULT_TYPEDEF_(0x8028005AL)")]
    public const int TPM_E_BADCONTEXT = unchecked((int)(0x8028005A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_TOOMANYCONTEXTS"]/*' />
    [NativeTypeName("#define TPM_E_TOOMANYCONTEXTS _HRESULT_TYPEDEF_(0x8028005BL)")]
    public const int TPM_E_TOOMANYCONTEXTS = unchecked((int)(0x8028005B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MA_TICKET_SIGNATURE"]/*' />
    [NativeTypeName("#define TPM_E_MA_TICKET_SIGNATURE _HRESULT_TYPEDEF_(0x8028005CL)")]
    public const int TPM_E_MA_TICKET_SIGNATURE = unchecked((int)(0x8028005C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MA_DESTINATION"]/*' />
    [NativeTypeName("#define TPM_E_MA_DESTINATION _HRESULT_TYPEDEF_(0x8028005DL)")]
    public const int TPM_E_MA_DESTINATION = unchecked((int)(0x8028005D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MA_SOURCE"]/*' />
    [NativeTypeName("#define TPM_E_MA_SOURCE _HRESULT_TYPEDEF_(0x8028005EL)")]
    public const int TPM_E_MA_SOURCE = unchecked((int)(0x8028005E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_MA_AUTHORITY"]/*' />
    [NativeTypeName("#define TPM_E_MA_AUTHORITY _HRESULT_TYPEDEF_(0x8028005FL)")]
    public const int TPM_E_MA_AUTHORITY = unchecked((int)(0x8028005F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PERMANENTEK"]/*' />
    [NativeTypeName("#define TPM_E_PERMANENTEK _HRESULT_TYPEDEF_(0x80280061L)")]
    public const int TPM_E_PERMANENTEK = unchecked((int)(0x80280061));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define TPM_E_BAD_SIGNATURE _HRESULT_TYPEDEF_(0x80280062L)")]
    public const int TPM_E_BAD_SIGNATURE = unchecked((int)(0x80280062));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOCONTEXTSPACE"]/*' />
    [NativeTypeName("#define TPM_E_NOCONTEXTSPACE _HRESULT_TYPEDEF_(0x80280063L)")]
    public const int TPM_E_NOCONTEXTSPACE = unchecked((int)(0x80280063));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_ASYMMETRIC"]/*' />
    [NativeTypeName("#define TPM_20_E_ASYMMETRIC _HRESULT_TYPEDEF_(0x80280081L)")]
    public const int TPM_20_E_ASYMMETRIC = unchecked((int)(0x80280081));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_ATTRIBUTES"]/*' />
    [NativeTypeName("#define TPM_20_E_ATTRIBUTES _HRESULT_TYPEDEF_(0x80280082L)")]
    public const int TPM_20_E_ATTRIBUTES = unchecked((int)(0x80280082));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_HASH"]/*' />
    [NativeTypeName("#define TPM_20_E_HASH _HRESULT_TYPEDEF_(0x80280083L)")]
    public const int TPM_20_E_HASH = unchecked((int)(0x80280083));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_VALUE"]/*' />
    [NativeTypeName("#define TPM_20_E_VALUE _HRESULT_TYPEDEF_(0x80280084L)")]
    public const int TPM_20_E_VALUE = unchecked((int)(0x80280084));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_HIERARCHY"]/*' />
    [NativeTypeName("#define TPM_20_E_HIERARCHY _HRESULT_TYPEDEF_(0x80280085L)")]
    public const int TPM_20_E_HIERARCHY = unchecked((int)(0x80280085));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_KEY_SIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_KEY_SIZE _HRESULT_TYPEDEF_(0x80280087L)")]
    public const int TPM_20_E_KEY_SIZE = unchecked((int)(0x80280087));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_MGF"]/*' />
    [NativeTypeName("#define TPM_20_E_MGF _HRESULT_TYPEDEF_(0x80280088L)")]
    public const int TPM_20_E_MGF = unchecked((int)(0x80280088));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_MODE"]/*' />
    [NativeTypeName("#define TPM_20_E_MODE _HRESULT_TYPEDEF_(0x80280089L)")]
    public const int TPM_20_E_MODE = unchecked((int)(0x80280089));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_TYPE"]/*' />
    [NativeTypeName("#define TPM_20_E_TYPE _HRESULT_TYPEDEF_(0x8028008AL)")]
    public const int TPM_20_E_TYPE = unchecked((int)(0x8028008A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_HANDLE"]/*' />
    [NativeTypeName("#define TPM_20_E_HANDLE _HRESULT_TYPEDEF_(0x8028008BL)")]
    public const int TPM_20_E_HANDLE = unchecked((int)(0x8028008B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_KDF"]/*' />
    [NativeTypeName("#define TPM_20_E_KDF _HRESULT_TYPEDEF_(0x8028008CL)")]
    public const int TPM_20_E_KDF = unchecked((int)(0x8028008C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_RANGE"]/*' />
    [NativeTypeName("#define TPM_20_E_RANGE _HRESULT_TYPEDEF_(0x8028008DL)")]
    public const int TPM_20_E_RANGE = unchecked((int)(0x8028008D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTH_FAIL"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTH_FAIL _HRESULT_TYPEDEF_(0x8028008EL)")]
    public const int TPM_20_E_AUTH_FAIL = unchecked((int)(0x8028008E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NONCE"]/*' />
    [NativeTypeName("#define TPM_20_E_NONCE _HRESULT_TYPEDEF_(0x8028008FL)")]
    public const int TPM_20_E_NONCE = unchecked((int)(0x8028008F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_PP"]/*' />
    [NativeTypeName("#define TPM_20_E_PP _HRESULT_TYPEDEF_(0x80280090L)")]
    public const int TPM_20_E_PP = unchecked((int)(0x80280090));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SCHEME"]/*' />
    [NativeTypeName("#define TPM_20_E_SCHEME _HRESULT_TYPEDEF_(0x80280092L)")]
    public const int TPM_20_E_SCHEME = unchecked((int)(0x80280092));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_SIZE _HRESULT_TYPEDEF_(0x80280095L)")]
    public const int TPM_20_E_SIZE = unchecked((int)(0x80280095));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SYMMETRIC"]/*' />
    [NativeTypeName("#define TPM_20_E_SYMMETRIC _HRESULT_TYPEDEF_(0x80280096L)")]
    public const int TPM_20_E_SYMMETRIC = unchecked((int)(0x80280096));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_TAG"]/*' />
    [NativeTypeName("#define TPM_20_E_TAG _HRESULT_TYPEDEF_(0x80280097L)")]
    public const int TPM_20_E_TAG = unchecked((int)(0x80280097));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SELECTOR"]/*' />
    [NativeTypeName("#define TPM_20_E_SELECTOR _HRESULT_TYPEDEF_(0x80280098L)")]
    public const int TPM_20_E_SELECTOR = unchecked((int)(0x80280098));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_INSUFFICIENT"]/*' />
    [NativeTypeName("#define TPM_20_E_INSUFFICIENT _HRESULT_TYPEDEF_(0x8028009AL)")]
    public const int TPM_20_E_INSUFFICIENT = unchecked((int)(0x8028009A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SIGNATURE"]/*' />
    [NativeTypeName("#define TPM_20_E_SIGNATURE _HRESULT_TYPEDEF_(0x8028009BL)")]
    public const int TPM_20_E_SIGNATURE = unchecked((int)(0x8028009B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_KEY"]/*' />
    [NativeTypeName("#define TPM_20_E_KEY _HRESULT_TYPEDEF_(0x8028009CL)")]
    public const int TPM_20_E_KEY = unchecked((int)(0x8028009C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_POLICY_FAIL"]/*' />
    [NativeTypeName("#define TPM_20_E_POLICY_FAIL _HRESULT_TYPEDEF_(0x8028009DL)")]
    public const int TPM_20_E_POLICY_FAIL = unchecked((int)(0x8028009D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_INTEGRITY"]/*' />
    [NativeTypeName("#define TPM_20_E_INTEGRITY _HRESULT_TYPEDEF_(0x8028009FL)")]
    public const int TPM_20_E_INTEGRITY = unchecked((int)(0x8028009F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_TICKET"]/*' />
    [NativeTypeName("#define TPM_20_E_TICKET _HRESULT_TYPEDEF_(0x802800A0L)")]
    public const int TPM_20_E_TICKET = unchecked((int)(0x802800A0));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_RESERVED_BITS"]/*' />
    [NativeTypeName("#define TPM_20_E_RESERVED_BITS _HRESULT_TYPEDEF_(0x802800A1L)")]
    public const int TPM_20_E_RESERVED_BITS = unchecked((int)(0x802800A1));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_BAD_AUTH"]/*' />
    [NativeTypeName("#define TPM_20_E_BAD_AUTH _HRESULT_TYPEDEF_(0x802800A2L)")]
    public const int TPM_20_E_BAD_AUTH = unchecked((int)(0x802800A2));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_EXPIRED"]/*' />
    [NativeTypeName("#define TPM_20_E_EXPIRED _HRESULT_TYPEDEF_(0x802800A3L)")]
    public const int TPM_20_E_EXPIRED = unchecked((int)(0x802800A3));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_POLICY_CC"]/*' />
    [NativeTypeName("#define TPM_20_E_POLICY_CC _HRESULT_TYPEDEF_(0x802800A4L)")]
    public const int TPM_20_E_POLICY_CC = unchecked((int)(0x802800A4));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_BINDING"]/*' />
    [NativeTypeName("#define TPM_20_E_BINDING _HRESULT_TYPEDEF_(0x802800A5L)")]
    public const int TPM_20_E_BINDING = unchecked((int)(0x802800A5));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_CURVE"]/*' />
    [NativeTypeName("#define TPM_20_E_CURVE _HRESULT_TYPEDEF_(0x802800A6L)")]
    public const int TPM_20_E_CURVE = unchecked((int)(0x802800A6));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_ECC_POINT"]/*' />
    [NativeTypeName("#define TPM_20_E_ECC_POINT _HRESULT_TYPEDEF_(0x802800A7L)")]
    public const int TPM_20_E_ECC_POINT = unchecked((int)(0x802800A7));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_INITIALIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_INITIALIZE _HRESULT_TYPEDEF_(0x80280100L)")]
    public const int TPM_20_E_INITIALIZE = unchecked((int)(0x80280100));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_FAILURE"]/*' />
    [NativeTypeName("#define TPM_20_E_FAILURE _HRESULT_TYPEDEF_(0x80280101L)")]
    public const int TPM_20_E_FAILURE = unchecked((int)(0x80280101));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SEQUENCE"]/*' />
    [NativeTypeName("#define TPM_20_E_SEQUENCE _HRESULT_TYPEDEF_(0x80280103L)")]
    public const int TPM_20_E_SEQUENCE = unchecked((int)(0x80280103));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_PRIVATE"]/*' />
    [NativeTypeName("#define TPM_20_E_PRIVATE _HRESULT_TYPEDEF_(0x8028010BL)")]
    public const int TPM_20_E_PRIVATE = unchecked((int)(0x8028010B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_HMAC"]/*' />
    [NativeTypeName("#define TPM_20_E_HMAC _HRESULT_TYPEDEF_(0x80280119L)")]
    public const int TPM_20_E_HMAC = unchecked((int)(0x80280119));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_DISABLED"]/*' />
    [NativeTypeName("#define TPM_20_E_DISABLED _HRESULT_TYPEDEF_(0x80280120L)")]
    public const int TPM_20_E_DISABLED = unchecked((int)(0x80280120));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_EXCLUSIVE"]/*' />
    [NativeTypeName("#define TPM_20_E_EXCLUSIVE _HRESULT_TYPEDEF_(0x80280121L)")]
    public const int TPM_20_E_EXCLUSIVE = unchecked((int)(0x80280121));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_ECC_CURVE"]/*' />
    [NativeTypeName("#define TPM_20_E_ECC_CURVE _HRESULT_TYPEDEF_(0x80280123L)")]
    public const int TPM_20_E_ECC_CURVE = unchecked((int)(0x80280123));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTH_TYPE"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTH_TYPE _HRESULT_TYPEDEF_(0x80280124L)")]
    public const int TPM_20_E_AUTH_TYPE = unchecked((int)(0x80280124));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTH_MISSING"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTH_MISSING _HRESULT_TYPEDEF_(0x80280125L)")]
    public const int TPM_20_E_AUTH_MISSING = unchecked((int)(0x80280125));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_POLICY"]/*' />
    [NativeTypeName("#define TPM_20_E_POLICY _HRESULT_TYPEDEF_(0x80280126L)")]
    public const int TPM_20_E_POLICY = unchecked((int)(0x80280126));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_PCR"]/*' />
    [NativeTypeName("#define TPM_20_E_PCR _HRESULT_TYPEDEF_(0x80280127L)")]
    public const int TPM_20_E_PCR = unchecked((int)(0x80280127));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_PCR_CHANGED"]/*' />
    [NativeTypeName("#define TPM_20_E_PCR_CHANGED _HRESULT_TYPEDEF_(0x80280128L)")]
    public const int TPM_20_E_PCR_CHANGED = unchecked((int)(0x80280128));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_UPGRADE"]/*' />
    [NativeTypeName("#define TPM_20_E_UPGRADE _HRESULT_TYPEDEF_(0x8028012DL)")]
    public const int TPM_20_E_UPGRADE = unchecked((int)(0x8028012D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_TOO_MANY_CONTEXTS"]/*' />
    [NativeTypeName("#define TPM_20_E_TOO_MANY_CONTEXTS _HRESULT_TYPEDEF_(0x8028012EL)")]
    public const int TPM_20_E_TOO_MANY_CONTEXTS = unchecked((int)(0x8028012E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTH_UNAVAILABLE"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTH_UNAVAILABLE _HRESULT_TYPEDEF_(0x8028012FL)")]
    public const int TPM_20_E_AUTH_UNAVAILABLE = unchecked((int)(0x8028012F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_REBOOT"]/*' />
    [NativeTypeName("#define TPM_20_E_REBOOT _HRESULT_TYPEDEF_(0x80280130L)")]
    public const int TPM_20_E_REBOOT = unchecked((int)(0x80280130));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_UNBALANCED"]/*' />
    [NativeTypeName("#define TPM_20_E_UNBALANCED _HRESULT_TYPEDEF_(0x80280131L)")]
    public const int TPM_20_E_UNBALANCED = unchecked((int)(0x80280131));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_COMMAND_SIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_COMMAND_SIZE _HRESULT_TYPEDEF_(0x80280142L)")]
    public const int TPM_20_E_COMMAND_SIZE = unchecked((int)(0x80280142));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_COMMAND_CODE"]/*' />
    [NativeTypeName("#define TPM_20_E_COMMAND_CODE _HRESULT_TYPEDEF_(0x80280143L)")]
    public const int TPM_20_E_COMMAND_CODE = unchecked((int)(0x80280143));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTHSIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTHSIZE _HRESULT_TYPEDEF_(0x80280144L)")]
    public const int TPM_20_E_AUTHSIZE = unchecked((int)(0x80280144));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_AUTH_CONTEXT"]/*' />
    [NativeTypeName("#define TPM_20_E_AUTH_CONTEXT _HRESULT_TYPEDEF_(0x80280145L)")]
    public const int TPM_20_E_AUTH_CONTEXT = unchecked((int)(0x80280145));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_RANGE"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_RANGE _HRESULT_TYPEDEF_(0x80280146L)")]
    public const int TPM_20_E_NV_RANGE = unchecked((int)(0x80280146));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_SIZE"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_SIZE _HRESULT_TYPEDEF_(0x80280147L)")]
    public const int TPM_20_E_NV_SIZE = unchecked((int)(0x80280147));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_LOCKED"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_LOCKED _HRESULT_TYPEDEF_(0x80280148L)")]
    public const int TPM_20_E_NV_LOCKED = unchecked((int)(0x80280148));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_AUTHORIZATION"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_AUTHORIZATION _HRESULT_TYPEDEF_(0x80280149L)")]
    public const int TPM_20_E_NV_AUTHORIZATION = unchecked((int)(0x80280149));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_UNINITIALIZED"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_UNINITIALIZED _HRESULT_TYPEDEF_(0x8028014AL)")]
    public const int TPM_20_E_NV_UNINITIALIZED = unchecked((int)(0x8028014A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_SPACE"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_SPACE _HRESULT_TYPEDEF_(0x8028014BL)")]
    public const int TPM_20_E_NV_SPACE = unchecked((int)(0x8028014B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_DEFINED"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_DEFINED _HRESULT_TYPEDEF_(0x8028014CL)")]
    public const int TPM_20_E_NV_DEFINED = unchecked((int)(0x8028014C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_BAD_CONTEXT"]/*' />
    [NativeTypeName("#define TPM_20_E_BAD_CONTEXT _HRESULT_TYPEDEF_(0x80280150L)")]
    public const int TPM_20_E_BAD_CONTEXT = unchecked((int)(0x80280150));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_CPHASH"]/*' />
    [NativeTypeName("#define TPM_20_E_CPHASH _HRESULT_TYPEDEF_(0x80280151L)")]
    public const int TPM_20_E_CPHASH = unchecked((int)(0x80280151));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_PARENT"]/*' />
    [NativeTypeName("#define TPM_20_E_PARENT _HRESULT_TYPEDEF_(0x80280152L)")]
    public const int TPM_20_E_PARENT = unchecked((int)(0x80280152));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NEEDS_TEST"]/*' />
    [NativeTypeName("#define TPM_20_E_NEEDS_TEST _HRESULT_TYPEDEF_(0x80280153L)")]
    public const int TPM_20_E_NEEDS_TEST = unchecked((int)(0x80280153));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NO_RESULT"]/*' />
    [NativeTypeName("#define TPM_20_E_NO_RESULT _HRESULT_TYPEDEF_(0x80280154L)")]
    public const int TPM_20_E_NO_RESULT = unchecked((int)(0x80280154));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SENSITIVE"]/*' />
    [NativeTypeName("#define TPM_20_E_SENSITIVE _HRESULT_TYPEDEF_(0x80280155L)")]
    public const int TPM_20_E_SENSITIVE = unchecked((int)(0x80280155));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_COMMAND_BLOCKED"]/*' />
    [NativeTypeName("#define TPM_E_COMMAND_BLOCKED _HRESULT_TYPEDEF_(0x80280400L)")]
    public const int TPM_E_COMMAND_BLOCKED = unchecked((int)(0x80280400));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80280401L)")]
    public const int TPM_E_INVALID_HANDLE = unchecked((int)(0x80280401));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DUPLICATE_VHANDLE"]/*' />
    [NativeTypeName("#define TPM_E_DUPLICATE_VHANDLE _HRESULT_TYPEDEF_(0x80280402L)")]
    public const int TPM_E_DUPLICATE_VHANDLE = unchecked((int)(0x80280402));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_EMBEDDED_COMMAND_BLOCKED"]/*' />
    [NativeTypeName("#define TPM_E_EMBEDDED_COMMAND_BLOCKED _HRESULT_TYPEDEF_(0x80280403L)")]
    public const int TPM_E_EMBEDDED_COMMAND_BLOCKED = unchecked((int)(0x80280403));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_EMBEDDED_COMMAND_UNSUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_EMBEDDED_COMMAND_UNSUPPORTED _HRESULT_TYPEDEF_(0x80280404L)")]
    public const int TPM_E_EMBEDDED_COMMAND_UNSUPPORTED = unchecked((int)(0x80280404));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_RETRY"]/*' />
    [NativeTypeName("#define TPM_E_RETRY _HRESULT_TYPEDEF_(0x80280800L)")]
    public const int TPM_E_RETRY = unchecked((int)(0x80280800));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NEEDS_SELFTEST"]/*' />
    [NativeTypeName("#define TPM_E_NEEDS_SELFTEST _HRESULT_TYPEDEF_(0x80280801L)")]
    public const int TPM_E_NEEDS_SELFTEST = unchecked((int)(0x80280801));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DOING_SELFTEST"]/*' />
    [NativeTypeName("#define TPM_E_DOING_SELFTEST _HRESULT_TYPEDEF_(0x80280802L)")]
    public const int TPM_E_DOING_SELFTEST = unchecked((int)(0x80280802));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_DEFEND_LOCK_RUNNING"]/*' />
    [NativeTypeName("#define TPM_E_DEFEND_LOCK_RUNNING _HRESULT_TYPEDEF_(0x80280803L)")]
    public const int TPM_E_DEFEND_LOCK_RUNNING = unchecked((int)(0x80280803));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_CONTEXT_GAP"]/*' />
    [NativeTypeName("#define TPM_20_E_CONTEXT_GAP _HRESULT_TYPEDEF_(0x80280901L)")]
    public const int TPM_20_E_CONTEXT_GAP = unchecked((int)(0x80280901));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_OBJECT_MEMORY"]/*' />
    [NativeTypeName("#define TPM_20_E_OBJECT_MEMORY _HRESULT_TYPEDEF_(0x80280902L)")]
    public const int TPM_20_E_OBJECT_MEMORY = unchecked((int)(0x80280902));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SESSION_MEMORY"]/*' />
    [NativeTypeName("#define TPM_20_E_SESSION_MEMORY _HRESULT_TYPEDEF_(0x80280903L)")]
    public const int TPM_20_E_SESSION_MEMORY = unchecked((int)(0x80280903));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_MEMORY"]/*' />
    [NativeTypeName("#define TPM_20_E_MEMORY _HRESULT_TYPEDEF_(0x80280904L)")]
    public const int TPM_20_E_MEMORY = unchecked((int)(0x80280904));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_SESSION_HANDLES"]/*' />
    [NativeTypeName("#define TPM_20_E_SESSION_HANDLES _HRESULT_TYPEDEF_(0x80280905L)")]
    public const int TPM_20_E_SESSION_HANDLES = unchecked((int)(0x80280905));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_OBJECT_HANDLES"]/*' />
    [NativeTypeName("#define TPM_20_E_OBJECT_HANDLES _HRESULT_TYPEDEF_(0x80280906L)")]
    public const int TPM_20_E_OBJECT_HANDLES = unchecked((int)(0x80280906));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_LOCALITY"]/*' />
    [NativeTypeName("#define TPM_20_E_LOCALITY _HRESULT_TYPEDEF_(0x80280907L)")]
    public const int TPM_20_E_LOCALITY = unchecked((int)(0x80280907));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_YIELDED"]/*' />
    [NativeTypeName("#define TPM_20_E_YIELDED _HRESULT_TYPEDEF_(0x80280908L)")]
    public const int TPM_20_E_YIELDED = unchecked((int)(0x80280908));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_CANCELED"]/*' />
    [NativeTypeName("#define TPM_20_E_CANCELED _HRESULT_TYPEDEF_(0x80280909L)")]
    public const int TPM_20_E_CANCELED = unchecked((int)(0x80280909));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_TESTING"]/*' />
    [NativeTypeName("#define TPM_20_E_TESTING _HRESULT_TYPEDEF_(0x8028090AL)")]
    public const int TPM_20_E_TESTING = unchecked((int)(0x8028090A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_RATE"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_RATE _HRESULT_TYPEDEF_(0x80280920L)")]
    public const int TPM_20_E_NV_RATE = unchecked((int)(0x80280920));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_LOCKOUT"]/*' />
    [NativeTypeName("#define TPM_20_E_LOCKOUT _HRESULT_TYPEDEF_(0x80280921L)")]
    public const int TPM_20_E_LOCKOUT = unchecked((int)(0x80280921));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_RETRY"]/*' />
    [NativeTypeName("#define TPM_20_E_RETRY _HRESULT_TYPEDEF_(0x80280922L)")]
    public const int TPM_20_E_RETRY = unchecked((int)(0x80280922));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_20_E_NV_UNAVAILABLE"]/*' />
    [NativeTypeName("#define TPM_20_E_NV_UNAVAILABLE _HRESULT_TYPEDEF_(0x80280923L)")]
    public const int TPM_20_E_NV_UNAVAILABLE = unchecked((int)(0x80280923));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PPI_ACPI_FAILURE"]/*' />
    [NativeTypeName("#define TPM_E_PPI_ACPI_FAILURE _HRESULT_TYPEDEF_(0x80290300L)")]
    public const int TPM_E_PPI_ACPI_FAILURE = unchecked((int)(0x80290300));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PPI_USER_ABORT"]/*' />
    [NativeTypeName("#define TPM_E_PPI_USER_ABORT _HRESULT_TYPEDEF_(0x80290301L)")]
    public const int TPM_E_PPI_USER_ABORT = unchecked((int)(0x80290301));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PPI_BIOS_FAILURE"]/*' />
    [NativeTypeName("#define TPM_E_PPI_BIOS_FAILURE _HRESULT_TYPEDEF_(0x80290302L)")]
    public const int TPM_E_PPI_BIOS_FAILURE = unchecked((int)(0x80290302));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PPI_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_PPI_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290303L)")]
    public const int TPM_E_PPI_NOT_SUPPORTED = unchecked((int)(0x80290303));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PPI_BLOCKED_IN_BIOS"]/*' />
    [NativeTypeName("#define TPM_E_PPI_BLOCKED_IN_BIOS _HRESULT_TYPEDEF_(0x80290304L)")]
    public const int TPM_E_PPI_BLOCKED_IN_BIOS = unchecked((int)(0x80290304));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_ERROR_MASK"]/*' />
    [NativeTypeName("#define TPM_E_PCP_ERROR_MASK _HRESULT_TYPEDEF_(0x80290400L)")]
    public const int TPM_E_PCP_ERROR_MASK = unchecked((int)(0x80290400));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("#define TPM_E_PCP_DEVICE_NOT_READY _HRESULT_TYPEDEF_(0x80290401L)")]
    public const int TPM_E_PCP_DEVICE_NOT_READY = unchecked((int)(0x80290401));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define TPM_E_PCP_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80290402L)")]
    public const int TPM_E_PCP_INVALID_HANDLE = unchecked((int)(0x80290402));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define TPM_E_PCP_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290403L)")]
    public const int TPM_E_PCP_INVALID_PARAMETER = unchecked((int)(0x80290403));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_FLAG_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_FLAG_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290404L)")]
    public const int TPM_E_PCP_FLAG_NOT_SUPPORTED = unchecked((int)(0x80290404));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290405L)")]
    public const int TPM_E_PCP_NOT_SUPPORTED = unchecked((int)(0x80290405));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define TPM_E_PCP_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290406L)")]
    public const int TPM_E_PCP_BUFFER_TOO_SMALL = unchecked((int)(0x80290406));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define TPM_E_PCP_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80290407L)")]
    public const int TPM_E_PCP_INTERNAL_ERROR = unchecked((int)(0x80290407));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_AUTHENTICATION_FAILED _HRESULT_TYPEDEF_(0x80290408L)")]
    public const int TPM_E_PCP_AUTHENTICATION_FAILED = unchecked((int)(0x80290408));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_AUTHENTICATION_IGNORED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_AUTHENTICATION_IGNORED _HRESULT_TYPEDEF_(0x80290409L)")]
    public const int TPM_E_PCP_AUTHENTICATION_IGNORED = unchecked((int)(0x80290409));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define TPM_E_PCP_POLICY_NOT_FOUND _HRESULT_TYPEDEF_(0x8029040AL)")]
    public const int TPM_E_PCP_POLICY_NOT_FOUND = unchecked((int)(0x8029040A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_PROFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define TPM_E_PCP_PROFILE_NOT_FOUND _HRESULT_TYPEDEF_(0x8029040BL)")]
    public const int TPM_E_PCP_PROFILE_NOT_FOUND = unchecked((int)(0x8029040B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_VALIDATION_FAILED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_VALIDATION_FAILED _HRESULT_TYPEDEF_(0x8029040CL)")]
    public const int TPM_E_PCP_VALIDATION_FAILED = unchecked((int)(0x8029040C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_WRONG_PARENT"]/*' />
    [NativeTypeName("#define TPM_E_PCP_WRONG_PARENT _HRESULT_TYPEDEF_(0x8029040EL)")]
    public const int TPM_E_PCP_WRONG_PARENT = unchecked((int)(0x8029040E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_NOT_LOADED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_NOT_LOADED _HRESULT_TYPEDEF_(0x8029040FL)")]
    public const int TPM_E_KEY_NOT_LOADED = unchecked((int)(0x8029040F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NO_KEY_CERTIFICATION"]/*' />
    [NativeTypeName("#define TPM_E_NO_KEY_CERTIFICATION _HRESULT_TYPEDEF_(0x80290410L)")]
    public const int TPM_E_NO_KEY_CERTIFICATION = unchecked((int)(0x80290410));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_NOT_FINALIZED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_NOT_FINALIZED _HRESULT_TYPEDEF_(0x80290411L)")]
    public const int TPM_E_KEY_NOT_FINALIZED = unchecked((int)(0x80290411));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_ATTESTATION_CHALLENGE_NOT_SET"]/*' />
    [NativeTypeName("#define TPM_E_ATTESTATION_CHALLENGE_NOT_SET _HRESULT_TYPEDEF_(0x80290412L)")]
    public const int TPM_E_ATTESTATION_CHALLENGE_NOT_SET = unchecked((int)(0x80290412));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_NOT_PCR_BOUND"]/*' />
    [NativeTypeName("#define TPM_E_NOT_PCR_BOUND _HRESULT_TYPEDEF_(0x80290413L)")]
    public const int TPM_E_NOT_PCR_BOUND = unchecked((int)(0x80290413));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_ALREADY_FINALIZED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_ALREADY_FINALIZED _HRESULT_TYPEDEF_(0x80290414L)")]
    public const int TPM_E_KEY_ALREADY_FINALIZED = unchecked((int)(0x80290414));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_USAGE_POLICY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_USAGE_POLICY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290415L)")]
    public const int TPM_E_KEY_USAGE_POLICY_NOT_SUPPORTED = unchecked((int)(0x80290415));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_USAGE_POLICY_INVALID"]/*' />
    [NativeTypeName("#define TPM_E_KEY_USAGE_POLICY_INVALID _HRESULT_TYPEDEF_(0x80290416L)")]
    public const int TPM_E_KEY_USAGE_POLICY_INVALID = unchecked((int)(0x80290416));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_SOFT_KEY_ERROR"]/*' />
    [NativeTypeName("#define TPM_E_SOFT_KEY_ERROR _HRESULT_TYPEDEF_(0x80290417L)")]
    public const int TPM_E_SOFT_KEY_ERROR = unchecked((int)(0x80290417));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define TPM_E_KEY_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x80290418L)")]
    public const int TPM_E_KEY_NOT_AUTHENTICATED = unchecked((int)(0x80290418));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_KEY_NOT_AIK"]/*' />
    [NativeTypeName("#define TPM_E_PCP_KEY_NOT_AIK _HRESULT_TYPEDEF_(0x80290419L)")]
    public const int TPM_E_PCP_KEY_NOT_AIK = unchecked((int)(0x80290419));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_KEY_NOT_SIGNING_KEY"]/*' />
    [NativeTypeName("#define TPM_E_KEY_NOT_SIGNING_KEY _HRESULT_TYPEDEF_(0x8029041AL)")]
    public const int TPM_E_KEY_NOT_SIGNING_KEY = unchecked((int)(0x8029041A));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_LOCKED_OUT"]/*' />
    [NativeTypeName("#define TPM_E_LOCKED_OUT _HRESULT_TYPEDEF_(0x8029041BL)")]
    public const int TPM_E_LOCKED_OUT = unchecked((int)(0x8029041B));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_CLAIM_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_CLAIM_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8029041CL)")]
    public const int TPM_E_CLAIM_TYPE_NOT_SUPPORTED = unchecked((int)(0x8029041C));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_VERSION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8029041DL)")]
    public const int TPM_E_VERSION_NOT_SUPPORTED = unchecked((int)(0x8029041D));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_BUFFER_LENGTH_MISMATCH"]/*' />
    [NativeTypeName("#define TPM_E_BUFFER_LENGTH_MISMATCH _HRESULT_TYPEDEF_(0x8029041EL)")]
    public const int TPM_E_BUFFER_LENGTH_MISMATCH = unchecked((int)(0x8029041E));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_IFX_RSA_KEY_CREATION_BLOCKED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_IFX_RSA_KEY_CREATION_BLOCKED _HRESULT_TYPEDEF_(0x8029041FL)")]
    public const int TPM_E_PCP_IFX_RSA_KEY_CREATION_BLOCKED = unchecked((int)(0x8029041F));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_TICKET_MISSING"]/*' />
    [NativeTypeName("#define TPM_E_PCP_TICKET_MISSING _HRESULT_TYPEDEF_(0x80290420L)")]
    public const int TPM_E_PCP_TICKET_MISSING = unchecked((int)(0x80290420));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_RAW_POLICY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_RAW_POLICY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290421L)")]
    public const int TPM_E_PCP_RAW_POLICY_NOT_SUPPORTED = unchecked((int)(0x80290421));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_KEY_HANDLE_INVALIDATED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_KEY_HANDLE_INVALIDATED _HRESULT_TYPEDEF_(0x80290422L)")]
    public const int TPM_E_PCP_KEY_HANDLE_INVALIDATED = unchecked((int)(0x80290422));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_UNSUPPORTED_PSS_SALT"]/*' />
    [NativeTypeName("#define TPM_E_PCP_UNSUPPORTED_PSS_SALT _HRESULT_TYPEDEF_(0x40290423L)")]
    public const int TPM_E_PCP_UNSUPPORTED_PSS_SALT = ((int)(0x40290423));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_PLATFORM_CLAIM_MAY_BE_OUTDATED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_PLATFORM_CLAIM_MAY_BE_OUTDATED _HRESULT_TYPEDEF_(0x40290424L)")]
    public const int TPM_E_PCP_PLATFORM_CLAIM_MAY_BE_OUTDATED = ((int)(0x40290424));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_PLATFORM_CLAIM_OUTDATED"]/*' />
    [NativeTypeName("#define TPM_E_PCP_PLATFORM_CLAIM_OUTDATED _HRESULT_TYPEDEF_(0x40290425L)")]
    public const int TPM_E_PCP_PLATFORM_CLAIM_OUTDATED = ((int)(0x40290425));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PCP_PLATFORM_CLAIM_REBOOT"]/*' />
    [NativeTypeName("#define TPM_E_PCP_PLATFORM_CLAIM_REBOOT _HRESULT_TYPEDEF_(0x40290426L)")]
    public const int TPM_E_PCP_PLATFORM_CLAIM_REBOOT = ((int)(0x40290426));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_ZERO_EXHAUST_ENABLED"]/*' />
    [NativeTypeName("#define TPM_E_ZERO_EXHAUST_ENABLED _HRESULT_TYPEDEF_(0x80290500L)")]
    public const int TPM_E_ZERO_EXHAUST_ENABLED = unchecked((int)(0x80290500));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_PROVISIONING_INCOMPLETE"]/*' />
    [NativeTypeName("#define TPM_E_PROVISIONING_INCOMPLETE _HRESULT_TYPEDEF_(0x80290600L)")]
    public const int TPM_E_PROVISIONING_INCOMPLETE = unchecked((int)(0x80290600));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_INVALID_OWNER_AUTH"]/*' />
    [NativeTypeName("#define TPM_E_INVALID_OWNER_AUTH _HRESULT_TYPEDEF_(0x80290601L)")]
    public const int TPM_E_INVALID_OWNER_AUTH = unchecked((int)(0x80290601));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_TOO_MUCH_DATA"]/*' />
    [NativeTypeName("#define TPM_E_TOO_MUCH_DATA _HRESULT_TYPEDEF_(0x80290602L)")]
    public const int TPM_E_TOO_MUCH_DATA = unchecked((int)(0x80290602));

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_E_TPM_GENERATED_EPS"]/*' />
    [NativeTypeName("#define TPM_E_TPM_GENERATED_EPS _HRESULT_TYPEDEF_(0x80290603L)")]
    public const int TPM_E_TPM_GENERATED_EPS = unchecked((int)(0x80290603));
}
