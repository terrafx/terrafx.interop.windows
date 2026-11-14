// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HRESULT_FROM_WIN32"]/*' />
    public static HRESULT HRESULT_FROM_WIN32([NativeTypeName("unsigned long")] uint x)
    {
        return (HRESULT)(x) <= 0 ? (HRESULT)(x) : (HRESULT)(((x) & 0x0000FFFF) | (7 << 16) | 0x80000000);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NO_ERROR"]/*' />
    [NativeTypeName("#define NO_ERROR 0L")]
    public const int NO_ERROR = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EPT_S_INVALID_ENTRY"]/*' />
    [NativeTypeName("#define EPT_S_INVALID_ENTRY 1751L")]
    public const int EPT_S_INVALID_ENTRY = 1751;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EPT_S_CANT_PERFORM_OP"]/*' />
    [NativeTypeName("#define EPT_S_CANT_PERFORM_OP 1752L")]
    public const int EPT_S_CANT_PERFORM_OP = 1752;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EPT_S_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define EPT_S_NOT_REGISTERED 1753L")]
    public const int EPT_S_NOT_REGISTERED = 1753;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EPT_S_CANT_CREATE"]/*' />
    [NativeTypeName("#define EPT_S_CANT_CREATE 1899L")]
    public const int EPT_S_CANT_CREATE = 1899;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OR_INVALID_OXID"]/*' />
    [NativeTypeName("#define OR_INVALID_OXID 1910L")]
    public const int OR_INVALID_OXID = 1910;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OR_INVALID_OID"]/*' />
    [NativeTypeName("#define OR_INVALID_OID 1911L")]
    public const int OR_INVALID_OID = 1911;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OR_INVALID_SET"]/*' />
    [NativeTypeName("#define OR_INVALID_SET 1912L")]
    public const int OR_INVALID_SET = 1912;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSABASEERR"]/*' />
    [NativeTypeName("#define WSABASEERR 10000")]
    public const int WSABASEERR = 10000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEINTR"]/*' />
    [NativeTypeName("#define WSAEINTR 10004L")]
    public const int WSAEINTR = 10004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEBADF"]/*' />
    [NativeTypeName("#define WSAEBADF 10009L")]
    public const int WSAEBADF = 10009;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEACCES"]/*' />
    [NativeTypeName("#define WSAEACCES 10013L")]
    public const int WSAEACCES = 10013;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEFAULT"]/*' />
    [NativeTypeName("#define WSAEFAULT 10014L")]
    public const int WSAEFAULT = 10014;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEINVAL"]/*' />
    [NativeTypeName("#define WSAEINVAL 10022L")]
    public const int WSAEINVAL = 10022;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEMFILE"]/*' />
    [NativeTypeName("#define WSAEMFILE 10024L")]
    public const int WSAEMFILE = 10024;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEWOULDBLOCK"]/*' />
    [NativeTypeName("#define WSAEWOULDBLOCK 10035L")]
    public const int WSAEWOULDBLOCK = 10035;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEINPROGRESS"]/*' />
    [NativeTypeName("#define WSAEINPROGRESS 10036L")]
    public const int WSAEINPROGRESS = 10036;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEALREADY"]/*' />
    [NativeTypeName("#define WSAEALREADY 10037L")]
    public const int WSAEALREADY = 10037;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOTSOCK"]/*' />
    [NativeTypeName("#define WSAENOTSOCK 10038L")]
    public const int WSAENOTSOCK = 10038;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEDESTADDRREQ"]/*' />
    [NativeTypeName("#define WSAEDESTADDRREQ 10039L")]
    public const int WSAEDESTADDRREQ = 10039;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEMSGSIZE"]/*' />
    [NativeTypeName("#define WSAEMSGSIZE 10040L")]
    public const int WSAEMSGSIZE = 10040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEPROTOTYPE"]/*' />
    [NativeTypeName("#define WSAEPROTOTYPE 10041L")]
    public const int WSAEPROTOTYPE = 10041;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOPROTOOPT"]/*' />
    [NativeTypeName("#define WSAENOPROTOOPT 10042L")]
    public const int WSAENOPROTOOPT = 10042;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEPROTONOSUPPORT"]/*' />
    [NativeTypeName("#define WSAEPROTONOSUPPORT 10043L")]
    public const int WSAEPROTONOSUPPORT = 10043;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAESOCKTNOSUPPORT"]/*' />
    [NativeTypeName("#define WSAESOCKTNOSUPPORT 10044L")]
    public const int WSAESOCKTNOSUPPORT = 10044;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEOPNOTSUPP"]/*' />
    [NativeTypeName("#define WSAEOPNOTSUPP 10045L")]
    public const int WSAEOPNOTSUPP = 10045;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEPFNOSUPPORT"]/*' />
    [NativeTypeName("#define WSAEPFNOSUPPORT 10046L")]
    public const int WSAEPFNOSUPPORT = 10046;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEAFNOSUPPORT"]/*' />
    [NativeTypeName("#define WSAEAFNOSUPPORT 10047L")]
    public const int WSAEAFNOSUPPORT = 10047;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEADDRINUSE"]/*' />
    [NativeTypeName("#define WSAEADDRINUSE 10048L")]
    public const int WSAEADDRINUSE = 10048;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEADDRNOTAVAIL"]/*' />
    [NativeTypeName("#define WSAEADDRNOTAVAIL 10049L")]
    public const int WSAEADDRNOTAVAIL = 10049;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENETDOWN"]/*' />
    [NativeTypeName("#define WSAENETDOWN 10050L")]
    public const int WSAENETDOWN = 10050;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENETUNREACH"]/*' />
    [NativeTypeName("#define WSAENETUNREACH 10051L")]
    public const int WSAENETUNREACH = 10051;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENETRESET"]/*' />
    [NativeTypeName("#define WSAENETRESET 10052L")]
    public const int WSAENETRESET = 10052;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAECONNABORTED"]/*' />
    [NativeTypeName("#define WSAECONNABORTED 10053L")]
    public const int WSAECONNABORTED = 10053;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAECONNRESET"]/*' />
    [NativeTypeName("#define WSAECONNRESET 10054L")]
    public const int WSAECONNRESET = 10054;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOBUFS"]/*' />
    [NativeTypeName("#define WSAENOBUFS 10055L")]
    public const int WSAENOBUFS = 10055;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEISCONN"]/*' />
    [NativeTypeName("#define WSAEISCONN 10056L")]
    public const int WSAEISCONN = 10056;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOTCONN"]/*' />
    [NativeTypeName("#define WSAENOTCONN 10057L")]
    public const int WSAENOTCONN = 10057;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAESHUTDOWN"]/*' />
    [NativeTypeName("#define WSAESHUTDOWN 10058L")]
    public const int WSAESHUTDOWN = 10058;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAETOOMANYREFS"]/*' />
    [NativeTypeName("#define WSAETOOMANYREFS 10059L")]
    public const int WSAETOOMANYREFS = 10059;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAETIMEDOUT"]/*' />
    [NativeTypeName("#define WSAETIMEDOUT 10060L")]
    public const int WSAETIMEDOUT = 10060;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAECONNREFUSED"]/*' />
    [NativeTypeName("#define WSAECONNREFUSED 10061L")]
    public const int WSAECONNREFUSED = 10061;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAELOOP"]/*' />
    [NativeTypeName("#define WSAELOOP 10062L")]
    public const int WSAELOOP = 10062;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENAMETOOLONG"]/*' />
    [NativeTypeName("#define WSAENAMETOOLONG 10063L")]
    public const int WSAENAMETOOLONG = 10063;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEHOSTDOWN"]/*' />
    [NativeTypeName("#define WSAEHOSTDOWN 10064L")]
    public const int WSAEHOSTDOWN = 10064;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEHOSTUNREACH"]/*' />
    [NativeTypeName("#define WSAEHOSTUNREACH 10065L")]
    public const int WSAEHOSTUNREACH = 10065;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOTEMPTY"]/*' />
    [NativeTypeName("#define WSAENOTEMPTY 10066L")]
    public const int WSAENOTEMPTY = 10066;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEPROCLIM"]/*' />
    [NativeTypeName("#define WSAEPROCLIM 10067L")]
    public const int WSAEPROCLIM = 10067;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEUSERS"]/*' />
    [NativeTypeName("#define WSAEUSERS 10068L")]
    public const int WSAEUSERS = 10068;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEDQUOT"]/*' />
    [NativeTypeName("#define WSAEDQUOT 10069L")]
    public const int WSAEDQUOT = 10069;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAESTALE"]/*' />
    [NativeTypeName("#define WSAESTALE 10070L")]
    public const int WSAESTALE = 10070;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEREMOTE"]/*' />
    [NativeTypeName("#define WSAEREMOTE 10071L")]
    public const int WSAEREMOTE = 10071;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSASYSNOTREADY"]/*' />
    [NativeTypeName("#define WSASYSNOTREADY 10091L")]
    public const int WSASYSNOTREADY = 10091;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAVERNOTSUPPORTED"]/*' />
    [NativeTypeName("#define WSAVERNOTSUPPORTED 10092L")]
    public const int WSAVERNOTSUPPORTED = 10092;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSANOTINITIALISED"]/*' />
    [NativeTypeName("#define WSANOTINITIALISED 10093L")]
    public const int WSANOTINITIALISED = 10093;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEDISCON"]/*' />
    [NativeTypeName("#define WSAEDISCON 10101L")]
    public const int WSAEDISCON = 10101;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAENOMORE"]/*' />
    [NativeTypeName("#define WSAENOMORE 10102L")]
    public const int WSAENOMORE = 10102;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAECANCELLED"]/*' />
    [NativeTypeName("#define WSAECANCELLED 10103L")]
    public const int WSAECANCELLED = 10103;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEINVALIDPROCTABLE"]/*' />
    [NativeTypeName("#define WSAEINVALIDPROCTABLE 10104L")]
    public const int WSAEINVALIDPROCTABLE = 10104;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEINVALIDPROVIDER"]/*' />
    [NativeTypeName("#define WSAEINVALIDPROVIDER 10105L")]
    public const int WSAEINVALIDPROVIDER = 10105;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEPROVIDERFAILEDINIT"]/*' />
    [NativeTypeName("#define WSAEPROVIDERFAILEDINIT 10106L")]
    public const int WSAEPROVIDERFAILEDINIT = 10106;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSASYSCALLFAILURE"]/*' />
    [NativeTypeName("#define WSASYSCALLFAILURE 10107L")]
    public const int WSASYSCALLFAILURE = 10107;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSASERVICE_NOT_FOUND"]/*' />
    [NativeTypeName("#define WSASERVICE_NOT_FOUND 10108L")]
    public const int WSASERVICE_NOT_FOUND = 10108;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSATYPE_NOT_FOUND"]/*' />
    [NativeTypeName("#define WSATYPE_NOT_FOUND 10109L")]
    public const int WSATYPE_NOT_FOUND = 10109;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAEREFUSED"]/*' />
    [NativeTypeName("#define WSAEREFUSED 10112L")]
    public const int WSAEREFUSED = 10112;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSAHOST_NOT_FOUND"]/*' />
    [NativeTypeName("#define WSAHOST_NOT_FOUND 11001L")]
    public const int WSAHOST_NOT_FOUND = 11001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSATRY_AGAIN"]/*' />
    [NativeTypeName("#define WSATRY_AGAIN 11002L")]
    public const int WSATRY_AGAIN = 11002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSANO_RECOVERY"]/*' />
    [NativeTypeName("#define WSANO_RECOVERY 11003L")]
    public const int WSANO_RECOVERY = 11003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WSANO_DATA"]/*' />
    [NativeTypeName("#define WSANO_DATA 11004L")]
    public const int WSANO_DATA = 11004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WARNING_IPSEC_MM_POLICY_PRUNED"]/*' />
    [NativeTypeName("#define WARNING_IPSEC_MM_POLICY_PRUNED 13024L")]
    public const int WARNING_IPSEC_MM_POLICY_PRUNED = 13024;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WARNING_IPSEC_QM_POLICY_PRUNED"]/*' />
    [NativeTypeName("#define WARNING_IPSEC_QM_POLICY_PRUNED 13025L")]
    public const int WARNING_IPSEC_QM_POLICY_PRUNED = 13025;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_NO_PACKAGE"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_NO_PACKAGE 15700L")]
    public const int APPMODEL_ERROR_NO_PACKAGE = 15700;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT 15701L")]
    public const int APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT 15702L")]
    public const int APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_NO_APPLICATION"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_NO_APPLICATION 15703L")]
    public const int APPMODEL_ERROR_NO_APPLICATION = 15703;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED 15704L")]
    public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED = 15704;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID 15705L")]
    public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID = 15705;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE 15706L")]
    public const int APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE = 15706;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPMODEL_ERROR_NO_MUTABLE_DIRECTORY"]/*' />
    [NativeTypeName("#define APPMODEL_ERROR_NO_MUTABLE_DIRECTORY 15707L")]
    public const int APPMODEL_ERROR_NO_MUTABLE_DIRECTORY = 15707;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORE_ERROR_UNLICENSED"]/*' />
    [NativeTypeName("#define STORE_ERROR_UNLICENSED 15861L")]
    public const int STORE_ERROR_UNLICENSED = 15861;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORE_ERROR_UNLICENSED_USER"]/*' />
    [NativeTypeName("#define STORE_ERROR_UNLICENSED_USER 15862L")]
    public const int STORE_ERROR_UNLICENSED_USER = 15862;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORE_ERROR_PENDING_COM_TRANSACTION"]/*' />
    [NativeTypeName("#define STORE_ERROR_PENDING_COM_TRANSACTION 15863L")]
    public const int STORE_ERROR_PENDING_COM_TRANSACTION = 15863;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORE_ERROR_LICENSE_REVOKED"]/*' />
    [NativeTypeName("#define STORE_ERROR_LICENSE_REVOKED 15864L")]
    public const int STORE_ERROR_LICENSE_REVOKED = 15864;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SEVERITY_SUCCESS"]/*' />
    [NativeTypeName("#define SEVERITY_SUCCESS 0")]
    public const int SEVERITY_SUCCESS = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SEVERITY_ERROR"]/*' />
    [NativeTypeName("#define SEVERITY_ERROR 1")]
    public const int SEVERITY_ERROR = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOERROR"]/*' />
    [NativeTypeName("#define NOERROR 0")]
    public const int NOERROR = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASSFACTORY_E_FIRST"]/*' />
    [NativeTypeName("#define CLASSFACTORY_E_FIRST 0x80040110L")]
    public const uint CLASSFACTORY_E_FIRST = 0x80040110;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASSFACTORY_E_LAST"]/*' />
    [NativeTypeName("#define CLASSFACTORY_E_LAST 0x8004011FL")]
    public const uint CLASSFACTORY_E_LAST = 0x8004011F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASSFACTORY_S_FIRST"]/*' />
    [NativeTypeName("#define CLASSFACTORY_S_FIRST 0x00040110L")]
    public const int CLASSFACTORY_S_FIRST = 0x00040110;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASSFACTORY_S_LAST"]/*' />
    [NativeTypeName("#define CLASSFACTORY_S_LAST 0x0004011FL")]
    public const int CLASSFACTORY_S_LAST = 0x0004011F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASS_E_NOAGGREGATION"]/*' />
    [NativeTypeName("#define CLASS_E_NOAGGREGATION _HRESULT_TYPEDEF_(0x80040110L)")]
    public const int CLASS_E_NOAGGREGATION = unchecked((int)(0x80040110));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASS_E_CLASSNOTAVAILABLE"]/*' />
    [NativeTypeName("#define CLASS_E_CLASSNOTAVAILABLE _HRESULT_TYPEDEF_(0x80040111L)")]
    public const int CLASS_E_CLASSNOTAVAILABLE = unchecked((int)(0x80040111));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLASS_E_NOTLICENSED"]/*' />
    [NativeTypeName("#define CLASS_E_NOTLICENSED _HRESULT_TYPEDEF_(0x80040112L)")]
    public const int CLASS_E_NOTLICENSED = unchecked((int)(0x80040112));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MARSHAL_E_FIRST"]/*' />
    [NativeTypeName("#define MARSHAL_E_FIRST 0x80040120L")]
    public const uint MARSHAL_E_FIRST = 0x80040120;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MARSHAL_E_LAST"]/*' />
    [NativeTypeName("#define MARSHAL_E_LAST 0x8004012FL")]
    public const uint MARSHAL_E_LAST = 0x8004012F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MARSHAL_S_FIRST"]/*' />
    [NativeTypeName("#define MARSHAL_S_FIRST 0x00040120L")]
    public const int MARSHAL_S_FIRST = 0x00040120;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MARSHAL_S_LAST"]/*' />
    [NativeTypeName("#define MARSHAL_S_LAST 0x0004012FL")]
    public const int MARSHAL_S_LAST = 0x0004012F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATA_E_FIRST"]/*' />
    [NativeTypeName("#define DATA_E_FIRST 0x80040130L")]
    public const uint DATA_E_FIRST = 0x80040130;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATA_E_LAST"]/*' />
    [NativeTypeName("#define DATA_E_LAST 0x8004013FL")]
    public const uint DATA_E_LAST = 0x8004013F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATA_S_FIRST"]/*' />
    [NativeTypeName("#define DATA_S_FIRST 0x00040130L")]
    public const int DATA_S_FIRST = 0x00040130;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATA_S_LAST"]/*' />
    [NativeTypeName("#define DATA_S_LAST 0x0004013FL")]
    public const int DATA_S_LAST = 0x0004013F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_E_FIRST"]/*' />
    [NativeTypeName("#define CACHE_E_FIRST 0x80040170L")]
    public const uint CACHE_E_FIRST = 0x80040170;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_E_LAST"]/*' />
    [NativeTypeName("#define CACHE_E_LAST 0x8004017FL")]
    public const uint CACHE_E_LAST = 0x8004017F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_S_FIRST"]/*' />
    [NativeTypeName("#define CACHE_S_FIRST 0x00040170L")]
    public const int CACHE_S_FIRST = 0x00040170;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_S_LAST"]/*' />
    [NativeTypeName("#define CACHE_S_LAST 0x0004017FL")]
    public const int CACHE_S_LAST = 0x0004017F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_E_NOCACHE_UPDATED"]/*' />
    [NativeTypeName("#define CACHE_E_NOCACHE_UPDATED _HRESULT_TYPEDEF_(0x80040170L)")]
    public const int CACHE_E_NOCACHE_UPDATED = unchecked((int)(0x80040170));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_E_FIRST"]/*' />
    [NativeTypeName("#define OLEOBJ_E_FIRST 0x80040180L")]
    public const uint OLEOBJ_E_FIRST = 0x80040180;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_E_LAST"]/*' />
    [NativeTypeName("#define OLEOBJ_E_LAST 0x8004018FL")]
    public const uint OLEOBJ_E_LAST = 0x8004018F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_S_FIRST"]/*' />
    [NativeTypeName("#define OLEOBJ_S_FIRST 0x00040180L")]
    public const int OLEOBJ_S_FIRST = 0x00040180;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_S_LAST"]/*' />
    [NativeTypeName("#define OLEOBJ_S_LAST 0x0004018FL")]
    public const int OLEOBJ_S_LAST = 0x0004018F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_E_NOVERBS"]/*' />
    [NativeTypeName("#define OLEOBJ_E_NOVERBS _HRESULT_TYPEDEF_(0x80040180L)")]
    public const int OLEOBJ_E_NOVERBS = unchecked((int)(0x80040180));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_E_INVALIDVERB"]/*' />
    [NativeTypeName("#define OLEOBJ_E_INVALIDVERB _HRESULT_TYPEDEF_(0x80040181L)")]
    public const int OLEOBJ_E_INVALIDVERB = unchecked((int)(0x80040181));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIENTSITE_E_FIRST"]/*' />
    [NativeTypeName("#define CLIENTSITE_E_FIRST 0x80040190L")]
    public const uint CLIENTSITE_E_FIRST = 0x80040190;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIENTSITE_E_LAST"]/*' />
    [NativeTypeName("#define CLIENTSITE_E_LAST 0x8004019FL")]
    public const uint CLIENTSITE_E_LAST = 0x8004019F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIENTSITE_S_FIRST"]/*' />
    [NativeTypeName("#define CLIENTSITE_S_FIRST 0x00040190L")]
    public const int CLIENTSITE_S_FIRST = 0x00040190;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIENTSITE_S_LAST"]/*' />
    [NativeTypeName("#define CLIENTSITE_S_LAST 0x0004019FL")]
    public const int CLIENTSITE_S_LAST = 0x0004019F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_E_NOTUNDOABLE"]/*' />
    [NativeTypeName("#define INPLACE_E_NOTUNDOABLE _HRESULT_TYPEDEF_(0x800401A0L)")]
    public const int INPLACE_E_NOTUNDOABLE = unchecked((int)(0x800401A0));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_E_NOTOOLSPACE"]/*' />
    [NativeTypeName("#define INPLACE_E_NOTOOLSPACE _HRESULT_TYPEDEF_(0x800401A1L)")]
    public const int INPLACE_E_NOTOOLSPACE = unchecked((int)(0x800401A1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_E_FIRST"]/*' />
    [NativeTypeName("#define INPLACE_E_FIRST 0x800401A0L")]
    public const uint INPLACE_E_FIRST = 0x800401A0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_E_LAST"]/*' />
    [NativeTypeName("#define INPLACE_E_LAST 0x800401AFL")]
    public const uint INPLACE_E_LAST = 0x800401AF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_S_FIRST"]/*' />
    [NativeTypeName("#define INPLACE_S_FIRST 0x000401A0L")]
    public const int INPLACE_S_FIRST = 0x000401A0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_S_LAST"]/*' />
    [NativeTypeName("#define INPLACE_S_LAST 0x000401AFL")]
    public const int INPLACE_S_LAST = 0x000401AF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_FIRST"]/*' />
    [NativeTypeName("#define CLIPBRD_E_FIRST 0x800401D0L")]
    public const uint CLIPBRD_E_FIRST = 0x800401D0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_LAST"]/*' />
    [NativeTypeName("#define CLIPBRD_E_LAST 0x800401DFL")]
    public const uint CLIPBRD_E_LAST = 0x800401DF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_S_FIRST"]/*' />
    [NativeTypeName("#define CLIPBRD_S_FIRST 0x000401D0L")]
    public const int CLIPBRD_S_FIRST = 0x000401D0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_S_LAST"]/*' />
    [NativeTypeName("#define CLIPBRD_S_LAST 0x000401DFL")]
    public const int CLIPBRD_S_LAST = 0x000401DF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_CANT_OPEN"]/*' />
    [NativeTypeName("#define CLIPBRD_E_CANT_OPEN _HRESULT_TYPEDEF_(0x800401D0L)")]
    public const int CLIPBRD_E_CANT_OPEN = unchecked((int)(0x800401D0));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_CANT_EMPTY"]/*' />
    [NativeTypeName("#define CLIPBRD_E_CANT_EMPTY _HRESULT_TYPEDEF_(0x800401D1L)")]
    public const int CLIPBRD_E_CANT_EMPTY = unchecked((int)(0x800401D1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_CANT_SET"]/*' />
    [NativeTypeName("#define CLIPBRD_E_CANT_SET _HRESULT_TYPEDEF_(0x800401D2L)")]
    public const int CLIPBRD_E_CANT_SET = unchecked((int)(0x800401D2));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_BAD_DATA"]/*' />
    [NativeTypeName("#define CLIPBRD_E_BAD_DATA _HRESULT_TYPEDEF_(0x800401D3L)")]
    public const int CLIPBRD_E_BAD_DATA = unchecked((int)(0x800401D3));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLIPBRD_E_CANT_CLOSE"]/*' />
    [NativeTypeName("#define CLIPBRD_E_CANT_CLOSE _HRESULT_TYPEDEF_(0x800401D4L)")]
    public const int CLIPBRD_E_CANT_CLOSE = unchecked((int)(0x800401D4));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATA_S_SAMEFORMATETC"]/*' />
    [NativeTypeName("#define DATA_S_SAMEFORMATETC _HRESULT_TYPEDEF_(0x00040130L)")]
    public const int DATA_S_SAMEFORMATETC = ((int)(0x00040130));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_S_FORMATETC_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define CACHE_S_FORMATETC_NOTSUPPORTED _HRESULT_TYPEDEF_(0x00040170L)")]
    public const int CACHE_S_FORMATETC_NOTSUPPORTED = ((int)(0x00040170));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_S_SAMECACHE"]/*' />
    [NativeTypeName("#define CACHE_S_SAMECACHE _HRESULT_TYPEDEF_(0x00040171L)")]
    public const int CACHE_S_SAMECACHE = ((int)(0x00040171));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_S_SOMECACHES_NOTUPDATED"]/*' />
    [NativeTypeName("#define CACHE_S_SOMECACHES_NOTUPDATED _HRESULT_TYPEDEF_(0x00040172L)")]
    public const int CACHE_S_SOMECACHES_NOTUPDATED = ((int)(0x00040172));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_S_INVALIDVERB"]/*' />
    [NativeTypeName("#define OLEOBJ_S_INVALIDVERB _HRESULT_TYPEDEF_(0x00040180L)")]
    public const int OLEOBJ_S_INVALIDVERB = ((int)(0x00040180));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_S_CANNOT_DOVERB_NOW"]/*' />
    [NativeTypeName("#define OLEOBJ_S_CANNOT_DOVERB_NOW _HRESULT_TYPEDEF_(0x00040181L)")]
    public const int OLEOBJ_S_CANNOT_DOVERB_NOW = ((int)(0x00040181));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OLEOBJ_S_INVALIDHWND"]/*' />
    [NativeTypeName("#define OLEOBJ_S_INVALIDHWND _HRESULT_TYPEDEF_(0x00040182L)")]
    public const int OLEOBJ_S_INVALIDHWND = ((int)(0x00040182));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INPLACE_S_TRUNCATED"]/*' />
    [NativeTypeName("#define INPLACE_S_TRUNCATED _HRESULT_TYPEDEF_(0x000401A0L)")]
    public const int INPLACE_S_TRUNCATED = ((int)(0x000401A0));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BT_E_SPURIOUS_ACTIVATION"]/*' />
    [NativeTypeName("#define BT_E_SPURIOUS_ACTIVATION _HRESULT_TYPEDEF_(0x80080300L)")]
    public const int BT_E_SPURIOUS_ACTIVATION = unchecked((int)(0x80080300));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_KEY_NOT_EXPORTABLE"]/*' />
    [NativeTypeName("#define XENROLL_E_KEY_NOT_EXPORTABLE _HRESULT_TYPEDEF_(0x80095000L)")]
    public const int XENROLL_E_KEY_NOT_EXPORTABLE = unchecked((int)(0x80095000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_CANNOT_ADD_ROOT_CERT"]/*' />
    [NativeTypeName("#define XENROLL_E_CANNOT_ADD_ROOT_CERT _HRESULT_TYPEDEF_(0x80095001L)")]
    public const int XENROLL_E_CANNOT_ADD_ROOT_CERT = unchecked((int)(0x80095001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND"]/*' />
    [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND _HRESULT_TYPEDEF_(0x80095002L)")]
    public const int XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = unchecked((int)(0x80095002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH"]/*' />
    [NativeTypeName("#define XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH _HRESULT_TYPEDEF_(0x80095003L)")]
    public const int XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = unchecked((int)(0x80095003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_RESPONSE_KA_HASH_MISMATCH"]/*' />
    [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_MISMATCH _HRESULT_TYPEDEF_(0x80095004L)")]
    public const int XENROLL_E_RESPONSE_KA_HASH_MISMATCH = unchecked((int)(0x80095004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.XENROLL_E_KEYSPEC_SMIME_MISMATCH"]/*' />
    [NativeTypeName("#define XENROLL_E_KEYSPEC_SMIME_MISMATCH _HRESULT_TYPEDEF_(0x80095005L)")]
    public const int XENROLL_E_KEYSPEC_SMIME_MISMATCH = unchecked((int)(0x80095005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIGSIG_E_ENCODE"]/*' />
    [NativeTypeName("#define DIGSIG_E_ENCODE _HRESULT_TYPEDEF_(0x800B0005L)")]
    public const int DIGSIG_E_ENCODE = unchecked((int)(0x800B0005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIGSIG_E_DECODE"]/*' />
    [NativeTypeName("#define DIGSIG_E_DECODE _HRESULT_TYPEDEF_(0x800B0006L)")]
    public const int DIGSIG_E_DECODE = unchecked((int)(0x800B0006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIGSIG_E_EXTENSIBILITY"]/*' />
    [NativeTypeName("#define DIGSIG_E_EXTENSIBILITY _HRESULT_TYPEDEF_(0x800B0007L)")]
    public const int DIGSIG_E_EXTENSIBILITY = unchecked((int)(0x800B0007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIGSIG_E_CRYPTO"]/*' />
    [NativeTypeName("#define DIGSIG_E_CRYPTO _HRESULT_TYPEDEF_(0x800B0008L)")]
    public const int DIGSIG_E_CRYPTO = unchecked((int)(0x800B0008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERSIST_E_SIZEDEFINITE"]/*' />
    [NativeTypeName("#define PERSIST_E_SIZEDEFINITE _HRESULT_TYPEDEF_(0x800B0009L)")]
    public const int PERSIST_E_SIZEDEFINITE = unchecked((int)(0x800B0009));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERSIST_E_SIZEINDEFINITE"]/*' />
    [NativeTypeName("#define PERSIST_E_SIZEINDEFINITE _HRESULT_TYPEDEF_(0x800B000AL)")]
    public const int PERSIST_E_SIZEINDEFINITE = unchecked((int)(0x800B000A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERSIST_E_NOTSELFSIZING"]/*' />
    [NativeTypeName("#define PERSIST_E_NOTSELFSIZING _HRESULT_TYPEDEF_(0x800B000BL)")]
    public const int PERSIST_E_NOTSELFSIZING = unchecked((int)(0x800B000B));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_APPLICATION_NOT_QUEUED"]/*' />
    [NativeTypeName("#define COMQC_E_APPLICATION_NOT_QUEUED _HRESULT_TYPEDEF_(0x80110600L)")]
    public const int COMQC_E_APPLICATION_NOT_QUEUED = unchecked((int)(0x80110600));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_NO_QUEUEABLE_INTERFACES"]/*' />
    [NativeTypeName("#define COMQC_E_NO_QUEUEABLE_INTERFACES _HRESULT_TYPEDEF_(0x80110601L)")]
    public const int COMQC_E_NO_QUEUEABLE_INTERFACES = unchecked((int)(0x80110601));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80110602L)")]
    public const int COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80110602));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_NO_IPERSISTSTREAM"]/*' />
    [NativeTypeName("#define COMQC_E_NO_IPERSISTSTREAM _HRESULT_TYPEDEF_(0x80110603L)")]
    public const int COMQC_E_NO_IPERSISTSTREAM = unchecked((int)(0x80110603));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_BAD_MESSAGE"]/*' />
    [NativeTypeName("#define COMQC_E_BAD_MESSAGE _HRESULT_TYPEDEF_(0x80110604L)")]
    public const int COMQC_E_BAD_MESSAGE = unchecked((int)(0x80110604));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_UNAUTHENTICATED"]/*' />
    [NativeTypeName("#define COMQC_E_UNAUTHENTICATED _HRESULT_TYPEDEF_(0x80110605L)")]
    public const int COMQC_E_UNAUTHENTICATED = unchecked((int)(0x80110605));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMQC_E_UNTRUSTED_ENQUEUER"]/*' />
    [NativeTypeName("#define COMQC_E_UNTRUSTED_ENQUEUER _HRESULT_TYPEDEF_(0x80110606L)")]
    public const int COMQC_E_UNTRUSTED_ENQUEUER = unchecked((int)(0x80110606));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MSDTC_E_DUPLICATE_RESOURCE"]/*' />
    [NativeTypeName("#define MSDTC_E_DUPLICATE_RESOURCE _HRESULT_TYPEDEF_(0x80110701L)")]
    public const int MSDTC_E_DUPLICATE_RESOURCE = unchecked((int)(0x80110701));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRTM_E_ENVIRONMENT_UNSAFE"]/*' />
    [NativeTypeName("#define DRTM_E_ENVIRONMENT_UNSAFE _HRESULT_TYPEDEF_(0x80290501L)")]
    public const int DRTM_E_ENVIRONMENT_UNSAFE = unchecked((int)(0x80290501));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRTM_E_NO_DIRECT_AUTH_FOR_CURRENT_MLE"]/*' />
    [NativeTypeName("#define DRTM_E_NO_DIRECT_AUTH_FOR_CURRENT_MLE _HRESULT_TYPEDEF_(0x80290502L)")]
    public const int DRTM_E_NO_DIRECT_AUTH_FOR_CURRENT_MLE = unchecked((int)(0x80290502));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_MODULE_NOT_FOUND"]/*' />
    [NativeTypeName("#define GCN_E_MODULE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0021L)")]
    public const int GCN_E_MODULE_NOT_FOUND = unchecked((int)(0x803B0021));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_NO_REQUEST_HANDLERS"]/*' />
    [NativeTypeName("#define GCN_E_NO_REQUEST_HANDLERS _HRESULT_TYPEDEF_(0x803B0022L)")]
    public const int GCN_E_NO_REQUEST_HANDLERS = unchecked((int)(0x803B0022));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_REQUEST_UNSUPPORTED"]/*' />
    [NativeTypeName("#define GCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0023L)")]
    public const int GCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0023));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_RUNTIMEKEYS_FAILED"]/*' />
    [NativeTypeName("#define GCN_E_RUNTIMEKEYS_FAILED _HRESULT_TYPEDEF_(0x803B0024L)")]
    public const int GCN_E_RUNTIMEKEYS_FAILED = unchecked((int)(0x803B0024));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_NETADAPTER_TIMEOUT"]/*' />
    [NativeTypeName("#define GCN_E_NETADAPTER_TIMEOUT _HRESULT_TYPEDEF_(0x803B0025L)")]
    public const int GCN_E_NETADAPTER_TIMEOUT = unchecked((int)(0x803B0025));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_NETADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define GCN_E_NETADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0026L)")]
    public const int GCN_E_NETADAPTER_NOT_FOUND = unchecked((int)(0x803B0026));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_NETCOMPARTMENT_NOT_FOUND"]/*' />
    [NativeTypeName("#define GCN_E_NETCOMPARTMENT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0027L)")]
    public const int GCN_E_NETCOMPARTMENT_NOT_FOUND = unchecked((int)(0x803B0027));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_NETINTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define GCN_E_NETINTERFACE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0028L)")]
    public const int GCN_E_NETINTERFACE_NOT_FOUND = unchecked((int)(0x803B0028));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCN_E_DEFAULTNAMESPACE_EXISTS"]/*' />
    [NativeTypeName("#define GCN_E_DEFAULTNAMESPACE_EXISTS _HRESULT_TYPEDEF_(0x803B0029L)")]
    public const int GCN_E_DEFAULTNAMESPACE_EXISTS = unchecked((int)(0x803B0029));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80670011L)")]
    public const int STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED = unchecked((int)(0x80670011));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DXCORE_ERROR_EVENT_NOT_UNREGISTERED"]/*' />
    [NativeTypeName("#define DXCORE_ERROR_EVENT_NOT_UNREGISTERED _HRESULT_TYPEDEF_(0x88800001L)")]
    public const int DXCORE_ERROR_EVENT_NOT_UNREGISTERED = unchecked((int)(0x88800001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRESENTATION_ERROR_LOST"]/*' />
    [NativeTypeName("#define PRESENTATION_ERROR_LOST _HRESULT_TYPEDEF_(0x88810001L)")]
    public const int PRESENTATION_ERROR_LOST = unchecked((int)(0x88810001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWMERR_STATE_TRANSITION_FAILED"]/*' />
    [NativeTypeName("#define DWMERR_STATE_TRANSITION_FAILED _HRESULT_TYPEDEF_(0x88980700L)")]
    public const int DWMERR_STATE_TRANSITION_FAILED = unchecked((int)(0x88980700));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWMERR_THEME_FAILED"]/*' />
    [NativeTypeName("#define DWMERR_THEME_FAILED _HRESULT_TYPEDEF_(0x88980701L)")]
    public const int DWMERR_THEME_FAILED = unchecked((int)(0x88980701));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWMERR_CATASTROPHIC_FAILURE"]/*' />
    [NativeTypeName("#define DWMERR_CATASTROPHIC_FAILURE _HRESULT_TYPEDEF_(0x88980702L)")]
    public const int DWMERR_CATASTROPHIC_FAILURE = unchecked((int)(0x88980702));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FA_E_MAX_PERSISTED_ITEMS_REACHED"]/*' />
    [NativeTypeName("#define FA_E_MAX_PERSISTED_ITEMS_REACHED _HRESULT_TYPEDEF_(0x80270220L)")]
    public const int FA_E_MAX_PERSISTED_ITEMS_REACHED = unchecked((int)(0x80270220));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FA_E_HOMEGROUP_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define FA_E_HOMEGROUP_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80270222L)")]
    public const int FA_E_HOMEGROUP_NOT_AVAILABLE = unchecked((int)(0x80270222));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_UNSUPPORTED_FORMAT"]/*' />
    [NativeTypeName("#define WEB_E_UNSUPPORTED_FORMAT _HRESULT_TYPEDEF_(0x83750001L)")]
    public const int WEB_E_UNSUPPORTED_FORMAT = unchecked((int)(0x83750001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_INVALID_XML"]/*' />
    [NativeTypeName("#define WEB_E_INVALID_XML _HRESULT_TYPEDEF_(0x83750002L)")]
    public const int WEB_E_INVALID_XML = unchecked((int)(0x83750002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_MISSING_REQUIRED_ELEMENT"]/*' />
    [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ELEMENT _HRESULT_TYPEDEF_(0x83750003L)")]
    public const int WEB_E_MISSING_REQUIRED_ELEMENT = unchecked((int)(0x83750003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_MISSING_REQUIRED_ATTRIBUTE"]/*' />
    [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ATTRIBUTE _HRESULT_TYPEDEF_(0x83750004L)")]
    public const int WEB_E_MISSING_REQUIRED_ATTRIBUTE = unchecked((int)(0x83750004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_UNEXPECTED_CONTENT"]/*' />
    [NativeTypeName("#define WEB_E_UNEXPECTED_CONTENT _HRESULT_TYPEDEF_(0x83750005L)")]
    public const int WEB_E_UNEXPECTED_CONTENT = unchecked((int)(0x83750005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_RESOURCE_TOO_LARGE"]/*' />
    [NativeTypeName("#define WEB_E_RESOURCE_TOO_LARGE _HRESULT_TYPEDEF_(0x83750006L)")]
    public const int WEB_E_RESOURCE_TOO_LARGE = unchecked((int)(0x83750006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_INVALID_JSON_STRING"]/*' />
    [NativeTypeName("#define WEB_E_INVALID_JSON_STRING _HRESULT_TYPEDEF_(0x83750007L)")]
    public const int WEB_E_INVALID_JSON_STRING = unchecked((int)(0x83750007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_INVALID_JSON_NUMBER"]/*' />
    [NativeTypeName("#define WEB_E_INVALID_JSON_NUMBER _HRESULT_TYPEDEF_(0x83750008L)")]
    public const int WEB_E_INVALID_JSON_NUMBER = unchecked((int)(0x83750008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEB_E_JSON_VALUE_NOT_FOUND"]/*' />
    [NativeTypeName("#define WEB_E_JSON_VALUE_NOT_FOUND _HRESULT_TYPEDEF_(0x83750009L)")]
    public const int WEB_E_JSON_VALUE_NOT_FOUND = unchecked((int)(0x83750009));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_E_ERROR_MASK"]/*' />
    [NativeTypeName("#define HSP_E_ERROR_MASK _HRESULT_TYPEDEF_(0x81280000L)")]
    public const int HSP_E_ERROR_MASK = unchecked((int)(0x81280000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_E_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define HSP_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x81280FFFL)")]
    public const int HSP_E_INTERNAL_ERROR = unchecked((int)(0x81280FFF));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_BS_ERROR_MASK"]/*' />
    [NativeTypeName("#define HSP_BS_ERROR_MASK _HRESULT_TYPEDEF_(0x81281000L)")]
    public const int HSP_BS_ERROR_MASK = unchecked((int)(0x81281000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_BS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define HSP_BS_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812810FFL)")]
    public const int HSP_BS_INTERNAL_ERROR = unchecked((int)(0x812810FF));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_DRV_ERROR_MASK"]/*' />
    [NativeTypeName("#define HSP_DRV_ERROR_MASK _HRESULT_TYPEDEF_(0x81290000L)")]
    public const int HSP_DRV_ERROR_MASK = unchecked((int)(0x81290000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_DRV_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define HSP_DRV_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812900FFL)")]
    public const int HSP_DRV_INTERNAL_ERROR = unchecked((int)(0x812900FF));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_BASE_ERROR_MASK"]/*' />
    [NativeTypeName("#define HSP_BASE_ERROR_MASK _HRESULT_TYPEDEF_(0x81290100L)")]
    public const int HSP_BASE_ERROR_MASK = unchecked((int)(0x81290100));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_BASE_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define HSP_BASE_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812901FFL)")]
    public const int HSP_BASE_INTERNAL_ERROR = unchecked((int)(0x812901FF));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_ERROR_MASK"]/*' />
    [NativeTypeName("#define HSP_KSP_ERROR_MASK _HRESULT_TYPEDEF_(0x81290200L)")]
    public const int HSP_KSP_ERROR_MASK = unchecked((int)(0x81290200));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("#define HSP_KSP_DEVICE_NOT_READY _HRESULT_TYPEDEF_(0x81290201L)")]
    public const int HSP_KSP_DEVICE_NOT_READY = unchecked((int)(0x81290201));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_PROVIDER_HANDLE"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_PROVIDER_HANDLE _HRESULT_TYPEDEF_(0x81290202L)")]
    public const int HSP_KSP_INVALID_PROVIDER_HANDLE = unchecked((int)(0x81290202));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_KEY_HANDLE"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_KEY_HANDLE _HRESULT_TYPEDEF_(0x81290203L)")]
    public const int HSP_KSP_INVALID_KEY_HANDLE = unchecked((int)(0x81290203));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x81290204L)")]
    public const int HSP_KSP_INVALID_PARAMETER = unchecked((int)(0x81290204));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define HSP_KSP_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x81290205L)")]
    public const int HSP_KSP_BUFFER_TOO_SMALL = unchecked((int)(0x81290205));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define HSP_KSP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x81290206L)")]
    public const int HSP_KSP_NOT_SUPPORTED = unchecked((int)(0x81290206));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_DATA"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_DATA _HRESULT_TYPEDEF_(0x81290207L)")]
    public const int HSP_KSP_INVALID_DATA = unchecked((int)(0x81290207));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_FLAGS _HRESULT_TYPEDEF_(0x81290208L)")]
    public const int HSP_KSP_INVALID_FLAGS = unchecked((int)(0x81290208));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_ALGORITHM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define HSP_KSP_ALGORITHM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x81290209L)")]
    public const int HSP_KSP_ALGORITHM_NOT_SUPPORTED = unchecked((int)(0x81290209));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_KEY_ALREADY_FINALIZED"]/*' />
    [NativeTypeName("#define HSP_KSP_KEY_ALREADY_FINALIZED _HRESULT_TYPEDEF_(0x8129020AL)")]
    public const int HSP_KSP_KEY_ALREADY_FINALIZED = unchecked((int)(0x8129020A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_KEY_NOT_FINALIZED"]/*' />
    [NativeTypeName("#define HSP_KSP_KEY_NOT_FINALIZED _HRESULT_TYPEDEF_(0x8129020BL)")]
    public const int HSP_KSP_KEY_NOT_FINALIZED = unchecked((int)(0x8129020B));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INVALID_KEY_TYPE"]/*' />
    [NativeTypeName("#define HSP_KSP_INVALID_KEY_TYPE _HRESULT_TYPEDEF_(0x8129020CL)")]
    public const int HSP_KSP_INVALID_KEY_TYPE = unchecked((int)(0x8129020C));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_NO_MEMORY"]/*' />
    [NativeTypeName("#define HSP_KSP_NO_MEMORY _HRESULT_TYPEDEF_(0x81290210L)")]
    public const int HSP_KSP_NO_MEMORY = unchecked((int)(0x81290210));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_PARAMETER_NOT_SET"]/*' />
    [NativeTypeName("#define HSP_KSP_PARAMETER_NOT_SET _HRESULT_TYPEDEF_(0x81290211L)")]
    public const int HSP_KSP_PARAMETER_NOT_SET = unchecked((int)(0x81290211));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_KEY_EXISTS"]/*' />
    [NativeTypeName("#define HSP_KSP_KEY_EXISTS _HRESULT_TYPEDEF_(0x81290215L)")]
    public const int HSP_KSP_KEY_EXISTS = unchecked((int)(0x81290215));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_KEY_MISSING"]/*' />
    [NativeTypeName("#define HSP_KSP_KEY_MISSING _HRESULT_TYPEDEF_(0x81290216L)")]
    public const int HSP_KSP_KEY_MISSING = unchecked((int)(0x81290216));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_KEY_LOAD_FAIL"]/*' />
    [NativeTypeName("#define HSP_KSP_KEY_LOAD_FAIL _HRESULT_TYPEDEF_(0x81290217L)")]
    public const int HSP_KSP_KEY_LOAD_FAIL = unchecked((int)(0x81290217));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_NO_MORE_ITEMS"]/*' />
    [NativeTypeName("#define HSP_KSP_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x81290218L)")]
    public const int HSP_KSP_NO_MORE_ITEMS = unchecked((int)(0x81290218));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HSP_KSP_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define HSP_KSP_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812902FFL)")]
    public const int HSP_KSP_INTERNAL_ERROR = unchecked((int)(0x812902FF));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JSCRIPT_E_CANTEXECUTE"]/*' />
    [NativeTypeName("#define JSCRIPT_E_CANTEXECUTE _HRESULT_TYPEDEF_(0x89020001L)")]
    public const int JSCRIPT_E_CANTEXECUTE = unchecked((int)(0x89020001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES"]/*' />
    [NativeTypeName("#define WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES _HRESULT_TYPEDEF_(0x88010001L)")]
    public const int WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)(0x88010001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_FIXED_DATA_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define WEP_E_FIXED_DATA_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88010002L)")]
    public const int WEP_E_FIXED_DATA_NOT_SUPPORTED = unchecked((int)(0x88010002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_HARDWARE_NOT_COMPLIANT"]/*' />
    [NativeTypeName("#define WEP_E_HARDWARE_NOT_COMPLIANT _HRESULT_TYPEDEF_(0x88010003L)")]
    public const int WEP_E_HARDWARE_NOT_COMPLIANT = unchecked((int)(0x88010003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_LOCK_NOT_CONFIGURED"]/*' />
    [NativeTypeName("#define WEP_E_LOCK_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x88010004L)")]
    public const int WEP_E_LOCK_NOT_CONFIGURED = unchecked((int)(0x88010004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_PROTECTION_SUSPENDED"]/*' />
    [NativeTypeName("#define WEP_E_PROTECTION_SUSPENDED _HRESULT_TYPEDEF_(0x88010005L)")]
    public const int WEP_E_PROTECTION_SUSPENDED = unchecked((int)(0x88010005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_NO_LICENSE"]/*' />
    [NativeTypeName("#define WEP_E_NO_LICENSE _HRESULT_TYPEDEF_(0x88010006L)")]
    public const int WEP_E_NO_LICENSE = unchecked((int)(0x88010006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_OS_NOT_PROTECTED"]/*' />
    [NativeTypeName("#define WEP_E_OS_NOT_PROTECTED _HRESULT_TYPEDEF_(0x88010007L)")]
    public const int WEP_E_OS_NOT_PROTECTED = unchecked((int)(0x88010007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_UNEXPECTED_FAIL"]/*' />
    [NativeTypeName("#define WEP_E_UNEXPECTED_FAIL _HRESULT_TYPEDEF_(0x88010008L)")]
    public const int WEP_E_UNEXPECTED_FAIL = unchecked((int)(0x88010008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WEP_E_BUFFER_TOO_LARGE"]/*' />
    [NativeTypeName("#define WEP_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x88010009L)")]
    public const int WEP_E_BUFFER_TOO_LARGE = unchecked((int)(0x88010009));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WINML_ERR_INVALID_DEVICE"]/*' />
    [NativeTypeName("#define WINML_ERR_INVALID_DEVICE _HRESULT_TYPEDEF_(0x88900001L)")]
    public const int WINML_ERR_INVALID_DEVICE = unchecked((int)(0x88900001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WINML_ERR_INVALID_BINDING"]/*' />
    [NativeTypeName("#define WINML_ERR_INVALID_BINDING _HRESULT_TYPEDEF_(0x88900002L)")]
    public const int WINML_ERR_INVALID_BINDING = unchecked((int)(0x88900002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WINML_ERR_VALUE_NOTFOUND"]/*' />
    [NativeTypeName("#define WINML_ERR_VALUE_NOTFOUND _HRESULT_TYPEDEF_(0x88900003L)")]
    public const int WINML_ERR_VALUE_NOTFOUND = unchecked((int)(0x88900003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WINML_ERR_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define WINML_ERR_SIZE_MISMATCH _HRESULT_TYPEDEF_(0x88900004L)")]
    public const int WINML_ERR_SIZE_MISMATCH = unchecked((int)(0x88900004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_REQUIRED_FLAG_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define IORING_E_REQUIRED_FLAG_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80460001L)")]
    public const int IORING_E_REQUIRED_FLAG_NOT_SUPPORTED = unchecked((int)(0x80460001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_SUBMISSION_QUEUE_FULL"]/*' />
    [NativeTypeName("#define IORING_E_SUBMISSION_QUEUE_FULL _HRESULT_TYPEDEF_(0x80460002L)")]
    public const int IORING_E_SUBMISSION_QUEUE_FULL = unchecked((int)(0x80460002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define IORING_E_VERSION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80460003L)")]
    public const int IORING_E_VERSION_NOT_SUPPORTED = unchecked((int)(0x80460003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_SUBMISSION_QUEUE_TOO_BIG"]/*' />
    [NativeTypeName("#define IORING_E_SUBMISSION_QUEUE_TOO_BIG _HRESULT_TYPEDEF_(0x80460004L)")]
    public const int IORING_E_SUBMISSION_QUEUE_TOO_BIG = unchecked((int)(0x80460004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_COMPLETION_QUEUE_TOO_BIG"]/*' />
    [NativeTypeName("#define IORING_E_COMPLETION_QUEUE_TOO_BIG _HRESULT_TYPEDEF_(0x80460005L)")]
    public const int IORING_E_COMPLETION_QUEUE_TOO_BIG = unchecked((int)(0x80460005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_SUBMIT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define IORING_E_SUBMIT_IN_PROGRESS _HRESULT_TYPEDEF_(0x80460006L)")]
    public const int IORING_E_SUBMIT_IN_PROGRESS = unchecked((int)(0x80460006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_CORRUPT"]/*' />
    [NativeTypeName("#define IORING_E_CORRUPT _HRESULT_TYPEDEF_(0x80460007L)")]
    public const int IORING_E_CORRUPT = unchecked((int)(0x80460007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IORING_E_COMPLETION_QUEUE_TOO_FULL"]/*' />
    [NativeTypeName("#define IORING_E_COMPLETION_QUEUE_TOO_FULL _HRESULT_TYPEDEF_(0x80460008L)")]
    public const int IORING_E_COMPLETION_QUEUE_TOO_FULL = unchecked((int)(0x80460008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_CANNOT_CROSS_UNION"]/*' />
    [NativeTypeName("#define UNIONFS_E_CANNOT_CROSS_UNION _HRESULT_TYPEDEF_(0x89250001L)")]
    public const int UNIONFS_E_CANNOT_CROSS_UNION = unchecked((int)(0x89250001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_CANNOT_EXIT_UNION"]/*' />
    [NativeTypeName("#define UNIONFS_E_CANNOT_EXIT_UNION _HRESULT_TYPEDEF_(0x89250002L)")]
    public const int UNIONFS_E_CANNOT_EXIT_UNION = unchecked((int)(0x89250002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_CANNOT_PRESERVE_LINK"]/*' />
    [NativeTypeName("#define UNIONFS_E_CANNOT_PRESERVE_LINK _HRESULT_TYPEDEF_(0x89250003L)")]
    public const int UNIONFS_E_CANNOT_PRESERVE_LINK = unchecked((int)(0x89250003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_INVALID_TOMBSTONE_STATE"]/*' />
    [NativeTypeName("#define UNIONFS_E_INVALID_TOMBSTONE_STATE _HRESULT_TYPEDEF_(0x89250004L)")]
    public const int UNIONFS_E_INVALID_TOMBSTONE_STATE = unchecked((int)(0x89250004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_LAYERS_PRESENT"]/*' />
    [NativeTypeName("#define UNIONFS_E_LAYERS_PRESENT _HRESULT_TYPEDEF_(0x89250005L)")]
    public const int UNIONFS_E_LAYERS_PRESENT = unchecked((int)(0x89250005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_NESTED_LAYER"]/*' />
    [NativeTypeName("#define UNIONFS_E_NESTED_LAYER _HRESULT_TYPEDEF_(0x89250006L)")]
    public const int UNIONFS_E_NESTED_LAYER = unchecked((int)(0x89250006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_UNION_DUPLICATE_ID"]/*' />
    [NativeTypeName("#define UNIONFS_E_UNION_DUPLICATE_ID _HRESULT_TYPEDEF_(0x89250007L)")]
    public const int UNIONFS_E_UNION_DUPLICATE_ID = unchecked((int)(0x89250007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_INACTIVE_UNION"]/*' />
    [NativeTypeName("#define UNIONFS_E_INACTIVE_UNION _HRESULT_TYPEDEF_(0x89250008L)")]
    public const int UNIONFS_E_INACTIVE_UNION = unchecked((int)(0x89250008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_TOO_MANY_LAYERS"]/*' />
    [NativeTypeName("#define UNIONFS_E_TOO_MANY_LAYERS _HRESULT_TYPEDEF_(0x89250009L)")]
    public const int UNIONFS_E_TOO_MANY_LAYERS = unchecked((int)(0x89250009));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_TOO_LATE"]/*' />
    [NativeTypeName("#define UNIONFS_E_TOO_LATE _HRESULT_TYPEDEF_(0x8925000AL)")]
    public const int UNIONFS_E_TOO_LATE = unchecked((int)(0x8925000A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_NESTED_UNION"]/*' />
    [NativeTypeName("#define UNIONFS_E_NESTED_UNION _HRESULT_TYPEDEF_(0x8925000BL)")]
    public const int UNIONFS_E_NESTED_UNION = unchecked((int)(0x8925000B));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_NESTED_UNION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define UNIONFS_E_NESTED_UNION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8925000CL)")]
    public const int UNIONFS_E_NESTED_UNION_NOT_ALLOWED = unchecked((int)(0x8925000C));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIONFS_E_BOOT_LAYER_NOT_ATTACHED"]/*' />
    [NativeTypeName("#define UNIONFS_E_BOOT_LAYER_NOT_ATTACHED _HRESULT_TYPEDEF_(0x8925000DL)")]
    public const int UNIONFS_E_BOOT_LAYER_NOT_ATTACHED = unchecked((int)(0x8925000D));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_DIGEST_ALGO_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_DIGEST_ALGO_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC9280000L)")]
    public const int PPF_E_TRANSFORM_DIGEST_ALGO_NOT_SUPPORTED = unchecked((int)(0xC9280000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_CONFLICT"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_CONFLICT _HRESULT_TYPEDEF_(0xC9280001L)")]
    public const int PPF_E_TRANSFORM_CONFLICT = unchecked((int)(0xC9280001));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_CLEANED_UP_NA"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_CLEANED_UP_NA _HRESULT_TYPEDEF_(0xC9280002L)")]
    public const int PPF_E_TRANSFORM_CLEANED_UP_NA = unchecked((int)(0xC9280002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_CLEANED_UP_STATE_CHANGE"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_CLEANED_UP_STATE_CHANGE _HRESULT_TYPEDEF_(0xC9280003L)")]
    public const int PPF_E_TRANSFORM_CLEANED_UP_STATE_CHANGE = unchecked((int)(0xC9280003));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_DIGEST_ALGO_NOT_PRESENT"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_DIGEST_ALGO_NOT_PRESENT _HRESULT_TYPEDEF_(0xC9280004L)")]
    public const int PPF_E_TRANSFORM_DIGEST_ALGO_NOT_PRESENT = unchecked((int)(0xC9280004));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_UNKNOWN_FORMAT"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_UNKNOWN_FORMAT _HRESULT_TYPEDEF_(0xC9280005L)")]
    public const int PPF_E_TRANSFORM_UNKNOWN_FORMAT = unchecked((int)(0xC9280005));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_INSERT_NO_MATCH_EVENTS"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_INSERT_NO_MATCH_EVENTS _HRESULT_TYPEDEF_(0xC9280006L)")]
    public const int PPF_E_JSONTX_INSERT_NO_MATCH_EVENTS = unchecked((int)(0xC9280006));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_MULTIPLE_MATCHES_FOR_UNIQUE"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_MULTIPLE_MATCHES_FOR_UNIQUE _HRESULT_TYPEDEF_(0xC9280007L)")]
    public const int PPF_E_JSONTX_MULTIPLE_MATCHES_FOR_UNIQUE = unchecked((int)(0xC9280007));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TXGENBM_NO_EVENTS_GENERATED"]/*' />
    [NativeTypeName("#define PPF_E_TXGENBM_NO_EVENTS_GENERATED _HRESULT_TYPEDEF_(0xC9280008L)")]
    public const int PPF_E_TXGENBM_NO_EVENTS_GENERATED = unchecked((int)(0xC9280008));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_TRANSFORM_NOT_APPLICABLE"]/*' />
    [NativeTypeName("#define PPF_E_TRANSFORM_NOT_APPLICABLE _HRESULT_TYPEDEF_(0xC9280009L)")]
    public const int PPF_E_TRANSFORM_NOT_APPLICABLE = unchecked((int)(0xC9280009));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_NO_MATCH_EVENTS"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_NO_MATCH_EVENTS _HRESULT_TYPEDEF_(0xC928000AL)")]
    public const int PPF_E_JSONTX_NO_MATCH_EVENTS = unchecked((int)(0xC928000A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_NO_NEW_EVENTS_TO_INSERT"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_NO_NEW_EVENTS_TO_INSERT _HRESULT_TYPEDEF_(0xC928000BL)")]
    public const int PPF_E_JSONTX_NO_NEW_EVENTS_TO_INSERT = unchecked((int)(0xC928000B));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_EMPTY_RULE"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_EMPTY_RULE _HRESULT_TYPEDEF_(0xC928000CL)")]
    public const int PPF_E_JSONTX_EMPTY_RULE = unchecked((int)(0xC928000C));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PPF_E_JSONTX_EVENT_TYPE_ERROR"]/*' />
    [NativeTypeName("#define PPF_E_JSONTX_EVENT_TYPE_ERROR _HRESULT_TYPEDEF_(0xC928000DL)")]
    public const int PPF_E_JSONTX_EVENT_TYPE_ERROR = unchecked((int)(0xC928000D));
}
