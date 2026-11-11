// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HTTP
{
    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_INITIALIZE_SERVER"]/*' />
    [NativeTypeName("#define HTTP_INITIALIZE_SERVER 0x00000001")]
    public const int HTTP_INITIALIZE_SERVER = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_INITIALIZE_CONFIG"]/*' />
    [NativeTypeName("#define HTTP_INITIALIZE_CONFIG 0x00000002")]
    public const int HTTP_INITIALIZE_CONFIG = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_DEMAND_CBT"]/*' />
    [NativeTypeName("#define HTTP_DEMAND_CBT 0x00000004")]
    public const int HTTP_DEMAND_CBT = 0x00000004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_MAX_SERVER_QUEUE_LENGTH"]/*' />
    [NativeTypeName("#define HTTP_MAX_SERVER_QUEUE_LENGTH 0x7FFFFFFF")]
    public const int HTTP_MAX_SERVER_QUEUE_LENGTH = 0x7FFFFFFF;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_MIN_SERVER_QUEUE_LENGTH"]/*' />
    [NativeTypeName("#define HTTP_MIN_SERVER_QUEUE_LENGTH 1")]
    public const int HTTP_MIN_SERVER_QUEUE_LENGTH = 1;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_MIN_ALLOWED_BANDWIDTH_THROTTLING_RATE"]/*' />
    [NativeTypeName("#define HTTP_MIN_ALLOWED_BANDWIDTH_THROTTLING_RATE ((ULONG)1024)")]
    public const uint HTTP_MIN_ALLOWED_BANDWIDTH_THROTTLING_RATE = ((uint)(1024));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LIMIT_INFINITE"]/*' />
    [NativeTypeName("#define HTTP_LIMIT_INFINITE ((ULONG)-1)")]
    public const uint HTTP_LIMIT_INFINITE = unchecked((uint)(-1));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_BASIC"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_BASIC (0x00000001)")]
    public const int HTTP_AUTH_ENABLE_BASIC = (0x00000001);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_DIGEST"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_DIGEST (0x00000002)")]
    public const int HTTP_AUTH_ENABLE_DIGEST = (0x00000002);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_NTLM"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_NTLM (0x00000004)")]
    public const int HTTP_AUTH_ENABLE_NTLM = (0x00000004);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_NEGOTIATE"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_NEGOTIATE (0x00000008)")]
    public const int HTTP_AUTH_ENABLE_NEGOTIATE = (0x00000008);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_KERBEROS"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_KERBEROS (0x00000010)")]
    public const int HTTP_AUTH_ENABLE_KERBEROS = (0x00000010);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_ENABLE_ALL"]/*' />
    [NativeTypeName("#define HTTP_AUTH_ENABLE_ALL (HTTP_AUTH_ENABLE_BASIC     |\\\r\n             HTTP_AUTH_ENABLE_DIGEST    |\\\r\n             HTTP_AUTH_ENABLE_NTLM      |\\\r\n             HTTP_AUTH_ENABLE_NEGOTIATE |\\\r\n             HTTP_AUTH_ENABLE_KERBEROS)")]
    public const int HTTP_AUTH_ENABLE_ALL = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x00000010));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_EX_FLAG_ENABLE_KERBEROS_CREDENTIAL_CACHING"]/*' />
    [NativeTypeName("#define HTTP_AUTH_EX_FLAG_ENABLE_KERBEROS_CREDENTIAL_CACHING (0x01)")]
    public const int HTTP_AUTH_EX_FLAG_ENABLE_KERBEROS_CREDENTIAL_CACHING = (0x01);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_AUTH_EX_FLAG_CAPTURE_CREDENTIAL"]/*' />
    [NativeTypeName("#define HTTP_AUTH_EX_FLAG_CAPTURE_CREDENTIAL (0x02)")]
    public const int HTTP_AUTH_EX_FLAG_CAPTURE_CREDENTIAL = (0x02);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_PROXY"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_PROXY 0x1")]
    public const int HTTP_CHANNEL_BIND_PROXY = 0x1;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_PROXY_COHOSTING"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_PROXY_COHOSTING 0x20")]
    public const int HTTP_CHANNEL_BIND_PROXY_COHOSTING = 0x20;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_NO_SERVICE_NAME_CHECK"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_NO_SERVICE_NAME_CHECK 0x2")]
    public const int HTTP_CHANNEL_BIND_NO_SERVICE_NAME_CHECK = 0x2;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_DOTLESS_SERVICE"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_DOTLESS_SERVICE 0x4")]
    public const int HTTP_CHANNEL_BIND_DOTLESS_SERVICE = 0x4;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_SECURE_CHANNEL_TOKEN"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_SECURE_CHANNEL_TOKEN 0x8")]
    public const int HTTP_CHANNEL_BIND_SECURE_CHANNEL_TOKEN = 0x8;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CHANNEL_BIND_CLIENT_SERVICE"]/*' />
    [NativeTypeName("#define HTTP_CHANNEL_BIND_CLIENT_SERVICE 0x10")]
    public const int HTTP_CHANNEL_BIND_CLIENT_SERVICE = 0x10;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_DATE"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_DATE 0x00000001")]
    public const int HTTP_LOG_FIELD_DATE = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_TIME"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_TIME 0x00000002")]
    public const int HTTP_LOG_FIELD_TIME = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_CLIENT_IP"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_CLIENT_IP 0x00000004")]
    public const int HTTP_LOG_FIELD_CLIENT_IP = 0x00000004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_USER_NAME"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_USER_NAME 0x00000008")]
    public const int HTTP_LOG_FIELD_USER_NAME = 0x00000008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_SITE_NAME"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_SITE_NAME 0x00000010")]
    public const int HTTP_LOG_FIELD_SITE_NAME = 0x00000010;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_COMPUTER_NAME"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_COMPUTER_NAME 0x00000020")]
    public const int HTTP_LOG_FIELD_COMPUTER_NAME = 0x00000020;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_SERVER_IP"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_SERVER_IP 0x00000040")]
    public const int HTTP_LOG_FIELD_SERVER_IP = 0x00000040;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_METHOD"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_METHOD 0x00000080")]
    public const int HTTP_LOG_FIELD_METHOD = 0x00000080;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_URI_STEM"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_URI_STEM 0x00000100")]
    public const int HTTP_LOG_FIELD_URI_STEM = 0x00000100;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_URI_QUERY"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_URI_QUERY 0x00000200")]
    public const int HTTP_LOG_FIELD_URI_QUERY = 0x00000200;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_STATUS"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_STATUS 0x00000400")]
    public const int HTTP_LOG_FIELD_STATUS = 0x00000400;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_WIN32_STATUS"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_WIN32_STATUS 0x00000800")]
    public const int HTTP_LOG_FIELD_WIN32_STATUS = 0x00000800;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_BYTES_SENT"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_BYTES_SENT 0x00001000")]
    public const int HTTP_LOG_FIELD_BYTES_SENT = 0x00001000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_BYTES_RECV"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_BYTES_RECV 0x00002000")]
    public const int HTTP_LOG_FIELD_BYTES_RECV = 0x00002000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_TIME_TAKEN"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_TIME_TAKEN 0x00004000")]
    public const int HTTP_LOG_FIELD_TIME_TAKEN = 0x00004000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_SERVER_PORT"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_SERVER_PORT 0x00008000")]
    public const int HTTP_LOG_FIELD_SERVER_PORT = 0x00008000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_USER_AGENT"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_USER_AGENT 0x00010000")]
    public const int HTTP_LOG_FIELD_USER_AGENT = 0x00010000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_COOKIE"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_COOKIE 0x00020000")]
    public const int HTTP_LOG_FIELD_COOKIE = 0x00020000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_REFERER"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_REFERER 0x00040000")]
    public const int HTTP_LOG_FIELD_REFERER = 0x00040000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_VERSION"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_VERSION 0x00080000")]
    public const int HTTP_LOG_FIELD_VERSION = 0x00080000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_HOST"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_HOST 0x00100000")]
    public const int HTTP_LOG_FIELD_HOST = 0x00100000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_SUB_STATUS"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_SUB_STATUS 0x00200000")]
    public const int HTTP_LOG_FIELD_SUB_STATUS = 0x00200000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_STREAM_ID"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_STREAM_ID 0x08000000")]
    public const int HTTP_LOG_FIELD_STREAM_ID = 0x08000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_STREAM_ID_EX"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_STREAM_ID_EX 0x10000000")]
    public const int HTTP_LOG_FIELD_STREAM_ID_EX = 0x10000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_TRANSPORT_TYPE"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_TRANSPORT_TYPE 0x20000000")]
    public const int HTTP_LOG_FIELD_TRANSPORT_TYPE = 0x20000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_CLIENT_PORT"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_CLIENT_PORT 0x00400000")]
    public const int HTTP_LOG_FIELD_CLIENT_PORT = 0x00400000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_URI"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_URI 0x00800000")]
    public const int HTTP_LOG_FIELD_URI = 0x00800000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_SITE_ID"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_SITE_ID 0x01000000")]
    public const int HTTP_LOG_FIELD_SITE_ID = 0x01000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_REASON"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_REASON 0x02000000")]
    public const int HTTP_LOG_FIELD_REASON = 0x02000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_QUEUE_NAME"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_QUEUE_NAME 0x04000000")]
    public const int HTTP_LOG_FIELD_QUEUE_NAME = 0x04000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_CORRELATION_ID"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_CORRELATION_ID 0x40000000")]
    public const int HTTP_LOG_FIELD_CORRELATION_ID = 0x40000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_FAULT_CODE"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_FAULT_CODE 0x80000000")]
    public const uint HTTP_LOG_FIELD_FAULT_CODE = 0x80000000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOG_FIELD_EXT_FAULT_CODE_EXT"]/*' />
    [NativeTypeName("#define HTTP_LOG_FIELD_EXT_FAULT_CODE_EXT 0x0000000000000001")]
    public const int HTTP_LOG_FIELD_EXT_FAULT_CODE_EXT = 0x0000000000000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_MIN_ALLOWED_LOG_FILE_ROLLOVER_SIZE"]/*' />
    [NativeTypeName("#define HTTP_MIN_ALLOWED_LOG_FILE_ROLLOVER_SIZE ((ULONG)(1 * 1024 * 1024))")]
    public const uint HTTP_MIN_ALLOWED_LOG_FILE_ROLLOVER_SIZE = ((uint)(1 * 1024 * 1024));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOGGING_FLAG_LOCAL_TIME_ROLLOVER"]/*' />
    [NativeTypeName("#define HTTP_LOGGING_FLAG_LOCAL_TIME_ROLLOVER (0x00000001)")]
    public const int HTTP_LOGGING_FLAG_LOCAL_TIME_ROLLOVER = (0x00000001);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOGGING_FLAG_USE_UTF8_CONVERSION"]/*' />
    [NativeTypeName("#define HTTP_LOGGING_FLAG_USE_UTF8_CONVERSION (0x00000002)")]
    public const int HTTP_LOGGING_FLAG_USE_UTF8_CONVERSION = (0x00000002);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOGGING_FLAG_LOG_ERRORS_ONLY"]/*' />
    [NativeTypeName("#define HTTP_LOGGING_FLAG_LOG_ERRORS_ONLY (0x00000004)")]
    public const int HTTP_LOGGING_FLAG_LOG_ERRORS_ONLY = (0x00000004);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_LOGGING_FLAG_LOG_SUCCESS_ONLY"]/*' />
    [NativeTypeName("#define HTTP_LOGGING_FLAG_LOG_SUCCESS_ONLY (0x00000008)")]
    public const int HTTP_LOGGING_FLAG_LOG_SUCCESS_ONLY = (0x00000008);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_INFO_FLAG_INITIAL_TTL"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_INFO_FLAG_INITIAL_TTL (0x00000001ULL)")]
    public const ulong HTTP_REQUEST_INFO_FLAG_INITIAL_TTL = (0x00000001UL);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CREATE_REQUEST_QUEUE_FLAG_OPEN_EXISTING"]/*' />
    [NativeTypeName("#define HTTP_CREATE_REQUEST_QUEUE_FLAG_OPEN_EXISTING (0x00000001)")]
    public const int HTTP_CREATE_REQUEST_QUEUE_FLAG_OPEN_EXISTING = (0x00000001);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CREATE_REQUEST_QUEUE_FLAG_CONTROLLER"]/*' />
    [NativeTypeName("#define HTTP_CREATE_REQUEST_QUEUE_FLAG_CONTROLLER (0x00000002)")]
    public const int HTTP_CREATE_REQUEST_QUEUE_FLAG_CONTROLLER = (0x00000002);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CREATE_REQUEST_QUEUE_FLAG_DELEGATION"]/*' />
    [NativeTypeName("#define HTTP_CREATE_REQUEST_QUEUE_FLAG_DELEGATION (0x00000008)")]
    public const int HTTP_CREATE_REQUEST_QUEUE_FLAG_DELEGATION = (0x00000008);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY"]/*' />
    [NativeTypeName("#define HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY 0x00000001")]
    public const int HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RECEIVE_REQUEST_FLAG_FLUSH_BODY"]/*' />
    [NativeTypeName("#define HTTP_RECEIVE_REQUEST_FLAG_FLUSH_BODY 0x00000002")]
    public const int HTTP_RECEIVE_REQUEST_FLAG_FLUSH_BODY = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RECEIVE_REQUEST_ENTITY_BODY_FLAG_FILL_BUFFER"]/*' />
    [NativeTypeName("#define HTTP_RECEIVE_REQUEST_ENTITY_BODY_FLAG_FILL_BUFFER 0x00000001")]
    public const int HTTP_RECEIVE_REQUEST_ENTITY_BODY_FLAG_FILL_BUFFER = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_DISCONNECT"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_DISCONNECT 0x00000001")]
    public const int HTTP_SEND_RESPONSE_FLAG_DISCONNECT = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_MORE_DATA"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_MORE_DATA 0x00000002")]
    public const int HTTP_SEND_RESPONSE_FLAG_MORE_DATA = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA 0x00000004")]
    public const int HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA = 0x00000004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_ENABLE_NAGLING"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_ENABLE_NAGLING 0x00000008")]
    public const int HTTP_SEND_RESPONSE_FLAG_ENABLE_NAGLING = 0x00000008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_PROCESS_RANGES"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_PROCESS_RANGES 0x00000020")]
    public const int HTTP_SEND_RESPONSE_FLAG_PROCESS_RANGES = 0x00000020;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_OPAQUE"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_OPAQUE 0x00000040")]
    public const int HTTP_SEND_RESPONSE_FLAG_OPAQUE = 0x00000040;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_GOAWAY"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_GOAWAY 0x00000100")]
    public const int HTTP_SEND_RESPONSE_FLAG_GOAWAY = 0x00000100;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SEND_RESPONSE_FLAG_AUTOMATIC_CHUNKING"]/*' />
    [NativeTypeName("#define HTTP_SEND_RESPONSE_FLAG_AUTOMATIC_CHUNKING 0x00000200")]
    public const int HTTP_SEND_RESPONSE_FLAG_AUTOMATIC_CHUNKING = 0x00000200;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_FLUSH_RESPONSE_FLAG_RECURSIVE"]/*' />
    [NativeTypeName("#define HTTP_FLUSH_RESPONSE_FLAG_RECURSIVE 0x00000001")]
    public const int HTTP_FLUSH_RESPONSE_FLAG_RECURSIVE = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_NULL_ID"]/*' />
    [NativeTypeName("#define HTTP_NULL_ID (0ui64)")]
    public const ulong HTTP_NULL_ID = (0UL);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_BYTE_RANGE_TO_EOF"]/*' />
    [NativeTypeName("#define HTTP_BYTE_RANGE_TO_EOF ((ULONGLONG)-1)")]
    public const ulong HTTP_BYTE_RANGE_TO_EOF = unchecked((ulong)(-1));

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_URL_FLAG_REMOVE_ALL"]/*' />
    [NativeTypeName("#define HTTP_URL_FLAG_REMOVE_ALL 0x00000001")]
    public const int HTTP_URL_FLAG_REMOVE_ALL = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RECEIVE_SECURE_CHANNEL_TOKEN"]/*' />
    [NativeTypeName("#define HTTP_RECEIVE_SECURE_CHANNEL_TOKEN 0x1")]
    public const int HTTP_RECEIVE_SECURE_CHANNEL_TOKEN = 0x1;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RECEIVE_FULL_CHAIN"]/*' />
    [NativeTypeName("#define HTTP_RECEIVE_FULL_CHAIN 0x2")]
    public const int HTTP_RECEIVE_FULL_CHAIN = 0x2;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_SIZING_INFO_FLAG_TCP_FAST_OPEN"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_SIZING_INFO_FLAG_TCP_FAST_OPEN 0x00000001")]
    public const int HTTP_REQUEST_SIZING_INFO_FLAG_TCP_FAST_OPEN = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_SIZING_INFO_FLAG_TLS_SESSION_RESUMPTION"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_SIZING_INFO_FLAG_TLS_SESSION_RESUMPTION 0x00000002")]
    public const int HTTP_REQUEST_SIZING_INFO_FLAG_TLS_SESSION_RESUMPTION = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_SIZING_INFO_FLAG_TLS_FALSE_START"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_SIZING_INFO_FLAG_TLS_FALSE_START 0x00000004")]
    public const int HTTP_REQUEST_SIZING_INFO_FLAG_TLS_FALSE_START = 0x00000004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_SIZING_INFO_FLAG_FIRST_REQUEST"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_SIZING_INFO_FLAG_FIRST_REQUEST 0x00000008")]
    public const int HTTP_REQUEST_SIZING_INFO_FLAG_FIRST_REQUEST = 0x00000008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_AUTH_FLAG_TOKEN_FOR_CACHED_CRED"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_AUTH_FLAG_TOKEN_FOR_CACHED_CRED (0x00000001)")]
    public const int HTTP_REQUEST_AUTH_FLAG_TOKEN_FOR_CACHED_CRED = (0x00000001);

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_MORE_ENTITY_BODY_EXISTS"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_MORE_ENTITY_BODY_EXISTS 0x00000001")]
    public const int HTTP_REQUEST_FLAG_MORE_ENTITY_BODY_EXISTS = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_IP_ROUTED"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_IP_ROUTED 0x00000002")]
    public const int HTTP_REQUEST_FLAG_IP_ROUTED = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_HTTP2"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_HTTP2 0x00000004")]
    public const int HTTP_REQUEST_FLAG_HTTP2 = 0x00000004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_HTTP3"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_HTTP3 0x00000008")]
    public const int HTTP_REQUEST_FLAG_HTTP3 = 0x00000008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_FAST_FORWARDING_ALLOWED"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_FAST_FORWARDING_ALLOWED 0x00000010")]
    public const int HTTP_REQUEST_FLAG_FAST_FORWARDING_ALLOWED = 0x00000010;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_FLAG_FAST_FORWARDING_RESPONSE_ALLOWED"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_FLAG_FAST_FORWARDING_RESPONSE_ALLOWED HTTP_REQUEST_FLAG_FAST_FORWARDING_ALLOWED")]
    public const int HTTP_REQUEST_FLAG_FAST_FORWARDING_RESPONSE_ALLOWED = 0x00000010;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RESPONSE_FLAG_MULTIPLE_ENCODINGS_AVAILABLE"]/*' />
    [NativeTypeName("#define HTTP_RESPONSE_FLAG_MULTIPLE_ENCODINGS_AVAILABLE 0x00000001")]
    public const int HTTP_RESPONSE_FLAG_MULTIPLE_ENCODINGS_AVAILABLE = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RESPONSE_FLAG_MORE_ENTITY_BODY_EXISTS"]/*' />
    [NativeTypeName("#define HTTP_RESPONSE_FLAG_MORE_ENTITY_BODY_EXISTS 0x00000002")]
    public const int HTTP_RESPONSE_FLAG_MORE_ENTITY_BODY_EXISTS = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_RESPONSE_INFO_FLAGS_PRESERVE_ORDER"]/*' />
    [NativeTypeName("#define HTTP_RESPONSE_INFO_FLAGS_PRESERVE_ORDER 0x00000001")]
    public const int HTTP_RESPONSE_INFO_FLAGS_PRESERVE_ORDER = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_NO_REVOCATION"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_NO_REVOCATION 0x00001")]
    public const int HTTP_CERT_CHECK_MODE_NO_REVOCATION = 0x00001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_CACHED_REVOCATION"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_CACHED_REVOCATION 0x00002")]
    public const int HTTP_CERT_CHECK_MODE_CACHED_REVOCATION = 0x00002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_USE_REVOCATION_FRESHNESS"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_USE_REVOCATION_FRESHNESS 0x00004")]
    public const int HTTP_CERT_CHECK_MODE_USE_REVOCATION_FRESHNESS = 0x00004;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_CACHED_URLS"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_CACHED_URLS 0x00008")]
    public const int HTTP_CERT_CHECK_MODE_CACHED_URLS = 0x00008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_NO_AIA"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_NO_AIA 0x00010")]
    public const int HTTP_CERT_CHECK_MODE_NO_AIA = 0x00010;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_CERT_CHECK_MODE_NO_USAGE_CHECK"]/*' />
    [NativeTypeName("#define HTTP_CERT_CHECK_MODE_NO_USAGE_CHECK 0x10000")]
    public const int HTTP_CERT_CHECK_MODE_NO_USAGE_CHECK = 0x10000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SSL_CERT_SHA_HASH_LENGTH"]/*' />
    [NativeTypeName("#define HTTP_SSL_CERT_SHA_HASH_LENGTH 20")]
    public const int HTTP_SSL_CERT_SHA_HASH_LENGTH = 20;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SSL_CERT_STORE_NAME_LENGTH"]/*' />
    [NativeTypeName("#define HTTP_SSL_CERT_STORE_NAME_LENGTH 128")]
    public const int HTTP_SSL_CERT_STORE_NAME_LENGTH = 128;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_USE_DS_MAPPER"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_USE_DS_MAPPER 0x00000001")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_USE_DS_MAPPER = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_NEGOTIATE_CLIENT_CERT"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_NEGOTIATE_CLIENT_CERT 0x00000002")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_NEGOTIATE_CLIENT_CERT = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_REJECT"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_REJECT 0x00000008")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_REJECT = 0x00000008;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_HTTP2"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_HTTP2 0x00000010")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_HTTP2 = 0x00000010;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_QUIC"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_QUIC 0x00000020")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_QUIC = 0x00000020;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS13"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS13 0x00000040")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS13 = 0x00000040;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_OCSP_STAPLING"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_OCSP_STAPLING 0x00000080")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_OCSP_STAPLING = 0x00000080;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_TOKEN_BINDING"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_TOKEN_BINDING 0x00000100")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_TOKEN_BINDING = 0x00000100;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_LOG_EXTENDED_EVENTS"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_LOG_EXTENDED_EVENTS 0x00000200")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_LOG_EXTENDED_EVENTS = 0x00000200;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_LEGACY_TLS"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_LEGACY_TLS 0x00000400")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_LEGACY_TLS = 0x00000400;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_SESSION_TICKET"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_SESSION_TICKET 0x00000800")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_SESSION_TICKET = 0x00000800;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS12"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS12 0x00001000")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_TLS12 = 0x00001000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CLIENT_CORRELATION"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CLIENT_CORRELATION 0x00002000")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CLIENT_CORRELATION = 0x00002000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_SESSION_ID"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_SESSION_ID 0x00004000")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_DISABLE_SESSION_ID = 0x00004000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CACHE_CLIENT_HELLO"]/*' />
    [NativeTypeName("#define HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CACHE_CLIENT_HELLO 0x00008000")]
    public const int HTTP_SERVICE_CONFIG_SSL_FLAG_ENABLE_CACHE_CLIENT_HELLO = 0x00008000;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_PROPERTY_SNI_HOST_MAX_LENGTH"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_PROPERTY_SNI_HOST_MAX_LENGTH 255")]
    public const int HTTP_REQUEST_PROPERTY_SNI_HOST_MAX_LENGTH = 255;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_PROPERTY_SNI_FLAG_SNI_USED"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_PROPERTY_SNI_FLAG_SNI_USED 0x00000001")]
    public const int HTTP_REQUEST_PROPERTY_SNI_FLAG_SNI_USED = 0x00000001;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_REQUEST_PROPERTY_SNI_FLAG_NO_SNI"]/*' />
    [NativeTypeName("#define HTTP_REQUEST_PROPERTY_SNI_FLAG_NO_SNI 0x00000002")]
    public const int HTTP_REQUEST_PROPERTY_SNI_FLAG_NO_SNI = 0x00000002;

    /// <include file='HTTP.xml' path='doc/member[@name="HTTP.HTTP_QUIC_KEEPALIVE_TIMEOUT_DISABLED"]/*' />
    [NativeTypeName("#define HTTP_QUIC_KEEPALIVE_TIMEOUT_DISABLED ((ULONG)-1)")]
    public const uint HTTP_QUIC_KEEPALIVE_TIMEOUT_DISABLED = unchecked((uint)(-1));
}
