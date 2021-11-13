// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        public static HRESULT HRESULT_FROM_WIN32([NativeTypeName("unsigned long")] uint x)
        {
            return (HRESULT)(x) <= 0 ? (HRESULT)(x) : (HRESULT)(((x) & 0x0000FFFF) | (7 << 16) | 0x80000000);
        }

        [NativeTypeName("#define NO_ERROR 0L")]
        public const int NO_ERROR = 0;

        [NativeTypeName("#define SEC_E_OK ((HRESULT)0x00000000L)")]
        public const int SEC_E_OK = ((int)(0x00000000));

        [NativeTypeName("#define WAIT_TIMEOUT 258L")]
        public const int WAIT_TIMEOUT = 258;

        [NativeTypeName("#define EPT_S_INVALID_ENTRY 1751L")]
        public const int EPT_S_INVALID_ENTRY = 1751;

        [NativeTypeName("#define EPT_S_CANT_PERFORM_OP 1752L")]
        public const int EPT_S_CANT_PERFORM_OP = 1752;

        [NativeTypeName("#define EPT_S_NOT_REGISTERED 1753L")]
        public const int EPT_S_NOT_REGISTERED = 1753;

        [NativeTypeName("#define EPT_S_CANT_CREATE 1899L")]
        public const int EPT_S_CANT_CREATE = 1899;

        [NativeTypeName("#define OR_INVALID_OXID 1910L")]
        public const int OR_INVALID_OXID = 1910;

        [NativeTypeName("#define OR_INVALID_OID 1911L")]
        public const int OR_INVALID_OID = 1911;

        [NativeTypeName("#define OR_INVALID_SET 1912L")]
        public const int OR_INVALID_SET = 1912;

        [NativeTypeName("#define PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED 4050L")]
        public const int PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED = 4050;

        [NativeTypeName("#define PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO 4051L")]
        public const int PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO = 4051;

        [NativeTypeName("#define PEERDIST_ERROR_MISSING_DATA 4052L")]
        public const int PEERDIST_ERROR_MISSING_DATA = 4052;

        [NativeTypeName("#define PEERDIST_ERROR_NO_MORE 4053L")]
        public const int PEERDIST_ERROR_NO_MORE = 4053;

        [NativeTypeName("#define PEERDIST_ERROR_NOT_INITIALIZED 4054L")]
        public const int PEERDIST_ERROR_NOT_INITIALIZED = 4054;

        [NativeTypeName("#define PEERDIST_ERROR_ALREADY_INITIALIZED 4055L")]
        public const int PEERDIST_ERROR_ALREADY_INITIALIZED = 4055;

        [NativeTypeName("#define PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS 4056L")]
        public const int PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS = 4056;

        [NativeTypeName("#define PEERDIST_ERROR_INVALIDATED 4057L")]
        public const int PEERDIST_ERROR_INVALIDATED = 4057;

        [NativeTypeName("#define PEERDIST_ERROR_ALREADY_EXISTS 4058L")]
        public const int PEERDIST_ERROR_ALREADY_EXISTS = 4058;

        [NativeTypeName("#define PEERDIST_ERROR_OPERATION_NOTFOUND 4059L")]
        public const int PEERDIST_ERROR_OPERATION_NOTFOUND = 4059;

        [NativeTypeName("#define PEERDIST_ERROR_ALREADY_COMPLETED 4060L")]
        public const int PEERDIST_ERROR_ALREADY_COMPLETED = 4060;

        [NativeTypeName("#define PEERDIST_ERROR_OUT_OF_BOUNDS 4061L")]
        public const int PEERDIST_ERROR_OUT_OF_BOUNDS = 4061;

        [NativeTypeName("#define PEERDIST_ERROR_VERSION_UNSUPPORTED 4062L")]
        public const int PEERDIST_ERROR_VERSION_UNSUPPORTED = 4062;

        [NativeTypeName("#define PEERDIST_ERROR_INVALID_CONFIGURATION 4063L")]
        public const int PEERDIST_ERROR_INVALID_CONFIGURATION = 4063;

        [NativeTypeName("#define PEERDIST_ERROR_NOT_LICENSED 4064L")]
        public const int PEERDIST_ERROR_NOT_LICENSED = 4064;

        [NativeTypeName("#define PEERDIST_ERROR_SERVICE_UNAVAILABLE 4065L")]
        public const int PEERDIST_ERROR_SERVICE_UNAVAILABLE = 4065;

        [NativeTypeName("#define PEERDIST_ERROR_TRUST_FAILURE 4066L")]
        public const int PEERDIST_ERROR_TRUST_FAILURE = 4066;

        [NativeTypeName("#define SCHED_E_SERVICE_NOT_LOCALSYSTEM 6200L")]
        public const int SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200;

        [NativeTypeName("#define FRS_ERR_INVALID_API_SEQUENCE 8001L")]
        public const int FRS_ERR_INVALID_API_SEQUENCE = 8001;

        [NativeTypeName("#define FRS_ERR_STARTING_SERVICE 8002L")]
        public const int FRS_ERR_STARTING_SERVICE = 8002;

        [NativeTypeName("#define FRS_ERR_STOPPING_SERVICE 8003L")]
        public const int FRS_ERR_STOPPING_SERVICE = 8003;

        [NativeTypeName("#define FRS_ERR_INTERNAL_API 8004L")]
        public const int FRS_ERR_INTERNAL_API = 8004;

        [NativeTypeName("#define FRS_ERR_INTERNAL 8005L")]
        public const int FRS_ERR_INTERNAL = 8005;

        [NativeTypeName("#define FRS_ERR_SERVICE_COMM 8006L")]
        public const int FRS_ERR_SERVICE_COMM = 8006;

        [NativeTypeName("#define FRS_ERR_INSUFFICIENT_PRIV 8007L")]
        public const int FRS_ERR_INSUFFICIENT_PRIV = 8007;

        [NativeTypeName("#define FRS_ERR_AUTHENTICATION 8008L")]
        public const int FRS_ERR_AUTHENTICATION = 8008;

        [NativeTypeName("#define FRS_ERR_PARENT_INSUFFICIENT_PRIV 8009L")]
        public const int FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009;

        [NativeTypeName("#define FRS_ERR_PARENT_AUTHENTICATION 8010L")]
        public const int FRS_ERR_PARENT_AUTHENTICATION = 8010;

        [NativeTypeName("#define FRS_ERR_CHILD_TO_PARENT_COMM 8011L")]
        public const int FRS_ERR_CHILD_TO_PARENT_COMM = 8011;

        [NativeTypeName("#define FRS_ERR_PARENT_TO_CHILD_COMM 8012L")]
        public const int FRS_ERR_PARENT_TO_CHILD_COMM = 8012;

        [NativeTypeName("#define FRS_ERR_SYSVOL_POPULATE 8013L")]
        public const int FRS_ERR_SYSVOL_POPULATE = 8013;

        [NativeTypeName("#define FRS_ERR_SYSVOL_POPULATE_TIMEOUT 8014L")]
        public const int FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014;

        [NativeTypeName("#define FRS_ERR_SYSVOL_IS_BUSY 8015L")]
        public const int FRS_ERR_SYSVOL_IS_BUSY = 8015;

        [NativeTypeName("#define FRS_ERR_SYSVOL_DEMOTE 8016L")]
        public const int FRS_ERR_SYSVOL_DEMOTE = 8016;

        [NativeTypeName("#define FRS_ERR_INVALID_SERVICE_PARAMETER 8017L")]
        public const int FRS_ERR_INVALID_SERVICE_PARAMETER = 8017;

        [NativeTypeName("#define DS_S_SUCCESS NO_ERROR")]
        public const int DS_S_SUCCESS = 0;

        [NativeTypeName("#define WSABASEERR 10000")]
        public const int WSABASEERR = 10000;

        [NativeTypeName("#define WSAEINTR 10004L")]
        public const int WSAEINTR = 10004;

        [NativeTypeName("#define WSAEBADF 10009L")]
        public const int WSAEBADF = 10009;

        [NativeTypeName("#define WSAEACCES 10013L")]
        public const int WSAEACCES = 10013;

        [NativeTypeName("#define WSAEFAULT 10014L")]
        public const int WSAEFAULT = 10014;

        [NativeTypeName("#define WSAEINVAL 10022L")]
        public const int WSAEINVAL = 10022;

        [NativeTypeName("#define WSAEMFILE 10024L")]
        public const int WSAEMFILE = 10024;

        [NativeTypeName("#define WSAEWOULDBLOCK 10035L")]
        public const int WSAEWOULDBLOCK = 10035;

        [NativeTypeName("#define WSAEINPROGRESS 10036L")]
        public const int WSAEINPROGRESS = 10036;

        [NativeTypeName("#define WSAEALREADY 10037L")]
        public const int WSAEALREADY = 10037;

        [NativeTypeName("#define WSAENOTSOCK 10038L")]
        public const int WSAENOTSOCK = 10038;

        [NativeTypeName("#define WSAEDESTADDRREQ 10039L")]
        public const int WSAEDESTADDRREQ = 10039;

        [NativeTypeName("#define WSAEMSGSIZE 10040L")]
        public const int WSAEMSGSIZE = 10040;

        [NativeTypeName("#define WSAEPROTOTYPE 10041L")]
        public const int WSAEPROTOTYPE = 10041;

        [NativeTypeName("#define WSAENOPROTOOPT 10042L")]
        public const int WSAENOPROTOOPT = 10042;

        [NativeTypeName("#define WSAEPROTONOSUPPORT 10043L")]
        public const int WSAEPROTONOSUPPORT = 10043;

        [NativeTypeName("#define WSAESOCKTNOSUPPORT 10044L")]
        public const int WSAESOCKTNOSUPPORT = 10044;

        [NativeTypeName("#define WSAEOPNOTSUPP 10045L")]
        public const int WSAEOPNOTSUPP = 10045;

        [NativeTypeName("#define WSAEPFNOSUPPORT 10046L")]
        public const int WSAEPFNOSUPPORT = 10046;

        [NativeTypeName("#define WSAEAFNOSUPPORT 10047L")]
        public const int WSAEAFNOSUPPORT = 10047;

        [NativeTypeName("#define WSAEADDRINUSE 10048L")]
        public const int WSAEADDRINUSE = 10048;

        [NativeTypeName("#define WSAEADDRNOTAVAIL 10049L")]
        public const int WSAEADDRNOTAVAIL = 10049;

        [NativeTypeName("#define WSAENETDOWN 10050L")]
        public const int WSAENETDOWN = 10050;

        [NativeTypeName("#define WSAENETUNREACH 10051L")]
        public const int WSAENETUNREACH = 10051;

        [NativeTypeName("#define WSAENETRESET 10052L")]
        public const int WSAENETRESET = 10052;

        [NativeTypeName("#define WSAECONNABORTED 10053L")]
        public const int WSAECONNABORTED = 10053;

        [NativeTypeName("#define WSAECONNRESET 10054L")]
        public const int WSAECONNRESET = 10054;

        [NativeTypeName("#define WSAENOBUFS 10055L")]
        public const int WSAENOBUFS = 10055;

        [NativeTypeName("#define WSAEISCONN 10056L")]
        public const int WSAEISCONN = 10056;

        [NativeTypeName("#define WSAENOTCONN 10057L")]
        public const int WSAENOTCONN = 10057;

        [NativeTypeName("#define WSAESHUTDOWN 10058L")]
        public const int WSAESHUTDOWN = 10058;

        [NativeTypeName("#define WSAETOOMANYREFS 10059L")]
        public const int WSAETOOMANYREFS = 10059;

        [NativeTypeName("#define WSAETIMEDOUT 10060L")]
        public const int WSAETIMEDOUT = 10060;

        [NativeTypeName("#define WSAECONNREFUSED 10061L")]
        public const int WSAECONNREFUSED = 10061;

        [NativeTypeName("#define WSAELOOP 10062L")]
        public const int WSAELOOP = 10062;

        [NativeTypeName("#define WSAENAMETOOLONG 10063L")]
        public const int WSAENAMETOOLONG = 10063;

        [NativeTypeName("#define WSAEHOSTDOWN 10064L")]
        public const int WSAEHOSTDOWN = 10064;

        [NativeTypeName("#define WSAEHOSTUNREACH 10065L")]
        public const int WSAEHOSTUNREACH = 10065;

        [NativeTypeName("#define WSAENOTEMPTY 10066L")]
        public const int WSAENOTEMPTY = 10066;

        [NativeTypeName("#define WSAEPROCLIM 10067L")]
        public const int WSAEPROCLIM = 10067;

        [NativeTypeName("#define WSAEUSERS 10068L")]
        public const int WSAEUSERS = 10068;

        [NativeTypeName("#define WSAEDQUOT 10069L")]
        public const int WSAEDQUOT = 10069;

        [NativeTypeName("#define WSAESTALE 10070L")]
        public const int WSAESTALE = 10070;

        [NativeTypeName("#define WSAEREMOTE 10071L")]
        public const int WSAEREMOTE = 10071;

        [NativeTypeName("#define WSASYSNOTREADY 10091L")]
        public const int WSASYSNOTREADY = 10091;

        [NativeTypeName("#define WSAVERNOTSUPPORTED 10092L")]
        public const int WSAVERNOTSUPPORTED = 10092;

        [NativeTypeName("#define WSANOTINITIALISED 10093L")]
        public const int WSANOTINITIALISED = 10093;

        [NativeTypeName("#define WSAEDISCON 10101L")]
        public const int WSAEDISCON = 10101;

        [NativeTypeName("#define WSAENOMORE 10102L")]
        public const int WSAENOMORE = 10102;

        [NativeTypeName("#define WSAECANCELLED 10103L")]
        public const int WSAECANCELLED = 10103;

        [NativeTypeName("#define WSAEINVALIDPROCTABLE 10104L")]
        public const int WSAEINVALIDPROCTABLE = 10104;

        [NativeTypeName("#define WSAEINVALIDPROVIDER 10105L")]
        public const int WSAEINVALIDPROVIDER = 10105;

        [NativeTypeName("#define WSAEPROVIDERFAILEDINIT 10106L")]
        public const int WSAEPROVIDERFAILEDINIT = 10106;

        [NativeTypeName("#define WSASYSCALLFAILURE 10107L")]
        public const int WSASYSCALLFAILURE = 10107;

        [NativeTypeName("#define WSASERVICE_NOT_FOUND 10108L")]
        public const int WSASERVICE_NOT_FOUND = 10108;

        [NativeTypeName("#define WSATYPE_NOT_FOUND 10109L")]
        public const int WSATYPE_NOT_FOUND = 10109;

        [NativeTypeName("#define WSA_E_NO_MORE 10110L")]
        public const int WSA_E_NO_MORE = 10110;

        [NativeTypeName("#define WSA_E_CANCELLED 10111L")]
        public const int WSA_E_CANCELLED = 10111;

        [NativeTypeName("#define WSAEREFUSED 10112L")]
        public const int WSAEREFUSED = 10112;

        [NativeTypeName("#define WSAHOST_NOT_FOUND 11001L")]
        public const int WSAHOST_NOT_FOUND = 11001;

        [NativeTypeName("#define WSATRY_AGAIN 11002L")]
        public const int WSATRY_AGAIN = 11002;

        [NativeTypeName("#define WSANO_RECOVERY 11003L")]
        public const int WSANO_RECOVERY = 11003;

        [NativeTypeName("#define WSANO_DATA 11004L")]
        public const int WSANO_DATA = 11004;

        [NativeTypeName("#define WSA_QOS_RECEIVERS 11005L")]
        public const int WSA_QOS_RECEIVERS = 11005;

        [NativeTypeName("#define WSA_QOS_SENDERS 11006L")]
        public const int WSA_QOS_SENDERS = 11006;

        [NativeTypeName("#define WSA_QOS_NO_SENDERS 11007L")]
        public const int WSA_QOS_NO_SENDERS = 11007;

        [NativeTypeName("#define WSA_QOS_NO_RECEIVERS 11008L")]
        public const int WSA_QOS_NO_RECEIVERS = 11008;

        [NativeTypeName("#define WSA_QOS_REQUEST_CONFIRMED 11009L")]
        public const int WSA_QOS_REQUEST_CONFIRMED = 11009;

        [NativeTypeName("#define WSA_QOS_ADMISSION_FAILURE 11010L")]
        public const int WSA_QOS_ADMISSION_FAILURE = 11010;

        [NativeTypeName("#define WSA_QOS_POLICY_FAILURE 11011L")]
        public const int WSA_QOS_POLICY_FAILURE = 11011;

        [NativeTypeName("#define WSA_QOS_BAD_STYLE 11012L")]
        public const int WSA_QOS_BAD_STYLE = 11012;

        [NativeTypeName("#define WSA_QOS_BAD_OBJECT 11013L")]
        public const int WSA_QOS_BAD_OBJECT = 11013;

        [NativeTypeName("#define WSA_QOS_TRAFFIC_CTRL_ERROR 11014L")]
        public const int WSA_QOS_TRAFFIC_CTRL_ERROR = 11014;

        [NativeTypeName("#define WSA_QOS_GENERIC_ERROR 11015L")]
        public const int WSA_QOS_GENERIC_ERROR = 11015;

        [NativeTypeName("#define WSA_QOS_ESERVICETYPE 11016L")]
        public const int WSA_QOS_ESERVICETYPE = 11016;

        [NativeTypeName("#define WSA_QOS_EFLOWSPEC 11017L")]
        public const int WSA_QOS_EFLOWSPEC = 11017;

        [NativeTypeName("#define WSA_QOS_EPROVSPECBUF 11018L")]
        public const int WSA_QOS_EPROVSPECBUF = 11018;

        [NativeTypeName("#define WSA_QOS_EFILTERSTYLE 11019L")]
        public const int WSA_QOS_EFILTERSTYLE = 11019;

        [NativeTypeName("#define WSA_QOS_EFILTERTYPE 11020L")]
        public const int WSA_QOS_EFILTERTYPE = 11020;

        [NativeTypeName("#define WSA_QOS_EFILTERCOUNT 11021L")]
        public const int WSA_QOS_EFILTERCOUNT = 11021;

        [NativeTypeName("#define WSA_QOS_EOBJLENGTH 11022L")]
        public const int WSA_QOS_EOBJLENGTH = 11022;

        [NativeTypeName("#define WSA_QOS_EFLOWCOUNT 11023L")]
        public const int WSA_QOS_EFLOWCOUNT = 11023;

        [NativeTypeName("#define WSA_QOS_EUNKOWNPSOBJ 11024L")]
        public const int WSA_QOS_EUNKOWNPSOBJ = 11024;

        [NativeTypeName("#define WSA_QOS_EPOLICYOBJ 11025L")]
        public const int WSA_QOS_EPOLICYOBJ = 11025;

        [NativeTypeName("#define WSA_QOS_EFLOWDESC 11026L")]
        public const int WSA_QOS_EFLOWDESC = 11026;

        [NativeTypeName("#define WSA_QOS_EPSFLOWSPEC 11027L")]
        public const int WSA_QOS_EPSFLOWSPEC = 11027;

        [NativeTypeName("#define WSA_QOS_EPSFILTERSPEC 11028L")]
        public const int WSA_QOS_EPSFILTERSPEC = 11028;

        [NativeTypeName("#define WSA_QOS_ESDMODEOBJ 11029L")]
        public const int WSA_QOS_ESDMODEOBJ = 11029;

        [NativeTypeName("#define WSA_QOS_ESHAPERATEOBJ 11030L")]
        public const int WSA_QOS_ESHAPERATEOBJ = 11030;

        [NativeTypeName("#define WSA_QOS_RESERVED_PETYPE 11031L")]
        public const int WSA_QOS_RESERVED_PETYPE = 11031;

        [NativeTypeName("#define WSA_SECURE_HOST_NOT_FOUND 11032L")]
        public const int WSA_SECURE_HOST_NOT_FOUND = 11032;

        [NativeTypeName("#define WSA_IPSEC_NAME_POLICY_ERROR 11033L")]
        public const int WSA_IPSEC_NAME_POLICY_ERROR = 11033;

        [NativeTypeName("#define WARNING_IPSEC_MM_POLICY_PRUNED 13024L")]
        public const int WARNING_IPSEC_MM_POLICY_PRUNED = 13024;

        [NativeTypeName("#define WARNING_IPSEC_QM_POLICY_PRUNED 13025L")]
        public const int WARNING_IPSEC_QM_POLICY_PRUNED = 13025;

        [NativeTypeName("#define APPMODEL_ERROR_NO_PACKAGE 15700L")]
        public const int APPMODEL_ERROR_NO_PACKAGE = 15700;

        [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT 15701L")]
        public const int APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701;

        [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT 15702L")]
        public const int APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702;

        [NativeTypeName("#define APPMODEL_ERROR_NO_APPLICATION 15703L")]
        public const int APPMODEL_ERROR_NO_APPLICATION = 15703;

        [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED 15704L")]
        public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED = 15704;

        [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID 15705L")]
        public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID = 15705;

        [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE 15706L")]
        public const int APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE = 15706;

        [NativeTypeName("#define APPMODEL_ERROR_NO_MUTABLE_DIRECTORY 15707L")]
        public const int APPMODEL_ERROR_NO_MUTABLE_DIRECTORY = 15707;

        [NativeTypeName("#define STORE_ERROR_UNLICENSED 15861L")]
        public const int STORE_ERROR_UNLICENSED = 15861;

        [NativeTypeName("#define STORE_ERROR_UNLICENSED_USER 15862L")]
        public const int STORE_ERROR_UNLICENSED_USER = 15862;

        [NativeTypeName("#define STORE_ERROR_PENDING_COM_TRANSACTION 15863L")]
        public const int STORE_ERROR_PENDING_COM_TRANSACTION = 15863;

        [NativeTypeName("#define STORE_ERROR_LICENSE_REVOKED 15864L")]
        public const int STORE_ERROR_LICENSE_REVOKED = 15864;

        [NativeTypeName("#define SEVERITY_SUCCESS 0")]
        public const int SEVERITY_SUCCESS = 0;

        [NativeTypeName("#define SEVERITY_ERROR 1")]
        public const int SEVERITY_ERROR = 1;

        [NativeTypeName("#define NOERROR 0")]
        public const int NOERROR = 0;

        [NativeTypeName("#define RO_E_METADATA_NAME_NOT_FOUND _HRESULT_TYPEDEF_(0x8000000FL)")]
        public const int RO_E_METADATA_NAME_NOT_FOUND = unchecked((int)(0x8000000F));

        [NativeTypeName("#define RO_E_METADATA_NAME_IS_NAMESPACE _HRESULT_TYPEDEF_(0x80000010L)")]
        public const int RO_E_METADATA_NAME_IS_NAMESPACE = unchecked((int)(0x80000010));

        [NativeTypeName("#define RO_E_METADATA_INVALID_TYPE_FORMAT _HRESULT_TYPEDEF_(0x80000011L)")]
        public const int RO_E_METADATA_INVALID_TYPE_FORMAT = unchecked((int)(0x80000011));

        [NativeTypeName("#define RO_E_INVALID_METADATA_FILE _HRESULT_TYPEDEF_(0x80000012L)")]
        public const int RO_E_INVALID_METADATA_FILE = unchecked((int)(0x80000012));

        [NativeTypeName("#define RO_E_CLOSED _HRESULT_TYPEDEF_(0x80000013L)")]
        public const int RO_E_CLOSED = unchecked((int)(0x80000013));

        [NativeTypeName("#define RO_E_EXCLUSIVE_WRITE _HRESULT_TYPEDEF_(0x80000014L)")]
        public const int RO_E_EXCLUSIVE_WRITE = unchecked((int)(0x80000014));

        [NativeTypeName("#define RO_E_CHANGE_NOTIFICATION_IN_PROGRESS _HRESULT_TYPEDEF_(0x80000015L)")]
        public const int RO_E_CHANGE_NOTIFICATION_IN_PROGRESS = unchecked((int)(0x80000015));

        [NativeTypeName("#define RO_E_ERROR_STRING_NOT_FOUND _HRESULT_TYPEDEF_(0x80000016L)")]
        public const int RO_E_ERROR_STRING_NOT_FOUND = unchecked((int)(0x80000016));

        [NativeTypeName("#define RO_E_MUST_BE_AGILE _HRESULT_TYPEDEF_(0x8000001CL)")]
        public const int RO_E_MUST_BE_AGILE = unchecked((int)(0x8000001C));

        [NativeTypeName("#define RO_E_UNSUPPORTED_FROM_MTA _HRESULT_TYPEDEF_(0x8000001DL)")]
        public const int RO_E_UNSUPPORTED_FROM_MTA = unchecked((int)(0x8000001D));

        [NativeTypeName("#define RO_E_COMMITTED _HRESULT_TYPEDEF_(0x8000001EL)")]
        public const int RO_E_COMMITTED = unchecked((int)(0x8000001E));

        [NativeTypeName("#define RO_E_BLOCKED_CROSS_ASTA_CALL _HRESULT_TYPEDEF_(0x8000001FL)")]
        public const int RO_E_BLOCKED_CROSS_ASTA_CALL = unchecked((int)(0x8000001F));

        [NativeTypeName("#define RO_E_CANNOT_ACTIVATE_FULL_TRUST_SERVER _HRESULT_TYPEDEF_(0x80000020L)")]
        public const int RO_E_CANNOT_ACTIVATE_FULL_TRUST_SERVER = unchecked((int)(0x80000020));

        [NativeTypeName("#define RO_E_CANNOT_ACTIVATE_UNIVERSAL_APPLICATION_SERVER _HRESULT_TYPEDEF_(0x80000021L)")]
        public const int RO_E_CANNOT_ACTIVATE_UNIVERSAL_APPLICATION_SERVER = unchecked((int)(0x80000021));

        [NativeTypeName("#define S_OK ((HRESULT)0L)")]
        public const int S_OK = ((int)(0));

        [NativeTypeName("#define S_FALSE ((HRESULT)1L)")]
        public const int S_FALSE = ((int)(1));

        [NativeTypeName("#define OLE_E_FIRST ((HRESULT)0x80040000L)")]
        public const int OLE_E_FIRST = unchecked((int)(0x80040000));

        [NativeTypeName("#define OLE_E_LAST ((HRESULT)0x800400FFL)")]
        public const int OLE_E_LAST = unchecked((int)(0x800400FF));

        [NativeTypeName("#define OLE_S_FIRST ((HRESULT)0x00040000L)")]
        public const int OLE_S_FIRST = ((int)(0x00040000));

        [NativeTypeName("#define OLE_S_LAST ((HRESULT)0x000400FFL)")]
        public const int OLE_S_LAST = ((int)(0x000400FF));

        [NativeTypeName("#define OLE_E_OLEVERB _HRESULT_TYPEDEF_(0x80040000L)")]
        public const int OLE_E_OLEVERB = unchecked((int)(0x80040000));

        [NativeTypeName("#define OLE_E_ADVF _HRESULT_TYPEDEF_(0x80040001L)")]
        public const int OLE_E_ADVF = unchecked((int)(0x80040001));

        [NativeTypeName("#define OLE_E_ENUM_NOMORE _HRESULT_TYPEDEF_(0x80040002L)")]
        public const int OLE_E_ENUM_NOMORE = unchecked((int)(0x80040002));

        [NativeTypeName("#define OLE_E_ADVISENOTSUPPORTED _HRESULT_TYPEDEF_(0x80040003L)")]
        public const int OLE_E_ADVISENOTSUPPORTED = unchecked((int)(0x80040003));

        [NativeTypeName("#define OLE_E_NOCONNECTION _HRESULT_TYPEDEF_(0x80040004L)")]
        public const int OLE_E_NOCONNECTION = unchecked((int)(0x80040004));

        [NativeTypeName("#define OLE_E_NOTRUNNING _HRESULT_TYPEDEF_(0x80040005L)")]
        public const int OLE_E_NOTRUNNING = unchecked((int)(0x80040005));

        [NativeTypeName("#define OLE_E_NOCACHE _HRESULT_TYPEDEF_(0x80040006L)")]
        public const int OLE_E_NOCACHE = unchecked((int)(0x80040006));

        [NativeTypeName("#define OLE_E_BLANK _HRESULT_TYPEDEF_(0x80040007L)")]
        public const int OLE_E_BLANK = unchecked((int)(0x80040007));

        [NativeTypeName("#define OLE_E_CLASSDIFF _HRESULT_TYPEDEF_(0x80040008L)")]
        public const int OLE_E_CLASSDIFF = unchecked((int)(0x80040008));

        [NativeTypeName("#define OLE_E_CANT_GETMONIKER _HRESULT_TYPEDEF_(0x80040009L)")]
        public const int OLE_E_CANT_GETMONIKER = unchecked((int)(0x80040009));

        [NativeTypeName("#define OLE_E_CANT_BINDTOSOURCE _HRESULT_TYPEDEF_(0x8004000AL)")]
        public const int OLE_E_CANT_BINDTOSOURCE = unchecked((int)(0x8004000A));

        [NativeTypeName("#define OLE_E_STATIC _HRESULT_TYPEDEF_(0x8004000BL)")]
        public const int OLE_E_STATIC = unchecked((int)(0x8004000B));

        [NativeTypeName("#define OLE_E_PROMPTSAVECANCELLED _HRESULT_TYPEDEF_(0x8004000CL)")]
        public const int OLE_E_PROMPTSAVECANCELLED = unchecked((int)(0x8004000C));

        [NativeTypeName("#define OLE_E_INVALIDRECT _HRESULT_TYPEDEF_(0x8004000DL)")]
        public const int OLE_E_INVALIDRECT = unchecked((int)(0x8004000D));

        [NativeTypeName("#define OLE_E_WRONGCOMPOBJ _HRESULT_TYPEDEF_(0x8004000EL)")]
        public const int OLE_E_WRONGCOMPOBJ = unchecked((int)(0x8004000E));

        [NativeTypeName("#define OLE_E_INVALIDHWND _HRESULT_TYPEDEF_(0x8004000FL)")]
        public const int OLE_E_INVALIDHWND = unchecked((int)(0x8004000F));

        [NativeTypeName("#define OLE_E_NOT_INPLACEACTIVE _HRESULT_TYPEDEF_(0x80040010L)")]
        public const int OLE_E_NOT_INPLACEACTIVE = unchecked((int)(0x80040010));

        [NativeTypeName("#define OLE_E_CANTCONVERT _HRESULT_TYPEDEF_(0x80040011L)")]
        public const int OLE_E_CANTCONVERT = unchecked((int)(0x80040011));

        [NativeTypeName("#define OLE_E_NOSTORAGE _HRESULT_TYPEDEF_(0x80040012L)")]
        public const int OLE_E_NOSTORAGE = unchecked((int)(0x80040012));

        [NativeTypeName("#define DV_E_FORMATETC _HRESULT_TYPEDEF_(0x80040064L)")]
        public const int DV_E_FORMATETC = unchecked((int)(0x80040064));

        [NativeTypeName("#define DV_E_DVTARGETDEVICE _HRESULT_TYPEDEF_(0x80040065L)")]
        public const int DV_E_DVTARGETDEVICE = unchecked((int)(0x80040065));

        [NativeTypeName("#define DV_E_STGMEDIUM _HRESULT_TYPEDEF_(0x80040066L)")]
        public const int DV_E_STGMEDIUM = unchecked((int)(0x80040066));

        [NativeTypeName("#define DV_E_STATDATA _HRESULT_TYPEDEF_(0x80040067L)")]
        public const int DV_E_STATDATA = unchecked((int)(0x80040067));

        [NativeTypeName("#define DV_E_LINDEX _HRESULT_TYPEDEF_(0x80040068L)")]
        public const int DV_E_LINDEX = unchecked((int)(0x80040068));

        [NativeTypeName("#define DV_E_TYMED _HRESULT_TYPEDEF_(0x80040069L)")]
        public const int DV_E_TYMED = unchecked((int)(0x80040069));

        [NativeTypeName("#define DV_E_CLIPFORMAT _HRESULT_TYPEDEF_(0x8004006AL)")]
        public const int DV_E_CLIPFORMAT = unchecked((int)(0x8004006A));

        [NativeTypeName("#define DV_E_DVASPECT _HRESULT_TYPEDEF_(0x8004006BL)")]
        public const int DV_E_DVASPECT = unchecked((int)(0x8004006B));

        [NativeTypeName("#define DV_E_DVTARGETDEVICE_SIZE _HRESULT_TYPEDEF_(0x8004006CL)")]
        public const int DV_E_DVTARGETDEVICE_SIZE = unchecked((int)(0x8004006C));

        [NativeTypeName("#define DV_E_NOIVIEWOBJECT _HRESULT_TYPEDEF_(0x8004006DL)")]
        public const int DV_E_NOIVIEWOBJECT = unchecked((int)(0x8004006D));

        [NativeTypeName("#define DRAGDROP_E_FIRST 0x80040100L")]
        public const uint DRAGDROP_E_FIRST = 0x80040100;

        [NativeTypeName("#define DRAGDROP_E_LAST 0x8004010FL")]
        public const uint DRAGDROP_E_LAST = 0x8004010F;

        [NativeTypeName("#define DRAGDROP_S_FIRST 0x00040100L")]
        public const int DRAGDROP_S_FIRST = 0x00040100;

        [NativeTypeName("#define DRAGDROP_S_LAST 0x0004010FL")]
        public const int DRAGDROP_S_LAST = 0x0004010F;

        [NativeTypeName("#define DRAGDROP_E_NOTREGISTERED _HRESULT_TYPEDEF_(0x80040100L)")]
        public const int DRAGDROP_E_NOTREGISTERED = unchecked((int)(0x80040100));

        [NativeTypeName("#define DRAGDROP_E_ALREADYREGISTERED _HRESULT_TYPEDEF_(0x80040101L)")]
        public const int DRAGDROP_E_ALREADYREGISTERED = unchecked((int)(0x80040101));

        [NativeTypeName("#define DRAGDROP_E_INVALIDHWND _HRESULT_TYPEDEF_(0x80040102L)")]
        public const int DRAGDROP_E_INVALIDHWND = unchecked((int)(0x80040102));

        [NativeTypeName("#define DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED _HRESULT_TYPEDEF_(0x80040103L)")]
        public const int DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED = unchecked((int)(0x80040103));

        [NativeTypeName("#define CLASSFACTORY_E_FIRST 0x80040110L")]
        public const uint CLASSFACTORY_E_FIRST = 0x80040110;

        [NativeTypeName("#define CLASSFACTORY_E_LAST 0x8004011FL")]
        public const uint CLASSFACTORY_E_LAST = 0x8004011F;

        [NativeTypeName("#define CLASSFACTORY_S_FIRST 0x00040110L")]
        public const int CLASSFACTORY_S_FIRST = 0x00040110;

        [NativeTypeName("#define CLASSFACTORY_S_LAST 0x0004011FL")]
        public const int CLASSFACTORY_S_LAST = 0x0004011F;

        [NativeTypeName("#define CLASS_E_NOAGGREGATION _HRESULT_TYPEDEF_(0x80040110L)")]
        public const int CLASS_E_NOAGGREGATION = unchecked((int)(0x80040110));

        [NativeTypeName("#define CLASS_E_CLASSNOTAVAILABLE _HRESULT_TYPEDEF_(0x80040111L)")]
        public const int CLASS_E_CLASSNOTAVAILABLE = unchecked((int)(0x80040111));

        [NativeTypeName("#define CLASS_E_NOTLICENSED _HRESULT_TYPEDEF_(0x80040112L)")]
        public const int CLASS_E_NOTLICENSED = unchecked((int)(0x80040112));

        [NativeTypeName("#define MARSHAL_E_FIRST 0x80040120L")]
        public const uint MARSHAL_E_FIRST = 0x80040120;

        [NativeTypeName("#define MARSHAL_E_LAST 0x8004012FL")]
        public const uint MARSHAL_E_LAST = 0x8004012F;

        [NativeTypeName("#define MARSHAL_S_FIRST 0x00040120L")]
        public const int MARSHAL_S_FIRST = 0x00040120;

        [NativeTypeName("#define MARSHAL_S_LAST 0x0004012FL")]
        public const int MARSHAL_S_LAST = 0x0004012F;

        [NativeTypeName("#define DATA_E_FIRST 0x80040130L")]
        public const uint DATA_E_FIRST = 0x80040130;

        [NativeTypeName("#define DATA_E_LAST 0x8004013FL")]
        public const uint DATA_E_LAST = 0x8004013F;

        [NativeTypeName("#define DATA_S_FIRST 0x00040130L")]
        public const int DATA_S_FIRST = 0x00040130;

        [NativeTypeName("#define DATA_S_LAST 0x0004013FL")]
        public const int DATA_S_LAST = 0x0004013F;

        [NativeTypeName("#define VIEW_E_FIRST 0x80040140L")]
        public const uint VIEW_E_FIRST = 0x80040140;

        [NativeTypeName("#define VIEW_E_LAST 0x8004014FL")]
        public const uint VIEW_E_LAST = 0x8004014F;

        [NativeTypeName("#define VIEW_S_FIRST 0x00040140L")]
        public const int VIEW_S_FIRST = 0x00040140;

        [NativeTypeName("#define VIEW_S_LAST 0x0004014FL")]
        public const int VIEW_S_LAST = 0x0004014F;

        [NativeTypeName("#define VIEW_E_DRAW _HRESULT_TYPEDEF_(0x80040140L)")]
        public const int VIEW_E_DRAW = unchecked((int)(0x80040140));

        [NativeTypeName("#define REGDB_E_FIRST 0x80040150L")]
        public const uint REGDB_E_FIRST = 0x80040150;

        [NativeTypeName("#define REGDB_E_LAST 0x8004015FL")]
        public const uint REGDB_E_LAST = 0x8004015F;

        [NativeTypeName("#define REGDB_S_FIRST 0x00040150L")]
        public const int REGDB_S_FIRST = 0x00040150;

        [NativeTypeName("#define REGDB_S_LAST 0x0004015FL")]
        public const int REGDB_S_LAST = 0x0004015F;

        [NativeTypeName("#define REGDB_E_READREGDB _HRESULT_TYPEDEF_(0x80040150L)")]
        public const int REGDB_E_READREGDB = unchecked((int)(0x80040150));

        [NativeTypeName("#define REGDB_E_WRITEREGDB _HRESULT_TYPEDEF_(0x80040151L)")]
        public const int REGDB_E_WRITEREGDB = unchecked((int)(0x80040151));

        [NativeTypeName("#define REGDB_E_KEYMISSING _HRESULT_TYPEDEF_(0x80040152L)")]
        public const int REGDB_E_KEYMISSING = unchecked((int)(0x80040152));

        [NativeTypeName("#define REGDB_E_INVALIDVALUE _HRESULT_TYPEDEF_(0x80040153L)")]
        public const int REGDB_E_INVALIDVALUE = unchecked((int)(0x80040153));

        [NativeTypeName("#define REGDB_E_CLASSNOTREG _HRESULT_TYPEDEF_(0x80040154L)")]
        public const int REGDB_E_CLASSNOTREG = unchecked((int)(0x80040154));

        [NativeTypeName("#define REGDB_E_IIDNOTREG _HRESULT_TYPEDEF_(0x80040155L)")]
        public const int REGDB_E_IIDNOTREG = unchecked((int)(0x80040155));

        [NativeTypeName("#define REGDB_E_BADTHREADINGMODEL _HRESULT_TYPEDEF_(0x80040156L)")]
        public const int REGDB_E_BADTHREADINGMODEL = unchecked((int)(0x80040156));

        [NativeTypeName("#define REGDB_E_PACKAGEPOLICYVIOLATION _HRESULT_TYPEDEF_(0x80040157L)")]
        public const int REGDB_E_PACKAGEPOLICYVIOLATION = unchecked((int)(0x80040157));

        [NativeTypeName("#define CAT_E_FIRST 0x80040160L")]
        public const uint CAT_E_FIRST = 0x80040160;

        [NativeTypeName("#define CAT_E_LAST 0x80040161L")]
        public const uint CAT_E_LAST = 0x80040161;

        [NativeTypeName("#define CAT_E_CATIDNOEXIST _HRESULT_TYPEDEF_(0x80040160L)")]
        public const int CAT_E_CATIDNOEXIST = unchecked((int)(0x80040160));

        [NativeTypeName("#define CAT_E_NODESCRIPTION _HRESULT_TYPEDEF_(0x80040161L)")]
        public const int CAT_E_NODESCRIPTION = unchecked((int)(0x80040161));

        [NativeTypeName("#define CS_E_FIRST 0x80040164L")]
        public const uint CS_E_FIRST = 0x80040164;

        [NativeTypeName("#define CS_E_LAST 0x8004016FL")]
        public const uint CS_E_LAST = 0x8004016F;

        [NativeTypeName("#define CS_E_PACKAGE_NOTFOUND _HRESULT_TYPEDEF_(0x80040164L)")]
        public const int CS_E_PACKAGE_NOTFOUND = unchecked((int)(0x80040164));

        [NativeTypeName("#define CS_E_NOT_DELETABLE _HRESULT_TYPEDEF_(0x80040165L)")]
        public const int CS_E_NOT_DELETABLE = unchecked((int)(0x80040165));

        [NativeTypeName("#define CS_E_CLASS_NOTFOUND _HRESULT_TYPEDEF_(0x80040166L)")]
        public const int CS_E_CLASS_NOTFOUND = unchecked((int)(0x80040166));

        [NativeTypeName("#define CS_E_INVALID_VERSION _HRESULT_TYPEDEF_(0x80040167L)")]
        public const int CS_E_INVALID_VERSION = unchecked((int)(0x80040167));

        [NativeTypeName("#define CS_E_NO_CLASSSTORE _HRESULT_TYPEDEF_(0x80040168L)")]
        public const int CS_E_NO_CLASSSTORE = unchecked((int)(0x80040168));

        [NativeTypeName("#define CS_E_OBJECT_NOTFOUND _HRESULT_TYPEDEF_(0x80040169L)")]
        public const int CS_E_OBJECT_NOTFOUND = unchecked((int)(0x80040169));

        [NativeTypeName("#define CS_E_OBJECT_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x8004016AL)")]
        public const int CS_E_OBJECT_ALREADY_EXISTS = unchecked((int)(0x8004016A));

        [NativeTypeName("#define CS_E_INVALID_PATH _HRESULT_TYPEDEF_(0x8004016BL)")]
        public const int CS_E_INVALID_PATH = unchecked((int)(0x8004016B));

        [NativeTypeName("#define CS_E_NETWORK_ERROR _HRESULT_TYPEDEF_(0x8004016CL)")]
        public const int CS_E_NETWORK_ERROR = unchecked((int)(0x8004016C));

        [NativeTypeName("#define CS_E_ADMIN_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8004016DL)")]
        public const int CS_E_ADMIN_LIMIT_EXCEEDED = unchecked((int)(0x8004016D));

        [NativeTypeName("#define CS_E_SCHEMA_MISMATCH _HRESULT_TYPEDEF_(0x8004016EL)")]
        public const int CS_E_SCHEMA_MISMATCH = unchecked((int)(0x8004016E));

        [NativeTypeName("#define CS_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x8004016FL)")]
        public const int CS_E_INTERNAL_ERROR = unchecked((int)(0x8004016F));

        [NativeTypeName("#define CACHE_E_FIRST 0x80040170L")]
        public const uint CACHE_E_FIRST = 0x80040170;

        [NativeTypeName("#define CACHE_E_LAST 0x8004017FL")]
        public const uint CACHE_E_LAST = 0x8004017F;

        [NativeTypeName("#define CACHE_S_FIRST 0x00040170L")]
        public const int CACHE_S_FIRST = 0x00040170;

        [NativeTypeName("#define CACHE_S_LAST 0x0004017FL")]
        public const int CACHE_S_LAST = 0x0004017F;

        [NativeTypeName("#define CACHE_E_NOCACHE_UPDATED _HRESULT_TYPEDEF_(0x80040170L)")]
        public const int CACHE_E_NOCACHE_UPDATED = unchecked((int)(0x80040170));

        [NativeTypeName("#define OLEOBJ_E_FIRST 0x80040180L")]
        public const uint OLEOBJ_E_FIRST = 0x80040180;

        [NativeTypeName("#define OLEOBJ_E_LAST 0x8004018FL")]
        public const uint OLEOBJ_E_LAST = 0x8004018F;

        [NativeTypeName("#define OLEOBJ_S_FIRST 0x00040180L")]
        public const int OLEOBJ_S_FIRST = 0x00040180;

        [NativeTypeName("#define OLEOBJ_S_LAST 0x0004018FL")]
        public const int OLEOBJ_S_LAST = 0x0004018F;

        [NativeTypeName("#define OLEOBJ_E_NOVERBS _HRESULT_TYPEDEF_(0x80040180L)")]
        public const int OLEOBJ_E_NOVERBS = unchecked((int)(0x80040180));

        [NativeTypeName("#define OLEOBJ_E_INVALIDVERB _HRESULT_TYPEDEF_(0x80040181L)")]
        public const int OLEOBJ_E_INVALIDVERB = unchecked((int)(0x80040181));

        [NativeTypeName("#define CLIENTSITE_E_FIRST 0x80040190L")]
        public const uint CLIENTSITE_E_FIRST = 0x80040190;

        [NativeTypeName("#define CLIENTSITE_E_LAST 0x8004019FL")]
        public const uint CLIENTSITE_E_LAST = 0x8004019F;

        [NativeTypeName("#define CLIENTSITE_S_FIRST 0x00040190L")]
        public const int CLIENTSITE_S_FIRST = 0x00040190;

        [NativeTypeName("#define CLIENTSITE_S_LAST 0x0004019FL")]
        public const int CLIENTSITE_S_LAST = 0x0004019F;

        [NativeTypeName("#define INPLACE_E_NOTUNDOABLE _HRESULT_TYPEDEF_(0x800401A0L)")]
        public const int INPLACE_E_NOTUNDOABLE = unchecked((int)(0x800401A0));

        [NativeTypeName("#define INPLACE_E_NOTOOLSPACE _HRESULT_TYPEDEF_(0x800401A1L)")]
        public const int INPLACE_E_NOTOOLSPACE = unchecked((int)(0x800401A1));

        [NativeTypeName("#define INPLACE_E_FIRST 0x800401A0L")]
        public const uint INPLACE_E_FIRST = 0x800401A0;

        [NativeTypeName("#define INPLACE_E_LAST 0x800401AFL")]
        public const uint INPLACE_E_LAST = 0x800401AF;

        [NativeTypeName("#define INPLACE_S_FIRST 0x000401A0L")]
        public const int INPLACE_S_FIRST = 0x000401A0;

        [NativeTypeName("#define INPLACE_S_LAST 0x000401AFL")]
        public const int INPLACE_S_LAST = 0x000401AF;

        [NativeTypeName("#define ENUM_E_FIRST 0x800401B0L")]
        public const uint ENUM_E_FIRST = 0x800401B0;

        [NativeTypeName("#define ENUM_E_LAST 0x800401BFL")]
        public const uint ENUM_E_LAST = 0x800401BF;

        [NativeTypeName("#define ENUM_S_FIRST 0x000401B0L")]
        public const int ENUM_S_FIRST = 0x000401B0;

        [NativeTypeName("#define ENUM_S_LAST 0x000401BFL")]
        public const int ENUM_S_LAST = 0x000401BF;

        [NativeTypeName("#define CONVERT10_E_FIRST 0x800401C0L")]
        public const uint CONVERT10_E_FIRST = 0x800401C0;

        [NativeTypeName("#define CONVERT10_E_LAST 0x800401CFL")]
        public const uint CONVERT10_E_LAST = 0x800401CF;

        [NativeTypeName("#define CONVERT10_S_FIRST 0x000401C0L")]
        public const int CONVERT10_S_FIRST = 0x000401C0;

        [NativeTypeName("#define CONVERT10_S_LAST 0x000401CFL")]
        public const int CONVERT10_S_LAST = 0x000401CF;

        [NativeTypeName("#define CONVERT10_E_OLESTREAM_GET _HRESULT_TYPEDEF_(0x800401C0L)")]
        public const int CONVERT10_E_OLESTREAM_GET = unchecked((int)(0x800401C0));

        [NativeTypeName("#define CONVERT10_E_OLESTREAM_PUT _HRESULT_TYPEDEF_(0x800401C1L)")]
        public const int CONVERT10_E_OLESTREAM_PUT = unchecked((int)(0x800401C1));

        [NativeTypeName("#define CONVERT10_E_OLESTREAM_FMT _HRESULT_TYPEDEF_(0x800401C2L)")]
        public const int CONVERT10_E_OLESTREAM_FMT = unchecked((int)(0x800401C2));

        [NativeTypeName("#define CONVERT10_E_OLESTREAM_BITMAP_TO_DIB _HRESULT_TYPEDEF_(0x800401C3L)")]
        public const int CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = unchecked((int)(0x800401C3));

        [NativeTypeName("#define CONVERT10_E_STG_FMT _HRESULT_TYPEDEF_(0x800401C4L)")]
        public const int CONVERT10_E_STG_FMT = unchecked((int)(0x800401C4));

        [NativeTypeName("#define CONVERT10_E_STG_NO_STD_STREAM _HRESULT_TYPEDEF_(0x800401C5L)")]
        public const int CONVERT10_E_STG_NO_STD_STREAM = unchecked((int)(0x800401C5));

        [NativeTypeName("#define CONVERT10_E_STG_DIB_TO_BITMAP _HRESULT_TYPEDEF_(0x800401C6L)")]
        public const int CONVERT10_E_STG_DIB_TO_BITMAP = unchecked((int)(0x800401C6));

        [NativeTypeName("#define CLIPBRD_E_FIRST 0x800401D0L")]
        public const uint CLIPBRD_E_FIRST = 0x800401D0;

        [NativeTypeName("#define CLIPBRD_E_LAST 0x800401DFL")]
        public const uint CLIPBRD_E_LAST = 0x800401DF;

        [NativeTypeName("#define CLIPBRD_S_FIRST 0x000401D0L")]
        public const int CLIPBRD_S_FIRST = 0x000401D0;

        [NativeTypeName("#define CLIPBRD_S_LAST 0x000401DFL")]
        public const int CLIPBRD_S_LAST = 0x000401DF;

        [NativeTypeName("#define CLIPBRD_E_CANT_OPEN _HRESULT_TYPEDEF_(0x800401D0L)")]
        public const int CLIPBRD_E_CANT_OPEN = unchecked((int)(0x800401D0));

        [NativeTypeName("#define CLIPBRD_E_CANT_EMPTY _HRESULT_TYPEDEF_(0x800401D1L)")]
        public const int CLIPBRD_E_CANT_EMPTY = unchecked((int)(0x800401D1));

        [NativeTypeName("#define CLIPBRD_E_CANT_SET _HRESULT_TYPEDEF_(0x800401D2L)")]
        public const int CLIPBRD_E_CANT_SET = unchecked((int)(0x800401D2));

        [NativeTypeName("#define CLIPBRD_E_BAD_DATA _HRESULT_TYPEDEF_(0x800401D3L)")]
        public const int CLIPBRD_E_BAD_DATA = unchecked((int)(0x800401D3));

        [NativeTypeName("#define CLIPBRD_E_CANT_CLOSE _HRESULT_TYPEDEF_(0x800401D4L)")]
        public const int CLIPBRD_E_CANT_CLOSE = unchecked((int)(0x800401D4));

        [NativeTypeName("#define MK_E_FIRST 0x800401E0L")]
        public const uint MK_E_FIRST = 0x800401E0;

        [NativeTypeName("#define MK_E_LAST 0x800401EFL")]
        public const uint MK_E_LAST = 0x800401EF;

        [NativeTypeName("#define MK_S_FIRST 0x000401E0L")]
        public const int MK_S_FIRST = 0x000401E0;

        [NativeTypeName("#define MK_S_LAST 0x000401EFL")]
        public const int MK_S_LAST = 0x000401EF;

        [NativeTypeName("#define MK_E_CONNECTMANUALLY _HRESULT_TYPEDEF_(0x800401E0L)")]
        public const int MK_E_CONNECTMANUALLY = unchecked((int)(0x800401E0));

        [NativeTypeName("#define MK_E_EXCEEDEDDEADLINE _HRESULT_TYPEDEF_(0x800401E1L)")]
        public const int MK_E_EXCEEDEDDEADLINE = unchecked((int)(0x800401E1));

        [NativeTypeName("#define MK_E_NEEDGENERIC _HRESULT_TYPEDEF_(0x800401E2L)")]
        public const int MK_E_NEEDGENERIC = unchecked((int)(0x800401E2));

        [NativeTypeName("#define MK_E_UNAVAILABLE _HRESULT_TYPEDEF_(0x800401E3L)")]
        public const int MK_E_UNAVAILABLE = unchecked((int)(0x800401E3));

        [NativeTypeName("#define MK_E_SYNTAX _HRESULT_TYPEDEF_(0x800401E4L)")]
        public const int MK_E_SYNTAX = unchecked((int)(0x800401E4));

        [NativeTypeName("#define MK_E_NOOBJECT _HRESULT_TYPEDEF_(0x800401E5L)")]
        public const int MK_E_NOOBJECT = unchecked((int)(0x800401E5));

        [NativeTypeName("#define MK_E_INVALIDEXTENSION _HRESULT_TYPEDEF_(0x800401E6L)")]
        public const int MK_E_INVALIDEXTENSION = unchecked((int)(0x800401E6));

        [NativeTypeName("#define MK_E_INTERMEDIATEINTERFACENOTSUPPORTED _HRESULT_TYPEDEF_(0x800401E7L)")]
        public const int MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = unchecked((int)(0x800401E7));

        [NativeTypeName("#define MK_E_NOTBINDABLE _HRESULT_TYPEDEF_(0x800401E8L)")]
        public const int MK_E_NOTBINDABLE = unchecked((int)(0x800401E8));

        [NativeTypeName("#define MK_E_NOTBOUND _HRESULT_TYPEDEF_(0x800401E9L)")]
        public const int MK_E_NOTBOUND = unchecked((int)(0x800401E9));

        [NativeTypeName("#define MK_E_CANTOPENFILE _HRESULT_TYPEDEF_(0x800401EAL)")]
        public const int MK_E_CANTOPENFILE = unchecked((int)(0x800401EA));

        [NativeTypeName("#define MK_E_MUSTBOTHERUSER _HRESULT_TYPEDEF_(0x800401EBL)")]
        public const int MK_E_MUSTBOTHERUSER = unchecked((int)(0x800401EB));

        [NativeTypeName("#define MK_E_NOINVERSE _HRESULT_TYPEDEF_(0x800401ECL)")]
        public const int MK_E_NOINVERSE = unchecked((int)(0x800401EC));

        [NativeTypeName("#define MK_E_NOSTORAGE _HRESULT_TYPEDEF_(0x800401EDL)")]
        public const int MK_E_NOSTORAGE = unchecked((int)(0x800401ED));

        [NativeTypeName("#define MK_E_NOPREFIX _HRESULT_TYPEDEF_(0x800401EEL)")]
        public const int MK_E_NOPREFIX = unchecked((int)(0x800401EE));

        [NativeTypeName("#define MK_E_ENUMERATION_FAILED _HRESULT_TYPEDEF_(0x800401EFL)")]
        public const int MK_E_ENUMERATION_FAILED = unchecked((int)(0x800401EF));

        [NativeTypeName("#define EVENT_E_FIRST 0x80040200L")]
        public const uint EVENT_E_FIRST = 0x80040200;

        [NativeTypeName("#define EVENT_E_LAST 0x8004021FL")]
        public const uint EVENT_E_LAST = 0x8004021F;

        [NativeTypeName("#define EVENT_S_FIRST 0x00040200L")]
        public const int EVENT_S_FIRST = 0x00040200;

        [NativeTypeName("#define EVENT_S_LAST 0x0004021FL")]
        public const int EVENT_S_LAST = 0x0004021F;

        [NativeTypeName("#define EVENT_S_SOME_SUBSCRIBERS_FAILED _HRESULT_TYPEDEF_(0x00040200L)")]
        public const int EVENT_S_SOME_SUBSCRIBERS_FAILED = ((int)(0x00040200));

        [NativeTypeName("#define EVENT_E_ALL_SUBSCRIBERS_FAILED _HRESULT_TYPEDEF_(0x80040201L)")]
        public const int EVENT_E_ALL_SUBSCRIBERS_FAILED = unchecked((int)(0x80040201));

        [NativeTypeName("#define EVENT_S_NOSUBSCRIBERS _HRESULT_TYPEDEF_(0x00040202L)")]
        public const int EVENT_S_NOSUBSCRIBERS = ((int)(0x00040202));

        [NativeTypeName("#define EVENT_E_QUERYSYNTAX _HRESULT_TYPEDEF_(0x80040203L)")]
        public const int EVENT_E_QUERYSYNTAX = unchecked((int)(0x80040203));

        [NativeTypeName("#define EVENT_E_QUERYFIELD _HRESULT_TYPEDEF_(0x80040204L)")]
        public const int EVENT_E_QUERYFIELD = unchecked((int)(0x80040204));

        [NativeTypeName("#define EVENT_E_INTERNALEXCEPTION _HRESULT_TYPEDEF_(0x80040205L)")]
        public const int EVENT_E_INTERNALEXCEPTION = unchecked((int)(0x80040205));

        [NativeTypeName("#define EVENT_E_INTERNALERROR _HRESULT_TYPEDEF_(0x80040206L)")]
        public const int EVENT_E_INTERNALERROR = unchecked((int)(0x80040206));

        [NativeTypeName("#define EVENT_E_INVALID_PER_USER_SID _HRESULT_TYPEDEF_(0x80040207L)")]
        public const int EVENT_E_INVALID_PER_USER_SID = unchecked((int)(0x80040207));

        [NativeTypeName("#define EVENT_E_USER_EXCEPTION _HRESULT_TYPEDEF_(0x80040208L)")]
        public const int EVENT_E_USER_EXCEPTION = unchecked((int)(0x80040208));

        [NativeTypeName("#define EVENT_E_TOO_MANY_METHODS _HRESULT_TYPEDEF_(0x80040209L)")]
        public const int EVENT_E_TOO_MANY_METHODS = unchecked((int)(0x80040209));

        [NativeTypeName("#define EVENT_E_MISSING_EVENTCLASS _HRESULT_TYPEDEF_(0x8004020AL)")]
        public const int EVENT_E_MISSING_EVENTCLASS = unchecked((int)(0x8004020A));

        [NativeTypeName("#define EVENT_E_NOT_ALL_REMOVED _HRESULT_TYPEDEF_(0x8004020BL)")]
        public const int EVENT_E_NOT_ALL_REMOVED = unchecked((int)(0x8004020B));

        [NativeTypeName("#define EVENT_E_COMPLUS_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8004020CL)")]
        public const int EVENT_E_COMPLUS_NOT_INSTALLED = unchecked((int)(0x8004020C));

        [NativeTypeName("#define EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT _HRESULT_TYPEDEF_(0x8004020DL)")]
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = unchecked((int)(0x8004020D));

        [NativeTypeName("#define EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT _HRESULT_TYPEDEF_(0x8004020EL)")]
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = unchecked((int)(0x8004020E));

        [NativeTypeName("#define EVENT_E_INVALID_EVENT_CLASS_PARTITION _HRESULT_TYPEDEF_(0x8004020FL)")]
        public const int EVENT_E_INVALID_EVENT_CLASS_PARTITION = unchecked((int)(0x8004020F));

        [NativeTypeName("#define EVENT_E_PER_USER_SID_NOT_LOGGED_ON _HRESULT_TYPEDEF_(0x80040210L)")]
        public const int EVENT_E_PER_USER_SID_NOT_LOGGED_ON = unchecked((int)(0x80040210));

        [NativeTypeName("#define TPC_E_INVALID_PROPERTY _HRESULT_TYPEDEF_(0x80040241L)")]
        public const int TPC_E_INVALID_PROPERTY = unchecked((int)(0x80040241));

        [NativeTypeName("#define TPC_E_NO_DEFAULT_TABLET _HRESULT_TYPEDEF_(0x80040212L)")]
        public const int TPC_E_NO_DEFAULT_TABLET = unchecked((int)(0x80040212));

        [NativeTypeName("#define TPC_E_UNKNOWN_PROPERTY _HRESULT_TYPEDEF_(0x8004021BL)")]
        public const int TPC_E_UNKNOWN_PROPERTY = unchecked((int)(0x8004021B));

        [NativeTypeName("#define TPC_E_INVALID_INPUT_RECT _HRESULT_TYPEDEF_(0x80040219L)")]
        public const int TPC_E_INVALID_INPUT_RECT = unchecked((int)(0x80040219));

        [NativeTypeName("#define TPC_E_INVALID_STROKE _HRESULT_TYPEDEF_(0x80040222L)")]
        public const int TPC_E_INVALID_STROKE = unchecked((int)(0x80040222));

        [NativeTypeName("#define TPC_E_INITIALIZE_FAIL _HRESULT_TYPEDEF_(0x80040223L)")]
        public const int TPC_E_INITIALIZE_FAIL = unchecked((int)(0x80040223));

        [NativeTypeName("#define TPC_E_NOT_RELEVANT _HRESULT_TYPEDEF_(0x80040232L)")]
        public const int TPC_E_NOT_RELEVANT = unchecked((int)(0x80040232));

        [NativeTypeName("#define TPC_E_INVALID_PACKET_DESCRIPTION _HRESULT_TYPEDEF_(0x80040233L)")]
        public const int TPC_E_INVALID_PACKET_DESCRIPTION = unchecked((int)(0x80040233));

        [NativeTypeName("#define TPC_E_RECOGNIZER_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80040235L)")]
        public const int TPC_E_RECOGNIZER_NOT_REGISTERED = unchecked((int)(0x80040235));

        [NativeTypeName("#define TPC_E_INVALID_RIGHTS _HRESULT_TYPEDEF_(0x80040236L)")]
        public const int TPC_E_INVALID_RIGHTS = unchecked((int)(0x80040236));

        [NativeTypeName("#define TPC_E_OUT_OF_ORDER_CALL _HRESULT_TYPEDEF_(0x80040237L)")]
        public const int TPC_E_OUT_OF_ORDER_CALL = unchecked((int)(0x80040237));

        [NativeTypeName("#define TPC_E_QUEUE_FULL _HRESULT_TYPEDEF_(0x80040238L)")]
        public const int TPC_E_QUEUE_FULL = unchecked((int)(0x80040238));

        [NativeTypeName("#define TPC_E_INVALID_CONFIGURATION _HRESULT_TYPEDEF_(0x80040239L)")]
        public const int TPC_E_INVALID_CONFIGURATION = unchecked((int)(0x80040239));

        [NativeTypeName("#define TPC_E_INVALID_DATA_FROM_RECOGNIZER _HRESULT_TYPEDEF_(0x8004023AL)")]
        public const int TPC_E_INVALID_DATA_FROM_RECOGNIZER = unchecked((int)(0x8004023A));

        [NativeTypeName("#define TPC_S_TRUNCATED _HRESULT_TYPEDEF_(0x00040252L)")]
        public const int TPC_S_TRUNCATED = ((int)(0x00040252));

        [NativeTypeName("#define TPC_S_INTERRUPTED _HRESULT_TYPEDEF_(0x00040253L)")]
        public const int TPC_S_INTERRUPTED = ((int)(0x00040253));

        [NativeTypeName("#define TPC_S_NO_DATA_TO_PROCESS _HRESULT_TYPEDEF_(0x00040254L)")]
        public const int TPC_S_NO_DATA_TO_PROCESS = ((int)(0x00040254));

        [NativeTypeName("#define XACT_E_FIRST 0x8004D000")]
        public const uint XACT_E_FIRST = 0x8004D000;

        [NativeTypeName("#define XACT_E_LAST 0x8004D02B")]
        public const uint XACT_E_LAST = 0x8004D02B;

        [NativeTypeName("#define XACT_S_FIRST 0x0004D000")]
        public const int XACT_S_FIRST = 0x0004D000;

        [NativeTypeName("#define XACT_S_LAST 0x0004D010")]
        public const int XACT_S_LAST = 0x0004D010;

        [NativeTypeName("#define XACT_E_ALREADYOTHERSINGLEPHASE _HRESULT_TYPEDEF_(0x8004D000L)")]
        public const int XACT_E_ALREADYOTHERSINGLEPHASE = unchecked((int)(0x8004D000));

        [NativeTypeName("#define XACT_E_CANTRETAIN _HRESULT_TYPEDEF_(0x8004D001L)")]
        public const int XACT_E_CANTRETAIN = unchecked((int)(0x8004D001));

        [NativeTypeName("#define XACT_E_COMMITFAILED _HRESULT_TYPEDEF_(0x8004D002L)")]
        public const int XACT_E_COMMITFAILED = unchecked((int)(0x8004D002));

        [NativeTypeName("#define XACT_E_COMMITPREVENTED _HRESULT_TYPEDEF_(0x8004D003L)")]
        public const int XACT_E_COMMITPREVENTED = unchecked((int)(0x8004D003));

        [NativeTypeName("#define XACT_E_HEURISTICABORT _HRESULT_TYPEDEF_(0x8004D004L)")]
        public const int XACT_E_HEURISTICABORT = unchecked((int)(0x8004D004));

        [NativeTypeName("#define XACT_E_HEURISTICCOMMIT _HRESULT_TYPEDEF_(0x8004D005L)")]
        public const int XACT_E_HEURISTICCOMMIT = unchecked((int)(0x8004D005));

        [NativeTypeName("#define XACT_E_HEURISTICDAMAGE _HRESULT_TYPEDEF_(0x8004D006L)")]
        public const int XACT_E_HEURISTICDAMAGE = unchecked((int)(0x8004D006));

        [NativeTypeName("#define XACT_E_HEURISTICDANGER _HRESULT_TYPEDEF_(0x8004D007L)")]
        public const int XACT_E_HEURISTICDANGER = unchecked((int)(0x8004D007));

        [NativeTypeName("#define XACT_E_ISOLATIONLEVEL _HRESULT_TYPEDEF_(0x8004D008L)")]
        public const int XACT_E_ISOLATIONLEVEL = unchecked((int)(0x8004D008));

        [NativeTypeName("#define XACT_E_NOASYNC _HRESULT_TYPEDEF_(0x8004D009L)")]
        public const int XACT_E_NOASYNC = unchecked((int)(0x8004D009));

        [NativeTypeName("#define XACT_E_NOENLIST _HRESULT_TYPEDEF_(0x8004D00AL)")]
        public const int XACT_E_NOENLIST = unchecked((int)(0x8004D00A));

        [NativeTypeName("#define XACT_E_NOISORETAIN _HRESULT_TYPEDEF_(0x8004D00BL)")]
        public const int XACT_E_NOISORETAIN = unchecked((int)(0x8004D00B));

        [NativeTypeName("#define XACT_E_NORESOURCE _HRESULT_TYPEDEF_(0x8004D00CL)")]
        public const int XACT_E_NORESOURCE = unchecked((int)(0x8004D00C));

        [NativeTypeName("#define XACT_E_NOTCURRENT _HRESULT_TYPEDEF_(0x8004D00DL)")]
        public const int XACT_E_NOTCURRENT = unchecked((int)(0x8004D00D));

        [NativeTypeName("#define XACT_E_NOTRANSACTION _HRESULT_TYPEDEF_(0x8004D00EL)")]
        public const int XACT_E_NOTRANSACTION = unchecked((int)(0x8004D00E));

        [NativeTypeName("#define XACT_E_NOTSUPPORTED _HRESULT_TYPEDEF_(0x8004D00FL)")]
        public const int XACT_E_NOTSUPPORTED = unchecked((int)(0x8004D00F));

        [NativeTypeName("#define XACT_E_UNKNOWNRMGRID _HRESULT_TYPEDEF_(0x8004D010L)")]
        public const int XACT_E_UNKNOWNRMGRID = unchecked((int)(0x8004D010));

        [NativeTypeName("#define XACT_E_WRONGSTATE _HRESULT_TYPEDEF_(0x8004D011L)")]
        public const int XACT_E_WRONGSTATE = unchecked((int)(0x8004D011));

        [NativeTypeName("#define XACT_E_WRONGUOW _HRESULT_TYPEDEF_(0x8004D012L)")]
        public const int XACT_E_WRONGUOW = unchecked((int)(0x8004D012));

        [NativeTypeName("#define XACT_E_XTIONEXISTS _HRESULT_TYPEDEF_(0x8004D013L)")]
        public const int XACT_E_XTIONEXISTS = unchecked((int)(0x8004D013));

        [NativeTypeName("#define XACT_E_NOIMPORTOBJECT _HRESULT_TYPEDEF_(0x8004D014L)")]
        public const int XACT_E_NOIMPORTOBJECT = unchecked((int)(0x8004D014));

        [NativeTypeName("#define XACT_E_INVALIDCOOKIE _HRESULT_TYPEDEF_(0x8004D015L)")]
        public const int XACT_E_INVALIDCOOKIE = unchecked((int)(0x8004D015));

        [NativeTypeName("#define XACT_E_INDOUBT _HRESULT_TYPEDEF_(0x8004D016L)")]
        public const int XACT_E_INDOUBT = unchecked((int)(0x8004D016));

        [NativeTypeName("#define XACT_E_NOTIMEOUT _HRESULT_TYPEDEF_(0x8004D017L)")]
        public const int XACT_E_NOTIMEOUT = unchecked((int)(0x8004D017));

        [NativeTypeName("#define XACT_E_ALREADYINPROGRESS _HRESULT_TYPEDEF_(0x8004D018L)")]
        public const int XACT_E_ALREADYINPROGRESS = unchecked((int)(0x8004D018));

        [NativeTypeName("#define XACT_E_ABORTED _HRESULT_TYPEDEF_(0x8004D019L)")]
        public const int XACT_E_ABORTED = unchecked((int)(0x8004D019));

        [NativeTypeName("#define XACT_E_LOGFULL _HRESULT_TYPEDEF_(0x8004D01AL)")]
        public const int XACT_E_LOGFULL = unchecked((int)(0x8004D01A));

        [NativeTypeName("#define XACT_E_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004D01BL)")]
        public const int XACT_E_TMNOTAVAILABLE = unchecked((int)(0x8004D01B));

        [NativeTypeName("#define XACT_E_CONNECTION_DOWN _HRESULT_TYPEDEF_(0x8004D01CL)")]
        public const int XACT_E_CONNECTION_DOWN = unchecked((int)(0x8004D01C));

        [NativeTypeName("#define XACT_E_CONNECTION_DENIED _HRESULT_TYPEDEF_(0x8004D01DL)")]
        public const int XACT_E_CONNECTION_DENIED = unchecked((int)(0x8004D01D));

        [NativeTypeName("#define XACT_E_REENLISTTIMEOUT _HRESULT_TYPEDEF_(0x8004D01EL)")]
        public const int XACT_E_REENLISTTIMEOUT = unchecked((int)(0x8004D01E));

        [NativeTypeName("#define XACT_E_TIP_CONNECT_FAILED _HRESULT_TYPEDEF_(0x8004D01FL)")]
        public const int XACT_E_TIP_CONNECT_FAILED = unchecked((int)(0x8004D01F));

        [NativeTypeName("#define XACT_E_TIP_PROTOCOL_ERROR _HRESULT_TYPEDEF_(0x8004D020L)")]
        public const int XACT_E_TIP_PROTOCOL_ERROR = unchecked((int)(0x8004D020));

        [NativeTypeName("#define XACT_E_TIP_PULL_FAILED _HRESULT_TYPEDEF_(0x8004D021L)")]
        public const int XACT_E_TIP_PULL_FAILED = unchecked((int)(0x8004D021));

        [NativeTypeName("#define XACT_E_DEST_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004D022L)")]
        public const int XACT_E_DEST_TMNOTAVAILABLE = unchecked((int)(0x8004D022));

        [NativeTypeName("#define XACT_E_TIP_DISABLED _HRESULT_TYPEDEF_(0x8004D023L)")]
        public const int XACT_E_TIP_DISABLED = unchecked((int)(0x8004D023));

        [NativeTypeName("#define XACT_E_NETWORK_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D024L)")]
        public const int XACT_E_NETWORK_TX_DISABLED = unchecked((int)(0x8004D024));

        [NativeTypeName("#define XACT_E_PARTNER_NETWORK_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D025L)")]
        public const int XACT_E_PARTNER_NETWORK_TX_DISABLED = unchecked((int)(0x8004D025));

        [NativeTypeName("#define XACT_E_XA_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D026L)")]
        public const int XACT_E_XA_TX_DISABLED = unchecked((int)(0x8004D026));

        [NativeTypeName("#define XACT_E_UNABLE_TO_READ_DTC_CONFIG _HRESULT_TYPEDEF_(0x8004D027L)")]
        public const int XACT_E_UNABLE_TO_READ_DTC_CONFIG = unchecked((int)(0x8004D027));

        [NativeTypeName("#define XACT_E_UNABLE_TO_LOAD_DTC_PROXY _HRESULT_TYPEDEF_(0x8004D028L)")]
        public const int XACT_E_UNABLE_TO_LOAD_DTC_PROXY = unchecked((int)(0x8004D028));

        [NativeTypeName("#define XACT_E_ABORTING _HRESULT_TYPEDEF_(0x8004D029L)")]
        public const int XACT_E_ABORTING = unchecked((int)(0x8004D029));

        [NativeTypeName("#define XACT_E_PUSH_COMM_FAILURE _HRESULT_TYPEDEF_(0x8004D02AL)")]
        public const int XACT_E_PUSH_COMM_FAILURE = unchecked((int)(0x8004D02A));

        [NativeTypeName("#define XACT_E_PULL_COMM_FAILURE _HRESULT_TYPEDEF_(0x8004D02BL)")]
        public const int XACT_E_PULL_COMM_FAILURE = unchecked((int)(0x8004D02B));

        [NativeTypeName("#define XACT_E_LU_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D02CL)")]
        public const int XACT_E_LU_TX_DISABLED = unchecked((int)(0x8004D02C));

        [NativeTypeName("#define XACT_E_CLERKNOTFOUND _HRESULT_TYPEDEF_(0x8004D080L)")]
        public const int XACT_E_CLERKNOTFOUND = unchecked((int)(0x8004D080));

        [NativeTypeName("#define XACT_E_CLERKEXISTS _HRESULT_TYPEDEF_(0x8004D081L)")]
        public const int XACT_E_CLERKEXISTS = unchecked((int)(0x8004D081));

        [NativeTypeName("#define XACT_E_RECOVERYINPROGRESS _HRESULT_TYPEDEF_(0x8004D082L)")]
        public const int XACT_E_RECOVERYINPROGRESS = unchecked((int)(0x8004D082));

        [NativeTypeName("#define XACT_E_TRANSACTIONCLOSED _HRESULT_TYPEDEF_(0x8004D083L)")]
        public const int XACT_E_TRANSACTIONCLOSED = unchecked((int)(0x8004D083));

        [NativeTypeName("#define XACT_E_INVALIDLSN _HRESULT_TYPEDEF_(0x8004D084L)")]
        public const int XACT_E_INVALIDLSN = unchecked((int)(0x8004D084));

        [NativeTypeName("#define XACT_E_REPLAYREQUEST _HRESULT_TYPEDEF_(0x8004D085L)")]
        public const int XACT_E_REPLAYREQUEST = unchecked((int)(0x8004D085));

        [NativeTypeName("#define XACT_S_ASYNC _HRESULT_TYPEDEF_(0x0004D000L)")]
        public const int XACT_S_ASYNC = ((int)(0x0004D000));

        [NativeTypeName("#define XACT_S_DEFECT _HRESULT_TYPEDEF_(0x0004D001L)")]
        public const int XACT_S_DEFECT = ((int)(0x0004D001));

        [NativeTypeName("#define XACT_S_READONLY _HRESULT_TYPEDEF_(0x0004D002L)")]
        public const int XACT_S_READONLY = ((int)(0x0004D002));

        [NativeTypeName("#define XACT_S_SOMENORETAIN _HRESULT_TYPEDEF_(0x0004D003L)")]
        public const int XACT_S_SOMENORETAIN = ((int)(0x0004D003));

        [NativeTypeName("#define XACT_S_OKINFORM _HRESULT_TYPEDEF_(0x0004D004L)")]
        public const int XACT_S_OKINFORM = ((int)(0x0004D004));

        [NativeTypeName("#define XACT_S_MADECHANGESCONTENT _HRESULT_TYPEDEF_(0x0004D005L)")]
        public const int XACT_S_MADECHANGESCONTENT = ((int)(0x0004D005));

        [NativeTypeName("#define XACT_S_MADECHANGESINFORM _HRESULT_TYPEDEF_(0x0004D006L)")]
        public const int XACT_S_MADECHANGESINFORM = ((int)(0x0004D006));

        [NativeTypeName("#define XACT_S_ALLNORETAIN _HRESULT_TYPEDEF_(0x0004D007L)")]
        public const int XACT_S_ALLNORETAIN = ((int)(0x0004D007));

        [NativeTypeName("#define XACT_S_ABORTING _HRESULT_TYPEDEF_(0x0004D008L)")]
        public const int XACT_S_ABORTING = ((int)(0x0004D008));

        [NativeTypeName("#define XACT_S_SINGLEPHASE _HRESULT_TYPEDEF_(0x0004D009L)")]
        public const int XACT_S_SINGLEPHASE = ((int)(0x0004D009));

        [NativeTypeName("#define XACT_S_LOCALLY_OK _HRESULT_TYPEDEF_(0x0004D00AL)")]
        public const int XACT_S_LOCALLY_OK = ((int)(0x0004D00A));

        [NativeTypeName("#define XACT_S_LASTRESOURCEMANAGER _HRESULT_TYPEDEF_(0x0004D010L)")]
        public const int XACT_S_LASTRESOURCEMANAGER = ((int)(0x0004D010));

        [NativeTypeName("#define CONTEXT_E_FIRST 0x8004E000L")]
        public const uint CONTEXT_E_FIRST = 0x8004E000;

        [NativeTypeName("#define CONTEXT_E_LAST 0x8004E02FL")]
        public const uint CONTEXT_E_LAST = 0x8004E02F;

        [NativeTypeName("#define CONTEXT_S_FIRST 0x0004E000L")]
        public const int CONTEXT_S_FIRST = 0x0004E000;

        [NativeTypeName("#define CONTEXT_S_LAST 0x0004E02FL")]
        public const int CONTEXT_S_LAST = 0x0004E02F;

        [NativeTypeName("#define CONTEXT_E_ABORTED _HRESULT_TYPEDEF_(0x8004E002L)")]
        public const int CONTEXT_E_ABORTED = unchecked((int)(0x8004E002));

        [NativeTypeName("#define CONTEXT_E_ABORTING _HRESULT_TYPEDEF_(0x8004E003L)")]
        public const int CONTEXT_E_ABORTING = unchecked((int)(0x8004E003));

        [NativeTypeName("#define CONTEXT_E_NOCONTEXT _HRESULT_TYPEDEF_(0x8004E004L)")]
        public const int CONTEXT_E_NOCONTEXT = unchecked((int)(0x8004E004));

        [NativeTypeName("#define CONTEXT_E_WOULD_DEADLOCK _HRESULT_TYPEDEF_(0x8004E005L)")]
        public const int CONTEXT_E_WOULD_DEADLOCK = unchecked((int)(0x8004E005));

        [NativeTypeName("#define CONTEXT_E_SYNCH_TIMEOUT _HRESULT_TYPEDEF_(0x8004E006L)")]
        public const int CONTEXT_E_SYNCH_TIMEOUT = unchecked((int)(0x8004E006));

        [NativeTypeName("#define CONTEXT_E_OLDREF _HRESULT_TYPEDEF_(0x8004E007L)")]
        public const int CONTEXT_E_OLDREF = unchecked((int)(0x8004E007));

        [NativeTypeName("#define CONTEXT_E_ROLENOTFOUND _HRESULT_TYPEDEF_(0x8004E00CL)")]
        public const int CONTEXT_E_ROLENOTFOUND = unchecked((int)(0x8004E00C));

        [NativeTypeName("#define CONTEXT_E_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004E00FL)")]
        public const int CONTEXT_E_TMNOTAVAILABLE = unchecked((int)(0x8004E00F));

        [NativeTypeName("#define CONTEXT_E_NOJIT _HRESULT_TYPEDEF_(0x8004E026L)")]
        public const int CONTEXT_E_NOJIT = unchecked((int)(0x8004E026));

        [NativeTypeName("#define CONTEXT_E_NOTRANSACTION _HRESULT_TYPEDEF_(0x8004E027L)")]
        public const int CONTEXT_E_NOTRANSACTION = unchecked((int)(0x8004E027));

        [NativeTypeName("#define OLE_S_USEREG _HRESULT_TYPEDEF_(0x00040000L)")]
        public const int OLE_S_USEREG = ((int)(0x00040000));

        [NativeTypeName("#define OLE_S_STATIC _HRESULT_TYPEDEF_(0x00040001L)")]
        public const int OLE_S_STATIC = ((int)(0x00040001));

        [NativeTypeName("#define OLE_S_MAC_CLIPFORMAT _HRESULT_TYPEDEF_(0x00040002L)")]
        public const int OLE_S_MAC_CLIPFORMAT = ((int)(0x00040002));

        [NativeTypeName("#define DRAGDROP_S_DROP _HRESULT_TYPEDEF_(0x00040100L)")]
        public const int DRAGDROP_S_DROP = ((int)(0x00040100));

        [NativeTypeName("#define DRAGDROP_S_CANCEL _HRESULT_TYPEDEF_(0x00040101L)")]
        public const int DRAGDROP_S_CANCEL = ((int)(0x00040101));

        [NativeTypeName("#define DRAGDROP_S_USEDEFAULTCURSORS _HRESULT_TYPEDEF_(0x00040102L)")]
        public const int DRAGDROP_S_USEDEFAULTCURSORS = ((int)(0x00040102));

        [NativeTypeName("#define DATA_S_SAMEFORMATETC _HRESULT_TYPEDEF_(0x00040130L)")]
        public const int DATA_S_SAMEFORMATETC = ((int)(0x00040130));

        [NativeTypeName("#define VIEW_S_ALREADY_FROZEN _HRESULT_TYPEDEF_(0x00040140L)")]
        public const int VIEW_S_ALREADY_FROZEN = ((int)(0x00040140));

        [NativeTypeName("#define CACHE_S_FORMATETC_NOTSUPPORTED _HRESULT_TYPEDEF_(0x00040170L)")]
        public const int CACHE_S_FORMATETC_NOTSUPPORTED = ((int)(0x00040170));

        [NativeTypeName("#define CACHE_S_SAMECACHE _HRESULT_TYPEDEF_(0x00040171L)")]
        public const int CACHE_S_SAMECACHE = ((int)(0x00040171));

        [NativeTypeName("#define CACHE_S_SOMECACHES_NOTUPDATED _HRESULT_TYPEDEF_(0x00040172L)")]
        public const int CACHE_S_SOMECACHES_NOTUPDATED = ((int)(0x00040172));

        [NativeTypeName("#define OLEOBJ_S_INVALIDVERB _HRESULT_TYPEDEF_(0x00040180L)")]
        public const int OLEOBJ_S_INVALIDVERB = ((int)(0x00040180));

        [NativeTypeName("#define OLEOBJ_S_CANNOT_DOVERB_NOW _HRESULT_TYPEDEF_(0x00040181L)")]
        public const int OLEOBJ_S_CANNOT_DOVERB_NOW = ((int)(0x00040181));

        [NativeTypeName("#define OLEOBJ_S_INVALIDHWND _HRESULT_TYPEDEF_(0x00040182L)")]
        public const int OLEOBJ_S_INVALIDHWND = ((int)(0x00040182));

        [NativeTypeName("#define INPLACE_S_TRUNCATED _HRESULT_TYPEDEF_(0x000401A0L)")]
        public const int INPLACE_S_TRUNCATED = ((int)(0x000401A0));

        [NativeTypeName("#define CONVERT10_S_NO_PRESENTATION _HRESULT_TYPEDEF_(0x000401C0L)")]
        public const int CONVERT10_S_NO_PRESENTATION = ((int)(0x000401C0));

        [NativeTypeName("#define MK_S_REDUCED_TO_SELF _HRESULT_TYPEDEF_(0x000401E2L)")]
        public const int MK_S_REDUCED_TO_SELF = ((int)(0x000401E2));

        [NativeTypeName("#define MK_S_ME _HRESULT_TYPEDEF_(0x000401E4L)")]
        public const int MK_S_ME = ((int)(0x000401E4));

        [NativeTypeName("#define MK_S_HIM _HRESULT_TYPEDEF_(0x000401E5L)")]
        public const int MK_S_HIM = ((int)(0x000401E5));

        [NativeTypeName("#define MK_S_US _HRESULT_TYPEDEF_(0x000401E6L)")]
        public const int MK_S_US = ((int)(0x000401E6));

        [NativeTypeName("#define MK_S_MONIKERALREADYREGISTERED _HRESULT_TYPEDEF_(0x000401E7L)")]
        public const int MK_S_MONIKERALREADYREGISTERED = ((int)(0x000401E7));

        [NativeTypeName("#define SCHED_S_TASK_READY _HRESULT_TYPEDEF_(0x00041300L)")]
        public const int SCHED_S_TASK_READY = ((int)(0x00041300));

        [NativeTypeName("#define SCHED_S_TASK_RUNNING _HRESULT_TYPEDEF_(0x00041301L)")]
        public const int SCHED_S_TASK_RUNNING = ((int)(0x00041301));

        [NativeTypeName("#define SCHED_S_TASK_DISABLED _HRESULT_TYPEDEF_(0x00041302L)")]
        public const int SCHED_S_TASK_DISABLED = ((int)(0x00041302));

        [NativeTypeName("#define SCHED_S_TASK_HAS_NOT_RUN _HRESULT_TYPEDEF_(0x00041303L)")]
        public const int SCHED_S_TASK_HAS_NOT_RUN = ((int)(0x00041303));

        [NativeTypeName("#define SCHED_S_TASK_NO_MORE_RUNS _HRESULT_TYPEDEF_(0x00041304L)")]
        public const int SCHED_S_TASK_NO_MORE_RUNS = ((int)(0x00041304));

        [NativeTypeName("#define SCHED_S_TASK_NOT_SCHEDULED _HRESULT_TYPEDEF_(0x00041305L)")]
        public const int SCHED_S_TASK_NOT_SCHEDULED = ((int)(0x00041305));

        [NativeTypeName("#define SCHED_S_TASK_TERMINATED _HRESULT_TYPEDEF_(0x00041306L)")]
        public const int SCHED_S_TASK_TERMINATED = ((int)(0x00041306));

        [NativeTypeName("#define SCHED_S_TASK_NO_VALID_TRIGGERS _HRESULT_TYPEDEF_(0x00041307L)")]
        public const int SCHED_S_TASK_NO_VALID_TRIGGERS = ((int)(0x00041307));

        [NativeTypeName("#define SCHED_S_EVENT_TRIGGER _HRESULT_TYPEDEF_(0x00041308L)")]
        public const int SCHED_S_EVENT_TRIGGER = ((int)(0x00041308));

        [NativeTypeName("#define SCHED_E_TRIGGER_NOT_FOUND _HRESULT_TYPEDEF_(0x80041309L)")]
        public const int SCHED_E_TRIGGER_NOT_FOUND = unchecked((int)(0x80041309));

        [NativeTypeName("#define SCHED_E_TASK_NOT_READY _HRESULT_TYPEDEF_(0x8004130AL)")]
        public const int SCHED_E_TASK_NOT_READY = unchecked((int)(0x8004130A));

        [NativeTypeName("#define SCHED_E_TASK_NOT_RUNNING _HRESULT_TYPEDEF_(0x8004130BL)")]
        public const int SCHED_E_TASK_NOT_RUNNING = unchecked((int)(0x8004130B));

        [NativeTypeName("#define SCHED_E_SERVICE_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8004130CL)")]
        public const int SCHED_E_SERVICE_NOT_INSTALLED = unchecked((int)(0x8004130C));

        [NativeTypeName("#define SCHED_E_CANNOT_OPEN_TASK _HRESULT_TYPEDEF_(0x8004130DL)")]
        public const int SCHED_E_CANNOT_OPEN_TASK = unchecked((int)(0x8004130D));

        [NativeTypeName("#define SCHED_E_INVALID_TASK _HRESULT_TYPEDEF_(0x8004130EL)")]
        public const int SCHED_E_INVALID_TASK = unchecked((int)(0x8004130E));

        [NativeTypeName("#define SCHED_E_ACCOUNT_INFORMATION_NOT_SET _HRESULT_TYPEDEF_(0x8004130FL)")]
        public const int SCHED_E_ACCOUNT_INFORMATION_NOT_SET = unchecked((int)(0x8004130F));

        [NativeTypeName("#define SCHED_E_ACCOUNT_NAME_NOT_FOUND _HRESULT_TYPEDEF_(0x80041310L)")]
        public const int SCHED_E_ACCOUNT_NAME_NOT_FOUND = unchecked((int)(0x80041310));

        [NativeTypeName("#define SCHED_E_ACCOUNT_DBASE_CORRUPT _HRESULT_TYPEDEF_(0x80041311L)")]
        public const int SCHED_E_ACCOUNT_DBASE_CORRUPT = unchecked((int)(0x80041311));

        [NativeTypeName("#define SCHED_E_NO_SECURITY_SERVICES _HRESULT_TYPEDEF_(0x80041312L)")]
        public const int SCHED_E_NO_SECURITY_SERVICES = unchecked((int)(0x80041312));

        [NativeTypeName("#define SCHED_E_UNKNOWN_OBJECT_VERSION _HRESULT_TYPEDEF_(0x80041313L)")]
        public const int SCHED_E_UNKNOWN_OBJECT_VERSION = unchecked((int)(0x80041313));

        [NativeTypeName("#define SCHED_E_UNSUPPORTED_ACCOUNT_OPTION _HRESULT_TYPEDEF_(0x80041314L)")]
        public const int SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = unchecked((int)(0x80041314));

        [NativeTypeName("#define SCHED_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x80041315L)")]
        public const int SCHED_E_SERVICE_NOT_RUNNING = unchecked((int)(0x80041315));

        [NativeTypeName("#define SCHED_E_UNEXPECTEDNODE _HRESULT_TYPEDEF_(0x80041316L)")]
        public const int SCHED_E_UNEXPECTEDNODE = unchecked((int)(0x80041316));

        [NativeTypeName("#define SCHED_E_NAMESPACE _HRESULT_TYPEDEF_(0x80041317L)")]
        public const int SCHED_E_NAMESPACE = unchecked((int)(0x80041317));

        [NativeTypeName("#define SCHED_E_INVALIDVALUE _HRESULT_TYPEDEF_(0x80041318L)")]
        public const int SCHED_E_INVALIDVALUE = unchecked((int)(0x80041318));

        [NativeTypeName("#define SCHED_E_MISSINGNODE _HRESULT_TYPEDEF_(0x80041319L)")]
        public const int SCHED_E_MISSINGNODE = unchecked((int)(0x80041319));

        [NativeTypeName("#define SCHED_E_MALFORMEDXML _HRESULT_TYPEDEF_(0x8004131AL)")]
        public const int SCHED_E_MALFORMEDXML = unchecked((int)(0x8004131A));

        [NativeTypeName("#define SCHED_S_SOME_TRIGGERS_FAILED _HRESULT_TYPEDEF_(0x0004131BL)")]
        public const int SCHED_S_SOME_TRIGGERS_FAILED = ((int)(0x0004131B));

        [NativeTypeName("#define SCHED_S_BATCH_LOGON_PROBLEM _HRESULT_TYPEDEF_(0x0004131CL)")]
        public const int SCHED_S_BATCH_LOGON_PROBLEM = ((int)(0x0004131C));

        [NativeTypeName("#define SCHED_E_TOO_MANY_NODES _HRESULT_TYPEDEF_(0x8004131DL)")]
        public const int SCHED_E_TOO_MANY_NODES = unchecked((int)(0x8004131D));

        [NativeTypeName("#define SCHED_E_PAST_END_BOUNDARY _HRESULT_TYPEDEF_(0x8004131EL)")]
        public const int SCHED_E_PAST_END_BOUNDARY = unchecked((int)(0x8004131E));

        [NativeTypeName("#define SCHED_E_ALREADY_RUNNING _HRESULT_TYPEDEF_(0x8004131FL)")]
        public const int SCHED_E_ALREADY_RUNNING = unchecked((int)(0x8004131F));

        [NativeTypeName("#define SCHED_E_USER_NOT_LOGGED_ON _HRESULT_TYPEDEF_(0x80041320L)")]
        public const int SCHED_E_USER_NOT_LOGGED_ON = unchecked((int)(0x80041320));

        [NativeTypeName("#define SCHED_E_INVALID_TASK_HASH _HRESULT_TYPEDEF_(0x80041321L)")]
        public const int SCHED_E_INVALID_TASK_HASH = unchecked((int)(0x80041321));

        [NativeTypeName("#define SCHED_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80041322L)")]
        public const int SCHED_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80041322));

        [NativeTypeName("#define SCHED_E_SERVICE_TOO_BUSY _HRESULT_TYPEDEF_(0x80041323L)")]
        public const int SCHED_E_SERVICE_TOO_BUSY = unchecked((int)(0x80041323));

        [NativeTypeName("#define SCHED_E_TASK_ATTEMPTED _HRESULT_TYPEDEF_(0x80041324L)")]
        public const int SCHED_E_TASK_ATTEMPTED = unchecked((int)(0x80041324));

        [NativeTypeName("#define SCHED_S_TASK_QUEUED _HRESULT_TYPEDEF_(0x00041325L)")]
        public const int SCHED_S_TASK_QUEUED = ((int)(0x00041325));

        [NativeTypeName("#define SCHED_E_TASK_DISABLED _HRESULT_TYPEDEF_(0x80041326L)")]
        public const int SCHED_E_TASK_DISABLED = unchecked((int)(0x80041326));

        [NativeTypeName("#define SCHED_E_TASK_NOT_V1_COMPAT _HRESULT_TYPEDEF_(0x80041327L)")]
        public const int SCHED_E_TASK_NOT_V1_COMPAT = unchecked((int)(0x80041327));

        [NativeTypeName("#define SCHED_E_START_ON_DEMAND _HRESULT_TYPEDEF_(0x80041328L)")]
        public const int SCHED_E_START_ON_DEMAND = unchecked((int)(0x80041328));

        [NativeTypeName("#define SCHED_E_TASK_NOT_UBPM_COMPAT _HRESULT_TYPEDEF_(0x80041329L)")]
        public const int SCHED_E_TASK_NOT_UBPM_COMPAT = unchecked((int)(0x80041329));

        [NativeTypeName("#define SCHED_E_DEPRECATED_FEATURE_USED _HRESULT_TYPEDEF_(0x80041330L)")]
        public const int SCHED_E_DEPRECATED_FEATURE_USED = unchecked((int)(0x80041330));

        [NativeTypeName("#define MK_E_NO_NORMALIZED _HRESULT_TYPEDEF_(0x80080007L)")]
        public const int MK_E_NO_NORMALIZED = unchecked((int)(0x80080007));

        [NativeTypeName("#define MEM_E_INVALID_ROOT _HRESULT_TYPEDEF_(0x80080009L)")]
        public const int MEM_E_INVALID_ROOT = unchecked((int)(0x80080009));

        [NativeTypeName("#define MEM_E_INVALID_LINK _HRESULT_TYPEDEF_(0x80080010L)")]
        public const int MEM_E_INVALID_LINK = unchecked((int)(0x80080010));

        [NativeTypeName("#define MEM_E_INVALID_SIZE _HRESULT_TYPEDEF_(0x80080011L)")]
        public const int MEM_E_INVALID_SIZE = unchecked((int)(0x80080011));

        [NativeTypeName("#define APPX_E_PACKAGING_INTERNAL _HRESULT_TYPEDEF_(0x80080200L)")]
        public const int APPX_E_PACKAGING_INTERNAL = unchecked((int)(0x80080200));

        [NativeTypeName("#define APPX_E_INTERLEAVING_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080201L)")]
        public const int APPX_E_INTERLEAVING_NOT_ALLOWED = unchecked((int)(0x80080201));

        [NativeTypeName("#define APPX_E_RELATIONSHIPS_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080202L)")]
        public const int APPX_E_RELATIONSHIPS_NOT_ALLOWED = unchecked((int)(0x80080202));

        [NativeTypeName("#define APPX_E_MISSING_REQUIRED_FILE _HRESULT_TYPEDEF_(0x80080203L)")]
        public const int APPX_E_MISSING_REQUIRED_FILE = unchecked((int)(0x80080203));

        [NativeTypeName("#define APPX_E_INVALID_MANIFEST _HRESULT_TYPEDEF_(0x80080204L)")]
        public const int APPX_E_INVALID_MANIFEST = unchecked((int)(0x80080204));

        [NativeTypeName("#define APPX_E_INVALID_BLOCKMAP _HRESULT_TYPEDEF_(0x80080205L)")]
        public const int APPX_E_INVALID_BLOCKMAP = unchecked((int)(0x80080205));

        [NativeTypeName("#define APPX_E_CORRUPT_CONTENT _HRESULT_TYPEDEF_(0x80080206L)")]
        public const int APPX_E_CORRUPT_CONTENT = unchecked((int)(0x80080206));

        [NativeTypeName("#define APPX_E_BLOCK_HASH_INVALID _HRESULT_TYPEDEF_(0x80080207L)")]
        public const int APPX_E_BLOCK_HASH_INVALID = unchecked((int)(0x80080207));

        [NativeTypeName("#define APPX_E_REQUESTED_RANGE_TOO_LARGE _HRESULT_TYPEDEF_(0x80080208L)")]
        public const int APPX_E_REQUESTED_RANGE_TOO_LARGE = unchecked((int)(0x80080208));

        [NativeTypeName("#define APPX_E_INVALID_SIP_CLIENT_DATA _HRESULT_TYPEDEF_(0x80080209L)")]
        public const int APPX_E_INVALID_SIP_CLIENT_DATA = unchecked((int)(0x80080209));

        [NativeTypeName("#define APPX_E_INVALID_KEY_INFO _HRESULT_TYPEDEF_(0x8008020AL)")]
        public const int APPX_E_INVALID_KEY_INFO = unchecked((int)(0x8008020A));

        [NativeTypeName("#define APPX_E_INVALID_CONTENTGROUPMAP _HRESULT_TYPEDEF_(0x8008020BL)")]
        public const int APPX_E_INVALID_CONTENTGROUPMAP = unchecked((int)(0x8008020B));

        [NativeTypeName("#define APPX_E_INVALID_APPINSTALLER _HRESULT_TYPEDEF_(0x8008020CL)")]
        public const int APPX_E_INVALID_APPINSTALLER = unchecked((int)(0x8008020C));

        [NativeTypeName("#define APPX_E_DELTA_BASELINE_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x8008020DL)")]
        public const int APPX_E_DELTA_BASELINE_VERSION_MISMATCH = unchecked((int)(0x8008020D));

        [NativeTypeName("#define APPX_E_DELTA_PACKAGE_MISSING_FILE _HRESULT_TYPEDEF_(0x8008020EL)")]
        public const int APPX_E_DELTA_PACKAGE_MISSING_FILE = unchecked((int)(0x8008020E));

        [NativeTypeName("#define APPX_E_INVALID_DELTA_PACKAGE _HRESULT_TYPEDEF_(0x8008020FL)")]
        public const int APPX_E_INVALID_DELTA_PACKAGE = unchecked((int)(0x8008020F));

        [NativeTypeName("#define APPX_E_DELTA_APPENDED_PACKAGE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080210L)")]
        public const int APPX_E_DELTA_APPENDED_PACKAGE_NOT_ALLOWED = unchecked((int)(0x80080210));

        [NativeTypeName("#define APPX_E_INVALID_PACKAGING_LAYOUT _HRESULT_TYPEDEF_(0x80080211L)")]
        public const int APPX_E_INVALID_PACKAGING_LAYOUT = unchecked((int)(0x80080211));

        [NativeTypeName("#define APPX_E_INVALID_PACKAGESIGNCONFIG _HRESULT_TYPEDEF_(0x80080212L)")]
        public const int APPX_E_INVALID_PACKAGESIGNCONFIG = unchecked((int)(0x80080212));

        [NativeTypeName("#define APPX_E_RESOURCESPRI_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080213L)")]
        public const int APPX_E_RESOURCESPRI_NOT_ALLOWED = unchecked((int)(0x80080213));

        [NativeTypeName("#define APPX_E_FILE_COMPRESSION_MISMATCH _HRESULT_TYPEDEF_(0x80080214L)")]
        public const int APPX_E_FILE_COMPRESSION_MISMATCH = unchecked((int)(0x80080214));

        [NativeTypeName("#define APPX_E_INVALID_PAYLOAD_PACKAGE_EXTENSION _HRESULT_TYPEDEF_(0x80080215L)")]
        public const int APPX_E_INVALID_PAYLOAD_PACKAGE_EXTENSION = unchecked((int)(0x80080215));

        [NativeTypeName("#define APPX_E_INVALID_ENCRYPTION_EXCLUSION_FILE_LIST _HRESULT_TYPEDEF_(0x80080216L)")]
        public const int APPX_E_INVALID_ENCRYPTION_EXCLUSION_FILE_LIST = unchecked((int)(0x80080216));

        [NativeTypeName("#define APPX_E_INVALID_PACKAGE_FOLDER_ACLS _HRESULT_TYPEDEF_(0x80080217L)")]
        public const int APPX_E_INVALID_PACKAGE_FOLDER_ACLS = unchecked((int)(0x80080217));

        [NativeTypeName("#define BT_E_SPURIOUS_ACTIVATION _HRESULT_TYPEDEF_(0x80080300L)")]
        public const int BT_E_SPURIOUS_ACTIVATION = unchecked((int)(0x80080300));

        [NativeTypeName("#define DISP_E_UNKNOWNINTERFACE _HRESULT_TYPEDEF_(0x80020001L)")]
        public const int DISP_E_UNKNOWNINTERFACE = unchecked((int)(0x80020001));

        [NativeTypeName("#define DISP_E_MEMBERNOTFOUND _HRESULT_TYPEDEF_(0x80020003L)")]
        public const int DISP_E_MEMBERNOTFOUND = unchecked((int)(0x80020003));

        [NativeTypeName("#define DISP_E_PARAMNOTFOUND _HRESULT_TYPEDEF_(0x80020004L)")]
        public const int DISP_E_PARAMNOTFOUND = unchecked((int)(0x80020004));

        [NativeTypeName("#define DISP_E_TYPEMISMATCH _HRESULT_TYPEDEF_(0x80020005L)")]
        public const int DISP_E_TYPEMISMATCH = unchecked((int)(0x80020005));

        [NativeTypeName("#define DISP_E_UNKNOWNNAME _HRESULT_TYPEDEF_(0x80020006L)")]
        public const int DISP_E_UNKNOWNNAME = unchecked((int)(0x80020006));

        [NativeTypeName("#define DISP_E_NONAMEDARGS _HRESULT_TYPEDEF_(0x80020007L)")]
        public const int DISP_E_NONAMEDARGS = unchecked((int)(0x80020007));

        [NativeTypeName("#define DISP_E_BADVARTYPE _HRESULT_TYPEDEF_(0x80020008L)")]
        public const int DISP_E_BADVARTYPE = unchecked((int)(0x80020008));

        [NativeTypeName("#define DISP_E_EXCEPTION _HRESULT_TYPEDEF_(0x80020009L)")]
        public const int DISP_E_EXCEPTION = unchecked((int)(0x80020009));

        [NativeTypeName("#define DISP_E_OVERFLOW _HRESULT_TYPEDEF_(0x8002000AL)")]
        public const int DISP_E_OVERFLOW = unchecked((int)(0x8002000A));

        [NativeTypeName("#define DISP_E_BADINDEX _HRESULT_TYPEDEF_(0x8002000BL)")]
        public const int DISP_E_BADINDEX = unchecked((int)(0x8002000B));

        [NativeTypeName("#define DISP_E_UNKNOWNLCID _HRESULT_TYPEDEF_(0x8002000CL)")]
        public const int DISP_E_UNKNOWNLCID = unchecked((int)(0x8002000C));

        [NativeTypeName("#define DISP_E_ARRAYISLOCKED _HRESULT_TYPEDEF_(0x8002000DL)")]
        public const int DISP_E_ARRAYISLOCKED = unchecked((int)(0x8002000D));

        [NativeTypeName("#define DISP_E_BADPARAMCOUNT _HRESULT_TYPEDEF_(0x8002000EL)")]
        public const int DISP_E_BADPARAMCOUNT = unchecked((int)(0x8002000E));

        [NativeTypeName("#define DISP_E_PARAMNOTOPTIONAL _HRESULT_TYPEDEF_(0x8002000FL)")]
        public const int DISP_E_PARAMNOTOPTIONAL = unchecked((int)(0x8002000F));

        [NativeTypeName("#define DISP_E_BADCALLEE _HRESULT_TYPEDEF_(0x80020010L)")]
        public const int DISP_E_BADCALLEE = unchecked((int)(0x80020010));

        [NativeTypeName("#define DISP_E_NOTACOLLECTION _HRESULT_TYPEDEF_(0x80020011L)")]
        public const int DISP_E_NOTACOLLECTION = unchecked((int)(0x80020011));

        [NativeTypeName("#define DISP_E_DIVBYZERO _HRESULT_TYPEDEF_(0x80020012L)")]
        public const int DISP_E_DIVBYZERO = unchecked((int)(0x80020012));

        [NativeTypeName("#define DISP_E_BUFFERTOOSMALL _HRESULT_TYPEDEF_(0x80020013L)")]
        public const int DISP_E_BUFFERTOOSMALL = unchecked((int)(0x80020013));

        [NativeTypeName("#define TYPE_E_BUFFERTOOSMALL _HRESULT_TYPEDEF_(0x80028016L)")]
        public const int TYPE_E_BUFFERTOOSMALL = unchecked((int)(0x80028016));

        [NativeTypeName("#define TYPE_E_FIELDNOTFOUND _HRESULT_TYPEDEF_(0x80028017L)")]
        public const int TYPE_E_FIELDNOTFOUND = unchecked((int)(0x80028017));

        [NativeTypeName("#define TYPE_E_INVDATAREAD _HRESULT_TYPEDEF_(0x80028018L)")]
        public const int TYPE_E_INVDATAREAD = unchecked((int)(0x80028018));

        [NativeTypeName("#define TYPE_E_UNSUPFORMAT _HRESULT_TYPEDEF_(0x80028019L)")]
        public const int TYPE_E_UNSUPFORMAT = unchecked((int)(0x80028019));

        [NativeTypeName("#define TYPE_E_REGISTRYACCESS _HRESULT_TYPEDEF_(0x8002801CL)")]
        public const int TYPE_E_REGISTRYACCESS = unchecked((int)(0x8002801C));

        [NativeTypeName("#define TYPE_E_LIBNOTREGISTERED _HRESULT_TYPEDEF_(0x8002801DL)")]
        public const int TYPE_E_LIBNOTREGISTERED = unchecked((int)(0x8002801D));

        [NativeTypeName("#define TYPE_E_UNDEFINEDTYPE _HRESULT_TYPEDEF_(0x80028027L)")]
        public const int TYPE_E_UNDEFINEDTYPE = unchecked((int)(0x80028027));

        [NativeTypeName("#define TYPE_E_QUALIFIEDNAMEDISALLOWED _HRESULT_TYPEDEF_(0x80028028L)")]
        public const int TYPE_E_QUALIFIEDNAMEDISALLOWED = unchecked((int)(0x80028028));

        [NativeTypeName("#define TYPE_E_INVALIDSTATE _HRESULT_TYPEDEF_(0x80028029L)")]
        public const int TYPE_E_INVALIDSTATE = unchecked((int)(0x80028029));

        [NativeTypeName("#define TYPE_E_WRONGTYPEKIND _HRESULT_TYPEDEF_(0x8002802AL)")]
        public const int TYPE_E_WRONGTYPEKIND = unchecked((int)(0x8002802A));

        [NativeTypeName("#define TYPE_E_ELEMENTNOTFOUND _HRESULT_TYPEDEF_(0x8002802BL)")]
        public const int TYPE_E_ELEMENTNOTFOUND = unchecked((int)(0x8002802B));

        [NativeTypeName("#define TYPE_E_AMBIGUOUSNAME _HRESULT_TYPEDEF_(0x8002802CL)")]
        public const int TYPE_E_AMBIGUOUSNAME = unchecked((int)(0x8002802C));

        [NativeTypeName("#define TYPE_E_NAMECONFLICT _HRESULT_TYPEDEF_(0x8002802DL)")]
        public const int TYPE_E_NAMECONFLICT = unchecked((int)(0x8002802D));

        [NativeTypeName("#define TYPE_E_UNKNOWNLCID _HRESULT_TYPEDEF_(0x8002802EL)")]
        public const int TYPE_E_UNKNOWNLCID = unchecked((int)(0x8002802E));

        [NativeTypeName("#define TYPE_E_DLLFUNCTIONNOTFOUND _HRESULT_TYPEDEF_(0x8002802FL)")]
        public const int TYPE_E_DLLFUNCTIONNOTFOUND = unchecked((int)(0x8002802F));

        [NativeTypeName("#define TYPE_E_BADMODULEKIND _HRESULT_TYPEDEF_(0x800288BDL)")]
        public const int TYPE_E_BADMODULEKIND = unchecked((int)(0x800288BD));

        [NativeTypeName("#define TYPE_E_SIZETOOBIG _HRESULT_TYPEDEF_(0x800288C5L)")]
        public const int TYPE_E_SIZETOOBIG = unchecked((int)(0x800288C5));

        [NativeTypeName("#define TYPE_E_DUPLICATEID _HRESULT_TYPEDEF_(0x800288C6L)")]
        public const int TYPE_E_DUPLICATEID = unchecked((int)(0x800288C6));

        [NativeTypeName("#define TYPE_E_INVALIDID _HRESULT_TYPEDEF_(0x800288CFL)")]
        public const int TYPE_E_INVALIDID = unchecked((int)(0x800288CF));

        [NativeTypeName("#define TYPE_E_TYPEMISMATCH _HRESULT_TYPEDEF_(0x80028CA0L)")]
        public const int TYPE_E_TYPEMISMATCH = unchecked((int)(0x80028CA0));

        [NativeTypeName("#define TYPE_E_OUTOFBOUNDS _HRESULT_TYPEDEF_(0x80028CA1L)")]
        public const int TYPE_E_OUTOFBOUNDS = unchecked((int)(0x80028CA1));

        [NativeTypeName("#define TYPE_E_IOERROR _HRESULT_TYPEDEF_(0x80028CA2L)")]
        public const int TYPE_E_IOERROR = unchecked((int)(0x80028CA2));

        [NativeTypeName("#define TYPE_E_CANTCREATETMPFILE _HRESULT_TYPEDEF_(0x80028CA3L)")]
        public const int TYPE_E_CANTCREATETMPFILE = unchecked((int)(0x80028CA3));

        [NativeTypeName("#define TYPE_E_CANTLOADLIBRARY _HRESULT_TYPEDEF_(0x80029C4AL)")]
        public const int TYPE_E_CANTLOADLIBRARY = unchecked((int)(0x80029C4A));

        [NativeTypeName("#define TYPE_E_INCONSISTENTPROPFUNCS _HRESULT_TYPEDEF_(0x80029C83L)")]
        public const int TYPE_E_INCONSISTENTPROPFUNCS = unchecked((int)(0x80029C83));

        [NativeTypeName("#define TYPE_E_CIRCULARTYPE _HRESULT_TYPEDEF_(0x80029C84L)")]
        public const int TYPE_E_CIRCULARTYPE = unchecked((int)(0x80029C84));

        [NativeTypeName("#define STG_E_INVALIDFUNCTION _HRESULT_TYPEDEF_(0x80030001L)")]
        public const int STG_E_INVALIDFUNCTION = unchecked((int)(0x80030001));

        [NativeTypeName("#define STG_E_FILENOTFOUND _HRESULT_TYPEDEF_(0x80030002L)")]
        public const int STG_E_FILENOTFOUND = unchecked((int)(0x80030002));

        [NativeTypeName("#define STG_E_PATHNOTFOUND _HRESULT_TYPEDEF_(0x80030003L)")]
        public const int STG_E_PATHNOTFOUND = unchecked((int)(0x80030003));

        [NativeTypeName("#define STG_E_TOOMANYOPENFILES _HRESULT_TYPEDEF_(0x80030004L)")]
        public const int STG_E_TOOMANYOPENFILES = unchecked((int)(0x80030004));

        [NativeTypeName("#define STG_E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80030005L)")]
        public const int STG_E_ACCESSDENIED = unchecked((int)(0x80030005));

        [NativeTypeName("#define STG_E_INVALIDHANDLE _HRESULT_TYPEDEF_(0x80030006L)")]
        public const int STG_E_INVALIDHANDLE = unchecked((int)(0x80030006));

        [NativeTypeName("#define STG_E_INSUFFICIENTMEMORY _HRESULT_TYPEDEF_(0x80030008L)")]
        public const int STG_E_INSUFFICIENTMEMORY = unchecked((int)(0x80030008));

        [NativeTypeName("#define STG_E_INVALIDPOINTER _HRESULT_TYPEDEF_(0x80030009L)")]
        public const int STG_E_INVALIDPOINTER = unchecked((int)(0x80030009));

        [NativeTypeName("#define STG_E_NOMOREFILES _HRESULT_TYPEDEF_(0x80030012L)")]
        public const int STG_E_NOMOREFILES = unchecked((int)(0x80030012));

        [NativeTypeName("#define STG_E_DISKISWRITEPROTECTED _HRESULT_TYPEDEF_(0x80030013L)")]
        public const int STG_E_DISKISWRITEPROTECTED = unchecked((int)(0x80030013));

        [NativeTypeName("#define STG_E_SEEKERROR _HRESULT_TYPEDEF_(0x80030019L)")]
        public const int STG_E_SEEKERROR = unchecked((int)(0x80030019));

        [NativeTypeName("#define STG_E_WRITEFAULT _HRESULT_TYPEDEF_(0x8003001DL)")]
        public const int STG_E_WRITEFAULT = unchecked((int)(0x8003001D));

        [NativeTypeName("#define STG_E_READFAULT _HRESULT_TYPEDEF_(0x8003001EL)")]
        public const int STG_E_READFAULT = unchecked((int)(0x8003001E));

        [NativeTypeName("#define STG_E_SHAREVIOLATION _HRESULT_TYPEDEF_(0x80030020L)")]
        public const int STG_E_SHAREVIOLATION = unchecked((int)(0x80030020));

        [NativeTypeName("#define STG_E_LOCKVIOLATION _HRESULT_TYPEDEF_(0x80030021L)")]
        public const int STG_E_LOCKVIOLATION = unchecked((int)(0x80030021));

        [NativeTypeName("#define STG_E_FILEALREADYEXISTS _HRESULT_TYPEDEF_(0x80030050L)")]
        public const int STG_E_FILEALREADYEXISTS = unchecked((int)(0x80030050));

        [NativeTypeName("#define STG_E_INVALIDPARAMETER _HRESULT_TYPEDEF_(0x80030057L)")]
        public const int STG_E_INVALIDPARAMETER = unchecked((int)(0x80030057));

        [NativeTypeName("#define STG_E_MEDIUMFULL _HRESULT_TYPEDEF_(0x80030070L)")]
        public const int STG_E_MEDIUMFULL = unchecked((int)(0x80030070));

        [NativeTypeName("#define STG_E_PROPSETMISMATCHED _HRESULT_TYPEDEF_(0x800300F0L)")]
        public const int STG_E_PROPSETMISMATCHED = unchecked((int)(0x800300F0));

        [NativeTypeName("#define STG_E_ABNORMALAPIEXIT _HRESULT_TYPEDEF_(0x800300FAL)")]
        public const int STG_E_ABNORMALAPIEXIT = unchecked((int)(0x800300FA));

        [NativeTypeName("#define STG_E_INVALIDHEADER _HRESULT_TYPEDEF_(0x800300FBL)")]
        public const int STG_E_INVALIDHEADER = unchecked((int)(0x800300FB));

        [NativeTypeName("#define STG_E_INVALIDNAME _HRESULT_TYPEDEF_(0x800300FCL)")]
        public const int STG_E_INVALIDNAME = unchecked((int)(0x800300FC));

        [NativeTypeName("#define STG_E_UNKNOWN _HRESULT_TYPEDEF_(0x800300FDL)")]
        public const int STG_E_UNKNOWN = unchecked((int)(0x800300FD));

        [NativeTypeName("#define STG_E_UNIMPLEMENTEDFUNCTION _HRESULT_TYPEDEF_(0x800300FEL)")]
        public const int STG_E_UNIMPLEMENTEDFUNCTION = unchecked((int)(0x800300FE));

        [NativeTypeName("#define STG_E_INVALIDFLAG _HRESULT_TYPEDEF_(0x800300FFL)")]
        public const int STG_E_INVALIDFLAG = unchecked((int)(0x800300FF));

        [NativeTypeName("#define STG_E_INUSE _HRESULT_TYPEDEF_(0x80030100L)")]
        public const int STG_E_INUSE = unchecked((int)(0x80030100));

        [NativeTypeName("#define STG_E_NOTCURRENT _HRESULT_TYPEDEF_(0x80030101L)")]
        public const int STG_E_NOTCURRENT = unchecked((int)(0x80030101));

        [NativeTypeName("#define STG_E_REVERTED _HRESULT_TYPEDEF_(0x80030102L)")]
        public const int STG_E_REVERTED = unchecked((int)(0x80030102));

        [NativeTypeName("#define STG_E_CANTSAVE _HRESULT_TYPEDEF_(0x80030103L)")]
        public const int STG_E_CANTSAVE = unchecked((int)(0x80030103));

        [NativeTypeName("#define STG_E_OLDFORMAT _HRESULT_TYPEDEF_(0x80030104L)")]
        public const int STG_E_OLDFORMAT = unchecked((int)(0x80030104));

        [NativeTypeName("#define STG_E_OLDDLL _HRESULT_TYPEDEF_(0x80030105L)")]
        public const int STG_E_OLDDLL = unchecked((int)(0x80030105));

        [NativeTypeName("#define STG_E_SHAREREQUIRED _HRESULT_TYPEDEF_(0x80030106L)")]
        public const int STG_E_SHAREREQUIRED = unchecked((int)(0x80030106));

        [NativeTypeName("#define STG_E_NOTFILEBASEDSTORAGE _HRESULT_TYPEDEF_(0x80030107L)")]
        public const int STG_E_NOTFILEBASEDSTORAGE = unchecked((int)(0x80030107));

        [NativeTypeName("#define STG_E_EXTANTMARSHALLINGS _HRESULT_TYPEDEF_(0x80030108L)")]
        public const int STG_E_EXTANTMARSHALLINGS = unchecked((int)(0x80030108));

        [NativeTypeName("#define STG_E_DOCFILECORRUPT _HRESULT_TYPEDEF_(0x80030109L)")]
        public const int STG_E_DOCFILECORRUPT = unchecked((int)(0x80030109));

        [NativeTypeName("#define STG_E_BADBASEADDRESS _HRESULT_TYPEDEF_(0x80030110L)")]
        public const int STG_E_BADBASEADDRESS = unchecked((int)(0x80030110));

        [NativeTypeName("#define STG_E_DOCFILETOOLARGE _HRESULT_TYPEDEF_(0x80030111L)")]
        public const int STG_E_DOCFILETOOLARGE = unchecked((int)(0x80030111));

        [NativeTypeName("#define STG_E_NOTSIMPLEFORMAT _HRESULT_TYPEDEF_(0x80030112L)")]
        public const int STG_E_NOTSIMPLEFORMAT = unchecked((int)(0x80030112));

        [NativeTypeName("#define STG_E_INCOMPLETE _HRESULT_TYPEDEF_(0x80030201L)")]
        public const int STG_E_INCOMPLETE = unchecked((int)(0x80030201));

        [NativeTypeName("#define STG_E_TERMINATED _HRESULT_TYPEDEF_(0x80030202L)")]
        public const int STG_E_TERMINATED = unchecked((int)(0x80030202));

        [NativeTypeName("#define STG_S_CONVERTED _HRESULT_TYPEDEF_(0x00030200L)")]
        public const int STG_S_CONVERTED = ((int)(0x00030200));

        [NativeTypeName("#define STG_S_BLOCK _HRESULT_TYPEDEF_(0x00030201L)")]
        public const int STG_S_BLOCK = ((int)(0x00030201));

        [NativeTypeName("#define STG_S_RETRYNOW _HRESULT_TYPEDEF_(0x00030202L)")]
        public const int STG_S_RETRYNOW = ((int)(0x00030202));

        [NativeTypeName("#define STG_S_MONITORING _HRESULT_TYPEDEF_(0x00030203L)")]
        public const int STG_S_MONITORING = ((int)(0x00030203));

        [NativeTypeName("#define STG_S_MULTIPLEOPENS _HRESULT_TYPEDEF_(0x00030204L)")]
        public const int STG_S_MULTIPLEOPENS = ((int)(0x00030204));

        [NativeTypeName("#define STG_S_CONSOLIDATIONFAILED _HRESULT_TYPEDEF_(0x00030205L)")]
        public const int STG_S_CONSOLIDATIONFAILED = ((int)(0x00030205));

        [NativeTypeName("#define STG_S_CANNOTCONSOLIDATE _HRESULT_TYPEDEF_(0x00030206L)")]
        public const int STG_S_CANNOTCONSOLIDATE = ((int)(0x00030206));

        [NativeTypeName("#define STG_S_POWER_CYCLE_REQUIRED _HRESULT_TYPEDEF_(0x00030207L)")]
        public const int STG_S_POWER_CYCLE_REQUIRED = ((int)(0x00030207));

        [NativeTypeName("#define STG_E_FIRMWARE_SLOT_INVALID _HRESULT_TYPEDEF_(0x80030208L)")]
        public const int STG_E_FIRMWARE_SLOT_INVALID = unchecked((int)(0x80030208));

        [NativeTypeName("#define STG_E_FIRMWARE_IMAGE_INVALID _HRESULT_TYPEDEF_(0x80030209L)")]
        public const int STG_E_FIRMWARE_IMAGE_INVALID = unchecked((int)(0x80030209));

        [NativeTypeName("#define STG_E_DEVICE_UNRESPONSIVE _HRESULT_TYPEDEF_(0x8003020AL)")]
        public const int STG_E_DEVICE_UNRESPONSIVE = unchecked((int)(0x8003020A));

        [NativeTypeName("#define STG_E_STATUS_COPY_PROTECTION_FAILURE _HRESULT_TYPEDEF_(0x80030305L)")]
        public const int STG_E_STATUS_COPY_PROTECTION_FAILURE = unchecked((int)(0x80030305));

        [NativeTypeName("#define STG_E_CSS_AUTHENTICATION_FAILURE _HRESULT_TYPEDEF_(0x80030306L)")]
        public const int STG_E_CSS_AUTHENTICATION_FAILURE = unchecked((int)(0x80030306));

        [NativeTypeName("#define STG_E_CSS_KEY_NOT_PRESENT _HRESULT_TYPEDEF_(0x80030307L)")]
        public const int STG_E_CSS_KEY_NOT_PRESENT = unchecked((int)(0x80030307));

        [NativeTypeName("#define STG_E_CSS_KEY_NOT_ESTABLISHED _HRESULT_TYPEDEF_(0x80030308L)")]
        public const int STG_E_CSS_KEY_NOT_ESTABLISHED = unchecked((int)(0x80030308));

        [NativeTypeName("#define STG_E_CSS_SCRAMBLED_SECTOR _HRESULT_TYPEDEF_(0x80030309L)")]
        public const int STG_E_CSS_SCRAMBLED_SECTOR = unchecked((int)(0x80030309));

        [NativeTypeName("#define STG_E_CSS_REGION_MISMATCH _HRESULT_TYPEDEF_(0x8003030AL)")]
        public const int STG_E_CSS_REGION_MISMATCH = unchecked((int)(0x8003030A));

        [NativeTypeName("#define STG_E_RESETS_EXHAUSTED _HRESULT_TYPEDEF_(0x8003030BL)")]
        public const int STG_E_RESETS_EXHAUSTED = unchecked((int)(0x8003030B));

        [NativeTypeName("#define NTE_BAD_UID _HRESULT_TYPEDEF_(0x80090001L)")]
        public const int NTE_BAD_UID = unchecked((int)(0x80090001));

        [NativeTypeName("#define NTE_BAD_HASH _HRESULT_TYPEDEF_(0x80090002L)")]
        public const int NTE_BAD_HASH = unchecked((int)(0x80090002));

        [NativeTypeName("#define NTE_BAD_KEY _HRESULT_TYPEDEF_(0x80090003L)")]
        public const int NTE_BAD_KEY = unchecked((int)(0x80090003));

        [NativeTypeName("#define NTE_BAD_LEN _HRESULT_TYPEDEF_(0x80090004L)")]
        public const int NTE_BAD_LEN = unchecked((int)(0x80090004));

        [NativeTypeName("#define NTE_BAD_DATA _HRESULT_TYPEDEF_(0x80090005L)")]
        public const int NTE_BAD_DATA = unchecked((int)(0x80090005));

        [NativeTypeName("#define NTE_BAD_SIGNATURE _HRESULT_TYPEDEF_(0x80090006L)")]
        public const int NTE_BAD_SIGNATURE = unchecked((int)(0x80090006));

        [NativeTypeName("#define NTE_BAD_VER _HRESULT_TYPEDEF_(0x80090007L)")]
        public const int NTE_BAD_VER = unchecked((int)(0x80090007));

        [NativeTypeName("#define NTE_BAD_ALGID _HRESULT_TYPEDEF_(0x80090008L)")]
        public const int NTE_BAD_ALGID = unchecked((int)(0x80090008));

        [NativeTypeName("#define NTE_BAD_FLAGS _HRESULT_TYPEDEF_(0x80090009L)")]
        public const int NTE_BAD_FLAGS = unchecked((int)(0x80090009));

        [NativeTypeName("#define NTE_BAD_TYPE _HRESULT_TYPEDEF_(0x8009000AL)")]
        public const int NTE_BAD_TYPE = unchecked((int)(0x8009000A));

        [NativeTypeName("#define NTE_BAD_KEY_STATE _HRESULT_TYPEDEF_(0x8009000BL)")]
        public const int NTE_BAD_KEY_STATE = unchecked((int)(0x8009000B));

        [NativeTypeName("#define NTE_BAD_HASH_STATE _HRESULT_TYPEDEF_(0x8009000CL)")]
        public const int NTE_BAD_HASH_STATE = unchecked((int)(0x8009000C));

        [NativeTypeName("#define NTE_NO_KEY _HRESULT_TYPEDEF_(0x8009000DL)")]
        public const int NTE_NO_KEY = unchecked((int)(0x8009000D));

        [NativeTypeName("#define NTE_NO_MEMORY _HRESULT_TYPEDEF_(0x8009000EL)")]
        public const int NTE_NO_MEMORY = unchecked((int)(0x8009000E));

        [NativeTypeName("#define NTE_EXISTS _HRESULT_TYPEDEF_(0x8009000FL)")]
        public const int NTE_EXISTS = unchecked((int)(0x8009000F));

        [NativeTypeName("#define NTE_PERM _HRESULT_TYPEDEF_(0x80090010L)")]
        public const int NTE_PERM = unchecked((int)(0x80090010));

        [NativeTypeName("#define NTE_NOT_FOUND _HRESULT_TYPEDEF_(0x80090011L)")]
        public const int NTE_NOT_FOUND = unchecked((int)(0x80090011));

        [NativeTypeName("#define NTE_DOUBLE_ENCRYPT _HRESULT_TYPEDEF_(0x80090012L)")]
        public const int NTE_DOUBLE_ENCRYPT = unchecked((int)(0x80090012));

        [NativeTypeName("#define NTE_BAD_PROVIDER _HRESULT_TYPEDEF_(0x80090013L)")]
        public const int NTE_BAD_PROVIDER = unchecked((int)(0x80090013));

        [NativeTypeName("#define NTE_BAD_PROV_TYPE _HRESULT_TYPEDEF_(0x80090014L)")]
        public const int NTE_BAD_PROV_TYPE = unchecked((int)(0x80090014));

        [NativeTypeName("#define NTE_BAD_PUBLIC_KEY _HRESULT_TYPEDEF_(0x80090015L)")]
        public const int NTE_BAD_PUBLIC_KEY = unchecked((int)(0x80090015));

        [NativeTypeName("#define NTE_BAD_KEYSET _HRESULT_TYPEDEF_(0x80090016L)")]
        public const int NTE_BAD_KEYSET = unchecked((int)(0x80090016));

        [NativeTypeName("#define NTE_PROV_TYPE_NOT_DEF _HRESULT_TYPEDEF_(0x80090017L)")]
        public const int NTE_PROV_TYPE_NOT_DEF = unchecked((int)(0x80090017));

        [NativeTypeName("#define NTE_PROV_TYPE_ENTRY_BAD _HRESULT_TYPEDEF_(0x80090018L)")]
        public const int NTE_PROV_TYPE_ENTRY_BAD = unchecked((int)(0x80090018));

        [NativeTypeName("#define NTE_KEYSET_NOT_DEF _HRESULT_TYPEDEF_(0x80090019L)")]
        public const int NTE_KEYSET_NOT_DEF = unchecked((int)(0x80090019));

        [NativeTypeName("#define NTE_KEYSET_ENTRY_BAD _HRESULT_TYPEDEF_(0x8009001AL)")]
        public const int NTE_KEYSET_ENTRY_BAD = unchecked((int)(0x8009001A));

        [NativeTypeName("#define NTE_PROV_TYPE_NO_MATCH _HRESULT_TYPEDEF_(0x8009001BL)")]
        public const int NTE_PROV_TYPE_NO_MATCH = unchecked((int)(0x8009001B));

        [NativeTypeName("#define NTE_SIGNATURE_FILE_BAD _HRESULT_TYPEDEF_(0x8009001CL)")]
        public const int NTE_SIGNATURE_FILE_BAD = unchecked((int)(0x8009001C));

        [NativeTypeName("#define NTE_PROVIDER_DLL_FAIL _HRESULT_TYPEDEF_(0x8009001DL)")]
        public const int NTE_PROVIDER_DLL_FAIL = unchecked((int)(0x8009001D));

        [NativeTypeName("#define NTE_PROV_DLL_NOT_FOUND _HRESULT_TYPEDEF_(0x8009001EL)")]
        public const int NTE_PROV_DLL_NOT_FOUND = unchecked((int)(0x8009001E));

        [NativeTypeName("#define NTE_BAD_KEYSET_PARAM _HRESULT_TYPEDEF_(0x8009001FL)")]
        public const int NTE_BAD_KEYSET_PARAM = unchecked((int)(0x8009001F));

        [NativeTypeName("#define NTE_FAIL _HRESULT_TYPEDEF_(0x80090020L)")]
        public const int NTE_FAIL = unchecked((int)(0x80090020));

        [NativeTypeName("#define NTE_SYS_ERR _HRESULT_TYPEDEF_(0x80090021L)")]
        public const int NTE_SYS_ERR = unchecked((int)(0x80090021));

        [NativeTypeName("#define NTE_SILENT_CONTEXT _HRESULT_TYPEDEF_(0x80090022L)")]
        public const int NTE_SILENT_CONTEXT = unchecked((int)(0x80090022));

        [NativeTypeName("#define NTE_TOKEN_KEYSET_STORAGE_FULL _HRESULT_TYPEDEF_(0x80090023L)")]
        public const int NTE_TOKEN_KEYSET_STORAGE_FULL = unchecked((int)(0x80090023));

        [NativeTypeName("#define NTE_TEMPORARY_PROFILE _HRESULT_TYPEDEF_(0x80090024L)")]
        public const int NTE_TEMPORARY_PROFILE = unchecked((int)(0x80090024));

        [NativeTypeName("#define NTE_FIXEDPARAMETER _HRESULT_TYPEDEF_(0x80090025L)")]
        public const int NTE_FIXEDPARAMETER = unchecked((int)(0x80090025));

        [NativeTypeName("#define NTE_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80090026L)")]
        public const int NTE_INVALID_HANDLE = unchecked((int)(0x80090026));

        [NativeTypeName("#define NTE_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80090027L)")]
        public const int NTE_INVALID_PARAMETER = unchecked((int)(0x80090027));

        [NativeTypeName("#define NTE_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80090028L)")]
        public const int NTE_BUFFER_TOO_SMALL = unchecked((int)(0x80090028));

        [NativeTypeName("#define NTE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80090029L)")]
        public const int NTE_NOT_SUPPORTED = unchecked((int)(0x80090029));

        [NativeTypeName("#define NTE_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x8009002AL)")]
        public const int NTE_NO_MORE_ITEMS = unchecked((int)(0x8009002A));

        [NativeTypeName("#define NTE_BUFFERS_OVERLAP _HRESULT_TYPEDEF_(0x8009002BL)")]
        public const int NTE_BUFFERS_OVERLAP = unchecked((int)(0x8009002B));

        [NativeTypeName("#define NTE_DECRYPTION_FAILURE _HRESULT_TYPEDEF_(0x8009002CL)")]
        public const int NTE_DECRYPTION_FAILURE = unchecked((int)(0x8009002C));

        [NativeTypeName("#define NTE_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x8009002DL)")]
        public const int NTE_INTERNAL_ERROR = unchecked((int)(0x8009002D));

        [NativeTypeName("#define NTE_UI_REQUIRED _HRESULT_TYPEDEF_(0x8009002EL)")]
        public const int NTE_UI_REQUIRED = unchecked((int)(0x8009002E));

        [NativeTypeName("#define NTE_HMAC_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009002FL)")]
        public const int NTE_HMAC_NOT_SUPPORTED = unchecked((int)(0x8009002F));

        [NativeTypeName("#define NTE_DEVICE_NOT_READY _HRESULT_TYPEDEF_(0x80090030L)")]
        public const int NTE_DEVICE_NOT_READY = unchecked((int)(0x80090030));

        [NativeTypeName("#define NTE_AUTHENTICATION_IGNORED _HRESULT_TYPEDEF_(0x80090031L)")]
        public const int NTE_AUTHENTICATION_IGNORED = unchecked((int)(0x80090031));

        [NativeTypeName("#define NTE_VALIDATION_FAILED _HRESULT_TYPEDEF_(0x80090032L)")]
        public const int NTE_VALIDATION_FAILED = unchecked((int)(0x80090032));

        [NativeTypeName("#define NTE_INCORRECT_PASSWORD _HRESULT_TYPEDEF_(0x80090033L)")]
        public const int NTE_INCORRECT_PASSWORD = unchecked((int)(0x80090033));

        [NativeTypeName("#define NTE_ENCRYPTION_FAILURE _HRESULT_TYPEDEF_(0x80090034L)")]
        public const int NTE_ENCRYPTION_FAILURE = unchecked((int)(0x80090034));

        [NativeTypeName("#define NTE_DEVICE_NOT_FOUND _HRESULT_TYPEDEF_(0x80090035L)")]
        public const int NTE_DEVICE_NOT_FOUND = unchecked((int)(0x80090035));

        [NativeTypeName("#define NTE_USER_CANCELLED _HRESULT_TYPEDEF_(0x80090036L)")]
        public const int NTE_USER_CANCELLED = unchecked((int)(0x80090036));

        [NativeTypeName("#define NTE_PASSWORD_CHANGE_REQUIRED _HRESULT_TYPEDEF_(0x80090037L)")]
        public const int NTE_PASSWORD_CHANGE_REQUIRED = unchecked((int)(0x80090037));

        [NativeTypeName("#define NTE_NOT_ACTIVE_CONSOLE _HRESULT_TYPEDEF_(0x80090038L)")]
        public const int NTE_NOT_ACTIVE_CONSOLE = unchecked((int)(0x80090038));

        [NativeTypeName("#define SEC_E_INSUFFICIENT_MEMORY _HRESULT_TYPEDEF_(0x80090300L)")]
        public const int SEC_E_INSUFFICIENT_MEMORY = unchecked((int)(0x80090300));

        [NativeTypeName("#define SEC_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80090301L)")]
        public const int SEC_E_INVALID_HANDLE = unchecked((int)(0x80090301));

        [NativeTypeName("#define SEC_E_UNSUPPORTED_FUNCTION _HRESULT_TYPEDEF_(0x80090302L)")]
        public const int SEC_E_UNSUPPORTED_FUNCTION = unchecked((int)(0x80090302));

        [NativeTypeName("#define SEC_E_TARGET_UNKNOWN _HRESULT_TYPEDEF_(0x80090303L)")]
        public const int SEC_E_TARGET_UNKNOWN = unchecked((int)(0x80090303));

        [NativeTypeName("#define SEC_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80090304L)")]
        public const int SEC_E_INTERNAL_ERROR = unchecked((int)(0x80090304));

        [NativeTypeName("#define SEC_E_SECPKG_NOT_FOUND _HRESULT_TYPEDEF_(0x80090305L)")]
        public const int SEC_E_SECPKG_NOT_FOUND = unchecked((int)(0x80090305));

        [NativeTypeName("#define SEC_E_NOT_OWNER _HRESULT_TYPEDEF_(0x80090306L)")]
        public const int SEC_E_NOT_OWNER = unchecked((int)(0x80090306));

        [NativeTypeName("#define SEC_E_CANNOT_INSTALL _HRESULT_TYPEDEF_(0x80090307L)")]
        public const int SEC_E_CANNOT_INSTALL = unchecked((int)(0x80090307));

        [NativeTypeName("#define SEC_E_INVALID_TOKEN _HRESULT_TYPEDEF_(0x80090308L)")]
        public const int SEC_E_INVALID_TOKEN = unchecked((int)(0x80090308));

        [NativeTypeName("#define SEC_E_CANNOT_PACK _HRESULT_TYPEDEF_(0x80090309L)")]
        public const int SEC_E_CANNOT_PACK = unchecked((int)(0x80090309));

        [NativeTypeName("#define SEC_E_QOP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009030AL)")]
        public const int SEC_E_QOP_NOT_SUPPORTED = unchecked((int)(0x8009030A));

        [NativeTypeName("#define SEC_E_NO_IMPERSONATION _HRESULT_TYPEDEF_(0x8009030BL)")]
        public const int SEC_E_NO_IMPERSONATION = unchecked((int)(0x8009030B));

        [NativeTypeName("#define SEC_E_LOGON_DENIED _HRESULT_TYPEDEF_(0x8009030CL)")]
        public const int SEC_E_LOGON_DENIED = unchecked((int)(0x8009030C));

        [NativeTypeName("#define SEC_E_UNKNOWN_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030DL)")]
        public const int SEC_E_UNKNOWN_CREDENTIALS = unchecked((int)(0x8009030D));

        [NativeTypeName("#define SEC_E_NO_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030EL)")]
        public const int SEC_E_NO_CREDENTIALS = unchecked((int)(0x8009030E));

        [NativeTypeName("#define SEC_E_MESSAGE_ALTERED _HRESULT_TYPEDEF_(0x8009030FL)")]
        public const int SEC_E_MESSAGE_ALTERED = unchecked((int)(0x8009030F));

        [NativeTypeName("#define SEC_E_OUT_OF_SEQUENCE _HRESULT_TYPEDEF_(0x80090310L)")]
        public const int SEC_E_OUT_OF_SEQUENCE = unchecked((int)(0x80090310));

        [NativeTypeName("#define SEC_E_NO_AUTHENTICATING_AUTHORITY _HRESULT_TYPEDEF_(0x80090311L)")]
        public const int SEC_E_NO_AUTHENTICATING_AUTHORITY = unchecked((int)(0x80090311));

        [NativeTypeName("#define SEC_I_CONTINUE_NEEDED _HRESULT_TYPEDEF_(0x00090312L)")]
        public const int SEC_I_CONTINUE_NEEDED = ((int)(0x00090312));

        [NativeTypeName("#define SEC_I_COMPLETE_NEEDED _HRESULT_TYPEDEF_(0x00090313L)")]
        public const int SEC_I_COMPLETE_NEEDED = ((int)(0x00090313));

        [NativeTypeName("#define SEC_I_COMPLETE_AND_CONTINUE _HRESULT_TYPEDEF_(0x00090314L)")]
        public const int SEC_I_COMPLETE_AND_CONTINUE = ((int)(0x00090314));

        [NativeTypeName("#define SEC_I_LOCAL_LOGON _HRESULT_TYPEDEF_(0x00090315L)")]
        public const int SEC_I_LOCAL_LOGON = ((int)(0x00090315));

        [NativeTypeName("#define SEC_I_GENERIC_EXTENSION_RECEIVED _HRESULT_TYPEDEF_(0x00090316L)")]
        public const int SEC_I_GENERIC_EXTENSION_RECEIVED = ((int)(0x00090316));

        [NativeTypeName("#define SEC_E_BAD_PKGID _HRESULT_TYPEDEF_(0x80090316L)")]
        public const int SEC_E_BAD_PKGID = unchecked((int)(0x80090316));

        [NativeTypeName("#define SEC_E_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x80090317L)")]
        public const int SEC_E_CONTEXT_EXPIRED = unchecked((int)(0x80090317));

        [NativeTypeName("#define SEC_I_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x00090317L)")]
        public const int SEC_I_CONTEXT_EXPIRED = ((int)(0x00090317));

        [NativeTypeName("#define SEC_E_INCOMPLETE_MESSAGE _HRESULT_TYPEDEF_(0x80090318L)")]
        public const int SEC_E_INCOMPLETE_MESSAGE = unchecked((int)(0x80090318));

        [NativeTypeName("#define SEC_E_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x80090320L)")]
        public const int SEC_E_INCOMPLETE_CREDENTIALS = unchecked((int)(0x80090320));

        [NativeTypeName("#define SEC_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80090321L)")]
        public const int SEC_E_BUFFER_TOO_SMALL = unchecked((int)(0x80090321));

        [NativeTypeName("#define SEC_I_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x00090320L)")]
        public const int SEC_I_INCOMPLETE_CREDENTIALS = ((int)(0x00090320));

        [NativeTypeName("#define SEC_I_RENEGOTIATE _HRESULT_TYPEDEF_(0x00090321L)")]
        public const int SEC_I_RENEGOTIATE = ((int)(0x00090321));

        [NativeTypeName("#define SEC_E_WRONG_PRINCIPAL _HRESULT_TYPEDEF_(0x80090322L)")]
        public const int SEC_E_WRONG_PRINCIPAL = unchecked((int)(0x80090322));

        [NativeTypeName("#define SEC_I_NO_LSA_CONTEXT _HRESULT_TYPEDEF_(0x00090323L)")]
        public const int SEC_I_NO_LSA_CONTEXT = ((int)(0x00090323));

        [NativeTypeName("#define SEC_E_TIME_SKEW _HRESULT_TYPEDEF_(0x80090324L)")]
        public const int SEC_E_TIME_SKEW = unchecked((int)(0x80090324));

        [NativeTypeName("#define SEC_E_UNTRUSTED_ROOT _HRESULT_TYPEDEF_(0x80090325L)")]
        public const int SEC_E_UNTRUSTED_ROOT = unchecked((int)(0x80090325));

        [NativeTypeName("#define SEC_E_ILLEGAL_MESSAGE _HRESULT_TYPEDEF_(0x80090326L)")]
        public const int SEC_E_ILLEGAL_MESSAGE = unchecked((int)(0x80090326));

        [NativeTypeName("#define SEC_E_CERT_UNKNOWN _HRESULT_TYPEDEF_(0x80090327L)")]
        public const int SEC_E_CERT_UNKNOWN = unchecked((int)(0x80090327));

        [NativeTypeName("#define SEC_E_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090328L)")]
        public const int SEC_E_CERT_EXPIRED = unchecked((int)(0x80090328));

        [NativeTypeName("#define SEC_E_ENCRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090329L)")]
        public const int SEC_E_ENCRYPT_FAILURE = unchecked((int)(0x80090329));

        [NativeTypeName("#define SEC_E_DECRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090330L)")]
        public const int SEC_E_DECRYPT_FAILURE = unchecked((int)(0x80090330));

        [NativeTypeName("#define SEC_E_ALGORITHM_MISMATCH _HRESULT_TYPEDEF_(0x80090331L)")]
        public const int SEC_E_ALGORITHM_MISMATCH = unchecked((int)(0x80090331));

        [NativeTypeName("#define SEC_E_SECURITY_QOS_FAILED _HRESULT_TYPEDEF_(0x80090332L)")]
        public const int SEC_E_SECURITY_QOS_FAILED = unchecked((int)(0x80090332));

        [NativeTypeName("#define SEC_E_UNFINISHED_CONTEXT_DELETED _HRESULT_TYPEDEF_(0x80090333L)")]
        public const int SEC_E_UNFINISHED_CONTEXT_DELETED = unchecked((int)(0x80090333));

        [NativeTypeName("#define SEC_E_NO_TGT_REPLY _HRESULT_TYPEDEF_(0x80090334L)")]
        public const int SEC_E_NO_TGT_REPLY = unchecked((int)(0x80090334));

        [NativeTypeName("#define SEC_E_NO_IP_ADDRESSES _HRESULT_TYPEDEF_(0x80090335L)")]
        public const int SEC_E_NO_IP_ADDRESSES = unchecked((int)(0x80090335));

        [NativeTypeName("#define SEC_E_WRONG_CREDENTIAL_HANDLE _HRESULT_TYPEDEF_(0x80090336L)")]
        public const int SEC_E_WRONG_CREDENTIAL_HANDLE = unchecked((int)(0x80090336));

        [NativeTypeName("#define SEC_E_CRYPTO_SYSTEM_INVALID _HRESULT_TYPEDEF_(0x80090337L)")]
        public const int SEC_E_CRYPTO_SYSTEM_INVALID = unchecked((int)(0x80090337));

        [NativeTypeName("#define SEC_E_MAX_REFERRALS_EXCEEDED _HRESULT_TYPEDEF_(0x80090338L)")]
        public const int SEC_E_MAX_REFERRALS_EXCEEDED = unchecked((int)(0x80090338));

        [NativeTypeName("#define SEC_E_MUST_BE_KDC _HRESULT_TYPEDEF_(0x80090339L)")]
        public const int SEC_E_MUST_BE_KDC = unchecked((int)(0x80090339));

        [NativeTypeName("#define SEC_E_STRONG_CRYPTO_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009033AL)")]
        public const int SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)(0x8009033A));

        [NativeTypeName("#define SEC_E_TOO_MANY_PRINCIPALS _HRESULT_TYPEDEF_(0x8009033BL)")]
        public const int SEC_E_TOO_MANY_PRINCIPALS = unchecked((int)(0x8009033B));

        [NativeTypeName("#define SEC_E_NO_PA_DATA _HRESULT_TYPEDEF_(0x8009033CL)")]
        public const int SEC_E_NO_PA_DATA = unchecked((int)(0x8009033C));

        [NativeTypeName("#define SEC_E_PKINIT_NAME_MISMATCH _HRESULT_TYPEDEF_(0x8009033DL)")]
        public const int SEC_E_PKINIT_NAME_MISMATCH = unchecked((int)(0x8009033D));

        [NativeTypeName("#define SEC_E_SMARTCARD_LOGON_REQUIRED _HRESULT_TYPEDEF_(0x8009033EL)")]
        public const int SEC_E_SMARTCARD_LOGON_REQUIRED = unchecked((int)(0x8009033E));

        [NativeTypeName("#define SEC_E_SHUTDOWN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8009033FL)")]
        public const int SEC_E_SHUTDOWN_IN_PROGRESS = unchecked((int)(0x8009033F));

        [NativeTypeName("#define SEC_E_KDC_INVALID_REQUEST _HRESULT_TYPEDEF_(0x80090340L)")]
        public const int SEC_E_KDC_INVALID_REQUEST = unchecked((int)(0x80090340));

        [NativeTypeName("#define SEC_E_KDC_UNABLE_TO_REFER _HRESULT_TYPEDEF_(0x80090341L)")]
        public const int SEC_E_KDC_UNABLE_TO_REFER = unchecked((int)(0x80090341));

        [NativeTypeName("#define SEC_E_KDC_UNKNOWN_ETYPE _HRESULT_TYPEDEF_(0x80090342L)")]
        public const int SEC_E_KDC_UNKNOWN_ETYPE = unchecked((int)(0x80090342));

        [NativeTypeName("#define SEC_E_UNSUPPORTED_PREAUTH _HRESULT_TYPEDEF_(0x80090343L)")]
        public const int SEC_E_UNSUPPORTED_PREAUTH = unchecked((int)(0x80090343));

        [NativeTypeName("#define SEC_E_DELEGATION_REQUIRED _HRESULT_TYPEDEF_(0x80090345L)")]
        public const int SEC_E_DELEGATION_REQUIRED = unchecked((int)(0x80090345));

        [NativeTypeName("#define SEC_E_BAD_BINDINGS _HRESULT_TYPEDEF_(0x80090346L)")]
        public const int SEC_E_BAD_BINDINGS = unchecked((int)(0x80090346));

        [NativeTypeName("#define SEC_E_MULTIPLE_ACCOUNTS _HRESULT_TYPEDEF_(0x80090347L)")]
        public const int SEC_E_MULTIPLE_ACCOUNTS = unchecked((int)(0x80090347));

        [NativeTypeName("#define SEC_E_NO_KERB_KEY _HRESULT_TYPEDEF_(0x80090348L)")]
        public const int SEC_E_NO_KERB_KEY = unchecked((int)(0x80090348));

        [NativeTypeName("#define SEC_E_CERT_WRONG_USAGE _HRESULT_TYPEDEF_(0x80090349L)")]
        public const int SEC_E_CERT_WRONG_USAGE = unchecked((int)(0x80090349));

        [NativeTypeName("#define SEC_E_DOWNGRADE_DETECTED _HRESULT_TYPEDEF_(0x80090350L)")]
        public const int SEC_E_DOWNGRADE_DETECTED = unchecked((int)(0x80090350));

        [NativeTypeName("#define SEC_E_SMARTCARD_CERT_REVOKED _HRESULT_TYPEDEF_(0x80090351L)")]
        public const int SEC_E_SMARTCARD_CERT_REVOKED = unchecked((int)(0x80090351));

        [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED _HRESULT_TYPEDEF_(0x80090352L)")]
        public const int SEC_E_ISSUING_CA_UNTRUSTED = unchecked((int)(0x80090352));

        [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_C _HRESULT_TYPEDEF_(0x80090353L)")]
        public const int SEC_E_REVOCATION_OFFLINE_C = unchecked((int)(0x80090353));

        [NativeTypeName("#define SEC_E_PKINIT_CLIENT_FAILURE _HRESULT_TYPEDEF_(0x80090354L)")]
        public const int SEC_E_PKINIT_CLIENT_FAILURE = unchecked((int)(0x80090354));

        [NativeTypeName("#define SEC_E_SMARTCARD_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090355L)")]
        public const int SEC_E_SMARTCARD_CERT_EXPIRED = unchecked((int)(0x80090355));

        [NativeTypeName("#define SEC_E_NO_S4U_PROT_SUPPORT _HRESULT_TYPEDEF_(0x80090356L)")]
        public const int SEC_E_NO_S4U_PROT_SUPPORT = unchecked((int)(0x80090356));

        [NativeTypeName("#define SEC_E_CROSSREALM_DELEGATION_FAILURE _HRESULT_TYPEDEF_(0x80090357L)")]
        public const int SEC_E_CROSSREALM_DELEGATION_FAILURE = unchecked((int)(0x80090357));

        [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_KDC _HRESULT_TYPEDEF_(0x80090358L)")]
        public const int SEC_E_REVOCATION_OFFLINE_KDC = unchecked((int)(0x80090358));

        [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED_KDC _HRESULT_TYPEDEF_(0x80090359L)")]
        public const int SEC_E_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)(0x80090359));

        [NativeTypeName("#define SEC_E_KDC_CERT_EXPIRED _HRESULT_TYPEDEF_(0x8009035AL)")]
        public const int SEC_E_KDC_CERT_EXPIRED = unchecked((int)(0x8009035A));

        [NativeTypeName("#define SEC_E_KDC_CERT_REVOKED _HRESULT_TYPEDEF_(0x8009035BL)")]
        public const int SEC_E_KDC_CERT_REVOKED = unchecked((int)(0x8009035B));

        [NativeTypeName("#define SEC_I_SIGNATURE_NEEDED _HRESULT_TYPEDEF_(0x0009035CL)")]
        public const int SEC_I_SIGNATURE_NEEDED = ((int)(0x0009035C));

        [NativeTypeName("#define SEC_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x8009035DL)")]
        public const int SEC_E_INVALID_PARAMETER = unchecked((int)(0x8009035D));

        [NativeTypeName("#define SEC_E_DELEGATION_POLICY _HRESULT_TYPEDEF_(0x8009035EL)")]
        public const int SEC_E_DELEGATION_POLICY = unchecked((int)(0x8009035E));

        [NativeTypeName("#define SEC_E_POLICY_NLTM_ONLY _HRESULT_TYPEDEF_(0x8009035FL)")]
        public const int SEC_E_POLICY_NLTM_ONLY = unchecked((int)(0x8009035F));

        [NativeTypeName("#define SEC_I_NO_RENEGOTIATION _HRESULT_TYPEDEF_(0x00090360L)")]
        public const int SEC_I_NO_RENEGOTIATION = ((int)(0x00090360));

        [NativeTypeName("#define SEC_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x80090361L)")]
        public const int SEC_E_NO_CONTEXT = unchecked((int)(0x80090361));

        [NativeTypeName("#define SEC_E_PKU2U_CERT_FAILURE _HRESULT_TYPEDEF_(0x80090362L)")]
        public const int SEC_E_PKU2U_CERT_FAILURE = unchecked((int)(0x80090362));

        [NativeTypeName("#define SEC_E_MUTUAL_AUTH_FAILED _HRESULT_TYPEDEF_(0x80090363L)")]
        public const int SEC_E_MUTUAL_AUTH_FAILED = unchecked((int)(0x80090363));

        [NativeTypeName("#define SEC_I_MESSAGE_FRAGMENT _HRESULT_TYPEDEF_(0x00090364L)")]
        public const int SEC_I_MESSAGE_FRAGMENT = ((int)(0x00090364));

        [NativeTypeName("#define SEC_E_ONLY_HTTPS_ALLOWED _HRESULT_TYPEDEF_(0x80090365L)")]
        public const int SEC_E_ONLY_HTTPS_ALLOWED = unchecked((int)(0x80090365));

        [NativeTypeName("#define SEC_I_CONTINUE_NEEDED_MESSAGE_OK _HRESULT_TYPEDEF_(0x00090366L)")]
        public const int SEC_I_CONTINUE_NEEDED_MESSAGE_OK = ((int)(0x00090366));

        [NativeTypeName("#define SEC_E_APPLICATION_PROTOCOL_MISMATCH _HRESULT_TYPEDEF_(0x80090367L)")]
        public const int SEC_E_APPLICATION_PROTOCOL_MISMATCH = unchecked((int)(0x80090367));

        [NativeTypeName("#define SEC_I_ASYNC_CALL_PENDING _HRESULT_TYPEDEF_(0x00090368L)")]
        public const int SEC_I_ASYNC_CALL_PENDING = ((int)(0x00090368));

        [NativeTypeName("#define SEC_E_INVALID_UPN_NAME _HRESULT_TYPEDEF_(0x80090369L)")]
        public const int SEC_E_INVALID_UPN_NAME = unchecked((int)(0x80090369));

        [NativeTypeName("#define SEC_E_EXT_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x8009036AL)")]
        public const int SEC_E_EXT_BUFFER_TOO_SMALL = unchecked((int)(0x8009036A));

        [NativeTypeName("#define SEC_E_INSUFFICIENT_BUFFERS _HRESULT_TYPEDEF_(0x8009036BL)")]
        public const int SEC_E_INSUFFICIENT_BUFFERS = unchecked((int)(0x8009036B));

        [NativeTypeName("#define SEC_E_NO_SPM SEC_E_INTERNAL_ERROR")]
        public const int SEC_E_NO_SPM = unchecked((int)(0x80090304));

        [NativeTypeName("#define SEC_E_NOT_SUPPORTED SEC_E_UNSUPPORTED_FUNCTION")]
        public const int SEC_E_NOT_SUPPORTED = unchecked((int)(0x80090302));

        [NativeTypeName("#define OSS_MORE_BUF _HRESULT_TYPEDEF_(0x80093001L)")]
        public const int OSS_MORE_BUF = unchecked((int)(0x80093001));

        [NativeTypeName("#define OSS_NEGATIVE_UINTEGER _HRESULT_TYPEDEF_(0x80093002L)")]
        public const int OSS_NEGATIVE_UINTEGER = unchecked((int)(0x80093002));

        [NativeTypeName("#define OSS_PDU_RANGE _HRESULT_TYPEDEF_(0x80093003L)")]
        public const int OSS_PDU_RANGE = unchecked((int)(0x80093003));

        [NativeTypeName("#define OSS_MORE_INPUT _HRESULT_TYPEDEF_(0x80093004L)")]
        public const int OSS_MORE_INPUT = unchecked((int)(0x80093004));

        [NativeTypeName("#define OSS_DATA_ERROR _HRESULT_TYPEDEF_(0x80093005L)")]
        public const int OSS_DATA_ERROR = unchecked((int)(0x80093005));

        [NativeTypeName("#define OSS_BAD_ARG _HRESULT_TYPEDEF_(0x80093006L)")]
        public const int OSS_BAD_ARG = unchecked((int)(0x80093006));

        [NativeTypeName("#define OSS_BAD_VERSION _HRESULT_TYPEDEF_(0x80093007L)")]
        public const int OSS_BAD_VERSION = unchecked((int)(0x80093007));

        [NativeTypeName("#define OSS_OUT_MEMORY _HRESULT_TYPEDEF_(0x80093008L)")]
        public const int OSS_OUT_MEMORY = unchecked((int)(0x80093008));

        [NativeTypeName("#define OSS_PDU_MISMATCH _HRESULT_TYPEDEF_(0x80093009L)")]
        public const int OSS_PDU_MISMATCH = unchecked((int)(0x80093009));

        [NativeTypeName("#define OSS_LIMITED _HRESULT_TYPEDEF_(0x8009300AL)")]
        public const int OSS_LIMITED = unchecked((int)(0x8009300A));

        [NativeTypeName("#define OSS_BAD_PTR _HRESULT_TYPEDEF_(0x8009300BL)")]
        public const int OSS_BAD_PTR = unchecked((int)(0x8009300B));

        [NativeTypeName("#define OSS_BAD_TIME _HRESULT_TYPEDEF_(0x8009300CL)")]
        public const int OSS_BAD_TIME = unchecked((int)(0x8009300C));

        [NativeTypeName("#define OSS_INDEFINITE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009300DL)")]
        public const int OSS_INDEFINITE_NOT_SUPPORTED = unchecked((int)(0x8009300D));

        [NativeTypeName("#define OSS_MEM_ERROR _HRESULT_TYPEDEF_(0x8009300EL)")]
        public const int OSS_MEM_ERROR = unchecked((int)(0x8009300E));

        [NativeTypeName("#define OSS_BAD_TABLE _HRESULT_TYPEDEF_(0x8009300FL)")]
        public const int OSS_BAD_TABLE = unchecked((int)(0x8009300F));

        [NativeTypeName("#define OSS_TOO_LONG _HRESULT_TYPEDEF_(0x80093010L)")]
        public const int OSS_TOO_LONG = unchecked((int)(0x80093010));

        [NativeTypeName("#define OSS_CONSTRAINT_VIOLATED _HRESULT_TYPEDEF_(0x80093011L)")]
        public const int OSS_CONSTRAINT_VIOLATED = unchecked((int)(0x80093011));

        [NativeTypeName("#define OSS_FATAL_ERROR _HRESULT_TYPEDEF_(0x80093012L)")]
        public const int OSS_FATAL_ERROR = unchecked((int)(0x80093012));

        [NativeTypeName("#define OSS_ACCESS_SERIALIZATION_ERROR _HRESULT_TYPEDEF_(0x80093013L)")]
        public const int OSS_ACCESS_SERIALIZATION_ERROR = unchecked((int)(0x80093013));

        [NativeTypeName("#define OSS_NULL_TBL _HRESULT_TYPEDEF_(0x80093014L)")]
        public const int OSS_NULL_TBL = unchecked((int)(0x80093014));

        [NativeTypeName("#define OSS_NULL_FCN _HRESULT_TYPEDEF_(0x80093015L)")]
        public const int OSS_NULL_FCN = unchecked((int)(0x80093015));

        [NativeTypeName("#define OSS_BAD_ENCRULES _HRESULT_TYPEDEF_(0x80093016L)")]
        public const int OSS_BAD_ENCRULES = unchecked((int)(0x80093016));

        [NativeTypeName("#define OSS_UNAVAIL_ENCRULES _HRESULT_TYPEDEF_(0x80093017L)")]
        public const int OSS_UNAVAIL_ENCRULES = unchecked((int)(0x80093017));

        [NativeTypeName("#define OSS_CANT_OPEN_TRACE_WINDOW _HRESULT_TYPEDEF_(0x80093018L)")]
        public const int OSS_CANT_OPEN_TRACE_WINDOW = unchecked((int)(0x80093018));

        [NativeTypeName("#define OSS_UNIMPLEMENTED _HRESULT_TYPEDEF_(0x80093019L)")]
        public const int OSS_UNIMPLEMENTED = unchecked((int)(0x80093019));

        [NativeTypeName("#define OSS_OID_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009301AL)")]
        public const int OSS_OID_DLL_NOT_LINKED = unchecked((int)(0x8009301A));

        [NativeTypeName("#define OSS_CANT_OPEN_TRACE_FILE _HRESULT_TYPEDEF_(0x8009301BL)")]
        public const int OSS_CANT_OPEN_TRACE_FILE = unchecked((int)(0x8009301B));

        [NativeTypeName("#define OSS_TRACE_FILE_ALREADY_OPEN _HRESULT_TYPEDEF_(0x8009301CL)")]
        public const int OSS_TRACE_FILE_ALREADY_OPEN = unchecked((int)(0x8009301C));

        [NativeTypeName("#define OSS_TABLE_MISMATCH _HRESULT_TYPEDEF_(0x8009301DL)")]
        public const int OSS_TABLE_MISMATCH = unchecked((int)(0x8009301D));

        [NativeTypeName("#define OSS_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009301EL)")]
        public const int OSS_TYPE_NOT_SUPPORTED = unchecked((int)(0x8009301E));

        [NativeTypeName("#define OSS_REAL_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009301FL)")]
        public const int OSS_REAL_DLL_NOT_LINKED = unchecked((int)(0x8009301F));

        [NativeTypeName("#define OSS_REAL_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093020L)")]
        public const int OSS_REAL_CODE_NOT_LINKED = unchecked((int)(0x80093020));

        [NativeTypeName("#define OSS_OUT_OF_RANGE _HRESULT_TYPEDEF_(0x80093021L)")]
        public const int OSS_OUT_OF_RANGE = unchecked((int)(0x80093021));

        [NativeTypeName("#define OSS_COPIER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093022L)")]
        public const int OSS_COPIER_DLL_NOT_LINKED = unchecked((int)(0x80093022));

        [NativeTypeName("#define OSS_CONSTRAINT_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093023L)")]
        public const int OSS_CONSTRAINT_DLL_NOT_LINKED = unchecked((int)(0x80093023));

        [NativeTypeName("#define OSS_COMPARATOR_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093024L)")]
        public const int OSS_COMPARATOR_DLL_NOT_LINKED = unchecked((int)(0x80093024));

        [NativeTypeName("#define OSS_COMPARATOR_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093025L)")]
        public const int OSS_COMPARATOR_CODE_NOT_LINKED = unchecked((int)(0x80093025));

        [NativeTypeName("#define OSS_MEM_MGR_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093026L)")]
        public const int OSS_MEM_MGR_DLL_NOT_LINKED = unchecked((int)(0x80093026));

        [NativeTypeName("#define OSS_PDV_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093027L)")]
        public const int OSS_PDV_DLL_NOT_LINKED = unchecked((int)(0x80093027));

        [NativeTypeName("#define OSS_PDV_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093028L)")]
        public const int OSS_PDV_CODE_NOT_LINKED = unchecked((int)(0x80093028));

        [NativeTypeName("#define OSS_API_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093029L)")]
        public const int OSS_API_DLL_NOT_LINKED = unchecked((int)(0x80093029));

        [NativeTypeName("#define OSS_BERDER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009302AL)")]
        public const int OSS_BERDER_DLL_NOT_LINKED = unchecked((int)(0x8009302A));

        [NativeTypeName("#define OSS_PER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009302BL)")]
        public const int OSS_PER_DLL_NOT_LINKED = unchecked((int)(0x8009302B));

        [NativeTypeName("#define OSS_OPEN_TYPE_ERROR _HRESULT_TYPEDEF_(0x8009302CL)")]
        public const int OSS_OPEN_TYPE_ERROR = unchecked((int)(0x8009302C));

        [NativeTypeName("#define OSS_MUTEX_NOT_CREATED _HRESULT_TYPEDEF_(0x8009302DL)")]
        public const int OSS_MUTEX_NOT_CREATED = unchecked((int)(0x8009302D));

        [NativeTypeName("#define OSS_CANT_CLOSE_TRACE_FILE _HRESULT_TYPEDEF_(0x8009302EL)")]
        public const int OSS_CANT_CLOSE_TRACE_FILE = unchecked((int)(0x8009302E));

        [NativeTypeName("#define CERTSRV_E_BAD_REQUESTSUBJECT _HRESULT_TYPEDEF_(0x80094001L)")]
        public const int CERTSRV_E_BAD_REQUESTSUBJECT = unchecked((int)(0x80094001));

        [NativeTypeName("#define CERTSRV_E_NO_REQUEST _HRESULT_TYPEDEF_(0x80094002L)")]
        public const int CERTSRV_E_NO_REQUEST = unchecked((int)(0x80094002));

        [NativeTypeName("#define CERTSRV_E_BAD_REQUESTSTATUS _HRESULT_TYPEDEF_(0x80094003L)")]
        public const int CERTSRV_E_BAD_REQUESTSTATUS = unchecked((int)(0x80094003));

        [NativeTypeName("#define CERTSRV_E_PROPERTY_EMPTY _HRESULT_TYPEDEF_(0x80094004L)")]
        public const int CERTSRV_E_PROPERTY_EMPTY = unchecked((int)(0x80094004));

        [NativeTypeName("#define CERTSRV_E_INVALID_CA_CERTIFICATE _HRESULT_TYPEDEF_(0x80094005L)")]
        public const int CERTSRV_E_INVALID_CA_CERTIFICATE = unchecked((int)(0x80094005));

        [NativeTypeName("#define CERTSRV_E_SERVER_SUSPENDED _HRESULT_TYPEDEF_(0x80094006L)")]
        public const int CERTSRV_E_SERVER_SUSPENDED = unchecked((int)(0x80094006));

        [NativeTypeName("#define CERTSRV_E_ENCODING_LENGTH _HRESULT_TYPEDEF_(0x80094007L)")]
        public const int CERTSRV_E_ENCODING_LENGTH = unchecked((int)(0x80094007));

        [NativeTypeName("#define CERTSRV_E_ROLECONFLICT _HRESULT_TYPEDEF_(0x80094008L)")]
        public const int CERTSRV_E_ROLECONFLICT = unchecked((int)(0x80094008));

        [NativeTypeName("#define CERTSRV_E_RESTRICTEDOFFICER _HRESULT_TYPEDEF_(0x80094009L)")]
        public const int CERTSRV_E_RESTRICTEDOFFICER = unchecked((int)(0x80094009));

        [NativeTypeName("#define CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x8009400AL)")]
        public const int CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = unchecked((int)(0x8009400A));

        [NativeTypeName("#define CERTSRV_E_NO_VALID_KRA _HRESULT_TYPEDEF_(0x8009400BL)")]
        public const int CERTSRV_E_NO_VALID_KRA = unchecked((int)(0x8009400B));

        [NativeTypeName("#define CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL _HRESULT_TYPEDEF_(0x8009400CL)")]
        public const int CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = unchecked((int)(0x8009400C));

        [NativeTypeName("#define CERTSRV_E_NO_CAADMIN_DEFINED _HRESULT_TYPEDEF_(0x8009400DL)")]
        public const int CERTSRV_E_NO_CAADMIN_DEFINED = unchecked((int)(0x8009400D));

        [NativeTypeName("#define CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE _HRESULT_TYPEDEF_(0x8009400EL)")]
        public const int CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = unchecked((int)(0x8009400E));

        [NativeTypeName("#define CERTSRV_E_NO_DB_SESSIONS _HRESULT_TYPEDEF_(0x8009400FL)")]
        public const int CERTSRV_E_NO_DB_SESSIONS = unchecked((int)(0x8009400F));

        [NativeTypeName("#define CERTSRV_E_ALIGNMENT_FAULT _HRESULT_TYPEDEF_(0x80094010L)")]
        public const int CERTSRV_E_ALIGNMENT_FAULT = unchecked((int)(0x80094010));

        [NativeTypeName("#define CERTSRV_E_ENROLL_DENIED _HRESULT_TYPEDEF_(0x80094011L)")]
        public const int CERTSRV_E_ENROLL_DENIED = unchecked((int)(0x80094011));

        [NativeTypeName("#define CERTSRV_E_TEMPLATE_DENIED _HRESULT_TYPEDEF_(0x80094012L)")]
        public const int CERTSRV_E_TEMPLATE_DENIED = unchecked((int)(0x80094012));

        [NativeTypeName("#define CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE _HRESULT_TYPEDEF_(0x80094013L)")]
        public const int CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = unchecked((int)(0x80094013));

        [NativeTypeName("#define CERTSRV_E_ADMIN_DENIED_REQUEST _HRESULT_TYPEDEF_(0x80094014L)")]
        public const int CERTSRV_E_ADMIN_DENIED_REQUEST = unchecked((int)(0x80094014));

        [NativeTypeName("#define CERTSRV_E_NO_POLICY_SERVER _HRESULT_TYPEDEF_(0x80094015L)")]
        public const int CERTSRV_E_NO_POLICY_SERVER = unchecked((int)(0x80094015));

        [NativeTypeName("#define CERTSRV_E_WEAK_SIGNATURE_OR_KEY _HRESULT_TYPEDEF_(0x80094016L)")]
        public const int CERTSRV_E_WEAK_SIGNATURE_OR_KEY = unchecked((int)(0x80094016));

        [NativeTypeName("#define CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80094017L)")]
        public const int CERTSRV_E_KEY_ATTESTATION_NOT_SUPPORTED = unchecked((int)(0x80094017));

        [NativeTypeName("#define CERTSRV_E_ENCRYPTION_CERT_REQUIRED _HRESULT_TYPEDEF_(0x80094018L)")]
        public const int CERTSRV_E_ENCRYPTION_CERT_REQUIRED = unchecked((int)(0x80094018));

        [NativeTypeName("#define CERTSRV_E_UNSUPPORTED_CERT_TYPE _HRESULT_TYPEDEF_(0x80094800L)")]
        public const int CERTSRV_E_UNSUPPORTED_CERT_TYPE = unchecked((int)(0x80094800));

        [NativeTypeName("#define CERTSRV_E_NO_CERT_TYPE _HRESULT_TYPEDEF_(0x80094801L)")]
        public const int CERTSRV_E_NO_CERT_TYPE = unchecked((int)(0x80094801));

        [NativeTypeName("#define CERTSRV_E_TEMPLATE_CONFLICT _HRESULT_TYPEDEF_(0x80094802L)")]
        public const int CERTSRV_E_TEMPLATE_CONFLICT = unchecked((int)(0x80094802));

        [NativeTypeName("#define CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED _HRESULT_TYPEDEF_(0x80094803L)")]
        public const int CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = unchecked((int)(0x80094803));

        [NativeTypeName("#define CERTSRV_E_ARCHIVED_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80094804L)")]
        public const int CERTSRV_E_ARCHIVED_KEY_REQUIRED = unchecked((int)(0x80094804));

        [NativeTypeName("#define CERTSRV_E_SMIME_REQUIRED _HRESULT_TYPEDEF_(0x80094805L)")]
        public const int CERTSRV_E_SMIME_REQUIRED = unchecked((int)(0x80094805));

        [NativeTypeName("#define CERTSRV_E_BAD_RENEWAL_SUBJECT _HRESULT_TYPEDEF_(0x80094806L)")]
        public const int CERTSRV_E_BAD_RENEWAL_SUBJECT = unchecked((int)(0x80094806));

        [NativeTypeName("#define CERTSRV_E_BAD_TEMPLATE_VERSION _HRESULT_TYPEDEF_(0x80094807L)")]
        public const int CERTSRV_E_BAD_TEMPLATE_VERSION = unchecked((int)(0x80094807));

        [NativeTypeName("#define CERTSRV_E_TEMPLATE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x80094808L)")]
        public const int CERTSRV_E_TEMPLATE_POLICY_REQUIRED = unchecked((int)(0x80094808));

        [NativeTypeName("#define CERTSRV_E_SIGNATURE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x80094809L)")]
        public const int CERTSRV_E_SIGNATURE_POLICY_REQUIRED = unchecked((int)(0x80094809));

        [NativeTypeName("#define CERTSRV_E_SIGNATURE_COUNT _HRESULT_TYPEDEF_(0x8009480AL)")]
        public const int CERTSRV_E_SIGNATURE_COUNT = unchecked((int)(0x8009480A));

        [NativeTypeName("#define CERTSRV_E_SIGNATURE_REJECTED _HRESULT_TYPEDEF_(0x8009480BL)")]
        public const int CERTSRV_E_SIGNATURE_REJECTED = unchecked((int)(0x8009480B));

        [NativeTypeName("#define CERTSRV_E_ISSUANCE_POLICY_REQUIRED _HRESULT_TYPEDEF_(0x8009480CL)")]
        public const int CERTSRV_E_ISSUANCE_POLICY_REQUIRED = unchecked((int)(0x8009480C));

        [NativeTypeName("#define CERTSRV_E_SUBJECT_UPN_REQUIRED _HRESULT_TYPEDEF_(0x8009480DL)")]
        public const int CERTSRV_E_SUBJECT_UPN_REQUIRED = unchecked((int)(0x8009480D));

        [NativeTypeName("#define CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED _HRESULT_TYPEDEF_(0x8009480EL)")]
        public const int CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = unchecked((int)(0x8009480E));

        [NativeTypeName("#define CERTSRV_E_SUBJECT_DNS_REQUIRED _HRESULT_TYPEDEF_(0x8009480FL)")]
        public const int CERTSRV_E_SUBJECT_DNS_REQUIRED = unchecked((int)(0x8009480F));

        [NativeTypeName("#define CERTSRV_E_ARCHIVED_KEY_UNEXPECTED _HRESULT_TYPEDEF_(0x80094810L)")]
        public const int CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = unchecked((int)(0x80094810));

        [NativeTypeName("#define CERTSRV_E_KEY_LENGTH _HRESULT_TYPEDEF_(0x80094811L)")]
        public const int CERTSRV_E_KEY_LENGTH = unchecked((int)(0x80094811));

        [NativeTypeName("#define CERTSRV_E_SUBJECT_EMAIL_REQUIRED _HRESULT_TYPEDEF_(0x80094812L)")]
        public const int CERTSRV_E_SUBJECT_EMAIL_REQUIRED = unchecked((int)(0x80094812));

        [NativeTypeName("#define CERTSRV_E_UNKNOWN_CERT_TYPE _HRESULT_TYPEDEF_(0x80094813L)")]
        public const int CERTSRV_E_UNKNOWN_CERT_TYPE = unchecked((int)(0x80094813));

        [NativeTypeName("#define CERTSRV_E_CERT_TYPE_OVERLAP _HRESULT_TYPEDEF_(0x80094814L)")]
        public const int CERTSRV_E_CERT_TYPE_OVERLAP = unchecked((int)(0x80094814));

        [NativeTypeName("#define CERTSRV_E_TOO_MANY_SIGNATURES _HRESULT_TYPEDEF_(0x80094815L)")]
        public const int CERTSRV_E_TOO_MANY_SIGNATURES = unchecked((int)(0x80094815));

        [NativeTypeName("#define CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY _HRESULT_TYPEDEF_(0x80094816L)")]
        public const int CERTSRV_E_RENEWAL_BAD_PUBLIC_KEY = unchecked((int)(0x80094816));

        [NativeTypeName("#define CERTSRV_E_INVALID_EK _HRESULT_TYPEDEF_(0x80094817L)")]
        public const int CERTSRV_E_INVALID_EK = unchecked((int)(0x80094817));

        [NativeTypeName("#define CERTSRV_E_INVALID_IDBINDING _HRESULT_TYPEDEF_(0x80094818L)")]
        public const int CERTSRV_E_INVALID_IDBINDING = unchecked((int)(0x80094818));

        [NativeTypeName("#define CERTSRV_E_INVALID_ATTESTATION _HRESULT_TYPEDEF_(0x80094819L)")]
        public const int CERTSRV_E_INVALID_ATTESTATION = unchecked((int)(0x80094819));

        [NativeTypeName("#define CERTSRV_E_KEY_ATTESTATION _HRESULT_TYPEDEF_(0x8009481AL)")]
        public const int CERTSRV_E_KEY_ATTESTATION = unchecked((int)(0x8009481A));

        [NativeTypeName("#define CERTSRV_E_CORRUPT_KEY_ATTESTATION _HRESULT_TYPEDEF_(0x8009481BL)")]
        public const int CERTSRV_E_CORRUPT_KEY_ATTESTATION = unchecked((int)(0x8009481B));

        [NativeTypeName("#define CERTSRV_E_EXPIRED_CHALLENGE _HRESULT_TYPEDEF_(0x8009481CL)")]
        public const int CERTSRV_E_EXPIRED_CHALLENGE = unchecked((int)(0x8009481C));

        [NativeTypeName("#define CERTSRV_E_INVALID_RESPONSE _HRESULT_TYPEDEF_(0x8009481DL)")]
        public const int CERTSRV_E_INVALID_RESPONSE = unchecked((int)(0x8009481D));

        [NativeTypeName("#define CERTSRV_E_INVALID_REQUESTID _HRESULT_TYPEDEF_(0x8009481EL)")]
        public const int CERTSRV_E_INVALID_REQUESTID = unchecked((int)(0x8009481E));

        [NativeTypeName("#define CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH _HRESULT_TYPEDEF_(0x8009481FL)")]
        public const int CERTSRV_E_REQUEST_PRECERTIFICATE_MISMATCH = unchecked((int)(0x8009481F));

        [NativeTypeName("#define CERTSRV_E_PENDING_CLIENT_RESPONSE _HRESULT_TYPEDEF_(0x80094820L)")]
        public const int CERTSRV_E_PENDING_CLIENT_RESPONSE = unchecked((int)(0x80094820));

        [NativeTypeName("#define XENROLL_E_KEY_NOT_EXPORTABLE _HRESULT_TYPEDEF_(0x80095000L)")]
        public const int XENROLL_E_KEY_NOT_EXPORTABLE = unchecked((int)(0x80095000));

        [NativeTypeName("#define XENROLL_E_CANNOT_ADD_ROOT_CERT _HRESULT_TYPEDEF_(0x80095001L)")]
        public const int XENROLL_E_CANNOT_ADD_ROOT_CERT = unchecked((int)(0x80095001));

        [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND _HRESULT_TYPEDEF_(0x80095002L)")]
        public const int XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = unchecked((int)(0x80095002));

        [NativeTypeName("#define XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH _HRESULT_TYPEDEF_(0x80095003L)")]
        public const int XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = unchecked((int)(0x80095003));

        [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_MISMATCH _HRESULT_TYPEDEF_(0x80095004L)")]
        public const int XENROLL_E_RESPONSE_KA_HASH_MISMATCH = unchecked((int)(0x80095004));

        [NativeTypeName("#define XENROLL_E_KEYSPEC_SMIME_MISMATCH _HRESULT_TYPEDEF_(0x80095005L)")]
        public const int XENROLL_E_KEYSPEC_SMIME_MISMATCH = unchecked((int)(0x80095005));

        [NativeTypeName("#define TRUST_E_SYSTEM_ERROR _HRESULT_TYPEDEF_(0x80096001L)")]
        public const int TRUST_E_SYSTEM_ERROR = unchecked((int)(0x80096001));

        [NativeTypeName("#define TRUST_E_NO_SIGNER_CERT _HRESULT_TYPEDEF_(0x80096002L)")]
        public const int TRUST_E_NO_SIGNER_CERT = unchecked((int)(0x80096002));

        [NativeTypeName("#define TRUST_E_COUNTER_SIGNER _HRESULT_TYPEDEF_(0x80096003L)")]
        public const int TRUST_E_COUNTER_SIGNER = unchecked((int)(0x80096003));

        [NativeTypeName("#define TRUST_E_CERT_SIGNATURE _HRESULT_TYPEDEF_(0x80096004L)")]
        public const int TRUST_E_CERT_SIGNATURE = unchecked((int)(0x80096004));

        [NativeTypeName("#define TRUST_E_TIME_STAMP _HRESULT_TYPEDEF_(0x80096005L)")]
        public const int TRUST_E_TIME_STAMP = unchecked((int)(0x80096005));

        [NativeTypeName("#define TRUST_E_BAD_DIGEST _HRESULT_TYPEDEF_(0x80096010L)")]
        public const int TRUST_E_BAD_DIGEST = unchecked((int)(0x80096010));

        [NativeTypeName("#define TRUST_E_MALFORMED_SIGNATURE _HRESULT_TYPEDEF_(0x80096011L)")]
        public const int TRUST_E_MALFORMED_SIGNATURE = unchecked((int)(0x80096011));

        [NativeTypeName("#define TRUST_E_BASIC_CONSTRAINTS _HRESULT_TYPEDEF_(0x80096019L)")]
        public const int TRUST_E_BASIC_CONSTRAINTS = unchecked((int)(0x80096019));

        [NativeTypeName("#define TRUST_E_FINANCIAL_CRITERIA _HRESULT_TYPEDEF_(0x8009601EL)")]
        public const int TRUST_E_FINANCIAL_CRITERIA = unchecked((int)(0x8009601E));

        [NativeTypeName("#define MSSIPOTF_E_OUTOFMEMRANGE _HRESULT_TYPEDEF_(0x80097001L)")]
        public const int MSSIPOTF_E_OUTOFMEMRANGE = unchecked((int)(0x80097001));

        [NativeTypeName("#define MSSIPOTF_E_CANTGETOBJECT _HRESULT_TYPEDEF_(0x80097002L)")]
        public const int MSSIPOTF_E_CANTGETOBJECT = unchecked((int)(0x80097002));

        [NativeTypeName("#define MSSIPOTF_E_NOHEADTABLE _HRESULT_TYPEDEF_(0x80097003L)")]
        public const int MSSIPOTF_E_NOHEADTABLE = unchecked((int)(0x80097003));

        [NativeTypeName("#define MSSIPOTF_E_BAD_MAGICNUMBER _HRESULT_TYPEDEF_(0x80097004L)")]
        public const int MSSIPOTF_E_BAD_MAGICNUMBER = unchecked((int)(0x80097004));

        [NativeTypeName("#define MSSIPOTF_E_BAD_OFFSET_TABLE _HRESULT_TYPEDEF_(0x80097005L)")]
        public const int MSSIPOTF_E_BAD_OFFSET_TABLE = unchecked((int)(0x80097005));

        [NativeTypeName("#define MSSIPOTF_E_TABLE_TAGORDER _HRESULT_TYPEDEF_(0x80097006L)")]
        public const int MSSIPOTF_E_TABLE_TAGORDER = unchecked((int)(0x80097006));

        [NativeTypeName("#define MSSIPOTF_E_TABLE_LONGWORD _HRESULT_TYPEDEF_(0x80097007L)")]
        public const int MSSIPOTF_E_TABLE_LONGWORD = unchecked((int)(0x80097007));

        [NativeTypeName("#define MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT _HRESULT_TYPEDEF_(0x80097008L)")]
        public const int MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = unchecked((int)(0x80097008));

        [NativeTypeName("#define MSSIPOTF_E_TABLES_OVERLAP _HRESULT_TYPEDEF_(0x80097009L)")]
        public const int MSSIPOTF_E_TABLES_OVERLAP = unchecked((int)(0x80097009));

        [NativeTypeName("#define MSSIPOTF_E_TABLE_PADBYTES _HRESULT_TYPEDEF_(0x8009700AL)")]
        public const int MSSIPOTF_E_TABLE_PADBYTES = unchecked((int)(0x8009700A));

        [NativeTypeName("#define MSSIPOTF_E_FILETOOSMALL _HRESULT_TYPEDEF_(0x8009700BL)")]
        public const int MSSIPOTF_E_FILETOOSMALL = unchecked((int)(0x8009700B));

        [NativeTypeName("#define MSSIPOTF_E_TABLE_CHECKSUM _HRESULT_TYPEDEF_(0x8009700CL)")]
        public const int MSSIPOTF_E_TABLE_CHECKSUM = unchecked((int)(0x8009700C));

        [NativeTypeName("#define MSSIPOTF_E_FILE_CHECKSUM _HRESULT_TYPEDEF_(0x8009700DL)")]
        public const int MSSIPOTF_E_FILE_CHECKSUM = unchecked((int)(0x8009700D));

        [NativeTypeName("#define MSSIPOTF_E_FAILED_POLICY _HRESULT_TYPEDEF_(0x80097010L)")]
        public const int MSSIPOTF_E_FAILED_POLICY = unchecked((int)(0x80097010));

        [NativeTypeName("#define MSSIPOTF_E_FAILED_HINTS_CHECK _HRESULT_TYPEDEF_(0x80097011L)")]
        public const int MSSIPOTF_E_FAILED_HINTS_CHECK = unchecked((int)(0x80097011));

        [NativeTypeName("#define MSSIPOTF_E_NOT_OPENTYPE _HRESULT_TYPEDEF_(0x80097012L)")]
        public const int MSSIPOTF_E_NOT_OPENTYPE = unchecked((int)(0x80097012));

        [NativeTypeName("#define MSSIPOTF_E_FILE _HRESULT_TYPEDEF_(0x80097013L)")]
        public const int MSSIPOTF_E_FILE = unchecked((int)(0x80097013));

        [NativeTypeName("#define MSSIPOTF_E_CRYPT _HRESULT_TYPEDEF_(0x80097014L)")]
        public const int MSSIPOTF_E_CRYPT = unchecked((int)(0x80097014));

        [NativeTypeName("#define MSSIPOTF_E_BADVERSION _HRESULT_TYPEDEF_(0x80097015L)")]
        public const int MSSIPOTF_E_BADVERSION = unchecked((int)(0x80097015));

        [NativeTypeName("#define MSSIPOTF_E_DSIG_STRUCTURE _HRESULT_TYPEDEF_(0x80097016L)")]
        public const int MSSIPOTF_E_DSIG_STRUCTURE = unchecked((int)(0x80097016));

        [NativeTypeName("#define MSSIPOTF_E_PCONST_CHECK _HRESULT_TYPEDEF_(0x80097017L)")]
        public const int MSSIPOTF_E_PCONST_CHECK = unchecked((int)(0x80097017));

        [NativeTypeName("#define MSSIPOTF_E_STRUCTURE _HRESULT_TYPEDEF_(0x80097018L)")]
        public const int MSSIPOTF_E_STRUCTURE = unchecked((int)(0x80097018));

        [NativeTypeName("#define NTE_OP_OK 0")]
        public const int NTE_OP_OK = 0;

        [NativeTypeName("#define TRUST_E_PROVIDER_UNKNOWN _HRESULT_TYPEDEF_(0x800B0001L)")]
        public const int TRUST_E_PROVIDER_UNKNOWN = unchecked((int)(0x800B0001));

        [NativeTypeName("#define TRUST_E_ACTION_UNKNOWN _HRESULT_TYPEDEF_(0x800B0002L)")]
        public const int TRUST_E_ACTION_UNKNOWN = unchecked((int)(0x800B0002));

        [NativeTypeName("#define TRUST_E_SUBJECT_FORM_UNKNOWN _HRESULT_TYPEDEF_(0x800B0003L)")]
        public const int TRUST_E_SUBJECT_FORM_UNKNOWN = unchecked((int)(0x800B0003));

        [NativeTypeName("#define TRUST_E_SUBJECT_NOT_TRUSTED _HRESULT_TYPEDEF_(0x800B0004L)")]
        public const int TRUST_E_SUBJECT_NOT_TRUSTED = unchecked((int)(0x800B0004));

        [NativeTypeName("#define DIGSIG_E_ENCODE _HRESULT_TYPEDEF_(0x800B0005L)")]
        public const int DIGSIG_E_ENCODE = unchecked((int)(0x800B0005));

        [NativeTypeName("#define DIGSIG_E_DECODE _HRESULT_TYPEDEF_(0x800B0006L)")]
        public const int DIGSIG_E_DECODE = unchecked((int)(0x800B0006));

        [NativeTypeName("#define DIGSIG_E_EXTENSIBILITY _HRESULT_TYPEDEF_(0x800B0007L)")]
        public const int DIGSIG_E_EXTENSIBILITY = unchecked((int)(0x800B0007));

        [NativeTypeName("#define DIGSIG_E_CRYPTO _HRESULT_TYPEDEF_(0x800B0008L)")]
        public const int DIGSIG_E_CRYPTO = unchecked((int)(0x800B0008));

        [NativeTypeName("#define PERSIST_E_SIZEDEFINITE _HRESULT_TYPEDEF_(0x800B0009L)")]
        public const int PERSIST_E_SIZEDEFINITE = unchecked((int)(0x800B0009));

        [NativeTypeName("#define PERSIST_E_SIZEINDEFINITE _HRESULT_TYPEDEF_(0x800B000AL)")]
        public const int PERSIST_E_SIZEINDEFINITE = unchecked((int)(0x800B000A));

        [NativeTypeName("#define PERSIST_E_NOTSELFSIZING _HRESULT_TYPEDEF_(0x800B000BL)")]
        public const int PERSIST_E_NOTSELFSIZING = unchecked((int)(0x800B000B));

        [NativeTypeName("#define TRUST_E_NOSIGNATURE _HRESULT_TYPEDEF_(0x800B0100L)")]
        public const int TRUST_E_NOSIGNATURE = unchecked((int)(0x800B0100));

        [NativeTypeName("#define TRUST_E_FAIL _HRESULT_TYPEDEF_(0x800B010BL)")]
        public const int TRUST_E_FAIL = unchecked((int)(0x800B010B));

        [NativeTypeName("#define TRUST_E_EXPLICIT_DISTRUST _HRESULT_TYPEDEF_(0x800B0111L)")]
        public const int TRUST_E_EXPLICIT_DISTRUST = unchecked((int)(0x800B0111));

        [NativeTypeName("#define SPAPI_E_EXPECTED_SECTION_NAME _HRESULT_TYPEDEF_(0x800F0000L)")]
        public const int SPAPI_E_EXPECTED_SECTION_NAME = unchecked((int)(0x800F0000));

        [NativeTypeName("#define SPAPI_E_BAD_SECTION_NAME_LINE _HRESULT_TYPEDEF_(0x800F0001L)")]
        public const int SPAPI_E_BAD_SECTION_NAME_LINE = unchecked((int)(0x800F0001));

        [NativeTypeName("#define SPAPI_E_SECTION_NAME_TOO_LONG _HRESULT_TYPEDEF_(0x800F0002L)")]
        public const int SPAPI_E_SECTION_NAME_TOO_LONG = unchecked((int)(0x800F0002));

        [NativeTypeName("#define SPAPI_E_GENERAL_SYNTAX _HRESULT_TYPEDEF_(0x800F0003L)")]
        public const int SPAPI_E_GENERAL_SYNTAX = unchecked((int)(0x800F0003));

        [NativeTypeName("#define SPAPI_E_WRONG_INF_STYLE _HRESULT_TYPEDEF_(0x800F0100L)")]
        public const int SPAPI_E_WRONG_INF_STYLE = unchecked((int)(0x800F0100));

        [NativeTypeName("#define SPAPI_E_SECTION_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0101L)")]
        public const int SPAPI_E_SECTION_NOT_FOUND = unchecked((int)(0x800F0101));

        [NativeTypeName("#define SPAPI_E_LINE_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0102L)")]
        public const int SPAPI_E_LINE_NOT_FOUND = unchecked((int)(0x800F0102));

        [NativeTypeName("#define SPAPI_E_NO_BACKUP _HRESULT_TYPEDEF_(0x800F0103L)")]
        public const int SPAPI_E_NO_BACKUP = unchecked((int)(0x800F0103));

        [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_CLASS _HRESULT_TYPEDEF_(0x800F0200L)")]
        public const int SPAPI_E_NO_ASSOCIATED_CLASS = unchecked((int)(0x800F0200));

        [NativeTypeName("#define SPAPI_E_CLASS_MISMATCH _HRESULT_TYPEDEF_(0x800F0201L)")]
        public const int SPAPI_E_CLASS_MISMATCH = unchecked((int)(0x800F0201));

        [NativeTypeName("#define SPAPI_E_DUPLICATE_FOUND _HRESULT_TYPEDEF_(0x800F0202L)")]
        public const int SPAPI_E_DUPLICATE_FOUND = unchecked((int)(0x800F0202));

        [NativeTypeName("#define SPAPI_E_NO_DRIVER_SELECTED _HRESULT_TYPEDEF_(0x800F0203L)")]
        public const int SPAPI_E_NO_DRIVER_SELECTED = unchecked((int)(0x800F0203));

        [NativeTypeName("#define SPAPI_E_KEY_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x800F0204L)")]
        public const int SPAPI_E_KEY_DOES_NOT_EXIST = unchecked((int)(0x800F0204));

        [NativeTypeName("#define SPAPI_E_INVALID_DEVINST_NAME _HRESULT_TYPEDEF_(0x800F0205L)")]
        public const int SPAPI_E_INVALID_DEVINST_NAME = unchecked((int)(0x800F0205));

        [NativeTypeName("#define SPAPI_E_INVALID_CLASS _HRESULT_TYPEDEF_(0x800F0206L)")]
        public const int SPAPI_E_INVALID_CLASS = unchecked((int)(0x800F0206));

        [NativeTypeName("#define SPAPI_E_DEVINST_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x800F0207L)")]
        public const int SPAPI_E_DEVINST_ALREADY_EXISTS = unchecked((int)(0x800F0207));

        [NativeTypeName("#define SPAPI_E_DEVINFO_NOT_REGISTERED _HRESULT_TYPEDEF_(0x800F0208L)")]
        public const int SPAPI_E_DEVINFO_NOT_REGISTERED = unchecked((int)(0x800F0208));

        [NativeTypeName("#define SPAPI_E_INVALID_REG_PROPERTY _HRESULT_TYPEDEF_(0x800F0209L)")]
        public const int SPAPI_E_INVALID_REG_PROPERTY = unchecked((int)(0x800F0209));

        [NativeTypeName("#define SPAPI_E_NO_INF _HRESULT_TYPEDEF_(0x800F020AL)")]
        public const int SPAPI_E_NO_INF = unchecked((int)(0x800F020A));

        [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVINST _HRESULT_TYPEDEF_(0x800F020BL)")]
        public const int SPAPI_E_NO_SUCH_DEVINST = unchecked((int)(0x800F020B));

        [NativeTypeName("#define SPAPI_E_CANT_LOAD_CLASS_ICON _HRESULT_TYPEDEF_(0x800F020CL)")]
        public const int SPAPI_E_CANT_LOAD_CLASS_ICON = unchecked((int)(0x800F020C));

        [NativeTypeName("#define SPAPI_E_INVALID_CLASS_INSTALLER _HRESULT_TYPEDEF_(0x800F020DL)")]
        public const int SPAPI_E_INVALID_CLASS_INSTALLER = unchecked((int)(0x800F020D));

        [NativeTypeName("#define SPAPI_E_DI_DO_DEFAULT _HRESULT_TYPEDEF_(0x800F020EL)")]
        public const int SPAPI_E_DI_DO_DEFAULT = unchecked((int)(0x800F020E));

        [NativeTypeName("#define SPAPI_E_DI_NOFILECOPY _HRESULT_TYPEDEF_(0x800F020FL)")]
        public const int SPAPI_E_DI_NOFILECOPY = unchecked((int)(0x800F020F));

        [NativeTypeName("#define SPAPI_E_INVALID_HWPROFILE _HRESULT_TYPEDEF_(0x800F0210L)")]
        public const int SPAPI_E_INVALID_HWPROFILE = unchecked((int)(0x800F0210));

        [NativeTypeName("#define SPAPI_E_NO_DEVICE_SELECTED _HRESULT_TYPEDEF_(0x800F0211L)")]
        public const int SPAPI_E_NO_DEVICE_SELECTED = unchecked((int)(0x800F0211));

        [NativeTypeName("#define SPAPI_E_DEVINFO_LIST_LOCKED _HRESULT_TYPEDEF_(0x800F0212L)")]
        public const int SPAPI_E_DEVINFO_LIST_LOCKED = unchecked((int)(0x800F0212));

        [NativeTypeName("#define SPAPI_E_DEVINFO_DATA_LOCKED _HRESULT_TYPEDEF_(0x800F0213L)")]
        public const int SPAPI_E_DEVINFO_DATA_LOCKED = unchecked((int)(0x800F0213));

        [NativeTypeName("#define SPAPI_E_DI_BAD_PATH _HRESULT_TYPEDEF_(0x800F0214L)")]
        public const int SPAPI_E_DI_BAD_PATH = unchecked((int)(0x800F0214));

        [NativeTypeName("#define SPAPI_E_NO_CLASSINSTALL_PARAMS _HRESULT_TYPEDEF_(0x800F0215L)")]
        public const int SPAPI_E_NO_CLASSINSTALL_PARAMS = unchecked((int)(0x800F0215));

        [NativeTypeName("#define SPAPI_E_FILEQUEUE_LOCKED _HRESULT_TYPEDEF_(0x800F0216L)")]
        public const int SPAPI_E_FILEQUEUE_LOCKED = unchecked((int)(0x800F0216));

        [NativeTypeName("#define SPAPI_E_BAD_SERVICE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F0217L)")]
        public const int SPAPI_E_BAD_SERVICE_INSTALLSECT = unchecked((int)(0x800F0217));

        [NativeTypeName("#define SPAPI_E_NO_CLASS_DRIVER_LIST _HRESULT_TYPEDEF_(0x800F0218L)")]
        public const int SPAPI_E_NO_CLASS_DRIVER_LIST = unchecked((int)(0x800F0218));

        [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_SERVICE _HRESULT_TYPEDEF_(0x800F0219L)")]
        public const int SPAPI_E_NO_ASSOCIATED_SERVICE = unchecked((int)(0x800F0219));

        [NativeTypeName("#define SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F021AL)")]
        public const int SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = unchecked((int)(0x800F021A));

        [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_ACTIVE _HRESULT_TYPEDEF_(0x800F021BL)")]
        public const int SPAPI_E_DEVICE_INTERFACE_ACTIVE = unchecked((int)(0x800F021B));

        [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_REMOVED _HRESULT_TYPEDEF_(0x800F021CL)")]
        public const int SPAPI_E_DEVICE_INTERFACE_REMOVED = unchecked((int)(0x800F021C));

        [NativeTypeName("#define SPAPI_E_BAD_INTERFACE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F021DL)")]
        public const int SPAPI_E_BAD_INTERFACE_INSTALLSECT = unchecked((int)(0x800F021D));

        [NativeTypeName("#define SPAPI_E_NO_SUCH_INTERFACE_CLASS _HRESULT_TYPEDEF_(0x800F021EL)")]
        public const int SPAPI_E_NO_SUCH_INTERFACE_CLASS = unchecked((int)(0x800F021E));

        [NativeTypeName("#define SPAPI_E_INVALID_REFERENCE_STRING _HRESULT_TYPEDEF_(0x800F021FL)")]
        public const int SPAPI_E_INVALID_REFERENCE_STRING = unchecked((int)(0x800F021F));

        [NativeTypeName("#define SPAPI_E_INVALID_MACHINENAME _HRESULT_TYPEDEF_(0x800F0220L)")]
        public const int SPAPI_E_INVALID_MACHINENAME = unchecked((int)(0x800F0220));

        [NativeTypeName("#define SPAPI_E_REMOTE_COMM_FAILURE _HRESULT_TYPEDEF_(0x800F0221L)")]
        public const int SPAPI_E_REMOTE_COMM_FAILURE = unchecked((int)(0x800F0221));

        [NativeTypeName("#define SPAPI_E_MACHINE_UNAVAILABLE _HRESULT_TYPEDEF_(0x800F0222L)")]
        public const int SPAPI_E_MACHINE_UNAVAILABLE = unchecked((int)(0x800F0222));

        [NativeTypeName("#define SPAPI_E_NO_CONFIGMGR_SERVICES _HRESULT_TYPEDEF_(0x800F0223L)")]
        public const int SPAPI_E_NO_CONFIGMGR_SERVICES = unchecked((int)(0x800F0223));

        [NativeTypeName("#define SPAPI_E_INVALID_PROPPAGE_PROVIDER _HRESULT_TYPEDEF_(0x800F0224L)")]
        public const int SPAPI_E_INVALID_PROPPAGE_PROVIDER = unchecked((int)(0x800F0224));

        [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F0225L)")]
        public const int SPAPI_E_NO_SUCH_DEVICE_INTERFACE = unchecked((int)(0x800F0225));

        [NativeTypeName("#define SPAPI_E_DI_POSTPROCESSING_REQUIRED _HRESULT_TYPEDEF_(0x800F0226L)")]
        public const int SPAPI_E_DI_POSTPROCESSING_REQUIRED = unchecked((int)(0x800F0226));

        [NativeTypeName("#define SPAPI_E_INVALID_COINSTALLER _HRESULT_TYPEDEF_(0x800F0227L)")]
        public const int SPAPI_E_INVALID_COINSTALLER = unchecked((int)(0x800F0227));

        [NativeTypeName("#define SPAPI_E_NO_COMPAT_DRIVERS _HRESULT_TYPEDEF_(0x800F0228L)")]
        public const int SPAPI_E_NO_COMPAT_DRIVERS = unchecked((int)(0x800F0228));

        [NativeTypeName("#define SPAPI_E_NO_DEVICE_ICON _HRESULT_TYPEDEF_(0x800F0229L)")]
        public const int SPAPI_E_NO_DEVICE_ICON = unchecked((int)(0x800F0229));

        [NativeTypeName("#define SPAPI_E_INVALID_INF_LOGCONFIG _HRESULT_TYPEDEF_(0x800F022AL)")]
        public const int SPAPI_E_INVALID_INF_LOGCONFIG = unchecked((int)(0x800F022A));

        [NativeTypeName("#define SPAPI_E_DI_DONT_INSTALL _HRESULT_TYPEDEF_(0x800F022BL)")]
        public const int SPAPI_E_DI_DONT_INSTALL = unchecked((int)(0x800F022B));

        [NativeTypeName("#define SPAPI_E_INVALID_FILTER_DRIVER _HRESULT_TYPEDEF_(0x800F022CL)")]
        public const int SPAPI_E_INVALID_FILTER_DRIVER = unchecked((int)(0x800F022C));

        [NativeTypeName("#define SPAPI_E_NON_WINDOWS_NT_DRIVER _HRESULT_TYPEDEF_(0x800F022DL)")]
        public const int SPAPI_E_NON_WINDOWS_NT_DRIVER = unchecked((int)(0x800F022D));

        [NativeTypeName("#define SPAPI_E_NON_WINDOWS_DRIVER _HRESULT_TYPEDEF_(0x800F022EL)")]
        public const int SPAPI_E_NON_WINDOWS_DRIVER = unchecked((int)(0x800F022E));

        [NativeTypeName("#define SPAPI_E_NO_CATALOG_FOR_OEM_INF _HRESULT_TYPEDEF_(0x800F022FL)")]
        public const int SPAPI_E_NO_CATALOG_FOR_OEM_INF = unchecked((int)(0x800F022F));

        [NativeTypeName("#define SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE _HRESULT_TYPEDEF_(0x800F0230L)")]
        public const int SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = unchecked((int)(0x800F0230));

        [NativeTypeName("#define SPAPI_E_NOT_DISABLEABLE _HRESULT_TYPEDEF_(0x800F0231L)")]
        public const int SPAPI_E_NOT_DISABLEABLE = unchecked((int)(0x800F0231));

        [NativeTypeName("#define SPAPI_E_CANT_REMOVE_DEVINST _HRESULT_TYPEDEF_(0x800F0232L)")]
        public const int SPAPI_E_CANT_REMOVE_DEVINST = unchecked((int)(0x800F0232));

        [NativeTypeName("#define SPAPI_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x800F0233L)")]
        public const int SPAPI_E_INVALID_TARGET = unchecked((int)(0x800F0233));

        [NativeTypeName("#define SPAPI_E_DRIVER_NONNATIVE _HRESULT_TYPEDEF_(0x800F0234L)")]
        public const int SPAPI_E_DRIVER_NONNATIVE = unchecked((int)(0x800F0234));

        [NativeTypeName("#define SPAPI_E_IN_WOW64 _HRESULT_TYPEDEF_(0x800F0235L)")]
        public const int SPAPI_E_IN_WOW64 = unchecked((int)(0x800F0235));

        [NativeTypeName("#define SPAPI_E_SET_SYSTEM_RESTORE_POINT _HRESULT_TYPEDEF_(0x800F0236L)")]
        public const int SPAPI_E_SET_SYSTEM_RESTORE_POINT = unchecked((int)(0x800F0236));

        [NativeTypeName("#define SPAPI_E_INCORRECTLY_COPIED_INF _HRESULT_TYPEDEF_(0x800F0237L)")]
        public const int SPAPI_E_INCORRECTLY_COPIED_INF = unchecked((int)(0x800F0237));

        [NativeTypeName("#define SPAPI_E_SCE_DISABLED _HRESULT_TYPEDEF_(0x800F0238L)")]
        public const int SPAPI_E_SCE_DISABLED = unchecked((int)(0x800F0238));

        [NativeTypeName("#define SPAPI_E_UNKNOWN_EXCEPTION _HRESULT_TYPEDEF_(0x800F0239L)")]
        public const int SPAPI_E_UNKNOWN_EXCEPTION = unchecked((int)(0x800F0239));

        [NativeTypeName("#define SPAPI_E_PNP_REGISTRY_ERROR _HRESULT_TYPEDEF_(0x800F023AL)")]
        public const int SPAPI_E_PNP_REGISTRY_ERROR = unchecked((int)(0x800F023A));

        [NativeTypeName("#define SPAPI_E_REMOTE_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x800F023BL)")]
        public const int SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = unchecked((int)(0x800F023B));

        [NativeTypeName("#define SPAPI_E_NOT_AN_INSTALLED_OEM_INF _HRESULT_TYPEDEF_(0x800F023CL)")]
        public const int SPAPI_E_NOT_AN_INSTALLED_OEM_INF = unchecked((int)(0x800F023C));

        [NativeTypeName("#define SPAPI_E_INF_IN_USE_BY_DEVICES _HRESULT_TYPEDEF_(0x800F023DL)")]
        public const int SPAPI_E_INF_IN_USE_BY_DEVICES = unchecked((int)(0x800F023D));

        [NativeTypeName("#define SPAPI_E_DI_FUNCTION_OBSOLETE _HRESULT_TYPEDEF_(0x800F023EL)")]
        public const int SPAPI_E_DI_FUNCTION_OBSOLETE = unchecked((int)(0x800F023E));

        [NativeTypeName("#define SPAPI_E_NO_AUTHENTICODE_CATALOG _HRESULT_TYPEDEF_(0x800F023FL)")]
        public const int SPAPI_E_NO_AUTHENTICODE_CATALOG = unchecked((int)(0x800F023F));

        [NativeTypeName("#define SPAPI_E_AUTHENTICODE_DISALLOWED _HRESULT_TYPEDEF_(0x800F0240L)")]
        public const int SPAPI_E_AUTHENTICODE_DISALLOWED = unchecked((int)(0x800F0240));

        [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER _HRESULT_TYPEDEF_(0x800F0241L)")]
        public const int SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = unchecked((int)(0x800F0241));

        [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED _HRESULT_TYPEDEF_(0x800F0242L)")]
        public const int SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = unchecked((int)(0x800F0242));

        [NativeTypeName("#define SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED _HRESULT_TYPEDEF_(0x800F0243L)")]
        public const int SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = unchecked((int)(0x800F0243));

        [NativeTypeName("#define SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH _HRESULT_TYPEDEF_(0x800F0244L)")]
        public const int SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = unchecked((int)(0x800F0244));

        [NativeTypeName("#define SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE _HRESULT_TYPEDEF_(0x800F0245L)")]
        public const int SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = unchecked((int)(0x800F0245));

        [NativeTypeName("#define SPAPI_E_DEVICE_INSTALLER_NOT_READY _HRESULT_TYPEDEF_(0x800F0246L)")]
        public const int SPAPI_E_DEVICE_INSTALLER_NOT_READY = unchecked((int)(0x800F0246));

        [NativeTypeName("#define SPAPI_E_DRIVER_STORE_ADD_FAILED _HRESULT_TYPEDEF_(0x800F0247L)")]
        public const int SPAPI_E_DRIVER_STORE_ADD_FAILED = unchecked((int)(0x800F0247));

        [NativeTypeName("#define SPAPI_E_DEVICE_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0248L)")]
        public const int SPAPI_E_DEVICE_INSTALL_BLOCKED = unchecked((int)(0x800F0248));

        [NativeTypeName("#define SPAPI_E_DRIVER_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0249L)")]
        public const int SPAPI_E_DRIVER_INSTALL_BLOCKED = unchecked((int)(0x800F0249));

        [NativeTypeName("#define SPAPI_E_WRONG_INF_TYPE _HRESULT_TYPEDEF_(0x800F024AL)")]
        public const int SPAPI_E_WRONG_INF_TYPE = unchecked((int)(0x800F024A));

        [NativeTypeName("#define SPAPI_E_FILE_HASH_NOT_IN_CATALOG _HRESULT_TYPEDEF_(0x800F024BL)")]
        public const int SPAPI_E_FILE_HASH_NOT_IN_CATALOG = unchecked((int)(0x800F024B));

        [NativeTypeName("#define SPAPI_E_DRIVER_STORE_DELETE_FAILED _HRESULT_TYPEDEF_(0x800F024CL)")]
        public const int SPAPI_E_DRIVER_STORE_DELETE_FAILED = unchecked((int)(0x800F024C));

        [NativeTypeName("#define SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW _HRESULT_TYPEDEF_(0x800F0300L)")]
        public const int SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = unchecked((int)(0x800F0300));

        [NativeTypeName("#define SPAPI_E_ERROR_NOT_INSTALLED _HRESULT_TYPEDEF_(0x800F1000L)")]
        public const int SPAPI_E_ERROR_NOT_INSTALLED = unchecked((int)(0x800F1000));

        [NativeTypeName("#define SCARD_S_SUCCESS NO_ERROR")]
        public const int SCARD_S_SUCCESS = 0;

        [NativeTypeName("#define SCARD_F_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80100001L)")]
        public const int SCARD_F_INTERNAL_ERROR = unchecked((int)(0x80100001));

        [NativeTypeName("#define SCARD_E_CANCELLED _HRESULT_TYPEDEF_(0x80100002L)")]
        public const int SCARD_E_CANCELLED = unchecked((int)(0x80100002));

        [NativeTypeName("#define SCARD_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80100003L)")]
        public const int SCARD_E_INVALID_HANDLE = unchecked((int)(0x80100003));

        [NativeTypeName("#define SCARD_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80100004L)")]
        public const int SCARD_E_INVALID_PARAMETER = unchecked((int)(0x80100004));

        [NativeTypeName("#define SCARD_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x80100005L)")]
        public const int SCARD_E_INVALID_TARGET = unchecked((int)(0x80100005));

        [NativeTypeName("#define SCARD_E_NO_MEMORY _HRESULT_TYPEDEF_(0x80100006L)")]
        public const int SCARD_E_NO_MEMORY = unchecked((int)(0x80100006));

        [NativeTypeName("#define SCARD_F_WAITED_TOO_LONG _HRESULT_TYPEDEF_(0x80100007L)")]
        public const int SCARD_F_WAITED_TOO_LONG = unchecked((int)(0x80100007));

        [NativeTypeName("#define SCARD_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80100008L)")]
        public const int SCARD_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80100008));

        [NativeTypeName("#define SCARD_E_UNKNOWN_READER _HRESULT_TYPEDEF_(0x80100009L)")]
        public const int SCARD_E_UNKNOWN_READER = unchecked((int)(0x80100009));

        [NativeTypeName("#define SCARD_E_TIMEOUT _HRESULT_TYPEDEF_(0x8010000AL)")]
        public const int SCARD_E_TIMEOUT = unchecked((int)(0x8010000A));

        [NativeTypeName("#define SCARD_E_SHARING_VIOLATION _HRESULT_TYPEDEF_(0x8010000BL)")]
        public const int SCARD_E_SHARING_VIOLATION = unchecked((int)(0x8010000B));

        [NativeTypeName("#define SCARD_E_NO_SMARTCARD _HRESULT_TYPEDEF_(0x8010000CL)")]
        public const int SCARD_E_NO_SMARTCARD = unchecked((int)(0x8010000C));

        [NativeTypeName("#define SCARD_E_UNKNOWN_CARD _HRESULT_TYPEDEF_(0x8010000DL)")]
        public const int SCARD_E_UNKNOWN_CARD = unchecked((int)(0x8010000D));

        [NativeTypeName("#define SCARD_E_CANT_DISPOSE _HRESULT_TYPEDEF_(0x8010000EL)")]
        public const int SCARD_E_CANT_DISPOSE = unchecked((int)(0x8010000E));

        [NativeTypeName("#define SCARD_E_PROTO_MISMATCH _HRESULT_TYPEDEF_(0x8010000FL)")]
        public const int SCARD_E_PROTO_MISMATCH = unchecked((int)(0x8010000F));

        [NativeTypeName("#define SCARD_E_NOT_READY _HRESULT_TYPEDEF_(0x80100010L)")]
        public const int SCARD_E_NOT_READY = unchecked((int)(0x80100010));

        [NativeTypeName("#define SCARD_E_INVALID_VALUE _HRESULT_TYPEDEF_(0x80100011L)")]
        public const int SCARD_E_INVALID_VALUE = unchecked((int)(0x80100011));

        [NativeTypeName("#define SCARD_E_SYSTEM_CANCELLED _HRESULT_TYPEDEF_(0x80100012L)")]
        public const int SCARD_E_SYSTEM_CANCELLED = unchecked((int)(0x80100012));

        [NativeTypeName("#define SCARD_F_COMM_ERROR _HRESULT_TYPEDEF_(0x80100013L)")]
        public const int SCARD_F_COMM_ERROR = unchecked((int)(0x80100013));

        [NativeTypeName("#define SCARD_F_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80100014L)")]
        public const int SCARD_F_UNKNOWN_ERROR = unchecked((int)(0x80100014));

        [NativeTypeName("#define SCARD_E_INVALID_ATR _HRESULT_TYPEDEF_(0x80100015L)")]
        public const int SCARD_E_INVALID_ATR = unchecked((int)(0x80100015));

        [NativeTypeName("#define SCARD_E_NOT_TRANSACTED _HRESULT_TYPEDEF_(0x80100016L)")]
        public const int SCARD_E_NOT_TRANSACTED = unchecked((int)(0x80100016));

        [NativeTypeName("#define SCARD_E_READER_UNAVAILABLE _HRESULT_TYPEDEF_(0x80100017L)")]
        public const int SCARD_E_READER_UNAVAILABLE = unchecked((int)(0x80100017));

        [NativeTypeName("#define SCARD_P_SHUTDOWN _HRESULT_TYPEDEF_(0x80100018L)")]
        public const int SCARD_P_SHUTDOWN = unchecked((int)(0x80100018));

        [NativeTypeName("#define SCARD_E_PCI_TOO_SMALL _HRESULT_TYPEDEF_(0x80100019L)")]
        public const int SCARD_E_PCI_TOO_SMALL = unchecked((int)(0x80100019));

        [NativeTypeName("#define SCARD_E_READER_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001AL)")]
        public const int SCARD_E_READER_UNSUPPORTED = unchecked((int)(0x8010001A));

        [NativeTypeName("#define SCARD_E_DUPLICATE_READER _HRESULT_TYPEDEF_(0x8010001BL)")]
        public const int SCARD_E_DUPLICATE_READER = unchecked((int)(0x8010001B));

        [NativeTypeName("#define SCARD_E_CARD_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001CL)")]
        public const int SCARD_E_CARD_UNSUPPORTED = unchecked((int)(0x8010001C));

        [NativeTypeName("#define SCARD_E_NO_SERVICE _HRESULT_TYPEDEF_(0x8010001DL)")]
        public const int SCARD_E_NO_SERVICE = unchecked((int)(0x8010001D));

        [NativeTypeName("#define SCARD_E_SERVICE_STOPPED _HRESULT_TYPEDEF_(0x8010001EL)")]
        public const int SCARD_E_SERVICE_STOPPED = unchecked((int)(0x8010001E));

        [NativeTypeName("#define SCARD_E_UNEXPECTED _HRESULT_TYPEDEF_(0x8010001FL)")]
        public const int SCARD_E_UNEXPECTED = unchecked((int)(0x8010001F));

        [NativeTypeName("#define SCARD_E_ICC_INSTALLATION _HRESULT_TYPEDEF_(0x80100020L)")]
        public const int SCARD_E_ICC_INSTALLATION = unchecked((int)(0x80100020));

        [NativeTypeName("#define SCARD_E_ICC_CREATEORDER _HRESULT_TYPEDEF_(0x80100021L)")]
        public const int SCARD_E_ICC_CREATEORDER = unchecked((int)(0x80100021));

        [NativeTypeName("#define SCARD_E_UNSUPPORTED_FEATURE _HRESULT_TYPEDEF_(0x80100022L)")]
        public const int SCARD_E_UNSUPPORTED_FEATURE = unchecked((int)(0x80100022));

        [NativeTypeName("#define SCARD_E_DIR_NOT_FOUND _HRESULT_TYPEDEF_(0x80100023L)")]
        public const int SCARD_E_DIR_NOT_FOUND = unchecked((int)(0x80100023));

        [NativeTypeName("#define SCARD_E_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x80100024L)")]
        public const int SCARD_E_FILE_NOT_FOUND = unchecked((int)(0x80100024));

        [NativeTypeName("#define SCARD_E_NO_DIR _HRESULT_TYPEDEF_(0x80100025L)")]
        public const int SCARD_E_NO_DIR = unchecked((int)(0x80100025));

        [NativeTypeName("#define SCARD_E_NO_FILE _HRESULT_TYPEDEF_(0x80100026L)")]
        public const int SCARD_E_NO_FILE = unchecked((int)(0x80100026));

        [NativeTypeName("#define SCARD_E_NO_ACCESS _HRESULT_TYPEDEF_(0x80100027L)")]
        public const int SCARD_E_NO_ACCESS = unchecked((int)(0x80100027));

        [NativeTypeName("#define SCARD_E_WRITE_TOO_MANY _HRESULT_TYPEDEF_(0x80100028L)")]
        public const int SCARD_E_WRITE_TOO_MANY = unchecked((int)(0x80100028));

        [NativeTypeName("#define SCARD_E_BAD_SEEK _HRESULT_TYPEDEF_(0x80100029L)")]
        public const int SCARD_E_BAD_SEEK = unchecked((int)(0x80100029));

        [NativeTypeName("#define SCARD_E_INVALID_CHV _HRESULT_TYPEDEF_(0x8010002AL)")]
        public const int SCARD_E_INVALID_CHV = unchecked((int)(0x8010002A));

        [NativeTypeName("#define SCARD_E_UNKNOWN_RES_MNG _HRESULT_TYPEDEF_(0x8010002BL)")]
        public const int SCARD_E_UNKNOWN_RES_MNG = unchecked((int)(0x8010002B));

        [NativeTypeName("#define SCARD_E_NO_SUCH_CERTIFICATE _HRESULT_TYPEDEF_(0x8010002CL)")]
        public const int SCARD_E_NO_SUCH_CERTIFICATE = unchecked((int)(0x8010002C));

        [NativeTypeName("#define SCARD_E_CERTIFICATE_UNAVAILABLE _HRESULT_TYPEDEF_(0x8010002DL)")]
        public const int SCARD_E_CERTIFICATE_UNAVAILABLE = unchecked((int)(0x8010002D));

        [NativeTypeName("#define SCARD_E_NO_READERS_AVAILABLE _HRESULT_TYPEDEF_(0x8010002EL)")]
        public const int SCARD_E_NO_READERS_AVAILABLE = unchecked((int)(0x8010002E));

        [NativeTypeName("#define SCARD_E_COMM_DATA_LOST _HRESULT_TYPEDEF_(0x8010002FL)")]
        public const int SCARD_E_COMM_DATA_LOST = unchecked((int)(0x8010002F));

        [NativeTypeName("#define SCARD_E_NO_KEY_CONTAINER _HRESULT_TYPEDEF_(0x80100030L)")]
        public const int SCARD_E_NO_KEY_CONTAINER = unchecked((int)(0x80100030));

        [NativeTypeName("#define SCARD_E_SERVER_TOO_BUSY _HRESULT_TYPEDEF_(0x80100031L)")]
        public const int SCARD_E_SERVER_TOO_BUSY = unchecked((int)(0x80100031));

        [NativeTypeName("#define SCARD_E_PIN_CACHE_EXPIRED _HRESULT_TYPEDEF_(0x80100032L)")]
        public const int SCARD_E_PIN_CACHE_EXPIRED = unchecked((int)(0x80100032));

        [NativeTypeName("#define SCARD_E_NO_PIN_CACHE _HRESULT_TYPEDEF_(0x80100033L)")]
        public const int SCARD_E_NO_PIN_CACHE = unchecked((int)(0x80100033));

        [NativeTypeName("#define SCARD_E_READ_ONLY_CARD _HRESULT_TYPEDEF_(0x80100034L)")]
        public const int SCARD_E_READ_ONLY_CARD = unchecked((int)(0x80100034));

        [NativeTypeName("#define SCARD_W_UNSUPPORTED_CARD _HRESULT_TYPEDEF_(0x80100065L)")]
        public const int SCARD_W_UNSUPPORTED_CARD = unchecked((int)(0x80100065));

        [NativeTypeName("#define SCARD_W_UNRESPONSIVE_CARD _HRESULT_TYPEDEF_(0x80100066L)")]
        public const int SCARD_W_UNRESPONSIVE_CARD = unchecked((int)(0x80100066));

        [NativeTypeName("#define SCARD_W_UNPOWERED_CARD _HRESULT_TYPEDEF_(0x80100067L)")]
        public const int SCARD_W_UNPOWERED_CARD = unchecked((int)(0x80100067));

        [NativeTypeName("#define SCARD_W_RESET_CARD _HRESULT_TYPEDEF_(0x80100068L)")]
        public const int SCARD_W_RESET_CARD = unchecked((int)(0x80100068));

        [NativeTypeName("#define SCARD_W_REMOVED_CARD _HRESULT_TYPEDEF_(0x80100069L)")]
        public const int SCARD_W_REMOVED_CARD = unchecked((int)(0x80100069));

        [NativeTypeName("#define SCARD_W_SECURITY_VIOLATION _HRESULT_TYPEDEF_(0x8010006AL)")]
        public const int SCARD_W_SECURITY_VIOLATION = unchecked((int)(0x8010006A));

        [NativeTypeName("#define SCARD_W_WRONG_CHV _HRESULT_TYPEDEF_(0x8010006BL)")]
        public const int SCARD_W_WRONG_CHV = unchecked((int)(0x8010006B));

        [NativeTypeName("#define SCARD_W_CHV_BLOCKED _HRESULT_TYPEDEF_(0x8010006CL)")]
        public const int SCARD_W_CHV_BLOCKED = unchecked((int)(0x8010006C));

        [NativeTypeName("#define SCARD_W_EOF _HRESULT_TYPEDEF_(0x8010006DL)")]
        public const int SCARD_W_EOF = unchecked((int)(0x8010006D));

        [NativeTypeName("#define SCARD_W_CANCELLED_BY_USER _HRESULT_TYPEDEF_(0x8010006EL)")]
        public const int SCARD_W_CANCELLED_BY_USER = unchecked((int)(0x8010006E));

        [NativeTypeName("#define SCARD_W_CARD_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x8010006FL)")]
        public const int SCARD_W_CARD_NOT_AUTHENTICATED = unchecked((int)(0x8010006F));

        [NativeTypeName("#define SCARD_W_CACHE_ITEM_NOT_FOUND _HRESULT_TYPEDEF_(0x80100070L)")]
        public const int SCARD_W_CACHE_ITEM_NOT_FOUND = unchecked((int)(0x80100070));

        [NativeTypeName("#define SCARD_W_CACHE_ITEM_STALE _HRESULT_TYPEDEF_(0x80100071L)")]
        public const int SCARD_W_CACHE_ITEM_STALE = unchecked((int)(0x80100071));

        [NativeTypeName("#define SCARD_W_CACHE_ITEM_TOO_BIG _HRESULT_TYPEDEF_(0x80100072L)")]
        public const int SCARD_W_CACHE_ITEM_TOO_BIG = unchecked((int)(0x80100072));

        [NativeTypeName("#define COMQC_E_APPLICATION_NOT_QUEUED _HRESULT_TYPEDEF_(0x80110600L)")]
        public const int COMQC_E_APPLICATION_NOT_QUEUED = unchecked((int)(0x80110600));

        [NativeTypeName("#define COMQC_E_NO_QUEUEABLE_INTERFACES _HRESULT_TYPEDEF_(0x80110601L)")]
        public const int COMQC_E_NO_QUEUEABLE_INTERFACES = unchecked((int)(0x80110601));

        [NativeTypeName("#define COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80110602L)")]
        public const int COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80110602));

        [NativeTypeName("#define COMQC_E_NO_IPERSISTSTREAM _HRESULT_TYPEDEF_(0x80110603L)")]
        public const int COMQC_E_NO_IPERSISTSTREAM = unchecked((int)(0x80110603));

        [NativeTypeName("#define COMQC_E_BAD_MESSAGE _HRESULT_TYPEDEF_(0x80110604L)")]
        public const int COMQC_E_BAD_MESSAGE = unchecked((int)(0x80110604));

        [NativeTypeName("#define COMQC_E_UNAUTHENTICATED _HRESULT_TYPEDEF_(0x80110605L)")]
        public const int COMQC_E_UNAUTHENTICATED = unchecked((int)(0x80110605));

        [NativeTypeName("#define COMQC_E_UNTRUSTED_ENQUEUER _HRESULT_TYPEDEF_(0x80110606L)")]
        public const int COMQC_E_UNTRUSTED_ENQUEUER = unchecked((int)(0x80110606));

        [NativeTypeName("#define MSDTC_E_DUPLICATE_RESOURCE _HRESULT_TYPEDEF_(0x80110701L)")]
        public const int MSDTC_E_DUPLICATE_RESOURCE = unchecked((int)(0x80110701));

        [NativeTypeName("#define MENROLL_E_DEVICE_MESSAGE_FORMAT_ERROR _HRESULT_TYPEDEF_(0x80180001L)")]
        public const int MENROLL_E_DEVICE_MESSAGE_FORMAT_ERROR = unchecked((int)(0x80180001));

        [NativeTypeName("#define MENROLL_E_DEVICE_AUTHENTICATION_ERROR _HRESULT_TYPEDEF_(0x80180002L)")]
        public const int MENROLL_E_DEVICE_AUTHENTICATION_ERROR = unchecked((int)(0x80180002));

        [NativeTypeName("#define MENROLL_E_DEVICE_AUTHORIZATION_ERROR _HRESULT_TYPEDEF_(0x80180003L)")]
        public const int MENROLL_E_DEVICE_AUTHORIZATION_ERROR = unchecked((int)(0x80180003));

        [NativeTypeName("#define MENROLL_E_DEVICE_CERTIFICATEREQUEST_ERROR _HRESULT_TYPEDEF_(0x80180004L)")]
        public const int MENROLL_E_DEVICE_CERTIFICATEREQUEST_ERROR = unchecked((int)(0x80180004));

        [NativeTypeName("#define MENROLL_E_DEVICE_CONFIGMGRSERVER_ERROR _HRESULT_TYPEDEF_(0x80180005L)")]
        public const int MENROLL_E_DEVICE_CONFIGMGRSERVER_ERROR = unchecked((int)(0x80180005));

        [NativeTypeName("#define MENROLL_E_DEVICE_INTERNALSERVICE_ERROR _HRESULT_TYPEDEF_(0x80180006L)")]
        public const int MENROLL_E_DEVICE_INTERNALSERVICE_ERROR = unchecked((int)(0x80180006));

        [NativeTypeName("#define MENROLL_E_DEVICE_INVALIDSECURITY_ERROR _HRESULT_TYPEDEF_(0x80180007L)")]
        public const int MENROLL_E_DEVICE_INVALIDSECURITY_ERROR = unchecked((int)(0x80180007));

        [NativeTypeName("#define MENROLL_E_DEVICE_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80180008L)")]
        public const int MENROLL_E_DEVICE_UNKNOWN_ERROR = unchecked((int)(0x80180008));

        [NativeTypeName("#define MENROLL_E_ENROLLMENT_IN_PROGRESS _HRESULT_TYPEDEF_(0x80180009L)")]
        public const int MENROLL_E_ENROLLMENT_IN_PROGRESS = unchecked((int)(0x80180009));

        [NativeTypeName("#define MENROLL_E_DEVICE_ALREADY_ENROLLED _HRESULT_TYPEDEF_(0x8018000AL)")]
        public const int MENROLL_E_DEVICE_ALREADY_ENROLLED = unchecked((int)(0x8018000A));

        [NativeTypeName("#define MENROLL_E_DISCOVERY_SEC_CERT_DATE_INVALID _HRESULT_TYPEDEF_(0x8018000DL)")]
        public const int MENROLL_E_DISCOVERY_SEC_CERT_DATE_INVALID = unchecked((int)(0x8018000D));

        [NativeTypeName("#define MENROLL_E_PASSWORD_NEEDED _HRESULT_TYPEDEF_(0x8018000EL)")]
        public const int MENROLL_E_PASSWORD_NEEDED = unchecked((int)(0x8018000E));

        [NativeTypeName("#define MENROLL_E_WAB_ERROR _HRESULT_TYPEDEF_(0x8018000FL)")]
        public const int MENROLL_E_WAB_ERROR = unchecked((int)(0x8018000F));

        [NativeTypeName("#define MENROLL_E_CONNECTIVITY _HRESULT_TYPEDEF_(0x80180010L)")]
        public const int MENROLL_E_CONNECTIVITY = unchecked((int)(0x80180010));

        [NativeTypeName("#define MENROLL_S_ENROLLMENT_SUSPENDED _HRESULT_TYPEDEF_(0x00180011L)")]
        public const int MENROLL_S_ENROLLMENT_SUSPENDED = ((int)(0x00180011));

        [NativeTypeName("#define MENROLL_E_INVALIDSSLCERT _HRESULT_TYPEDEF_(0x80180012L)")]
        public const int MENROLL_E_INVALIDSSLCERT = unchecked((int)(0x80180012));

        [NativeTypeName("#define MENROLL_E_DEVICEAPREACHED _HRESULT_TYPEDEF_(0x80180013L)")]
        public const int MENROLL_E_DEVICEAPREACHED = unchecked((int)(0x80180013));

        [NativeTypeName("#define MENROLL_E_DEVICENOTSUPPORTED _HRESULT_TYPEDEF_(0x80180014L)")]
        public const int MENROLL_E_DEVICENOTSUPPORTED = unchecked((int)(0x80180014));

        [NativeTypeName("#define MENROLL_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80180015L)")]
        public const int MENROLL_E_NOT_SUPPORTED = unchecked((int)(0x80180015));

        [NativeTypeName("#define MENROLL_E_NOTELIGIBLETORENEW _HRESULT_TYPEDEF_(0x80180016L)")]
        public const int MENROLL_E_NOTELIGIBLETORENEW = unchecked((int)(0x80180016));

        [NativeTypeName("#define MENROLL_E_INMAINTENANCE _HRESULT_TYPEDEF_(0x80180017L)")]
        public const int MENROLL_E_INMAINTENANCE = unchecked((int)(0x80180017));

        [NativeTypeName("#define MENROLL_E_USER_LICENSE _HRESULT_TYPEDEF_(0x80180018L)")]
        public const int MENROLL_E_USER_LICENSE = unchecked((int)(0x80180018));

        [NativeTypeName("#define MENROLL_E_ENROLLMENTDATAINVALID _HRESULT_TYPEDEF_(0x80180019L)")]
        public const int MENROLL_E_ENROLLMENTDATAINVALID = unchecked((int)(0x80180019));

        [NativeTypeName("#define MENROLL_E_INSECUREREDIRECT _HRESULT_TYPEDEF_(0x8018001AL)")]
        public const int MENROLL_E_INSECUREREDIRECT = unchecked((int)(0x8018001A));

        [NativeTypeName("#define MENROLL_E_PLATFORM_WRONG_STATE _HRESULT_TYPEDEF_(0x8018001BL)")]
        public const int MENROLL_E_PLATFORM_WRONG_STATE = unchecked((int)(0x8018001B));

        [NativeTypeName("#define MENROLL_E_PLATFORM_LICENSE_ERROR _HRESULT_TYPEDEF_(0x8018001CL)")]
        public const int MENROLL_E_PLATFORM_LICENSE_ERROR = unchecked((int)(0x8018001C));

        [NativeTypeName("#define MENROLL_E_PLATFORM_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x8018001DL)")]
        public const int MENROLL_E_PLATFORM_UNKNOWN_ERROR = unchecked((int)(0x8018001D));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_CERTSTORE _HRESULT_TYPEDEF_(0x8018001EL)")]
        public const int MENROLL_E_PROV_CSP_CERTSTORE = unchecked((int)(0x8018001E));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_W7 _HRESULT_TYPEDEF_(0x8018001FL)")]
        public const int MENROLL_E_PROV_CSP_W7 = unchecked((int)(0x8018001F));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_DMCLIENT _HRESULT_TYPEDEF_(0x80180020L)")]
        public const int MENROLL_E_PROV_CSP_DMCLIENT = unchecked((int)(0x80180020));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_PFW _HRESULT_TYPEDEF_(0x80180021L)")]
        public const int MENROLL_E_PROV_CSP_PFW = unchecked((int)(0x80180021));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_MISC _HRESULT_TYPEDEF_(0x80180022L)")]
        public const int MENROLL_E_PROV_CSP_MISC = unchecked((int)(0x80180022));

        [NativeTypeName("#define MENROLL_E_PROV_UNKNOWN _HRESULT_TYPEDEF_(0x80180023L)")]
        public const int MENROLL_E_PROV_UNKNOWN = unchecked((int)(0x80180023));

        [NativeTypeName("#define MENROLL_E_PROV_SSLCERTNOTFOUND _HRESULT_TYPEDEF_(0x80180024L)")]
        public const int MENROLL_E_PROV_SSLCERTNOTFOUND = unchecked((int)(0x80180024));

        [NativeTypeName("#define MENROLL_E_PROV_CSP_APPMGMT _HRESULT_TYPEDEF_(0x80180025L)")]
        public const int MENROLL_E_PROV_CSP_APPMGMT = unchecked((int)(0x80180025));

        [NativeTypeName("#define MENROLL_E_DEVICE_MANAGEMENT_BLOCKED _HRESULT_TYPEDEF_(0x80180026L)")]
        public const int MENROLL_E_DEVICE_MANAGEMENT_BLOCKED = unchecked((int)(0x80180026));

        [NativeTypeName("#define MENROLL_E_CERTPOLICY_PRIVATEKEYCREATION_FAILED _HRESULT_TYPEDEF_(0x80180027L)")]
        public const int MENROLL_E_CERTPOLICY_PRIVATEKEYCREATION_FAILED = unchecked((int)(0x80180027));

        [NativeTypeName("#define MENROLL_E_CERTAUTH_FAILED_TO_FIND_CERT _HRESULT_TYPEDEF_(0x80180028L)")]
        public const int MENROLL_E_CERTAUTH_FAILED_TO_FIND_CERT = unchecked((int)(0x80180028));

        [NativeTypeName("#define MENROLL_E_EMPTY_MESSAGE _HRESULT_TYPEDEF_(0x80180029L)")]
        public const int MENROLL_E_EMPTY_MESSAGE = unchecked((int)(0x80180029));

        [NativeTypeName("#define MENROLL_E_USER_CANCELLED _HRESULT_TYPEDEF_(0x80180030L)")]
        public const int MENROLL_E_USER_CANCELLED = unchecked((int)(0x80180030));

        [NativeTypeName("#define MENROLL_E_MDM_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x80180031L)")]
        public const int MENROLL_E_MDM_NOT_CONFIGURED = unchecked((int)(0x80180031));

        [NativeTypeName("#define WER_S_REPORT_DEBUG _HRESULT_TYPEDEF_(0x001B0000L)")]
        public const int WER_S_REPORT_DEBUG = ((int)(0x001B0000));

        [NativeTypeName("#define WER_S_REPORT_UPLOADED _HRESULT_TYPEDEF_(0x001B0001L)")]
        public const int WER_S_REPORT_UPLOADED = ((int)(0x001B0001));

        [NativeTypeName("#define WER_S_REPORT_QUEUED _HRESULT_TYPEDEF_(0x001B0002L)")]
        public const int WER_S_REPORT_QUEUED = ((int)(0x001B0002));

        [NativeTypeName("#define WER_S_DISABLED _HRESULT_TYPEDEF_(0x001B0003L)")]
        public const int WER_S_DISABLED = ((int)(0x001B0003));

        [NativeTypeName("#define WER_S_SUSPENDED_UPLOAD _HRESULT_TYPEDEF_(0x001B0004L)")]
        public const int WER_S_SUSPENDED_UPLOAD = ((int)(0x001B0004));

        [NativeTypeName("#define WER_S_DISABLED_QUEUE _HRESULT_TYPEDEF_(0x001B0005L)")]
        public const int WER_S_DISABLED_QUEUE = ((int)(0x001B0005));

        [NativeTypeName("#define WER_S_DISABLED_ARCHIVE _HRESULT_TYPEDEF_(0x001B0006L)")]
        public const int WER_S_DISABLED_ARCHIVE = ((int)(0x001B0006));

        [NativeTypeName("#define WER_S_REPORT_ASYNC _HRESULT_TYPEDEF_(0x001B0007L)")]
        public const int WER_S_REPORT_ASYNC = ((int)(0x001B0007));

        [NativeTypeName("#define WER_S_IGNORE_ASSERT_INSTANCE _HRESULT_TYPEDEF_(0x001B0008L)")]
        public const int WER_S_IGNORE_ASSERT_INSTANCE = ((int)(0x001B0008));

        [NativeTypeName("#define WER_S_IGNORE_ALL_ASSERTS _HRESULT_TYPEDEF_(0x001B0009L)")]
        public const int WER_S_IGNORE_ALL_ASSERTS = ((int)(0x001B0009));

        [NativeTypeName("#define WER_S_ASSERT_CONTINUE _HRESULT_TYPEDEF_(0x001B000AL)")]
        public const int WER_S_ASSERT_CONTINUE = ((int)(0x001B000A));

        [NativeTypeName("#define WER_S_THROTTLED _HRESULT_TYPEDEF_(0x001B000BL)")]
        public const int WER_S_THROTTLED = ((int)(0x001B000B));

        [NativeTypeName("#define WER_S_REPORT_UPLOADED_CAB _HRESULT_TYPEDEF_(0x001B000CL)")]
        public const int WER_S_REPORT_UPLOADED_CAB = ((int)(0x001B000C));

        [NativeTypeName("#define WER_E_CRASH_FAILURE _HRESULT_TYPEDEF_(0x801B8000L)")]
        public const int WER_E_CRASH_FAILURE = unchecked((int)(0x801B8000));

        [NativeTypeName("#define WER_E_CANCELED _HRESULT_TYPEDEF_(0x801B8001L)")]
        public const int WER_E_CANCELED = unchecked((int)(0x801B8001));

        [NativeTypeName("#define WER_E_NETWORK_FAILURE _HRESULT_TYPEDEF_(0x801B8002L)")]
        public const int WER_E_NETWORK_FAILURE = unchecked((int)(0x801B8002));

        [NativeTypeName("#define WER_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x801B8003L)")]
        public const int WER_E_NOT_INITIALIZED = unchecked((int)(0x801B8003));

        [NativeTypeName("#define WER_E_ALREADY_REPORTING _HRESULT_TYPEDEF_(0x801B8004L)")]
        public const int WER_E_ALREADY_REPORTING = unchecked((int)(0x801B8004));

        [NativeTypeName("#define WER_E_DUMP_THROTTLED _HRESULT_TYPEDEF_(0x801B8005L)")]
        public const int WER_E_DUMP_THROTTLED = unchecked((int)(0x801B8005));

        [NativeTypeName("#define WER_E_INSUFFICIENT_CONSENT _HRESULT_TYPEDEF_(0x801B8006L)")]
        public const int WER_E_INSUFFICIENT_CONSENT = unchecked((int)(0x801B8006));

        [NativeTypeName("#define WER_E_TOO_HEAVY _HRESULT_TYPEDEF_(0x801B8007L)")]
        public const int WER_E_TOO_HEAVY = unchecked((int)(0x801B8007));

        [NativeTypeName("#define DWM_E_COMPOSITIONDISABLED _HRESULT_TYPEDEF_(0x80263001L)")]
        public const int DWM_E_COMPOSITIONDISABLED = unchecked((int)(0x80263001));

        [NativeTypeName("#define DWM_E_REMOTING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80263002L)")]
        public const int DWM_E_REMOTING_NOT_SUPPORTED = unchecked((int)(0x80263002));

        [NativeTypeName("#define DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE _HRESULT_TYPEDEF_(0x80263003L)")]
        public const int DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)(0x80263003));

        [NativeTypeName("#define DWM_E_NOT_QUEUING_PRESENTS _HRESULT_TYPEDEF_(0x80263004L)")]
        public const int DWM_E_NOT_QUEUING_PRESENTS = unchecked((int)(0x80263004));

        [NativeTypeName("#define DWM_E_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x80263005L)")]
        public const int DWM_E_ADAPTER_NOT_FOUND = unchecked((int)(0x80263005));

        [NativeTypeName("#define DWM_S_GDI_REDIRECTION_SURFACE _HRESULT_TYPEDEF_(0x00263005L)")]
        public const int DWM_S_GDI_REDIRECTION_SURFACE = ((int)(0x00263005));

        [NativeTypeName("#define DWM_E_TEXTURE_TOO_LARGE _HRESULT_TYPEDEF_(0x80263007L)")]
        public const int DWM_E_TEXTURE_TOO_LARGE = unchecked((int)(0x80263007));

        [NativeTypeName("#define DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI _HRESULT_TYPEDEF_(0x00263008L)")]
        public const int DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI = ((int)(0x00263008));

        [NativeTypeName("#define NAP_E_INVALID_PACKET _HRESULT_TYPEDEF_(0x80270001L)")]
        public const int NAP_E_INVALID_PACKET = unchecked((int)(0x80270001));

        [NativeTypeName("#define NAP_E_MISSING_SOH _HRESULT_TYPEDEF_(0x80270002L)")]
        public const int NAP_E_MISSING_SOH = unchecked((int)(0x80270002));

        [NativeTypeName("#define NAP_E_CONFLICTING_ID _HRESULT_TYPEDEF_(0x80270003L)")]
        public const int NAP_E_CONFLICTING_ID = unchecked((int)(0x80270003));

        [NativeTypeName("#define NAP_E_NO_CACHED_SOH _HRESULT_TYPEDEF_(0x80270004L)")]
        public const int NAP_E_NO_CACHED_SOH = unchecked((int)(0x80270004));

        [NativeTypeName("#define NAP_E_STILL_BOUND _HRESULT_TYPEDEF_(0x80270005L)")]
        public const int NAP_E_STILL_BOUND = unchecked((int)(0x80270005));

        [NativeTypeName("#define NAP_E_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80270006L)")]
        public const int NAP_E_NOT_REGISTERED = unchecked((int)(0x80270006));

        [NativeTypeName("#define NAP_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80270007L)")]
        public const int NAP_E_NOT_INITIALIZED = unchecked((int)(0x80270007));

        [NativeTypeName("#define NAP_E_MISMATCHED_ID _HRESULT_TYPEDEF_(0x80270008L)")]
        public const int NAP_E_MISMATCHED_ID = unchecked((int)(0x80270008));

        [NativeTypeName("#define NAP_E_NOT_PENDING _HRESULT_TYPEDEF_(0x80270009L)")]
        public const int NAP_E_NOT_PENDING = unchecked((int)(0x80270009));

        [NativeTypeName("#define NAP_E_ID_NOT_FOUND _HRESULT_TYPEDEF_(0x8027000AL)")]
        public const int NAP_E_ID_NOT_FOUND = unchecked((int)(0x8027000A));

        [NativeTypeName("#define NAP_E_MAXSIZE_TOO_SMALL _HRESULT_TYPEDEF_(0x8027000BL)")]
        public const int NAP_E_MAXSIZE_TOO_SMALL = unchecked((int)(0x8027000B));

        [NativeTypeName("#define NAP_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x8027000CL)")]
        public const int NAP_E_SERVICE_NOT_RUNNING = unchecked((int)(0x8027000C));

        [NativeTypeName("#define NAP_S_CERT_ALREADY_PRESENT _HRESULT_TYPEDEF_(0x0027000DL)")]
        public const int NAP_S_CERT_ALREADY_PRESENT = ((int)(0x0027000D));

        [NativeTypeName("#define NAP_E_ENTITY_DISABLED _HRESULT_TYPEDEF_(0x8027000EL)")]
        public const int NAP_E_ENTITY_DISABLED = unchecked((int)(0x8027000E));

        [NativeTypeName("#define NAP_E_NETSH_GROUPPOLICY_ERROR _HRESULT_TYPEDEF_(0x8027000FL)")]
        public const int NAP_E_NETSH_GROUPPOLICY_ERROR = unchecked((int)(0x8027000F));

        [NativeTypeName("#define NAP_E_TOO_MANY_CALLS _HRESULT_TYPEDEF_(0x80270010L)")]
        public const int NAP_E_TOO_MANY_CALLS = unchecked((int)(0x80270010));

        [NativeTypeName("#define NAP_E_SHV_CONFIG_EXISTED _HRESULT_TYPEDEF_(0x80270011L)")]
        public const int NAP_E_SHV_CONFIG_EXISTED = unchecked((int)(0x80270011));

        [NativeTypeName("#define NAP_E_SHV_CONFIG_NOT_FOUND _HRESULT_TYPEDEF_(0x80270012L)")]
        public const int NAP_E_SHV_CONFIG_NOT_FOUND = unchecked((int)(0x80270012));

        [NativeTypeName("#define NAP_E_SHV_TIMEOUT _HRESULT_TYPEDEF_(0x80270013L)")]
        public const int NAP_E_SHV_TIMEOUT = unchecked((int)(0x80270013));

        [NativeTypeName("#define TBS_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80284001L)")]
        public const int TBS_E_INTERNAL_ERROR = unchecked((int)(0x80284001));

        [NativeTypeName("#define TBS_E_BAD_PARAMETER _HRESULT_TYPEDEF_(0x80284002L)")]
        public const int TBS_E_BAD_PARAMETER = unchecked((int)(0x80284002));

        [NativeTypeName("#define TBS_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80284003L)")]
        public const int TBS_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80284003));

        [NativeTypeName("#define TBS_E_INVALID_CONTEXT _HRESULT_TYPEDEF_(0x80284004L)")]
        public const int TBS_E_INVALID_CONTEXT = unchecked((int)(0x80284004));

        [NativeTypeName("#define TBS_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80284005L)")]
        public const int TBS_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80284005));

        [NativeTypeName("#define TBS_E_IOERROR _HRESULT_TYPEDEF_(0x80284006L)")]
        public const int TBS_E_IOERROR = unchecked((int)(0x80284006));

        [NativeTypeName("#define TBS_E_INVALID_CONTEXT_PARAM _HRESULT_TYPEDEF_(0x80284007L)")]
        public const int TBS_E_INVALID_CONTEXT_PARAM = unchecked((int)(0x80284007));

        [NativeTypeName("#define TBS_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x80284008L)")]
        public const int TBS_E_SERVICE_NOT_RUNNING = unchecked((int)(0x80284008));

        [NativeTypeName("#define TBS_E_TOO_MANY_TBS_CONTEXTS _HRESULT_TYPEDEF_(0x80284009L)")]
        public const int TBS_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)(0x80284009));

        [NativeTypeName("#define TBS_E_TOO_MANY_RESOURCES _HRESULT_TYPEDEF_(0x8028400AL)")]
        public const int TBS_E_TOO_MANY_RESOURCES = unchecked((int)(0x8028400A));

        [NativeTypeName("#define TBS_E_SERVICE_START_PENDING _HRESULT_TYPEDEF_(0x8028400BL)")]
        public const int TBS_E_SERVICE_START_PENDING = unchecked((int)(0x8028400B));

        [NativeTypeName("#define TBS_E_PPI_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8028400CL)")]
        public const int TBS_E_PPI_NOT_SUPPORTED = unchecked((int)(0x8028400C));

        [NativeTypeName("#define TBS_E_COMMAND_CANCELED _HRESULT_TYPEDEF_(0x8028400DL)")]
        public const int TBS_E_COMMAND_CANCELED = unchecked((int)(0x8028400D));

        [NativeTypeName("#define TBS_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x8028400EL)")]
        public const int TBS_E_BUFFER_TOO_LARGE = unchecked((int)(0x8028400E));

        [NativeTypeName("#define TBS_E_TPM_NOT_FOUND _HRESULT_TYPEDEF_(0x8028400FL)")]
        public const int TBS_E_TPM_NOT_FOUND = unchecked((int)(0x8028400F));

        [NativeTypeName("#define TBS_E_SERVICE_DISABLED _HRESULT_TYPEDEF_(0x80284010L)")]
        public const int TBS_E_SERVICE_DISABLED = unchecked((int)(0x80284010));

        [NativeTypeName("#define TBS_E_NO_EVENT_LOG _HRESULT_TYPEDEF_(0x80284011L)")]
        public const int TBS_E_NO_EVENT_LOG = unchecked((int)(0x80284011));

        [NativeTypeName("#define TBS_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80284012L)")]
        public const int TBS_E_ACCESS_DENIED = unchecked((int)(0x80284012));

        [NativeTypeName("#define TBS_E_PROVISIONING_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80284013L)")]
        public const int TBS_E_PROVISIONING_NOT_ALLOWED = unchecked((int)(0x80284013));

        [NativeTypeName("#define TBS_E_PPI_FUNCTION_UNSUPPORTED _HRESULT_TYPEDEF_(0x80284014L)")]
        public const int TBS_E_PPI_FUNCTION_UNSUPPORTED = unchecked((int)(0x80284014));

        [NativeTypeName("#define TBS_E_OWNERAUTH_NOT_FOUND _HRESULT_TYPEDEF_(0x80284015L)")]
        public const int TBS_E_OWNERAUTH_NOT_FOUND = unchecked((int)(0x80284015));

        [NativeTypeName("#define TBS_E_PROVISIONING_INCOMPLETE _HRESULT_TYPEDEF_(0x80284016L)")]
        public const int TBS_E_PROVISIONING_INCOMPLETE = unchecked((int)(0x80284016));

        [NativeTypeName("#define TPMAPI_E_INVALID_STATE _HRESULT_TYPEDEF_(0x80290100L)")]
        public const int TPMAPI_E_INVALID_STATE = unchecked((int)(0x80290100));

        [NativeTypeName("#define TPMAPI_E_NOT_ENOUGH_DATA _HRESULT_TYPEDEF_(0x80290101L)")]
        public const int TPMAPI_E_NOT_ENOUGH_DATA = unchecked((int)(0x80290101));

        [NativeTypeName("#define TPMAPI_E_TOO_MUCH_DATA _HRESULT_TYPEDEF_(0x80290102L)")]
        public const int TPMAPI_E_TOO_MUCH_DATA = unchecked((int)(0x80290102));

        [NativeTypeName("#define TPMAPI_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80290103L)")]
        public const int TPMAPI_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80290103));

        [NativeTypeName("#define TPMAPI_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290104L)")]
        public const int TPMAPI_E_INVALID_PARAMETER = unchecked((int)(0x80290104));

        [NativeTypeName("#define TPMAPI_E_OUT_OF_MEMORY _HRESULT_TYPEDEF_(0x80290105L)")]
        public const int TPMAPI_E_OUT_OF_MEMORY = unchecked((int)(0x80290105));

        [NativeTypeName("#define TPMAPI_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290106L)")]
        public const int TPMAPI_E_BUFFER_TOO_SMALL = unchecked((int)(0x80290106));

        [NativeTypeName("#define TPMAPI_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80290107L)")]
        public const int TPMAPI_E_INTERNAL_ERROR = unchecked((int)(0x80290107));

        [NativeTypeName("#define TPMAPI_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80290108L)")]
        public const int TPMAPI_E_ACCESS_DENIED = unchecked((int)(0x80290108));

        [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_FAILED _HRESULT_TYPEDEF_(0x80290109L)")]
        public const int TPMAPI_E_AUTHORIZATION_FAILED = unchecked((int)(0x80290109));

        [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_HANDLE _HRESULT_TYPEDEF_(0x8029010AL)")]
        public const int TPMAPI_E_INVALID_CONTEXT_HANDLE = unchecked((int)(0x8029010A));

        [NativeTypeName("#define TPMAPI_E_TBS_COMMUNICATION_ERROR _HRESULT_TYPEDEF_(0x8029010BL)")]
        public const int TPMAPI_E_TBS_COMMUNICATION_ERROR = unchecked((int)(0x8029010B));

        [NativeTypeName("#define TPMAPI_E_TPM_COMMAND_ERROR _HRESULT_TYPEDEF_(0x8029010CL)")]
        public const int TPMAPI_E_TPM_COMMAND_ERROR = unchecked((int)(0x8029010C));

        [NativeTypeName("#define TPMAPI_E_MESSAGE_TOO_LARGE _HRESULT_TYPEDEF_(0x8029010DL)")]
        public const int TPMAPI_E_MESSAGE_TOO_LARGE = unchecked((int)(0x8029010D));

        [NativeTypeName("#define TPMAPI_E_INVALID_ENCODING _HRESULT_TYPEDEF_(0x8029010EL)")]
        public const int TPMAPI_E_INVALID_ENCODING = unchecked((int)(0x8029010E));

        [NativeTypeName("#define TPMAPI_E_INVALID_KEY_SIZE _HRESULT_TYPEDEF_(0x8029010FL)")]
        public const int TPMAPI_E_INVALID_KEY_SIZE = unchecked((int)(0x8029010F));

        [NativeTypeName("#define TPMAPI_E_ENCRYPTION_FAILED _HRESULT_TYPEDEF_(0x80290110L)")]
        public const int TPMAPI_E_ENCRYPTION_FAILED = unchecked((int)(0x80290110));

        [NativeTypeName("#define TPMAPI_E_INVALID_KEY_PARAMS _HRESULT_TYPEDEF_(0x80290111L)")]
        public const int TPMAPI_E_INVALID_KEY_PARAMS = unchecked((int)(0x80290111));

        [NativeTypeName("#define TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB _HRESULT_TYPEDEF_(0x80290112L)")]
        public const int TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB = unchecked((int)(0x80290112));

        [NativeTypeName("#define TPMAPI_E_INVALID_PCR_INDEX _HRESULT_TYPEDEF_(0x80290113L)")]
        public const int TPMAPI_E_INVALID_PCR_INDEX = unchecked((int)(0x80290113));

        [NativeTypeName("#define TPMAPI_E_INVALID_DELEGATE_BLOB _HRESULT_TYPEDEF_(0x80290114L)")]
        public const int TPMAPI_E_INVALID_DELEGATE_BLOB = unchecked((int)(0x80290114));

        [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_PARAMS _HRESULT_TYPEDEF_(0x80290115L)")]
        public const int TPMAPI_E_INVALID_CONTEXT_PARAMS = unchecked((int)(0x80290115));

        [NativeTypeName("#define TPMAPI_E_INVALID_KEY_BLOB _HRESULT_TYPEDEF_(0x80290116L)")]
        public const int TPMAPI_E_INVALID_KEY_BLOB = unchecked((int)(0x80290116));

        [NativeTypeName("#define TPMAPI_E_INVALID_PCR_DATA _HRESULT_TYPEDEF_(0x80290117L)")]
        public const int TPMAPI_E_INVALID_PCR_DATA = unchecked((int)(0x80290117));

        [NativeTypeName("#define TPMAPI_E_INVALID_OWNER_AUTH _HRESULT_TYPEDEF_(0x80290118L)")]
        public const int TPMAPI_E_INVALID_OWNER_AUTH = unchecked((int)(0x80290118));

        [NativeTypeName("#define TPMAPI_E_FIPS_RNG_CHECK_FAILED _HRESULT_TYPEDEF_(0x80290119L)")]
        public const int TPMAPI_E_FIPS_RNG_CHECK_FAILED = unchecked((int)(0x80290119));

        [NativeTypeName("#define TPMAPI_E_EMPTY_TCG_LOG _HRESULT_TYPEDEF_(0x8029011AL)")]
        public const int TPMAPI_E_EMPTY_TCG_LOG = unchecked((int)(0x8029011A));

        [NativeTypeName("#define TPMAPI_E_INVALID_TCG_LOG_ENTRY _HRESULT_TYPEDEF_(0x8029011BL)")]
        public const int TPMAPI_E_INVALID_TCG_LOG_ENTRY = unchecked((int)(0x8029011B));

        [NativeTypeName("#define TPMAPI_E_TCG_SEPARATOR_ABSENT _HRESULT_TYPEDEF_(0x8029011CL)")]
        public const int TPMAPI_E_TCG_SEPARATOR_ABSENT = unchecked((int)(0x8029011C));

        [NativeTypeName("#define TPMAPI_E_TCG_INVALID_DIGEST_ENTRY _HRESULT_TYPEDEF_(0x8029011DL)")]
        public const int TPMAPI_E_TCG_INVALID_DIGEST_ENTRY = unchecked((int)(0x8029011D));

        [NativeTypeName("#define TPMAPI_E_POLICY_DENIES_OPERATION _HRESULT_TYPEDEF_(0x8029011EL)")]
        public const int TPMAPI_E_POLICY_DENIES_OPERATION = unchecked((int)(0x8029011E));

        [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_DEFINED _HRESULT_TYPEDEF_(0x8029011FL)")]
        public const int TPMAPI_E_NV_BITS_NOT_DEFINED = unchecked((int)(0x8029011F));

        [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_READY _HRESULT_TYPEDEF_(0x80290120L)")]
        public const int TPMAPI_E_NV_BITS_NOT_READY = unchecked((int)(0x80290120));

        [NativeTypeName("#define TPMAPI_E_SEALING_KEY_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290121L)")]
        public const int TPMAPI_E_SEALING_KEY_NOT_AVAILABLE = unchecked((int)(0x80290121));

        [NativeTypeName("#define TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND _HRESULT_TYPEDEF_(0x80290122L)")]
        public const int TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND = unchecked((int)(0x80290122));

        [NativeTypeName("#define TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290123L)")]
        public const int TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE = unchecked((int)(0x80290123));

        [NativeTypeName("#define TPMAPI_E_OWNER_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290124L)")]
        public const int TPMAPI_E_OWNER_AUTH_NOT_NULL = unchecked((int)(0x80290124));

        [NativeTypeName("#define TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290125L)")]
        public const int TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL = unchecked((int)(0x80290125));

        [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_REVOKED _HRESULT_TYPEDEF_(0x80290126L)")]
        public const int TPMAPI_E_AUTHORIZATION_REVOKED = unchecked((int)(0x80290126));

        [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_KEY _HRESULT_TYPEDEF_(0x80290127L)")]
        public const int TPMAPI_E_MALFORMED_AUTHORIZATION_KEY = unchecked((int)(0x80290127));

        [NativeTypeName("#define TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290128L)")]
        public const int TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED = unchecked((int)(0x80290128));

        [NativeTypeName("#define TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE _HRESULT_TYPEDEF_(0x80290129L)")]
        public const int TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE = unchecked((int)(0x80290129));

        [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY _HRESULT_TYPEDEF_(0x8029012AL)")]
        public const int TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY = unchecked((int)(0x8029012A));

        [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER _HRESULT_TYPEDEF_(0x8029012BL)")]
        public const int TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER = unchecked((int)(0x8029012B));

        [NativeTypeName("#define TPMAPI_E_SEALING_KEY_CHANGED _HRESULT_TYPEDEF_(0x8029012CL)")]
        public const int TPMAPI_E_SEALING_KEY_CHANGED = unchecked((int)(0x8029012C));

        [NativeTypeName("#define TPMAPI_E_INVALID_TPM_VERSION _HRESULT_TYPEDEF_(0x8029012DL)")]
        public const int TPMAPI_E_INVALID_TPM_VERSION = unchecked((int)(0x8029012D));

        [NativeTypeName("#define TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE _HRESULT_TYPEDEF_(0x8029012EL)")]
        public const int TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE = unchecked((int)(0x8029012E));

        [NativeTypeName("#define TBSIMP_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290200L)")]
        public const int TBSIMP_E_BUFFER_TOO_SMALL = unchecked((int)(0x80290200));

        [NativeTypeName("#define TBSIMP_E_CLEANUP_FAILED _HRESULT_TYPEDEF_(0x80290201L)")]
        public const int TBSIMP_E_CLEANUP_FAILED = unchecked((int)(0x80290201));

        [NativeTypeName("#define TBSIMP_E_INVALID_CONTEXT_HANDLE _HRESULT_TYPEDEF_(0x80290202L)")]
        public const int TBSIMP_E_INVALID_CONTEXT_HANDLE = unchecked((int)(0x80290202));

        [NativeTypeName("#define TBSIMP_E_INVALID_CONTEXT_PARAM _HRESULT_TYPEDEF_(0x80290203L)")]
        public const int TBSIMP_E_INVALID_CONTEXT_PARAM = unchecked((int)(0x80290203));

        [NativeTypeName("#define TBSIMP_E_TPM_ERROR _HRESULT_TYPEDEF_(0x80290204L)")]
        public const int TBSIMP_E_TPM_ERROR = unchecked((int)(0x80290204));

        [NativeTypeName("#define TBSIMP_E_HASH_BAD_KEY _HRESULT_TYPEDEF_(0x80290205L)")]
        public const int TBSIMP_E_HASH_BAD_KEY = unchecked((int)(0x80290205));

        [NativeTypeName("#define TBSIMP_E_DUPLICATE_VHANDLE _HRESULT_TYPEDEF_(0x80290206L)")]
        public const int TBSIMP_E_DUPLICATE_VHANDLE = unchecked((int)(0x80290206));

        [NativeTypeName("#define TBSIMP_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80290207L)")]
        public const int TBSIMP_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80290207));

        [NativeTypeName("#define TBSIMP_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290208L)")]
        public const int TBSIMP_E_INVALID_PARAMETER = unchecked((int)(0x80290208));

        [NativeTypeName("#define TBSIMP_E_RPC_INIT_FAILED _HRESULT_TYPEDEF_(0x80290209L)")]
        public const int TBSIMP_E_RPC_INIT_FAILED = unchecked((int)(0x80290209));

        [NativeTypeName("#define TBSIMP_E_SCHEDULER_NOT_RUNNING _HRESULT_TYPEDEF_(0x8029020AL)")]
        public const int TBSIMP_E_SCHEDULER_NOT_RUNNING = unchecked((int)(0x8029020A));

        [NativeTypeName("#define TBSIMP_E_COMMAND_CANCELED _HRESULT_TYPEDEF_(0x8029020BL)")]
        public const int TBSIMP_E_COMMAND_CANCELED = unchecked((int)(0x8029020B));

        [NativeTypeName("#define TBSIMP_E_OUT_OF_MEMORY _HRESULT_TYPEDEF_(0x8029020CL)")]
        public const int TBSIMP_E_OUT_OF_MEMORY = unchecked((int)(0x8029020C));

        [NativeTypeName("#define TBSIMP_E_LIST_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x8029020DL)")]
        public const int TBSIMP_E_LIST_NO_MORE_ITEMS = unchecked((int)(0x8029020D));

        [NativeTypeName("#define TBSIMP_E_LIST_NOT_FOUND _HRESULT_TYPEDEF_(0x8029020EL)")]
        public const int TBSIMP_E_LIST_NOT_FOUND = unchecked((int)(0x8029020E));

        [NativeTypeName("#define TBSIMP_E_NOT_ENOUGH_SPACE _HRESULT_TYPEDEF_(0x8029020FL)")]
        public const int TBSIMP_E_NOT_ENOUGH_SPACE = unchecked((int)(0x8029020F));

        [NativeTypeName("#define TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS _HRESULT_TYPEDEF_(0x80290210L)")]
        public const int TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS = unchecked((int)(0x80290210));

        [NativeTypeName("#define TBSIMP_E_COMMAND_FAILED _HRESULT_TYPEDEF_(0x80290211L)")]
        public const int TBSIMP_E_COMMAND_FAILED = unchecked((int)(0x80290211));

        [NativeTypeName("#define TBSIMP_E_UNKNOWN_ORDINAL _HRESULT_TYPEDEF_(0x80290212L)")]
        public const int TBSIMP_E_UNKNOWN_ORDINAL = unchecked((int)(0x80290212));

        [NativeTypeName("#define TBSIMP_E_RESOURCE_EXPIRED _HRESULT_TYPEDEF_(0x80290213L)")]
        public const int TBSIMP_E_RESOURCE_EXPIRED = unchecked((int)(0x80290213));

        [NativeTypeName("#define TBSIMP_E_INVALID_RESOURCE _HRESULT_TYPEDEF_(0x80290214L)")]
        public const int TBSIMP_E_INVALID_RESOURCE = unchecked((int)(0x80290214));

        [NativeTypeName("#define TBSIMP_E_NOTHING_TO_UNLOAD _HRESULT_TYPEDEF_(0x80290215L)")]
        public const int TBSIMP_E_NOTHING_TO_UNLOAD = unchecked((int)(0x80290215));

        [NativeTypeName("#define TBSIMP_E_HASH_TABLE_FULL _HRESULT_TYPEDEF_(0x80290216L)")]
        public const int TBSIMP_E_HASH_TABLE_FULL = unchecked((int)(0x80290216));

        [NativeTypeName("#define TBSIMP_E_TOO_MANY_TBS_CONTEXTS _HRESULT_TYPEDEF_(0x80290217L)")]
        public const int TBSIMP_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)(0x80290217));

        [NativeTypeName("#define TBSIMP_E_TOO_MANY_RESOURCES _HRESULT_TYPEDEF_(0x80290218L)")]
        public const int TBSIMP_E_TOO_MANY_RESOURCES = unchecked((int)(0x80290218));

        [NativeTypeName("#define TBSIMP_E_PPI_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290219L)")]
        public const int TBSIMP_E_PPI_NOT_SUPPORTED = unchecked((int)(0x80290219));

        [NativeTypeName("#define TBSIMP_E_TPM_INCOMPATIBLE _HRESULT_TYPEDEF_(0x8029021AL)")]
        public const int TBSIMP_E_TPM_INCOMPATIBLE = unchecked((int)(0x8029021A));

        [NativeTypeName("#define TBSIMP_E_NO_EVENT_LOG _HRESULT_TYPEDEF_(0x8029021BL)")]
        public const int TBSIMP_E_NO_EVENT_LOG = unchecked((int)(0x8029021B));

        [NativeTypeName("#define PLA_E_DCS_NOT_FOUND _HRESULT_TYPEDEF_(0x80300002L)")]
        public const int PLA_E_DCS_NOT_FOUND = unchecked((int)(0x80300002));

        [NativeTypeName("#define PLA_E_DCS_IN_USE _HRESULT_TYPEDEF_(0x803000AAL)")]
        public const int PLA_E_DCS_IN_USE = unchecked((int)(0x803000AA));

        [NativeTypeName("#define PLA_E_TOO_MANY_FOLDERS _HRESULT_TYPEDEF_(0x80300045L)")]
        public const int PLA_E_TOO_MANY_FOLDERS = unchecked((int)(0x80300045));

        [NativeTypeName("#define PLA_E_NO_MIN_DISK _HRESULT_TYPEDEF_(0x80300070L)")]
        public const int PLA_E_NO_MIN_DISK = unchecked((int)(0x80300070));

        [NativeTypeName("#define PLA_E_DCS_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803000B7L)")]
        public const int PLA_E_DCS_ALREADY_EXISTS = unchecked((int)(0x803000B7));

        [NativeTypeName("#define PLA_S_PROPERTY_IGNORED _HRESULT_TYPEDEF_(0x00300100L)")]
        public const int PLA_S_PROPERTY_IGNORED = ((int)(0x00300100));

        [NativeTypeName("#define PLA_E_PROPERTY_CONFLICT _HRESULT_TYPEDEF_(0x80300101L)")]
        public const int PLA_E_PROPERTY_CONFLICT = unchecked((int)(0x80300101));

        [NativeTypeName("#define PLA_E_DCS_SINGLETON_REQUIRED _HRESULT_TYPEDEF_(0x80300102L)")]
        public const int PLA_E_DCS_SINGLETON_REQUIRED = unchecked((int)(0x80300102));

        [NativeTypeName("#define PLA_E_CREDENTIALS_REQUIRED _HRESULT_TYPEDEF_(0x80300103L)")]
        public const int PLA_E_CREDENTIALS_REQUIRED = unchecked((int)(0x80300103));

        [NativeTypeName("#define PLA_E_DCS_NOT_RUNNING _HRESULT_TYPEDEF_(0x80300104L)")]
        public const int PLA_E_DCS_NOT_RUNNING = unchecked((int)(0x80300104));

        [NativeTypeName("#define PLA_E_CONFLICT_INCL_EXCL_API _HRESULT_TYPEDEF_(0x80300105L)")]
        public const int PLA_E_CONFLICT_INCL_EXCL_API = unchecked((int)(0x80300105));

        [NativeTypeName("#define PLA_E_NETWORK_EXE_NOT_VALID _HRESULT_TYPEDEF_(0x80300106L)")]
        public const int PLA_E_NETWORK_EXE_NOT_VALID = unchecked((int)(0x80300106));

        [NativeTypeName("#define PLA_E_EXE_ALREADY_CONFIGURED _HRESULT_TYPEDEF_(0x80300107L)")]
        public const int PLA_E_EXE_ALREADY_CONFIGURED = unchecked((int)(0x80300107));

        [NativeTypeName("#define PLA_E_EXE_PATH_NOT_VALID _HRESULT_TYPEDEF_(0x80300108L)")]
        public const int PLA_E_EXE_PATH_NOT_VALID = unchecked((int)(0x80300108));

        [NativeTypeName("#define PLA_E_DC_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80300109L)")]
        public const int PLA_E_DC_ALREADY_EXISTS = unchecked((int)(0x80300109));

        [NativeTypeName("#define PLA_E_DCS_START_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010AL)")]
        public const int PLA_E_DCS_START_WAIT_TIMEOUT = unchecked((int)(0x8030010A));

        [NativeTypeName("#define PLA_E_DC_START_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010BL)")]
        public const int PLA_E_DC_START_WAIT_TIMEOUT = unchecked((int)(0x8030010B));

        [NativeTypeName("#define PLA_E_REPORT_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010CL)")]
        public const int PLA_E_REPORT_WAIT_TIMEOUT = unchecked((int)(0x8030010C));

        [NativeTypeName("#define PLA_E_NO_DUPLICATES _HRESULT_TYPEDEF_(0x8030010DL)")]
        public const int PLA_E_NO_DUPLICATES = unchecked((int)(0x8030010D));

        [NativeTypeName("#define PLA_E_EXE_FULL_PATH_REQUIRED _HRESULT_TYPEDEF_(0x8030010EL)")]
        public const int PLA_E_EXE_FULL_PATH_REQUIRED = unchecked((int)(0x8030010E));

        [NativeTypeName("#define PLA_E_INVALID_SESSION_NAME _HRESULT_TYPEDEF_(0x8030010FL)")]
        public const int PLA_E_INVALID_SESSION_NAME = unchecked((int)(0x8030010F));

        [NativeTypeName("#define PLA_E_PLA_CHANNEL_NOT_ENABLED _HRESULT_TYPEDEF_(0x80300110L)")]
        public const int PLA_E_PLA_CHANNEL_NOT_ENABLED = unchecked((int)(0x80300110));

        [NativeTypeName("#define PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED _HRESULT_TYPEDEF_(0x80300111L)")]
        public const int PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED = unchecked((int)(0x80300111));

        [NativeTypeName("#define PLA_E_RULES_MANAGER_FAILED _HRESULT_TYPEDEF_(0x80300112L)")]
        public const int PLA_E_RULES_MANAGER_FAILED = unchecked((int)(0x80300112));

        [NativeTypeName("#define PLA_E_CABAPI_FAILURE _HRESULT_TYPEDEF_(0x80300113L)")]
        public const int PLA_E_CABAPI_FAILURE = unchecked((int)(0x80300113));

        [NativeTypeName("#define FWP_E_CALLOUT_NOT_FOUND _HRESULT_TYPEDEF_(0x80320001L)")]
        public const int FWP_E_CALLOUT_NOT_FOUND = unchecked((int)(0x80320001));

        [NativeTypeName("#define FWP_E_CONDITION_NOT_FOUND _HRESULT_TYPEDEF_(0x80320002L)")]
        public const int FWP_E_CONDITION_NOT_FOUND = unchecked((int)(0x80320002));

        [NativeTypeName("#define FWP_E_FILTER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320003L)")]
        public const int FWP_E_FILTER_NOT_FOUND = unchecked((int)(0x80320003));

        [NativeTypeName("#define FWP_E_LAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320004L)")]
        public const int FWP_E_LAYER_NOT_FOUND = unchecked((int)(0x80320004));

        [NativeTypeName("#define FWP_E_PROVIDER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320005L)")]
        public const int FWP_E_PROVIDER_NOT_FOUND = unchecked((int)(0x80320005));

        [NativeTypeName("#define FWP_E_PROVIDER_CONTEXT_NOT_FOUND _HRESULT_TYPEDEF_(0x80320006L)")]
        public const int FWP_E_PROVIDER_CONTEXT_NOT_FOUND = unchecked((int)(0x80320006));

        [NativeTypeName("#define FWP_E_SUBLAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320007L)")]
        public const int FWP_E_SUBLAYER_NOT_FOUND = unchecked((int)(0x80320007));

        [NativeTypeName("#define FWP_E_NOT_FOUND _HRESULT_TYPEDEF_(0x80320008L)")]
        public const int FWP_E_NOT_FOUND = unchecked((int)(0x80320008));

        [NativeTypeName("#define FWP_E_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80320009L)")]
        public const int FWP_E_ALREADY_EXISTS = unchecked((int)(0x80320009));

        [NativeTypeName("#define FWP_E_IN_USE _HRESULT_TYPEDEF_(0x8032000AL)")]
        public const int FWP_E_IN_USE = unchecked((int)(0x8032000A));

        [NativeTypeName("#define FWP_E_DYNAMIC_SESSION_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000BL)")]
        public const int FWP_E_DYNAMIC_SESSION_IN_PROGRESS = unchecked((int)(0x8032000B));

        [NativeTypeName("#define FWP_E_WRONG_SESSION _HRESULT_TYPEDEF_(0x8032000CL)")]
        public const int FWP_E_WRONG_SESSION = unchecked((int)(0x8032000C));

        [NativeTypeName("#define FWP_E_NO_TXN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000DL)")]
        public const int FWP_E_NO_TXN_IN_PROGRESS = unchecked((int)(0x8032000D));

        [NativeTypeName("#define FWP_E_TXN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000EL)")]
        public const int FWP_E_TXN_IN_PROGRESS = unchecked((int)(0x8032000E));

        [NativeTypeName("#define FWP_E_TXN_ABORTED _HRESULT_TYPEDEF_(0x8032000FL)")]
        public const int FWP_E_TXN_ABORTED = unchecked((int)(0x8032000F));

        [NativeTypeName("#define FWP_E_SESSION_ABORTED _HRESULT_TYPEDEF_(0x80320010L)")]
        public const int FWP_E_SESSION_ABORTED = unchecked((int)(0x80320010));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_TXN _HRESULT_TYPEDEF_(0x80320011L)")]
        public const int FWP_E_INCOMPATIBLE_TXN = unchecked((int)(0x80320011));

        [NativeTypeName("#define FWP_E_TIMEOUT _HRESULT_TYPEDEF_(0x80320012L)")]
        public const int FWP_E_TIMEOUT = unchecked((int)(0x80320012));

        [NativeTypeName("#define FWP_E_NET_EVENTS_DISABLED _HRESULT_TYPEDEF_(0x80320013L)")]
        public const int FWP_E_NET_EVENTS_DISABLED = unchecked((int)(0x80320013));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_LAYER _HRESULT_TYPEDEF_(0x80320014L)")]
        public const int FWP_E_INCOMPATIBLE_LAYER = unchecked((int)(0x80320014));

        [NativeTypeName("#define FWP_E_KM_CLIENTS_ONLY _HRESULT_TYPEDEF_(0x80320015L)")]
        public const int FWP_E_KM_CLIENTS_ONLY = unchecked((int)(0x80320015));

        [NativeTypeName("#define FWP_E_LIFETIME_MISMATCH _HRESULT_TYPEDEF_(0x80320016L)")]
        public const int FWP_E_LIFETIME_MISMATCH = unchecked((int)(0x80320016));

        [NativeTypeName("#define FWP_E_BUILTIN_OBJECT _HRESULT_TYPEDEF_(0x80320017L)")]
        public const int FWP_E_BUILTIN_OBJECT = unchecked((int)(0x80320017));

        [NativeTypeName("#define FWP_E_TOO_MANY_CALLOUTS _HRESULT_TYPEDEF_(0x80320018L)")]
        public const int FWP_E_TOO_MANY_CALLOUTS = unchecked((int)(0x80320018));

        [NativeTypeName("#define FWP_E_NOTIFICATION_DROPPED _HRESULT_TYPEDEF_(0x80320019L)")]
        public const int FWP_E_NOTIFICATION_DROPPED = unchecked((int)(0x80320019));

        [NativeTypeName("#define FWP_E_TRAFFIC_MISMATCH _HRESULT_TYPEDEF_(0x8032001AL)")]
        public const int FWP_E_TRAFFIC_MISMATCH = unchecked((int)(0x8032001A));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_SA_STATE _HRESULT_TYPEDEF_(0x8032001BL)")]
        public const int FWP_E_INCOMPATIBLE_SA_STATE = unchecked((int)(0x8032001B));

        [NativeTypeName("#define FWP_E_NULL_POINTER _HRESULT_TYPEDEF_(0x8032001CL)")]
        public const int FWP_E_NULL_POINTER = unchecked((int)(0x8032001C));

        [NativeTypeName("#define FWP_E_INVALID_ENUMERATOR _HRESULT_TYPEDEF_(0x8032001DL)")]
        public const int FWP_E_INVALID_ENUMERATOR = unchecked((int)(0x8032001D));

        [NativeTypeName("#define FWP_E_INVALID_FLAGS _HRESULT_TYPEDEF_(0x8032001EL)")]
        public const int FWP_E_INVALID_FLAGS = unchecked((int)(0x8032001E));

        [NativeTypeName("#define FWP_E_INVALID_NET_MASK _HRESULT_TYPEDEF_(0x8032001FL)")]
        public const int FWP_E_INVALID_NET_MASK = unchecked((int)(0x8032001F));

        [NativeTypeName("#define FWP_E_INVALID_RANGE _HRESULT_TYPEDEF_(0x80320020L)")]
        public const int FWP_E_INVALID_RANGE = unchecked((int)(0x80320020));

        [NativeTypeName("#define FWP_E_INVALID_INTERVAL _HRESULT_TYPEDEF_(0x80320021L)")]
        public const int FWP_E_INVALID_INTERVAL = unchecked((int)(0x80320021));

        [NativeTypeName("#define FWP_E_ZERO_LENGTH_ARRAY _HRESULT_TYPEDEF_(0x80320022L)")]
        public const int FWP_E_ZERO_LENGTH_ARRAY = unchecked((int)(0x80320022));

        [NativeTypeName("#define FWP_E_NULL_DISPLAY_NAME _HRESULT_TYPEDEF_(0x80320023L)")]
        public const int FWP_E_NULL_DISPLAY_NAME = unchecked((int)(0x80320023));

        [NativeTypeName("#define FWP_E_INVALID_ACTION_TYPE _HRESULT_TYPEDEF_(0x80320024L)")]
        public const int FWP_E_INVALID_ACTION_TYPE = unchecked((int)(0x80320024));

        [NativeTypeName("#define FWP_E_INVALID_WEIGHT _HRESULT_TYPEDEF_(0x80320025L)")]
        public const int FWP_E_INVALID_WEIGHT = unchecked((int)(0x80320025));

        [NativeTypeName("#define FWP_E_MATCH_TYPE_MISMATCH _HRESULT_TYPEDEF_(0x80320026L)")]
        public const int FWP_E_MATCH_TYPE_MISMATCH = unchecked((int)(0x80320026));

        [NativeTypeName("#define FWP_E_TYPE_MISMATCH _HRESULT_TYPEDEF_(0x80320027L)")]
        public const int FWP_E_TYPE_MISMATCH = unchecked((int)(0x80320027));

        [NativeTypeName("#define FWP_E_OUT_OF_BOUNDS _HRESULT_TYPEDEF_(0x80320028L)")]
        public const int FWP_E_OUT_OF_BOUNDS = unchecked((int)(0x80320028));

        [NativeTypeName("#define FWP_E_RESERVED _HRESULT_TYPEDEF_(0x80320029L)")]
        public const int FWP_E_RESERVED = unchecked((int)(0x80320029));

        [NativeTypeName("#define FWP_E_DUPLICATE_CONDITION _HRESULT_TYPEDEF_(0x8032002AL)")]
        public const int FWP_E_DUPLICATE_CONDITION = unchecked((int)(0x8032002A));

        [NativeTypeName("#define FWP_E_DUPLICATE_KEYMOD _HRESULT_TYPEDEF_(0x8032002BL)")]
        public const int FWP_E_DUPLICATE_KEYMOD = unchecked((int)(0x8032002B));

        [NativeTypeName("#define FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER _HRESULT_TYPEDEF_(0x8032002CL)")]
        public const int FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0x8032002C));

        [NativeTypeName("#define FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER _HRESULT_TYPEDEF_(0x8032002DL)")]
        public const int FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER = unchecked((int)(0x8032002D));

        [NativeTypeName("#define FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER _HRESULT_TYPEDEF_(0x8032002EL)")]
        public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0x8032002E));

        [NativeTypeName("#define FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT _HRESULT_TYPEDEF_(0x8032002FL)")]
        public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = unchecked((int)(0x8032002F));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_AUTH_METHOD _HRESULT_TYPEDEF_(0x80320030L)")]
        public const int FWP_E_INCOMPATIBLE_AUTH_METHOD = unchecked((int)(0x80320030));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_DH_GROUP _HRESULT_TYPEDEF_(0x80320031L)")]
        public const int FWP_E_INCOMPATIBLE_DH_GROUP = unchecked((int)(0x80320031));

        [NativeTypeName("#define FWP_E_EM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80320032L)")]
        public const int FWP_E_EM_NOT_SUPPORTED = unchecked((int)(0x80320032));

        [NativeTypeName("#define FWP_E_NEVER_MATCH _HRESULT_TYPEDEF_(0x80320033L)")]
        public const int FWP_E_NEVER_MATCH = unchecked((int)(0x80320033));

        [NativeTypeName("#define FWP_E_PROVIDER_CONTEXT_MISMATCH _HRESULT_TYPEDEF_(0x80320034L)")]
        public const int FWP_E_PROVIDER_CONTEXT_MISMATCH = unchecked((int)(0x80320034));

        [NativeTypeName("#define FWP_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80320035L)")]
        public const int FWP_E_INVALID_PARAMETER = unchecked((int)(0x80320035));

        [NativeTypeName("#define FWP_E_TOO_MANY_SUBLAYERS _HRESULT_TYPEDEF_(0x80320036L)")]
        public const int FWP_E_TOO_MANY_SUBLAYERS = unchecked((int)(0x80320036));

        [NativeTypeName("#define FWP_E_CALLOUT_NOTIFICATION_FAILED _HRESULT_TYPEDEF_(0x80320037L)")]
        public const int FWP_E_CALLOUT_NOTIFICATION_FAILED = unchecked((int)(0x80320037));

        [NativeTypeName("#define FWP_E_INVALID_AUTH_TRANSFORM _HRESULT_TYPEDEF_(0x80320038L)")]
        public const int FWP_E_INVALID_AUTH_TRANSFORM = unchecked((int)(0x80320038));

        [NativeTypeName("#define FWP_E_INVALID_CIPHER_TRANSFORM _HRESULT_TYPEDEF_(0x80320039L)")]
        public const int FWP_E_INVALID_CIPHER_TRANSFORM = unchecked((int)(0x80320039));

        [NativeTypeName("#define FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM _HRESULT_TYPEDEF_(0x8032003AL)")]
        public const int FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM = unchecked((int)(0x8032003A));

        [NativeTypeName("#define FWP_E_INVALID_TRANSFORM_COMBINATION _HRESULT_TYPEDEF_(0x8032003BL)")]
        public const int FWP_E_INVALID_TRANSFORM_COMBINATION = unchecked((int)(0x8032003B));

        [NativeTypeName("#define FWP_E_DUPLICATE_AUTH_METHOD _HRESULT_TYPEDEF_(0x8032003CL)")]
        public const int FWP_E_DUPLICATE_AUTH_METHOD = unchecked((int)(0x8032003C));

        [NativeTypeName("#define FWP_E_INVALID_TUNNEL_ENDPOINT _HRESULT_TYPEDEF_(0x8032003DL)")]
        public const int FWP_E_INVALID_TUNNEL_ENDPOINT = unchecked((int)(0x8032003D));

        [NativeTypeName("#define FWP_E_L2_DRIVER_NOT_READY _HRESULT_TYPEDEF_(0x8032003EL)")]
        public const int FWP_E_L2_DRIVER_NOT_READY = unchecked((int)(0x8032003E));

        [NativeTypeName("#define FWP_E_KEY_DICTATOR_ALREADY_REGISTERED _HRESULT_TYPEDEF_(0x8032003FL)")]
        public const int FWP_E_KEY_DICTATOR_ALREADY_REGISTERED = unchecked((int)(0x8032003F));

        [NativeTypeName("#define FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL _HRESULT_TYPEDEF_(0x80320040L)")]
        public const int FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL = unchecked((int)(0x80320040));

        [NativeTypeName("#define FWP_E_CONNECTIONS_DISABLED _HRESULT_TYPEDEF_(0x80320041L)")]
        public const int FWP_E_CONNECTIONS_DISABLED = unchecked((int)(0x80320041));

        [NativeTypeName("#define FWP_E_INVALID_DNS_NAME _HRESULT_TYPEDEF_(0x80320042L)")]
        public const int FWP_E_INVALID_DNS_NAME = unchecked((int)(0x80320042));

        [NativeTypeName("#define FWP_E_STILL_ON _HRESULT_TYPEDEF_(0x80320043L)")]
        public const int FWP_E_STILL_ON = unchecked((int)(0x80320043));

        [NativeTypeName("#define FWP_E_IKEEXT_NOT_RUNNING _HRESULT_TYPEDEF_(0x80320044L)")]
        public const int FWP_E_IKEEXT_NOT_RUNNING = unchecked((int)(0x80320044));

        [NativeTypeName("#define FWP_E_DROP_NOICMP _HRESULT_TYPEDEF_(0x80320104L)")]
        public const int FWP_E_DROP_NOICMP = unchecked((int)(0x80320104));

        [NativeTypeName("#define WS_S_ASYNC _HRESULT_TYPEDEF_(0x003D0000L)")]
        public const int WS_S_ASYNC = ((int)(0x003D0000));

        [NativeTypeName("#define WS_S_END _HRESULT_TYPEDEF_(0x003D0001L)")]
        public const int WS_S_END = ((int)(0x003D0001));

        [NativeTypeName("#define WS_E_INVALID_FORMAT _HRESULT_TYPEDEF_(0x803D0000L)")]
        public const int WS_E_INVALID_FORMAT = unchecked((int)(0x803D0000));

        [NativeTypeName("#define WS_E_OBJECT_FAULTED _HRESULT_TYPEDEF_(0x803D0001L)")]
        public const int WS_E_OBJECT_FAULTED = unchecked((int)(0x803D0001));

        [NativeTypeName("#define WS_E_NUMERIC_OVERFLOW _HRESULT_TYPEDEF_(0x803D0002L)")]
        public const int WS_E_NUMERIC_OVERFLOW = unchecked((int)(0x803D0002));

        [NativeTypeName("#define WS_E_INVALID_OPERATION _HRESULT_TYPEDEF_(0x803D0003L)")]
        public const int WS_E_INVALID_OPERATION = unchecked((int)(0x803D0003));

        [NativeTypeName("#define WS_E_OPERATION_ABORTED _HRESULT_TYPEDEF_(0x803D0004L)")]
        public const int WS_E_OPERATION_ABORTED = unchecked((int)(0x803D0004));

        [NativeTypeName("#define WS_E_ENDPOINT_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0005L)")]
        public const int WS_E_ENDPOINT_ACCESS_DENIED = unchecked((int)(0x803D0005));

        [NativeTypeName("#define WS_E_OPERATION_TIMED_OUT _HRESULT_TYPEDEF_(0x803D0006L)")]
        public const int WS_E_OPERATION_TIMED_OUT = unchecked((int)(0x803D0006));

        [NativeTypeName("#define WS_E_OPERATION_ABANDONED _HRESULT_TYPEDEF_(0x803D0007L)")]
        public const int WS_E_OPERATION_ABANDONED = unchecked((int)(0x803D0007));

        [NativeTypeName("#define WS_E_QUOTA_EXCEEDED _HRESULT_TYPEDEF_(0x803D0008L)")]
        public const int WS_E_QUOTA_EXCEEDED = unchecked((int)(0x803D0008));

        [NativeTypeName("#define WS_E_NO_TRANSLATION_AVAILABLE _HRESULT_TYPEDEF_(0x803D0009L)")]
        public const int WS_E_NO_TRANSLATION_AVAILABLE = unchecked((int)(0x803D0009));

        [NativeTypeName("#define WS_E_SECURITY_VERIFICATION_FAILURE _HRESULT_TYPEDEF_(0x803D000AL)")]
        public const int WS_E_SECURITY_VERIFICATION_FAILURE = unchecked((int)(0x803D000A));

        [NativeTypeName("#define WS_E_ADDRESS_IN_USE _HRESULT_TYPEDEF_(0x803D000BL)")]
        public const int WS_E_ADDRESS_IN_USE = unchecked((int)(0x803D000B));

        [NativeTypeName("#define WS_E_ADDRESS_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000CL)")]
        public const int WS_E_ADDRESS_NOT_AVAILABLE = unchecked((int)(0x803D000C));

        [NativeTypeName("#define WS_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803D000DL)")]
        public const int WS_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803D000D));

        [NativeTypeName("#define WS_E_ENDPOINT_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000EL)")]
        public const int WS_E_ENDPOINT_NOT_AVAILABLE = unchecked((int)(0x803D000E));

        [NativeTypeName("#define WS_E_ENDPOINT_FAILURE _HRESULT_TYPEDEF_(0x803D000FL)")]
        public const int WS_E_ENDPOINT_FAILURE = unchecked((int)(0x803D000F));

        [NativeTypeName("#define WS_E_ENDPOINT_UNREACHABLE _HRESULT_TYPEDEF_(0x803D0010L)")]
        public const int WS_E_ENDPOINT_UNREACHABLE = unchecked((int)(0x803D0010));

        [NativeTypeName("#define WS_E_ENDPOINT_ACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0011L)")]
        public const int WS_E_ENDPOINT_ACTION_NOT_SUPPORTED = unchecked((int)(0x803D0011));

        [NativeTypeName("#define WS_E_ENDPOINT_TOO_BUSY _HRESULT_TYPEDEF_(0x803D0012L)")]
        public const int WS_E_ENDPOINT_TOO_BUSY = unchecked((int)(0x803D0012));

        [NativeTypeName("#define WS_E_ENDPOINT_FAULT_RECEIVED _HRESULT_TYPEDEF_(0x803D0013L)")]
        public const int WS_E_ENDPOINT_FAULT_RECEIVED = unchecked((int)(0x803D0013));

        [NativeTypeName("#define WS_E_ENDPOINT_DISCONNECTED _HRESULT_TYPEDEF_(0x803D0014L)")]
        public const int WS_E_ENDPOINT_DISCONNECTED = unchecked((int)(0x803D0014));

        [NativeTypeName("#define WS_E_PROXY_FAILURE _HRESULT_TYPEDEF_(0x803D0015L)")]
        public const int WS_E_PROXY_FAILURE = unchecked((int)(0x803D0015));

        [NativeTypeName("#define WS_E_PROXY_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0016L)")]
        public const int WS_E_PROXY_ACCESS_DENIED = unchecked((int)(0x803D0016));

        [NativeTypeName("#define WS_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0017L)")]
        public const int WS_E_NOT_SUPPORTED = unchecked((int)(0x803D0017));

        [NativeTypeName("#define WS_E_PROXY_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D0018L)")]
        public const int WS_E_PROXY_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D0018));

        [NativeTypeName("#define WS_E_PROXY_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D0019L)")]
        public const int WS_E_PROXY_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D0019));

        [NativeTypeName("#define WS_E_PROXY_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001AL)")]
        public const int WS_E_PROXY_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001A));

        [NativeTypeName("#define WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001BL)")]
        public const int WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001B));

        [NativeTypeName("#define WS_E_SERVER_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D001CL)")]
        public const int WS_E_SERVER_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D001C));

        [NativeTypeName("#define WS_E_SERVER_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D001DL)")]
        public const int WS_E_SERVER_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D001D));

        [NativeTypeName("#define WS_E_SERVER_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001EL)")]
        public const int WS_E_SERVER_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001E));

        [NativeTypeName("#define WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001FL)")]
        public const int WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001F));

        [NativeTypeName("#define WS_E_INVALID_ENDPOINT_URL _HRESULT_TYPEDEF_(0x803D0020L)")]
        public const int WS_E_INVALID_ENDPOINT_URL = unchecked((int)(0x803D0020));

        [NativeTypeName("#define WS_E_OTHER _HRESULT_TYPEDEF_(0x803D0021L)")]
        public const int WS_E_OTHER = unchecked((int)(0x803D0021));

        [NativeTypeName("#define WS_E_SECURITY_TOKEN_EXPIRED _HRESULT_TYPEDEF_(0x803D0022L)")]
        public const int WS_E_SECURITY_TOKEN_EXPIRED = unchecked((int)(0x803D0022));

        [NativeTypeName("#define WS_E_SECURITY_SYSTEM_FAILURE _HRESULT_TYPEDEF_(0x803D0023L)")]
        public const int WS_E_SECURITY_SYSTEM_FAILURE = unchecked((int)(0x803D0023));

        [NativeTypeName("#define HCS_E_TERMINATED_DURING_START _HRESULT_TYPEDEF_(0x80370100L)")]
        public const int HCS_E_TERMINATED_DURING_START = unchecked((int)(0x80370100));

        [NativeTypeName("#define HCS_E_IMAGE_MISMATCH _HRESULT_TYPEDEF_(0x80370101L)")]
        public const int HCS_E_IMAGE_MISMATCH = unchecked((int)(0x80370101));

        [NativeTypeName("#define HCS_E_HYPERV_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80370102L)")]
        public const int HCS_E_HYPERV_NOT_INSTALLED = unchecked((int)(0x80370102));

        [NativeTypeName("#define HCS_E_INVALID_STATE _HRESULT_TYPEDEF_(0x80370105L)")]
        public const int HCS_E_INVALID_STATE = unchecked((int)(0x80370105));

        [NativeTypeName("#define HCS_E_UNEXPECTED_EXIT _HRESULT_TYPEDEF_(0x80370106L)")]
        public const int HCS_E_UNEXPECTED_EXIT = unchecked((int)(0x80370106));

        [NativeTypeName("#define HCS_E_TERMINATED _HRESULT_TYPEDEF_(0x80370107L)")]
        public const int HCS_E_TERMINATED = unchecked((int)(0x80370107));

        [NativeTypeName("#define HCS_E_CONNECT_FAILED _HRESULT_TYPEDEF_(0x80370108L)")]
        public const int HCS_E_CONNECT_FAILED = unchecked((int)(0x80370108));

        [NativeTypeName("#define HCS_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x80370109L)")]
        public const int HCS_E_CONNECTION_TIMEOUT = unchecked((int)(0x80370109));

        [NativeTypeName("#define HCS_E_CONNECTION_CLOSED _HRESULT_TYPEDEF_(0x8037010AL)")]
        public const int HCS_E_CONNECTION_CLOSED = unchecked((int)(0x8037010A));

        [NativeTypeName("#define HCS_E_UNKNOWN_MESSAGE _HRESULT_TYPEDEF_(0x8037010BL)")]
        public const int HCS_E_UNKNOWN_MESSAGE = unchecked((int)(0x8037010B));

        [NativeTypeName("#define HCS_E_UNSUPPORTED_PROTOCOL_VERSION _HRESULT_TYPEDEF_(0x8037010CL)")]
        public const int HCS_E_UNSUPPORTED_PROTOCOL_VERSION = unchecked((int)(0x8037010C));

        [NativeTypeName("#define HCS_E_INVALID_JSON _HRESULT_TYPEDEF_(0x8037010DL)")]
        public const int HCS_E_INVALID_JSON = unchecked((int)(0x8037010D));

        [NativeTypeName("#define HCS_E_SYSTEM_NOT_FOUND _HRESULT_TYPEDEF_(0x8037010EL)")]
        public const int HCS_E_SYSTEM_NOT_FOUND = unchecked((int)(0x8037010E));

        [NativeTypeName("#define HCS_E_SYSTEM_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x8037010FL)")]
        public const int HCS_E_SYSTEM_ALREADY_EXISTS = unchecked((int)(0x8037010F));

        [NativeTypeName("#define HCS_E_SYSTEM_ALREADY_STOPPED _HRESULT_TYPEDEF_(0x80370110L)")]
        public const int HCS_E_SYSTEM_ALREADY_STOPPED = unchecked((int)(0x80370110));

        [NativeTypeName("#define HCS_E_PROTOCOL_ERROR _HRESULT_TYPEDEF_(0x80370111L)")]
        public const int HCS_E_PROTOCOL_ERROR = unchecked((int)(0x80370111));

        [NativeTypeName("#define HCS_E_INVALID_LAYER _HRESULT_TYPEDEF_(0x80370112L)")]
        public const int HCS_E_INVALID_LAYER = unchecked((int)(0x80370112));

        [NativeTypeName("#define HCS_E_WINDOWS_INSIDER_REQUIRED _HRESULT_TYPEDEF_(0x80370113L)")]
        public const int HCS_E_WINDOWS_INSIDER_REQUIRED = unchecked((int)(0x80370113));

        [NativeTypeName("#define HCS_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80370114L)")]
        public const int HCS_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80370114));

        [NativeTypeName("#define HCS_E_OPERATION_NOT_STARTED _HRESULT_TYPEDEF_(0x80370115L)")]
        public const int HCS_E_OPERATION_NOT_STARTED = unchecked((int)(0x80370115));

        [NativeTypeName("#define HCS_E_OPERATION_ALREADY_STARTED _HRESULT_TYPEDEF_(0x80370116L)")]
        public const int HCS_E_OPERATION_ALREADY_STARTED = unchecked((int)(0x80370116));

        [NativeTypeName("#define HCS_E_OPERATION_PENDING _HRESULT_TYPEDEF_(0x80370117L)")]
        public const int HCS_E_OPERATION_PENDING = unchecked((int)(0x80370117));

        [NativeTypeName("#define HCS_E_OPERATION_TIMEOUT _HRESULT_TYPEDEF_(0x80370118L)")]
        public const int HCS_E_OPERATION_TIMEOUT = unchecked((int)(0x80370118));

        [NativeTypeName("#define HCS_E_OPERATION_SYSTEM_CALLBACK_ALREADY_SET _HRESULT_TYPEDEF_(0x80370119L)")]
        public const int HCS_E_OPERATION_SYSTEM_CALLBACK_ALREADY_SET = unchecked((int)(0x80370119));

        [NativeTypeName("#define HCS_E_OPERATION_RESULT_ALLOCATION_FAILED _HRESULT_TYPEDEF_(0x8037011AL)")]
        public const int HCS_E_OPERATION_RESULT_ALLOCATION_FAILED = unchecked((int)(0x8037011A));

        [NativeTypeName("#define HCS_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x8037011BL)")]
        public const int HCS_E_ACCESS_DENIED = unchecked((int)(0x8037011B));

        [NativeTypeName("#define HCS_E_GUEST_CRITICAL_ERROR _HRESULT_TYPEDEF_(0x8037011CL)")]
        public const int HCS_E_GUEST_CRITICAL_ERROR = unchecked((int)(0x8037011C));

        [NativeTypeName("#define HCS_E_PROCESS_INFO_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x8037011DL)")]
        public const int HCS_E_PROCESS_INFO_NOT_AVAILABLE = unchecked((int)(0x8037011D));

        [NativeTypeName("#define HCS_E_SERVICE_DISCONNECT _HRESULT_TYPEDEF_(0x8037011EL)")]
        public const int HCS_E_SERVICE_DISCONNECT = unchecked((int)(0x8037011E));

        [NativeTypeName("#define HCS_E_PROCESS_ALREADY_STOPPED _HRESULT_TYPEDEF_(0x8037011FL)")]
        public const int HCS_E_PROCESS_ALREADY_STOPPED = unchecked((int)(0x8037011F));

        [NativeTypeName("#define HCS_E_SYSTEM_NOT_CONFIGURED_FOR_OPERATION _HRESULT_TYPEDEF_(0x80370120L)")]
        public const int HCS_E_SYSTEM_NOT_CONFIGURED_FOR_OPERATION = unchecked((int)(0x80370120));

        [NativeTypeName("#define WHV_E_UNKNOWN_CAPABILITY _HRESULT_TYPEDEF_(0x80370300L)")]
        public const int WHV_E_UNKNOWN_CAPABILITY = unchecked((int)(0x80370300));

        [NativeTypeName("#define WHV_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80370301L)")]
        public const int WHV_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80370301));

        [NativeTypeName("#define WHV_E_UNKNOWN_PROPERTY _HRESULT_TYPEDEF_(0x80370302L)")]
        public const int WHV_E_UNKNOWN_PROPERTY = unchecked((int)(0x80370302));

        [NativeTypeName("#define WHV_E_UNSUPPORTED_HYPERVISOR_CONFIG _HRESULT_TYPEDEF_(0x80370303L)")]
        public const int WHV_E_UNSUPPORTED_HYPERVISOR_CONFIG = unchecked((int)(0x80370303));

        [NativeTypeName("#define WHV_E_INVALID_PARTITION_CONFIG _HRESULT_TYPEDEF_(0x80370304L)")]
        public const int WHV_E_INVALID_PARTITION_CONFIG = unchecked((int)(0x80370304));

        [NativeTypeName("#define WHV_E_GPA_RANGE_NOT_FOUND _HRESULT_TYPEDEF_(0x80370305L)")]
        public const int WHV_E_GPA_RANGE_NOT_FOUND = unchecked((int)(0x80370305));

        [NativeTypeName("#define WHV_E_VP_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80370306L)")]
        public const int WHV_E_VP_ALREADY_EXISTS = unchecked((int)(0x80370306));

        [NativeTypeName("#define WHV_E_VP_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x80370307L)")]
        public const int WHV_E_VP_DOES_NOT_EXIST = unchecked((int)(0x80370307));

        [NativeTypeName("#define WHV_E_INVALID_VP_STATE _HRESULT_TYPEDEF_(0x80370308L)")]
        public const int WHV_E_INVALID_VP_STATE = unchecked((int)(0x80370308));

        [NativeTypeName("#define WHV_E_INVALID_VP_REGISTER_NAME _HRESULT_TYPEDEF_(0x80370309L)")]
        public const int WHV_E_INVALID_VP_REGISTER_NAME = unchecked((int)(0x80370309));

        [NativeTypeName("#define WHV_E_UNSUPPORTED_PROCESSOR_CONFIG _HRESULT_TYPEDEF_(0x80370310L)")]
        public const int WHV_E_UNSUPPORTED_PROCESSOR_CONFIG = unchecked((int)(0x80370310));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370500L)")]
        public const int VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND = unchecked((int)(0xC0370500));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370501L)")]
        public const int VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND = unchecked((int)(0xC0370501));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE _HRESULT_TYPEDEF_(0xC0370502L)")]
        public const int VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE = unchecked((int)(0xC0370502));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0370503L)")]
        public const int VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED = unchecked((int)(0xC0370503));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370504L)")]
        public const int VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND = unchecked((int)(0xC0370504));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PXE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370505L)")]
        public const int VM_SAVED_STATE_DUMP_E_PXE_NOT_PRESENT = unchecked((int)(0xC0370505));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PDPTE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370506L)")]
        public const int VM_SAVED_STATE_DUMP_E_PDPTE_NOT_PRESENT = unchecked((int)(0xC0370506));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PDE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370507L)")]
        public const int VM_SAVED_STATE_DUMP_E_PDE_NOT_PRESENT = unchecked((int)(0xC0370507));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PTE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370508L)")]
        public const int VM_SAVED_STATE_DUMP_E_PTE_NOT_PRESENT = unchecked((int)(0xC0370508));

        [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED _HRESULT_TYPEDEF_(0xC0370509L)")]
        public const int VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED = unchecked((int)(0xC0370509));

        [NativeTypeName("#define HCN_E_NETWORK_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0001L)")]
        public const int HCN_E_NETWORK_NOT_FOUND = unchecked((int)(0x803B0001));

        [NativeTypeName("#define HCN_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0002L)")]
        public const int HCN_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803B0002));

        [NativeTypeName("#define HCN_E_LAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0003L)")]
        public const int HCN_E_LAYER_NOT_FOUND = unchecked((int)(0x803B0003));

        [NativeTypeName("#define HCN_E_SWITCH_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0004L)")]
        public const int HCN_E_SWITCH_NOT_FOUND = unchecked((int)(0x803B0004));

        [NativeTypeName("#define HCN_E_SUBNET_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0005L)")]
        public const int HCN_E_SUBNET_NOT_FOUND = unchecked((int)(0x803B0005));

        [NativeTypeName("#define HCN_E_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0006L)")]
        public const int HCN_E_ADAPTER_NOT_FOUND = unchecked((int)(0x803B0006));

        [NativeTypeName("#define HCN_E_PORT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0007L)")]
        public const int HCN_E_PORT_NOT_FOUND = unchecked((int)(0x803B0007));

        [NativeTypeName("#define HCN_E_POLICY_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0008L)")]
        public const int HCN_E_POLICY_NOT_FOUND = unchecked((int)(0x803B0008));

        [NativeTypeName("#define HCN_E_VFP_PORTSETTING_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0009L)")]
        public const int HCN_E_VFP_PORTSETTING_NOT_FOUND = unchecked((int)(0x803B0009));

        [NativeTypeName("#define HCN_E_INVALID_NETWORK _HRESULT_TYPEDEF_(0x803B000AL)")]
        public const int HCN_E_INVALID_NETWORK = unchecked((int)(0x803B000A));

        [NativeTypeName("#define HCN_E_INVALID_NETWORK_TYPE _HRESULT_TYPEDEF_(0x803B000BL)")]
        public const int HCN_E_INVALID_NETWORK_TYPE = unchecked((int)(0x803B000B));

        [NativeTypeName("#define HCN_E_INVALID_ENDPOINT _HRESULT_TYPEDEF_(0x803B000CL)")]
        public const int HCN_E_INVALID_ENDPOINT = unchecked((int)(0x803B000C));

        [NativeTypeName("#define HCN_E_INVALID_POLICY _HRESULT_TYPEDEF_(0x803B000DL)")]
        public const int HCN_E_INVALID_POLICY = unchecked((int)(0x803B000D));

        [NativeTypeName("#define HCN_E_INVALID_POLICY_TYPE _HRESULT_TYPEDEF_(0x803B000EL)")]
        public const int HCN_E_INVALID_POLICY_TYPE = unchecked((int)(0x803B000E));

        [NativeTypeName("#define HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION _HRESULT_TYPEDEF_(0x803B000FL)")]
        public const int HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION = unchecked((int)(0x803B000F));

        [NativeTypeName("#define HCN_E_NETWORK_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0010L)")]
        public const int HCN_E_NETWORK_ALREADY_EXISTS = unchecked((int)(0x803B0010));

        [NativeTypeName("#define HCN_E_LAYER_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0011L)")]
        public const int HCN_E_LAYER_ALREADY_EXISTS = unchecked((int)(0x803B0011));

        [NativeTypeName("#define HCN_E_POLICY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0012L)")]
        public const int HCN_E_POLICY_ALREADY_EXISTS = unchecked((int)(0x803B0012));

        [NativeTypeName("#define HCN_E_PORT_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0013L)")]
        public const int HCN_E_PORT_ALREADY_EXISTS = unchecked((int)(0x803B0013));

        [NativeTypeName("#define HCN_E_ENDPOINT_ALREADY_ATTACHED _HRESULT_TYPEDEF_(0x803B0014L)")]
        public const int HCN_E_ENDPOINT_ALREADY_ATTACHED = unchecked((int)(0x803B0014));

        [NativeTypeName("#define HCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0015L)")]
        public const int HCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0015));

        [NativeTypeName("#define HCN_E_MAPPING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803B0016L)")]
        public const int HCN_E_MAPPING_NOT_SUPPORTED = unchecked((int)(0x803B0016));

        [NativeTypeName("#define HCN_E_DEGRADED_OPERATION _HRESULT_TYPEDEF_(0x803B0017L)")]
        public const int HCN_E_DEGRADED_OPERATION = unchecked((int)(0x803B0017));

        [NativeTypeName("#define HCN_E_SHARED_SWITCH_MODIFICATION _HRESULT_TYPEDEF_(0x803B0018L)")]
        public const int HCN_E_SHARED_SWITCH_MODIFICATION = unchecked((int)(0x803B0018));

        [NativeTypeName("#define HCN_E_GUID_CONVERSION_FAILURE _HRESULT_TYPEDEF_(0x803B0019L)")]
        public const int HCN_E_GUID_CONVERSION_FAILURE = unchecked((int)(0x803B0019));

        [NativeTypeName("#define HCN_E_REGKEY_FAILURE _HRESULT_TYPEDEF_(0x803B001AL)")]
        public const int HCN_E_REGKEY_FAILURE = unchecked((int)(0x803B001A));

        [NativeTypeName("#define HCN_E_INVALID_JSON _HRESULT_TYPEDEF_(0x803B001BL)")]
        public const int HCN_E_INVALID_JSON = unchecked((int)(0x803B001B));

        [NativeTypeName("#define HCN_E_INVALID_JSON_REFERENCE _HRESULT_TYPEDEF_(0x803B001CL)")]
        public const int HCN_E_INVALID_JSON_REFERENCE = unchecked((int)(0x803B001C));

        [NativeTypeName("#define HCN_E_ENDPOINT_SHARING_DISABLED _HRESULT_TYPEDEF_(0x803B001DL)")]
        public const int HCN_E_ENDPOINT_SHARING_DISABLED = unchecked((int)(0x803B001D));

        [NativeTypeName("#define HCN_E_INVALID_IP _HRESULT_TYPEDEF_(0x803B001EL)")]
        public const int HCN_E_INVALID_IP = unchecked((int)(0x803B001E));

        [NativeTypeName("#define HCN_E_SWITCH_EXTENSION_NOT_FOUND _HRESULT_TYPEDEF_(0x803B001FL)")]
        public const int HCN_E_SWITCH_EXTENSION_NOT_FOUND = unchecked((int)(0x803B001F));

        [NativeTypeName("#define HCN_E_MANAGER_STOPPED _HRESULT_TYPEDEF_(0x803B0020L)")]
        public const int HCN_E_MANAGER_STOPPED = unchecked((int)(0x803B0020));

        [NativeTypeName("#define GCN_E_MODULE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0021L)")]
        public const int GCN_E_MODULE_NOT_FOUND = unchecked((int)(0x803B0021));

        [NativeTypeName("#define GCN_E_NO_REQUEST_HANDLERS _HRESULT_TYPEDEF_(0x803B0022L)")]
        public const int GCN_E_NO_REQUEST_HANDLERS = unchecked((int)(0x803B0022));

        [NativeTypeName("#define GCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0023L)")]
        public const int GCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0023));

        [NativeTypeName("#define GCN_E_RUNTIMEKEYS_FAILED _HRESULT_TYPEDEF_(0x803B0024L)")]
        public const int GCN_E_RUNTIMEKEYS_FAILED = unchecked((int)(0x803B0024));

        [NativeTypeName("#define GCN_E_NETADAPTER_TIMEOUT _HRESULT_TYPEDEF_(0x803B0025L)")]
        public const int GCN_E_NETADAPTER_TIMEOUT = unchecked((int)(0x803B0025));

        [NativeTypeName("#define GCN_E_NETADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0026L)")]
        public const int GCN_E_NETADAPTER_NOT_FOUND = unchecked((int)(0x803B0026));

        [NativeTypeName("#define GCN_E_NETCOMPARTMENT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0027L)")]
        public const int GCN_E_NETCOMPARTMENT_NOT_FOUND = unchecked((int)(0x803B0027));

        [NativeTypeName("#define GCN_E_NETINTERFACE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0028L)")]
        public const int GCN_E_NETINTERFACE_NOT_FOUND = unchecked((int)(0x803B0028));

        [NativeTypeName("#define GCN_E_DEFAULTNAMESPACE_EXISTS _HRESULT_TYPEDEF_(0x803B0029L)")]
        public const int GCN_E_DEFAULTNAMESPACE_EXISTS = unchecked((int)(0x803B0029));

        [NativeTypeName("#define HCN_E_ICS_DISABLED _HRESULT_TYPEDEF_(0x803B002AL)")]
        public const int HCN_E_ICS_DISABLED = unchecked((int)(0x803B002A));

        [NativeTypeName("#define HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B002BL)")]
        public const int HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS = unchecked((int)(0x803B002B));

        [NativeTypeName("#define HCN_E_ENTITY_HAS_REFERENCES _HRESULT_TYPEDEF_(0x803B002CL)")]
        public const int HCN_E_ENTITY_HAS_REFERENCES = unchecked((int)(0x803B002C));

        [NativeTypeName("#define HCN_E_INVALID_INTERNAL_PORT _HRESULT_TYPEDEF_(0x803B002DL)")]
        public const int HCN_E_INVALID_INTERNAL_PORT = unchecked((int)(0x803B002D));

        [NativeTypeName("#define HCN_E_NAMESPACE_ATTACH_FAILED _HRESULT_TYPEDEF_(0x803B002EL)")]
        public const int HCN_E_NAMESPACE_ATTACH_FAILED = unchecked((int)(0x803B002E));

        [NativeTypeName("#define HCN_E_ADDR_INVALID_OR_RESERVED _HRESULT_TYPEDEF_(0x803B002FL)")]
        public const int HCN_E_ADDR_INVALID_OR_RESERVED = unchecked((int)(0x803B002F));

        [NativeTypeName("#define HCN_E_INVALID_PREFIX _HRESULT_TYPEDEF_(0x803B0030L)")]
        public const int HCN_E_INVALID_PREFIX = unchecked((int)(0x803B0030));

        [NativeTypeName("#define HCN_E_OBJECT_USED_AFTER_UNLOAD _HRESULT_TYPEDEF_(0x803B0031L)")]
        public const int HCN_E_OBJECT_USED_AFTER_UNLOAD = unchecked((int)(0x803B0031));

        [NativeTypeName("#define HCN_E_INVALID_SUBNET _HRESULT_TYPEDEF_(0x803B0032L)")]
        public const int HCN_E_INVALID_SUBNET = unchecked((int)(0x803B0032));

        [NativeTypeName("#define HCN_E_INVALID_IP_SUBNET _HRESULT_TYPEDEF_(0x803B0033L)")]
        public const int HCN_E_INVALID_IP_SUBNET = unchecked((int)(0x803B0033));

        [NativeTypeName("#define HCN_E_ENDPOINT_NOT_ATTACHED _HRESULT_TYPEDEF_(0x803B0034L)")]
        public const int HCN_E_ENDPOINT_NOT_ATTACHED = unchecked((int)(0x803B0034));

        [NativeTypeName("#define HCN_E_ENDPOINT_NOT_LOCAL _HRESULT_TYPEDEF_(0x803B0035L)")]
        public const int HCN_E_ENDPOINT_NOT_LOCAL = unchecked((int)(0x803B0035));

        [NativeTypeName("#define HCN_INTERFACEPARAMETERS_ALREADY_APPLIED _HRESULT_TYPEDEF_(0x803B0036L)")]
        public const int HCN_INTERFACEPARAMETERS_ALREADY_APPLIED = unchecked((int)(0x803B0036));

        [NativeTypeName("#define HCN_E_VFP_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803B0037L)")]
        public const int HCN_E_VFP_NOT_ALLOWED = unchecked((int)(0x803B0037));

        [NativeTypeName("#define SDIAG_E_CANCELLED _NDIS_ERROR_TYPEDEF_(0x803C0100L)")]
        public const uint SDIAG_E_CANCELLED = (uint)(0x803C0100);

        [NativeTypeName("#define SDIAG_E_SCRIPT _NDIS_ERROR_TYPEDEF_(0x803C0101L)")]
        public const uint SDIAG_E_SCRIPT = (uint)(0x803C0101);

        [NativeTypeName("#define SDIAG_E_POWERSHELL _NDIS_ERROR_TYPEDEF_(0x803C0102L)")]
        public const uint SDIAG_E_POWERSHELL = (uint)(0x803C0102);

        [NativeTypeName("#define SDIAG_E_MANAGEDHOST _NDIS_ERROR_TYPEDEF_(0x803C0103L)")]
        public const uint SDIAG_E_MANAGEDHOST = (uint)(0x803C0103);

        [NativeTypeName("#define SDIAG_E_NOVERIFIER _NDIS_ERROR_TYPEDEF_(0x803C0104L)")]
        public const uint SDIAG_E_NOVERIFIER = (uint)(0x803C0104);

        [NativeTypeName("#define SDIAG_S_CANNOTRUN _NDIS_ERROR_TYPEDEF_(0x003C0105L)")]
        public const uint SDIAG_S_CANNOTRUN = (uint)(0x003C0105);

        [NativeTypeName("#define SDIAG_E_DISABLED _NDIS_ERROR_TYPEDEF_(0x803C0106L)")]
        public const uint SDIAG_E_DISABLED = (uint)(0x803C0106);

        [NativeTypeName("#define SDIAG_E_TRUST _NDIS_ERROR_TYPEDEF_(0x803C0107L)")]
        public const uint SDIAG_E_TRUST = (uint)(0x803C0107);

        [NativeTypeName("#define SDIAG_E_CANNOTRUN _NDIS_ERROR_TYPEDEF_(0x803C0108L)")]
        public const uint SDIAG_E_CANNOTRUN = (uint)(0x803C0108);

        [NativeTypeName("#define SDIAG_E_VERSION _NDIS_ERROR_TYPEDEF_(0x803C0109L)")]
        public const uint SDIAG_E_VERSION = (uint)(0x803C0109);

        [NativeTypeName("#define SDIAG_E_RESOURCE _NDIS_ERROR_TYPEDEF_(0x803C010AL)")]
        public const uint SDIAG_E_RESOURCE = (uint)(0x803C010A);

        [NativeTypeName("#define SDIAG_E_ROOTCAUSE _NDIS_ERROR_TYPEDEF_(0x803C010BL)")]
        public const uint SDIAG_E_ROOTCAUSE = (uint)(0x803C010B);

        [NativeTypeName("#define WPN_E_CHANNEL_CLOSED _HRESULT_TYPEDEF_(0x803E0100L)")]
        public const int WPN_E_CHANNEL_CLOSED = unchecked((int)(0x803E0100));

        [NativeTypeName("#define WPN_E_CHANNEL_REQUEST_NOT_COMPLETE _HRESULT_TYPEDEF_(0x803E0101L)")]
        public const int WPN_E_CHANNEL_REQUEST_NOT_COMPLETE = unchecked((int)(0x803E0101));

        [NativeTypeName("#define WPN_E_INVALID_APP _HRESULT_TYPEDEF_(0x803E0102L)")]
        public const int WPN_E_INVALID_APP = unchecked((int)(0x803E0102));

        [NativeTypeName("#define WPN_E_OUTSTANDING_CHANNEL_REQUEST _HRESULT_TYPEDEF_(0x803E0103L)")]
        public const int WPN_E_OUTSTANDING_CHANNEL_REQUEST = unchecked((int)(0x803E0103));

        [NativeTypeName("#define WPN_E_DUPLICATE_CHANNEL _HRESULT_TYPEDEF_(0x803E0104L)")]
        public const int WPN_E_DUPLICATE_CHANNEL = unchecked((int)(0x803E0104));

        [NativeTypeName("#define WPN_E_PLATFORM_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E0105L)")]
        public const int WPN_E_PLATFORM_UNAVAILABLE = unchecked((int)(0x803E0105));

        [NativeTypeName("#define WPN_E_NOTIFICATION_POSTED _HRESULT_TYPEDEF_(0x803E0106L)")]
        public const int WPN_E_NOTIFICATION_POSTED = unchecked((int)(0x803E0106));

        [NativeTypeName("#define WPN_E_NOTIFICATION_HIDDEN _HRESULT_TYPEDEF_(0x803E0107L)")]
        public const int WPN_E_NOTIFICATION_HIDDEN = unchecked((int)(0x803E0107));

        [NativeTypeName("#define WPN_E_NOTIFICATION_NOT_POSTED _HRESULT_TYPEDEF_(0x803E0108L)")]
        public const int WPN_E_NOTIFICATION_NOT_POSTED = unchecked((int)(0x803E0108));

        [NativeTypeName("#define WPN_E_CLOUD_DISABLED _HRESULT_TYPEDEF_(0x803E0109L)")]
        public const int WPN_E_CLOUD_DISABLED = unchecked((int)(0x803E0109));

        [NativeTypeName("#define WPN_E_CLOUD_INCAPABLE _HRESULT_TYPEDEF_(0x803E0110L)")]
        public const int WPN_E_CLOUD_INCAPABLE = unchecked((int)(0x803E0110));

        [NativeTypeName("#define WPN_E_CLOUD_AUTH_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E011AL)")]
        public const int WPN_E_CLOUD_AUTH_UNAVAILABLE = unchecked((int)(0x803E011A));

        [NativeTypeName("#define WPN_E_CLOUD_SERVICE_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E011BL)")]
        public const int WPN_E_CLOUD_SERVICE_UNAVAILABLE = unchecked((int)(0x803E011B));

        [NativeTypeName("#define WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION _HRESULT_TYPEDEF_(0x803E011CL)")]
        public const int WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION = unchecked((int)(0x803E011C));

        [NativeTypeName("#define WPN_E_NOTIFICATION_DISABLED _HRESULT_TYPEDEF_(0x803E0111L)")]
        public const int WPN_E_NOTIFICATION_DISABLED = unchecked((int)(0x803E0111));

        [NativeTypeName("#define WPN_E_NOTIFICATION_INCAPABLE _HRESULT_TYPEDEF_(0x803E0112L)")]
        public const int WPN_E_NOTIFICATION_INCAPABLE = unchecked((int)(0x803E0112));

        [NativeTypeName("#define WPN_E_INTERNET_INCAPABLE _HRESULT_TYPEDEF_(0x803E0113L)")]
        public const int WPN_E_INTERNET_INCAPABLE = unchecked((int)(0x803E0113));

        [NativeTypeName("#define WPN_E_NOTIFICATION_TYPE_DISABLED _HRESULT_TYPEDEF_(0x803E0114L)")]
        public const int WPN_E_NOTIFICATION_TYPE_DISABLED = unchecked((int)(0x803E0114));

        [NativeTypeName("#define WPN_E_NOTIFICATION_SIZE _HRESULT_TYPEDEF_(0x803E0115L)")]
        public const int WPN_E_NOTIFICATION_SIZE = unchecked((int)(0x803E0115));

        [NativeTypeName("#define WPN_E_TAG_SIZE _HRESULT_TYPEDEF_(0x803E0116L)")]
        public const int WPN_E_TAG_SIZE = unchecked((int)(0x803E0116));

        [NativeTypeName("#define WPN_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803E0117L)")]
        public const int WPN_E_ACCESS_DENIED = unchecked((int)(0x803E0117));

        [NativeTypeName("#define WPN_E_DUPLICATE_REGISTRATION _HRESULT_TYPEDEF_(0x803E0118L)")]
        public const int WPN_E_DUPLICATE_REGISTRATION = unchecked((int)(0x803E0118));

        [NativeTypeName("#define WPN_E_PUSH_NOTIFICATION_INCAPABLE _HRESULT_TYPEDEF_(0x803E0119L)")]
        public const int WPN_E_PUSH_NOTIFICATION_INCAPABLE = unchecked((int)(0x803E0119));

        [NativeTypeName("#define WPN_E_DEV_ID_SIZE _HRESULT_TYPEDEF_(0x803E0120L)")]
        public const int WPN_E_DEV_ID_SIZE = unchecked((int)(0x803E0120));

        [NativeTypeName("#define WPN_E_TAG_ALPHANUMERIC _HRESULT_TYPEDEF_(0x803E012AL)")]
        public const int WPN_E_TAG_ALPHANUMERIC = unchecked((int)(0x803E012A));

        [NativeTypeName("#define WPN_E_INVALID_HTTP_STATUS_CODE _HRESULT_TYPEDEF_(0x803E012BL)")]
        public const int WPN_E_INVALID_HTTP_STATUS_CODE = unchecked((int)(0x803E012B));

        [NativeTypeName("#define WPN_E_OUT_OF_SESSION _HRESULT_TYPEDEF_(0x803E0200L)")]
        public const int WPN_E_OUT_OF_SESSION = unchecked((int)(0x803E0200));

        [NativeTypeName("#define WPN_E_POWER_SAVE _HRESULT_TYPEDEF_(0x803E0201L)")]
        public const int WPN_E_POWER_SAVE = unchecked((int)(0x803E0201));

        [NativeTypeName("#define WPN_E_IMAGE_NOT_FOUND_IN_CACHE _HRESULT_TYPEDEF_(0x803E0202L)")]
        public const int WPN_E_IMAGE_NOT_FOUND_IN_CACHE = unchecked((int)(0x803E0202));

        [NativeTypeName("#define WPN_E_ALL_URL_NOT_COMPLETED _HRESULT_TYPEDEF_(0x803E0203L)")]
        public const int WPN_E_ALL_URL_NOT_COMPLETED = unchecked((int)(0x803E0203));

        [NativeTypeName("#define WPN_E_INVALID_CLOUD_IMAGE _HRESULT_TYPEDEF_(0x803E0204L)")]
        public const int WPN_E_INVALID_CLOUD_IMAGE = unchecked((int)(0x803E0204));

        [NativeTypeName("#define WPN_E_NOTIFICATION_ID_MATCHED _HRESULT_TYPEDEF_(0x803E0205L)")]
        public const int WPN_E_NOTIFICATION_ID_MATCHED = unchecked((int)(0x803E0205));

        [NativeTypeName("#define WPN_E_CALLBACK_ALREADY_REGISTERED _HRESULT_TYPEDEF_(0x803E0206L)")]
        public const int WPN_E_CALLBACK_ALREADY_REGISTERED = unchecked((int)(0x803E0206));

        [NativeTypeName("#define WPN_E_TOAST_NOTIFICATION_DROPPED _HRESULT_TYPEDEF_(0x803E0207L)")]
        public const int WPN_E_TOAST_NOTIFICATION_DROPPED = unchecked((int)(0x803E0207));

        [NativeTypeName("#define WPN_E_STORAGE_LOCKED _HRESULT_TYPEDEF_(0x803E0208L)")]
        public const int WPN_E_STORAGE_LOCKED = unchecked((int)(0x803E0208));

        [NativeTypeName("#define WPN_E_GROUP_SIZE _HRESULT_TYPEDEF_(0x803E0209L)")]
        public const int WPN_E_GROUP_SIZE = unchecked((int)(0x803E0209));

        [NativeTypeName("#define WPN_E_GROUP_ALPHANUMERIC _HRESULT_TYPEDEF_(0x803E020AL)")]
        public const int WPN_E_GROUP_ALPHANUMERIC = unchecked((int)(0x803E020A));

        [NativeTypeName("#define WPN_E_CLOUD_DISABLED_FOR_APP _HRESULT_TYPEDEF_(0x803E020BL)")]
        public const int WPN_E_CLOUD_DISABLED_FOR_APP = unchecked((int)(0x803E020B));

        [NativeTypeName("#define PEER_E_IPV6_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80630001L)")]
        public const int PEER_E_IPV6_NOT_INSTALLED = unchecked((int)(0x80630001));

        [NativeTypeName("#define PEER_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80630002L)")]
        public const int PEER_E_NOT_INITIALIZED = unchecked((int)(0x80630002));

        [NativeTypeName("#define PEER_E_CANNOT_START_SERVICE _HRESULT_TYPEDEF_(0x80630003L)")]
        public const int PEER_E_CANNOT_START_SERVICE = unchecked((int)(0x80630003));

        [NativeTypeName("#define PEER_E_NOT_LICENSED _HRESULT_TYPEDEF_(0x80630004L)")]
        public const int PEER_E_NOT_LICENSED = unchecked((int)(0x80630004));

        [NativeTypeName("#define PEER_E_INVALID_GRAPH _HRESULT_TYPEDEF_(0x80630010L)")]
        public const int PEER_E_INVALID_GRAPH = unchecked((int)(0x80630010));

        [NativeTypeName("#define PEER_E_DBNAME_CHANGED _HRESULT_TYPEDEF_(0x80630011L)")]
        public const int PEER_E_DBNAME_CHANGED = unchecked((int)(0x80630011));

        [NativeTypeName("#define PEER_E_DUPLICATE_GRAPH _HRESULT_TYPEDEF_(0x80630012L)")]
        public const int PEER_E_DUPLICATE_GRAPH = unchecked((int)(0x80630012));

        [NativeTypeName("#define PEER_E_GRAPH_NOT_READY _HRESULT_TYPEDEF_(0x80630013L)")]
        public const int PEER_E_GRAPH_NOT_READY = unchecked((int)(0x80630013));

        [NativeTypeName("#define PEER_E_GRAPH_SHUTTING_DOWN _HRESULT_TYPEDEF_(0x80630014L)")]
        public const int PEER_E_GRAPH_SHUTTING_DOWN = unchecked((int)(0x80630014));

        [NativeTypeName("#define PEER_E_GRAPH_IN_USE _HRESULT_TYPEDEF_(0x80630015L)")]
        public const int PEER_E_GRAPH_IN_USE = unchecked((int)(0x80630015));

        [NativeTypeName("#define PEER_E_INVALID_DATABASE _HRESULT_TYPEDEF_(0x80630016L)")]
        public const int PEER_E_INVALID_DATABASE = unchecked((int)(0x80630016));

        [NativeTypeName("#define PEER_E_TOO_MANY_ATTRIBUTES _HRESULT_TYPEDEF_(0x80630017L)")]
        public const int PEER_E_TOO_MANY_ATTRIBUTES = unchecked((int)(0x80630017));

        [NativeTypeName("#define PEER_E_CONNECTION_NOT_FOUND _HRESULT_TYPEDEF_(0x80630103L)")]
        public const int PEER_E_CONNECTION_NOT_FOUND = unchecked((int)(0x80630103));

        [NativeTypeName("#define PEER_E_CONNECT_SELF _HRESULT_TYPEDEF_(0x80630106L)")]
        public const int PEER_E_CONNECT_SELF = unchecked((int)(0x80630106));

        [NativeTypeName("#define PEER_E_ALREADY_LISTENING _HRESULT_TYPEDEF_(0x80630107L)")]
        public const int PEER_E_ALREADY_LISTENING = unchecked((int)(0x80630107));

        [NativeTypeName("#define PEER_E_NODE_NOT_FOUND _HRESULT_TYPEDEF_(0x80630108L)")]
        public const int PEER_E_NODE_NOT_FOUND = unchecked((int)(0x80630108));

        [NativeTypeName("#define PEER_E_CONNECTION_FAILED _HRESULT_TYPEDEF_(0x80630109L)")]
        public const int PEER_E_CONNECTION_FAILED = unchecked((int)(0x80630109));

        [NativeTypeName("#define PEER_E_CONNECTION_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x8063010AL)")]
        public const int PEER_E_CONNECTION_NOT_AUTHENTICATED = unchecked((int)(0x8063010A));

        [NativeTypeName("#define PEER_E_CONNECTION_REFUSED _HRESULT_TYPEDEF_(0x8063010BL)")]
        public const int PEER_E_CONNECTION_REFUSED = unchecked((int)(0x8063010B));

        [NativeTypeName("#define PEER_E_CLASSIFIER_TOO_LONG _HRESULT_TYPEDEF_(0x80630201L)")]
        public const int PEER_E_CLASSIFIER_TOO_LONG = unchecked((int)(0x80630201));

        [NativeTypeName("#define PEER_E_TOO_MANY_IDENTITIES _HRESULT_TYPEDEF_(0x80630202L)")]
        public const int PEER_E_TOO_MANY_IDENTITIES = unchecked((int)(0x80630202));

        [NativeTypeName("#define PEER_E_NO_KEY_ACCESS _HRESULT_TYPEDEF_(0x80630203L)")]
        public const int PEER_E_NO_KEY_ACCESS = unchecked((int)(0x80630203));

        [NativeTypeName("#define PEER_E_GROUPS_EXIST _HRESULT_TYPEDEF_(0x80630204L)")]
        public const int PEER_E_GROUPS_EXIST = unchecked((int)(0x80630204));

        [NativeTypeName("#define PEER_E_RECORD_NOT_FOUND _HRESULT_TYPEDEF_(0x80630301L)")]
        public const int PEER_E_RECORD_NOT_FOUND = unchecked((int)(0x80630301));

        [NativeTypeName("#define PEER_E_DATABASE_ACCESSDENIED _HRESULT_TYPEDEF_(0x80630302L)")]
        public const int PEER_E_DATABASE_ACCESSDENIED = unchecked((int)(0x80630302));

        [NativeTypeName("#define PEER_E_DBINITIALIZATION_FAILED _HRESULT_TYPEDEF_(0x80630303L)")]
        public const int PEER_E_DBINITIALIZATION_FAILED = unchecked((int)(0x80630303));

        [NativeTypeName("#define PEER_E_MAX_RECORD_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x80630304L)")]
        public const int PEER_E_MAX_RECORD_SIZE_EXCEEDED = unchecked((int)(0x80630304));

        [NativeTypeName("#define PEER_E_DATABASE_ALREADY_PRESENT _HRESULT_TYPEDEF_(0x80630305L)")]
        public const int PEER_E_DATABASE_ALREADY_PRESENT = unchecked((int)(0x80630305));

        [NativeTypeName("#define PEER_E_DATABASE_NOT_PRESENT _HRESULT_TYPEDEF_(0x80630306L)")]
        public const int PEER_E_DATABASE_NOT_PRESENT = unchecked((int)(0x80630306));

        [NativeTypeName("#define PEER_E_IDENTITY_NOT_FOUND _HRESULT_TYPEDEF_(0x80630401L)")]
        public const int PEER_E_IDENTITY_NOT_FOUND = unchecked((int)(0x80630401));

        [NativeTypeName("#define PEER_E_EVENT_HANDLE_NOT_FOUND _HRESULT_TYPEDEF_(0x80630501L)")]
        public const int PEER_E_EVENT_HANDLE_NOT_FOUND = unchecked((int)(0x80630501));

        [NativeTypeName("#define PEER_E_INVALID_SEARCH _HRESULT_TYPEDEF_(0x80630601L)")]
        public const int PEER_E_INVALID_SEARCH = unchecked((int)(0x80630601));

        [NativeTypeName("#define PEER_E_INVALID_ATTRIBUTES _HRESULT_TYPEDEF_(0x80630602L)")]
        public const int PEER_E_INVALID_ATTRIBUTES = unchecked((int)(0x80630602));

        [NativeTypeName("#define PEER_E_INVITATION_NOT_TRUSTED _HRESULT_TYPEDEF_(0x80630701L)")]
        public const int PEER_E_INVITATION_NOT_TRUSTED = unchecked((int)(0x80630701));

        [NativeTypeName("#define PEER_E_CHAIN_TOO_LONG _HRESULT_TYPEDEF_(0x80630703L)")]
        public const int PEER_E_CHAIN_TOO_LONG = unchecked((int)(0x80630703));

        [NativeTypeName("#define PEER_E_INVALID_TIME_PERIOD _HRESULT_TYPEDEF_(0x80630705L)")]
        public const int PEER_E_INVALID_TIME_PERIOD = unchecked((int)(0x80630705));

        [NativeTypeName("#define PEER_E_CIRCULAR_CHAIN_DETECTED _HRESULT_TYPEDEF_(0x80630706L)")]
        public const int PEER_E_CIRCULAR_CHAIN_DETECTED = unchecked((int)(0x80630706));

        [NativeTypeName("#define PEER_E_CERT_STORE_CORRUPTED _HRESULT_TYPEDEF_(0x80630801L)")]
        public const int PEER_E_CERT_STORE_CORRUPTED = unchecked((int)(0x80630801));

        [NativeTypeName("#define PEER_E_NO_CLOUD _HRESULT_TYPEDEF_(0x80631001L)")]
        public const int PEER_E_NO_CLOUD = unchecked((int)(0x80631001));

        [NativeTypeName("#define PEER_E_CLOUD_NAME_AMBIGUOUS _HRESULT_TYPEDEF_(0x80631005L)")]
        public const int PEER_E_CLOUD_NAME_AMBIGUOUS = unchecked((int)(0x80631005));

        [NativeTypeName("#define PEER_E_INVALID_RECORD _HRESULT_TYPEDEF_(0x80632010L)")]
        public const int PEER_E_INVALID_RECORD = unchecked((int)(0x80632010));

        [NativeTypeName("#define PEER_E_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x80632020L)")]
        public const int PEER_E_NOT_AUTHORIZED = unchecked((int)(0x80632020));

        [NativeTypeName("#define PEER_E_PASSWORD_DOES_NOT_MEET_POLICY _HRESULT_TYPEDEF_(0x80632021L)")]
        public const int PEER_E_PASSWORD_DOES_NOT_MEET_POLICY = unchecked((int)(0x80632021));

        [NativeTypeName("#define PEER_E_DEFERRED_VALIDATION _HRESULT_TYPEDEF_(0x80632030L)")]
        public const int PEER_E_DEFERRED_VALIDATION = unchecked((int)(0x80632030));

        [NativeTypeName("#define PEER_E_INVALID_GROUP_PROPERTIES _HRESULT_TYPEDEF_(0x80632040L)")]
        public const int PEER_E_INVALID_GROUP_PROPERTIES = unchecked((int)(0x80632040));

        [NativeTypeName("#define PEER_E_INVALID_PEER_NAME _HRESULT_TYPEDEF_(0x80632050L)")]
        public const int PEER_E_INVALID_PEER_NAME = unchecked((int)(0x80632050));

        [NativeTypeName("#define PEER_E_INVALID_CLASSIFIER _HRESULT_TYPEDEF_(0x80632060L)")]
        public const int PEER_E_INVALID_CLASSIFIER = unchecked((int)(0x80632060));

        [NativeTypeName("#define PEER_E_INVALID_FRIENDLY_NAME _HRESULT_TYPEDEF_(0x80632070L)")]
        public const int PEER_E_INVALID_FRIENDLY_NAME = unchecked((int)(0x80632070));

        [NativeTypeName("#define PEER_E_INVALID_ROLE_PROPERTY _HRESULT_TYPEDEF_(0x80632071L)")]
        public const int PEER_E_INVALID_ROLE_PROPERTY = unchecked((int)(0x80632071));

        [NativeTypeName("#define PEER_E_INVALID_CLASSIFIER_PROPERTY _HRESULT_TYPEDEF_(0x80632072L)")]
        public const int PEER_E_INVALID_CLASSIFIER_PROPERTY = unchecked((int)(0x80632072));

        [NativeTypeName("#define PEER_E_INVALID_RECORD_EXPIRATION _HRESULT_TYPEDEF_(0x80632080L)")]
        public const int PEER_E_INVALID_RECORD_EXPIRATION = unchecked((int)(0x80632080));

        [NativeTypeName("#define PEER_E_INVALID_CREDENTIAL_INFO _HRESULT_TYPEDEF_(0x80632081L)")]
        public const int PEER_E_INVALID_CREDENTIAL_INFO = unchecked((int)(0x80632081));

        [NativeTypeName("#define PEER_E_INVALID_CREDENTIAL _HRESULT_TYPEDEF_(0x80632082L)")]
        public const int PEER_E_INVALID_CREDENTIAL = unchecked((int)(0x80632082));

        [NativeTypeName("#define PEER_E_INVALID_RECORD_SIZE _HRESULT_TYPEDEF_(0x80632083L)")]
        public const int PEER_E_INVALID_RECORD_SIZE = unchecked((int)(0x80632083));

        [NativeTypeName("#define PEER_E_UNSUPPORTED_VERSION _HRESULT_TYPEDEF_(0x80632090L)")]
        public const int PEER_E_UNSUPPORTED_VERSION = unchecked((int)(0x80632090));

        [NativeTypeName("#define PEER_E_GROUP_NOT_READY _HRESULT_TYPEDEF_(0x80632091L)")]
        public const int PEER_E_GROUP_NOT_READY = unchecked((int)(0x80632091));

        [NativeTypeName("#define PEER_E_GROUP_IN_USE _HRESULT_TYPEDEF_(0x80632092L)")]
        public const int PEER_E_GROUP_IN_USE = unchecked((int)(0x80632092));

        [NativeTypeName("#define PEER_E_INVALID_GROUP _HRESULT_TYPEDEF_(0x80632093L)")]
        public const int PEER_E_INVALID_GROUP = unchecked((int)(0x80632093));

        [NativeTypeName("#define PEER_E_NO_MEMBERS_FOUND _HRESULT_TYPEDEF_(0x80632094L)")]
        public const int PEER_E_NO_MEMBERS_FOUND = unchecked((int)(0x80632094));

        [NativeTypeName("#define PEER_E_NO_MEMBER_CONNECTIONS _HRESULT_TYPEDEF_(0x80632095L)")]
        public const int PEER_E_NO_MEMBER_CONNECTIONS = unchecked((int)(0x80632095));

        [NativeTypeName("#define PEER_E_UNABLE_TO_LISTEN _HRESULT_TYPEDEF_(0x80632096L)")]
        public const int PEER_E_UNABLE_TO_LISTEN = unchecked((int)(0x80632096));

        [NativeTypeName("#define PEER_E_IDENTITY_DELETED _HRESULT_TYPEDEF_(0x806320A0L)")]
        public const int PEER_E_IDENTITY_DELETED = unchecked((int)(0x806320A0));

        [NativeTypeName("#define PEER_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x806320A1L)")]
        public const int PEER_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x806320A1));

        [NativeTypeName("#define PEER_E_CONTACT_NOT_FOUND _HRESULT_TYPEDEF_(0x80636001L)")]
        public const int PEER_E_CONTACT_NOT_FOUND = unchecked((int)(0x80636001));

        [NativeTypeName("#define PEER_S_GRAPH_DATA_CREATED _HRESULT_TYPEDEF_(0x00630001L)")]
        public const int PEER_S_GRAPH_DATA_CREATED = ((int)(0x00630001));

        [NativeTypeName("#define PEER_S_NO_EVENT_DATA _HRESULT_TYPEDEF_(0x00630002L)")]
        public const int PEER_S_NO_EVENT_DATA = ((int)(0x00630002));

        [NativeTypeName("#define PEER_S_ALREADY_CONNECTED _HRESULT_TYPEDEF_(0x00632000L)")]
        public const int PEER_S_ALREADY_CONNECTED = ((int)(0x00632000));

        [NativeTypeName("#define PEER_S_SUBSCRIPTION_EXISTS _HRESULT_TYPEDEF_(0x00636000L)")]
        public const int PEER_S_SUBSCRIPTION_EXISTS = ((int)(0x00636000));

        [NativeTypeName("#define PEER_S_NO_CONNECTIVITY _HRESULT_TYPEDEF_(0x00630005L)")]
        public const int PEER_S_NO_CONNECTIVITY = ((int)(0x00630005));

        [NativeTypeName("#define PEER_S_ALREADY_A_MEMBER _HRESULT_TYPEDEF_(0x00630006L)")]
        public const int PEER_S_ALREADY_A_MEMBER = ((int)(0x00630006));

        [NativeTypeName("#define PEER_E_CANNOT_CONVERT_PEER_NAME _HRESULT_TYPEDEF_(0x80634001L)")]
        public const int PEER_E_CANNOT_CONVERT_PEER_NAME = unchecked((int)(0x80634001));

        [NativeTypeName("#define PEER_E_INVALID_PEER_HOST_NAME _HRESULT_TYPEDEF_(0x80634002L)")]
        public const int PEER_E_INVALID_PEER_HOST_NAME = unchecked((int)(0x80634002));

        [NativeTypeName("#define PEER_E_NO_MORE _HRESULT_TYPEDEF_(0x80634003L)")]
        public const int PEER_E_NO_MORE = unchecked((int)(0x80634003));

        [NativeTypeName("#define PEER_E_PNRP_DUPLICATE_PEER_NAME _HRESULT_TYPEDEF_(0x80634005L)")]
        public const int PEER_E_PNRP_DUPLICATE_PEER_NAME = unchecked((int)(0x80634005));

        [NativeTypeName("#define PEER_E_INVITE_CANCELLED _HRESULT_TYPEDEF_(0x80637000L)")]
        public const int PEER_E_INVITE_CANCELLED = unchecked((int)(0x80637000));

        [NativeTypeName("#define PEER_E_INVITE_RESPONSE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80637001L)")]
        public const int PEER_E_INVITE_RESPONSE_NOT_AVAILABLE = unchecked((int)(0x80637001));

        [NativeTypeName("#define PEER_E_NOT_SIGNED_IN _HRESULT_TYPEDEF_(0x80637003L)")]
        public const int PEER_E_NOT_SIGNED_IN = unchecked((int)(0x80637003));

        [NativeTypeName("#define PEER_E_PRIVACY_DECLINED _HRESULT_TYPEDEF_(0x80637004L)")]
        public const int PEER_E_PRIVACY_DECLINED = unchecked((int)(0x80637004));

        [NativeTypeName("#define PEER_E_TIMEOUT _HRESULT_TYPEDEF_(0x80637005L)")]
        public const int PEER_E_TIMEOUT = unchecked((int)(0x80637005));

        [NativeTypeName("#define PEER_E_INVALID_ADDRESS _HRESULT_TYPEDEF_(0x80637007L)")]
        public const int PEER_E_INVALID_ADDRESS = unchecked((int)(0x80637007));

        [NativeTypeName("#define PEER_E_FW_EXCEPTION_DISABLED _HRESULT_TYPEDEF_(0x80637008L)")]
        public const int PEER_E_FW_EXCEPTION_DISABLED = unchecked((int)(0x80637008));

        [NativeTypeName("#define PEER_E_FW_BLOCKED_BY_POLICY _HRESULT_TYPEDEF_(0x80637009L)")]
        public const int PEER_E_FW_BLOCKED_BY_POLICY = unchecked((int)(0x80637009));

        [NativeTypeName("#define PEER_E_FW_BLOCKED_BY_SHIELDS_UP _HRESULT_TYPEDEF_(0x8063700AL)")]
        public const int PEER_E_FW_BLOCKED_BY_SHIELDS_UP = unchecked((int)(0x8063700A));

        [NativeTypeName("#define PEER_E_FW_DECLINED _HRESULT_TYPEDEF_(0x8063700BL)")]
        public const int PEER_E_FW_DECLINED = unchecked((int)(0x8063700B));

        [NativeTypeName("#define UI_E_CREATE_FAILED _HRESULT_TYPEDEF_(0x802A0001L)")]
        public const int UI_E_CREATE_FAILED = unchecked((int)(0x802A0001));

        [NativeTypeName("#define UI_E_SHUTDOWN_CALLED _HRESULT_TYPEDEF_(0x802A0002L)")]
        public const int UI_E_SHUTDOWN_CALLED = unchecked((int)(0x802A0002));

        [NativeTypeName("#define UI_E_ILLEGAL_REENTRANCY _HRESULT_TYPEDEF_(0x802A0003L)")]
        public const int UI_E_ILLEGAL_REENTRANCY = unchecked((int)(0x802A0003));

        [NativeTypeName("#define UI_E_OBJECT_SEALED _HRESULT_TYPEDEF_(0x802A0004L)")]
        public const int UI_E_OBJECT_SEALED = unchecked((int)(0x802A0004));

        [NativeTypeName("#define UI_E_VALUE_NOT_SET _HRESULT_TYPEDEF_(0x802A0005L)")]
        public const int UI_E_VALUE_NOT_SET = unchecked((int)(0x802A0005));

        [NativeTypeName("#define UI_E_VALUE_NOT_DETERMINED _HRESULT_TYPEDEF_(0x802A0006L)")]
        public const int UI_E_VALUE_NOT_DETERMINED = unchecked((int)(0x802A0006));

        [NativeTypeName("#define UI_E_INVALID_OUTPUT _HRESULT_TYPEDEF_(0x802A0007L)")]
        public const int UI_E_INVALID_OUTPUT = unchecked((int)(0x802A0007));

        [NativeTypeName("#define UI_E_BOOLEAN_EXPECTED _HRESULT_TYPEDEF_(0x802A0008L)")]
        public const int UI_E_BOOLEAN_EXPECTED = unchecked((int)(0x802A0008));

        [NativeTypeName("#define UI_E_DIFFERENT_OWNER _HRESULT_TYPEDEF_(0x802A0009L)")]
        public const int UI_E_DIFFERENT_OWNER = unchecked((int)(0x802A0009));

        [NativeTypeName("#define UI_E_AMBIGUOUS_MATCH _HRESULT_TYPEDEF_(0x802A000AL)")]
        public const int UI_E_AMBIGUOUS_MATCH = unchecked((int)(0x802A000A));

        [NativeTypeName("#define UI_E_FP_OVERFLOW _HRESULT_TYPEDEF_(0x802A000BL)")]
        public const int UI_E_FP_OVERFLOW = unchecked((int)(0x802A000B));

        [NativeTypeName("#define UI_E_WRONG_THREAD _HRESULT_TYPEDEF_(0x802A000CL)")]
        public const int UI_E_WRONG_THREAD = unchecked((int)(0x802A000C));

        [NativeTypeName("#define UI_E_STORYBOARD_ACTIVE _HRESULT_TYPEDEF_(0x802A0101L)")]
        public const int UI_E_STORYBOARD_ACTIVE = unchecked((int)(0x802A0101));

        [NativeTypeName("#define UI_E_STORYBOARD_NOT_PLAYING _HRESULT_TYPEDEF_(0x802A0102L)")]
        public const int UI_E_STORYBOARD_NOT_PLAYING = unchecked((int)(0x802A0102));

        [NativeTypeName("#define UI_E_START_KEYFRAME_AFTER_END _HRESULT_TYPEDEF_(0x802A0103L)")]
        public const int UI_E_START_KEYFRAME_AFTER_END = unchecked((int)(0x802A0103));

        [NativeTypeName("#define UI_E_END_KEYFRAME_NOT_DETERMINED _HRESULT_TYPEDEF_(0x802A0104L)")]
        public const int UI_E_END_KEYFRAME_NOT_DETERMINED = unchecked((int)(0x802A0104));

        [NativeTypeName("#define UI_E_LOOPS_OVERLAP _HRESULT_TYPEDEF_(0x802A0105L)")]
        public const int UI_E_LOOPS_OVERLAP = unchecked((int)(0x802A0105));

        [NativeTypeName("#define UI_E_TRANSITION_ALREADY_USED _HRESULT_TYPEDEF_(0x802A0106L)")]
        public const int UI_E_TRANSITION_ALREADY_USED = unchecked((int)(0x802A0106));

        [NativeTypeName("#define UI_E_TRANSITION_NOT_IN_STORYBOARD _HRESULT_TYPEDEF_(0x802A0107L)")]
        public const int UI_E_TRANSITION_NOT_IN_STORYBOARD = unchecked((int)(0x802A0107));

        [NativeTypeName("#define UI_E_TRANSITION_ECLIPSED _HRESULT_TYPEDEF_(0x802A0108L)")]
        public const int UI_E_TRANSITION_ECLIPSED = unchecked((int)(0x802A0108));

        [NativeTypeName("#define UI_E_TIME_BEFORE_LAST_UPDATE _HRESULT_TYPEDEF_(0x802A0109L)")]
        public const int UI_E_TIME_BEFORE_LAST_UPDATE = unchecked((int)(0x802A0109));

        [NativeTypeName("#define UI_E_TIMER_CLIENT_ALREADY_CONNECTED _HRESULT_TYPEDEF_(0x802A010AL)")]
        public const int UI_E_TIMER_CLIENT_ALREADY_CONNECTED = unchecked((int)(0x802A010A));

        [NativeTypeName("#define UI_E_INVALID_DIMENSION _HRESULT_TYPEDEF_(0x802A010BL)")]
        public const int UI_E_INVALID_DIMENSION = unchecked((int)(0x802A010B));

        [NativeTypeName("#define UI_E_PRIMITIVE_OUT_OF_BOUNDS _HRESULT_TYPEDEF_(0x802A010CL)")]
        public const int UI_E_PRIMITIVE_OUT_OF_BOUNDS = unchecked((int)(0x802A010C));

        [NativeTypeName("#define UI_E_WINDOW_CLOSED _HRESULT_TYPEDEF_(0x802A0201L)")]
        public const int UI_E_WINDOW_CLOSED = unchecked((int)(0x802A0201));

        [NativeTypeName("#define STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE _HRESULT_TYPEDEF_(0x80670001L)")]
        public const int STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE = unchecked((int)(0x80670001));

        [NativeTypeName("#define STATEREPOSITORY_E_STATEMENT_INPROGRESS _HRESULT_TYPEDEF_(0x80670002L)")]
        public const int STATEREPOSITORY_E_STATEMENT_INPROGRESS = unchecked((int)(0x80670002));

        [NativeTypeName("#define STATEREPOSITORY_E_CONFIGURATION_INVALID _HRESULT_TYPEDEF_(0x80670003L)")]
        public const int STATEREPOSITORY_E_CONFIGURATION_INVALID = unchecked((int)(0x80670003));

        [NativeTypeName("#define STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION _HRESULT_TYPEDEF_(0x80670004L)")]
        public const int STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION = unchecked((int)(0x80670004));

        [NativeTypeName("#define STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED _HRESULT_TYPEDEF_(0x80670005L)")]
        public const int STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED = unchecked((int)(0x80670005));

        [NativeTypeName("#define STATEREPOSITORY_E_BLOCKED _HRESULT_TYPEDEF_(0x80670006L)")]
        public const int STATEREPOSITORY_E_BLOCKED = unchecked((int)(0x80670006));

        [NativeTypeName("#define STATEREPOSITORY_E_BUSY_RETRY _HRESULT_TYPEDEF_(0x80670007L)")]
        public const int STATEREPOSITORY_E_BUSY_RETRY = unchecked((int)(0x80670007));

        [NativeTypeName("#define STATEREPOSITORY_E_BUSY_RECOVERY_RETRY _HRESULT_TYPEDEF_(0x80670008L)")]
        public const int STATEREPOSITORY_E_BUSY_RECOVERY_RETRY = unchecked((int)(0x80670008));

        [NativeTypeName("#define STATEREPOSITORY_E_LOCKED_RETRY _HRESULT_TYPEDEF_(0x80670009L)")]
        public const int STATEREPOSITORY_E_LOCKED_RETRY = unchecked((int)(0x80670009));

        [NativeTypeName("#define STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY _HRESULT_TYPEDEF_(0x8067000AL)")]
        public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY = unchecked((int)(0x8067000A));

        [NativeTypeName("#define STATEREPOSITORY_E_TRANSACTION_REQUIRED _HRESULT_TYPEDEF_(0x8067000BL)")]
        public const int STATEREPOSITORY_E_TRANSACTION_REQUIRED = unchecked((int)(0x8067000B));

        [NativeTypeName("#define STATEREPOSITORY_E_BUSY_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000CL)")]
        public const int STATEREPOSITORY_E_BUSY_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000C));

        [NativeTypeName("#define STATEREPOSITORY_E_BUSY_RECOVERY_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000DL)")]
        public const int STATEREPOSITORY_E_BUSY_RECOVERY_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000D));

        [NativeTypeName("#define STATEREPOSITORY_E_LOCKED_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000EL)")]
        public const int STATEREPOSITORY_E_LOCKED_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000E));

        [NativeTypeName("#define STATEREPOSITORY_E_LOCKED_SHAREDCACHE_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000FL)")]
        public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000F));

        [NativeTypeName("#define STATEREPOSITORY_E_SERVICE_STOP_IN_PROGRESS _HRESULT_TYPEDEF_(0x80670010L)")]
        public const int STATEREPOSITORY_E_SERVICE_STOP_IN_PROGRESS = unchecked((int)(0x80670010));

        [NativeTypeName("#define STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80670011L)")]
        public const int STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED = unchecked((int)(0x80670011));

        [NativeTypeName("#define STATEREPOSITORY_ERROR_CACHE_CORRUPTED _HRESULT_TYPEDEF_(0x80670012L)")]
        public const int STATEREPOSITORY_ERROR_CACHE_CORRUPTED = unchecked((int)(0x80670012));

        [NativeTypeName("#define STATEREPOSITORY_TRANSACTION_CALLER_ID_CHANGED _HRESULT_TYPEDEF_(0x00670013L)")]
        public const int STATEREPOSITORY_TRANSACTION_CALLER_ID_CHANGED = ((int)(0x00670013));

        [NativeTypeName("#define STATEREPOSITORY_TRANSACTION_IN_PROGRESS _HRESULT_TYPEDEF_(0x80670014L)")]
        public const int STATEREPOSITORY_TRANSACTION_IN_PROGRESS = unchecked((int)(0x80670014));

        [NativeTypeName("#define STATEREPOSITORY_E_CACHE_NOT_INIITALIZED _HRESULT_TYPEDEF_(0x80670015L)")]
        public const int STATEREPOSITORY_E_CACHE_NOT_INIITALIZED = unchecked((int)(0x80670015));

        [NativeTypeName("#define STATEREPOSITORY_E_DEPENDENCY_NOT_RESOLVED _HRESULT_TYPEDEF_(0x80670016L)")]
        public const int STATEREPOSITORY_E_DEPENDENCY_NOT_RESOLVED = unchecked((int)(0x80670016));

        [NativeTypeName("#define DXGI_STATUS_OCCLUDED _HRESULT_TYPEDEF_(0x087A0001L)")]
        public const int DXGI_STATUS_OCCLUDED = ((int)(0x087A0001));

        [NativeTypeName("#define DXGI_STATUS_CLIPPED _HRESULT_TYPEDEF_(0x087A0002L)")]
        public const int DXGI_STATUS_CLIPPED = ((int)(0x087A0002));

        [NativeTypeName("#define DXGI_STATUS_NO_REDIRECTION _HRESULT_TYPEDEF_(0x087A0004L)")]
        public const int DXGI_STATUS_NO_REDIRECTION = ((int)(0x087A0004));

        [NativeTypeName("#define DXGI_STATUS_NO_DESKTOP_ACCESS _HRESULT_TYPEDEF_(0x087A0005L)")]
        public const int DXGI_STATUS_NO_DESKTOP_ACCESS = ((int)(0x087A0005));

        [NativeTypeName("#define DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE _HRESULT_TYPEDEF_(0x087A0006L)")]
        public const int DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = ((int)(0x087A0006));

        [NativeTypeName("#define DXGI_STATUS_MODE_CHANGED _HRESULT_TYPEDEF_(0x087A0007L)")]
        public const int DXGI_STATUS_MODE_CHANGED = ((int)(0x087A0007));

        [NativeTypeName("#define DXGI_STATUS_MODE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0x087A0008L)")]
        public const int DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = ((int)(0x087A0008));

        [NativeTypeName("#define DXGI_ERROR_INVALID_CALL _HRESULT_TYPEDEF_(0x887A0001L)")]
        public const int DXGI_ERROR_INVALID_CALL = unchecked((int)(0x887A0001));

        [NativeTypeName("#define DXGI_ERROR_NOT_FOUND _HRESULT_TYPEDEF_(0x887A0002L)")]
        public const int DXGI_ERROR_NOT_FOUND = unchecked((int)(0x887A0002));

        [NativeTypeName("#define DXGI_ERROR_MORE_DATA _HRESULT_TYPEDEF_(0x887A0003L)")]
        public const int DXGI_ERROR_MORE_DATA = unchecked((int)(0x887A0003));

        [NativeTypeName("#define DXGI_ERROR_UNSUPPORTED _HRESULT_TYPEDEF_(0x887A0004L)")]
        public const int DXGI_ERROR_UNSUPPORTED = unchecked((int)(0x887A0004));

        [NativeTypeName("#define DXGI_ERROR_DEVICE_REMOVED _HRESULT_TYPEDEF_(0x887A0005L)")]
        public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)(0x887A0005));

        [NativeTypeName("#define DXGI_ERROR_DEVICE_HUNG _HRESULT_TYPEDEF_(0x887A0006L)")]
        public const int DXGI_ERROR_DEVICE_HUNG = unchecked((int)(0x887A0006));

        [NativeTypeName("#define DXGI_ERROR_DEVICE_RESET _HRESULT_TYPEDEF_(0x887A0007L)")]
        public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)(0x887A0007));

        [NativeTypeName("#define DXGI_ERROR_WAS_STILL_DRAWING _HRESULT_TYPEDEF_(0x887A000AL)")]
        public const int DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)(0x887A000A));

        [NativeTypeName("#define DXGI_ERROR_FRAME_STATISTICS_DISJOINT _HRESULT_TYPEDEF_(0x887A000BL)")]
        public const int DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)(0x887A000B));

        [NativeTypeName("#define DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE _HRESULT_TYPEDEF_(0x887A000CL)")]
        public const int DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)(0x887A000C));

        [NativeTypeName("#define DXGI_ERROR_DRIVER_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x887A0020L)")]
        public const int DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)(0x887A0020));

        [NativeTypeName("#define DXGI_ERROR_NONEXCLUSIVE _HRESULT_TYPEDEF_(0x887A0021L)")]
        public const int DXGI_ERROR_NONEXCLUSIVE = unchecked((int)(0x887A0021));

        [NativeTypeName("#define DXGI_ERROR_NOT_CURRENTLY_AVAILABLE _HRESULT_TYPEDEF_(0x887A0022L)")]
        public const int DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)(0x887A0022));

        [NativeTypeName("#define DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED _HRESULT_TYPEDEF_(0x887A0023L)")]
        public const int DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)(0x887A0023));

        [NativeTypeName("#define DXGI_ERROR_REMOTE_OUTOFMEMORY _HRESULT_TYPEDEF_(0x887A0024L)")]
        public const int DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)(0x887A0024));

        [NativeTypeName("#define DXGI_ERROR_ACCESS_LOST _HRESULT_TYPEDEF_(0x887A0026L)")]
        public const int DXGI_ERROR_ACCESS_LOST = unchecked((int)(0x887A0026));

        [NativeTypeName("#define DXGI_ERROR_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x887A0027L)")]
        public const int DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)(0x887A0027));

        [NativeTypeName("#define DXGI_ERROR_SESSION_DISCONNECTED _HRESULT_TYPEDEF_(0x887A0028L)")]
        public const int DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)(0x887A0028));

        [NativeTypeName("#define DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE _HRESULT_TYPEDEF_(0x887A0029L)")]
        public const int DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)(0x887A0029));

        [NativeTypeName("#define DXGI_ERROR_CANNOT_PROTECT_CONTENT _HRESULT_TYPEDEF_(0x887A002AL)")]
        public const int DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)(0x887A002A));

        [NativeTypeName("#define DXGI_ERROR_ACCESS_DENIED _HRESULT_TYPEDEF_(0x887A002BL)")]
        public const int DXGI_ERROR_ACCESS_DENIED = unchecked((int)(0x887A002B));

        [NativeTypeName("#define DXGI_ERROR_NAME_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x887A002CL)")]
        public const int DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)(0x887A002C));

        [NativeTypeName("#define DXGI_ERROR_SDK_COMPONENT_MISSING _HRESULT_TYPEDEF_(0x887A002DL)")]
        public const int DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)(0x887A002D));

        [NativeTypeName("#define DXGI_ERROR_NOT_CURRENT _HRESULT_TYPEDEF_(0x887A002EL)")]
        public const int DXGI_ERROR_NOT_CURRENT = unchecked((int)(0x887A002E));

        [NativeTypeName("#define DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY _HRESULT_TYPEDEF_(0x887A0030L)")]
        public const int DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)(0x887A0030));

        [NativeTypeName("#define DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION _HRESULT_TYPEDEF_(0x887A0031L)")]
        public const int DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)(0x887A0031));

        [NativeTypeName("#define DXGI_ERROR_NON_COMPOSITED_UI _HRESULT_TYPEDEF_(0x887A0032L)")]
        public const int DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)(0x887A0032));

        [NativeTypeName("#define DXCORE_ERROR_EVENT_NOT_UNREGISTERED _HRESULT_TYPEDEF_(0x88800001L)")]
        public const int DXCORE_ERROR_EVENT_NOT_UNREGISTERED = unchecked((int)(0x88800001));

        [NativeTypeName("#define DXGI_STATUS_UNOCCLUDED _HRESULT_TYPEDEF_(0x087A0009L)")]
        public const int DXGI_STATUS_UNOCCLUDED = ((int)(0x087A0009));

        [NativeTypeName("#define DXGI_STATUS_DDA_WAS_STILL_DRAWING _HRESULT_TYPEDEF_(0x087A000AL)")]
        public const int DXGI_STATUS_DDA_WAS_STILL_DRAWING = ((int)(0x087A000A));

        [NativeTypeName("#define DXGI_ERROR_MODE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0x887A0025L)")]
        public const int DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)(0x887A0025));

        [NativeTypeName("#define DXGI_STATUS_PRESENT_REQUIRED _HRESULT_TYPEDEF_(0x087A002FL)")]
        public const int DXGI_STATUS_PRESENT_REQUIRED = ((int)(0x087A002F));

        [NativeTypeName("#define DXGI_ERROR_CACHE_CORRUPT _HRESULT_TYPEDEF_(0x887A0033L)")]
        public const int DXGI_ERROR_CACHE_CORRUPT = unchecked((int)(0x887A0033));

        [NativeTypeName("#define DXGI_ERROR_CACHE_FULL _HRESULT_TYPEDEF_(0x887A0034L)")]
        public const int DXGI_ERROR_CACHE_FULL = unchecked((int)(0x887A0034));

        [NativeTypeName("#define DXGI_ERROR_CACHE_HASH_COLLISION _HRESULT_TYPEDEF_(0x887A0035L)")]
        public const int DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)(0x887A0035));

        [NativeTypeName("#define DXGI_ERROR_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x887A0036L)")]
        public const int DXGI_ERROR_ALREADY_EXISTS = unchecked((int)(0x887A0036));

        [NativeTypeName("#define DXGI_DDI_ERR_WASSTILLDRAWING _HRESULT_TYPEDEF_(0x887B0001L)")]
        public const int DXGI_DDI_ERR_WASSTILLDRAWING = unchecked((int)(0x887B0001));

        [NativeTypeName("#define DXGI_DDI_ERR_UNSUPPORTED _HRESULT_TYPEDEF_(0x887B0002L)")]
        public const int DXGI_DDI_ERR_UNSUPPORTED = unchecked((int)(0x887B0002));

        [NativeTypeName("#define DXGI_DDI_ERR_NONEXCLUSIVE _HRESULT_TYPEDEF_(0x887B0003L)")]
        public const int DXGI_DDI_ERR_NONEXCLUSIVE = unchecked((int)(0x887B0003));

        [NativeTypeName("#define D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS _HRESULT_TYPEDEF_(0x88790001L)")]
        public const int D3D10_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)(0x88790001));

        [NativeTypeName("#define D3D10_ERROR_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x88790002L)")]
        public const int D3D10_ERROR_FILE_NOT_FOUND = unchecked((int)(0x88790002));

        [NativeTypeName("#define D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS _HRESULT_TYPEDEF_(0x887C0001L)")]
        public const int D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)(0x887C0001));

        [NativeTypeName("#define D3D11_ERROR_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x887C0002L)")]
        public const int D3D11_ERROR_FILE_NOT_FOUND = unchecked((int)(0x887C0002));

        [NativeTypeName("#define D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS _HRESULT_TYPEDEF_(0x887C0003L)")]
        public const int D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS = unchecked((int)(0x887C0003));

        [NativeTypeName("#define D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD _HRESULT_TYPEDEF_(0x887C0004L)")]
        public const int D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD = unchecked((int)(0x887C0004));

        [NativeTypeName("#define D3D12_ERROR_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x887E0001L)")]
        public const int D3D12_ERROR_ADAPTER_NOT_FOUND = unchecked((int)(0x887E0001));

        [NativeTypeName("#define D3D12_ERROR_DRIVER_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x887E0002L)")]
        public const int D3D12_ERROR_DRIVER_VERSION_MISMATCH = unchecked((int)(0x887E0002));

        [NativeTypeName("#define D3D12_ERROR_INVALID_REDIST _HRESULT_TYPEDEF_(0x887E0003L)")]
        public const int D3D12_ERROR_INVALID_REDIST = unchecked((int)(0x887E0003));

        [NativeTypeName("#define D2DERR_WRONG_STATE _HRESULT_TYPEDEF_(0x88990001L)")]
        public const int D2DERR_WRONG_STATE = unchecked((int)(0x88990001));

        [NativeTypeName("#define D2DERR_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x88990002L)")]
        public const int D2DERR_NOT_INITIALIZED = unchecked((int)(0x88990002));

        [NativeTypeName("#define D2DERR_UNSUPPORTED_OPERATION _HRESULT_TYPEDEF_(0x88990003L)")]
        public const int D2DERR_UNSUPPORTED_OPERATION = unchecked((int)(0x88990003));

        [NativeTypeName("#define D2DERR_SCANNER_FAILED _HRESULT_TYPEDEF_(0x88990004L)")]
        public const int D2DERR_SCANNER_FAILED = unchecked((int)(0x88990004));

        [NativeTypeName("#define D2DERR_SCREEN_ACCESS_DENIED _HRESULT_TYPEDEF_(0x88990005L)")]
        public const int D2DERR_SCREEN_ACCESS_DENIED = unchecked((int)(0x88990005));

        [NativeTypeName("#define D2DERR_DISPLAY_STATE_INVALID _HRESULT_TYPEDEF_(0x88990006L)")]
        public const int D2DERR_DISPLAY_STATE_INVALID = unchecked((int)(0x88990006));

        [NativeTypeName("#define D2DERR_ZERO_VECTOR _HRESULT_TYPEDEF_(0x88990007L)")]
        public const int D2DERR_ZERO_VECTOR = unchecked((int)(0x88990007));

        [NativeTypeName("#define D2DERR_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x88990008L)")]
        public const int D2DERR_INTERNAL_ERROR = unchecked((int)(0x88990008));

        [NativeTypeName("#define D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88990009L)")]
        public const int D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = unchecked((int)(0x88990009));

        [NativeTypeName("#define D2DERR_INVALID_CALL _HRESULT_TYPEDEF_(0x8899000AL)")]
        public const int D2DERR_INVALID_CALL = unchecked((int)(0x8899000A));

        [NativeTypeName("#define D2DERR_NO_HARDWARE_DEVICE _HRESULT_TYPEDEF_(0x8899000BL)")]
        public const int D2DERR_NO_HARDWARE_DEVICE = unchecked((int)(0x8899000B));

        [NativeTypeName("#define D2DERR_RECREATE_TARGET _HRESULT_TYPEDEF_(0x8899000CL)")]
        public const int D2DERR_RECREATE_TARGET = unchecked((int)(0x8899000C));

        [NativeTypeName("#define D2DERR_TOO_MANY_SHADER_ELEMENTS _HRESULT_TYPEDEF_(0x8899000DL)")]
        public const int D2DERR_TOO_MANY_SHADER_ELEMENTS = unchecked((int)(0x8899000D));

        [NativeTypeName("#define D2DERR_SHADER_COMPILE_FAILED _HRESULT_TYPEDEF_(0x8899000EL)")]
        public const int D2DERR_SHADER_COMPILE_FAILED = unchecked((int)(0x8899000E));

        [NativeTypeName("#define D2DERR_MAX_TEXTURE_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x8899000FL)")]
        public const int D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)(0x8899000F));

        [NativeTypeName("#define D2DERR_UNSUPPORTED_VERSION _HRESULT_TYPEDEF_(0x88990010L)")]
        public const int D2DERR_UNSUPPORTED_VERSION = unchecked((int)(0x88990010));

        [NativeTypeName("#define D2DERR_BAD_NUMBER _HRESULT_TYPEDEF_(0x88990011L)")]
        public const int D2DERR_BAD_NUMBER = unchecked((int)(0x88990011));

        [NativeTypeName("#define D2DERR_WRONG_FACTORY _HRESULT_TYPEDEF_(0x88990012L)")]
        public const int D2DERR_WRONG_FACTORY = unchecked((int)(0x88990012));

        [NativeTypeName("#define D2DERR_LAYER_ALREADY_IN_USE _HRESULT_TYPEDEF_(0x88990013L)")]
        public const int D2DERR_LAYER_ALREADY_IN_USE = unchecked((int)(0x88990013));

        [NativeTypeName("#define D2DERR_POP_CALL_DID_NOT_MATCH_PUSH _HRESULT_TYPEDEF_(0x88990014L)")]
        public const int D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = unchecked((int)(0x88990014));

        [NativeTypeName("#define D2DERR_WRONG_RESOURCE_DOMAIN _HRESULT_TYPEDEF_(0x88990015L)")]
        public const int D2DERR_WRONG_RESOURCE_DOMAIN = unchecked((int)(0x88990015));

        [NativeTypeName("#define D2DERR_PUSH_POP_UNBALANCED _HRESULT_TYPEDEF_(0x88990016L)")]
        public const int D2DERR_PUSH_POP_UNBALANCED = unchecked((int)(0x88990016));

        [NativeTypeName("#define D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT _HRESULT_TYPEDEF_(0x88990017L)")]
        public const int D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = unchecked((int)(0x88990017));

        [NativeTypeName("#define D2DERR_INCOMPATIBLE_BRUSH_TYPES _HRESULT_TYPEDEF_(0x88990018L)")]
        public const int D2DERR_INCOMPATIBLE_BRUSH_TYPES = unchecked((int)(0x88990018));

        [NativeTypeName("#define D2DERR_WIN32_ERROR _HRESULT_TYPEDEF_(0x88990019L)")]
        public const int D2DERR_WIN32_ERROR = unchecked((int)(0x88990019));

        [NativeTypeName("#define D2DERR_TARGET_NOT_GDI_COMPATIBLE _HRESULT_TYPEDEF_(0x8899001AL)")]
        public const int D2DERR_TARGET_NOT_GDI_COMPATIBLE = unchecked((int)(0x8899001A));

        [NativeTypeName("#define D2DERR_TEXT_EFFECT_IS_WRONG_TYPE _HRESULT_TYPEDEF_(0x8899001BL)")]
        public const int D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = unchecked((int)(0x8899001B));

        [NativeTypeName("#define D2DERR_TEXT_RENDERER_NOT_RELEASED _HRESULT_TYPEDEF_(0x8899001CL)")]
        public const int D2DERR_TEXT_RENDERER_NOT_RELEASED = unchecked((int)(0x8899001C));

        [NativeTypeName("#define D2DERR_EXCEEDS_MAX_BITMAP_SIZE _HRESULT_TYPEDEF_(0x8899001DL)")]
        public const int D2DERR_EXCEEDS_MAX_BITMAP_SIZE = unchecked((int)(0x8899001D));

        [NativeTypeName("#define D2DERR_INVALID_GRAPH_CONFIGURATION _HRESULT_TYPEDEF_(0x8899001EL)")]
        public const int D2DERR_INVALID_GRAPH_CONFIGURATION = unchecked((int)(0x8899001E));

        [NativeTypeName("#define D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION _HRESULT_TYPEDEF_(0x8899001FL)")]
        public const int D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = unchecked((int)(0x8899001F));

        [NativeTypeName("#define D2DERR_CYCLIC_GRAPH _HRESULT_TYPEDEF_(0x88990020L)")]
        public const int D2DERR_CYCLIC_GRAPH = unchecked((int)(0x88990020));

        [NativeTypeName("#define D2DERR_BITMAP_CANNOT_DRAW _HRESULT_TYPEDEF_(0x88990021L)")]
        public const int D2DERR_BITMAP_CANNOT_DRAW = unchecked((int)(0x88990021));

        [NativeTypeName("#define D2DERR_OUTSTANDING_BITMAP_REFERENCES _HRESULT_TYPEDEF_(0x88990022L)")]
        public const int D2DERR_OUTSTANDING_BITMAP_REFERENCES = unchecked((int)(0x88990022));

        [NativeTypeName("#define D2DERR_ORIGINAL_TARGET_NOT_BOUND _HRESULT_TYPEDEF_(0x88990023L)")]
        public const int D2DERR_ORIGINAL_TARGET_NOT_BOUND = unchecked((int)(0x88990023));

        [NativeTypeName("#define D2DERR_INVALID_TARGET _HRESULT_TYPEDEF_(0x88990024L)")]
        public const int D2DERR_INVALID_TARGET = unchecked((int)(0x88990024));

        [NativeTypeName("#define D2DERR_BITMAP_BOUND_AS_TARGET _HRESULT_TYPEDEF_(0x88990025L)")]
        public const int D2DERR_BITMAP_BOUND_AS_TARGET = unchecked((int)(0x88990025));

        [NativeTypeName("#define D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES _HRESULT_TYPEDEF_(0x88990026L)")]
        public const int D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = unchecked((int)(0x88990026));

        [NativeTypeName("#define D2DERR_INTERMEDIATE_TOO_LARGE _HRESULT_TYPEDEF_(0x88990027L)")]
        public const int D2DERR_INTERMEDIATE_TOO_LARGE = unchecked((int)(0x88990027));

        [NativeTypeName("#define D2DERR_EFFECT_IS_NOT_REGISTERED _HRESULT_TYPEDEF_(0x88990028L)")]
        public const int D2DERR_EFFECT_IS_NOT_REGISTERED = unchecked((int)(0x88990028));

        [NativeTypeName("#define D2DERR_INVALID_PROPERTY _HRESULT_TYPEDEF_(0x88990029L)")]
        public const int D2DERR_INVALID_PROPERTY = unchecked((int)(0x88990029));

        [NativeTypeName("#define D2DERR_NO_SUBPROPERTIES _HRESULT_TYPEDEF_(0x8899002AL)")]
        public const int D2DERR_NO_SUBPROPERTIES = unchecked((int)(0x8899002A));

        [NativeTypeName("#define D2DERR_PRINT_JOB_CLOSED _HRESULT_TYPEDEF_(0x8899002BL)")]
        public const int D2DERR_PRINT_JOB_CLOSED = unchecked((int)(0x8899002B));

        [NativeTypeName("#define D2DERR_PRINT_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8899002CL)")]
        public const int D2DERR_PRINT_FORMAT_NOT_SUPPORTED = unchecked((int)(0x8899002C));

        [NativeTypeName("#define D2DERR_TOO_MANY_TRANSFORM_INPUTS _HRESULT_TYPEDEF_(0x8899002DL)")]
        public const int D2DERR_TOO_MANY_TRANSFORM_INPUTS = unchecked((int)(0x8899002D));

        [NativeTypeName("#define D2DERR_INVALID_GLYPH_IMAGE _HRESULT_TYPEDEF_(0x8899002EL)")]
        public const int D2DERR_INVALID_GLYPH_IMAGE = unchecked((int)(0x8899002E));

        [NativeTypeName("#define DWRITE_E_FILEFORMAT _HRESULT_TYPEDEF_(0x88985000L)")]
        public const int DWRITE_E_FILEFORMAT = unchecked((int)(0x88985000));

        [NativeTypeName("#define DWRITE_E_UNEXPECTED _HRESULT_TYPEDEF_(0x88985001L)")]
        public const int DWRITE_E_UNEXPECTED = unchecked((int)(0x88985001));

        [NativeTypeName("#define DWRITE_E_NOFONT _HRESULT_TYPEDEF_(0x88985002L)")]
        public const int DWRITE_E_NOFONT = unchecked((int)(0x88985002));

        [NativeTypeName("#define DWRITE_E_FILENOTFOUND _HRESULT_TYPEDEF_(0x88985003L)")]
        public const int DWRITE_E_FILENOTFOUND = unchecked((int)(0x88985003));

        [NativeTypeName("#define DWRITE_E_FILEACCESS _HRESULT_TYPEDEF_(0x88985004L)")]
        public const int DWRITE_E_FILEACCESS = unchecked((int)(0x88985004));

        [NativeTypeName("#define DWRITE_E_FONTCOLLECTIONOBSOLETE _HRESULT_TYPEDEF_(0x88985005L)")]
        public const int DWRITE_E_FONTCOLLECTIONOBSOLETE = unchecked((int)(0x88985005));

        [NativeTypeName("#define DWRITE_E_ALREADYREGISTERED _HRESULT_TYPEDEF_(0x88985006L)")]
        public const int DWRITE_E_ALREADYREGISTERED = unchecked((int)(0x88985006));

        [NativeTypeName("#define DWRITE_E_CACHEFORMAT _HRESULT_TYPEDEF_(0x88985007L)")]
        public const int DWRITE_E_CACHEFORMAT = unchecked((int)(0x88985007));

        [NativeTypeName("#define DWRITE_E_CACHEVERSION _HRESULT_TYPEDEF_(0x88985008L)")]
        public const int DWRITE_E_CACHEVERSION = unchecked((int)(0x88985008));

        [NativeTypeName("#define DWRITE_E_UNSUPPORTEDOPERATION _HRESULT_TYPEDEF_(0x88985009L)")]
        public const int DWRITE_E_UNSUPPORTEDOPERATION = unchecked((int)(0x88985009));

        [NativeTypeName("#define DWRITE_E_TEXTRENDERERINCOMPATIBLE _HRESULT_TYPEDEF_(0x8898500AL)")]
        public const int DWRITE_E_TEXTRENDERERINCOMPATIBLE = unchecked((int)(0x8898500A));

        [NativeTypeName("#define DWRITE_E_FLOWDIRECTIONCONFLICTS _HRESULT_TYPEDEF_(0x8898500BL)")]
        public const int DWRITE_E_FLOWDIRECTIONCONFLICTS = unchecked((int)(0x8898500B));

        [NativeTypeName("#define DWRITE_E_NOCOLOR _HRESULT_TYPEDEF_(0x8898500CL)")]
        public const int DWRITE_E_NOCOLOR = unchecked((int)(0x8898500C));

        [NativeTypeName("#define DWRITE_E_REMOTEFONT _HRESULT_TYPEDEF_(0x8898500DL)")]
        public const int DWRITE_E_REMOTEFONT = unchecked((int)(0x8898500D));

        [NativeTypeName("#define DWRITE_E_DOWNLOADCANCELLED _HRESULT_TYPEDEF_(0x8898500EL)")]
        public const int DWRITE_E_DOWNLOADCANCELLED = unchecked((int)(0x8898500E));

        [NativeTypeName("#define DWRITE_E_DOWNLOADFAILED _HRESULT_TYPEDEF_(0x8898500FL)")]
        public const int DWRITE_E_DOWNLOADFAILED = unchecked((int)(0x8898500F));

        [NativeTypeName("#define DWRITE_E_TOOMANYDOWNLOADS _HRESULT_TYPEDEF_(0x88985010L)")]
        public const int DWRITE_E_TOOMANYDOWNLOADS = unchecked((int)(0x88985010));

        [NativeTypeName("#define WINCODEC_ERR_WRONGSTATE _HRESULT_TYPEDEF_(0x88982F04L)")]
        public const int WINCODEC_ERR_WRONGSTATE = unchecked((int)(0x88982F04));

        [NativeTypeName("#define WINCODEC_ERR_VALUEOUTOFRANGE _HRESULT_TYPEDEF_(0x88982F05L)")]
        public const int WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)(0x88982F05));

        [NativeTypeName("#define WINCODEC_ERR_UNKNOWNIMAGEFORMAT _HRESULT_TYPEDEF_(0x88982F07L)")]
        public const int WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)(0x88982F07));

        [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDVERSION _HRESULT_TYPEDEF_(0x88982F0BL)")]
        public const int WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)(0x88982F0B));

        [NativeTypeName("#define WINCODEC_ERR_NOTINITIALIZED _HRESULT_TYPEDEF_(0x88982F0CL)")]
        public const int WINCODEC_ERR_NOTINITIALIZED = unchecked((int)(0x88982F0C));

        [NativeTypeName("#define WINCODEC_ERR_ALREADYLOCKED _HRESULT_TYPEDEF_(0x88982F0DL)")]
        public const int WINCODEC_ERR_ALREADYLOCKED = unchecked((int)(0x88982F0D));

        [NativeTypeName("#define WINCODEC_ERR_PROPERTYNOTFOUND _HRESULT_TYPEDEF_(0x88982F40L)")]
        public const int WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)(0x88982F40));

        [NativeTypeName("#define WINCODEC_ERR_PROPERTYNOTSUPPORTED _HRESULT_TYPEDEF_(0x88982F41L)")]
        public const int WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)(0x88982F41));

        [NativeTypeName("#define WINCODEC_ERR_PROPERTYSIZE _HRESULT_TYPEDEF_(0x88982F42L)")]
        public const int WINCODEC_ERR_PROPERTYSIZE = unchecked((int)(0x88982F42));

        [NativeTypeName("#define WINCODEC_ERR_CODECPRESENT _HRESULT_TYPEDEF_(0x88982F43L)")]
        public const int WINCODEC_ERR_CODECPRESENT = unchecked((int)(0x88982F43));

        [NativeTypeName("#define WINCODEC_ERR_CODECNOTHUMBNAIL _HRESULT_TYPEDEF_(0x88982F44L)")]
        public const int WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)(0x88982F44));

        [NativeTypeName("#define WINCODEC_ERR_PALETTEUNAVAILABLE _HRESULT_TYPEDEF_(0x88982F45L)")]
        public const int WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)(0x88982F45));

        [NativeTypeName("#define WINCODEC_ERR_CODECTOOMANYSCANLINES _HRESULT_TYPEDEF_(0x88982F46L)")]
        public const int WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)(0x88982F46));

        [NativeTypeName("#define WINCODEC_ERR_INTERNALERROR _HRESULT_TYPEDEF_(0x88982F48L)")]
        public const int WINCODEC_ERR_INTERNALERROR = unchecked((int)(0x88982F48));

        [NativeTypeName("#define WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS _HRESULT_TYPEDEF_(0x88982F49L)")]
        public const int WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)(0x88982F49));

        [NativeTypeName("#define WINCODEC_ERR_COMPONENTNOTFOUND _HRESULT_TYPEDEF_(0x88982F50L)")]
        public const int WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)(0x88982F50));

        [NativeTypeName("#define WINCODEC_ERR_IMAGESIZEOUTOFRANGE _HRESULT_TYPEDEF_(0x88982F51L)")]
        public const int WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)(0x88982F51));

        [NativeTypeName("#define WINCODEC_ERR_TOOMUCHMETADATA _HRESULT_TYPEDEF_(0x88982F52L)")]
        public const int WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)(0x88982F52));

        [NativeTypeName("#define WINCODEC_ERR_BADIMAGE _HRESULT_TYPEDEF_(0x88982F60L)")]
        public const int WINCODEC_ERR_BADIMAGE = unchecked((int)(0x88982F60));

        [NativeTypeName("#define WINCODEC_ERR_BADHEADER _HRESULT_TYPEDEF_(0x88982F61L)")]
        public const int WINCODEC_ERR_BADHEADER = unchecked((int)(0x88982F61));

        [NativeTypeName("#define WINCODEC_ERR_FRAMEMISSING _HRESULT_TYPEDEF_(0x88982F62L)")]
        public const int WINCODEC_ERR_FRAMEMISSING = unchecked((int)(0x88982F62));

        [NativeTypeName("#define WINCODEC_ERR_BADMETADATAHEADER _HRESULT_TYPEDEF_(0x88982F63L)")]
        public const int WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)(0x88982F63));

        [NativeTypeName("#define WINCODEC_ERR_BADSTREAMDATA _HRESULT_TYPEDEF_(0x88982F70L)")]
        public const int WINCODEC_ERR_BADSTREAMDATA = unchecked((int)(0x88982F70));

        [NativeTypeName("#define WINCODEC_ERR_STREAMWRITE _HRESULT_TYPEDEF_(0x88982F71L)")]
        public const int WINCODEC_ERR_STREAMWRITE = unchecked((int)(0x88982F71));

        [NativeTypeName("#define WINCODEC_ERR_STREAMREAD _HRESULT_TYPEDEF_(0x88982F72L)")]
        public const int WINCODEC_ERR_STREAMREAD = unchecked((int)(0x88982F72));

        [NativeTypeName("#define WINCODEC_ERR_STREAMNOTAVAILABLE _HRESULT_TYPEDEF_(0x88982F73L)")]
        public const int WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)(0x88982F73));

        [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT _HRESULT_TYPEDEF_(0x88982F80L)")]
        public const int WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)(0x88982F80));

        [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDOPERATION _HRESULT_TYPEDEF_(0x88982F81L)")]
        public const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)(0x88982F81));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDREGISTRATION _HRESULT_TYPEDEF_(0x88982F8AL)")]
        public const int WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)(0x88982F8A));

        [NativeTypeName("#define WINCODEC_ERR_COMPONENTINITIALIZEFAILURE _HRESULT_TYPEDEF_(0x88982F8BL)")]
        public const int WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)(0x88982F8B));

        [NativeTypeName("#define WINCODEC_ERR_INSUFFICIENTBUFFER _HRESULT_TYPEDEF_(0x88982F8CL)")]
        public const int WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)(0x88982F8C));

        [NativeTypeName("#define WINCODEC_ERR_DUPLICATEMETADATAPRESENT _HRESULT_TYPEDEF_(0x88982F8DL)")]
        public const int WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)(0x88982F8D));

        [NativeTypeName("#define WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE _HRESULT_TYPEDEF_(0x88982F8EL)")]
        public const int WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)(0x88982F8E));

        [NativeTypeName("#define WINCODEC_ERR_UNEXPECTEDSIZE _HRESULT_TYPEDEF_(0x88982F8FL)")]
        public const int WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)(0x88982F8F));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDQUERYREQUEST _HRESULT_TYPEDEF_(0x88982F90L)")]
        public const int WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)(0x88982F90));

        [NativeTypeName("#define WINCODEC_ERR_UNEXPECTEDMETADATATYPE _HRESULT_TYPEDEF_(0x88982F91L)")]
        public const int WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)(0x88982F91));

        [NativeTypeName("#define WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT _HRESULT_TYPEDEF_(0x88982F92L)")]
        public const int WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)(0x88982F92));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDQUERYCHARACTER _HRESULT_TYPEDEF_(0x88982F93L)")]
        public const int WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)(0x88982F93));

        [NativeTypeName("#define WINCODEC_ERR_WIN32ERROR _HRESULT_TYPEDEF_(0x88982F94L)")]
        public const int WINCODEC_ERR_WIN32ERROR = unchecked((int)(0x88982F94));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDPROGRESSIVELEVEL _HRESULT_TYPEDEF_(0x88982F95L)")]
        public const int WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)(0x88982F95));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDJPEGSCANINDEX _HRESULT_TYPEDEF_(0x88982F96L)")]
        public const int WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)(0x88982F96));

        [NativeTypeName("#define MILERR_OBJECTBUSY _HRESULT_TYPEDEF_(0x88980001L)")]
        public const int MILERR_OBJECTBUSY = unchecked((int)(0x88980001));

        [NativeTypeName("#define MILERR_INSUFFICIENTBUFFER _HRESULT_TYPEDEF_(0x88980002L)")]
        public const int MILERR_INSUFFICIENTBUFFER = unchecked((int)(0x88980002));

        [NativeTypeName("#define MILERR_WIN32ERROR _HRESULT_TYPEDEF_(0x88980003L)")]
        public const int MILERR_WIN32ERROR = unchecked((int)(0x88980003));

        [NativeTypeName("#define MILERR_SCANNER_FAILED _HRESULT_TYPEDEF_(0x88980004L)")]
        public const int MILERR_SCANNER_FAILED = unchecked((int)(0x88980004));

        [NativeTypeName("#define MILERR_SCREENACCESSDENIED _HRESULT_TYPEDEF_(0x88980005L)")]
        public const int MILERR_SCREENACCESSDENIED = unchecked((int)(0x88980005));

        [NativeTypeName("#define MILERR_DISPLAYSTATEINVALID _HRESULT_TYPEDEF_(0x88980006L)")]
        public const int MILERR_DISPLAYSTATEINVALID = unchecked((int)(0x88980006));

        [NativeTypeName("#define MILERR_NONINVERTIBLEMATRIX _HRESULT_TYPEDEF_(0x88980007L)")]
        public const int MILERR_NONINVERTIBLEMATRIX = unchecked((int)(0x88980007));

        [NativeTypeName("#define MILERR_ZEROVECTOR _HRESULT_TYPEDEF_(0x88980008L)")]
        public const int MILERR_ZEROVECTOR = unchecked((int)(0x88980008));

        [NativeTypeName("#define MILERR_TERMINATED _HRESULT_TYPEDEF_(0x88980009L)")]
        public const int MILERR_TERMINATED = unchecked((int)(0x88980009));

        [NativeTypeName("#define MILERR_BADNUMBER _HRESULT_TYPEDEF_(0x8898000AL)")]
        public const int MILERR_BADNUMBER = unchecked((int)(0x8898000A));

        [NativeTypeName("#define MILERR_INTERNALERROR _HRESULT_TYPEDEF_(0x88980080L)")]
        public const int MILERR_INTERNALERROR = unchecked((int)(0x88980080));

        [NativeTypeName("#define MILERR_DISPLAYFORMATNOTSUPPORTED _HRESULT_TYPEDEF_(0x88980084L)")]
        public const int MILERR_DISPLAYFORMATNOTSUPPORTED = unchecked((int)(0x88980084));

        [NativeTypeName("#define MILERR_INVALIDCALL _HRESULT_TYPEDEF_(0x88980085L)")]
        public const int MILERR_INVALIDCALL = unchecked((int)(0x88980085));

        [NativeTypeName("#define MILERR_ALREADYLOCKED _HRESULT_TYPEDEF_(0x88980086L)")]
        public const int MILERR_ALREADYLOCKED = unchecked((int)(0x88980086));

        [NativeTypeName("#define MILERR_NOTLOCKED _HRESULT_TYPEDEF_(0x88980087L)")]
        public const int MILERR_NOTLOCKED = unchecked((int)(0x88980087));

        [NativeTypeName("#define MILERR_DEVICECANNOTRENDERTEXT _HRESULT_TYPEDEF_(0x88980088L)")]
        public const int MILERR_DEVICECANNOTRENDERTEXT = unchecked((int)(0x88980088));

        [NativeTypeName("#define MILERR_GLYPHBITMAPMISSED _HRESULT_TYPEDEF_(0x88980089L)")]
        public const int MILERR_GLYPHBITMAPMISSED = unchecked((int)(0x88980089));

        [NativeTypeName("#define MILERR_MALFORMEDGLYPHCACHE _HRESULT_TYPEDEF_(0x8898008AL)")]
        public const int MILERR_MALFORMEDGLYPHCACHE = unchecked((int)(0x8898008A));

        [NativeTypeName("#define MILERR_GENERIC_IGNORE _HRESULT_TYPEDEF_(0x8898008BL)")]
        public const int MILERR_GENERIC_IGNORE = unchecked((int)(0x8898008B));

        [NativeTypeName("#define MILERR_MALFORMED_GUIDELINE_DATA _HRESULT_TYPEDEF_(0x8898008CL)")]
        public const int MILERR_MALFORMED_GUIDELINE_DATA = unchecked((int)(0x8898008C));

        [NativeTypeName("#define MILERR_NO_HARDWARE_DEVICE _HRESULT_TYPEDEF_(0x8898008DL)")]
        public const int MILERR_NO_HARDWARE_DEVICE = unchecked((int)(0x8898008D));

        [NativeTypeName("#define MILERR_NEED_RECREATE_AND_PRESENT _HRESULT_TYPEDEF_(0x8898008EL)")]
        public const int MILERR_NEED_RECREATE_AND_PRESENT = unchecked((int)(0x8898008E));

        [NativeTypeName("#define MILERR_ALREADY_INITIALIZED _HRESULT_TYPEDEF_(0x8898008FL)")]
        public const int MILERR_ALREADY_INITIALIZED = unchecked((int)(0x8898008F));

        [NativeTypeName("#define MILERR_MISMATCHED_SIZE _HRESULT_TYPEDEF_(0x88980090L)")]
        public const int MILERR_MISMATCHED_SIZE = unchecked((int)(0x88980090));

        [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_AVAILABLE _HRESULT_TYPEDEF_(0x88980091L)")]
        public const int MILERR_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)(0x88980091));

        [NativeTypeName("#define MILERR_REMOTING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980092L)")]
        public const int MILERR_REMOTING_NOT_SUPPORTED = unchecked((int)(0x88980092));

        [NativeTypeName("#define MILERR_QUEUED_PRESENT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980093L)")]
        public const int MILERR_QUEUED_PRESENT_NOT_SUPPORTED = unchecked((int)(0x88980093));

        [NativeTypeName("#define MILERR_NOT_QUEUING_PRESENTS _HRESULT_TYPEDEF_(0x88980094L)")]
        public const int MILERR_NOT_QUEUING_PRESENTS = unchecked((int)(0x88980094));

        [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER _HRESULT_TYPEDEF_(0x88980095L)")]
        public const int MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER = unchecked((int)(0x88980095));

        [NativeTypeName("#define MILERR_TOOMANYSHADERELEMNTS _HRESULT_TYPEDEF_(0x88980096L)")]
        public const int MILERR_TOOMANYSHADERELEMNTS = unchecked((int)(0x88980096));

        [NativeTypeName("#define MILERR_MROW_READLOCK_FAILED _HRESULT_TYPEDEF_(0x88980097L)")]
        public const int MILERR_MROW_READLOCK_FAILED = unchecked((int)(0x88980097));

        [NativeTypeName("#define MILERR_MROW_UPDATE_FAILED _HRESULT_TYPEDEF_(0x88980098L)")]
        public const int MILERR_MROW_UPDATE_FAILED = unchecked((int)(0x88980098));

        [NativeTypeName("#define MILERR_SHADER_COMPILE_FAILED _HRESULT_TYPEDEF_(0x88980099L)")]
        public const int MILERR_SHADER_COMPILE_FAILED = unchecked((int)(0x88980099));

        [NativeTypeName("#define MILERR_MAX_TEXTURE_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x8898009AL)")]
        public const int MILERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)(0x8898009A));

        [NativeTypeName("#define MILERR_QPC_TIME_WENT_BACKWARD _HRESULT_TYPEDEF_(0x8898009BL)")]
        public const int MILERR_QPC_TIME_WENT_BACKWARD = unchecked((int)(0x8898009B));

        [NativeTypeName("#define MILERR_DXGI_ENUMERATION_OUT_OF_SYNC _HRESULT_TYPEDEF_(0x8898009DL)")]
        public const int MILERR_DXGI_ENUMERATION_OUT_OF_SYNC = unchecked((int)(0x8898009D));

        [NativeTypeName("#define MILERR_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x8898009EL)")]
        public const int MILERR_ADAPTER_NOT_FOUND = unchecked((int)(0x8898009E));

        [NativeTypeName("#define MILERR_COLORSPACE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8898009FL)")]
        public const int MILERR_COLORSPACE_NOT_SUPPORTED = unchecked((int)(0x8898009F));

        [NativeTypeName("#define MILERR_PREFILTER_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x889800A0L)")]
        public const int MILERR_PREFILTER_NOT_SUPPORTED = unchecked((int)(0x889800A0));

        [NativeTypeName("#define MILERR_DISPLAYID_ACCESS_DENIED _HRESULT_TYPEDEF_(0x889800A1L)")]
        public const int MILERR_DISPLAYID_ACCESS_DENIED = unchecked((int)(0x889800A1));

        [NativeTypeName("#define UCEERR_INVALIDPACKETHEADER _HRESULT_TYPEDEF_(0x88980400L)")]
        public const int UCEERR_INVALIDPACKETHEADER = unchecked((int)(0x88980400));

        [NativeTypeName("#define UCEERR_UNKNOWNPACKET _HRESULT_TYPEDEF_(0x88980401L)")]
        public const int UCEERR_UNKNOWNPACKET = unchecked((int)(0x88980401));

        [NativeTypeName("#define UCEERR_ILLEGALPACKET _HRESULT_TYPEDEF_(0x88980402L)")]
        public const int UCEERR_ILLEGALPACKET = unchecked((int)(0x88980402));

        [NativeTypeName("#define UCEERR_MALFORMEDPACKET _HRESULT_TYPEDEF_(0x88980403L)")]
        public const int UCEERR_MALFORMEDPACKET = unchecked((int)(0x88980403));

        [NativeTypeName("#define UCEERR_ILLEGALHANDLE _HRESULT_TYPEDEF_(0x88980404L)")]
        public const int UCEERR_ILLEGALHANDLE = unchecked((int)(0x88980404));

        [NativeTypeName("#define UCEERR_HANDLELOOKUPFAILED _HRESULT_TYPEDEF_(0x88980405L)")]
        public const int UCEERR_HANDLELOOKUPFAILED = unchecked((int)(0x88980405));

        [NativeTypeName("#define UCEERR_RENDERTHREADFAILURE _HRESULT_TYPEDEF_(0x88980406L)")]
        public const int UCEERR_RENDERTHREADFAILURE = unchecked((int)(0x88980406));

        [NativeTypeName("#define UCEERR_CTXSTACKFRSTTARGETNULL _HRESULT_TYPEDEF_(0x88980407L)")]
        public const int UCEERR_CTXSTACKFRSTTARGETNULL = unchecked((int)(0x88980407));

        [NativeTypeName("#define UCEERR_CONNECTIONIDLOOKUPFAILED _HRESULT_TYPEDEF_(0x88980408L)")]
        public const int UCEERR_CONNECTIONIDLOOKUPFAILED = unchecked((int)(0x88980408));

        [NativeTypeName("#define UCEERR_BLOCKSFULL _HRESULT_TYPEDEF_(0x88980409L)")]
        public const int UCEERR_BLOCKSFULL = unchecked((int)(0x88980409));

        [NativeTypeName("#define UCEERR_MEMORYFAILURE _HRESULT_TYPEDEF_(0x8898040AL)")]
        public const int UCEERR_MEMORYFAILURE = unchecked((int)(0x8898040A));

        [NativeTypeName("#define UCEERR_PACKETRECORDOUTOFRANGE _HRESULT_TYPEDEF_(0x8898040BL)")]
        public const int UCEERR_PACKETRECORDOUTOFRANGE = unchecked((int)(0x8898040B));

        [NativeTypeName("#define UCEERR_ILLEGALRECORDTYPE _HRESULT_TYPEDEF_(0x8898040CL)")]
        public const int UCEERR_ILLEGALRECORDTYPE = unchecked((int)(0x8898040C));

        [NativeTypeName("#define UCEERR_OUTOFHANDLES _HRESULT_TYPEDEF_(0x8898040DL)")]
        public const int UCEERR_OUTOFHANDLES = unchecked((int)(0x8898040D));

        [NativeTypeName("#define UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED _HRESULT_TYPEDEF_(0x8898040EL)")]
        public const int UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED = unchecked((int)(0x8898040E));

        [NativeTypeName("#define UCEERR_NO_MULTIPLE_WORKER_THREADS _HRESULT_TYPEDEF_(0x8898040FL)")]
        public const int UCEERR_NO_MULTIPLE_WORKER_THREADS = unchecked((int)(0x8898040F));

        [NativeTypeName("#define UCEERR_REMOTINGNOTSUPPORTED _HRESULT_TYPEDEF_(0x88980410L)")]
        public const int UCEERR_REMOTINGNOTSUPPORTED = unchecked((int)(0x88980410));

        [NativeTypeName("#define UCEERR_MISSINGENDCOMMAND _HRESULT_TYPEDEF_(0x88980411L)")]
        public const int UCEERR_MISSINGENDCOMMAND = unchecked((int)(0x88980411));

        [NativeTypeName("#define UCEERR_MISSINGBEGINCOMMAND _HRESULT_TYPEDEF_(0x88980412L)")]
        public const int UCEERR_MISSINGBEGINCOMMAND = unchecked((int)(0x88980412));

        [NativeTypeName("#define UCEERR_CHANNELSYNCTIMEDOUT _HRESULT_TYPEDEF_(0x88980413L)")]
        public const int UCEERR_CHANNELSYNCTIMEDOUT = unchecked((int)(0x88980413));

        [NativeTypeName("#define UCEERR_CHANNELSYNCABANDONED _HRESULT_TYPEDEF_(0x88980414L)")]
        public const int UCEERR_CHANNELSYNCABANDONED = unchecked((int)(0x88980414));

        [NativeTypeName("#define UCEERR_UNSUPPORTEDTRANSPORTVERSION _HRESULT_TYPEDEF_(0x88980415L)")]
        public const int UCEERR_UNSUPPORTEDTRANSPORTVERSION = unchecked((int)(0x88980415));

        [NativeTypeName("#define UCEERR_TRANSPORTUNAVAILABLE _HRESULT_TYPEDEF_(0x88980416L)")]
        public const int UCEERR_TRANSPORTUNAVAILABLE = unchecked((int)(0x88980416));

        [NativeTypeName("#define UCEERR_FEEDBACK_UNSUPPORTED _HRESULT_TYPEDEF_(0x88980417L)")]
        public const int UCEERR_FEEDBACK_UNSUPPORTED = unchecked((int)(0x88980417));

        [NativeTypeName("#define UCEERR_COMMANDTRANSPORTDENIED _HRESULT_TYPEDEF_(0x88980418L)")]
        public const int UCEERR_COMMANDTRANSPORTDENIED = unchecked((int)(0x88980418));

        [NativeTypeName("#define UCEERR_GRAPHICSSTREAMUNAVAILABLE _HRESULT_TYPEDEF_(0x88980419L)")]
        public const int UCEERR_GRAPHICSSTREAMUNAVAILABLE = unchecked((int)(0x88980419));

        [NativeTypeName("#define UCEERR_GRAPHICSSTREAMALREADYOPEN _HRESULT_TYPEDEF_(0x88980420L)")]
        public const int UCEERR_GRAPHICSSTREAMALREADYOPEN = unchecked((int)(0x88980420));

        [NativeTypeName("#define UCEERR_TRANSPORTDISCONNECTED _HRESULT_TYPEDEF_(0x88980421L)")]
        public const int UCEERR_TRANSPORTDISCONNECTED = unchecked((int)(0x88980421));

        [NativeTypeName("#define UCEERR_TRANSPORTOVERLOADED _HRESULT_TYPEDEF_(0x88980422L)")]
        public const int UCEERR_TRANSPORTOVERLOADED = unchecked((int)(0x88980422));

        [NativeTypeName("#define UCEERR_PARTITION_ZOMBIED _HRESULT_TYPEDEF_(0x88980423L)")]
        public const int UCEERR_PARTITION_ZOMBIED = unchecked((int)(0x88980423));

        [NativeTypeName("#define MILAVERR_NOCLOCK _HRESULT_TYPEDEF_(0x88980500L)")]
        public const int MILAVERR_NOCLOCK = unchecked((int)(0x88980500));

        [NativeTypeName("#define MILAVERR_NOMEDIATYPE _HRESULT_TYPEDEF_(0x88980501L)")]
        public const int MILAVERR_NOMEDIATYPE = unchecked((int)(0x88980501));

        [NativeTypeName("#define MILAVERR_NOVIDEOMIXER _HRESULT_TYPEDEF_(0x88980502L)")]
        public const int MILAVERR_NOVIDEOMIXER = unchecked((int)(0x88980502));

        [NativeTypeName("#define MILAVERR_NOVIDEOPRESENTER _HRESULT_TYPEDEF_(0x88980503L)")]
        public const int MILAVERR_NOVIDEOPRESENTER = unchecked((int)(0x88980503));

        [NativeTypeName("#define MILAVERR_NOREADYFRAMES _HRESULT_TYPEDEF_(0x88980504L)")]
        public const int MILAVERR_NOREADYFRAMES = unchecked((int)(0x88980504));

        [NativeTypeName("#define MILAVERR_MODULENOTLOADED _HRESULT_TYPEDEF_(0x88980505L)")]
        public const int MILAVERR_MODULENOTLOADED = unchecked((int)(0x88980505));

        [NativeTypeName("#define MILAVERR_WMPFACTORYNOTREGISTERED _HRESULT_TYPEDEF_(0x88980506L)")]
        public const int MILAVERR_WMPFACTORYNOTREGISTERED = unchecked((int)(0x88980506));

        [NativeTypeName("#define MILAVERR_INVALIDWMPVERSION _HRESULT_TYPEDEF_(0x88980507L)")]
        public const int MILAVERR_INVALIDWMPVERSION = unchecked((int)(0x88980507));

        [NativeTypeName("#define MILAVERR_INSUFFICIENTVIDEORESOURCES _HRESULT_TYPEDEF_(0x88980508L)")]
        public const int MILAVERR_INSUFFICIENTVIDEORESOURCES = unchecked((int)(0x88980508));

        [NativeTypeName("#define MILAVERR_VIDEOACCELERATIONNOTAVAILABLE _HRESULT_TYPEDEF_(0x88980509L)")]
        public const int MILAVERR_VIDEOACCELERATIONNOTAVAILABLE = unchecked((int)(0x88980509));

        [NativeTypeName("#define MILAVERR_REQUESTEDTEXTURETOOBIG _HRESULT_TYPEDEF_(0x8898050AL)")]
        public const int MILAVERR_REQUESTEDTEXTURETOOBIG = unchecked((int)(0x8898050A));

        [NativeTypeName("#define MILAVERR_SEEKFAILED _HRESULT_TYPEDEF_(0x8898050BL)")]
        public const int MILAVERR_SEEKFAILED = unchecked((int)(0x8898050B));

        [NativeTypeName("#define MILAVERR_UNEXPECTEDWMPFAILURE _HRESULT_TYPEDEF_(0x8898050CL)")]
        public const int MILAVERR_UNEXPECTEDWMPFAILURE = unchecked((int)(0x8898050C));

        [NativeTypeName("#define MILAVERR_MEDIAPLAYERCLOSED _HRESULT_TYPEDEF_(0x8898050DL)")]
        public const int MILAVERR_MEDIAPLAYERCLOSED = unchecked((int)(0x8898050D));

        [NativeTypeName("#define MILAVERR_UNKNOWNHARDWAREERROR _HRESULT_TYPEDEF_(0x8898050EL)")]
        public const int MILAVERR_UNKNOWNHARDWAREERROR = unchecked((int)(0x8898050E));

        [NativeTypeName("#define MILEFFECTSERR_UNKNOWNPROPERTY _HRESULT_TYPEDEF_(0x8898060EL)")]
        public const int MILEFFECTSERR_UNKNOWNPROPERTY = unchecked((int)(0x8898060E));

        [NativeTypeName("#define MILEFFECTSERR_EFFECTNOTPARTOFGROUP _HRESULT_TYPEDEF_(0x8898060FL)")]
        public const int MILEFFECTSERR_EFFECTNOTPARTOFGROUP = unchecked((int)(0x8898060F));

        [NativeTypeName("#define MILEFFECTSERR_NOINPUTSOURCEATTACHED _HRESULT_TYPEDEF_(0x88980610L)")]
        public const int MILEFFECTSERR_NOINPUTSOURCEATTACHED = unchecked((int)(0x88980610));

        [NativeTypeName("#define MILEFFECTSERR_CONNECTORNOTCONNECTED _HRESULT_TYPEDEF_(0x88980611L)")]
        public const int MILEFFECTSERR_CONNECTORNOTCONNECTED = unchecked((int)(0x88980611));

        [NativeTypeName("#define MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT _HRESULT_TYPEDEF_(0x88980612L)")]
        public const int MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT = unchecked((int)(0x88980612));

        [NativeTypeName("#define MILEFFECTSERR_RESERVED _HRESULT_TYPEDEF_(0x88980613L)")]
        public const int MILEFFECTSERR_RESERVED = unchecked((int)(0x88980613));

        [NativeTypeName("#define MILEFFECTSERR_CYCLEDETECTED _HRESULT_TYPEDEF_(0x88980614L)")]
        public const int MILEFFECTSERR_CYCLEDETECTED = unchecked((int)(0x88980614));

        [NativeTypeName("#define MILEFFECTSERR_EFFECTINMORETHANONEGRAPH _HRESULT_TYPEDEF_(0x88980615L)")]
        public const int MILEFFECTSERR_EFFECTINMORETHANONEGRAPH = unchecked((int)(0x88980615));

        [NativeTypeName("#define MILEFFECTSERR_EFFECTALREADYINAGRAPH _HRESULT_TYPEDEF_(0x88980616L)")]
        public const int MILEFFECTSERR_EFFECTALREADYINAGRAPH = unchecked((int)(0x88980616));

        [NativeTypeName("#define MILEFFECTSERR_EFFECTHASNOCHILDREN _HRESULT_TYPEDEF_(0x88980617L)")]
        public const int MILEFFECTSERR_EFFECTHASNOCHILDREN = unchecked((int)(0x88980617));

        [NativeTypeName("#define MILEFFECTSERR_ALREADYATTACHEDTOLISTENER _HRESULT_TYPEDEF_(0x88980618L)")]
        public const int MILEFFECTSERR_ALREADYATTACHEDTOLISTENER = unchecked((int)(0x88980618));

        [NativeTypeName("#define MILEFFECTSERR_NOTAFFINETRANSFORM _HRESULT_TYPEDEF_(0x88980619L)")]
        public const int MILEFFECTSERR_NOTAFFINETRANSFORM = unchecked((int)(0x88980619));

        [NativeTypeName("#define MILEFFECTSERR_EMPTYBOUNDS _HRESULT_TYPEDEF_(0x8898061AL)")]
        public const int MILEFFECTSERR_EMPTYBOUNDS = unchecked((int)(0x8898061A));

        [NativeTypeName("#define MILEFFECTSERR_OUTPUTSIZETOOLARGE _HRESULT_TYPEDEF_(0x8898061BL)")]
        public const int MILEFFECTSERR_OUTPUTSIZETOOLARGE = unchecked((int)(0x8898061B));

        [NativeTypeName("#define DWMERR_STATE_TRANSITION_FAILED _HRESULT_TYPEDEF_(0x88980700L)")]
        public const int DWMERR_STATE_TRANSITION_FAILED = unchecked((int)(0x88980700));

        [NativeTypeName("#define DWMERR_THEME_FAILED _HRESULT_TYPEDEF_(0x88980701L)")]
        public const int DWMERR_THEME_FAILED = unchecked((int)(0x88980701));

        [NativeTypeName("#define DWMERR_CATASTROPHIC_FAILURE _HRESULT_TYPEDEF_(0x88980702L)")]
        public const int DWMERR_CATASTROPHIC_FAILURE = unchecked((int)(0x88980702));

        [NativeTypeName("#define DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED _HRESULT_TYPEDEF_(0x88980800L)")]
        public const int DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED = unchecked((int)(0x88980800));

        [NativeTypeName("#define DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED _HRESULT_TYPEDEF_(0x88980801L)")]
        public const int DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED = unchecked((int)(0x88980801));

        [NativeTypeName("#define DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED _HRESULT_TYPEDEF_(0x88980802L)")]
        public const int DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED = unchecked((int)(0x88980802));

        [NativeTypeName("#define ONL_E_INVALID_AUTHENTICATION_TARGET _HRESULT_TYPEDEF_(0x80860001L)")]
        public const int ONL_E_INVALID_AUTHENTICATION_TARGET = unchecked((int)(0x80860001));

        [NativeTypeName("#define ONL_E_ACCESS_DENIED_BY_TOU _HRESULT_TYPEDEF_(0x80860002L)")]
        public const int ONL_E_ACCESS_DENIED_BY_TOU = unchecked((int)(0x80860002));

        [NativeTypeName("#define ONL_E_INVALID_APPLICATION _HRESULT_TYPEDEF_(0x80860003L)")]
        public const int ONL_E_INVALID_APPLICATION = unchecked((int)(0x80860003));

        [NativeTypeName("#define ONL_E_PASSWORD_UPDATE_REQUIRED _HRESULT_TYPEDEF_(0x80860004L)")]
        public const int ONL_E_PASSWORD_UPDATE_REQUIRED = unchecked((int)(0x80860004));

        [NativeTypeName("#define ONL_E_ACCOUNT_UPDATE_REQUIRED _HRESULT_TYPEDEF_(0x80860005L)")]
        public const int ONL_E_ACCOUNT_UPDATE_REQUIRED = unchecked((int)(0x80860005));

        [NativeTypeName("#define ONL_E_FORCESIGNIN _HRESULT_TYPEDEF_(0x80860006L)")]
        public const int ONL_E_FORCESIGNIN = unchecked((int)(0x80860006));

        [NativeTypeName("#define ONL_E_ACCOUNT_LOCKED _HRESULT_TYPEDEF_(0x80860007L)")]
        public const int ONL_E_ACCOUNT_LOCKED = unchecked((int)(0x80860007));

        [NativeTypeName("#define ONL_E_PARENTAL_CONSENT_REQUIRED _HRESULT_TYPEDEF_(0x80860008L)")]
        public const int ONL_E_PARENTAL_CONSENT_REQUIRED = unchecked((int)(0x80860008));

        [NativeTypeName("#define ONL_E_EMAIL_VERIFICATION_REQUIRED _HRESULT_TYPEDEF_(0x80860009L)")]
        public const int ONL_E_EMAIL_VERIFICATION_REQUIRED = unchecked((int)(0x80860009));

        [NativeTypeName("#define ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE _HRESULT_TYPEDEF_(0x8086000AL)")]
        public const int ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE = unchecked((int)(0x8086000A));

        [NativeTypeName("#define ONL_E_ACCOUNT_SUSPENDED_ABUSE _HRESULT_TYPEDEF_(0x8086000BL)")]
        public const int ONL_E_ACCOUNT_SUSPENDED_ABUSE = unchecked((int)(0x8086000B));

        [NativeTypeName("#define ONL_E_ACTION_REQUIRED _HRESULT_TYPEDEF_(0x8086000CL)")]
        public const int ONL_E_ACTION_REQUIRED = unchecked((int)(0x8086000C));

        [NativeTypeName("#define ONL_CONNECTION_COUNT_LIMIT _HRESULT_TYPEDEF_(0x8086000DL)")]
        public const int ONL_CONNECTION_COUNT_LIMIT = unchecked((int)(0x8086000D));

        [NativeTypeName("#define ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT _HRESULT_TYPEDEF_(0x8086000EL)")]
        public const int ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT = unchecked((int)(0x8086000E));

        [NativeTypeName("#define ONL_E_USER_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x8086000FL)")]
        public const int ONL_E_USER_AUTHENTICATION_REQUIRED = unchecked((int)(0x8086000F));

        [NativeTypeName("#define ONL_E_REQUEST_THROTTLED _HRESULT_TYPEDEF_(0x80860010L)")]
        public const int ONL_E_REQUEST_THROTTLED = unchecked((int)(0x80860010));

        [NativeTypeName("#define FA_E_MAX_PERSISTED_ITEMS_REACHED _HRESULT_TYPEDEF_(0x80270220L)")]
        public const int FA_E_MAX_PERSISTED_ITEMS_REACHED = unchecked((int)(0x80270220));

        [NativeTypeName("#define FA_E_HOMEGROUP_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80270222L)")]
        public const int FA_E_HOMEGROUP_NOT_AVAILABLE = unchecked((int)(0x80270222));

        [NativeTypeName("#define S_STORE_LAUNCHED_FOR_REMEDIATION _HRESULT_TYPEDEF_(0x00270258L)")]
        public const int S_STORE_LAUNCHED_FOR_REMEDIATION = ((int)(0x00270258));

        [NativeTypeName("#define S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG _HRESULT_TYPEDEF_(0x00270259L)")]
        public const int S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG = ((int)(0x00270259));

        [NativeTypeName("#define EAS_E_POLICY_NOT_MANAGED_BY_OS _HRESULT_TYPEDEF_(0x80550001L)")]
        public const int EAS_E_POLICY_NOT_MANAGED_BY_OS = unchecked((int)(0x80550001));

        [NativeTypeName("#define EAS_E_POLICY_COMPLIANT_WITH_ACTIONS _HRESULT_TYPEDEF_(0x80550002L)")]
        public const int EAS_E_POLICY_COMPLIANT_WITH_ACTIONS = unchecked((int)(0x80550002));

        [NativeTypeName("#define EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE _HRESULT_TYPEDEF_(0x80550003L)")]
        public const int EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE = unchecked((int)(0x80550003));

        [NativeTypeName("#define EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD _HRESULT_TYPEDEF_(0x80550004L)")]
        public const int EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD = unchecked((int)(0x80550004));

        [NativeTypeName("#define EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE _HRESULT_TYPEDEF_(0x80550005L)")]
        public const int EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE = unchecked((int)(0x80550005));

        [NativeTypeName("#define EAS_E_USER_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550006L)")]
        public const int EAS_E_USER_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550006));

        [NativeTypeName("#define EAS_E_ADMINS_HAVE_BLANK_PASSWORD _HRESULT_TYPEDEF_(0x80550007L)")]
        public const int EAS_E_ADMINS_HAVE_BLANK_PASSWORD = unchecked((int)(0x80550007));

        [NativeTypeName("#define EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550008L)")]
        public const int EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550008));

        [NativeTypeName("#define EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550009L)")]
        public const int EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550009));

        [NativeTypeName("#define EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS _HRESULT_TYPEDEF_(0x8055000AL)")]
        public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS = unchecked((int)(0x8055000A));

        [NativeTypeName("#define EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x8055000BL)")]
        public const int EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD = unchecked((int)(0x8055000B));

        [NativeTypeName("#define EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER _HRESULT_TYPEDEF_(0x8055000CL)")]
        public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER = unchecked((int)(0x8055000C));

        [NativeTypeName("#define EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x8055000DL)")]
        public const int EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD = unchecked((int)(0x8055000D));

        [NativeTypeName("#define WEB_E_UNSUPPORTED_FORMAT _HRESULT_TYPEDEF_(0x83750001L)")]
        public const int WEB_E_UNSUPPORTED_FORMAT = unchecked((int)(0x83750001));

        [NativeTypeName("#define WEB_E_INVALID_XML _HRESULT_TYPEDEF_(0x83750002L)")]
        public const int WEB_E_INVALID_XML = unchecked((int)(0x83750002));

        [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ELEMENT _HRESULT_TYPEDEF_(0x83750003L)")]
        public const int WEB_E_MISSING_REQUIRED_ELEMENT = unchecked((int)(0x83750003));

        [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ATTRIBUTE _HRESULT_TYPEDEF_(0x83750004L)")]
        public const int WEB_E_MISSING_REQUIRED_ATTRIBUTE = unchecked((int)(0x83750004));

        [NativeTypeName("#define WEB_E_UNEXPECTED_CONTENT _HRESULT_TYPEDEF_(0x83750005L)")]
        public const int WEB_E_UNEXPECTED_CONTENT = unchecked((int)(0x83750005));

        [NativeTypeName("#define WEB_E_RESOURCE_TOO_LARGE _HRESULT_TYPEDEF_(0x83750006L)")]
        public const int WEB_E_RESOURCE_TOO_LARGE = unchecked((int)(0x83750006));

        [NativeTypeName("#define WEB_E_INVALID_JSON_STRING _HRESULT_TYPEDEF_(0x83750007L)")]
        public const int WEB_E_INVALID_JSON_STRING = unchecked((int)(0x83750007));

        [NativeTypeName("#define WEB_E_INVALID_JSON_NUMBER _HRESULT_TYPEDEF_(0x83750008L)")]
        public const int WEB_E_INVALID_JSON_NUMBER = unchecked((int)(0x83750008));

        [NativeTypeName("#define WEB_E_JSON_VALUE_NOT_FOUND _HRESULT_TYPEDEF_(0x83750009L)")]
        public const int WEB_E_JSON_VALUE_NOT_FOUND = unchecked((int)(0x83750009));

        [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED _HRESULT_TYPEDEF_(0x80190001L)")]
        public const int HTTP_E_STATUS_UNEXPECTED = unchecked((int)(0x80190001));

        [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_REDIRECTION _HRESULT_TYPEDEF_(0x80190003L)")]
        public const int HTTP_E_STATUS_UNEXPECTED_REDIRECTION = unchecked((int)(0x80190003));

        [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR _HRESULT_TYPEDEF_(0x80190004L)")]
        public const int HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = unchecked((int)(0x80190004));

        [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR _HRESULT_TYPEDEF_(0x80190005L)")]
        public const int HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = unchecked((int)(0x80190005));

        [NativeTypeName("#define HTTP_E_STATUS_AMBIGUOUS _HRESULT_TYPEDEF_(0x8019012CL)")]
        public const int HTTP_E_STATUS_AMBIGUOUS = unchecked((int)(0x8019012C));

        [NativeTypeName("#define HTTP_E_STATUS_MOVED _HRESULT_TYPEDEF_(0x8019012DL)")]
        public const int HTTP_E_STATUS_MOVED = unchecked((int)(0x8019012D));

        [NativeTypeName("#define HTTP_E_STATUS_REDIRECT _HRESULT_TYPEDEF_(0x8019012EL)")]
        public const int HTTP_E_STATUS_REDIRECT = unchecked((int)(0x8019012E));

        [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_METHOD _HRESULT_TYPEDEF_(0x8019012FL)")]
        public const int HTTP_E_STATUS_REDIRECT_METHOD = unchecked((int)(0x8019012F));

        [NativeTypeName("#define HTTP_E_STATUS_NOT_MODIFIED _HRESULT_TYPEDEF_(0x80190130L)")]
        public const int HTTP_E_STATUS_NOT_MODIFIED = unchecked((int)(0x80190130));

        [NativeTypeName("#define HTTP_E_STATUS_USE_PROXY _HRESULT_TYPEDEF_(0x80190131L)")]
        public const int HTTP_E_STATUS_USE_PROXY = unchecked((int)(0x80190131));

        [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_KEEP_VERB _HRESULT_TYPEDEF_(0x80190133L)")]
        public const int HTTP_E_STATUS_REDIRECT_KEEP_VERB = unchecked((int)(0x80190133));

        [NativeTypeName("#define HTTP_E_STATUS_BAD_REQUEST _HRESULT_TYPEDEF_(0x80190190L)")]
        public const int HTTP_E_STATUS_BAD_REQUEST = unchecked((int)(0x80190190));

        [NativeTypeName("#define HTTP_E_STATUS_DENIED _HRESULT_TYPEDEF_(0x80190191L)")]
        public const int HTTP_E_STATUS_DENIED = unchecked((int)(0x80190191));

        [NativeTypeName("#define HTTP_E_STATUS_PAYMENT_REQ _HRESULT_TYPEDEF_(0x80190192L)")]
        public const int HTTP_E_STATUS_PAYMENT_REQ = unchecked((int)(0x80190192));

        [NativeTypeName("#define HTTP_E_STATUS_FORBIDDEN _HRESULT_TYPEDEF_(0x80190193L)")]
        public const int HTTP_E_STATUS_FORBIDDEN = unchecked((int)(0x80190193));

        [NativeTypeName("#define HTTP_E_STATUS_NOT_FOUND _HRESULT_TYPEDEF_(0x80190194L)")]
        public const int HTTP_E_STATUS_NOT_FOUND = unchecked((int)(0x80190194));

        [NativeTypeName("#define HTTP_E_STATUS_BAD_METHOD _HRESULT_TYPEDEF_(0x80190195L)")]
        public const int HTTP_E_STATUS_BAD_METHOD = unchecked((int)(0x80190195));

        [NativeTypeName("#define HTTP_E_STATUS_NONE_ACCEPTABLE _HRESULT_TYPEDEF_(0x80190196L)")]
        public const int HTTP_E_STATUS_NONE_ACCEPTABLE = unchecked((int)(0x80190196));

        [NativeTypeName("#define HTTP_E_STATUS_PROXY_AUTH_REQ _HRESULT_TYPEDEF_(0x80190197L)")]
        public const int HTTP_E_STATUS_PROXY_AUTH_REQ = unchecked((int)(0x80190197));

        [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TIMEOUT _HRESULT_TYPEDEF_(0x80190198L)")]
        public const int HTTP_E_STATUS_REQUEST_TIMEOUT = unchecked((int)(0x80190198));

        [NativeTypeName("#define HTTP_E_STATUS_CONFLICT _HRESULT_TYPEDEF_(0x80190199L)")]
        public const int HTTP_E_STATUS_CONFLICT = unchecked((int)(0x80190199));

        [NativeTypeName("#define HTTP_E_STATUS_GONE _HRESULT_TYPEDEF_(0x8019019AL)")]
        public const int HTTP_E_STATUS_GONE = unchecked((int)(0x8019019A));

        [NativeTypeName("#define HTTP_E_STATUS_LENGTH_REQUIRED _HRESULT_TYPEDEF_(0x8019019BL)")]
        public const int HTTP_E_STATUS_LENGTH_REQUIRED = unchecked((int)(0x8019019B));

        [NativeTypeName("#define HTTP_E_STATUS_PRECOND_FAILED _HRESULT_TYPEDEF_(0x8019019CL)")]
        public const int HTTP_E_STATUS_PRECOND_FAILED = unchecked((int)(0x8019019C));

        [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TOO_LARGE _HRESULT_TYPEDEF_(0x8019019DL)")]
        public const int HTTP_E_STATUS_REQUEST_TOO_LARGE = unchecked((int)(0x8019019D));

        [NativeTypeName("#define HTTP_E_STATUS_URI_TOO_LONG _HRESULT_TYPEDEF_(0x8019019EL)")]
        public const int HTTP_E_STATUS_URI_TOO_LONG = unchecked((int)(0x8019019E));

        [NativeTypeName("#define HTTP_E_STATUS_UNSUPPORTED_MEDIA _HRESULT_TYPEDEF_(0x8019019FL)")]
        public const int HTTP_E_STATUS_UNSUPPORTED_MEDIA = unchecked((int)(0x8019019F));

        [NativeTypeName("#define HTTP_E_STATUS_RANGE_NOT_SATISFIABLE _HRESULT_TYPEDEF_(0x801901A0L)")]
        public const int HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = unchecked((int)(0x801901A0));

        [NativeTypeName("#define HTTP_E_STATUS_EXPECTATION_FAILED _HRESULT_TYPEDEF_(0x801901A1L)")]
        public const int HTTP_E_STATUS_EXPECTATION_FAILED = unchecked((int)(0x801901A1));

        [NativeTypeName("#define HTTP_E_STATUS_SERVER_ERROR _HRESULT_TYPEDEF_(0x801901F4L)")]
        public const int HTTP_E_STATUS_SERVER_ERROR = unchecked((int)(0x801901F4));

        [NativeTypeName("#define HTTP_E_STATUS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x801901F5L)")]
        public const int HTTP_E_STATUS_NOT_SUPPORTED = unchecked((int)(0x801901F5));

        [NativeTypeName("#define HTTP_E_STATUS_BAD_GATEWAY _HRESULT_TYPEDEF_(0x801901F6L)")]
        public const int HTTP_E_STATUS_BAD_GATEWAY = unchecked((int)(0x801901F6));

        [NativeTypeName("#define HTTP_E_STATUS_SERVICE_UNAVAIL _HRESULT_TYPEDEF_(0x801901F7L)")]
        public const int HTTP_E_STATUS_SERVICE_UNAVAIL = unchecked((int)(0x801901F7));

        [NativeTypeName("#define HTTP_E_STATUS_GATEWAY_TIMEOUT _HRESULT_TYPEDEF_(0x801901F8L)")]
        public const int HTTP_E_STATUS_GATEWAY_TIMEOUT = unchecked((int)(0x801901F8));

        [NativeTypeName("#define HTTP_E_STATUS_VERSION_NOT_SUP _HRESULT_TYPEDEF_(0x801901F9L)")]
        public const int HTTP_E_STATUS_VERSION_NOT_SUP = unchecked((int)(0x801901F9));

        [NativeTypeName("#define INPUT_E_OUT_OF_ORDER _HRESULT_TYPEDEF_(0x80400000L)")]
        public const int INPUT_E_OUT_OF_ORDER = unchecked((int)(0x80400000));

        [NativeTypeName("#define INPUT_E_REENTRANCY _HRESULT_TYPEDEF_(0x80400001L)")]
        public const int INPUT_E_REENTRANCY = unchecked((int)(0x80400001));

        [NativeTypeName("#define INPUT_E_MULTIMODAL _HRESULT_TYPEDEF_(0x80400002L)")]
        public const int INPUT_E_MULTIMODAL = unchecked((int)(0x80400002));

        [NativeTypeName("#define INPUT_E_PACKET _HRESULT_TYPEDEF_(0x80400003L)")]
        public const int INPUT_E_PACKET = unchecked((int)(0x80400003));

        [NativeTypeName("#define INPUT_E_FRAME _HRESULT_TYPEDEF_(0x80400004L)")]
        public const int INPUT_E_FRAME = unchecked((int)(0x80400004));

        [NativeTypeName("#define INPUT_E_HISTORY _HRESULT_TYPEDEF_(0x80400005L)")]
        public const int INPUT_E_HISTORY = unchecked((int)(0x80400005));

        [NativeTypeName("#define INPUT_E_DEVICE_INFO _HRESULT_TYPEDEF_(0x80400006L)")]
        public const int INPUT_E_DEVICE_INFO = unchecked((int)(0x80400006));

        [NativeTypeName("#define INPUT_E_TRANSFORM _HRESULT_TYPEDEF_(0x80400007L)")]
        public const int INPUT_E_TRANSFORM = unchecked((int)(0x80400007));

        [NativeTypeName("#define INPUT_E_DEVICE_PROPERTY _HRESULT_TYPEDEF_(0x80400008L)")]
        public const int INPUT_E_DEVICE_PROPERTY = unchecked((int)(0x80400008));

        [NativeTypeName("#define JSCRIPT_E_CANTEXECUTE _HRESULT_TYPEDEF_(0x89020001L)")]
        public const int JSCRIPT_E_CANTEXECUTE = unchecked((int)(0x89020001));

        [NativeTypeName("#define WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES _HRESULT_TYPEDEF_(0x88010001L)")]
        public const int WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)(0x88010001));

        [NativeTypeName("#define WEP_E_FIXED_DATA_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88010002L)")]
        public const int WEP_E_FIXED_DATA_NOT_SUPPORTED = unchecked((int)(0x88010002));

        [NativeTypeName("#define WEP_E_HARDWARE_NOT_COMPLIANT _HRESULT_TYPEDEF_(0x88010003L)")]
        public const int WEP_E_HARDWARE_NOT_COMPLIANT = unchecked((int)(0x88010003));

        [NativeTypeName("#define WEP_E_LOCK_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x88010004L)")]
        public const int WEP_E_LOCK_NOT_CONFIGURED = unchecked((int)(0x88010004));

        [NativeTypeName("#define WEP_E_PROTECTION_SUSPENDED _HRESULT_TYPEDEF_(0x88010005L)")]
        public const int WEP_E_PROTECTION_SUSPENDED = unchecked((int)(0x88010005));

        [NativeTypeName("#define WEP_E_NO_LICENSE _HRESULT_TYPEDEF_(0x88010006L)")]
        public const int WEP_E_NO_LICENSE = unchecked((int)(0x88010006));

        [NativeTypeName("#define WEP_E_OS_NOT_PROTECTED _HRESULT_TYPEDEF_(0x88010007L)")]
        public const int WEP_E_OS_NOT_PROTECTED = unchecked((int)(0x88010007));

        [NativeTypeName("#define WEP_E_UNEXPECTED_FAIL _HRESULT_TYPEDEF_(0x88010008L)")]
        public const int WEP_E_UNEXPECTED_FAIL = unchecked((int)(0x88010008));

        [NativeTypeName("#define WEP_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x88010009L)")]
        public const int WEP_E_BUFFER_TOO_LARGE = unchecked((int)(0x88010009));

        [NativeTypeName("#define WININET_E_OUT_OF_HANDLES _HRESULT_TYPEDEF_(0x80072EE1L)")]
        public const int WININET_E_OUT_OF_HANDLES = unchecked((int)(0x80072EE1));

        [NativeTypeName("#define WININET_E_TIMEOUT _HRESULT_TYPEDEF_(0x80072EE2L)")]
        public const int WININET_E_TIMEOUT = unchecked((int)(0x80072EE2));

        [NativeTypeName("#define WININET_E_EXTENDED_ERROR _HRESULT_TYPEDEF_(0x80072EE3L)")]
        public const int WININET_E_EXTENDED_ERROR = unchecked((int)(0x80072EE3));

        [NativeTypeName("#define WININET_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80072EE4L)")]
        public const int WININET_E_INTERNAL_ERROR = unchecked((int)(0x80072EE4));

        [NativeTypeName("#define WININET_E_INVALID_URL _HRESULT_TYPEDEF_(0x80072EE5L)")]
        public const int WININET_E_INVALID_URL = unchecked((int)(0x80072EE5));

        [NativeTypeName("#define WININET_E_UNRECOGNIZED_SCHEME _HRESULT_TYPEDEF_(0x80072EE6L)")]
        public const int WININET_E_UNRECOGNIZED_SCHEME = unchecked((int)(0x80072EE6));

        [NativeTypeName("#define WININET_E_NAME_NOT_RESOLVED _HRESULT_TYPEDEF_(0x80072EE7L)")]
        public const int WININET_E_NAME_NOT_RESOLVED = unchecked((int)(0x80072EE7));

        [NativeTypeName("#define WININET_E_PROTOCOL_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EE8L)")]
        public const int WININET_E_PROTOCOL_NOT_FOUND = unchecked((int)(0x80072EE8));

        [NativeTypeName("#define WININET_E_INVALID_OPTION _HRESULT_TYPEDEF_(0x80072EE9L)")]
        public const int WININET_E_INVALID_OPTION = unchecked((int)(0x80072EE9));

        [NativeTypeName("#define WININET_E_BAD_OPTION_LENGTH _HRESULT_TYPEDEF_(0x80072EEAL)")]
        public const int WININET_E_BAD_OPTION_LENGTH = unchecked((int)(0x80072EEA));

        [NativeTypeName("#define WININET_E_OPTION_NOT_SETTABLE _HRESULT_TYPEDEF_(0x80072EEBL)")]
        public const int WININET_E_OPTION_NOT_SETTABLE = unchecked((int)(0x80072EEB));

        [NativeTypeName("#define WININET_E_SHUTDOWN _HRESULT_TYPEDEF_(0x80072EECL)")]
        public const int WININET_E_SHUTDOWN = unchecked((int)(0x80072EEC));

        [NativeTypeName("#define WININET_E_INCORRECT_USER_NAME _HRESULT_TYPEDEF_(0x80072EEDL)")]
        public const int WININET_E_INCORRECT_USER_NAME = unchecked((int)(0x80072EED));

        [NativeTypeName("#define WININET_E_INCORRECT_PASSWORD _HRESULT_TYPEDEF_(0x80072EEEL)")]
        public const int WININET_E_INCORRECT_PASSWORD = unchecked((int)(0x80072EEE));

        [NativeTypeName("#define WININET_E_LOGIN_FAILURE _HRESULT_TYPEDEF_(0x80072EEFL)")]
        public const int WININET_E_LOGIN_FAILURE = unchecked((int)(0x80072EEF));

        [NativeTypeName("#define WININET_E_INVALID_OPERATION _HRESULT_TYPEDEF_(0x80072EF0L)")]
        public const int WININET_E_INVALID_OPERATION = unchecked((int)(0x80072EF0));

        [NativeTypeName("#define WININET_E_OPERATION_CANCELLED _HRESULT_TYPEDEF_(0x80072EF1L)")]
        public const int WININET_E_OPERATION_CANCELLED = unchecked((int)(0x80072EF1));

        [NativeTypeName("#define WININET_E_INCORRECT_HANDLE_TYPE _HRESULT_TYPEDEF_(0x80072EF2L)")]
        public const int WININET_E_INCORRECT_HANDLE_TYPE = unchecked((int)(0x80072EF2));

        [NativeTypeName("#define WININET_E_INCORRECT_HANDLE_STATE _HRESULT_TYPEDEF_(0x80072EF3L)")]
        public const int WININET_E_INCORRECT_HANDLE_STATE = unchecked((int)(0x80072EF3));

        [NativeTypeName("#define WININET_E_NOT_PROXY_REQUEST _HRESULT_TYPEDEF_(0x80072EF4L)")]
        public const int WININET_E_NOT_PROXY_REQUEST = unchecked((int)(0x80072EF4));

        [NativeTypeName("#define WININET_E_REGISTRY_VALUE_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EF5L)")]
        public const int WININET_E_REGISTRY_VALUE_NOT_FOUND = unchecked((int)(0x80072EF5));

        [NativeTypeName("#define WININET_E_BAD_REGISTRY_PARAMETER _HRESULT_TYPEDEF_(0x80072EF6L)")]
        public const int WININET_E_BAD_REGISTRY_PARAMETER = unchecked((int)(0x80072EF6));

        [NativeTypeName("#define WININET_E_NO_DIRECT_ACCESS _HRESULT_TYPEDEF_(0x80072EF7L)")]
        public const int WININET_E_NO_DIRECT_ACCESS = unchecked((int)(0x80072EF7));

        [NativeTypeName("#define WININET_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x80072EF8L)")]
        public const int WININET_E_NO_CONTEXT = unchecked((int)(0x80072EF8));

        [NativeTypeName("#define WININET_E_NO_CALLBACK _HRESULT_TYPEDEF_(0x80072EF9L)")]
        public const int WININET_E_NO_CALLBACK = unchecked((int)(0x80072EF9));

        [NativeTypeName("#define WININET_E_REQUEST_PENDING _HRESULT_TYPEDEF_(0x80072EFAL)")]
        public const int WININET_E_REQUEST_PENDING = unchecked((int)(0x80072EFA));

        [NativeTypeName("#define WININET_E_INCORRECT_FORMAT _HRESULT_TYPEDEF_(0x80072EFBL)")]
        public const int WININET_E_INCORRECT_FORMAT = unchecked((int)(0x80072EFB));

        [NativeTypeName("#define WININET_E_ITEM_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EFCL)")]
        public const int WININET_E_ITEM_NOT_FOUND = unchecked((int)(0x80072EFC));

        [NativeTypeName("#define WININET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x80072EFDL)")]
        public const int WININET_E_CANNOT_CONNECT = unchecked((int)(0x80072EFD));

        [NativeTypeName("#define WININET_E_CONNECTION_ABORTED _HRESULT_TYPEDEF_(0x80072EFEL)")]
        public const int WININET_E_CONNECTION_ABORTED = unchecked((int)(0x80072EFE));

        [NativeTypeName("#define WININET_E_CONNECTION_RESET _HRESULT_TYPEDEF_(0x80072EFFL)")]
        public const int WININET_E_CONNECTION_RESET = unchecked((int)(0x80072EFF));

        [NativeTypeName("#define WININET_E_FORCE_RETRY _HRESULT_TYPEDEF_(0x80072F00L)")]
        public const int WININET_E_FORCE_RETRY = unchecked((int)(0x80072F00));

        [NativeTypeName("#define WININET_E_INVALID_PROXY_REQUEST _HRESULT_TYPEDEF_(0x80072F01L)")]
        public const int WININET_E_INVALID_PROXY_REQUEST = unchecked((int)(0x80072F01));

        [NativeTypeName("#define WININET_E_NEED_UI _HRESULT_TYPEDEF_(0x80072F02L)")]
        public const int WININET_E_NEED_UI = unchecked((int)(0x80072F02));

        [NativeTypeName("#define WININET_E_HANDLE_EXISTS _HRESULT_TYPEDEF_(0x80072F04L)")]
        public const int WININET_E_HANDLE_EXISTS = unchecked((int)(0x80072F04));

        [NativeTypeName("#define WININET_E_SEC_CERT_DATE_INVALID _HRESULT_TYPEDEF_(0x80072F05L)")]
        public const int WININET_E_SEC_CERT_DATE_INVALID = unchecked((int)(0x80072F05));

        [NativeTypeName("#define WININET_E_SEC_CERT_CN_INVALID _HRESULT_TYPEDEF_(0x80072F06L)")]
        public const int WININET_E_SEC_CERT_CN_INVALID = unchecked((int)(0x80072F06));

        [NativeTypeName("#define WININET_E_HTTP_TO_HTTPS_ON_REDIR _HRESULT_TYPEDEF_(0x80072F07L)")]
        public const int WININET_E_HTTP_TO_HTTPS_ON_REDIR = unchecked((int)(0x80072F07));

        [NativeTypeName("#define WININET_E_HTTPS_TO_HTTP_ON_REDIR _HRESULT_TYPEDEF_(0x80072F08L)")]
        public const int WININET_E_HTTPS_TO_HTTP_ON_REDIR = unchecked((int)(0x80072F08));

        [NativeTypeName("#define WININET_E_MIXED_SECURITY _HRESULT_TYPEDEF_(0x80072F09L)")]
        public const int WININET_E_MIXED_SECURITY = unchecked((int)(0x80072F09));

        [NativeTypeName("#define WININET_E_CHG_POST_IS_NON_SECURE _HRESULT_TYPEDEF_(0x80072F0AL)")]
        public const int WININET_E_CHG_POST_IS_NON_SECURE = unchecked((int)(0x80072F0A));

        [NativeTypeName("#define WININET_E_POST_IS_NON_SECURE _HRESULT_TYPEDEF_(0x80072F0BL)")]
        public const int WININET_E_POST_IS_NON_SECURE = unchecked((int)(0x80072F0B));

        [NativeTypeName("#define WININET_E_CLIENT_AUTH_CERT_NEEDED _HRESULT_TYPEDEF_(0x80072F0CL)")]
        public const int WININET_E_CLIENT_AUTH_CERT_NEEDED = unchecked((int)(0x80072F0C));

        [NativeTypeName("#define WININET_E_INVALID_CA _HRESULT_TYPEDEF_(0x80072F0DL)")]
        public const int WININET_E_INVALID_CA = unchecked((int)(0x80072F0D));

        [NativeTypeName("#define WININET_E_CLIENT_AUTH_NOT_SETUP _HRESULT_TYPEDEF_(0x80072F0EL)")]
        public const int WININET_E_CLIENT_AUTH_NOT_SETUP = unchecked((int)(0x80072F0E));

        [NativeTypeName("#define WININET_E_ASYNC_THREAD_FAILED _HRESULT_TYPEDEF_(0x80072F0FL)")]
        public const int WININET_E_ASYNC_THREAD_FAILED = unchecked((int)(0x80072F0F));

        [NativeTypeName("#define WININET_E_REDIRECT_SCHEME_CHANGE _HRESULT_TYPEDEF_(0x80072F10L)")]
        public const int WININET_E_REDIRECT_SCHEME_CHANGE = unchecked((int)(0x80072F10));

        [NativeTypeName("#define WININET_E_DIALOG_PENDING _HRESULT_TYPEDEF_(0x80072F11L)")]
        public const int WININET_E_DIALOG_PENDING = unchecked((int)(0x80072F11));

        [NativeTypeName("#define WININET_E_RETRY_DIALOG _HRESULT_TYPEDEF_(0x80072F12L)")]
        public const int WININET_E_RETRY_DIALOG = unchecked((int)(0x80072F12));

        [NativeTypeName("#define WININET_E_NO_NEW_CONTAINERS _HRESULT_TYPEDEF_(0x80072F13L)")]
        public const int WININET_E_NO_NEW_CONTAINERS = unchecked((int)(0x80072F13));

        [NativeTypeName("#define WININET_E_HTTPS_HTTP_SUBMIT_REDIR _HRESULT_TYPEDEF_(0x80072F14L)")]
        public const int WININET_E_HTTPS_HTTP_SUBMIT_REDIR = unchecked((int)(0x80072F14));

        [NativeTypeName("#define WININET_E_SEC_CERT_ERRORS _HRESULT_TYPEDEF_(0x80072F17L)")]
        public const int WININET_E_SEC_CERT_ERRORS = unchecked((int)(0x80072F17));

        [NativeTypeName("#define WININET_E_SEC_CERT_REV_FAILED _HRESULT_TYPEDEF_(0x80072F19L)")]
        public const int WININET_E_SEC_CERT_REV_FAILED = unchecked((int)(0x80072F19));

        [NativeTypeName("#define WININET_E_HEADER_NOT_FOUND _HRESULT_TYPEDEF_(0x80072F76L)")]
        public const int WININET_E_HEADER_NOT_FOUND = unchecked((int)(0x80072F76));

        [NativeTypeName("#define WININET_E_DOWNLEVEL_SERVER _HRESULT_TYPEDEF_(0x80072F77L)")]
        public const int WININET_E_DOWNLEVEL_SERVER = unchecked((int)(0x80072F77));

        [NativeTypeName("#define WININET_E_INVALID_SERVER_RESPONSE _HRESULT_TYPEDEF_(0x80072F78L)")]
        public const int WININET_E_INVALID_SERVER_RESPONSE = unchecked((int)(0x80072F78));

        [NativeTypeName("#define WININET_E_INVALID_HEADER _HRESULT_TYPEDEF_(0x80072F79L)")]
        public const int WININET_E_INVALID_HEADER = unchecked((int)(0x80072F79));

        [NativeTypeName("#define WININET_E_INVALID_QUERY_REQUEST _HRESULT_TYPEDEF_(0x80072F7AL)")]
        public const int WININET_E_INVALID_QUERY_REQUEST = unchecked((int)(0x80072F7A));

        [NativeTypeName("#define WININET_E_HEADER_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80072F7BL)")]
        public const int WININET_E_HEADER_ALREADY_EXISTS = unchecked((int)(0x80072F7B));

        [NativeTypeName("#define WININET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x80072F7CL)")]
        public const int WININET_E_REDIRECT_FAILED = unchecked((int)(0x80072F7C));

        [NativeTypeName("#define WININET_E_SECURITY_CHANNEL_ERROR _HRESULT_TYPEDEF_(0x80072F7DL)")]
        public const int WININET_E_SECURITY_CHANNEL_ERROR = unchecked((int)(0x80072F7D));

        [NativeTypeName("#define WININET_E_UNABLE_TO_CACHE_FILE _HRESULT_TYPEDEF_(0x80072F7EL)")]
        public const int WININET_E_UNABLE_TO_CACHE_FILE = unchecked((int)(0x80072F7E));

        [NativeTypeName("#define WININET_E_TCPIP_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80072F7FL)")]
        public const int WININET_E_TCPIP_NOT_INSTALLED = unchecked((int)(0x80072F7F));

        [NativeTypeName("#define WININET_E_DISCONNECTED _HRESULT_TYPEDEF_(0x80072F83L)")]
        public const int WININET_E_DISCONNECTED = unchecked((int)(0x80072F83));

        [NativeTypeName("#define WININET_E_SERVER_UNREACHABLE _HRESULT_TYPEDEF_(0x80072F84L)")]
        public const int WININET_E_SERVER_UNREACHABLE = unchecked((int)(0x80072F84));

        [NativeTypeName("#define WININET_E_PROXY_SERVER_UNREACHABLE _HRESULT_TYPEDEF_(0x80072F85L)")]
        public const int WININET_E_PROXY_SERVER_UNREACHABLE = unchecked((int)(0x80072F85));

        [NativeTypeName("#define WININET_E_BAD_AUTO_PROXY_SCRIPT _HRESULT_TYPEDEF_(0x80072F86L)")]
        public const int WININET_E_BAD_AUTO_PROXY_SCRIPT = unchecked((int)(0x80072F86));

        [NativeTypeName("#define WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT _HRESULT_TYPEDEF_(0x80072F87L)")]
        public const int WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT = unchecked((int)(0x80072F87));

        [NativeTypeName("#define WININET_E_SEC_INVALID_CERT _HRESULT_TYPEDEF_(0x80072F89L)")]
        public const int WININET_E_SEC_INVALID_CERT = unchecked((int)(0x80072F89));

        [NativeTypeName("#define WININET_E_SEC_CERT_REVOKED _HRESULT_TYPEDEF_(0x80072F8AL)")]
        public const int WININET_E_SEC_CERT_REVOKED = unchecked((int)(0x80072F8A));

        [NativeTypeName("#define WININET_E_FAILED_DUETOSECURITYCHECK _HRESULT_TYPEDEF_(0x80072F8BL)")]
        public const int WININET_E_FAILED_DUETOSECURITYCHECK = unchecked((int)(0x80072F8B));

        [NativeTypeName("#define WININET_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80072F8CL)")]
        public const int WININET_E_NOT_INITIALIZED = unchecked((int)(0x80072F8C));

        [NativeTypeName("#define WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY _HRESULT_TYPEDEF_(0x80072F8EL)")]
        public const int WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = unchecked((int)(0x80072F8E));

        [NativeTypeName("#define WININET_E_DECODING_FAILED _HRESULT_TYPEDEF_(0x80072F8FL)")]
        public const int WININET_E_DECODING_FAILED = unchecked((int)(0x80072F8F));

        [NativeTypeName("#define WININET_E_NOT_REDIRECTED _HRESULT_TYPEDEF_(0x80072F80L)")]
        public const int WININET_E_NOT_REDIRECTED = unchecked((int)(0x80072F80));

        [NativeTypeName("#define WININET_E_COOKIE_NEEDS_CONFIRMATION _HRESULT_TYPEDEF_(0x80072F81L)")]
        public const int WININET_E_COOKIE_NEEDS_CONFIRMATION = unchecked((int)(0x80072F81));

        [NativeTypeName("#define WININET_E_COOKIE_DECLINED _HRESULT_TYPEDEF_(0x80072F82L)")]
        public const int WININET_E_COOKIE_DECLINED = unchecked((int)(0x80072F82));

        [NativeTypeName("#define WININET_E_REDIRECT_NEEDS_CONFIRMATION _HRESULT_TYPEDEF_(0x80072F88L)")]
        public const int WININET_E_REDIRECT_NEEDS_CONFIRMATION = unchecked((int)(0x80072F88));

        [NativeTypeName("#define SQLITE_E_ERROR _HRESULT_TYPEDEF_(0x87AF0001L)")]
        public const int SQLITE_E_ERROR = unchecked((int)(0x87AF0001));

        [NativeTypeName("#define SQLITE_E_INTERNAL _HRESULT_TYPEDEF_(0x87AF0002L)")]
        public const int SQLITE_E_INTERNAL = unchecked((int)(0x87AF0002));

        [NativeTypeName("#define SQLITE_E_PERM _HRESULT_TYPEDEF_(0x87AF0003L)")]
        public const int SQLITE_E_PERM = unchecked((int)(0x87AF0003));

        [NativeTypeName("#define SQLITE_E_ABORT _HRESULT_TYPEDEF_(0x87AF0004L)")]
        public const int SQLITE_E_ABORT = unchecked((int)(0x87AF0004));

        [NativeTypeName("#define SQLITE_E_BUSY _HRESULT_TYPEDEF_(0x87AF0005L)")]
        public const int SQLITE_E_BUSY = unchecked((int)(0x87AF0005));

        [NativeTypeName("#define SQLITE_E_LOCKED _HRESULT_TYPEDEF_(0x87AF0006L)")]
        public const int SQLITE_E_LOCKED = unchecked((int)(0x87AF0006));

        [NativeTypeName("#define SQLITE_E_NOMEM _HRESULT_TYPEDEF_(0x87AF0007L)")]
        public const int SQLITE_E_NOMEM = unchecked((int)(0x87AF0007));

        [NativeTypeName("#define SQLITE_E_READONLY _HRESULT_TYPEDEF_(0x87AF0008L)")]
        public const int SQLITE_E_READONLY = unchecked((int)(0x87AF0008));

        [NativeTypeName("#define SQLITE_E_INTERRUPT _HRESULT_TYPEDEF_(0x87AF0009L)")]
        public const int SQLITE_E_INTERRUPT = unchecked((int)(0x87AF0009));

        [NativeTypeName("#define SQLITE_E_IOERR _HRESULT_TYPEDEF_(0x87AF000AL)")]
        public const int SQLITE_E_IOERR = unchecked((int)(0x87AF000A));

        [NativeTypeName("#define SQLITE_E_CORRUPT _HRESULT_TYPEDEF_(0x87AF000BL)")]
        public const int SQLITE_E_CORRUPT = unchecked((int)(0x87AF000B));

        [NativeTypeName("#define SQLITE_E_NOTFOUND _HRESULT_TYPEDEF_(0x87AF000CL)")]
        public const int SQLITE_E_NOTFOUND = unchecked((int)(0x87AF000C));

        [NativeTypeName("#define SQLITE_E_FULL _HRESULT_TYPEDEF_(0x87AF000DL)")]
        public const int SQLITE_E_FULL = unchecked((int)(0x87AF000D));

        [NativeTypeName("#define SQLITE_E_CANTOPEN _HRESULT_TYPEDEF_(0x87AF000EL)")]
        public const int SQLITE_E_CANTOPEN = unchecked((int)(0x87AF000E));

        [NativeTypeName("#define SQLITE_E_PROTOCOL _HRESULT_TYPEDEF_(0x87AF000FL)")]
        public const int SQLITE_E_PROTOCOL = unchecked((int)(0x87AF000F));

        [NativeTypeName("#define SQLITE_E_EMPTY _HRESULT_TYPEDEF_(0x87AF0010L)")]
        public const int SQLITE_E_EMPTY = unchecked((int)(0x87AF0010));

        [NativeTypeName("#define SQLITE_E_SCHEMA _HRESULT_TYPEDEF_(0x87AF0011L)")]
        public const int SQLITE_E_SCHEMA = unchecked((int)(0x87AF0011));

        [NativeTypeName("#define SQLITE_E_TOOBIG _HRESULT_TYPEDEF_(0x87AF0012L)")]
        public const int SQLITE_E_TOOBIG = unchecked((int)(0x87AF0012));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT _HRESULT_TYPEDEF_(0x87AF0013L)")]
        public const int SQLITE_E_CONSTRAINT = unchecked((int)(0x87AF0013));

        [NativeTypeName("#define SQLITE_E_MISMATCH _HRESULT_TYPEDEF_(0x87AF0014L)")]
        public const int SQLITE_E_MISMATCH = unchecked((int)(0x87AF0014));

        [NativeTypeName("#define SQLITE_E_MISUSE _HRESULT_TYPEDEF_(0x87AF0015L)")]
        public const int SQLITE_E_MISUSE = unchecked((int)(0x87AF0015));

        [NativeTypeName("#define SQLITE_E_NOLFS _HRESULT_TYPEDEF_(0x87AF0016L)")]
        public const int SQLITE_E_NOLFS = unchecked((int)(0x87AF0016));

        [NativeTypeName("#define SQLITE_E_AUTH _HRESULT_TYPEDEF_(0x87AF0017L)")]
        public const int SQLITE_E_AUTH = unchecked((int)(0x87AF0017));

        [NativeTypeName("#define SQLITE_E_FORMAT _HRESULT_TYPEDEF_(0x87AF0018L)")]
        public const int SQLITE_E_FORMAT = unchecked((int)(0x87AF0018));

        [NativeTypeName("#define SQLITE_E_RANGE _HRESULT_TYPEDEF_(0x87AF0019L)")]
        public const int SQLITE_E_RANGE = unchecked((int)(0x87AF0019));

        [NativeTypeName("#define SQLITE_E_NOTADB _HRESULT_TYPEDEF_(0x87AF001AL)")]
        public const int SQLITE_E_NOTADB = unchecked((int)(0x87AF001A));

        [NativeTypeName("#define SQLITE_E_NOTICE _HRESULT_TYPEDEF_(0x87AF001BL)")]
        public const int SQLITE_E_NOTICE = unchecked((int)(0x87AF001B));

        [NativeTypeName("#define SQLITE_E_WARNING _HRESULT_TYPEDEF_(0x87AF001CL)")]
        public const int SQLITE_E_WARNING = unchecked((int)(0x87AF001C));

        [NativeTypeName("#define SQLITE_E_ROW _HRESULT_TYPEDEF_(0x87AF0064L)")]
        public const int SQLITE_E_ROW = unchecked((int)(0x87AF0064));

        [NativeTypeName("#define SQLITE_E_DONE _HRESULT_TYPEDEF_(0x87AF0065L)")]
        public const int SQLITE_E_DONE = unchecked((int)(0x87AF0065));

        [NativeTypeName("#define SQLITE_E_IOERR_READ _HRESULT_TYPEDEF_(0x87AF010AL)")]
        public const int SQLITE_E_IOERR_READ = unchecked((int)(0x87AF010A));

        [NativeTypeName("#define SQLITE_E_IOERR_SHORT_READ _HRESULT_TYPEDEF_(0x87AF020AL)")]
        public const int SQLITE_E_IOERR_SHORT_READ = unchecked((int)(0x87AF020A));

        [NativeTypeName("#define SQLITE_E_IOERR_WRITE _HRESULT_TYPEDEF_(0x87AF030AL)")]
        public const int SQLITE_E_IOERR_WRITE = unchecked((int)(0x87AF030A));

        [NativeTypeName("#define SQLITE_E_IOERR_FSYNC _HRESULT_TYPEDEF_(0x87AF040AL)")]
        public const int SQLITE_E_IOERR_FSYNC = unchecked((int)(0x87AF040A));

        [NativeTypeName("#define SQLITE_E_IOERR_DIR_FSYNC _HRESULT_TYPEDEF_(0x87AF050AL)")]
        public const int SQLITE_E_IOERR_DIR_FSYNC = unchecked((int)(0x87AF050A));

        [NativeTypeName("#define SQLITE_E_IOERR_TRUNCATE _HRESULT_TYPEDEF_(0x87AF060AL)")]
        public const int SQLITE_E_IOERR_TRUNCATE = unchecked((int)(0x87AF060A));

        [NativeTypeName("#define SQLITE_E_IOERR_FSTAT _HRESULT_TYPEDEF_(0x87AF070AL)")]
        public const int SQLITE_E_IOERR_FSTAT = unchecked((int)(0x87AF070A));

        [NativeTypeName("#define SQLITE_E_IOERR_UNLOCK _HRESULT_TYPEDEF_(0x87AF080AL)")]
        public const int SQLITE_E_IOERR_UNLOCK = unchecked((int)(0x87AF080A));

        [NativeTypeName("#define SQLITE_E_IOERR_RDLOCK _HRESULT_TYPEDEF_(0x87AF090AL)")]
        public const int SQLITE_E_IOERR_RDLOCK = unchecked((int)(0x87AF090A));

        [NativeTypeName("#define SQLITE_E_IOERR_DELETE _HRESULT_TYPEDEF_(0x87AF0A0AL)")]
        public const int SQLITE_E_IOERR_DELETE = unchecked((int)(0x87AF0A0A));

        [NativeTypeName("#define SQLITE_E_IOERR_BLOCKED _HRESULT_TYPEDEF_(0x87AF0B0AL)")]
        public const int SQLITE_E_IOERR_BLOCKED = unchecked((int)(0x87AF0B0A));

        [NativeTypeName("#define SQLITE_E_IOERR_NOMEM _HRESULT_TYPEDEF_(0x87AF0C0AL)")]
        public const int SQLITE_E_IOERR_NOMEM = unchecked((int)(0x87AF0C0A));

        [NativeTypeName("#define SQLITE_E_IOERR_ACCESS _HRESULT_TYPEDEF_(0x87AF0D0AL)")]
        public const int SQLITE_E_IOERR_ACCESS = unchecked((int)(0x87AF0D0A));

        [NativeTypeName("#define SQLITE_E_IOERR_CHECKRESERVEDLOCK _HRESULT_TYPEDEF_(0x87AF0E0AL)")]
        public const int SQLITE_E_IOERR_CHECKRESERVEDLOCK = unchecked((int)(0x87AF0E0A));

        [NativeTypeName("#define SQLITE_E_IOERR_LOCK _HRESULT_TYPEDEF_(0x87AF0F0AL)")]
        public const int SQLITE_E_IOERR_LOCK = unchecked((int)(0x87AF0F0A));

        [NativeTypeName("#define SQLITE_E_IOERR_CLOSE _HRESULT_TYPEDEF_(0x87AF100AL)")]
        public const int SQLITE_E_IOERR_CLOSE = unchecked((int)(0x87AF100A));

        [NativeTypeName("#define SQLITE_E_IOERR_DIR_CLOSE _HRESULT_TYPEDEF_(0x87AF110AL)")]
        public const int SQLITE_E_IOERR_DIR_CLOSE = unchecked((int)(0x87AF110A));

        [NativeTypeName("#define SQLITE_E_IOERR_SHMOPEN _HRESULT_TYPEDEF_(0x87AF120AL)")]
        public const int SQLITE_E_IOERR_SHMOPEN = unchecked((int)(0x87AF120A));

        [NativeTypeName("#define SQLITE_E_IOERR_SHMSIZE _HRESULT_TYPEDEF_(0x87AF130AL)")]
        public const int SQLITE_E_IOERR_SHMSIZE = unchecked((int)(0x87AF130A));

        [NativeTypeName("#define SQLITE_E_IOERR_SHMLOCK _HRESULT_TYPEDEF_(0x87AF140AL)")]
        public const int SQLITE_E_IOERR_SHMLOCK = unchecked((int)(0x87AF140A));

        [NativeTypeName("#define SQLITE_E_IOERR_SHMMAP _HRESULT_TYPEDEF_(0x87AF150AL)")]
        public const int SQLITE_E_IOERR_SHMMAP = unchecked((int)(0x87AF150A));

        [NativeTypeName("#define SQLITE_E_IOERR_SEEK _HRESULT_TYPEDEF_(0x87AF160AL)")]
        public const int SQLITE_E_IOERR_SEEK = unchecked((int)(0x87AF160A));

        [NativeTypeName("#define SQLITE_E_IOERR_DELETE_NOENT _HRESULT_TYPEDEF_(0x87AF170AL)")]
        public const int SQLITE_E_IOERR_DELETE_NOENT = unchecked((int)(0x87AF170A));

        [NativeTypeName("#define SQLITE_E_IOERR_MMAP _HRESULT_TYPEDEF_(0x87AF180AL)")]
        public const int SQLITE_E_IOERR_MMAP = unchecked((int)(0x87AF180A));

        [NativeTypeName("#define SQLITE_E_IOERR_GETTEMPPATH _HRESULT_TYPEDEF_(0x87AF190AL)")]
        public const int SQLITE_E_IOERR_GETTEMPPATH = unchecked((int)(0x87AF190A));

        [NativeTypeName("#define SQLITE_E_IOERR_CONVPATH _HRESULT_TYPEDEF_(0x87AF1A0AL)")]
        public const int SQLITE_E_IOERR_CONVPATH = unchecked((int)(0x87AF1A0A));

        [NativeTypeName("#define SQLITE_E_IOERR_VNODE _HRESULT_TYPEDEF_(0x87AF1A02L)")]
        public const int SQLITE_E_IOERR_VNODE = unchecked((int)(0x87AF1A02));

        [NativeTypeName("#define SQLITE_E_IOERR_AUTH _HRESULT_TYPEDEF_(0x87AF1A03L)")]
        public const int SQLITE_E_IOERR_AUTH = unchecked((int)(0x87AF1A03));

        [NativeTypeName("#define SQLITE_E_LOCKED_SHAREDCACHE _HRESULT_TYPEDEF_(0x87AF0106L)")]
        public const int SQLITE_E_LOCKED_SHAREDCACHE = unchecked((int)(0x87AF0106));

        [NativeTypeName("#define SQLITE_E_BUSY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0105L)")]
        public const int SQLITE_E_BUSY_RECOVERY = unchecked((int)(0x87AF0105));

        [NativeTypeName("#define SQLITE_E_BUSY_SNAPSHOT _HRESULT_TYPEDEF_(0x87AF0205L)")]
        public const int SQLITE_E_BUSY_SNAPSHOT = unchecked((int)(0x87AF0205));

        [NativeTypeName("#define SQLITE_E_CANTOPEN_NOTEMPDIR _HRESULT_TYPEDEF_(0x87AF010EL)")]
        public const int SQLITE_E_CANTOPEN_NOTEMPDIR = unchecked((int)(0x87AF010E));

        [NativeTypeName("#define SQLITE_E_CANTOPEN_ISDIR _HRESULT_TYPEDEF_(0x87AF020EL)")]
        public const int SQLITE_E_CANTOPEN_ISDIR = unchecked((int)(0x87AF020E));

        [NativeTypeName("#define SQLITE_E_CANTOPEN_FULLPATH _HRESULT_TYPEDEF_(0x87AF030EL)")]
        public const int SQLITE_E_CANTOPEN_FULLPATH = unchecked((int)(0x87AF030E));

        [NativeTypeName("#define SQLITE_E_CANTOPEN_CONVPATH _HRESULT_TYPEDEF_(0x87AF040EL)")]
        public const int SQLITE_E_CANTOPEN_CONVPATH = unchecked((int)(0x87AF040E));

        [NativeTypeName("#define SQLITE_E_CORRUPT_VTAB _HRESULT_TYPEDEF_(0x87AF010BL)")]
        public const int SQLITE_E_CORRUPT_VTAB = unchecked((int)(0x87AF010B));

        [NativeTypeName("#define SQLITE_E_READONLY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0108L)")]
        public const int SQLITE_E_READONLY_RECOVERY = unchecked((int)(0x87AF0108));

        [NativeTypeName("#define SQLITE_E_READONLY_CANTLOCK _HRESULT_TYPEDEF_(0x87AF0208L)")]
        public const int SQLITE_E_READONLY_CANTLOCK = unchecked((int)(0x87AF0208));

        [NativeTypeName("#define SQLITE_E_READONLY_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0308L)")]
        public const int SQLITE_E_READONLY_ROLLBACK = unchecked((int)(0x87AF0308));

        [NativeTypeName("#define SQLITE_E_READONLY_DBMOVED _HRESULT_TYPEDEF_(0x87AF0408L)")]
        public const int SQLITE_E_READONLY_DBMOVED = unchecked((int)(0x87AF0408));

        [NativeTypeName("#define SQLITE_E_ABORT_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0204L)")]
        public const int SQLITE_E_ABORT_ROLLBACK = unchecked((int)(0x87AF0204));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_CHECK _HRESULT_TYPEDEF_(0x87AF0113L)")]
        public const int SQLITE_E_CONSTRAINT_CHECK = unchecked((int)(0x87AF0113));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_COMMITHOOK _HRESULT_TYPEDEF_(0x87AF0213L)")]
        public const int SQLITE_E_CONSTRAINT_COMMITHOOK = unchecked((int)(0x87AF0213));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_FOREIGNKEY _HRESULT_TYPEDEF_(0x87AF0313L)")]
        public const int SQLITE_E_CONSTRAINT_FOREIGNKEY = unchecked((int)(0x87AF0313));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_FUNCTION _HRESULT_TYPEDEF_(0x87AF0413L)")]
        public const int SQLITE_E_CONSTRAINT_FUNCTION = unchecked((int)(0x87AF0413));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_NOTNULL _HRESULT_TYPEDEF_(0x87AF0513L)")]
        public const int SQLITE_E_CONSTRAINT_NOTNULL = unchecked((int)(0x87AF0513));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_PRIMARYKEY _HRESULT_TYPEDEF_(0x87AF0613L)")]
        public const int SQLITE_E_CONSTRAINT_PRIMARYKEY = unchecked((int)(0x87AF0613));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_TRIGGER _HRESULT_TYPEDEF_(0x87AF0713L)")]
        public const int SQLITE_E_CONSTRAINT_TRIGGER = unchecked((int)(0x87AF0713));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_UNIQUE _HRESULT_TYPEDEF_(0x87AF0813L)")]
        public const int SQLITE_E_CONSTRAINT_UNIQUE = unchecked((int)(0x87AF0813));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_VTAB _HRESULT_TYPEDEF_(0x87AF0913L)")]
        public const int SQLITE_E_CONSTRAINT_VTAB = unchecked((int)(0x87AF0913));

        [NativeTypeName("#define SQLITE_E_CONSTRAINT_ROWID _HRESULT_TYPEDEF_(0x87AF0A13L)")]
        public const int SQLITE_E_CONSTRAINT_ROWID = unchecked((int)(0x87AF0A13));

        [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_WAL _HRESULT_TYPEDEF_(0x87AF011BL)")]
        public const int SQLITE_E_NOTICE_RECOVER_WAL = unchecked((int)(0x87AF011B));

        [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_ROLLBACK _HRESULT_TYPEDEF_(0x87AF021BL)")]
        public const int SQLITE_E_NOTICE_RECOVER_ROLLBACK = unchecked((int)(0x87AF021B));

        [NativeTypeName("#define SQLITE_E_WARNING_AUTOINDEX _HRESULT_TYPEDEF_(0x87AF011CL)")]
        public const int SQLITE_E_WARNING_AUTOINDEX = unchecked((int)(0x87AF011C));

        [NativeTypeName("#define UTC_E_TOGGLE_TRACE_STARTED _HRESULT_TYPEDEF_(0x87C51001L)")]
        public const int UTC_E_TOGGLE_TRACE_STARTED = unchecked((int)(0x87C51001));

        [NativeTypeName("#define UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT _HRESULT_TYPEDEF_(0x87C51002L)")]
        public const int UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT = unchecked((int)(0x87C51002));

        [NativeTypeName("#define UTC_E_AOT_NOT_RUNNING _HRESULT_TYPEDEF_(0x87C51003L)")]
        public const int UTC_E_AOT_NOT_RUNNING = unchecked((int)(0x87C51003));

        [NativeTypeName("#define UTC_E_SCRIPT_TYPE_INVALID _HRESULT_TYPEDEF_(0x87C51004L)")]
        public const int UTC_E_SCRIPT_TYPE_INVALID = unchecked((int)(0x87C51004));

        [NativeTypeName("#define UTC_E_SCENARIODEF_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51005L)")]
        public const int UTC_E_SCENARIODEF_NOT_FOUND = unchecked((int)(0x87C51005));

        [NativeTypeName("#define UTC_E_TRACEPROFILE_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51006L)")]
        public const int UTC_E_TRACEPROFILE_NOT_FOUND = unchecked((int)(0x87C51006));

        [NativeTypeName("#define UTC_E_FORWARDER_ALREADY_ENABLED _HRESULT_TYPEDEF_(0x87C51007L)")]
        public const int UTC_E_FORWARDER_ALREADY_ENABLED = unchecked((int)(0x87C51007));

        [NativeTypeName("#define UTC_E_FORWARDER_ALREADY_DISABLED _HRESULT_TYPEDEF_(0x87C51008L)")]
        public const int UTC_E_FORWARDER_ALREADY_DISABLED = unchecked((int)(0x87C51008));

        [NativeTypeName("#define UTC_E_EVENTLOG_ENTRY_MALFORMED _HRESULT_TYPEDEF_(0x87C51009L)")]
        public const int UTC_E_EVENTLOG_ENTRY_MALFORMED = unchecked((int)(0x87C51009));

        [NativeTypeName("#define UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C5100AL)")]
        public const int UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH = unchecked((int)(0x87C5100A));

        [NativeTypeName("#define UTC_E_SCRIPT_TERMINATED _HRESULT_TYPEDEF_(0x87C5100BL)")]
        public const int UTC_E_SCRIPT_TERMINATED = unchecked((int)(0x87C5100B));

        [NativeTypeName("#define UTC_E_INVALID_CUSTOM_FILTER _HRESULT_TYPEDEF_(0x87C5100CL)")]
        public const int UTC_E_INVALID_CUSTOM_FILTER = unchecked((int)(0x87C5100C));

        [NativeTypeName("#define UTC_E_TRACE_NOT_RUNNING _HRESULT_TYPEDEF_(0x87C5100DL)")]
        public const int UTC_E_TRACE_NOT_RUNNING = unchecked((int)(0x87C5100D));

        [NativeTypeName("#define UTC_E_REESCALATED_TOO_QUICKLY _HRESULT_TYPEDEF_(0x87C5100EL)")]
        public const int UTC_E_REESCALATED_TOO_QUICKLY = unchecked((int)(0x87C5100E));

        [NativeTypeName("#define UTC_E_ESCALATION_ALREADY_RUNNING _HRESULT_TYPEDEF_(0x87C5100FL)")]
        public const int UTC_E_ESCALATION_ALREADY_RUNNING = unchecked((int)(0x87C5100F));

        [NativeTypeName("#define UTC_E_PERFTRACK_ALREADY_TRACING _HRESULT_TYPEDEF_(0x87C51010L)")]
        public const int UTC_E_PERFTRACK_ALREADY_TRACING = unchecked((int)(0x87C51010));

        [NativeTypeName("#define UTC_E_REACHED_MAX_ESCALATIONS _HRESULT_TYPEDEF_(0x87C51011L)")]
        public const int UTC_E_REACHED_MAX_ESCALATIONS = unchecked((int)(0x87C51011));

        [NativeTypeName("#define UTC_E_FORWARDER_PRODUCER_MISMATCH _HRESULT_TYPEDEF_(0x87C51012L)")]
        public const int UTC_E_FORWARDER_PRODUCER_MISMATCH = unchecked((int)(0x87C51012));

        [NativeTypeName("#define UTC_E_INTENTIONAL_SCRIPT_FAILURE _HRESULT_TYPEDEF_(0x87C51013L)")]
        public const int UTC_E_INTENTIONAL_SCRIPT_FAILURE = unchecked((int)(0x87C51013));

        [NativeTypeName("#define UTC_E_SQM_INIT_FAILED _HRESULT_TYPEDEF_(0x87C51014L)")]
        public const int UTC_E_SQM_INIT_FAILED = unchecked((int)(0x87C51014));

        [NativeTypeName("#define UTC_E_NO_WER_LOGGER_SUPPORTED _HRESULT_TYPEDEF_(0x87C51015L)")]
        public const int UTC_E_NO_WER_LOGGER_SUPPORTED = unchecked((int)(0x87C51015));

        [NativeTypeName("#define UTC_E_TRACERS_DONT_EXIST _HRESULT_TYPEDEF_(0x87C51016L)")]
        public const int UTC_E_TRACERS_DONT_EXIST = unchecked((int)(0x87C51016));

        [NativeTypeName("#define UTC_E_WINRT_INIT_FAILED _HRESULT_TYPEDEF_(0x87C51017L)")]
        public const int UTC_E_WINRT_INIT_FAILED = unchecked((int)(0x87C51017));

        [NativeTypeName("#define UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C51018L)")]
        public const int UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH = unchecked((int)(0x87C51018));

        [NativeTypeName("#define UTC_E_INVALID_FILTER _HRESULT_TYPEDEF_(0x87C51019L)")]
        public const int UTC_E_INVALID_FILTER = unchecked((int)(0x87C51019));

        [NativeTypeName("#define UTC_E_EXE_TERMINATED _HRESULT_TYPEDEF_(0x87C5101AL)")]
        public const int UTC_E_EXE_TERMINATED = unchecked((int)(0x87C5101A));

        [NativeTypeName("#define UTC_E_ESCALATION_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101BL)")]
        public const int UTC_E_ESCALATION_NOT_AUTHORIZED = unchecked((int)(0x87C5101B));

        [NativeTypeName("#define UTC_E_SETUP_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101CL)")]
        public const int UTC_E_SETUP_NOT_AUTHORIZED = unchecked((int)(0x87C5101C));

        [NativeTypeName("#define UTC_E_CHILD_PROCESS_FAILED _HRESULT_TYPEDEF_(0x87C5101DL)")]
        public const int UTC_E_CHILD_PROCESS_FAILED = unchecked((int)(0x87C5101D));

        [NativeTypeName("#define UTC_E_COMMAND_LINE_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101EL)")]
        public const int UTC_E_COMMAND_LINE_NOT_AUTHORIZED = unchecked((int)(0x87C5101E));

        [NativeTypeName("#define UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML _HRESULT_TYPEDEF_(0x87C5101FL)")]
        public const int UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML = unchecked((int)(0x87C5101F));

        [NativeTypeName("#define UTC_E_ESCALATION_TIMED_OUT _HRESULT_TYPEDEF_(0x87C51020L)")]
        public const int UTC_E_ESCALATION_TIMED_OUT = unchecked((int)(0x87C51020));

        [NativeTypeName("#define UTC_E_SETUP_TIMED_OUT _HRESULT_TYPEDEF_(0x87C51021L)")]
        public const int UTC_E_SETUP_TIMED_OUT = unchecked((int)(0x87C51021));

        [NativeTypeName("#define UTC_E_TRIGGER_MISMATCH _HRESULT_TYPEDEF_(0x87C51022L)")]
        public const int UTC_E_TRIGGER_MISMATCH = unchecked((int)(0x87C51022));

        [NativeTypeName("#define UTC_E_TRIGGER_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51023L)")]
        public const int UTC_E_TRIGGER_NOT_FOUND = unchecked((int)(0x87C51023));

        [NativeTypeName("#define UTC_E_SIF_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x87C51024L)")]
        public const int UTC_E_SIF_NOT_SUPPORTED = unchecked((int)(0x87C51024));

        [NativeTypeName("#define UTC_E_DELAY_TERMINATED _HRESULT_TYPEDEF_(0x87C51025L)")]
        public const int UTC_E_DELAY_TERMINATED = unchecked((int)(0x87C51025));

        [NativeTypeName("#define UTC_E_DEVICE_TICKET_ERROR _HRESULT_TYPEDEF_(0x87C51026L)")]
        public const int UTC_E_DEVICE_TICKET_ERROR = unchecked((int)(0x87C51026));

        [NativeTypeName("#define UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x87C51027L)")]
        public const int UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED = unchecked((int)(0x87C51027));

        [NativeTypeName("#define UTC_E_API_RESULT_UNAVAILABLE _HRESULT_TYPEDEF_(0x87C51028L)")]
        public const int UTC_E_API_RESULT_UNAVAILABLE = unchecked((int)(0x87C51028));

        [NativeTypeName("#define UTC_E_RPC_TIMEOUT _HRESULT_TYPEDEF_(0x87C51029L)")]
        public const int UTC_E_RPC_TIMEOUT = unchecked((int)(0x87C51029));

        [NativeTypeName("#define UTC_E_RPC_WAIT_FAILED _HRESULT_TYPEDEF_(0x87C5102AL)")]
        public const int UTC_E_RPC_WAIT_FAILED = unchecked((int)(0x87C5102A));

        [NativeTypeName("#define UTC_E_API_BUSY _HRESULT_TYPEDEF_(0x87C5102BL)")]
        public const int UTC_E_API_BUSY = unchecked((int)(0x87C5102B));

        [NativeTypeName("#define UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET _HRESULT_TYPEDEF_(0x87C5102CL)")]
        public const int UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET = unchecked((int)(0x87C5102C));

        [NativeTypeName("#define UTC_E_EXCLUSIVITY_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x87C5102DL)")]
        public const int UTC_E_EXCLUSIVITY_NOT_AVAILABLE = unchecked((int)(0x87C5102D));

        [NativeTypeName("#define UTC_E_GETFILE_FILE_PATH_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5102EL)")]
        public const int UTC_E_GETFILE_FILE_PATH_NOT_APPROVED = unchecked((int)(0x87C5102E));

        [NativeTypeName("#define UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x87C5102FL)")]
        public const int UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS = unchecked((int)(0x87C5102F));

        [NativeTypeName("#define UTC_E_TIME_TRIGGER_ON_START_INVALID _HRESULT_TYPEDEF_(0x87C51030L)")]
        public const int UTC_E_TIME_TRIGGER_ON_START_INVALID = unchecked((int)(0x87C51030));

        [NativeTypeName("#define UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION _HRESULT_TYPEDEF_(0x87C51031L)")]
        public const int UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION = unchecked((int)(0x87C51031));

        [NativeTypeName("#define UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE _HRESULT_TYPEDEF_(0x87C51032L)")]
        public const int UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE = unchecked((int)(0x87C51032));

        [NativeTypeName("#define UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE _HRESULT_TYPEDEF_(0x87C51033L)")]
        public const int UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE = unchecked((int)(0x87C51033));

        [NativeTypeName("#define UTC_E_BINARY_MISSING _HRESULT_TYPEDEF_(0x87C51034L)")]
        public const int UTC_E_BINARY_MISSING = unchecked((int)(0x87C51034));

        [NativeTypeName("#define UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID _HRESULT_TYPEDEF_(0x87C51036L)")]
        public const int UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID = unchecked((int)(0x87C51036));

        [NativeTypeName("#define UTC_E_UNABLE_TO_RESOLVE_SESSION _HRESULT_TYPEDEF_(0x87C51037L)")]
        public const int UTC_E_UNABLE_TO_RESOLVE_SESSION = unchecked((int)(0x87C51037));

        [NativeTypeName("#define UTC_E_THROTTLED _HRESULT_TYPEDEF_(0x87C51038L)")]
        public const int UTC_E_THROTTLED = unchecked((int)(0x87C51038));

        [NativeTypeName("#define UTC_E_UNAPPROVED_SCRIPT _HRESULT_TYPEDEF_(0x87C51039L)")]
        public const int UTC_E_UNAPPROVED_SCRIPT = unchecked((int)(0x87C51039));

        [NativeTypeName("#define UTC_E_SCRIPT_MISSING _HRESULT_TYPEDEF_(0x87C5103AL)")]
        public const int UTC_E_SCRIPT_MISSING = unchecked((int)(0x87C5103A));

        [NativeTypeName("#define UTC_E_SCENARIO_THROTTLED _HRESULT_TYPEDEF_(0x87C5103BL)")]
        public const int UTC_E_SCENARIO_THROTTLED = unchecked((int)(0x87C5103B));

        [NativeTypeName("#define UTC_E_API_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x87C5103CL)")]
        public const int UTC_E_API_NOT_SUPPORTED = unchecked((int)(0x87C5103C));

        [NativeTypeName("#define UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5103DL)")]
        public const int UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED = unchecked((int)(0x87C5103D));

        [NativeTypeName("#define UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x87C5103EL)")]
        public const int UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED = unchecked((int)(0x87C5103E));

        [NativeTypeName("#define UTC_E_CERT_REV_FAILED _HRESULT_TYPEDEF_(0x87C5103FL)")]
        public const int UTC_E_CERT_REV_FAILED = unchecked((int)(0x87C5103F));

        [NativeTypeName("#define UTC_E_FAILED_TO_START_NDISCAP _HRESULT_TYPEDEF_(0x87C51040L)")]
        public const int UTC_E_FAILED_TO_START_NDISCAP = unchecked((int)(0x87C51040));

        [NativeTypeName("#define UTC_E_KERNELDUMP_LIMIT_REACHED _HRESULT_TYPEDEF_(0x87C51041L)")]
        public const int UTC_E_KERNELDUMP_LIMIT_REACHED = unchecked((int)(0x87C51041));

        [NativeTypeName("#define UTC_E_MISSING_AGGREGATE_EVENT_TAG _HRESULT_TYPEDEF_(0x87C51042L)")]
        public const int UTC_E_MISSING_AGGREGATE_EVENT_TAG = unchecked((int)(0x87C51042));

        [NativeTypeName("#define UTC_E_INVALID_AGGREGATION_STRUCT _HRESULT_TYPEDEF_(0x87C51043L)")]
        public const int UTC_E_INVALID_AGGREGATION_STRUCT = unchecked((int)(0x87C51043));

        [NativeTypeName("#define UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION _HRESULT_TYPEDEF_(0x87C51044L)")]
        public const int UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION = unchecked((int)(0x87C51044));

        [NativeTypeName("#define UTC_E_FILTER_MISSING_ATTRIBUTE _HRESULT_TYPEDEF_(0x87C51045L)")]
        public const int UTC_E_FILTER_MISSING_ATTRIBUTE = unchecked((int)(0x87C51045));

        [NativeTypeName("#define UTC_E_FILTER_INVALID_TYPE _HRESULT_TYPEDEF_(0x87C51046L)")]
        public const int UTC_E_FILTER_INVALID_TYPE = unchecked((int)(0x87C51046));

        [NativeTypeName("#define UTC_E_FILTER_VARIABLE_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51047L)")]
        public const int UTC_E_FILTER_VARIABLE_NOT_FOUND = unchecked((int)(0x87C51047));

        [NativeTypeName("#define UTC_E_FILTER_FUNCTION_RESTRICTED _HRESULT_TYPEDEF_(0x87C51048L)")]
        public const int UTC_E_FILTER_FUNCTION_RESTRICTED = unchecked((int)(0x87C51048));

        [NativeTypeName("#define UTC_E_FILTER_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C51049L)")]
        public const int UTC_E_FILTER_VERSION_MISMATCH = unchecked((int)(0x87C51049));

        [NativeTypeName("#define UTC_E_FILTER_INVALID_FUNCTION _HRESULT_TYPEDEF_(0x87C51050L)")]
        public const int UTC_E_FILTER_INVALID_FUNCTION = unchecked((int)(0x87C51050));

        [NativeTypeName("#define UTC_E_FILTER_INVALID_FUNCTION_PARAMS _HRESULT_TYPEDEF_(0x87C51051L)")]
        public const int UTC_E_FILTER_INVALID_FUNCTION_PARAMS = unchecked((int)(0x87C51051));

        [NativeTypeName("#define UTC_E_FILTER_INVALID_COMMAND _HRESULT_TYPEDEF_(0x87C51052L)")]
        public const int UTC_E_FILTER_INVALID_COMMAND = unchecked((int)(0x87C51052));

        [NativeTypeName("#define UTC_E_FILTER_ILLEGAL_EVAL _HRESULT_TYPEDEF_(0x87C51053L)")]
        public const int UTC_E_FILTER_ILLEGAL_EVAL = unchecked((int)(0x87C51053));

        [NativeTypeName("#define UTC_E_TTTRACER_RETURNED_ERROR _HRESULT_TYPEDEF_(0x87C51054L)")]
        public const int UTC_E_TTTRACER_RETURNED_ERROR = unchecked((int)(0x87C51054));

        [NativeTypeName("#define UTC_E_AGENT_DIAGNOSTICS_TOO_LARGE _HRESULT_TYPEDEF_(0x87C51055L)")]
        public const int UTC_E_AGENT_DIAGNOSTICS_TOO_LARGE = unchecked((int)(0x87C51055));

        [NativeTypeName("#define UTC_E_FAILED_TO_RECEIVE_AGENT_DIAGNOSTICS _HRESULT_TYPEDEF_(0x87C51056L)")]
        public const int UTC_E_FAILED_TO_RECEIVE_AGENT_DIAGNOSTICS = unchecked((int)(0x87C51056));

        [NativeTypeName("#define UTC_E_SCENARIO_HAS_NO_ACTIONS _HRESULT_TYPEDEF_(0x87C51057L)")]
        public const int UTC_E_SCENARIO_HAS_NO_ACTIONS = unchecked((int)(0x87C51057));

        [NativeTypeName("#define UTC_E_TTTRACER_STORAGE_FULL _HRESULT_TYPEDEF_(0x87C51058L)")]
        public const int UTC_E_TTTRACER_STORAGE_FULL = unchecked((int)(0x87C51058));

        [NativeTypeName("#define UTC_E_INSUFFICIENT_SPACE_TO_START_TRACE _HRESULT_TYPEDEF_(0x87C51059L)")]
        public const int UTC_E_INSUFFICIENT_SPACE_TO_START_TRACE = unchecked((int)(0x87C51059));

        [NativeTypeName("#define UTC_E_ESCALATION_CANCELLED_AT_SHUTDOWN _HRESULT_TYPEDEF_(0x87C5105AL)")]
        public const int UTC_E_ESCALATION_CANCELLED_AT_SHUTDOWN = unchecked((int)(0x87C5105A));

        [NativeTypeName("#define UTC_E_GETFILEINFOACTION_FILE_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5105BL)")]
        public const int UTC_E_GETFILEINFOACTION_FILE_NOT_APPROVED = unchecked((int)(0x87C5105B));

        [NativeTypeName("#define UTC_E_SETREGKEYACTION_TYPE_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5105CL)")]
        public const int UTC_E_SETREGKEYACTION_TYPE_NOT_APPROVED = unchecked((int)(0x87C5105C));

        [NativeTypeName("#define UTC_E_TRACE_THROTTLED _HRESULT_TYPEDEF_(0x87C5105DL)")]
        public const int UTC_E_TRACE_THROTTLED = unchecked((int)(0x87C5105D));

        [NativeTypeName("#define WINML_ERR_INVALID_DEVICE _HRESULT_TYPEDEF_(0x88900001L)")]
        public const int WINML_ERR_INVALID_DEVICE = unchecked((int)(0x88900001));

        [NativeTypeName("#define WINML_ERR_INVALID_BINDING _HRESULT_TYPEDEF_(0x88900002L)")]
        public const int WINML_ERR_INVALID_BINDING = unchecked((int)(0x88900002));

        [NativeTypeName("#define WINML_ERR_VALUE_NOTFOUND _HRESULT_TYPEDEF_(0x88900003L)")]
        public const int WINML_ERR_VALUE_NOTFOUND = unchecked((int)(0x88900003));

        [NativeTypeName("#define WINML_ERR_SIZE_MISMATCH _HRESULT_TYPEDEF_(0x88900004L)")]
        public const int WINML_ERR_SIZE_MISMATCH = unchecked((int)(0x88900004));
    }
}
