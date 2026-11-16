// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RPC
{
    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_STRING_BINDING"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_STRING_BINDING 1700L")]
    public const int RPC_S_INVALID_STRING_BINDING = 1700;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_WRONG_KIND_OF_BINDING"]/*' />
    [NativeTypeName("#define RPC_S_WRONG_KIND_OF_BINDING 1701L")]
    public const int RPC_S_WRONG_KIND_OF_BINDING = 1701;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_BINDING"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_BINDING 1702L")]
    public const int RPC_S_INVALID_BINDING = 1702;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROTSEQ_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define RPC_S_PROTSEQ_NOT_SUPPORTED 1703L")]
    public const int RPC_S_PROTSEQ_NOT_SUPPORTED = 1703;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_RPC_PROTSEQ"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_RPC_PROTSEQ 1704L")]
    public const int RPC_S_INVALID_RPC_PROTSEQ = 1704;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_STRING_UUID"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_STRING_UUID 1705L")]
    public const int RPC_S_INVALID_STRING_UUID = 1705;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_ENDPOINT_FORMAT"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_ENDPOINT_FORMAT 1706L")]
    public const int RPC_S_INVALID_ENDPOINT_FORMAT = 1706;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_NET_ADDR"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_NET_ADDR 1707L")]
    public const int RPC_S_INVALID_NET_ADDR = 1707;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_ENDPOINT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_NO_ENDPOINT_FOUND 1708L")]
    public const int RPC_S_NO_ENDPOINT_FOUND = 1708;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_TIMEOUT 1709L")]
    public const int RPC_S_INVALID_TIMEOUT = 1709;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_OBJECT_NOT_FOUND 1710L")]
    public const int RPC_S_OBJECT_NOT_FOUND = 1710;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_S_ALREADY_REGISTERED 1711L")]
    public const int RPC_S_ALREADY_REGISTERED = 1711;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_TYPE_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_S_TYPE_ALREADY_REGISTERED 1712L")]
    public const int RPC_S_TYPE_ALREADY_REGISTERED = 1712;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ALREADY_LISTENING"]/*' />
    [NativeTypeName("#define RPC_S_ALREADY_LISTENING 1713L")]
    public const int RPC_S_ALREADY_LISTENING = 1713;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_PROTSEQS_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_S_NO_PROTSEQS_REGISTERED 1714L")]
    public const int RPC_S_NO_PROTSEQS_REGISTERED = 1714;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOT_LISTENING"]/*' />
    [NativeTypeName("#define RPC_S_NOT_LISTENING 1715L")]
    public const int RPC_S_NOT_LISTENING = 1715;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_MGR_TYPE"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_MGR_TYPE 1716L")]
    public const int RPC_S_UNKNOWN_MGR_TYPE = 1716;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_IF"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_IF 1717L")]
    public const int RPC_S_UNKNOWN_IF = 1717;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_BINDINGS"]/*' />
    [NativeTypeName("#define RPC_S_NO_BINDINGS 1718L")]
    public const int RPC_S_NO_BINDINGS = 1718;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_PROTSEQS"]/*' />
    [NativeTypeName("#define RPC_S_NO_PROTSEQS 1719L")]
    public const int RPC_S_NO_PROTSEQS = 1719;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CANT_CREATE_ENDPOINT"]/*' />
    [NativeTypeName("#define RPC_S_CANT_CREATE_ENDPOINT 1720L")]
    public const int RPC_S_CANT_CREATE_ENDPOINT = 1720;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_OUT_OF_RESOURCES"]/*' />
    [NativeTypeName("#define RPC_S_OUT_OF_RESOURCES 1721L")]
    public const int RPC_S_OUT_OF_RESOURCES = 1721;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SERVER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define RPC_S_SERVER_UNAVAILABLE 1722L")]
    public const int RPC_S_SERVER_UNAVAILABLE = 1722;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SERVER_TOO_BUSY"]/*' />
    [NativeTypeName("#define RPC_S_SERVER_TOO_BUSY 1723L")]
    public const int RPC_S_SERVER_TOO_BUSY = 1723;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_NETWORK_OPTIONS"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_NETWORK_OPTIONS 1724L")]
    public const int RPC_S_INVALID_NETWORK_OPTIONS = 1724;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_CALL_ACTIVE"]/*' />
    [NativeTypeName("#define RPC_S_NO_CALL_ACTIVE 1725L")]
    public const int RPC_S_NO_CALL_ACTIVE = 1725;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CALL_FAILED"]/*' />
    [NativeTypeName("#define RPC_S_CALL_FAILED 1726L")]
    public const int RPC_S_CALL_FAILED = 1726;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CALL_FAILED_DNE"]/*' />
    [NativeTypeName("#define RPC_S_CALL_FAILED_DNE 1727L")]
    public const int RPC_S_CALL_FAILED_DNE = 1727;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define RPC_S_PROTOCOL_ERROR 1728L")]
    public const int RPC_S_PROTOCOL_ERROR = 1728;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROXY_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define RPC_S_PROXY_ACCESS_DENIED 1729L")]
    public const int RPC_S_PROXY_ACCESS_DENIED = 1729;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNSUPPORTED_TRANS_SYN"]/*' />
    [NativeTypeName("#define RPC_S_UNSUPPORTED_TRANS_SYN 1730L")]
    public const int RPC_S_UNSUPPORTED_TRANS_SYN = 1730;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNSUPPORTED_TYPE"]/*' />
    [NativeTypeName("#define RPC_S_UNSUPPORTED_TYPE 1732L")]
    public const int RPC_S_UNSUPPORTED_TYPE = 1732;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_TAG"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_TAG 1733L")]
    public const int RPC_S_INVALID_TAG = 1733;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_BOUND"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_BOUND 1734L")]
    public const int RPC_S_INVALID_BOUND = 1734;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_ENTRY_NAME"]/*' />
    [NativeTypeName("#define RPC_S_NO_ENTRY_NAME 1735L")]
    public const int RPC_S_NO_ENTRY_NAME = 1735;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_NAME_SYNTAX"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_NAME_SYNTAX 1736L")]
    public const int RPC_S_INVALID_NAME_SYNTAX = 1736;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNSUPPORTED_NAME_SYNTAX"]/*' />
    [NativeTypeName("#define RPC_S_UNSUPPORTED_NAME_SYNTAX 1737L")]
    public const int RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UUID_NO_ADDRESS"]/*' />
    [NativeTypeName("#define RPC_S_UUID_NO_ADDRESS 1739L")]
    public const int RPC_S_UUID_NO_ADDRESS = 1739;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_DUPLICATE_ENDPOINT"]/*' />
    [NativeTypeName("#define RPC_S_DUPLICATE_ENDPOINT 1740L")]
    public const int RPC_S_DUPLICATE_ENDPOINT = 1740;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_AUTHN_TYPE"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_TYPE 1741L")]
    public const int RPC_S_UNKNOWN_AUTHN_TYPE = 1741;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_MAX_CALLS_TOO_SMALL"]/*' />
    [NativeTypeName("#define RPC_S_MAX_CALLS_TOO_SMALL 1742L")]
    public const int RPC_S_MAX_CALLS_TOO_SMALL = 1742;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_STRING_TOO_LONG"]/*' />
    [NativeTypeName("#define RPC_S_STRING_TOO_LONG 1743L")]
    public const int RPC_S_STRING_TOO_LONG = 1743;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROTSEQ_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_PROTSEQ_NOT_FOUND 1744L")]
    public const int RPC_S_PROTSEQ_NOT_FOUND = 1744;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROCNUM_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define RPC_S_PROCNUM_OUT_OF_RANGE 1745L")]
    public const int RPC_S_PROCNUM_OUT_OF_RANGE = 1745;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_BINDING_HAS_NO_AUTH"]/*' />
    [NativeTypeName("#define RPC_S_BINDING_HAS_NO_AUTH 1746L")]
    public const int RPC_S_BINDING_HAS_NO_AUTH = 1746;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_AUTHN_SERVICE"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_SERVICE 1747L")]
    public const int RPC_S_UNKNOWN_AUTHN_SERVICE = 1747;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_AUTHN_LEVEL"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_LEVEL 1748L")]
    public const int RPC_S_UNKNOWN_AUTHN_LEVEL = 1748;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_AUTH_IDENTITY"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_AUTH_IDENTITY 1749L")]
    public const int RPC_S_INVALID_AUTH_IDENTITY = 1749;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNKNOWN_AUTHZ_SERVICE"]/*' />
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHZ_SERVICE 1750L")]
    public const int RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOTHING_TO_EXPORT"]/*' />
    [NativeTypeName("#define RPC_S_NOTHING_TO_EXPORT 1754L")]
    public const int RPC_S_NOTHING_TO_EXPORT = 1754;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INCOMPLETE_NAME"]/*' />
    [NativeTypeName("#define RPC_S_INCOMPLETE_NAME 1755L")]
    public const int RPC_S_INCOMPLETE_NAME = 1755;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_VERS_OPTION"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_VERS_OPTION 1756L")]
    public const int RPC_S_INVALID_VERS_OPTION = 1756;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_MORE_MEMBERS"]/*' />
    [NativeTypeName("#define RPC_S_NO_MORE_MEMBERS 1757L")]
    public const int RPC_S_NO_MORE_MEMBERS = 1757;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOT_ALL_OBJS_UNEXPORTED"]/*' />
    [NativeTypeName("#define RPC_S_NOT_ALL_OBJS_UNEXPORTED 1758L")]
    public const int RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_INTERFACE_NOT_FOUND 1759L")]
    public const int RPC_S_INTERFACE_NOT_FOUND = 1759;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ENTRY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define RPC_S_ENTRY_ALREADY_EXISTS 1760L")]
    public const int RPC_S_ENTRY_ALREADY_EXISTS = 1760;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ENTRY_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_ENTRY_NOT_FOUND 1761L")]
    public const int RPC_S_ENTRY_NOT_FOUND = 1761;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NAME_SERVICE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define RPC_S_NAME_SERVICE_UNAVAILABLE 1762L")]
    public const int RPC_S_NAME_SERVICE_UNAVAILABLE = 1762;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_NAF_ID"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_NAF_ID 1763L")]
    public const int RPC_S_INVALID_NAF_ID = 1763;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CANNOT_SUPPORT"]/*' />
    [NativeTypeName("#define RPC_S_CANNOT_SUPPORT 1764L")]
    public const int RPC_S_CANNOT_SUPPORT = 1764;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_CONTEXT_AVAILABLE"]/*' />
    [NativeTypeName("#define RPC_S_NO_CONTEXT_AVAILABLE 1765L")]
    public const int RPC_S_NO_CONTEXT_AVAILABLE = 1765;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define RPC_S_INTERNAL_ERROR 1766L")]
    public const int RPC_S_INTERNAL_ERROR = 1766;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ZERO_DIVIDE"]/*' />
    [NativeTypeName("#define RPC_S_ZERO_DIVIDE 1767L")]
    public const int RPC_S_ZERO_DIVIDE = 1767;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ADDRESS_ERROR"]/*' />
    [NativeTypeName("#define RPC_S_ADDRESS_ERROR 1768L")]
    public const int RPC_S_ADDRESS_ERROR = 1768;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_FP_DIV_ZERO"]/*' />
    [NativeTypeName("#define RPC_S_FP_DIV_ZERO 1769L")]
    public const int RPC_S_FP_DIV_ZERO = 1769;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_FP_UNDERFLOW"]/*' />
    [NativeTypeName("#define RPC_S_FP_UNDERFLOW 1770L")]
    public const int RPC_S_FP_UNDERFLOW = 1770;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_FP_OVERFLOW"]/*' />
    [NativeTypeName("#define RPC_S_FP_OVERFLOW 1771L")]
    public const int RPC_S_FP_OVERFLOW = 1771;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_NO_MORE_ENTRIES"]/*' />
    [NativeTypeName("#define RPC_X_NO_MORE_ENTRIES 1772L")]
    public const int RPC_X_NO_MORE_ENTRIES = 1772;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_CHAR_TRANS_OPEN_FAIL"]/*' />
    [NativeTypeName("#define RPC_X_SS_CHAR_TRANS_OPEN_FAIL 1773L")]
    public const int RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_CHAR_TRANS_SHORT_FILE"]/*' />
    [NativeTypeName("#define RPC_X_SS_CHAR_TRANS_SHORT_FILE 1774L")]
    public const int RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_IN_NULL_CONTEXT"]/*' />
    [NativeTypeName("#define RPC_X_SS_IN_NULL_CONTEXT 1775L")]
    public const int RPC_X_SS_IN_NULL_CONTEXT = 1775;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_CONTEXT_DAMAGED"]/*' />
    [NativeTypeName("#define RPC_X_SS_CONTEXT_DAMAGED 1777L")]
    public const int RPC_X_SS_CONTEXT_DAMAGED = 1777;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_HANDLES_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_X_SS_HANDLES_MISMATCH 1778L")]
    public const int RPC_X_SS_HANDLES_MISMATCH = 1778;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_SS_CANNOT_GET_CALL_HANDLE"]/*' />
    [NativeTypeName("#define RPC_X_SS_CANNOT_GET_CALL_HANDLE 1779L")]
    public const int RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_NULL_REF_POINTER"]/*' />
    [NativeTypeName("#define RPC_X_NULL_REF_POINTER 1780L")]
    public const int RPC_X_NULL_REF_POINTER = 1780;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_ENUM_VALUE_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define RPC_X_ENUM_VALUE_OUT_OF_RANGE 1781L")]
    public const int RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_BYTE_COUNT_TOO_SMALL"]/*' />
    [NativeTypeName("#define RPC_X_BYTE_COUNT_TOO_SMALL 1782L")]
    public const int RPC_X_BYTE_COUNT_TOO_SMALL = 1782;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_BAD_STUB_DATA"]/*' />
    [NativeTypeName("#define RPC_X_BAD_STUB_DATA 1783L")]
    public const int RPC_X_BAD_STUB_DATA = 1783;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CALL_IN_PROGRESS"]/*' />
    [NativeTypeName("#define RPC_S_CALL_IN_PROGRESS 1791L")]
    public const int RPC_S_CALL_IN_PROGRESS = 1791;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_MORE_BINDINGS"]/*' />
    [NativeTypeName("#define RPC_S_NO_MORE_BINDINGS 1806L")]
    public const int RPC_S_NO_MORE_BINDINGS = 1806;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_INTERFACES"]/*' />
    [NativeTypeName("#define RPC_S_NO_INTERFACES 1817L")]
    public const int RPC_S_NO_INTERFACES = 1817;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CALL_CANCELLED"]/*' />
    [NativeTypeName("#define RPC_S_CALL_CANCELLED 1818L")]
    public const int RPC_S_CALL_CANCELLED = 1818;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_BINDING_INCOMPLETE"]/*' />
    [NativeTypeName("#define RPC_S_BINDING_INCOMPLETE 1819L")]
    public const int RPC_S_BINDING_INCOMPLETE = 1819;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_COMM_FAILURE"]/*' />
    [NativeTypeName("#define RPC_S_COMM_FAILURE 1820L")]
    public const int RPC_S_COMM_FAILURE = 1820;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UNSUPPORTED_AUTHN_LEVEL"]/*' />
    [NativeTypeName("#define RPC_S_UNSUPPORTED_AUTHN_LEVEL 1821L")]
    public const int RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NO_PRINC_NAME"]/*' />
    [NativeTypeName("#define RPC_S_NO_PRINC_NAME 1822L")]
    public const int RPC_S_NO_PRINC_NAME = 1822;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOT_RPC_ERROR"]/*' />
    [NativeTypeName("#define RPC_S_NOT_RPC_ERROR 1823L")]
    public const int RPC_S_NOT_RPC_ERROR = 1823;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_UUID_LOCAL_ONLY"]/*' />
    [NativeTypeName("#define RPC_S_UUID_LOCAL_ONLY 1824L")]
    public const int RPC_S_UUID_LOCAL_ONLY = 1824;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SEC_PKG_ERROR"]/*' />
    [NativeTypeName("#define RPC_S_SEC_PKG_ERROR 1825L")]
    public const int RPC_S_SEC_PKG_ERROR = 1825;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOT_CANCELLED"]/*' />
    [NativeTypeName("#define RPC_S_NOT_CANCELLED 1826L")]
    public const int RPC_S_NOT_CANCELLED = 1826;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_INVALID_ES_ACTION"]/*' />
    [NativeTypeName("#define RPC_X_INVALID_ES_ACTION 1827L")]
    public const int RPC_X_INVALID_ES_ACTION = 1827;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_WRONG_ES_VERSION"]/*' />
    [NativeTypeName("#define RPC_X_WRONG_ES_VERSION 1828L")]
    public const int RPC_X_WRONG_ES_VERSION = 1828;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_WRONG_STUB_VERSION"]/*' />
    [NativeTypeName("#define RPC_X_WRONG_STUB_VERSION 1829L")]
    public const int RPC_X_WRONG_STUB_VERSION = 1829;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_INVALID_PIPE_OBJECT"]/*' />
    [NativeTypeName("#define RPC_X_INVALID_PIPE_OBJECT 1830L")]
    public const int RPC_X_INVALID_PIPE_OBJECT = 1830;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_WRONG_PIPE_ORDER"]/*' />
    [NativeTypeName("#define RPC_X_WRONG_PIPE_ORDER 1831L")]
    public const int RPC_X_WRONG_PIPE_ORDER = 1831;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_WRONG_PIPE_VERSION"]/*' />
    [NativeTypeName("#define RPC_X_WRONG_PIPE_VERSION 1832L")]
    public const int RPC_X_WRONG_PIPE_VERSION = 1832;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_COOKIE_AUTH_FAILED"]/*' />
    [NativeTypeName("#define RPC_S_COOKIE_AUTH_FAILED 1833L")]
    public const int RPC_S_COOKIE_AUTH_FAILED = 1833;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_DO_NOT_DISTURB"]/*' />
    [NativeTypeName("#define RPC_S_DO_NOT_DISTURB 1834L")]
    public const int RPC_S_DO_NOT_DISTURB = 1834;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED 1835L")]
    public const int RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED = 1835;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH 1836L")]
    public const int RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH = 1836;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_GROUP_MEMBER_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_S_GROUP_MEMBER_NOT_FOUND 1898L")]
    public const int RPC_S_GROUP_MEMBER_NOT_FOUND = 1898;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_OBJECT"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_OBJECT 1900L")]
    public const int RPC_S_INVALID_OBJECT = 1900;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_SEND_INCOMPLETE"]/*' />
    [NativeTypeName("#define RPC_S_SEND_INCOMPLETE 1913L")]
    public const int RPC_S_SEND_INCOMPLETE = 1913;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_ASYNC_HANDLE"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_ASYNC_HANDLE 1914L")]
    public const int RPC_S_INVALID_ASYNC_HANDLE = 1914;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INVALID_ASYNC_CALL"]/*' />
    [NativeTypeName("#define RPC_S_INVALID_ASYNC_CALL 1915L")]
    public const int RPC_S_INVALID_ASYNC_CALL = 1915;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_PIPE_CLOSED"]/*' />
    [NativeTypeName("#define RPC_X_PIPE_CLOSED 1916L")]
    public const int RPC_X_PIPE_CLOSED = 1916;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_PIPE_DISCIPLINE_ERROR"]/*' />
    [NativeTypeName("#define RPC_X_PIPE_DISCIPLINE_ERROR 1917L")]
    public const int RPC_X_PIPE_DISCIPLINE_ERROR = 1917;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_X_PIPE_EMPTY"]/*' />
    [NativeTypeName("#define RPC_X_PIPE_EMPTY 1918L")]
    public const int RPC_X_PIPE_EMPTY = 1918;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_ENTRY_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_S_ENTRY_TYPE_MISMATCH 1922L")]
    public const int RPC_S_ENTRY_TYPE_MISMATCH = 1922;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_NOT_ALL_OBJS_EXPORTED"]/*' />
    [NativeTypeName("#define RPC_S_NOT_ALL_OBJS_EXPORTED 1923L")]
    public const int RPC_S_NOT_ALL_OBJS_EXPORTED = 1923;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_INTERFACE_NOT_EXPORTED"]/*' />
    [NativeTypeName("#define RPC_S_INTERFACE_NOT_EXPORTED 1924L")]
    public const int RPC_S_INTERFACE_NOT_EXPORTED = 1924;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PROFILE_NOT_ADDED"]/*' />
    [NativeTypeName("#define RPC_S_PROFILE_NOT_ADDED 1925L")]
    public const int RPC_S_PROFILE_NOT_ADDED = 1925;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PRF_ELT_NOT_ADDED"]/*' />
    [NativeTypeName("#define RPC_S_PRF_ELT_NOT_ADDED 1926L")]
    public const int RPC_S_PRF_ELT_NOT_ADDED = 1926;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_PRF_ELT_NOT_REMOVED"]/*' />
    [NativeTypeName("#define RPC_S_PRF_ELT_NOT_REMOVED 1927L")]
    public const int RPC_S_PRF_ELT_NOT_REMOVED = 1927;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_GRP_ELT_NOT_ADDED"]/*' />
    [NativeTypeName("#define RPC_S_GRP_ELT_NOT_ADDED 1928L")]
    public const int RPC_S_GRP_ELT_NOT_ADDED = 1928;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_GRP_ELT_NOT_REMOVED"]/*' />
    [NativeTypeName("#define RPC_S_GRP_ELT_NOT_REMOVED 1929L")]
    public const int RPC_S_GRP_ELT_NOT_REMOVED = 1929;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CALL_REJECTED"]/*' />
    [NativeTypeName("#define RPC_E_CALL_REJECTED _HRESULT_TYPEDEF_(0x80010001L)")]
    public const int RPC_E_CALL_REJECTED = unchecked((int)(0x80010001));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CALL_CANCELED"]/*' />
    [NativeTypeName("#define RPC_E_CALL_CANCELED _HRESULT_TYPEDEF_(0x80010002L)")]
    public const int RPC_E_CALL_CANCELED = unchecked((int)(0x80010002));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTPOST_INSENDCALL"]/*' />
    [NativeTypeName("#define RPC_E_CANTPOST_INSENDCALL _HRESULT_TYPEDEF_(0x80010003L)")]
    public const int RPC_E_CANTPOST_INSENDCALL = unchecked((int)(0x80010003));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTCALLOUT_INASYNCCALL"]/*' />
    [NativeTypeName("#define RPC_E_CANTCALLOUT_INASYNCCALL _HRESULT_TYPEDEF_(0x80010004L)")]
    public const int RPC_E_CANTCALLOUT_INASYNCCALL = unchecked((int)(0x80010004));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTCALLOUT_INEXTERNALCALL"]/*' />
    [NativeTypeName("#define RPC_E_CANTCALLOUT_INEXTERNALCALL _HRESULT_TYPEDEF_(0x80010005L)")]
    public const int RPC_E_CANTCALLOUT_INEXTERNALCALL = unchecked((int)(0x80010005));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CONNECTION_TERMINATED"]/*' />
    [NativeTypeName("#define RPC_E_CONNECTION_TERMINATED _HRESULT_TYPEDEF_(0x80010006L)")]
    public const int RPC_E_CONNECTION_TERMINATED = unchecked((int)(0x80010006));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVER_DIED"]/*' />
    [NativeTypeName("#define RPC_E_SERVER_DIED _HRESULT_TYPEDEF_(0x80010007L)")]
    public const int RPC_E_SERVER_DIED = unchecked((int)(0x80010007));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CLIENT_DIED"]/*' />
    [NativeTypeName("#define RPC_E_CLIENT_DIED _HRESULT_TYPEDEF_(0x80010008L)")]
    public const int RPC_E_CLIENT_DIED = unchecked((int)(0x80010008));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_DATAPACKET"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_DATAPACKET _HRESULT_TYPEDEF_(0x80010009L)")]
    public const int RPC_E_INVALID_DATAPACKET = unchecked((int)(0x80010009));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTTRANSMIT_CALL"]/*' />
    [NativeTypeName("#define RPC_E_CANTTRANSMIT_CALL _HRESULT_TYPEDEF_(0x8001000AL)")]
    public const int RPC_E_CANTTRANSMIT_CALL = unchecked((int)(0x8001000A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CLIENT_CANTMARSHAL_DATA"]/*' />
    [NativeTypeName("#define RPC_E_CLIENT_CANTMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000BL)")]
    public const int RPC_E_CLIENT_CANTMARSHAL_DATA = unchecked((int)(0x8001000B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CLIENT_CANTUNMARSHAL_DATA"]/*' />
    [NativeTypeName("#define RPC_E_CLIENT_CANTUNMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000CL)")]
    public const int RPC_E_CLIENT_CANTUNMARSHAL_DATA = unchecked((int)(0x8001000C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVER_CANTMARSHAL_DATA"]/*' />
    [NativeTypeName("#define RPC_E_SERVER_CANTMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000DL)")]
    public const int RPC_E_SERVER_CANTMARSHAL_DATA = unchecked((int)(0x8001000D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVER_CANTUNMARSHAL_DATA"]/*' />
    [NativeTypeName("#define RPC_E_SERVER_CANTUNMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000EL)")]
    public const int RPC_E_SERVER_CANTUNMARSHAL_DATA = unchecked((int)(0x8001000E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_DATA"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_DATA _HRESULT_TYPEDEF_(0x8001000FL)")]
    public const int RPC_E_INVALID_DATA = unchecked((int)(0x8001000F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80010010L)")]
    public const int RPC_E_INVALID_PARAMETER = unchecked((int)(0x80010010));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTCALLOUT_AGAIN"]/*' />
    [NativeTypeName("#define RPC_E_CANTCALLOUT_AGAIN _HRESULT_TYPEDEF_(0x80010011L)")]
    public const int RPC_E_CANTCALLOUT_AGAIN = unchecked((int)(0x80010011));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVER_DIED_DNE"]/*' />
    [NativeTypeName("#define RPC_E_SERVER_DIED_DNE _HRESULT_TYPEDEF_(0x80010012L)")]
    public const int RPC_E_SERVER_DIED_DNE = unchecked((int)(0x80010012));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SYS_CALL_FAILED"]/*' />
    [NativeTypeName("#define RPC_E_SYS_CALL_FAILED _HRESULT_TYPEDEF_(0x80010100L)")]
    public const int RPC_E_SYS_CALL_FAILED = unchecked((int)(0x80010100));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_OUT_OF_RESOURCES"]/*' />
    [NativeTypeName("#define RPC_E_OUT_OF_RESOURCES _HRESULT_TYPEDEF_(0x80010101L)")]
    public const int RPC_E_OUT_OF_RESOURCES = unchecked((int)(0x80010101));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_ATTEMPTED_MULTITHREAD"]/*' />
    [NativeTypeName("#define RPC_E_ATTEMPTED_MULTITHREAD _HRESULT_TYPEDEF_(0x80010102L)")]
    public const int RPC_E_ATTEMPTED_MULTITHREAD = unchecked((int)(0x80010102));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_E_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80010103L)")]
    public const int RPC_E_NOT_REGISTERED = unchecked((int)(0x80010103));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_FAULT"]/*' />
    [NativeTypeName("#define RPC_E_FAULT _HRESULT_TYPEDEF_(0x80010104L)")]
    public const int RPC_E_FAULT = unchecked((int)(0x80010104));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVERFAULT"]/*' />
    [NativeTypeName("#define RPC_E_SERVERFAULT _HRESULT_TYPEDEF_(0x80010105L)")]
    public const int RPC_E_SERVERFAULT = unchecked((int)(0x80010105));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CHANGED_MODE"]/*' />
    [NativeTypeName("#define RPC_E_CHANGED_MODE _HRESULT_TYPEDEF_(0x80010106L)")]
    public const int RPC_E_CHANGED_MODE = unchecked((int)(0x80010106));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALIDMETHOD"]/*' />
    [NativeTypeName("#define RPC_E_INVALIDMETHOD _HRESULT_TYPEDEF_(0x80010107L)")]
    public const int RPC_E_INVALIDMETHOD = unchecked((int)(0x80010107));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_DISCONNECTED"]/*' />
    [NativeTypeName("#define RPC_E_DISCONNECTED _HRESULT_TYPEDEF_(0x80010108L)")]
    public const int RPC_E_DISCONNECTED = unchecked((int)(0x80010108));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_RETRY"]/*' />
    [NativeTypeName("#define RPC_E_RETRY _HRESULT_TYPEDEF_(0x80010109L)")]
    public const int RPC_E_RETRY = unchecked((int)(0x80010109));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVERCALL_RETRYLATER"]/*' />
    [NativeTypeName("#define RPC_E_SERVERCALL_RETRYLATER _HRESULT_TYPEDEF_(0x8001010AL)")]
    public const int RPC_E_SERVERCALL_RETRYLATER = unchecked((int)(0x8001010A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_SERVERCALL_REJECTED"]/*' />
    [NativeTypeName("#define RPC_E_SERVERCALL_REJECTED _HRESULT_TYPEDEF_(0x8001010BL)")]
    public const int RPC_E_SERVERCALL_REJECTED = unchecked((int)(0x8001010B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_CALLDATA"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_CALLDATA _HRESULT_TYPEDEF_(0x8001010CL)")]
    public const int RPC_E_INVALID_CALLDATA = unchecked((int)(0x8001010C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CANTCALLOUT_ININPUTSYNCCALL"]/*' />
    [NativeTypeName("#define RPC_E_CANTCALLOUT_ININPUTSYNCCALL _HRESULT_TYPEDEF_(0x8001010DL)")]
    public const int RPC_E_CANTCALLOUT_ININPUTSYNCCALL = unchecked((int)(0x8001010D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_WRONG_THREAD"]/*' />
    [NativeTypeName("#define RPC_E_WRONG_THREAD _HRESULT_TYPEDEF_(0x8001010EL)")]
    public const int RPC_E_WRONG_THREAD = unchecked((int)(0x8001010E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_THREAD_NOT_INIT"]/*' />
    [NativeTypeName("#define RPC_E_THREAD_NOT_INIT _HRESULT_TYPEDEF_(0x8001010FL)")]
    public const int RPC_E_THREAD_NOT_INIT = unchecked((int)(0x8001010F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_E_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x80010110L)")]
    public const int RPC_E_VERSION_MISMATCH = unchecked((int)(0x80010110));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_HEADER"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_HEADER _HRESULT_TYPEDEF_(0x80010111L)")]
    public const int RPC_E_INVALID_HEADER = unchecked((int)(0x80010111));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_EXTENSION"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_EXTENSION _HRESULT_TYPEDEF_(0x80010112L)")]
    public const int RPC_E_INVALID_EXTENSION = unchecked((int)(0x80010112));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_IPID"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_IPID _HRESULT_TYPEDEF_(0x80010113L)")]
    public const int RPC_E_INVALID_IPID = unchecked((int)(0x80010113));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_OBJECT"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_OBJECT _HRESULT_TYPEDEF_(0x80010114L)")]
    public const int RPC_E_INVALID_OBJECT = unchecked((int)(0x80010114));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_CALLPENDING"]/*' />
    [NativeTypeName("#define RPC_S_CALLPENDING _HRESULT_TYPEDEF_(0x80010115L)")]
    public const int RPC_S_CALLPENDING = unchecked((int)(0x80010115));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_S_WAITONTIMER"]/*' />
    [NativeTypeName("#define RPC_S_WAITONTIMER _HRESULT_TYPEDEF_(0x80010116L)")]
    public const int RPC_S_WAITONTIMER = unchecked((int)(0x80010116));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_CALL_COMPLETE"]/*' />
    [NativeTypeName("#define RPC_E_CALL_COMPLETE _HRESULT_TYPEDEF_(0x80010117L)")]
    public const int RPC_E_CALL_COMPLETE = unchecked((int)(0x80010117));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_UNSECURE_CALL"]/*' />
    [NativeTypeName("#define RPC_E_UNSECURE_CALL _HRESULT_TYPEDEF_(0x80010118L)")]
    public const int RPC_E_UNSECURE_CALL = unchecked((int)(0x80010118));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_TOO_LATE"]/*' />
    [NativeTypeName("#define RPC_E_TOO_LATE _HRESULT_TYPEDEF_(0x80010119L)")]
    public const int RPC_E_TOO_LATE = unchecked((int)(0x80010119));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_NO_GOOD_SECURITY_PACKAGES"]/*' />
    [NativeTypeName("#define RPC_E_NO_GOOD_SECURITY_PACKAGES _HRESULT_TYPEDEF_(0x8001011AL)")]
    public const int RPC_E_NO_GOOD_SECURITY_PACKAGES = unchecked((int)(0x8001011A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define RPC_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x8001011BL)")]
    public const int RPC_E_ACCESS_DENIED = unchecked((int)(0x8001011B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_REMOTE_DISABLED"]/*' />
    [NativeTypeName("#define RPC_E_REMOTE_DISABLED _HRESULT_TYPEDEF_(0x8001011CL)")]
    public const int RPC_E_REMOTE_DISABLED = unchecked((int)(0x8001011C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_OBJREF"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_OBJREF _HRESULT_TYPEDEF_(0x8001011DL)")]
    public const int RPC_E_INVALID_OBJREF = unchecked((int)(0x8001011D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_NO_CONTEXT"]/*' />
    [NativeTypeName("#define RPC_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x8001011EL)")]
    public const int RPC_E_NO_CONTEXT = unchecked((int)(0x8001011E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_E_TIMEOUT _HRESULT_TYPEDEF_(0x8001011FL)")]
    public const int RPC_E_TIMEOUT = unchecked((int)(0x8001011F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_NO_SYNC"]/*' />
    [NativeTypeName("#define RPC_E_NO_SYNC _HRESULT_TYPEDEF_(0x80010120L)")]
    public const int RPC_E_NO_SYNC = unchecked((int)(0x80010120));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_FULLSIC_REQUIRED"]/*' />
    [NativeTypeName("#define RPC_E_FULLSIC_REQUIRED _HRESULT_TYPEDEF_(0x80010121L)")]
    public const int RPC_E_FULLSIC_REQUIRED = unchecked((int)(0x80010121));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_INVALID_STD_NAME"]/*' />
    [NativeTypeName("#define RPC_E_INVALID_STD_NAME _HRESULT_TYPEDEF_(0x80010122L)")]
    public const int RPC_E_INVALID_STD_NAME = unchecked((int)(0x80010122));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_E_UNEXPECTED"]/*' />
    [NativeTypeName("#define RPC_E_UNEXPECTED _HRESULT_TYPEDEF_(0x8001FFFFL)")]
    public const int RPC_E_UNEXPECTED = unchecked((int)(0x8001FFFF));
}
