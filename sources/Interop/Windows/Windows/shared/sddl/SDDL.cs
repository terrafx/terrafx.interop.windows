// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/sddl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SDDL
{
    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_REVISION_1"]/*' />
    [NativeTypeName("#define SDDL_REVISION_1 1")]
    public const int SDDL_REVISION_1 = 1;

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_REVISION"]/*' />
    [NativeTypeName("#define SDDL_REVISION SDDL_REVISION_1")]
    public const int SDDL_REVISION = 1;

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OWNER"]/*' />
    [NativeTypeName("#define SDDL_OWNER TEXT(\"O\")")]
    public const string SDDL_OWNER = "O";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GROUP"]/*' />
    [NativeTypeName("#define SDDL_GROUP TEXT(\"G\")")]
    public const string SDDL_GROUP = "G";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DACL"]/*' />
    [NativeTypeName("#define SDDL_DACL TEXT(\"D\")")]
    public const string SDDL_DACL = "D";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SACL"]/*' />
    [NativeTypeName("#define SDDL_SACL TEXT(\"S\")")]
    public const string SDDL_SACL = "S";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PROTECTED"]/*' />
    [NativeTypeName("#define SDDL_PROTECTED TEXT(\"P\")")]
    public const string SDDL_PROTECTED = "P";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUTO_INHERIT_REQ"]/*' />
    [NativeTypeName("#define SDDL_AUTO_INHERIT_REQ TEXT(\"AR\")")]
    public const string SDDL_AUTO_INHERIT_REQ = "AR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUTO_INHERITED"]/*' />
    [NativeTypeName("#define SDDL_AUTO_INHERITED TEXT(\"AI\")")]
    public const string SDDL_AUTO_INHERITED = "AI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NULL_ACL"]/*' />
    [NativeTypeName("#define SDDL_NULL_ACL TEXT(\"NO_ACCESS_CONTROL\")")]
    public const string SDDL_NULL_ACL = "NO_ACCESS_CONTROL";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACCESS_ALLOWED"]/*' />
    [NativeTypeName("#define SDDL_ACCESS_ALLOWED TEXT(\"A\")")]
    public const string SDDL_ACCESS_ALLOWED = "A";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define SDDL_ACCESS_DENIED TEXT(\"D\")")]
    public const string SDDL_ACCESS_DENIED = "D";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OBJECT_ACCESS_ALLOWED"]/*' />
    [NativeTypeName("#define SDDL_OBJECT_ACCESS_ALLOWED TEXT(\"OA\")")]
    public const string SDDL_OBJECT_ACCESS_ALLOWED = "OA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OBJECT_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define SDDL_OBJECT_ACCESS_DENIED TEXT(\"OD\")")]
    public const string SDDL_OBJECT_ACCESS_DENIED = "OD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUDIT"]/*' />
    [NativeTypeName("#define SDDL_AUDIT TEXT(\"AU\")")]
    public const string SDDL_AUDIT = "AU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ALARM"]/*' />
    [NativeTypeName("#define SDDL_ALARM TEXT(\"AL\")")]
    public const string SDDL_ALARM = "AL";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OBJECT_AUDIT"]/*' />
    [NativeTypeName("#define SDDL_OBJECT_AUDIT TEXT(\"OU\")")]
    public const string SDDL_OBJECT_AUDIT = "OU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OBJECT_ALARM"]/*' />
    [NativeTypeName("#define SDDL_OBJECT_ALARM TEXT(\"OL\")")]
    public const string SDDL_OBJECT_ALARM = "OL";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_MANDATORY_LABEL"]/*' />
    [NativeTypeName("#define SDDL_MANDATORY_LABEL TEXT(\"ML\")")]
    public const string SDDL_MANDATORY_LABEL = "ML";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PROCESS_TRUST_LABEL"]/*' />
    [NativeTypeName("#define SDDL_PROCESS_TRUST_LABEL TEXT(\"TL\")")]
    public const string SDDL_PROCESS_TRUST_LABEL = "TL";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CALLBACK_ACCESS_ALLOWED"]/*' />
    [NativeTypeName("#define SDDL_CALLBACK_ACCESS_ALLOWED TEXT(\"XA\")")]
    public const string SDDL_CALLBACK_ACCESS_ALLOWED = "XA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CALLBACK_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define SDDL_CALLBACK_ACCESS_DENIED TEXT(\"XD\")")]
    public const string SDDL_CALLBACK_ACCESS_DENIED = "XD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RESOURCE_ATTRIBUTE"]/*' />
    [NativeTypeName("#define SDDL_RESOURCE_ATTRIBUTE TEXT(\"RA\")")]
    public const string SDDL_RESOURCE_ATTRIBUTE = "RA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SCOPED_POLICY_ID"]/*' />
    [NativeTypeName("#define SDDL_SCOPED_POLICY_ID TEXT(\"SP\")")]
    public const string SDDL_SCOPED_POLICY_ID = "SP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CALLBACK_AUDIT"]/*' />
    [NativeTypeName("#define SDDL_CALLBACK_AUDIT TEXT(\"XU\")")]
    public const string SDDL_CALLBACK_AUDIT = "XU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CALLBACK_OBJECT_ACCESS_ALLOWED"]/*' />
    [NativeTypeName("#define SDDL_CALLBACK_OBJECT_ACCESS_ALLOWED TEXT(\"ZA\")")]
    public const string SDDL_CALLBACK_OBJECT_ACCESS_ALLOWED = "ZA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACCESS_FILTER"]/*' />
    [NativeTypeName("#define SDDL_ACCESS_FILTER TEXT(\"FL\")")]
    public const string SDDL_ACCESS_FILTER = "FL";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_INT"]/*' />
    [NativeTypeName("#define SDDL_INT TEXT(\"TI\")")]
    public const string SDDL_INT = "TI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_UINT"]/*' />
    [NativeTypeName("#define SDDL_UINT TEXT(\"TU\")")]
    public const string SDDL_UINT = "TU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_WSTRING"]/*' />
    [NativeTypeName("#define SDDL_WSTRING TEXT(\"TS\")")]
    public const string SDDL_WSTRING = "TS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SID"]/*' />
    [NativeTypeName("#define SDDL_SID TEXT(\"TD\")")]
    public const string SDDL_SID = "TD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BLOB"]/*' />
    [NativeTypeName("#define SDDL_BLOB TEXT(\"TX\")")]
    public const string SDDL_BLOB = "TX";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BOOLEAN"]/*' />
    [NativeTypeName("#define SDDL_BOOLEAN TEXT(\"TB\")")]
    public const string SDDL_BOOLEAN = "TB";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CONTAINER_INHERIT"]/*' />
    [NativeTypeName("#define SDDL_CONTAINER_INHERIT TEXT(\"CI\")")]
    public const string SDDL_CONTAINER_INHERIT = "CI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OBJECT_INHERIT"]/*' />
    [NativeTypeName("#define SDDL_OBJECT_INHERIT TEXT(\"OI\")")]
    public const string SDDL_OBJECT_INHERIT = "OI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NO_PROPAGATE"]/*' />
    [NativeTypeName("#define SDDL_NO_PROPAGATE TEXT(\"NP\")")]
    public const string SDDL_NO_PROPAGATE = "NP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_INHERIT_ONLY"]/*' />
    [NativeTypeName("#define SDDL_INHERIT_ONLY TEXT(\"IO\")")]
    public const string SDDL_INHERIT_ONLY = "IO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_INHERITED"]/*' />
    [NativeTypeName("#define SDDL_INHERITED TEXT(\"ID\")")]
    public const string SDDL_INHERITED = "ID";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CRITICAL"]/*' />
    [NativeTypeName("#define SDDL_CRITICAL TEXT(\"CR\")")]
    public const string SDDL_CRITICAL = "CR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_TRUST_PROTECTED_FILTER"]/*' />
    [NativeTypeName("#define SDDL_TRUST_PROTECTED_FILTER TEXT(\"TP\")")]
    public const string SDDL_TRUST_PROTECTED_FILTER = "TP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUDIT_SUCCESS"]/*' />
    [NativeTypeName("#define SDDL_AUDIT_SUCCESS TEXT(\"SA\")")]
    public const string SDDL_AUDIT_SUCCESS = "SA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUDIT_FAILURE"]/*' />
    [NativeTypeName("#define SDDL_AUDIT_FAILURE TEXT(\"FA\")")]
    public const string SDDL_AUDIT_FAILURE = "FA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_READ_PROPERTY"]/*' />
    [NativeTypeName("#define SDDL_READ_PROPERTY TEXT(\"RP\")")]
    public const string SDDL_READ_PROPERTY = "RP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_WRITE_PROPERTY"]/*' />
    [NativeTypeName("#define SDDL_WRITE_PROPERTY TEXT(\"WP\")")]
    public const string SDDL_WRITE_PROPERTY = "WP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CREATE_CHILD"]/*' />
    [NativeTypeName("#define SDDL_CREATE_CHILD TEXT(\"CC\")")]
    public const string SDDL_CREATE_CHILD = "CC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DELETE_CHILD"]/*' />
    [NativeTypeName("#define SDDL_DELETE_CHILD TEXT(\"DC\")")]
    public const string SDDL_DELETE_CHILD = "DC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LIST_CHILDREN"]/*' />
    [NativeTypeName("#define SDDL_LIST_CHILDREN TEXT(\"LC\")")]
    public const string SDDL_LIST_CHILDREN = "LC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SELF_WRITE"]/*' />
    [NativeTypeName("#define SDDL_SELF_WRITE TEXT(\"SW\")")]
    public const string SDDL_SELF_WRITE = "SW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LIST_OBJECT"]/*' />
    [NativeTypeName("#define SDDL_LIST_OBJECT TEXT(\"LO\")")]
    public const string SDDL_LIST_OBJECT = "LO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DELETE_TREE"]/*' />
    [NativeTypeName("#define SDDL_DELETE_TREE TEXT(\"DT\")")]
    public const string SDDL_DELETE_TREE = "DT";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CONTROL_ACCESS"]/*' />
    [NativeTypeName("#define SDDL_CONTROL_ACCESS TEXT(\"CR\")")]
    public const string SDDL_CONTROL_ACCESS = "CR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_READ_CONTROL"]/*' />
    [NativeTypeName("#define SDDL_READ_CONTROL TEXT(\"RC\")")]
    public const string SDDL_READ_CONTROL = "RC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_WRITE_DAC"]/*' />
    [NativeTypeName("#define SDDL_WRITE_DAC TEXT(\"WD\")")]
    public const string SDDL_WRITE_DAC = "WD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_WRITE_OWNER"]/*' />
    [NativeTypeName("#define SDDL_WRITE_OWNER TEXT(\"WO\")")]
    public const string SDDL_WRITE_OWNER = "WO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_STANDARD_DELETE"]/*' />
    [NativeTypeName("#define SDDL_STANDARD_DELETE TEXT(\"SD\")")]
    public const string SDDL_STANDARD_DELETE = "SD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GENERIC_ALL"]/*' />
    [NativeTypeName("#define SDDL_GENERIC_ALL TEXT(\"GA\")")]
    public const string SDDL_GENERIC_ALL = "GA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GENERIC_READ"]/*' />
    [NativeTypeName("#define SDDL_GENERIC_READ TEXT(\"GR\")")]
    public const string SDDL_GENERIC_READ = "GR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GENERIC_WRITE"]/*' />
    [NativeTypeName("#define SDDL_GENERIC_WRITE TEXT(\"GW\")")]
    public const string SDDL_GENERIC_WRITE = "GW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GENERIC_EXECUTE"]/*' />
    [NativeTypeName("#define SDDL_GENERIC_EXECUTE TEXT(\"GX\")")]
    public const string SDDL_GENERIC_EXECUTE = "GX";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_FILE_ALL"]/*' />
    [NativeTypeName("#define SDDL_FILE_ALL TEXT(\"FA\")")]
    public const string SDDL_FILE_ALL = "FA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_FILE_READ"]/*' />
    [NativeTypeName("#define SDDL_FILE_READ TEXT(\"FR\")")]
    public const string SDDL_FILE_READ = "FR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_FILE_WRITE"]/*' />
    [NativeTypeName("#define SDDL_FILE_WRITE TEXT(\"FW\")")]
    public const string SDDL_FILE_WRITE = "FW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_FILE_EXECUTE"]/*' />
    [NativeTypeName("#define SDDL_FILE_EXECUTE TEXT(\"FX\")")]
    public const string SDDL_FILE_EXECUTE = "FX";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_KEY_ALL"]/*' />
    [NativeTypeName("#define SDDL_KEY_ALL TEXT(\"KA\")")]
    public const string SDDL_KEY_ALL = "KA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_KEY_READ"]/*' />
    [NativeTypeName("#define SDDL_KEY_READ TEXT(\"KR\")")]
    public const string SDDL_KEY_READ = "KR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_KEY_WRITE"]/*' />
    [NativeTypeName("#define SDDL_KEY_WRITE TEXT(\"KW\")")]
    public const string SDDL_KEY_WRITE = "KW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_KEY_EXECUTE"]/*' />
    [NativeTypeName("#define SDDL_KEY_EXECUTE TEXT(\"KX\")")]
    public const string SDDL_KEY_EXECUTE = "KX";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NO_WRITE_UP"]/*' />
    [NativeTypeName("#define SDDL_NO_WRITE_UP TEXT(\"NW\")")]
    public const string SDDL_NO_WRITE_UP = "NW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NO_READ_UP"]/*' />
    [NativeTypeName("#define SDDL_NO_READ_UP TEXT(\"NR\")")]
    public const string SDDL_NO_READ_UP = "NR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NO_EXECUTE_UP"]/*' />
    [NativeTypeName("#define SDDL_NO_EXECUTE_UP TEXT(\"NX\")")]
    public const string SDDL_NO_EXECUTE_UP = "NX";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ALIAS_SIZE"]/*' />
    [NativeTypeName("#define SDDL_ALIAS_SIZE 2")]
    public const int SDDL_ALIAS_SIZE = 2;

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DOMAIN_ADMINISTRATORS"]/*' />
    [NativeTypeName("#define SDDL_DOMAIN_ADMINISTRATORS TEXT(\"DA\")")]
    public const string SDDL_DOMAIN_ADMINISTRATORS = "DA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DOMAIN_GUESTS"]/*' />
    [NativeTypeName("#define SDDL_DOMAIN_GUESTS TEXT(\"DG\")")]
    public const string SDDL_DOMAIN_GUESTS = "DG";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DOMAIN_USERS"]/*' />
    [NativeTypeName("#define SDDL_DOMAIN_USERS TEXT(\"DU\")")]
    public const string SDDL_DOMAIN_USERS = "DU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ENTERPRISE_DOMAIN_CONTROLLERS"]/*' />
    [NativeTypeName("#define SDDL_ENTERPRISE_DOMAIN_CONTROLLERS TEXT(\"ED\")")]
    public const string SDDL_ENTERPRISE_DOMAIN_CONTROLLERS = "ED";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DOMAIN_DOMAIN_CONTROLLERS"]/*' />
    [NativeTypeName("#define SDDL_DOMAIN_DOMAIN_CONTROLLERS TEXT(\"DD\")")]
    public const string SDDL_DOMAIN_DOMAIN_CONTROLLERS = "DD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DOMAIN_COMPUTERS"]/*' />
    [NativeTypeName("#define SDDL_DOMAIN_COMPUTERS TEXT(\"DC\")")]
    public const string SDDL_DOMAIN_COMPUTERS = "DC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BUILTIN_ADMINISTRATORS"]/*' />
    [NativeTypeName("#define SDDL_BUILTIN_ADMINISTRATORS TEXT(\"BA\")")]
    public const string SDDL_BUILTIN_ADMINISTRATORS = "BA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BUILTIN_GUESTS"]/*' />
    [NativeTypeName("#define SDDL_BUILTIN_GUESTS TEXT(\"BG\")")]
    public const string SDDL_BUILTIN_GUESTS = "BG";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BUILTIN_USERS"]/*' />
    [NativeTypeName("#define SDDL_BUILTIN_USERS TEXT(\"BU\")")]
    public const string SDDL_BUILTIN_USERS = "BU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LOCAL_ADMIN"]/*' />
    [NativeTypeName("#define SDDL_LOCAL_ADMIN TEXT(\"LA\")")]
    public const string SDDL_LOCAL_ADMIN = "LA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LOCAL_GUEST"]/*' />
    [NativeTypeName("#define SDDL_LOCAL_GUEST TEXT(\"LG\")")]
    public const string SDDL_LOCAL_GUEST = "LG";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACCOUNT_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_ACCOUNT_OPERATORS TEXT(\"AO\")")]
    public const string SDDL_ACCOUNT_OPERATORS = "AO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_BACKUP_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_BACKUP_OPERATORS TEXT(\"BO\")")]
    public const string SDDL_BACKUP_OPERATORS = "BO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PRINTER_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_PRINTER_OPERATORS TEXT(\"PO\")")]
    public const string SDDL_PRINTER_OPERATORS = "PO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SERVER_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_SERVER_OPERATORS TEXT(\"SO\")")]
    public const string SDDL_SERVER_OPERATORS = "SO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUTHENTICATED_USERS"]/*' />
    [NativeTypeName("#define SDDL_AUTHENTICATED_USERS TEXT(\"AU\")")]
    public const string SDDL_AUTHENTICATED_USERS = "AU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PERSONAL_SELF"]/*' />
    [NativeTypeName("#define SDDL_PERSONAL_SELF TEXT(\"PS\")")]
    public const string SDDL_PERSONAL_SELF = "PS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CREATOR_OWNER"]/*' />
    [NativeTypeName("#define SDDL_CREATOR_OWNER TEXT(\"CO\")")]
    public const string SDDL_CREATOR_OWNER = "CO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CREATOR_GROUP"]/*' />
    [NativeTypeName("#define SDDL_CREATOR_GROUP TEXT(\"CG\")")]
    public const string SDDL_CREATOR_GROUP = "CG";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LOCAL_SYSTEM"]/*' />
    [NativeTypeName("#define SDDL_LOCAL_SYSTEM TEXT(\"SY\")")]
    public const string SDDL_LOCAL_SYSTEM = "SY";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_POWER_USERS"]/*' />
    [NativeTypeName("#define SDDL_POWER_USERS TEXT(\"PU\")")]
    public const string SDDL_POWER_USERS = "PU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_EVERYONE"]/*' />
    [NativeTypeName("#define SDDL_EVERYONE TEXT(\"WD\")")]
    public const string SDDL_EVERYONE = "WD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_REPLICATOR"]/*' />
    [NativeTypeName("#define SDDL_REPLICATOR TEXT(\"RE\")")]
    public const string SDDL_REPLICATOR = "RE";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_INTERACTIVE"]/*' />
    [NativeTypeName("#define SDDL_INTERACTIVE TEXT(\"IU\")")]
    public const string SDDL_INTERACTIVE = "IU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NETWORK"]/*' />
    [NativeTypeName("#define SDDL_NETWORK TEXT(\"NU\")")]
    public const string SDDL_NETWORK = "NU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SERVICE"]/*' />
    [NativeTypeName("#define SDDL_SERVICE TEXT(\"SU\")")]
    public const string SDDL_SERVICE = "SU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RESTRICTED_CODE"]/*' />
    [NativeTypeName("#define SDDL_RESTRICTED_CODE TEXT(\"RC\")")]
    public const string SDDL_RESTRICTED_CODE = "RC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_WRITE_RESTRICTED_CODE"]/*' />
    [NativeTypeName("#define SDDL_WRITE_RESTRICTED_CODE TEXT(\"WR\")")]
    public const string SDDL_WRITE_RESTRICTED_CODE = "WR";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ANONYMOUS"]/*' />
    [NativeTypeName("#define SDDL_ANONYMOUS TEXT(\"AN\")")]
    public const string SDDL_ANONYMOUS = "AN";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SCHEMA_ADMINISTRATORS"]/*' />
    [NativeTypeName("#define SDDL_SCHEMA_ADMINISTRATORS TEXT(\"SA\")")]
    public const string SDDL_SCHEMA_ADMINISTRATORS = "SA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CERT_SERV_ADMINISTRATORS"]/*' />
    [NativeTypeName("#define SDDL_CERT_SERV_ADMINISTRATORS TEXT(\"CA\")")]
    public const string SDDL_CERT_SERV_ADMINISTRATORS = "CA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RAS_SERVERS"]/*' />
    [NativeTypeName("#define SDDL_RAS_SERVERS TEXT(\"RS\")")]
    public const string SDDL_RAS_SERVERS = "RS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ENTERPRISE_ADMINS"]/*' />
    [NativeTypeName("#define SDDL_ENTERPRISE_ADMINS TEXT(\"EA\")")]
    public const string SDDL_ENTERPRISE_ADMINS = "EA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_GROUP_POLICY_ADMINS"]/*' />
    [NativeTypeName("#define SDDL_GROUP_POLICY_ADMINS TEXT(\"PA\")")]
    public const string SDDL_GROUP_POLICY_ADMINS = "PA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ALIAS_PREW2KCOMPACC"]/*' />
    [NativeTypeName("#define SDDL_ALIAS_PREW2KCOMPACC TEXT(\"RU\")")]
    public const string SDDL_ALIAS_PREW2KCOMPACC = "RU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_LOCAL_SERVICE"]/*' />
    [NativeTypeName("#define SDDL_LOCAL_SERVICE TEXT(\"LS\")")]
    public const string SDDL_LOCAL_SERVICE = "LS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NETWORK_SERVICE"]/*' />
    [NativeTypeName("#define SDDL_NETWORK_SERVICE TEXT(\"NS\")")]
    public const string SDDL_NETWORK_SERVICE = "NS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_REMOTE_DESKTOP"]/*' />
    [NativeTypeName("#define SDDL_REMOTE_DESKTOP TEXT(\"RD\")")]
    public const string SDDL_REMOTE_DESKTOP = "RD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_NETWORK_CONFIGURATION_OPS"]/*' />
    [NativeTypeName("#define SDDL_NETWORK_CONFIGURATION_OPS TEXT(\"NO\")")]
    public const string SDDL_NETWORK_CONFIGURATION_OPS = "NO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PERFMON_USERS"]/*' />
    [NativeTypeName("#define SDDL_PERFMON_USERS TEXT(\"MU\")")]
    public const string SDDL_PERFMON_USERS = "MU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PERFLOG_USERS"]/*' />
    [NativeTypeName("#define SDDL_PERFLOG_USERS TEXT(\"LU\")")]
    public const string SDDL_PERFLOG_USERS = "LU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_IIS_USERS"]/*' />
    [NativeTypeName("#define SDDL_IIS_USERS TEXT(\"IS\")")]
    public const string SDDL_IIS_USERS = "IS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CRYPTO_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_CRYPTO_OPERATORS TEXT(\"CY\")")]
    public const string SDDL_CRYPTO_OPERATORS = "CY";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OWNER_RIGHTS"]/*' />
    [NativeTypeName("#define SDDL_OWNER_RIGHTS TEXT(\"OW\")")]
    public const string SDDL_OWNER_RIGHTS = "OW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_EVENT_LOG_READERS"]/*' />
    [NativeTypeName("#define SDDL_EVENT_LOG_READERS TEXT(\"ER\")")]
    public const string SDDL_EVENT_LOG_READERS = "ER";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ENTERPRISE_RO_DCs"]/*' />
    [NativeTypeName("#define SDDL_ENTERPRISE_RO_DCs TEXT(\"RO\")")]
    public const string SDDL_ENTERPRISE_RO_DCs = "RO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CERTSVC_DCOM_ACCESS"]/*' />
    [NativeTypeName("#define SDDL_CERTSVC_DCOM_ACCESS TEXT(\"CD\")")]
    public const string SDDL_CERTSVC_DCOM_ACCESS = "CD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ALL_APP_PACKAGES"]/*' />
    [NativeTypeName("#define SDDL_ALL_APP_PACKAGES TEXT(\"AC\")")]
    public const string SDDL_ALL_APP_PACKAGES = "AC";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RDS_REMOTE_ACCESS_SERVERS"]/*' />
    [NativeTypeName("#define SDDL_RDS_REMOTE_ACCESS_SERVERS TEXT(\"RA\")")]
    public const string SDDL_RDS_REMOTE_ACCESS_SERVERS = "RA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RDS_ENDPOINT_SERVERS"]/*' />
    [NativeTypeName("#define SDDL_RDS_ENDPOINT_SERVERS TEXT(\"ES\")")]
    public const string SDDL_RDS_ENDPOINT_SERVERS = "ES";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_RDS_MANAGEMENT_SERVERS"]/*' />
    [NativeTypeName("#define SDDL_RDS_MANAGEMENT_SERVERS TEXT(\"MS\")")]
    public const string SDDL_RDS_MANAGEMENT_SERVERS = "MS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_USER_MODE_DRIVERS"]/*' />
    [NativeTypeName("#define SDDL_USER_MODE_DRIVERS TEXT(\"UD\")")]
    public const string SDDL_USER_MODE_DRIVERS = "UD";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_HYPER_V_ADMINS"]/*' />
    [NativeTypeName("#define SDDL_HYPER_V_ADMINS TEXT(\"HA\")")]
    public const string SDDL_HYPER_V_ADMINS = "HA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CLONEABLE_CONTROLLERS"]/*' />
    [NativeTypeName("#define SDDL_CLONEABLE_CONTROLLERS TEXT(\"CN\")")]
    public const string SDDL_CLONEABLE_CONTROLLERS = "CN";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACCESS_CONTROL_ASSISTANCE_OPS"]/*' />
    [NativeTypeName("#define SDDL_ACCESS_CONTROL_ASSISTANCE_OPS TEXT(\"AA\")")]
    public const string SDDL_ACCESS_CONTROL_ASSISTANCE_OPS = "AA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_REMOTE_MANAGEMENT_USERS"]/*' />
    [NativeTypeName("#define SDDL_REMOTE_MANAGEMENT_USERS TEXT(\"RM\")")]
    public const string SDDL_REMOTE_MANAGEMENT_USERS = "RM";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_AUTHORITY_ASSERTED"]/*' />
    [NativeTypeName("#define SDDL_AUTHORITY_ASSERTED TEXT(\"AS\")")]
    public const string SDDL_AUTHORITY_ASSERTED = "AS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SERVICE_ASSERTED"]/*' />
    [NativeTypeName("#define SDDL_SERVICE_ASSERTED TEXT(\"SS\")")]
    public const string SDDL_SERVICE_ASSERTED = "SS";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_PROTECTED_USERS"]/*' />
    [NativeTypeName("#define SDDL_PROTECTED_USERS TEXT(\"AP\")")]
    public const string SDDL_PROTECTED_USERS = "AP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_KEY_ADMINS"]/*' />
    [NativeTypeName("#define SDDL_KEY_ADMINS TEXT(\"KA\")")]
    public const string SDDL_KEY_ADMINS = "KA";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ENTERPRISE_KEY_ADMINS"]/*' />
    [NativeTypeName("#define SDDL_ENTERPRISE_KEY_ADMINS TEXT(\"EK\")")]
    public const string SDDL_ENTERPRISE_KEY_ADMINS = "EK";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_USER_MODE_HARDWARE_OPERATORS"]/*' />
    [NativeTypeName("#define SDDL_USER_MODE_HARDWARE_OPERATORS TEXT(\"HO\")")]
    public const string SDDL_USER_MODE_HARDWARE_OPERATORS = "HO";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_OPENSSH_USERS"]/*' />
    [NativeTypeName("#define SDDL_OPENSSH_USERS TEXT(\"SH\")")]
    public const string SDDL_OPENSSH_USERS = "SH";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_CUA_USERS"]/*' />
    [NativeTypeName("#define SDDL_CUA_USERS TEXT(\"CU\")")]
    public const string SDDL_CUA_USERS = "CU";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ML_LOW"]/*' />
    [NativeTypeName("#define SDDL_ML_LOW TEXT(\"LW\")")]
    public const string SDDL_ML_LOW = "LW";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ML_MEDIUM"]/*' />
    [NativeTypeName("#define SDDL_ML_MEDIUM TEXT(\"ME\")")]
    public const string SDDL_ML_MEDIUM = "ME";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ML_MEDIUM_PLUS"]/*' />
    [NativeTypeName("#define SDDL_ML_MEDIUM_PLUS TEXT(\"MP\")")]
    public const string SDDL_ML_MEDIUM_PLUS = "MP";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ML_HIGH"]/*' />
    [NativeTypeName("#define SDDL_ML_HIGH TEXT(\"HI\")")]
    public const string SDDL_ML_HIGH = "HI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ML_SYSTEM"]/*' />
    [NativeTypeName("#define SDDL_ML_SYSTEM TEXT(\"SI\")")]
    public const string SDDL_ML_SYSTEM = "SI";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SEPERATORC"]/*' />
    [NativeTypeName("#define SDDL_SEPERATORC TEXT(';')")]
    public const char SDDL_SEPERATORC = ';';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DELIMINATORC"]/*' />
    [NativeTypeName("#define SDDL_DELIMINATORC TEXT(':')")]
    public const char SDDL_DELIMINATORC = ':';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_BEGINC"]/*' />
    [NativeTypeName("#define SDDL_ACE_BEGINC TEXT('(')")]
    public const char SDDL_ACE_BEGINC = '(';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_ENDC"]/*' />
    [NativeTypeName("#define SDDL_ACE_ENDC TEXT(')')")]
    public const char SDDL_ACE_ENDC = ')';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SPACEC"]/*' />
    [NativeTypeName("#define SDDL_SPACEC TEXT(' ')")]
    public const char SDDL_SPACEC = ' ';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_BEGINC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_BEGINC TEXT('(')")]
    public const char SDDL_ACE_COND_BEGINC = '(';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_ENDC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_ENDC TEXT(')')")]
    public const char SDDL_ACE_COND_ENDC = ')';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_STRING_BEGINC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_STRING_BEGINC TEXT('\"')")]
    public const char SDDL_ACE_COND_STRING_BEGINC = '"';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_STRING_ENDC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_STRING_ENDC TEXT('\"')")]
    public const char SDDL_ACE_COND_STRING_ENDC = '"';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_COMPOSITEVALUE_BEGINC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_BEGINC TEXT('{')")]
    public const char SDDL_ACE_COND_COMPOSITEVALUE_BEGINC = '{';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_COMPOSITEVALUE_ENDC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_ENDC TEXT('}')")]
    public const char SDDL_ACE_COND_COMPOSITEVALUE_ENDC = '}';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_COMPOSITEVALUE_SEPERATORC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_SEPERATORC TEXT(',')")]
    public const char SDDL_ACE_COND_COMPOSITEVALUE_SEPERATORC = ',';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_BLOB_PREFIXC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_BLOB_PREFIXC TEXT('#')")]
    public const char SDDL_ACE_COND_BLOB_PREFIXC = '#';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_SID_BEGINC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_SID_BEGINC TEXT('(')")]
    public const char SDDL_ACE_COND_SID_BEGINC = '(';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_SID_ENDC"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_SID_ENDC TEXT(')')")]
    public const char SDDL_ACE_COND_SID_ENDC = ')';

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SEPERATOR"]/*' />
    [NativeTypeName("#define SDDL_SEPERATOR TEXT(\";\")")]
    public const string SDDL_SEPERATOR = ";";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_DELIMINATOR"]/*' />
    [NativeTypeName("#define SDDL_DELIMINATOR TEXT(\":\")")]
    public const string SDDL_DELIMINATOR = ":";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_BEGIN"]/*' />
    [NativeTypeName("#define SDDL_ACE_BEGIN TEXT(\"(\")")]
    public const string SDDL_ACE_BEGIN = "(";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_END"]/*' />
    [NativeTypeName("#define SDDL_ACE_END TEXT(\")\")")]
    public const string SDDL_ACE_END = ")";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_BEGIN"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_BEGIN TEXT(\"(\")")]
    public const string SDDL_ACE_COND_BEGIN = "(";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_END"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_END TEXT(\")\")")]
    public const string SDDL_ACE_COND_END = ")";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_SPACE"]/*' />
    [NativeTypeName("#define SDDL_SPACE TEXT(\" \")")]
    public const string SDDL_SPACE = " ";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_BLOB_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_BLOB_PREFIX TEXT(\"#\")")]
    public const string SDDL_ACE_COND_BLOB_PREFIX = "#";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_SID_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_SID_PREFIX TEXT(\"SID\")")]
    public const string SDDL_ACE_COND_SID_PREFIX = "SID";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_ATTRIBUTE_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_ATTRIBUTE_PREFIX TEXT(\"@\")")]
    public const string SDDL_ACE_COND_ATTRIBUTE_PREFIX = "@";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_USER_ATTRIBUTE_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_USER_ATTRIBUTE_PREFIX TEXT(\"@USER.\")")]
    public const string SDDL_ACE_COND_USER_ATTRIBUTE_PREFIX = "@USER.";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_RESOURCE_ATTRIBUTE_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_RESOURCE_ATTRIBUTE_PREFIX TEXT(\"@RESOURCE.\")")]
    public const string SDDL_ACE_COND_RESOURCE_ATTRIBUTE_PREFIX = "@RESOURCE.";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_DEVICE_ATTRIBUTE_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_DEVICE_ATTRIBUTE_PREFIX TEXT(\"@DEVICE.\")")]
    public const string SDDL_ACE_COND_DEVICE_ATTRIBUTE_PREFIX = "@DEVICE.";

    /// <include file='SDDL.xml' path='doc/member[@name="SDDL.SDDL_ACE_COND_TOKEN_ATTRIBUTE_PREFIX"]/*' />
    [NativeTypeName("#define SDDL_ACE_COND_TOKEN_ATTRIBUTE_PREFIX TEXT(\"@TOKEN.\")")]
    public const string SDDL_ACE_COND_TOKEN_ATTRIBUTE_PREFIX = "@TOKEN.";
}
