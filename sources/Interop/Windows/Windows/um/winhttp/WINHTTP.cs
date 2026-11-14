// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WINHTTP
{
    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_ASYNC"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_ASYNC 0x10000000")]
    public const int WINHTTP_FLAG_ASYNC = 0x10000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_DEFAULTS"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_DEFAULTS 0x30000000")]
    public const int WINHTTP_FLAG_SECURE_DEFAULTS = 0x30000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE 0x00800000")]
    public const int WINHTTP_FLAG_SECURE = 0x00800000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_ESCAPE_PERCENT"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_PERCENT 0x00000004")]
    public const int WINHTTP_FLAG_ESCAPE_PERCENT = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_NULL_CODEPAGE"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_NULL_CODEPAGE 0x00000008")]
    public const int WINHTTP_FLAG_NULL_CODEPAGE = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_ESCAPE_DISABLE"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_DISABLE 0x00000040")]
    public const int WINHTTP_FLAG_ESCAPE_DISABLE = 0x00000040;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_ESCAPE_DISABLE_QUERY"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_DISABLE_QUERY 0x00000080")]
    public const int WINHTTP_FLAG_ESCAPE_DISABLE_QUERY = 0x00000080;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_BYPASS_PROXY_CACHE"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_BYPASS_PROXY_CACHE 0x00000100")]
    public const int WINHTTP_FLAG_BYPASS_PROXY_CACHE = 0x00000100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_REFRESH"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_REFRESH WINHTTP_FLAG_BYPASS_PROXY_CACHE")]
    public const int WINHTTP_FLAG_REFRESH = 0x00000100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_AUTOMATIC_CHUNKING"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_AUTOMATIC_CHUNKING 0x00000200")]
    public const int WINHTTP_FLAG_AUTOMATIC_CHUNKING = 0x00000200;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_AUTO_DETECT"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_AUTO_DETECT 0x00000001")]
    public const int WINHTTP_AUTOPROXY_AUTO_DETECT = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_CONFIG_URL"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_CONFIG_URL 0x00000002")]
    public const int WINHTTP_AUTOPROXY_CONFIG_URL = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_HOST_KEEPCASE"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_HOST_KEEPCASE 0x00000004")]
    public const int WINHTTP_AUTOPROXY_HOST_KEEPCASE = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_HOST_LOWERCASE"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_HOST_LOWERCASE 0x00000008")]
    public const int WINHTTP_AUTOPROXY_HOST_LOWERCASE = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_ALLOW_AUTOCONFIG"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_AUTOCONFIG 0x00000100")]
    public const int WINHTTP_AUTOPROXY_ALLOW_AUTOCONFIG = 0x00000100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_ALLOW_STATIC"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_STATIC 0x00000200")]
    public const int WINHTTP_AUTOPROXY_ALLOW_STATIC = 0x00000200;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_ALLOW_CM"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_CM 0x00000400")]
    public const int WINHTTP_AUTOPROXY_ALLOW_CM = 0x00000400;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_USE_INTERFACE_CONFIG"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_USE_INTERFACE_CONFIG 0x00000800")]
    public const int WINHTTP_AUTOPROXY_USE_INTERFACE_CONFIG = 0x00000800;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_RUN_INPROCESS"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_RUN_INPROCESS 0x00010000")]
    public const int WINHTTP_AUTOPROXY_RUN_INPROCESS = 0x00010000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_RUN_OUTPROCESS_ONLY"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_RUN_OUTPROCESS_ONLY 0x00020000")]
    public const int WINHTTP_AUTOPROXY_RUN_OUTPROCESS_ONLY = 0x00020000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_NO_DIRECTACCESS"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_DIRECTACCESS 0x00040000")]
    public const int WINHTTP_AUTOPROXY_NO_DIRECTACCESS = 0x00040000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_NO_CACHE_CLIENT"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_CACHE_CLIENT 0x00080000")]
    public const int WINHTTP_AUTOPROXY_NO_CACHE_CLIENT = 0x00080000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_NO_CACHE_SVC"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_CACHE_SVC 0x00100000")]
    public const int WINHTTP_AUTOPROXY_NO_CACHE_SVC = 0x00100000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOPROXY_SORT_RESULTS"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOPROXY_SORT_RESULTS 0x00400000")]
    public const int WINHTTP_AUTOPROXY_SORT_RESULTS = 0x00400000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTO_DETECT_TYPE_DHCP"]/*' />
    [NativeTypeName("#define WINHTTP_AUTO_DETECT_TYPE_DHCP 0x00000001")]
    public const int WINHTTP_AUTO_DETECT_TYPE_DHCP = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTO_DETECT_TYPE_DNS_A"]/*' />
    [NativeTypeName("#define WINHTTP_AUTO_DETECT_TYPE_DNS_A 0x00000002")]
    public const int WINHTTP_AUTO_DETECT_TYPE_DNS_A = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_TYPE_DIRECT"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_TYPE_DIRECT 0x00000001")]
    public const int WINHTTP_PROXY_TYPE_DIRECT = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_TYPE_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_TYPE_PROXY 0x00000002")]
    public const int WINHTTP_PROXY_TYPE_PROXY = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_TYPE_AUTO_PROXY_URL"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_TYPE_AUTO_PROXY_URL 0x00000004")]
    public const int WINHTTP_PROXY_TYPE_AUTO_PROXY_URL = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_TYPE_AUTO_DETECT"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_TYPE_AUTO_DETECT 0x00000008")]
    public const int WINHTTP_PROXY_TYPE_AUTO_DETECT = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_TCP_FAST_OPEN"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TCP_FAST_OPEN 0x00000001")]
    public const int WINHTTP_REQUEST_STAT_FLAG_TCP_FAST_OPEN = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_TLS_SESSION_RESUMPTION"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TLS_SESSION_RESUMPTION 0x00000002")]
    public const int WINHTTP_REQUEST_STAT_FLAG_TLS_SESSION_RESUMPTION = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_TLS_FALSE_START"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TLS_FALSE_START 0x00000004")]
    public const int WINHTTP_REQUEST_STAT_FLAG_TLS_FALSE_START = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_SESSION_RESUMPTION"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_SESSION_RESUMPTION 0x00000008")]
    public const int WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_SESSION_RESUMPTION = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_FALSE_START"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_FALSE_START 0x00000010")]
    public const int WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_FALSE_START = 0x00000010;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_REQUEST_STAT_FLAG_FIRST_REQUEST"]/*' />
    [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_FIRST_REQUEST 0x00000020")]
    public const int WINHTTP_REQUEST_STAT_FLAG_FIRST_REQUEST = 0x00000020;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION 0x00000001")]
    public const int WINHTTP_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_MATCH_CONNECTION_GUID_FLAGS_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_MATCH_CONNECTION_GUID_FLAGS_MASK WINHTTP_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION")]
    public const int WINHTTP_MATCH_CONNECTION_GUID_FLAGS_MASK = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT"]/*' />
    [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT 0x00000001")]
    public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE"]/*' />
    [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE 0x00000002")]
    public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL 0x00000004")]
    public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL 0x00000008")]
    public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONNECTION_GROUP_FLAG_INSECURE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONNECTION_GROUP_FLAG_INSECURE 0x0000000000000001ull")]
    public const ulong WINHTTP_QUERY_CONNECTION_GROUP_FLAG_INSECURE = 0x0000000000000001UL;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_TIME_FORMAT_BUFSIZE"]/*' />
    [NativeTypeName("#define WINHTTP_TIME_FORMAT_BUFSIZE 62")]
    public const int WINHTTP_TIME_FORMAT_BUFSIZE = 62;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FIRST_OPTION"]/*' />
    [NativeTypeName("#define WINHTTP_FIRST_OPTION WINHTTP_OPTION_CALLBACK")]
    public const int WINHTTP_FIRST_OPTION = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CALLBACK 1")]
    public const int WINHTTP_OPTION_CALLBACK = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RESOLVE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RESOLVE_TIMEOUT 2")]
    public const int WINHTTP_OPTION_RESOLVE_TIMEOUT = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECT_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECT_TIMEOUT 3")]
    public const int WINHTTP_OPTION_CONNECT_TIMEOUT = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECT_RETRIES"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECT_RETRIES 4")]
    public const int WINHTTP_OPTION_CONNECT_RETRIES = 4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SEND_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SEND_TIMEOUT 5")]
    public const int WINHTTP_OPTION_SEND_TIMEOUT = 5;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RECEIVE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_TIMEOUT 6")]
    public const int WINHTTP_OPTION_RECEIVE_TIMEOUT = 6;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RECEIVE_RESPONSE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_RESPONSE_TIMEOUT 7")]
    public const int WINHTTP_OPTION_RECEIVE_RESPONSE_TIMEOUT = 7;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HANDLE_TYPE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HANDLE_TYPE 9")]
    public const int WINHTTP_OPTION_HANDLE_TYPE = 9;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_READ_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_READ_BUFFER_SIZE 12")]
    public const int WINHTTP_OPTION_READ_BUFFER_SIZE = 12;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WRITE_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WRITE_BUFFER_SIZE 13")]
    public const int WINHTTP_OPTION_WRITE_BUFFER_SIZE = 13;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PARENT_HANDLE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PARENT_HANDLE 21")]
    public const int WINHTTP_OPTION_PARENT_HANDLE = 21;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_EXTENDED_ERROR"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_EXTENDED_ERROR 24")]
    public const int WINHTTP_OPTION_EXTENDED_ERROR = 24;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SECURITY_FLAGS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SECURITY_FLAGS 31")]
    public const int WINHTTP_OPTION_SECURITY_FLAGS = 31;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SECURITY_CERTIFICATE_STRUCT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SECURITY_CERTIFICATE_STRUCT 32")]
    public const int WINHTTP_OPTION_SECURITY_CERTIFICATE_STRUCT = 32;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_URL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_URL 34")]
    public const int WINHTTP_OPTION_URL = 34;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SECURITY_KEY_BITNESS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SECURITY_KEY_BITNESS 36")]
    public const int WINHTTP_OPTION_SECURITY_KEY_BITNESS = 36;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY 38")]
    public const int WINHTTP_OPTION_PROXY = 38;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY_RESULT_ENTRY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY_RESULT_ENTRY 39")]
    public const int WINHTTP_OPTION_PROXY_RESULT_ENTRY = 39;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_USER_AGENT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_USER_AGENT 41")]
    public const int WINHTTP_OPTION_USER_AGENT = 41;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONTEXT_VALUE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONTEXT_VALUE 45")]
    public const int WINHTTP_OPTION_CONTEXT_VALUE = 45;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CLIENT_CERT_CONTEXT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CLIENT_CERT_CONTEXT 47")]
    public const int WINHTTP_OPTION_CLIENT_CERT_CONTEXT = 47;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUEST_PRIORITY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUEST_PRIORITY 58")]
    public const int WINHTTP_OPTION_REQUEST_PRIORITY = 58;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP_VERSION"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP_VERSION 59")]
    public const int WINHTTP_OPTION_HTTP_VERSION = 59;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_FEATURE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_FEATURE 63")]
    public const int WINHTTP_OPTION_DISABLE_FEATURE = 63;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CODEPAGE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CODEPAGE 68")]
    public const int WINHTTP_OPTION_CODEPAGE = 68;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_CONNS_PER_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_CONNS_PER_SERVER 73")]
    public const int WINHTTP_OPTION_MAX_CONNS_PER_SERVER = 73;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_CONNS_PER_1_0_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_CONNS_PER_1_0_SERVER 74")]
    public const int WINHTTP_OPTION_MAX_CONNS_PER_1_0_SERVER = 74;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_AUTOLOGON_POLICY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_AUTOLOGON_POLICY 77")]
    public const int WINHTTP_OPTION_AUTOLOGON_POLICY = 77;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_CERT_CONTEXT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CONTEXT 78")]
    public const int WINHTTP_OPTION_SERVER_CERT_CONTEXT = 78;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENABLE_FEATURE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENABLE_FEATURE 79")]
    public const int WINHTTP_OPTION_ENABLE_FEATURE = 79;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WORKER_THREAD_COUNT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WORKER_THREAD_COUNT 80")]
    public const int WINHTTP_OPTION_WORKER_THREAD_COUNT = 80;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PASSPORT_COBRANDING_TEXT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_COBRANDING_TEXT 81")]
    public const int WINHTTP_OPTION_PASSPORT_COBRANDING_TEXT = 81;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PASSPORT_COBRANDING_URL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_COBRANDING_URL 82")]
    public const int WINHTTP_OPTION_PASSPORT_COBRANDING_URL = 82;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONFIGURE_PASSPORT_AUTH"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONFIGURE_PASSPORT_AUTH 83")]
    public const int WINHTTP_OPTION_CONFIGURE_PASSPORT_AUTH = 83;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SECURE_PROTOCOLS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SECURE_PROTOCOLS 84")]
    public const int WINHTTP_OPTION_SECURE_PROTOCOLS = 84;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENABLETRACING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENABLETRACING 85")]
    public const int WINHTTP_OPTION_ENABLETRACING = 85;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PASSPORT_SIGN_OUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_SIGN_OUT 86")]
    public const int WINHTTP_OPTION_PASSPORT_SIGN_OUT = 86;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PASSPORT_RETURN_URL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_RETURN_URL 87")]
    public const int WINHTTP_OPTION_PASSPORT_RETURN_URL = 87;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY 88")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY = 88;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_HTTP_AUTOMATIC_REDIRECTS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_HTTP_AUTOMATIC_REDIRECTS 89")]
    public const int WINHTTP_OPTION_MAX_HTTP_AUTOMATIC_REDIRECTS = 89;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_HTTP_STATUS_CONTINUE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_HTTP_STATUS_CONTINUE 90")]
    public const int WINHTTP_OPTION_MAX_HTTP_STATUS_CONTINUE = 90;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_RESPONSE_HEADER_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_RESPONSE_HEADER_SIZE 91")]
    public const int WINHTTP_OPTION_MAX_RESPONSE_HEADER_SIZE = 91;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MAX_RESPONSE_DRAIN_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MAX_RESPONSE_DRAIN_SIZE 92")]
    public const int WINHTTP_OPTION_MAX_RESPONSE_DRAIN_SIZE = 92;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_INFO"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_INFO 93")]
    public const int WINHTTP_OPTION_CONNECTION_INFO = 93;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CLIENT_CERT_ISSUER_LIST"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CLIENT_CERT_ISSUER_LIST 94")]
    public const int WINHTTP_OPTION_CLIENT_CERT_ISSUER_LIST = 94;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SPN"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SPN 96")]
    public const int WINHTTP_OPTION_SPN = 96;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_GLOBAL_PROXY_CREDS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_GLOBAL_PROXY_CREDS 97")]
    public const int WINHTTP_OPTION_GLOBAL_PROXY_CREDS = 97;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_GLOBAL_SERVER_CREDS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_GLOBAL_SERVER_CREDS 98")]
    public const int WINHTTP_OPTION_GLOBAL_SERVER_CREDS = 98;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_UNLOAD_NOTIFY_EVENT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_UNLOAD_NOTIFY_EVENT 99")]
    public const int WINHTTP_OPTION_UNLOAD_NOTIFY_EVENT = 99;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REJECT_USERPWD_IN_URL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REJECT_USERPWD_IN_URL 100")]
    public const int WINHTTP_OPTION_REJECT_USERPWD_IN_URL = 100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_USE_GLOBAL_SERVER_CREDENTIALS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_USE_GLOBAL_SERVER_CREDENTIALS 101")]
    public const int WINHTTP_OPTION_USE_GLOBAL_SERVER_CREDENTIALS = 101;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RECEIVE_PROXY_CONNECT_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_PROXY_CONNECT_RESPONSE 103")]
    public const int WINHTTP_OPTION_RECEIVE_PROXY_CONNECT_RESPONSE = 103;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_IS_PROXY_CONNECT_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_IS_PROXY_CONNECT_RESPONSE 104")]
    public const int WINHTTP_OPTION_IS_PROXY_CONNECT_RESPONSE = 104;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_NETWORK_INTERFACE_AFFINITY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_NETWORK_INTERFACE_AFFINITY 105")]
    public const int WINHTTP_OPTION_NETWORK_INTERFACE_AFFINITY = 105;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_SPN_USED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_SPN_USED 106")]
    public const int WINHTTP_OPTION_SERVER_SPN_USED = 106;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY_SPN_USED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY_SPN_USED 107")]
    public const int WINHTTP_OPTION_PROXY_SPN_USED = 107;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_CBT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_CBT 108")]
    public const int WINHTTP_OPTION_SERVER_CBT = 108;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_UNSAFE_HEADER_PARSING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_UNSAFE_HEADER_PARSING 110")]
    public const int WINHTTP_OPTION_UNSAFE_HEADER_PARSING = 110;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ASSURED_NON_BLOCKING_CALLBACKS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ASSURED_NON_BLOCKING_CALLBACKS 111")]
    public const int WINHTTP_OPTION_ASSURED_NON_BLOCKING_CALLBACKS = 111;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_UPGRADE_TO_WEB_SOCKET"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_UPGRADE_TO_WEB_SOCKET 114")]
    public const int WINHTTP_OPTION_UPGRADE_TO_WEB_SOCKET = 114;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WEB_SOCKET_CLOSE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_CLOSE_TIMEOUT 115")]
    public const int WINHTTP_OPTION_WEB_SOCKET_CLOSE_TIMEOUT = 115;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WEB_SOCKET_KEEPALIVE_INTERVAL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_KEEPALIVE_INTERVAL 116")]
    public const int WINHTTP_OPTION_WEB_SOCKET_KEEPALIVE_INTERVAL = 116;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DECOMPRESSION"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DECOMPRESSION 118")]
    public const int WINHTTP_OPTION_DECOMPRESSION = 118;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WEB_SOCKET_RECEIVE_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_RECEIVE_BUFFER_SIZE 122")]
    public const int WINHTTP_OPTION_WEB_SOCKET_RECEIVE_BUFFER_SIZE = 122;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_WEB_SOCKET_SEND_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_SEND_BUFFER_SIZE 123")]
    public const int WINHTTP_OPTION_WEB_SOCKET_SEND_BUFFER_SIZE = 123;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TCP_PRIORITY_HINT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TCP_PRIORITY_HINT 128")]
    public const int WINHTTP_OPTION_TCP_PRIORITY_HINT = 128;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_FILTER"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_FILTER 131")]
    public const int WINHTTP_OPTION_CONNECTION_FILTER = 131;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENABLE_HTTP_PROTOCOL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENABLE_HTTP_PROTOCOL 133")]
    public const int WINHTTP_OPTION_ENABLE_HTTP_PROTOCOL = 133;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP_PROTOCOL_USED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP_PROTOCOL_USED 134")]
    public const int WINHTTP_OPTION_HTTP_PROTOCOL_USED = 134;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_KDC_PROXY_SETTINGS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_KDC_PROXY_SETTINGS 136")]
    public const int WINHTTP_OPTION_KDC_PROXY_SETTINGS = 136;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY_DISABLE_SERVICE_CALLS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY_DISABLE_SERVICE_CALLS 137")]
    public const int WINHTTP_OPTION_PROXY_DISABLE_SERVICE_CALLS = 137;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENCODE_EXTRA"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENCODE_EXTRA 138")]
    public const int WINHTTP_OPTION_ENCODE_EXTRA = 138;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_STREAM_QUEUE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_STREAM_QUEUE 139")]
    public const int WINHTTP_OPTION_DISABLE_STREAM_QUEUE = 139;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_IPV6_FAST_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_IPV6_FAST_FALLBACK 140")]
    public const int WINHTTP_OPTION_IPV6_FAST_FALLBACK = 140;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_STATS_V0"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_STATS_V0 141")]
    public const int WINHTTP_OPTION_CONNECTION_STATS_V0 = 141;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUEST_TIMES"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUEST_TIMES 142")]
    public const int WINHTTP_OPTION_REQUEST_TIMES = 142;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_EXPIRE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_EXPIRE_CONNECTION 143")]
    public const int WINHTTP_OPTION_EXPIRE_CONNECTION = 143;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_SECURE_PROTOCOL_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_SECURE_PROTOCOL_FALLBACK 144")]
    public const int WINHTTP_OPTION_DISABLE_SECURE_PROTOCOL_FALLBACK = 144;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP_PROTOCOL_REQUIRED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP_PROTOCOL_REQUIRED 145")]
    public const int WINHTTP_OPTION_HTTP_PROTOCOL_REQUIRED = 145;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUEST_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUEST_STATS 146")]
    public const int WINHTTP_OPTION_REQUEST_STATS = 146;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_CERT_CHAIN_CONTEXT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CHAIN_CONTEXT 147")]
    public const int WINHTTP_OPTION_SERVER_CERT_CHAIN_CONTEXT = 147;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_FLAGS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_FLAGS 148")]
    public const int WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_FLAGS = 148;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_STATS_V1"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_STATS_V1 150")]
    public const int WINHTTP_OPTION_CONNECTION_STATS_V1 = 150;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SECURITY_INFO"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SECURITY_INFO 151")]
    public const int WINHTTP_OPTION_SECURITY_INFO = 151;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TCP_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TCP_KEEPALIVE 152")]
    public const int WINHTTP_OPTION_TCP_KEEPALIVE = 152;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TCP_FAST_OPEN"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TCP_FAST_OPEN 153")]
    public const int WINHTTP_OPTION_TCP_FAST_OPEN = 153;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TLS_FALSE_START"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TLS_FALSE_START 154")]
    public const int WINHTTP_OPTION_TLS_FALSE_START = 154;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_IGNORE_CERT_REVOCATION_OFFLINE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_IGNORE_CERT_REVOCATION_OFFLINE 155")]
    public const int WINHTTP_OPTION_IGNORE_CERT_REVOCATION_OFFLINE = 155;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TLS_PROTOCOL_INSECURE_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TLS_PROTOCOL_INSECURE_FALLBACK 158")]
    public const int WINHTTP_OPTION_TLS_PROTOCOL_INSECURE_FALLBACK = 158;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_STREAM_ERROR_CODE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_STREAM_ERROR_CODE 159")]
    public const int WINHTTP_OPTION_STREAM_ERROR_CODE = 159;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUIRE_STREAM_END"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUIRE_STREAM_END 160")]
    public const int WINHTTP_OPTION_REQUIRE_STREAM_END = 160;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENABLE_HTTP2_PLUS_CLIENT_CERT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENABLE_HTTP2_PLUS_CLIENT_CERT 161")]
    public const int WINHTTP_OPTION_ENABLE_HTTP2_PLUS_CLIENT_CERT = 161;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_FAILED_CONNECTION_RETRIES"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_FAILED_CONNECTION_RETRIES 162")]
    public const int WINHTTP_OPTION_FAILED_CONNECTION_RETRIES = 162;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP2_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP2_KEEPALIVE 164")]
    public const int WINHTTP_OPTION_HTTP2_KEEPALIVE = 164;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RESOLUTION_HOSTNAME"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RESOLUTION_HOSTNAME 165")]
    public const int WINHTTP_OPTION_RESOLUTION_HOSTNAME = 165;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SET_TOKEN_BINDING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SET_TOKEN_BINDING 166")]
    public const int WINHTTP_OPTION_SET_TOKEN_BINDING = 166;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TOKEN_BINDING_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TOKEN_BINDING_PUBLIC_KEY 167")]
    public const int WINHTTP_OPTION_TOKEN_BINDING_PUBLIC_KEY = 167;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REFERER_TOKEN_BINDING_HOSTNAME"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REFERER_TOKEN_BINDING_HOSTNAME 168")]
    public const int WINHTTP_OPTION_REFERER_TOKEN_BINDING_HOSTNAME = 168;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP2_PLUS_TRANSFER_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP2_PLUS_TRANSFER_ENCODING 169")]
    public const int WINHTTP_OPTION_HTTP2_PLUS_TRANSFER_ENCODING = 169;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_RESOLVER_CACHE_CONFIG"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_RESOLVER_CACHE_CONFIG 170")]
    public const int WINHTTP_OPTION_RESOLVER_CACHE_CONFIG = 170;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_CERT_CHAIN_BUILDING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_CERT_CHAIN_BUILDING 171")]
    public const int WINHTTP_OPTION_DISABLE_CERT_CHAIN_BUILDING = 171;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_BACKGROUND_CONNECTIONS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_BACKGROUND_CONNECTIONS 172")]
    public const int WINHTTP_OPTION_BACKGROUND_CONNECTIONS = 172;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION 173")]
    public const int WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION = 173;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_TCP_PRIORITY_STATUS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_TCP_PRIORITY_STATUS 177")]
    public const int WINHTTP_OPTION_TCP_PRIORITY_STATUS = 177;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_GUID 178")]
    public const int WINHTTP_OPTION_CONNECTION_GUID = 178;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_MATCH_CONNECTION_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_MATCH_CONNECTION_GUID 179")]
    public const int WINHTTP_OPTION_MATCH_CONNECTION_GUID = 179;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP2_RECEIVE_WINDOW"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP2_RECEIVE_WINDOW 183")]
    public const int WINHTTP_OPTION_HTTP2_RECEIVE_WINDOW = 183;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_FEATURE_SUPPORTED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_FEATURE_SUPPORTED 184")]
    public const int WINHTTP_OPTION_FEATURE_SUPPORTED = 184;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_QUIC_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_QUIC_STATS 185")]
    public const int WINHTTP_OPTION_QUIC_STATS = 185;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP3_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP3_KEEPALIVE 188")]
    public const int WINHTTP_OPTION_HTTP3_KEEPALIVE = 188;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP3_HANDSHAKE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP3_HANDSHAKE_TIMEOUT 189")]
    public const int WINHTTP_OPTION_HTTP3_HANDSHAKE_TIMEOUT = 189;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP3_INITIAL_RTT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP3_INITIAL_RTT 190")]
    public const int WINHTTP_OPTION_HTTP3_INITIAL_RTT = 190;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP3_STREAM_ERROR_CODE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP3_STREAM_ERROR_CODE 191")]
    public const int WINHTTP_OPTION_HTTP3_STREAM_ERROR_CODE = 191;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUEST_ANNOTATION"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUEST_ANNOTATION 192")]
    public const int WINHTTP_OPTION_REQUEST_ANNOTATION = 192;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_PROXY_AUTH_SCHEMES"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_PROXY_AUTH_SCHEMES 193")]
    public const int WINHTTP_OPTION_DISABLE_PROXY_AUTH_SCHEMES = 193;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REVERT_IMPERSONATION_SERVER_CERT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REVERT_IMPERSONATION_SERVER_CERT 194")]
    public const int WINHTTP_OPTION_REVERT_IMPERSONATION_SERVER_CERT = 194;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DISABLE_GLOBAL_POOLING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DISABLE_GLOBAL_POOLING 195")]
    public const int WINHTTP_OPTION_DISABLE_GLOBAL_POOLING = 195;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_USE_SESSION_SCH_CRED"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_USE_SESSION_SCH_CRED 196")]
    public const int WINHTTP_OPTION_USE_SESSION_SCH_CRED = 196;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_CACHE_ONLY"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_CACHE_ONLY 199")]
    public const int WINHTTP_OPTION_SERVER_CERT_CHAIN_BUILD_CACHE_ONLY = 199;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_QUIC_STATS_V2"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_QUIC_STATS_V2 200")]
    public const int WINHTTP_OPTION_QUIC_STATS_V2 = 200;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_QUIC_STREAM_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_QUIC_STREAM_STATS 202")]
    public const int WINHTTP_OPTION_QUIC_STREAM_STATS = 202;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_USE_LOOKASIDE"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_USE_LOOKASIDE 203")]
    public const int WINHTTP_OPTION_USE_LOOKASIDE = 203;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ERROR_LOG_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ERROR_LOG_GUID 204")]
    public const int WINHTTP_OPTION_ERROR_LOG_GUID = 204;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_ENABLE_FAST_FORWARDING"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_ENABLE_FAST_FORWARDING 205")]
    public const int WINHTTP_OPTION_ENABLE_FAST_FORWARDING = 205;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_DATA"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_DATA 206")]
    public const int WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_DATA = 206;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_UPGRADE_TO_PROTOCOL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_UPGRADE_TO_PROTOCOL 207")]
    public const int WINHTTP_OPTION_UPGRADE_TO_PROTOCOL = 207;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_CONNECTION_STATS_V2"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_STATS_V2 208")]
    public const int WINHTTP_OPTION_CONNECTION_STATS_V2 = 208;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_STATUS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_STATUS 209")]
    public const int WINHTTP_OPTION_FAST_FORWARDING_RESPONSE_STATUS = 209;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_DSCP_TAG"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_DSCP_TAG 210")]
    public const int WINHTTP_OPTION_DSCP_TAG = 210;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_HTTP11_DOWNGRADE_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_HTTP11_DOWNGRADE_TTL 211")]
    public const int WINHTTP_OPTION_HTTP11_DOWNGRADE_TTL = 211;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SESSION_ERROR_LOG_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SESSION_ERROR_LOG_GUID 212")]
    public const int WINHTTP_OPTION_SESSION_ERROR_LOG_GUID = 212;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_LAST_OPTION"]/*' />
    [NativeTypeName("#define WINHTTP_LAST_OPTION WINHTTP_OPTION_SESSION_ERROR_LOG_GUID")]
    public const int WINHTTP_LAST_OPTION = 212;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_USERNAME"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_USERNAME 0x1000")]
    public const int WINHTTP_OPTION_USERNAME = 0x1000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PASSWORD"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PASSWORD 0x1001")]
    public const int WINHTTP_OPTION_PASSWORD = 0x1001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY_USERNAME"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY_USERNAME 0x1002")]
    public const int WINHTTP_OPTION_PROXY_USERNAME = 0x1002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_PROXY_PASSWORD"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_PROXY_PASSWORD 0x1003")]
    public const int WINHTTP_OPTION_PROXY_PASSWORD = 0x1003;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNS_PER_SERVER_UNLIMITED"]/*' />
    [NativeTypeName("#define WINHTTP_CONNS_PER_SERVER_UNLIMITED 0xFFFFFFFF")]
    public const uint WINHTTP_CONNS_PER_SERVER_UNLIMITED = 0xFFFFFFFF;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_RETRY_CONDITION_408"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_408 0x1")]
    public const int WINHTTP_CONNECTION_RETRY_CONDITION_408 = 0x1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE 0x2")]
    public const int WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE = 0x2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION 0x4")]
    public const int WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION = 0x4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_RETRY_CONDITION_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_MASK (WINHTTP_CONNECTION_RETRY_CONDITION_408 |             \\\r\n     WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE |   \\\r\n     WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION)")]
    public const int WINHTTP_CONNECTION_RETRY_CONDITION_MASK = (0x1 | 0x2 | 0x4);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DECOMPRESSION_FLAG_GZIP"]/*' />
    [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_GZIP 0x00000001")]
    public const int WINHTTP_DECOMPRESSION_FLAG_GZIP = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DECOMPRESSION_FLAG_DEFLATE"]/*' />
    [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_DEFLATE 0x00000002")]
    public const int WINHTTP_DECOMPRESSION_FLAG_DEFLATE = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DECOMPRESSION_FLAG_ALL"]/*' />
    [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_ALL ( \\\r\n    WINHTTP_DECOMPRESSION_FLAG_GZIP    | \\\r\n    WINHTTP_DECOMPRESSION_FLAG_DEFLATE)")]
    public const int WINHTTP_DECOMPRESSION_FLAG_ALL = (0x00000001 | 0x00000002);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROTOCOL_FLAG_HTTP2"]/*' />
    [NativeTypeName("#define WINHTTP_PROTOCOL_FLAG_HTTP2 0x1")]
    public const int WINHTTP_PROTOCOL_FLAG_HTTP2 = 0x1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROTOCOL_FLAG_HTTP3"]/*' />
    [NativeTypeName("#define WINHTTP_PROTOCOL_FLAG_HTTP3 0x2")]
    public const int WINHTTP_PROTOCOL_FLAG_HTTP3 = 0x2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROTOCOL_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_PROTOCOL_MASK (WINHTTP_PROTOCOL_FLAG_HTTP2 | WINHTTP_PROTOCOL_FLAG_HTTP3)")]
    public const int WINHTTP_PROTOCOL_MASK = (0x1 | 0x2);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REQUEST_ANNOTATION_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REQUEST_ANNOTATION_MAX_LENGTH 0xFA00")]
    public const int WINHTTP_OPTION_REQUEST_ANNOTATION_MAX_LENGTH = 0xFA00;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM 0")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_LOW"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_LOW 1")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_LOW = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_HIGH"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_HIGH 2")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_HIGH = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_PROXY_ONLY"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_PROXY_ONLY 3")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_PROXY_ONLY = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_DEFAULT"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_DEFAULT WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_DEFAULT = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTOLOGON_SECURITY_LEVEL_MAX"]/*' />
    [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_MAX WINHTTP_AUTOLOGON_SECURITY_LEVEL_PROXY_ONLY")]
    public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_MAX = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY_NEVER"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_NEVER 0")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY_NEVER = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP 1")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS 2")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY_LAST"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_LAST WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY_LAST = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_REDIRECT_POLICY_DEFAULT"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_DEFAULT WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP")]
    public const int WINHTTP_OPTION_REDIRECT_POLICY_DEFAULT = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_PASSPORT_AUTH"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_PASSPORT_AUTH 0x00000000")]
    public const int WINHTTP_DISABLE_PASSPORT_AUTH = 0x00000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ENABLE_PASSPORT_AUTH"]/*' />
    [NativeTypeName("#define WINHTTP_ENABLE_PASSPORT_AUTH 0x10000000")]
    public const int WINHTTP_ENABLE_PASSPORT_AUTH = 0x10000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_PASSPORT_KEYRING"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_PASSPORT_KEYRING 0x20000000")]
    public const int WINHTTP_DISABLE_PASSPORT_KEYRING = 0x20000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ENABLE_PASSPORT_KEYRING"]/*' />
    [NativeTypeName("#define WINHTTP_ENABLE_PASSPORT_KEYRING 0x40000000")]
    public const int WINHTTP_ENABLE_PASSPORT_KEYRING = 0x40000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_SCHEME_BASIC"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_SCHEME_BASIC 0x00000001")]
    public const int WINHTTP_PROXY_DISABLE_SCHEME_BASIC = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_SCHEME_DIGEST"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_SCHEME_DIGEST 0x00000002")]
    public const int WINHTTP_PROXY_DISABLE_SCHEME_DIGEST = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_SCHEME_NTLM"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_SCHEME_NTLM 0x00000004")]
    public const int WINHTTP_PROXY_DISABLE_SCHEME_NTLM = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_SCHEME_KERBEROS"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_SCHEME_KERBEROS 0x00000008")]
    public const int WINHTTP_PROXY_DISABLE_SCHEME_KERBEROS = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_SCHEME_NEGOTIATE"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_SCHEME_NEGOTIATE 0x00000010")]
    public const int WINHTTP_PROXY_DISABLE_SCHEME_NEGOTIATE = 0x00000010;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_DISABLE_AUTH_LOCAL_SERVICE"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_DISABLE_AUTH_LOCAL_SERVICE 0x00000100")]
    public const int WINHTTP_PROXY_DISABLE_AUTH_LOCAL_SERVICE = 0x00000100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_SERVER_CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL"]/*' />
    [NativeTypeName("#define WINHTTP_SERVER_CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL 0x00000004")]
    public const int WINHTTP_SERVER_CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_SERVER_CERT_CHAIN_DISABLE_AIA"]/*' />
    [NativeTypeName("#define WINHTTP_SERVER_CERT_CHAIN_DISABLE_AIA 0x00002000")]
    public const int WINHTTP_SERVER_CERT_CHAIN_DISABLE_AIA = 0x00002000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_SERVER_CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY"]/*' />
    [NativeTypeName("#define WINHTTP_SERVER_CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY 0x80000000")]
    public const uint WINHTTP_SERVER_CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY = 0x80000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_COOKIES"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_COOKIES 0x00000001")]
    public const int WINHTTP_DISABLE_COOKIES = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_REDIRECTS"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_REDIRECTS 0x00000002")]
    public const int WINHTTP_DISABLE_REDIRECTS = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_AUTHENTICATION"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_AUTHENTICATION 0x00000004")]
    public const int WINHTTP_DISABLE_AUTHENTICATION = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_KEEP_ALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_KEEP_ALIVE 0x00000008")]
    public const int WINHTTP_DISABLE_KEEP_ALIVE = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ENABLE_SSL_REVOCATION"]/*' />
    [NativeTypeName("#define WINHTTP_ENABLE_SSL_REVOCATION 0x00000001")]
    public const int WINHTTP_ENABLE_SSL_REVOCATION = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ENABLE_SSL_REVERT_IMPERSONATION"]/*' />
    [NativeTypeName("#define WINHTTP_ENABLE_SSL_REVERT_IMPERSONATION 0x00000002")]
    public const int WINHTTP_ENABLE_SSL_REVERT_IMPERSONATION = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DISABLE_SPN_SERVER_PORT"]/*' />
    [NativeTypeName("#define WINHTTP_DISABLE_SPN_SERVER_PORT 0x00000000")]
    public const int WINHTTP_DISABLE_SPN_SERVER_PORT = 0x00000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ENABLE_SPN_SERVER_PORT"]/*' />
    [NativeTypeName("#define WINHTTP_ENABLE_SPN_SERVER_PORT 0x00000001")]
    public const int WINHTTP_ENABLE_SPN_SERVER_PORT = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_OPTION_SPN_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_OPTION_SPN_MASK WINHTTP_ENABLE_SPN_SERVER_PORT")]
    public const int WINHTTP_OPTION_SPN_MASK = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_SESSION"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_SESSION 1")]
    public const int WINHTTP_HANDLE_TYPE_SESSION = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_CONNECT"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_CONNECT 2")]
    public const int WINHTTP_HANDLE_TYPE_CONNECT = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_REQUEST"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_REQUEST 3")]
    public const int WINHTTP_HANDLE_TYPE_REQUEST = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_PROXY_RESOLVER"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_PROXY_RESOLVER 4")]
    public const int WINHTTP_HANDLE_TYPE_PROXY_RESOLVER = 4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_WEBSOCKET"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_WEBSOCKET 5")]
    public const int WINHTTP_HANDLE_TYPE_WEBSOCKET = 5;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HANDLE_TYPE_PROTOCOL"]/*' />
    [NativeTypeName("#define WINHTTP_HANDLE_TYPE_PROTOCOL 6")]
    public const int WINHTTP_HANDLE_TYPE_PROTOCOL = 6;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_SCHEME_BASIC"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_SCHEME_BASIC 0x00000001")]
    public const int WINHTTP_AUTH_SCHEME_BASIC = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_SCHEME_NTLM"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_SCHEME_NTLM 0x00000002")]
    public const int WINHTTP_AUTH_SCHEME_NTLM = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_SCHEME_PASSPORT"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_SCHEME_PASSPORT 0x00000004")]
    public const int WINHTTP_AUTH_SCHEME_PASSPORT = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_SCHEME_DIGEST"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_SCHEME_DIGEST 0x00000008")]
    public const int WINHTTP_AUTH_SCHEME_DIGEST = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_SCHEME_NEGOTIATE"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_SCHEME_NEGOTIATE 0x00000010")]
    public const int WINHTTP_AUTH_SCHEME_NEGOTIATE = 0x00000010;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_TARGET_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_TARGET_SERVER 0x00000000")]
    public const int WINHTTP_AUTH_TARGET_SERVER = 0x00000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_AUTH_TARGET_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_AUTH_TARGET_PROXY 0x00000001")]
    public const int WINHTTP_AUTH_TARGET_PROXY = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_CERT_REV_FAILED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_REV_FAILED 0x00000001")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_REV_FAILED = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CERT"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CERT 0x00000002")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CERT = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_CERT_REVOKED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_REVOKED 0x00000004")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_REVOKED = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CA"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CA 0x00000008")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CA = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_CERT_CN_INVALID"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_CN_INVALID 0x00000010")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_CN_INVALID = 0x00000010;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_CERT_DATE_INVALID"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_DATE_INVALID 0x00000020")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_DATE_INVALID = 0x00000020;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_CERT_WRONG_USAGE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_WRONG_USAGE 0x00000040")]
    public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_WRONG_USAGE = 0x00000040;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_FLAG_SECURITY_CHANNEL_ERROR"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_SECURITY_CHANNEL_ERROR 0x80000000")]
    public const uint WINHTTP_CALLBACK_STATUS_FLAG_SECURITY_CHANNEL_ERROR = 0x80000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_SSL2"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 0x00000008")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_SSL3"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 0x00000020")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 = 0x00000020;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_TLS1"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1 0x00000080")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1 = 0x00000080;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_1"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_1 0x00000200")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_1 = 0x00000200;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2 0x00000800")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2 = 0x00000800;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_3"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_3 0x00002000")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_3 = 0x00002000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FLAG_SECURE_PROTOCOL_ALL"]/*' />
    [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_ALL (WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 | \\\r\n                                             WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 | \\\r\n                                             WINHTTP_FLAG_SECURE_PROTOCOL_TLS1)")]
    public const int WINHTTP_FLAG_SECURE_PROTOCOL_ALL = (0x00000008 | 0x00000020 | 0x00000080);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_RESOLVING_NAME"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RESOLVING_NAME 0x00000001")]
    public const int WINHTTP_CALLBACK_STATUS_RESOLVING_NAME = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_NAME_RESOLVED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_NAME_RESOLVED 0x00000002")]
    public const int WINHTTP_CALLBACK_STATUS_NAME_RESOLVED = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER 0x00000004")]
    public const int WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER 0x00000008")]
    public const int WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SENDING_REQUEST"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SENDING_REQUEST 0x00000010")]
    public const int WINHTTP_CALLBACK_STATUS_SENDING_REQUEST = 0x00000010;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_REQUEST_SENT"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REQUEST_SENT 0x00000020")]
    public const int WINHTTP_CALLBACK_STATUS_REQUEST_SENT = 0x00000020;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE 0x00000040")]
    public const int WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE = 0x00000040;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED 0x00000080")]
    public const int WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED = 0x00000080;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION 0x00000100")]
    public const int WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION = 0x00000100;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED 0x00000200")]
    public const int WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED = 0x00000200;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_HANDLE_CREATED"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HANDLE_CREATED 0x00000400")]
    public const int WINHTTP_CALLBACK_STATUS_HANDLE_CREATED = 0x00000400;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING 0x00000800")]
    public const int WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING = 0x00000800;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_DETECTING_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_DETECTING_PROXY 0x00001000")]
    public const int WINHTTP_CALLBACK_STATUS_DETECTING_PROXY = 0x00001000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_REDIRECT"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REDIRECT 0x00004000")]
    public const int WINHTTP_CALLBACK_STATUS_REDIRECT = 0x00004000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE 0x00008000")]
    public const int WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE = 0x00008000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SECURE_FAILURE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SECURE_FAILURE 0x00010000")]
    public const int WINHTTP_CALLBACK_STATUS_SECURE_FAILURE = 0x00010000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE 0x00020000")]
    public const int WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE = 0x00020000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE 0x00040000")]
    public const int WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE = 0x00040000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_READ_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_READ_COMPLETE 0x00080000")]
    public const int WINHTTP_CALLBACK_STATUS_READ_COMPLETE = 0x00080000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE 0x00100000")]
    public const int WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE = 0x00100000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_REQUEST_ERROR"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REQUEST_ERROR 0x00200000")]
    public const int WINHTTP_CALLBACK_STATUS_REQUEST_ERROR = 0x00200000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE 0x00400000")]
    public const int WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE = 0x00400000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE 0x01000000")]
    public const int WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE = 0x01000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_CLOSE_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CLOSE_COMPLETE 0x02000000")]
    public const int WINHTTP_CALLBACK_STATUS_CLOSE_COMPLETE = 0x02000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SHUTDOWN_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SHUTDOWN_COMPLETE 0x04000000")]
    public const int WINHTTP_CALLBACK_STATUS_SHUTDOWN_COMPLETE = 0x04000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_GETPROXYSETTINGS_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_GETPROXYSETTINGS_COMPLETE 0x08000000")]
    public const int WINHTTP_CALLBACK_STATUS_GETPROXYSETTINGS_COMPLETE = 0x08000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SETTINGS_WRITE_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SETTINGS_WRITE_COMPLETE 0x10000000")]
    public const int WINHTTP_CALLBACK_STATUS_SETTINGS_WRITE_COMPLETE = 0x10000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_STATUS_SETTINGS_READ_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SETTINGS_READ_COMPLETE 0x20000000")]
    public const int WINHTTP_CALLBACK_STATUS_SETTINGS_READ_COMPLETE = 0x20000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_RESOLVE_NAME"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_RESOLVE_NAME (WINHTTP_CALLBACK_STATUS_RESOLVING_NAME | WINHTTP_CALLBACK_STATUS_NAME_RESOLVED)")]
    public const int WINHTTP_CALLBACK_FLAG_RESOLVE_NAME = (0x00000001 | 0x00000002);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_CONNECT_TO_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_CONNECT_TO_SERVER (WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER | WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER)")]
    public const int WINHTTP_CALLBACK_FLAG_CONNECT_TO_SERVER = (0x00000004 | 0x00000008);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_SEND_REQUEST"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SEND_REQUEST (WINHTTP_CALLBACK_STATUS_SENDING_REQUEST | WINHTTP_CALLBACK_STATUS_REQUEST_SENT)")]
    public const int WINHTTP_CALLBACK_FLAG_SEND_REQUEST = (0x00000010 | 0x00000020);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_RECEIVE_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_RECEIVE_RESPONSE (WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE | WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED)")]
    public const int WINHTTP_CALLBACK_FLAG_RECEIVE_RESPONSE = (0x00000040 | 0x00000080);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_CLOSE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_CLOSE_CONNECTION (WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION | WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED)")]
    public const int WINHTTP_CALLBACK_FLAG_CLOSE_CONNECTION = (0x00000100 | 0x00000200);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_HANDLES"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_HANDLES (WINHTTP_CALLBACK_STATUS_HANDLE_CREATED | WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING)")]
    public const int WINHTTP_CALLBACK_FLAG_HANDLES = (0x00000400 | 0x00000800);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_DETECTING_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_DETECTING_PROXY WINHTTP_CALLBACK_STATUS_DETECTING_PROXY")]
    public const int WINHTTP_CALLBACK_FLAG_DETECTING_PROXY = 0x00001000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_REDIRECT"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_REDIRECT WINHTTP_CALLBACK_STATUS_REDIRECT")]
    public const int WINHTTP_CALLBACK_FLAG_REDIRECT = 0x00004000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_INTERMEDIATE_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_INTERMEDIATE_RESPONSE WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE")]
    public const int WINHTTP_CALLBACK_FLAG_INTERMEDIATE_RESPONSE = 0x00008000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_SECURE_FAILURE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SECURE_FAILURE WINHTTP_CALLBACK_STATUS_SECURE_FAILURE")]
    public const int WINHTTP_CALLBACK_FLAG_SECURE_FAILURE = 0x00010000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_SENDREQUEST_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SENDREQUEST_COMPLETE WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE")]
    public const int WINHTTP_CALLBACK_FLAG_SENDREQUEST_COMPLETE = 0x00400000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_HEADERS_AVAILABLE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_HEADERS_AVAILABLE WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE")]
    public const int WINHTTP_CALLBACK_FLAG_HEADERS_AVAILABLE = 0x00020000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_DATA_AVAILABLE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_DATA_AVAILABLE WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE")]
    public const int WINHTTP_CALLBACK_FLAG_DATA_AVAILABLE = 0x00040000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_READ_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_READ_COMPLETE WINHTTP_CALLBACK_STATUS_READ_COMPLETE")]
    public const int WINHTTP_CALLBACK_FLAG_READ_COMPLETE = 0x00080000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_WRITE_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_WRITE_COMPLETE WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE")]
    public const int WINHTTP_CALLBACK_FLAG_WRITE_COMPLETE = 0x00100000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_REQUEST_ERROR"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_REQUEST_ERROR WINHTTP_CALLBACK_STATUS_REQUEST_ERROR")]
    public const int WINHTTP_CALLBACK_FLAG_REQUEST_ERROR = 0x00200000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_GETPROXYFORURL_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_GETPROXYFORURL_COMPLETE WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE")]
    public const int WINHTTP_CALLBACK_FLAG_GETPROXYFORURL_COMPLETE = 0x01000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_GETPROXYSETTINGS_COMPLETE"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_GETPROXYSETTINGS_COMPLETE WINHTTP_CALLBACK_STATUS_GETPROXYSETTINGS_COMPLETE")]
    public const int WINHTTP_CALLBACK_FLAG_GETPROXYSETTINGS_COMPLETE = 0x08000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_ALL_COMPLETIONS"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_ALL_COMPLETIONS (WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE       \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE         \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE            \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_READ_COMPLETE             \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE            \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_REQUEST_ERROR             \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE   \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_GETPROXYSETTINGS_COMPLETE)")]
    public const int WINHTTP_CALLBACK_FLAG_ALL_COMPLETIONS = (0x00400000 | 0x00020000 | 0x00040000 | 0x00080000 | 0x00100000 | 0x00200000 | 0x01000000 | 0x08000000);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CALLBACK_FLAG_ALL_NOTIFICATIONS"]/*' />
    [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_ALL_NOTIFICATIONS 0xffffffff")]
    public const uint WINHTTP_CALLBACK_FLAG_ALL_NOTIFICATIONS = 0xffffffff;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_MIME_VERSION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_MIME_VERSION 0")]
    public const int WINHTTP_QUERY_MIME_VERSION = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_TYPE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_TYPE 1")]
    public const int WINHTTP_QUERY_CONTENT_TYPE = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_TRANSFER_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_TRANSFER_ENCODING 2")]
    public const int WINHTTP_QUERY_CONTENT_TRANSFER_ENCODING = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_ID"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_ID 3")]
    public const int WINHTTP_QUERY_CONTENT_ID = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_DESCRIPTION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_DESCRIPTION 4")]
    public const int WINHTTP_QUERY_CONTENT_DESCRIPTION = 4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LENGTH 5")]
    public const int WINHTTP_QUERY_CONTENT_LENGTH = 5;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_LANGUAGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LANGUAGE 6")]
    public const int WINHTTP_QUERY_CONTENT_LANGUAGE = 6;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ALLOW"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ALLOW 7")]
    public const int WINHTTP_QUERY_ALLOW = 7;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PUBLIC"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PUBLIC 8")]
    public const int WINHTTP_QUERY_PUBLIC = 8;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_DATE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_DATE 9")]
    public const int WINHTTP_QUERY_DATE = 9;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_EXPIRES"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_EXPIRES 10")]
    public const int WINHTTP_QUERY_EXPIRES = 10;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_LAST_MODIFIED"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_LAST_MODIFIED 11")]
    public const int WINHTTP_QUERY_LAST_MODIFIED = 11;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_MESSAGE_ID"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_MESSAGE_ID 12")]
    public const int WINHTTP_QUERY_MESSAGE_ID = 12;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_URI"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_URI 13")]
    public const int WINHTTP_QUERY_URI = 13;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_DERIVED_FROM"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_DERIVED_FROM 14")]
    public const int WINHTTP_QUERY_DERIVED_FROM = 14;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_COST"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_COST 15")]
    public const int WINHTTP_QUERY_COST = 15;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_LINK"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_LINK 16")]
    public const int WINHTTP_QUERY_LINK = 16;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PRAGMA"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PRAGMA 17")]
    public const int WINHTTP_QUERY_PRAGMA = 17;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_VERSION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_VERSION 18")]
    public const int WINHTTP_QUERY_VERSION = 18;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_STATUS_CODE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_STATUS_CODE 19")]
    public const int WINHTTP_QUERY_STATUS_CODE = 19;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_STATUS_TEXT"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_STATUS_TEXT 20")]
    public const int WINHTTP_QUERY_STATUS_TEXT = 20;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_RAW_HEADERS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_RAW_HEADERS 21")]
    public const int WINHTTP_QUERY_RAW_HEADERS = 21;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_RAW_HEADERS_CRLF"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_RAW_HEADERS_CRLF 22")]
    public const int WINHTTP_QUERY_RAW_HEADERS_CRLF = 22;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONNECTION 23")]
    public const int WINHTTP_QUERY_CONNECTION = 23;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ACCEPT"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ACCEPT 24")]
    public const int WINHTTP_QUERY_ACCEPT = 24;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ACCEPT_CHARSET"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_CHARSET 25")]
    public const int WINHTTP_QUERY_ACCEPT_CHARSET = 25;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ACCEPT_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_ENCODING 26")]
    public const int WINHTTP_QUERY_ACCEPT_ENCODING = 26;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ACCEPT_LANGUAGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_LANGUAGE 27")]
    public const int WINHTTP_QUERY_ACCEPT_LANGUAGE = 27;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_AUTHORIZATION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_AUTHORIZATION 28")]
    public const int WINHTTP_QUERY_AUTHORIZATION = 28;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_ENCODING 29")]
    public const int WINHTTP_QUERY_CONTENT_ENCODING = 29;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FORWARDED"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FORWARDED 30")]
    public const int WINHTTP_QUERY_FORWARDED = 30;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FROM"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FROM 31")]
    public const int WINHTTP_QUERY_FROM = 31;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_IF_MODIFIED_SINCE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_IF_MODIFIED_SINCE 32")]
    public const int WINHTTP_QUERY_IF_MODIFIED_SINCE = 32;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_LOCATION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_LOCATION 33")]
    public const int WINHTTP_QUERY_LOCATION = 33;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ORIG_URI"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ORIG_URI 34")]
    public const int WINHTTP_QUERY_ORIG_URI = 34;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_REFERER"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_REFERER 35")]
    public const int WINHTTP_QUERY_REFERER = 35;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_RETRY_AFTER"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_RETRY_AFTER 36")]
    public const int WINHTTP_QUERY_RETRY_AFTER = 36;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_SERVER"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_SERVER 37")]
    public const int WINHTTP_QUERY_SERVER = 37;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_TITLE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_TITLE 38")]
    public const int WINHTTP_QUERY_TITLE = 38;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_USER_AGENT"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_USER_AGENT 39")]
    public const int WINHTTP_QUERY_USER_AGENT = 39;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_WWW_AUTHENTICATE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_WWW_AUTHENTICATE 40")]
    public const int WINHTTP_QUERY_WWW_AUTHENTICATE = 40;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PROXY_AUTHENTICATE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PROXY_AUTHENTICATE 41")]
    public const int WINHTTP_QUERY_PROXY_AUTHENTICATE = 41;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ACCEPT_RANGES"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_RANGES 42")]
    public const int WINHTTP_QUERY_ACCEPT_RANGES = 42;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_SET_COOKIE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_SET_COOKIE 43")]
    public const int WINHTTP_QUERY_SET_COOKIE = 43;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_COOKIE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_COOKIE 44")]
    public const int WINHTTP_QUERY_COOKIE = 44;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_REQUEST_METHOD"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_REQUEST_METHOD 45")]
    public const int WINHTTP_QUERY_REQUEST_METHOD = 45;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_REFRESH"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_REFRESH 46")]
    public const int WINHTTP_QUERY_REFRESH = 46;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_DISPOSITION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_DISPOSITION 47")]
    public const int WINHTTP_QUERY_CONTENT_DISPOSITION = 47;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_AGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_AGE 48")]
    public const int WINHTTP_QUERY_AGE = 48;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CACHE_CONTROL"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CACHE_CONTROL 49")]
    public const int WINHTTP_QUERY_CACHE_CONTROL = 49;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_BASE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_BASE 50")]
    public const int WINHTTP_QUERY_CONTENT_BASE = 50;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_LOCATION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LOCATION 51")]
    public const int WINHTTP_QUERY_CONTENT_LOCATION = 51;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_MD5"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_MD5 52")]
    public const int WINHTTP_QUERY_CONTENT_MD5 = 52;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CONTENT_RANGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CONTENT_RANGE 53")]
    public const int WINHTTP_QUERY_CONTENT_RANGE = 53;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_ETAG"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_ETAG 54")]
    public const int WINHTTP_QUERY_ETAG = 54;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_HOST"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_HOST 55")]
    public const int WINHTTP_QUERY_HOST = 55;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_IF_MATCH"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_IF_MATCH 56")]
    public const int WINHTTP_QUERY_IF_MATCH = 56;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_IF_NONE_MATCH"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_IF_NONE_MATCH 57")]
    public const int WINHTTP_QUERY_IF_NONE_MATCH = 57;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_IF_RANGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_IF_RANGE 58")]
    public const int WINHTTP_QUERY_IF_RANGE = 58;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_IF_UNMODIFIED_SINCE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_IF_UNMODIFIED_SINCE 59")]
    public const int WINHTTP_QUERY_IF_UNMODIFIED_SINCE = 59;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_MAX_FORWARDS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_MAX_FORWARDS 60")]
    public const int WINHTTP_QUERY_MAX_FORWARDS = 60;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PROXY_AUTHORIZATION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PROXY_AUTHORIZATION 61")]
    public const int WINHTTP_QUERY_PROXY_AUTHORIZATION = 61;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_RANGE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_RANGE 62")]
    public const int WINHTTP_QUERY_RANGE = 62;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_TRANSFER_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_TRANSFER_ENCODING 63")]
    public const int WINHTTP_QUERY_TRANSFER_ENCODING = 63;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_UPGRADE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_UPGRADE 64")]
    public const int WINHTTP_QUERY_UPGRADE = 64;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_VARY"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_VARY 65")]
    public const int WINHTTP_QUERY_VARY = 65;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_VIA"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_VIA 66")]
    public const int WINHTTP_QUERY_VIA = 66;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_WARNING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_WARNING 67")]
    public const int WINHTTP_QUERY_WARNING = 67;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_EXPECT"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_EXPECT 68")]
    public const int WINHTTP_QUERY_EXPECT = 68;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PROXY_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PROXY_CONNECTION 69")]
    public const int WINHTTP_QUERY_PROXY_CONNECTION = 69;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_UNLESS_MODIFIED_SINCE"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_UNLESS_MODIFIED_SINCE 70")]
    public const int WINHTTP_QUERY_UNLESS_MODIFIED_SINCE = 70;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PROXY_SUPPORT"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PROXY_SUPPORT 75")]
    public const int WINHTTP_QUERY_PROXY_SUPPORT = 75;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_AUTHENTICATION_INFO"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_AUTHENTICATION_INFO 76")]
    public const int WINHTTP_QUERY_AUTHENTICATION_INFO = 76;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PASSPORT_URLS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PASSPORT_URLS 77")]
    public const int WINHTTP_QUERY_PASSPORT_URLS = 77;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_PASSPORT_CONFIG"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_PASSPORT_CONFIG 78")]
    public const int WINHTTP_QUERY_PASSPORT_CONFIG = 78;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_MAX"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_MAX 78")]
    public const int WINHTTP_QUERY_MAX = 78;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_EX_ALL_HEADERS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_EX_ALL_HEADERS WINHTTP_QUERY_RAW_HEADERS")]
    public const int WINHTTP_QUERY_EX_ALL_HEADERS = 21;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_CUSTOM"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_CUSTOM 65535")]
    public const int WINHTTP_QUERY_CUSTOM = 65535;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_REQUEST_HEADERS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_REQUEST_HEADERS 0x80000000")]
    public const uint WINHTTP_QUERY_FLAG_REQUEST_HEADERS = 0x80000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_SYSTEMTIME"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_SYSTEMTIME 0x40000000")]
    public const int WINHTTP_QUERY_FLAG_SYSTEMTIME = 0x40000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_NUMBER"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_NUMBER 0x20000000")]
    public const int WINHTTP_QUERY_FLAG_NUMBER = 0x20000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_NUMBER64"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_NUMBER64 0x08000000")]
    public const int WINHTTP_QUERY_FLAG_NUMBER64 = 0x08000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_TRAILERS"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_TRAILERS 0x02000000")]
    public const int WINHTTP_QUERY_FLAG_TRAILERS = 0x02000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_QUERY_FLAG_WIRE_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_QUERY_FLAG_WIRE_ENCODING 0x01000000")]
    public const int WINHTTP_QUERY_FLAG_WIRE_ENCODING = 0x01000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ACCESS_TYPE_DEFAULT_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_ACCESS_TYPE_DEFAULT_PROXY 0")]
    public const int WINHTTP_ACCESS_TYPE_DEFAULT_PROXY = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ACCESS_TYPE_NO_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_ACCESS_TYPE_NO_PROXY 1")]
    public const int WINHTTP_ACCESS_TYPE_NO_PROXY = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ACCESS_TYPE_NAMED_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_ACCESS_TYPE_NAMED_PROXY 3")]
    public const int WINHTTP_ACCESS_TYPE_NAMED_PROXY = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ACCESS_TYPE_AUTOMATIC_PROXY"]/*' />
    [NativeTypeName("#define WINHTTP_ACCESS_TYPE_AUTOMATIC_PROXY 4")]
    public const int WINHTTP_ACCESS_TYPE_AUTOMATIC_PROXY = 4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_PROXY_NAME"]/*' />
    [NativeTypeName("#define WINHTTP_NO_PROXY_NAME NULL")]
    public const int WINHTTP_NO_PROXY_NAME = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_PROXY_BYPASS"]/*' />
    [NativeTypeName("#define WINHTTP_NO_PROXY_BYPASS NULL")]
    public const int WINHTTP_NO_PROXY_BYPASS = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_CLIENT_CERT_CONTEXT"]/*' />
    [NativeTypeName("#define WINHTTP_NO_CLIENT_CERT_CONTEXT NULL")]
    public const int WINHTTP_NO_CLIENT_CERT_CONTEXT = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_REFERER"]/*' />
    [NativeTypeName("#define WINHTTP_NO_REFERER NULL")]
    public const int WINHTTP_NO_REFERER = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_DEFAULT_ACCEPT_TYPES"]/*' />
    [NativeTypeName("#define WINHTTP_DEFAULT_ACCEPT_TYPES NULL")]
    public const int WINHTTP_DEFAULT_ACCEPT_TYPES = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_INDEX_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_INDEX_MASK 0x0000FFFF")]
    public const int WINHTTP_ADDREQ_INDEX_MASK = 0x0000FFFF;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAGS_MASK"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAGS_MASK 0xFFFF0000")]
    public const uint WINHTTP_ADDREQ_FLAGS_MASK = 0xFFFF0000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_ADD_IF_NEW"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_ADD_IF_NEW 0x10000000")]
    public const int WINHTTP_ADDREQ_FLAG_ADD_IF_NEW = 0x10000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_ADD"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_ADD 0x20000000")]
    public const int WINHTTP_ADDREQ_FLAG_ADD = 0x20000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA 0x40000000")]
    public const int WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA = 0x40000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_COALESCE_WITH_SEMICOLON"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE_WITH_SEMICOLON 0x01000000")]
    public const int WINHTTP_ADDREQ_FLAG_COALESCE_WITH_SEMICOLON = 0x01000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_COALESCE"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA")]
    public const int WINHTTP_ADDREQ_FLAG_COALESCE = 0x40000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ADDREQ_FLAG_REPLACE"]/*' />
    [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_REPLACE 0x80000000")]
    public const uint WINHTTP_ADDREQ_FLAG_REPLACE = 0x80000000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_EXTENDED_HEADER_FLAG_UNICODE"]/*' />
    [NativeTypeName("#define WINHTTP_EXTENDED_HEADER_FLAG_UNICODE 0x00000001")]
    public const int WINHTTP_EXTENDED_HEADER_FLAG_UNICODE = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_READ_DATA_EX_FLAG_FILL_BUFFER"]/*' />
    [NativeTypeName("#define WINHTTP_READ_DATA_EX_FLAG_FILL_BUFFER 0x0000000000000001ull")]
    public const ulong WINHTTP_READ_DATA_EX_FLAG_FILL_BUFFER = 0x0000000000000001UL;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_IGNORE_REQUEST_TOTAL_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_IGNORE_REQUEST_TOTAL_LENGTH 0")]
    public const int WINHTTP_IGNORE_REQUEST_TOTAL_LENGTH = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_ADDITIONAL_HEADERS"]/*' />
    [NativeTypeName("#define WINHTTP_NO_ADDITIONAL_HEADERS NULL")]
    public const int WINHTTP_NO_ADDITIONAL_HEADERS = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_REQUEST_DATA"]/*' />
    [NativeTypeName("#define WINHTTP_NO_REQUEST_DATA NULL")]
    public const int WINHTTP_NO_REQUEST_DATA = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_HEADER_NAME_BY_INDEX"]/*' />
    [NativeTypeName("#define WINHTTP_HEADER_NAME_BY_INDEX NULL")]
    public const int WINHTTP_HEADER_NAME_BY_INDEX = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_OUTPUT_BUFFER"]/*' />
    [NativeTypeName("#define WINHTTP_NO_OUTPUT_BUFFER NULL")]
    public const int WINHTTP_NO_OUTPUT_BUFFER = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_NO_HEADER_INDEX"]/*' />
    [NativeTypeName("#define WINHTTP_NO_HEADER_INDEX NULL")]
    public const int WINHTTP_NO_HEADER_INDEX = 0;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ERROR_BASE"]/*' />
    [NativeTypeName("#define WINHTTP_ERROR_BASE 12000")]
    public const int WINHTTP_ERROR_BASE = 12000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_ERROR_LAST"]/*' />
    [NativeTypeName("#define WINHTTP_ERROR_LAST ERROR_WINHTTP_FAST_FORWARDING_NOT_SUPPORTED")]
    public const int WINHTTP_ERROR_LAST = (12000 + 193);

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_STATE"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_STATE 0x00000001")]
    public const int WINHTTP_RESET_STATE = 0x00000001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_SWPAD_CURRENT_NETWORK"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_SWPAD_CURRENT_NETWORK 0x00000002")]
    public const int WINHTTP_RESET_SWPAD_CURRENT_NETWORK = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_SWPAD_ALL"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_SWPAD_ALL 0x00000004")]
    public const int WINHTTP_RESET_SWPAD_ALL = 0x00000004;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_SCRIPT_CACHE"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_SCRIPT_CACHE 0x00000008")]
    public const int WINHTTP_RESET_SCRIPT_CACHE = 0x00000008;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_ALL"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_ALL 0x0000FFFF")]
    public const int WINHTTP_RESET_ALL = 0x0000FFFF;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_NOTIFY_NETWORK_CHANGED"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_NOTIFY_NETWORK_CHANGED 0x00010000")]
    public const int WINHTTP_RESET_NOTIFY_NETWORK_CHANGED = 0x00010000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_OUT_OF_PROC"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_OUT_OF_PROC 0x00020000")]
    public const int WINHTTP_RESET_OUT_OF_PROC = 0x00020000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_RESET_DISCARD_RESOLVERS"]/*' />
    [NativeTypeName("#define WINHTTP_RESET_DISCARD_RESOLVERS 0x00040000")]
    public const int WINHTTP_RESET_DISCARD_RESOLVERS = 0x00040000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_WEB_SOCKET_MAX_CLOSE_REASON_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_WEB_SOCKET_MAX_CLOSE_REASON_LENGTH 123")]
    public const int WINHTTP_WEB_SOCKET_MAX_CLOSE_REASON_LENGTH = 123;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_WEB_SOCKET_MIN_KEEPALIVE_VALUE"]/*' />
    [NativeTypeName("#define WINHTTP_WEB_SOCKET_MIN_KEEPALIVE_VALUE 15000")]
    public const int WINHTTP_WEB_SOCKET_MIN_KEEPALIVE_VALUE = 15000;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_NAME_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_NAME_MAX_LENGTH 64")]
    public const int WINHTTP_CONNECTION_NAME_MAX_LENGTH = 64;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_CURRENT_VERSION"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_CURRENT_VERSION 1")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_CURRENT_VERSION = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_SERVER_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_SERVER_MAX_LENGTH 256")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_SERVER_MAX_LENGTH = 256;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_FRIENDLY_NAME_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_FRIENDLY_NAME_MAX_LENGTH 64")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_FRIENDLY_NAME_MAX_LENGTH = 64;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_USERNAME_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_USERNAME_MAX_LENGTH 128")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_USERNAME_MAX_LENGTH = 128;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_PASSWORD_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_PASSWORD_MAX_LENGTH 128")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_PASSWORD_MAX_LENGTH = 128;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_EXCEPTION_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_EXCEPTION_MAX_LENGTH 1024")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_EXCEPTION_MAX_LENGTH = 1024;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_EXTRA_INFO_MAX_LENGTH"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_EXTRA_INFO_MAX_LENGTH 1024")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_EXTRA_INFO_MAX_LENGTH = 1024;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_FLAG_DISABLED"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_FLAG_DISABLED 0x1")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_FLAG_DISABLED = 0x1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_PROXY_INFO_FLAG_BYPASSLOCAL"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_PROXY_INFO_FLAG_BYPASSLOCAL 0x2")]
    public const int WINHTTP_CONNECTION_PROXY_INFO_FLAG_BYPASSLOCAL = 0x2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_CONNECTION_POLICY_ALLOW_DEFAULT_INTERFACE_SELECTION"]/*' />
    [NativeTypeName("#define WINHTTP_CONNECTION_POLICY_ALLOW_DEFAULT_INTERFACE_SELECTION 0x00000002")]
    public const int WINHTTP_CONNECTION_POLICY_ALLOW_DEFAULT_INTERFACE_SELECTION = 0x00000002;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_PROXY_NOTIFY_CHANGE"]/*' />
    [NativeTypeName("#define WINHTTP_PROXY_NOTIFY_CHANGE 0x0001")]
    public const int WINHTTP_PROXY_NOTIFY_CHANGE = 0x0001;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_STREAM_QUEUE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_STREAM_QUEUE 1")]
    public const int WINHTTP_FEATURE_DISABLE_STREAM_QUEUE = 1;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_IPV6_FAST_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_IPV6_FAST_FALLBACK 2")]
    public const int WINHTTP_FEATURE_IPV6_FAST_FALLBACK = 2;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_CONNECTION_STATS_V0"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_CONNECTION_STATS_V0 3")]
    public const int WINHTTP_FEATURE_CONNECTION_STATS_V0 = 3;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REQUEST_TIMES"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REQUEST_TIMES 4")]
    public const int WINHTTP_FEATURE_REQUEST_TIMES = 4;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_EXPIRE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_EXPIRE_CONNECTION 5")]
    public const int WINHTTP_FEATURE_EXPIRE_CONNECTION = 5;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_SECURE_PROTOCOL_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_SECURE_PROTOCOL_FALLBACK 6")]
    public const int WINHTTP_FEATURE_DISABLE_SECURE_PROTOCOL_FALLBACK = 6;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP_PROTOCOL_REQUIRED"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP_PROTOCOL_REQUIRED 7")]
    public const int WINHTTP_FEATURE_HTTP_PROTOCOL_REQUIRED = 7;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REQUEST_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REQUEST_STATS 8")]
    public const int WINHTTP_FEATURE_REQUEST_STATS = 8;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SERVER_CERT_CHAIN_CONTEXT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SERVER_CERT_CHAIN_CONTEXT 9")]
    public const int WINHTTP_FEATURE_SERVER_CERT_CHAIN_CONTEXT = 9;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_CONNECTION_STATS_V1"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_CONNECTION_STATS_V1 12")]
    public const int WINHTTP_FEATURE_CONNECTION_STATS_V1 = 12;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SECURITY_INFO"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SECURITY_INFO 13")]
    public const int WINHTTP_FEATURE_SECURITY_INFO = 13;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TCP_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TCP_KEEPALIVE 14")]
    public const int WINHTTP_FEATURE_TCP_KEEPALIVE = 14;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TCP_FAST_OPEN"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TCP_FAST_OPEN 15")]
    public const int WINHTTP_FEATURE_TCP_FAST_OPEN = 15;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TLS_FALSE_START"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TLS_FALSE_START 16")]
    public const int WINHTTP_FEATURE_TLS_FALSE_START = 16;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_IGNORE_CERT_REVOCATION_OFFLINE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_IGNORE_CERT_REVOCATION_OFFLINE 17")]
    public const int WINHTTP_FEATURE_IGNORE_CERT_REVOCATION_OFFLINE = 17;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TLS_PROTOCOL_INSECURE_FALLBACK"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TLS_PROTOCOL_INSECURE_FALLBACK 20")]
    public const int WINHTTP_FEATURE_TLS_PROTOCOL_INSECURE_FALLBACK = 20;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_STREAM_ERROR_CODE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_STREAM_ERROR_CODE 21")]
    public const int WINHTTP_FEATURE_STREAM_ERROR_CODE = 21;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REQUIRE_STREAM_END"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REQUIRE_STREAM_END 22")]
    public const int WINHTTP_FEATURE_REQUIRE_STREAM_END = 22;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_ENABLE_HTTP2_PLUS_CLIENT_CERT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_ENABLE_HTTP2_PLUS_CLIENT_CERT 23")]
    public const int WINHTTP_FEATURE_ENABLE_HTTP2_PLUS_CLIENT_CERT = 23;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FAILED_CONNECTION_RETRIES"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FAILED_CONNECTION_RETRIES 24")]
    public const int WINHTTP_FEATURE_FAILED_CONNECTION_RETRIES = 24;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP2_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP2_KEEPALIVE 26")]
    public const int WINHTTP_FEATURE_HTTP2_KEEPALIVE = 26;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLUTION_HOSTNAME"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLUTION_HOSTNAME 27")]
    public const int WINHTTP_FEATURE_RESOLUTION_HOSTNAME = 27;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SET_TOKEN_BINDING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SET_TOKEN_BINDING 28")]
    public const int WINHTTP_FEATURE_SET_TOKEN_BINDING = 28;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TOKEN_BINDING_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TOKEN_BINDING_PUBLIC_KEY 29")]
    public const int WINHTTP_FEATURE_TOKEN_BINDING_PUBLIC_KEY = 29;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REFERER_TOKEN_BINDING_HOSTNAME"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REFERER_TOKEN_BINDING_HOSTNAME 30")]
    public const int WINHTTP_FEATURE_REFERER_TOKEN_BINDING_HOSTNAME = 30;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP2_PLUS_TRANSFER_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP2_PLUS_TRANSFER_ENCODING 31")]
    public const int WINHTTP_FEATURE_HTTP2_PLUS_TRANSFER_ENCODING = 31;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG 32")]
    public const int WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG = 32;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_CERT_CHAIN_BUILDING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_CERT_CHAIN_BUILDING 33")]
    public const int WINHTTP_FEATURE_DISABLE_CERT_CHAIN_BUILDING = 33;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_BACKGROUND_CONNECTIONS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_BACKGROUND_CONNECTIONS 34")]
    public const int WINHTTP_FEATURE_BACKGROUND_CONNECTIONS = 34;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FIRST_AVAILABLE_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FIRST_AVAILABLE_CONNECTION 35")]
    public const int WINHTTP_FEATURE_FIRST_AVAILABLE_CONNECTION = 35;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_TCP_PRIORITY_STATUS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_TCP_PRIORITY_STATUS 37")]
    public const int WINHTTP_FEATURE_TCP_PRIORITY_STATUS = 37;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_CONNECTION_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_CONNECTION_GUID 38")]
    public const int WINHTTP_FEATURE_CONNECTION_GUID = 38;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_MATCH_CONNECTION_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_MATCH_CONNECTION_GUID 39")]
    public const int WINHTTP_FEATURE_MATCH_CONNECTION_GUID = 39;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP2_RECEIVE_WINDOW"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP2_RECEIVE_WINDOW 43")]
    public const int WINHTTP_FEATURE_HTTP2_RECEIVE_WINDOW = 43;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_IS_FEATURE_SUPPORTED"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_IS_FEATURE_SUPPORTED 44")]
    public const int WINHTTP_FEATURE_IS_FEATURE_SUPPORTED = 44;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_ADD_REQUEST_HEADERS_EX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_ADD_REQUEST_HEADERS_EX 46")]
    public const int WINHTTP_FEATURE_ADD_REQUEST_HEADERS_EX = 46;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SET_PROXY_SETINGS_PER_USER"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SET_PROXY_SETINGS_PER_USER 47")]
    public const int WINHTTP_FEATURE_SET_PROXY_SETINGS_PER_USER = 47;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_READ_DATA_EX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_READ_DATA_EX 48")]
    public const int WINHTTP_FEATURE_READ_DATA_EX = 48;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_HEADERS_EX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_HEADERS_EX 49")]
    public const int WINHTTP_FEATURE_QUERY_HEADERS_EX = 49;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_CONNECTION_GROUP"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_CONNECTION_GROUP 50")]
    public const int WINHTTP_FEATURE_QUERY_CONNECTION_GROUP = 50;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FREE_QUERY_CONNECTION_GROUP_RESULT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FREE_QUERY_CONNECTION_GROUP_RESULT 51")]
    public const int WINHTTP_FEATURE_FREE_QUERY_CONNECTION_GROUP_RESULT = 51;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS 52")]
    public const int WINHTTP_FEATURE_SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS = 52;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FLAG_SECURE_DEFAULTS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FLAG_SECURE_DEFAULTS 53")]
    public const int WINHTTP_FEATURE_FLAG_SECURE_DEFAULTS = 53;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_EXTENDED_HEADER_FLAG_UNICODE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_EXTENDED_HEADER_FLAG_UNICODE 54")]
    public const int WINHTTP_FEATURE_EXTENDED_HEADER_FLAG_UNICODE = 54;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_FLAG_TRAILERS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_FLAG_TRAILERS 55")]
    public const int WINHTTP_FEATURE_QUERY_FLAG_TRAILERS = 55;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_FLAG_WIRE_ENCODING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_FLAG_WIRE_ENCODING 56")]
    public const int WINHTTP_FEATURE_QUERY_FLAG_WIRE_ENCODING = 56;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT 57")]
    public const int WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT = 57;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE 58")]
    public const int WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE = 58;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FLAG_AUTOMATIC_CHUNKING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FLAG_AUTOMATIC_CHUNKING 59")]
    public const int WINHTTP_FEATURE_FLAG_AUTOMATIC_CHUNKING = 59;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_CONNECTION_GROUP_FLAG_INSECURE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_CONNECTION_GROUP_FLAG_INSECURE 60")]
    public const int WINHTTP_FEATURE_QUERY_CONNECTION_GROUP_FLAG_INSECURE = 60;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION 61")]
    public const int WINHTTP_FEATURE_MATCH_CONNECTION_GUID_FLAG_REQUIRE_MARKED_CONNECTION = 61;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUERY_EX_ALL_HEADERS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUERY_EX_ALL_HEADERS 62")]
    public const int WINHTTP_FEATURE_QUERY_EX_ALL_HEADERS = 62;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_READ_DATA_EX_FLAG_FILL_BUFFER"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_READ_DATA_EX_FLAG_FILL_BUFFER 63")]
    public const int WINHTTP_FEATURE_READ_DATA_EX_FLAG_FILL_BUFFER = 63;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL 64")]
    public const int WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL = 64;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL 65")]
    public const int WINHTTP_FEATURE_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL = 65;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUIC_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUIC_STATS 66")]
    public const int WINHTTP_FEATURE_QUIC_STATS = 66;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP3_KEEPALIVE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP3_KEEPALIVE 69")]
    public const int WINHTTP_FEATURE_HTTP3_KEEPALIVE = 69;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP3_HANDSHAKE_TIMEOUT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP3_HANDSHAKE_TIMEOUT 70")]
    public const int WINHTTP_FEATURE_HTTP3_HANDSHAKE_TIMEOUT = 70;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP3_INITIAL_RTT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP3_INITIAL_RTT 71")]
    public const int WINHTTP_FEATURE_HTTP3_INITIAL_RTT = 71;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP3_STREAM_ERROR_CODE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP3_STREAM_ERROR_CODE 72")]
    public const int WINHTTP_FEATURE_HTTP3_STREAM_ERROR_CODE = 72;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REQUEST_ANNOTATION"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REQUEST_ANNOTATION 73")]
    public const int WINHTTP_FEATURE_REQUEST_ANNOTATION = 73;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_PROXY_AUTH_SCHEMES"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_PROXY_AUTH_SCHEMES 74")]
    public const int WINHTTP_FEATURE_DISABLE_PROXY_AUTH_SCHEMES = 74;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_REVERT_IMPERSONATION_SERVER_CERT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_REVERT_IMPERSONATION_SERVER_CERT 75")]
    public const int WINHTTP_FEATURE_REVERT_IMPERSONATION_SERVER_CERT = 75;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_GLOBAL_POOLING"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_GLOBAL_POOLING 76")]
    public const int WINHTTP_FEATURE_DISABLE_GLOBAL_POOLING = 76;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX 77")]
    public const int WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX = 77;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SESSION_SCH_CRED"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SESSION_SCH_CRED 78")]
    public const int WINHTTP_FEATURE_SESSION_SCH_CRED = 78;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUIC_STATS_V2"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUIC_STATS_V2 79")]
    public const int WINHTTP_FEATURE_QUIC_STATS_V2 = 79;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_URL_INCLUDE_DEFAULT_PORT"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_URL_INCLUDE_DEFAULT_PORT 80")]
    public const int WINHTTP_FEATURE_URL_INCLUDE_DEFAULT_PORT = 80;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_QUIC_STREAM_STATS"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_QUIC_STREAM_STATS 81")]
    public const int WINHTTP_FEATURE_QUIC_STREAM_STATS = 81;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_USE_LOOKASIDE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_USE_LOOKASIDE 82")]
    public const int WINHTTP_FEATURE_USE_LOOKASIDE = 82;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_ERROR_LOG_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_ERROR_LOG_GUID 83")]
    public const int WINHTTP_FEATURE_ERROR_LOG_GUID = 83;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_UPGRADE_TO_PROTOCOL"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_UPGRADE_TO_PROTOCOL 88")]
    public const int WINHTTP_FEATURE_UPGRADE_TO_PROTOCOL = 88;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_CONNECTION_STATS_V2"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_CONNECTION_STATS_V2 89")]
    public const int WINHTTP_FEATURE_CONNECTION_STATS_V2 = 89;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_FAST_FORWARD_RESPONSE"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_FAST_FORWARD_RESPONSE 90")]
    public const int WINHTTP_FEATURE_FAST_FORWARD_RESPONSE = 90;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DISABLE_AIA_FLAG"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DISABLE_AIA_FLAG 91")]
    public const int WINHTTP_FEATURE_DISABLE_AIA_FLAG = 91;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_DSCP_TAG"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_DSCP_TAG 92")]
    public const int WINHTTP_FEATURE_DSCP_TAG = 92;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_HTTP11_DOWNGRADE_TTL"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_HTTP11_DOWNGRADE_TTL 93")]
    public const int WINHTTP_FEATURE_HTTP11_DOWNGRADE_TTL = 93;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_SESSION_ERROR_LOG_GUID"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_SESSION_ERROR_LOG_GUID 94")]
    public const int WINHTTP_FEATURE_SESSION_ERROR_LOG_GUID = 94;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX_XBOX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX_XBOX 95")]
    public const int WINHTTP_FEATURE_GET_PROXY_SETTINGS_EX_XBOX = 95;

    /// <include file='WINHTTP.xml' path='doc/member[@name="WINHTTP.WINHTTP_FEATURE_CONNECTION_PROXY_EX"]/*' />
    [NativeTypeName("#define WINHTTP_FEATURE_CONNECTION_PROXY_EX 97")]
    public const int WINHTTP_FEATURE_CONNECTION_PROXY_EX = 97;
}
