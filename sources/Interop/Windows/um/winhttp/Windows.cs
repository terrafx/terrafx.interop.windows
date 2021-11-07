// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WINHTTP_STATUS_CALLBACK")]
        public static extern delegate* unmanaged<HINTERNET, nuint, uint, void*, uint, void> WinHttpSetStatusCallback(HINTERNET hInternet, [NativeTypeName("WINHTTP_STATUS_CALLBACK")] delegate* unmanaged<HINTERNET, nuint, uint, void*, uint, void> lpfnInternetCallback, [NativeTypeName("DWORD")] uint dwNotificationFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpTimeFromSystemTime([NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* pst, [NativeTypeName("LPWSTR")] ushort* pwszTime);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpTimeToSystemTime([NativeTypeName("LPCWSTR")] ushort* pwszTime, SYSTEMTIME* pst);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpCrackUrl([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwUrlLength, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPURL_COMPONENTS")] URL_COMPONENTS* lpUrlComponents);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpCreateUrl([NativeTypeName("LPURL_COMPONENTS")] URL_COMPONENTS* lpUrlComponents, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pwszUrl, [NativeTypeName("LPDWORD")] uint* pdwUrlLength);

        [DllImport("winhttp", ExactSpelling = true)]
        public static extern BOOL WinHttpCheckPlatform();

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpGetDefaultProxyConfiguration(WINHTTP_PROXY_INFO* pProxyInfo);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpSetDefaultProxyConfiguration(WINHTTP_PROXY_INFO* pProxyInfo);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern HINTERNET WinHttpOpen([NativeTypeName("LPCWSTR")] ushort* pszAgentW, [NativeTypeName("DWORD")] uint dwAccessType, [NativeTypeName("LPCWSTR")] ushort* pszProxyW, [NativeTypeName("LPCWSTR")] ushort* pszProxyBypassW, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpCloseHandle(HINTERNET hInternet);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern HINTERNET WinHttpConnect(HINTERNET hSession, [NativeTypeName("LPCWSTR")] ushort* pswzServerName, [NativeTypeName("INTERNET_PORT")] ushort nServerPort, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpReadData(HINTERNET hRequest, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint dwNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesRead);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpReadDataEx(HINTERNET hRequest, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint dwNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesRead, [NativeTypeName("ULONGLONG")] ulong ullFlags, [NativeTypeName("DWORD")] uint cbProperty, [NativeTypeName("PVOID")] void* pvProperty);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpWriteData(HINTERNET hRequest, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint dwNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesWritten);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpQueryDataAvailable(HINTERNET hRequest, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesAvailable);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpQueryOption(HINTERNET hInternet, [NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwBufferLength);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpSetOption(HINTERNET hInternet, [NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint dwBufferLength);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpSetTimeouts(HINTERNET hInternet, int nResolveTimeout, int nConnectTimeout, int nSendTimeout, int nReceiveTimeout);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern HINTERNET WinHttpOpenRequest(HINTERNET hConnect, [NativeTypeName("LPCWSTR")] ushort* pwszVerb, [NativeTypeName("LPCWSTR")] ushort* pwszObjectName, [NativeTypeName("LPCWSTR")] ushort* pwszVersion, [NativeTypeName("LPCWSTR")] ushort* pwszReferrer, [NativeTypeName("LPCWSTR *")] ushort** ppwszAcceptTypes, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpAddRequestHeaders(HINTERNET hRequest, [NativeTypeName("LPCWSTR")] ushort* lpszHeaders, [NativeTypeName("DWORD")] uint dwHeadersLength, [NativeTypeName("DWORD")] uint dwModifiers);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpAddRequestHeadersEx(HINTERNET hRequest, [NativeTypeName("DWORD")] uint dwModifiers, [NativeTypeName("ULONGLONG")] ulong ullFlags, [NativeTypeName("ULONGLONG")] ulong ullExtra, [NativeTypeName("DWORD")] uint cHeaders, WINHTTP_EXTENDED_HEADER* pHeaders);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpSendRequest(HINTERNET hRequest, [NativeTypeName("LPCWSTR")] ushort* lpszHeaders, [NativeTypeName("DWORD")] uint dwHeadersLength, [NativeTypeName("LPVOID")] void* lpOptional, [NativeTypeName("DWORD")] uint dwOptionalLength, [NativeTypeName("DWORD")] uint dwTotalLength, [NativeTypeName("DWORD_PTR")] nuint dwContext);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpSetCredentials(HINTERNET hRequest, [NativeTypeName("DWORD")] uint AuthTargets, [NativeTypeName("DWORD")] uint AuthScheme, [NativeTypeName("LPCWSTR")] ushort* pwszUserName, [NativeTypeName("LPCWSTR")] ushort* pwszPassword, [NativeTypeName("LPVOID")] void* pAuthParams);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpQueryAuthSchemes(HINTERNET hRequest, [NativeTypeName("LPDWORD")] uint* lpdwSupportedSchemes, [NativeTypeName("LPDWORD")] uint* lpdwFirstScheme, [NativeTypeName("LPDWORD")] uint* pdwAuthTarget);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpReceiveResponse(HINTERNET hRequest, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpQueryHeaders(HINTERNET hRequest, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwBufferLength, [NativeTypeName("LPDWORD")] uint* lpdwIndex);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpQueryHeadersEx(HINTERNET hRequest, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("ULONGLONG")] ulong ullFlags, uint uiCodePage, [NativeTypeName("PDWORD")] uint* pdwIndex, [NativeTypeName("PWINHTTP_HEADER_NAME")] WINHTTP_HEADER_NAME* pHeaderName, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwBufferLength, [NativeTypeName("PWINHTTP_EXTENDED_HEADER *")] WINHTTP_EXTENDED_HEADER** ppHeaders, [NativeTypeName("PDWORD")] uint* pdwHeadersCount);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpDetectAutoProxyConfigUrl([NativeTypeName("DWORD")] uint dwAutoDetectFlags, [NativeTypeName("LPWSTR *")] ushort** ppwstrAutoConfigUrl);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpGetProxyForUrl(HINTERNET hSession, [NativeTypeName("LPCWSTR")] ushort* lpcwszUrl, WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions, WINHTTP_PROXY_INFO* pProxyInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpCreateProxyResolver(HINTERNET hSession, HINTERNET* phResolver);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpGetProxyForUrlEx(HINTERNET hResolver, [NativeTypeName("PCWSTR")] ushort* pcwszUrl, WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions, [NativeTypeName("DWORD_PTR")] nuint pContext);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpGetProxyForUrlEx2(HINTERNET hResolver, [NativeTypeName("PCWSTR")] ushort* pcwszUrl, WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions, [NativeTypeName("DWORD")] uint cbInterfaceSelectionContext, byte* pInterfaceSelectionContext, [NativeTypeName("DWORD_PTR")] nuint pContext);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpGetProxyResult(HINTERNET hResolver, WINHTTP_PROXY_RESULT* pProxyResult);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpGetProxyResultEx(HINTERNET hResolver, WINHTTP_PROXY_RESULT_EX* pProxyResultEx);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        public static extern void WinHttpFreeProxyResult(WINHTTP_PROXY_RESULT* pProxyResult);

        [DllImport("winhttp", ExactSpelling = true)]
        public static extern void WinHttpFreeProxyResultEx(WINHTTP_PROXY_RESULT_EX* pProxyResultEx);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpResetAutoProxy(HINTERNET hSession, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHttpGetIEProxyConfigForCurrentUser(WINHTTP_CURRENT_USER_IE_PROXY_CONFIG* pProxyConfig);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWriteProxySettings(HINTERNET hSession, BOOL fForceUpdate, WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpReadProxySettings(HINTERNET hSession, [NativeTypeName("PCWSTR")] ushort* pcwszConnectionName, BOOL fFallBackToDefaultSettings, BOOL fSetAutoDiscoverForDefaultSettings, [NativeTypeName("DWORD *")] uint* pdwSettingsVersion, BOOL* pfDefaultSettingsAreReturned, WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings);

        [DllImport("winhttp", ExactSpelling = true)]
        public static extern void WinHttpFreeProxySettings(WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpGetProxySettingsVersion(HINTERNET hSession, [NativeTypeName("DWORD *")] uint* pdwProxySettingsVersion);

        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpSetProxySettingsPerUser(BOOL fProxySettingsPerUser);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true, SetLastError = true)]
        public static extern HINTERNET WinHttpWebSocketCompleteUpgrade(HINTERNET hRequest, [NativeTypeName("DWORD_PTR")] nuint pContext);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWebSocketSend(HINTERNET hWebSocket, WINHTTP_WEB_SOCKET_BUFFER_TYPE eBufferType, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint dwBufferLength);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWebSocketReceive(HINTERNET hWebSocket, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBytesRead, WINHTTP_WEB_SOCKET_BUFFER_TYPE* peBufferType);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWebSocketShutdown(HINTERNET hWebSocket, ushort usStatus, [NativeTypeName("PVOID")] void* pvReason, [NativeTypeName("DWORD")] uint dwReasonLength);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWebSocketClose(HINTERNET hWebSocket, ushort usStatus, [NativeTypeName("PVOID")] void* pvReason, [NativeTypeName("DWORD")] uint dwReasonLength);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("winhttp", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WinHttpWebSocketQueryCloseStatus(HINTERNET hWebSocket, ushort* pusStatus, [NativeTypeName("PVOID")] void* pvReason, [NativeTypeName("DWORD")] uint dwReasonLength, [NativeTypeName("DWORD *")] uint* pdwReasonLengthConsumed);

        [NativeTypeName("#define INTERNET_DEFAULT_PORT 0")]
        public const int INTERNET_DEFAULT_PORT = 0;

        [NativeTypeName("#define INTERNET_DEFAULT_HTTP_PORT 80")]
        public const int INTERNET_DEFAULT_HTTP_PORT = 80;

        [NativeTypeName("#define INTERNET_DEFAULT_HTTPS_PORT 443")]
        public const int INTERNET_DEFAULT_HTTPS_PORT = 443;

        [NativeTypeName("#define WINHTTP_FLAG_ASYNC 0x10000000")]
        public const int WINHTTP_FLAG_ASYNC = 0x10000000;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_DEFAULTS 0x30000000")]
        public const int WINHTTP_FLAG_SECURE_DEFAULTS = 0x30000000;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE 0x00800000")]
        public const int WINHTTP_FLAG_SECURE = 0x00800000;

        [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_PERCENT 0x00000004")]
        public const int WINHTTP_FLAG_ESCAPE_PERCENT = 0x00000004;

        [NativeTypeName("#define WINHTTP_FLAG_NULL_CODEPAGE 0x00000008")]
        public const int WINHTTP_FLAG_NULL_CODEPAGE = 0x00000008;

        [NativeTypeName("#define WINHTTP_FLAG_BYPASS_PROXY_CACHE 0x00000100")]
        public const int WINHTTP_FLAG_BYPASS_PROXY_CACHE = 0x00000100;

        [NativeTypeName("#define WINHTTP_FLAG_REFRESH WINHTTP_FLAG_BYPASS_PROXY_CACHE")]
        public const int WINHTTP_FLAG_REFRESH = 0x00000100;

        [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_DISABLE 0x00000040")]
        public const int WINHTTP_FLAG_ESCAPE_DISABLE = 0x00000040;

        [NativeTypeName("#define WINHTTP_FLAG_ESCAPE_DISABLE_QUERY 0x00000080")]
        public const int WINHTTP_FLAG_ESCAPE_DISABLE_QUERY = 0x00000080;

        [NativeTypeName("#define SECURITY_FLAG_IGNORE_UNKNOWN_CA 0x00000100")]
        public const int SECURITY_FLAG_IGNORE_UNKNOWN_CA = 0x00000100;

        [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_DATE_INVALID 0x00002000")]
        public const int SECURITY_FLAG_IGNORE_CERT_DATE_INVALID = 0x00002000;

        [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_CN_INVALID 0x00001000")]
        public const int SECURITY_FLAG_IGNORE_CERT_CN_INVALID = 0x00001000;

        [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE 0x00000200")]
        public const int SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE = 0x00000200;

        [NativeTypeName("#define SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS (SECURITY_FLAG_IGNORE_UNKNOWN_CA        | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_DATE_INVALID | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_CN_INVALID   | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE)")]
        public const int SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS = (0x00000100 | 0x00002000 | 0x00001000 | 0x00000200);

        [NativeTypeName("#define INTERNET_SCHEME_HTTP (1)")]
        public const int INTERNET_SCHEME_HTTP = (1);

        [NativeTypeName("#define INTERNET_SCHEME_HTTPS (2)")]
        public const int INTERNET_SCHEME_HTTPS = (2);

        [NativeTypeName("#define INTERNET_SCHEME_FTP (3)")]
        public const int INTERNET_SCHEME_FTP = (3);

        [NativeTypeName("#define INTERNET_SCHEME_SOCKS (4)")]
        public const int INTERNET_SCHEME_SOCKS = (4);

        [NativeTypeName("#define WINHTTP_AUTOPROXY_AUTO_DETECT 0x00000001")]
        public const int WINHTTP_AUTOPROXY_AUTO_DETECT = 0x00000001;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_CONFIG_URL 0x00000002")]
        public const int WINHTTP_AUTOPROXY_CONFIG_URL = 0x00000002;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_HOST_KEEPCASE 0x00000004")]
        public const int WINHTTP_AUTOPROXY_HOST_KEEPCASE = 0x00000004;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_HOST_LOWERCASE 0x00000008")]
        public const int WINHTTP_AUTOPROXY_HOST_LOWERCASE = 0x00000008;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_AUTOCONFIG 0x00000100")]
        public const int WINHTTP_AUTOPROXY_ALLOW_AUTOCONFIG = 0x00000100;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_STATIC 0x00000200")]
        public const int WINHTTP_AUTOPROXY_ALLOW_STATIC = 0x00000200;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_ALLOW_CM 0x00000400")]
        public const int WINHTTP_AUTOPROXY_ALLOW_CM = 0x00000400;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_RUN_INPROCESS 0x00010000")]
        public const int WINHTTP_AUTOPROXY_RUN_INPROCESS = 0x00010000;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_RUN_OUTPROCESS_ONLY 0x00020000")]
        public const int WINHTTP_AUTOPROXY_RUN_OUTPROCESS_ONLY = 0x00020000;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_DIRECTACCESS 0x00040000")]
        public const int WINHTTP_AUTOPROXY_NO_DIRECTACCESS = 0x00040000;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_CACHE_CLIENT 0x00080000")]
        public const int WINHTTP_AUTOPROXY_NO_CACHE_CLIENT = 0x00080000;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_NO_CACHE_SVC 0x00100000")]
        public const int WINHTTP_AUTOPROXY_NO_CACHE_SVC = 0x00100000;

        [NativeTypeName("#define WINHTTP_AUTOPROXY_SORT_RESULTS 0x00400000")]
        public const int WINHTTP_AUTOPROXY_SORT_RESULTS = 0x00400000;

        [NativeTypeName("#define WINHTTP_AUTO_DETECT_TYPE_DHCP 0x00000001")]
        public const int WINHTTP_AUTO_DETECT_TYPE_DHCP = 0x00000001;

        [NativeTypeName("#define WINHTTP_AUTO_DETECT_TYPE_DNS_A 0x00000002")]
        public const int WINHTTP_AUTO_DETECT_TYPE_DNS_A = 0x00000002;

        [NativeTypeName("#define NETWORKING_KEY_BUFSIZE 128")]
        public const int NETWORKING_KEY_BUFSIZE = 128;

        [NativeTypeName("#define WINHTTP_PROXY_TYPE_DIRECT 0x00000001")]
        public const int WINHTTP_PROXY_TYPE_DIRECT = 0x00000001;

        [NativeTypeName("#define WINHTTP_PROXY_TYPE_PROXY 0x00000002")]
        public const int WINHTTP_PROXY_TYPE_PROXY = 0x00000002;

        [NativeTypeName("#define WINHTTP_PROXY_TYPE_AUTO_PROXY_URL 0x00000004")]
        public const int WINHTTP_PROXY_TYPE_AUTO_PROXY_URL = 0x00000004;

        [NativeTypeName("#define WINHTTP_PROXY_TYPE_AUTO_DETECT 0x00000008")]
        public const int WINHTTP_PROXY_TYPE_AUTO_DETECT = 0x00000008;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TCP_FAST_OPEN 0x00000001")]
        public const int WINHTTP_REQUEST_STAT_FLAG_TCP_FAST_OPEN = 0x00000001;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TLS_SESSION_RESUMPTION 0x00000002")]
        public const int WINHTTP_REQUEST_STAT_FLAG_TLS_SESSION_RESUMPTION = 0x00000002;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_TLS_FALSE_START 0x00000004")]
        public const int WINHTTP_REQUEST_STAT_FLAG_TLS_FALSE_START = 0x00000004;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_SESSION_RESUMPTION 0x00000008")]
        public const int WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_SESSION_RESUMPTION = 0x00000008;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_FALSE_START 0x00000010")]
        public const int WINHTTP_REQUEST_STAT_FLAG_PROXY_TLS_FALSE_START = 0x00000010;

        [NativeTypeName("#define WINHTTP_REQUEST_STAT_FLAG_FIRST_REQUEST 0x00000020")]
        public const int WINHTTP_REQUEST_STAT_FLAG_FIRST_REQUEST = 0x00000020;

        [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT 0x00000001")]
        public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_SOFT_LIMIT = 0x00000001;

        [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE 0x00000002")]
        public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_BYPASS_CACHE = 0x00000002;

        [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL 0x00000004")]
        public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_USE_DNS_TTL = 0x00000004;

        [NativeTypeName("#define WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL 0x00000008")]
        public const int WINHTTP_RESOLVER_CACHE_CONFIG_FLAG_CONN_USE_TTL = 0x00000008;

        [NativeTypeName("#define WINHTTP_TIME_FORMAT_BUFSIZE 62")]
        public const int WINHTTP_TIME_FORMAT_BUFSIZE = 62;

        [NativeTypeName("#define WINHTTP_FIRST_OPTION WINHTTP_OPTION_CALLBACK")]
        public const int WINHTTP_FIRST_OPTION = 1;

        [NativeTypeName("#define WINHTTP_OPTION_CALLBACK 1")]
        public const int WINHTTP_OPTION_CALLBACK = 1;

        [NativeTypeName("#define WINHTTP_OPTION_RESOLVE_TIMEOUT 2")]
        public const int WINHTTP_OPTION_RESOLVE_TIMEOUT = 2;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECT_TIMEOUT 3")]
        public const int WINHTTP_OPTION_CONNECT_TIMEOUT = 3;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECT_RETRIES 4")]
        public const int WINHTTP_OPTION_CONNECT_RETRIES = 4;

        [NativeTypeName("#define WINHTTP_OPTION_SEND_TIMEOUT 5")]
        public const int WINHTTP_OPTION_SEND_TIMEOUT = 5;

        [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_TIMEOUT 6")]
        public const int WINHTTP_OPTION_RECEIVE_TIMEOUT = 6;

        [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_RESPONSE_TIMEOUT 7")]
        public const int WINHTTP_OPTION_RECEIVE_RESPONSE_TIMEOUT = 7;

        [NativeTypeName("#define WINHTTP_OPTION_HANDLE_TYPE 9")]
        public const int WINHTTP_OPTION_HANDLE_TYPE = 9;

        [NativeTypeName("#define WINHTTP_OPTION_READ_BUFFER_SIZE 12")]
        public const int WINHTTP_OPTION_READ_BUFFER_SIZE = 12;

        [NativeTypeName("#define WINHTTP_OPTION_WRITE_BUFFER_SIZE 13")]
        public const int WINHTTP_OPTION_WRITE_BUFFER_SIZE = 13;

        [NativeTypeName("#define WINHTTP_OPTION_PARENT_HANDLE 21")]
        public const int WINHTTP_OPTION_PARENT_HANDLE = 21;

        [NativeTypeName("#define WINHTTP_OPTION_EXTENDED_ERROR 24")]
        public const int WINHTTP_OPTION_EXTENDED_ERROR = 24;

        [NativeTypeName("#define WINHTTP_OPTION_SECURITY_FLAGS 31")]
        public const int WINHTTP_OPTION_SECURITY_FLAGS = 31;

        [NativeTypeName("#define WINHTTP_OPTION_SECURITY_CERTIFICATE_STRUCT 32")]
        public const int WINHTTP_OPTION_SECURITY_CERTIFICATE_STRUCT = 32;

        [NativeTypeName("#define WINHTTP_OPTION_URL 34")]
        public const int WINHTTP_OPTION_URL = 34;

        [NativeTypeName("#define WINHTTP_OPTION_SECURITY_KEY_BITNESS 36")]
        public const int WINHTTP_OPTION_SECURITY_KEY_BITNESS = 36;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY 38")]
        public const int WINHTTP_OPTION_PROXY = 38;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY_RESULT_ENTRY 39")]
        public const int WINHTTP_OPTION_PROXY_RESULT_ENTRY = 39;

        [NativeTypeName("#define WINHTTP_OPTION_USER_AGENT 41")]
        public const int WINHTTP_OPTION_USER_AGENT = 41;

        [NativeTypeName("#define WINHTTP_OPTION_CONTEXT_VALUE 45")]
        public const int WINHTTP_OPTION_CONTEXT_VALUE = 45;

        [NativeTypeName("#define WINHTTP_OPTION_CLIENT_CERT_CONTEXT 47")]
        public const int WINHTTP_OPTION_CLIENT_CERT_CONTEXT = 47;

        [NativeTypeName("#define WINHTTP_OPTION_REQUEST_PRIORITY 58")]
        public const int WINHTTP_OPTION_REQUEST_PRIORITY = 58;

        [NativeTypeName("#define WINHTTP_OPTION_HTTP_VERSION 59")]
        public const int WINHTTP_OPTION_HTTP_VERSION = 59;

        [NativeTypeName("#define WINHTTP_OPTION_DISABLE_FEATURE 63")]
        public const int WINHTTP_OPTION_DISABLE_FEATURE = 63;

        [NativeTypeName("#define WINHTTP_OPTION_CODEPAGE 68")]
        public const int WINHTTP_OPTION_CODEPAGE = 68;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_CONNS_PER_SERVER 73")]
        public const int WINHTTP_OPTION_MAX_CONNS_PER_SERVER = 73;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_CONNS_PER_1_0_SERVER 74")]
        public const int WINHTTP_OPTION_MAX_CONNS_PER_1_0_SERVER = 74;

        [NativeTypeName("#define WINHTTP_OPTION_AUTOLOGON_POLICY 77")]
        public const int WINHTTP_OPTION_AUTOLOGON_POLICY = 77;

        [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CONTEXT 78")]
        public const int WINHTTP_OPTION_SERVER_CERT_CONTEXT = 78;

        [NativeTypeName("#define WINHTTP_OPTION_ENABLE_FEATURE 79")]
        public const int WINHTTP_OPTION_ENABLE_FEATURE = 79;

        [NativeTypeName("#define WINHTTP_OPTION_WORKER_THREAD_COUNT 80")]
        public const int WINHTTP_OPTION_WORKER_THREAD_COUNT = 80;

        [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_COBRANDING_TEXT 81")]
        public const int WINHTTP_OPTION_PASSPORT_COBRANDING_TEXT = 81;

        [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_COBRANDING_URL 82")]
        public const int WINHTTP_OPTION_PASSPORT_COBRANDING_URL = 82;

        [NativeTypeName("#define WINHTTP_OPTION_CONFIGURE_PASSPORT_AUTH 83")]
        public const int WINHTTP_OPTION_CONFIGURE_PASSPORT_AUTH = 83;

        [NativeTypeName("#define WINHTTP_OPTION_SECURE_PROTOCOLS 84")]
        public const int WINHTTP_OPTION_SECURE_PROTOCOLS = 84;

        [NativeTypeName("#define WINHTTP_OPTION_ENABLETRACING 85")]
        public const int WINHTTP_OPTION_ENABLETRACING = 85;

        [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_SIGN_OUT 86")]
        public const int WINHTTP_OPTION_PASSPORT_SIGN_OUT = 86;

        [NativeTypeName("#define WINHTTP_OPTION_PASSPORT_RETURN_URL 87")]
        public const int WINHTTP_OPTION_PASSPORT_RETURN_URL = 87;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY 88")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY = 88;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_HTTP_AUTOMATIC_REDIRECTS 89")]
        public const int WINHTTP_OPTION_MAX_HTTP_AUTOMATIC_REDIRECTS = 89;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_HTTP_STATUS_CONTINUE 90")]
        public const int WINHTTP_OPTION_MAX_HTTP_STATUS_CONTINUE = 90;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_RESPONSE_HEADER_SIZE 91")]
        public const int WINHTTP_OPTION_MAX_RESPONSE_HEADER_SIZE = 91;

        [NativeTypeName("#define WINHTTP_OPTION_MAX_RESPONSE_DRAIN_SIZE 92")]
        public const int WINHTTP_OPTION_MAX_RESPONSE_DRAIN_SIZE = 92;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_INFO 93")]
        public const int WINHTTP_OPTION_CONNECTION_INFO = 93;

        [NativeTypeName("#define WINHTTP_OPTION_CLIENT_CERT_ISSUER_LIST 94")]
        public const int WINHTTP_OPTION_CLIENT_CERT_ISSUER_LIST = 94;

        [NativeTypeName("#define WINHTTP_OPTION_SPN 96")]
        public const int WINHTTP_OPTION_SPN = 96;

        [NativeTypeName("#define WINHTTP_OPTION_GLOBAL_PROXY_CREDS 97")]
        public const int WINHTTP_OPTION_GLOBAL_PROXY_CREDS = 97;

        [NativeTypeName("#define WINHTTP_OPTION_GLOBAL_SERVER_CREDS 98")]
        public const int WINHTTP_OPTION_GLOBAL_SERVER_CREDS = 98;

        [NativeTypeName("#define WINHTTP_OPTION_UNLOAD_NOTIFY_EVENT 99")]
        public const int WINHTTP_OPTION_UNLOAD_NOTIFY_EVENT = 99;

        [NativeTypeName("#define WINHTTP_OPTION_REJECT_USERPWD_IN_URL 100")]
        public const int WINHTTP_OPTION_REJECT_USERPWD_IN_URL = 100;

        [NativeTypeName("#define WINHTTP_OPTION_USE_GLOBAL_SERVER_CREDENTIALS 101")]
        public const int WINHTTP_OPTION_USE_GLOBAL_SERVER_CREDENTIALS = 101;

        [NativeTypeName("#define WINHTTP_OPTION_RECEIVE_PROXY_CONNECT_RESPONSE 103")]
        public const int WINHTTP_OPTION_RECEIVE_PROXY_CONNECT_RESPONSE = 103;

        [NativeTypeName("#define WINHTTP_OPTION_IS_PROXY_CONNECT_RESPONSE 104")]
        public const int WINHTTP_OPTION_IS_PROXY_CONNECT_RESPONSE = 104;

        [NativeTypeName("#define WINHTTP_OPTION_SERVER_SPN_USED 106")]
        public const int WINHTTP_OPTION_SERVER_SPN_USED = 106;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY_SPN_USED 107")]
        public const int WINHTTP_OPTION_PROXY_SPN_USED = 107;

        [NativeTypeName("#define WINHTTP_OPTION_SERVER_CBT 108")]
        public const int WINHTTP_OPTION_SERVER_CBT = 108;

        [NativeTypeName("#define WINHTTP_OPTION_UNSAFE_HEADER_PARSING 110")]
        public const int WINHTTP_OPTION_UNSAFE_HEADER_PARSING = 110;

        [NativeTypeName("#define WINHTTP_OPTION_ASSURED_NON_BLOCKING_CALLBACKS 111")]
        public const int WINHTTP_OPTION_ASSURED_NON_BLOCKING_CALLBACKS = 111;

        [NativeTypeName("#define WINHTTP_OPTION_UPGRADE_TO_WEB_SOCKET 114")]
        public const int WINHTTP_OPTION_UPGRADE_TO_WEB_SOCKET = 114;

        [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_CLOSE_TIMEOUT 115")]
        public const int WINHTTP_OPTION_WEB_SOCKET_CLOSE_TIMEOUT = 115;

        [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_KEEPALIVE_INTERVAL 116")]
        public const int WINHTTP_OPTION_WEB_SOCKET_KEEPALIVE_INTERVAL = 116;

        [NativeTypeName("#define WINHTTP_OPTION_DECOMPRESSION 118")]
        public const int WINHTTP_OPTION_DECOMPRESSION = 118;

        [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_RECEIVE_BUFFER_SIZE 122")]
        public const int WINHTTP_OPTION_WEB_SOCKET_RECEIVE_BUFFER_SIZE = 122;

        [NativeTypeName("#define WINHTTP_OPTION_WEB_SOCKET_SEND_BUFFER_SIZE 123")]
        public const int WINHTTP_OPTION_WEB_SOCKET_SEND_BUFFER_SIZE = 123;

        [NativeTypeName("#define WINHTTP_OPTION_TCP_PRIORITY_HINT 128")]
        public const int WINHTTP_OPTION_TCP_PRIORITY_HINT = 128;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_FILTER 131")]
        public const int WINHTTP_OPTION_CONNECTION_FILTER = 131;

        [NativeTypeName("#define WINHTTP_OPTION_ENABLE_HTTP_PROTOCOL 133")]
        public const int WINHTTP_OPTION_ENABLE_HTTP_PROTOCOL = 133;

        [NativeTypeName("#define WINHTTP_OPTION_HTTP_PROTOCOL_USED 134")]
        public const int WINHTTP_OPTION_HTTP_PROTOCOL_USED = 134;

        [NativeTypeName("#define WINHTTP_OPTION_KDC_PROXY_SETTINGS 136")]
        public const int WINHTTP_OPTION_KDC_PROXY_SETTINGS = 136;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY_DISABLE_SERVICE_CALLS 137")]
        public const int WINHTTP_OPTION_PROXY_DISABLE_SERVICE_CALLS = 137;

        [NativeTypeName("#define WINHTTP_OPTION_ENCODE_EXTRA 138")]
        public const int WINHTTP_OPTION_ENCODE_EXTRA = 138;

        [NativeTypeName("#define WINHTTP_OPTION_DISABLE_STREAM_QUEUE 139")]
        public const int WINHTTP_OPTION_DISABLE_STREAM_QUEUE = 139;

        [NativeTypeName("#define WINHTTP_OPTION_IPV6_FAST_FALLBACK 140")]
        public const int WINHTTP_OPTION_IPV6_FAST_FALLBACK = 140;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_STATS_V0 141")]
        public const int WINHTTP_OPTION_CONNECTION_STATS_V0 = 141;

        [NativeTypeName("#define WINHTTP_OPTION_REQUEST_TIMES 142")]
        public const int WINHTTP_OPTION_REQUEST_TIMES = 142;

        [NativeTypeName("#define WINHTTP_OPTION_EXPIRE_CONNECTION 143")]
        public const int WINHTTP_OPTION_EXPIRE_CONNECTION = 143;

        [NativeTypeName("#define WINHTTP_OPTION_DISABLE_SECURE_PROTOCOL_FALLBACK 144")]
        public const int WINHTTP_OPTION_DISABLE_SECURE_PROTOCOL_FALLBACK = 144;

        [NativeTypeName("#define WINHTTP_OPTION_HTTP_PROTOCOL_REQUIRED 145")]
        public const int WINHTTP_OPTION_HTTP_PROTOCOL_REQUIRED = 145;

        [NativeTypeName("#define WINHTTP_OPTION_REQUEST_STATS 146")]
        public const int WINHTTP_OPTION_REQUEST_STATS = 146;

        [NativeTypeName("#define WINHTTP_OPTION_SERVER_CERT_CHAIN_CONTEXT 147")]
        public const int WINHTTP_OPTION_SERVER_CERT_CHAIN_CONTEXT = 147;

        [NativeTypeName("#define WINHTTP_OPTION_CONNECTION_STATS_V1 150")]
        public const int WINHTTP_OPTION_CONNECTION_STATS_V1 = 150;

        [NativeTypeName("#define WINHTTP_OPTION_SECURITY_INFO 151")]
        public const int WINHTTP_OPTION_SECURITY_INFO = 151;

        [NativeTypeName("#define WINHTTP_OPTION_TCP_KEEPALIVE 152")]
        public const int WINHTTP_OPTION_TCP_KEEPALIVE = 152;

        [NativeTypeName("#define WINHTTP_OPTION_TCP_FAST_OPEN 153")]
        public const int WINHTTP_OPTION_TCP_FAST_OPEN = 153;

        [NativeTypeName("#define WINHTTP_OPTION_TLS_FALSE_START 154")]
        public const int WINHTTP_OPTION_TLS_FALSE_START = 154;

        [NativeTypeName("#define WINHTTP_OPTION_IGNORE_CERT_REVOCATION_OFFLINE 155")]
        public const int WINHTTP_OPTION_IGNORE_CERT_REVOCATION_OFFLINE = 155;

        [NativeTypeName("#define WINHTTP_OPTION_SOURCE_ADDRESS 156")]
        public const int WINHTTP_OPTION_SOURCE_ADDRESS = 156;

        [NativeTypeName("#define WINHTTP_OPTION_HEAP_EXTENSION 157")]
        public const int WINHTTP_OPTION_HEAP_EXTENSION = 157;

        [NativeTypeName("#define WINHTTP_OPTION_TLS_PROTOCOL_INSECURE_FALLBACK 158")]
        public const int WINHTTP_OPTION_TLS_PROTOCOL_INSECURE_FALLBACK = 158;

        [NativeTypeName("#define WINHTTP_OPTION_STREAM_ERROR_CODE 159")]
        public const int WINHTTP_OPTION_STREAM_ERROR_CODE = 159;

        [NativeTypeName("#define WINHTTP_OPTION_REQUIRE_STREAM_END 160")]
        public const int WINHTTP_OPTION_REQUIRE_STREAM_END = 160;

        [NativeTypeName("#define WINHTTP_OPTION_ENABLE_HTTP2_PLUS_CLIENT_CERT 161")]
        public const int WINHTTP_OPTION_ENABLE_HTTP2_PLUS_CLIENT_CERT = 161;

        [NativeTypeName("#define WINHTTP_OPTION_FAILED_CONNECTION_RETRIES 162")]
        public const int WINHTTP_OPTION_FAILED_CONNECTION_RETRIES = 162;

        [NativeTypeName("#define WINHTTP_OPTION_SET_GLOBAL_CALLBACK 163")]
        public const int WINHTTP_OPTION_SET_GLOBAL_CALLBACK = 163;

        [NativeTypeName("#define WINHTTP_OPTION_HTTP2_KEEPALIVE 164")]
        public const int WINHTTP_OPTION_HTTP2_KEEPALIVE = 164;

        [NativeTypeName("#define WINHTTP_OPTION_RESOLUTION_HOSTNAME 165")]
        public const int WINHTTP_OPTION_RESOLUTION_HOSTNAME = 165;

        [NativeTypeName("#define WINHTTP_OPTION_SET_TOKEN_BINDING 166")]
        public const int WINHTTP_OPTION_SET_TOKEN_BINDING = 166;

        [NativeTypeName("#define WINHTTP_OPTION_TOKEN_BINDING_PUBLIC_KEY 167")]
        public const int WINHTTP_OPTION_TOKEN_BINDING_PUBLIC_KEY = 167;

        [NativeTypeName("#define WINHTTP_OPTION_REFERER_TOKEN_BINDING_HOSTNAME 168")]
        public const int WINHTTP_OPTION_REFERER_TOKEN_BINDING_HOSTNAME = 168;

        [NativeTypeName("#define WINHTTP_OPTION_HTTP2_PLUS_TRANSFER_ENCODING 169")]
        public const int WINHTTP_OPTION_HTTP2_PLUS_TRANSFER_ENCODING = 169;

        [NativeTypeName("#define WINHTTP_OPTION_RESOLVER_CACHE_CONFIG 170")]
        public const int WINHTTP_OPTION_RESOLVER_CACHE_CONFIG = 170;

        [NativeTypeName("#define WINHTTP_OPTION_DISABLE_CERT_CHAIN_BUILDING 171")]
        public const int WINHTTP_OPTION_DISABLE_CERT_CHAIN_BUILDING = 171;

        [NativeTypeName("#define WINHTTP_OPTION_BACKGROUND_CONNECTIONS 172")]
        public const int WINHTTP_OPTION_BACKGROUND_CONNECTIONS = 172;

        [NativeTypeName("#define WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION 173")]
        public const int WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION = 173;

        [NativeTypeName("#define WINHTTP_OPTION_ENABLE_TEST_SIGNING 174")]
        public const int WINHTTP_OPTION_ENABLE_TEST_SIGNING = 174;

        [NativeTypeName("#define WINHTTP_OPTION_NTSERVICE_FLAG_TEST 175")]
        public const int WINHTTP_OPTION_NTSERVICE_FLAG_TEST = 175;

        [NativeTypeName("#define WINHTTP_OPTION_DISABLE_PROXY_LINK_LOCAL_NAME_RESOLUTION 176")]
        public const int WINHTTP_OPTION_DISABLE_PROXY_LINK_LOCAL_NAME_RESOLUTION = 176;

        [NativeTypeName("#define WINHTTP_LAST_OPTION WINHTTP_OPTION_FIRST_AVAILABLE_CONNECTION")]
        public const int WINHTTP_LAST_OPTION = 173;

        [NativeTypeName("#define WINHTTP_OPTION_USERNAME 0x1000")]
        public const int WINHTTP_OPTION_USERNAME = 0x1000;

        [NativeTypeName("#define WINHTTP_OPTION_PASSWORD 0x1001")]
        public const int WINHTTP_OPTION_PASSWORD = 0x1001;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY_USERNAME 0x1002")]
        public const int WINHTTP_OPTION_PROXY_USERNAME = 0x1002;

        [NativeTypeName("#define WINHTTP_OPTION_PROXY_PASSWORD 0x1003")]
        public const int WINHTTP_OPTION_PROXY_PASSWORD = 0x1003;

        [NativeTypeName("#define WINHTTP_CONNS_PER_SERVER_UNLIMITED 0xFFFFFFFF")]
        public const uint WINHTTP_CONNS_PER_SERVER_UNLIMITED = 0xFFFFFFFF;

        [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_408 0x1")]
        public const int WINHTTP_CONNECTION_RETRY_CONDITION_408 = 0x1;

        [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE 0x2")]
        public const int WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE = 0x2;

        [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION 0x4")]
        public const int WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION = 0x4;

        [NativeTypeName("#define WINHTTP_CONNECTION_RETRY_CONDITION_MASK (WINHTTP_CONNECTION_RETRY_CONDITION_408 |             \\\r\n     WINHTTP_CONNECTION_RETRY_CONDITION_SSL_HANDSHAKE |   \\\r\n     WINHTTP_CONNECTION_RETRY_CONDITION_STALE_CONNECTION)")]
        public const int WINHTTP_CONNECTION_RETRY_CONDITION_MASK = (0x1 | 0x2 | 0x4);

        [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_GZIP 0x00000001")]
        public const int WINHTTP_DECOMPRESSION_FLAG_GZIP = 0x00000001;

        [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_DEFLATE 0x00000002")]
        public const int WINHTTP_DECOMPRESSION_FLAG_DEFLATE = 0x00000002;

        [NativeTypeName("#define WINHTTP_DECOMPRESSION_FLAG_ALL ( \\\r\n    WINHTTP_DECOMPRESSION_FLAG_GZIP    | \\\r\n    WINHTTP_DECOMPRESSION_FLAG_DEFLATE)")]
        public const int WINHTTP_DECOMPRESSION_FLAG_ALL = (0x00000001 | 0x00000002);

        [NativeTypeName("#define WINHTTP_PROTOCOL_FLAG_HTTP2 0x1")]
        public const int WINHTTP_PROTOCOL_FLAG_HTTP2 = 0x1;

        [NativeTypeName("#define WINHTTP_PROTOCOL_FLAG_HTTP3 0x2")]
        public const int WINHTTP_PROTOCOL_FLAG_HTTP3 = 0x2;

        [NativeTypeName("#define WINHTTP_PROTOCOL_MASK (WINHTTP_PROTOCOL_FLAG_HTTP2 | WINHTTP_PROTOCOL_FLAG_HTTP3)")]
        public const int WINHTTP_PROTOCOL_MASK = (0x1 | 0x2);

        [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM 0")]
        public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM = 0;

        [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_LOW 1")]
        public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_LOW = 1;

        [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_HIGH 2")]
        public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_HIGH = 2;

        [NativeTypeName("#define WINHTTP_AUTOLOGON_SECURITY_LEVEL_DEFAULT WINHTTP_AUTOLOGON_SECURITY_LEVEL_MEDIUM")]
        public const int WINHTTP_AUTOLOGON_SECURITY_LEVEL_DEFAULT = 0;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_NEVER 0")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY_NEVER = 0;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP 1")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP = 1;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS 2")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS = 2;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_LAST WINHTTP_OPTION_REDIRECT_POLICY_ALWAYS")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY_LAST = 2;

        [NativeTypeName("#define WINHTTP_OPTION_REDIRECT_POLICY_DEFAULT WINHTTP_OPTION_REDIRECT_POLICY_DISALLOW_HTTPS_TO_HTTP")]
        public const int WINHTTP_OPTION_REDIRECT_POLICY_DEFAULT = 1;

        [NativeTypeName("#define WINHTTP_DISABLE_PASSPORT_AUTH 0x00000000")]
        public const int WINHTTP_DISABLE_PASSPORT_AUTH = 0x00000000;

        [NativeTypeName("#define WINHTTP_ENABLE_PASSPORT_AUTH 0x10000000")]
        public const int WINHTTP_ENABLE_PASSPORT_AUTH = 0x10000000;

        [NativeTypeName("#define WINHTTP_DISABLE_PASSPORT_KEYRING 0x20000000")]
        public const int WINHTTP_DISABLE_PASSPORT_KEYRING = 0x20000000;

        [NativeTypeName("#define WINHTTP_ENABLE_PASSPORT_KEYRING 0x40000000")]
        public const int WINHTTP_ENABLE_PASSPORT_KEYRING = 0x40000000;

        [NativeTypeName("#define WINHTTP_DISABLE_COOKIES 0x00000001")]
        public const int WINHTTP_DISABLE_COOKIES = 0x00000001;

        [NativeTypeName("#define WINHTTP_DISABLE_REDIRECTS 0x00000002")]
        public const int WINHTTP_DISABLE_REDIRECTS = 0x00000002;

        [NativeTypeName("#define WINHTTP_DISABLE_AUTHENTICATION 0x00000004")]
        public const int WINHTTP_DISABLE_AUTHENTICATION = 0x00000004;

        [NativeTypeName("#define WINHTTP_DISABLE_KEEP_ALIVE 0x00000008")]
        public const int WINHTTP_DISABLE_KEEP_ALIVE = 0x00000008;

        [NativeTypeName("#define WINHTTP_ENABLE_SSL_REVOCATION 0x00000001")]
        public const int WINHTTP_ENABLE_SSL_REVOCATION = 0x00000001;

        [NativeTypeName("#define WINHTTP_ENABLE_SSL_REVERT_IMPERSONATION 0x00000002")]
        public const int WINHTTP_ENABLE_SSL_REVERT_IMPERSONATION = 0x00000002;

        [NativeTypeName("#define WINHTTP_DISABLE_SPN_SERVER_PORT 0x00000000")]
        public const int WINHTTP_DISABLE_SPN_SERVER_PORT = 0x00000000;

        [NativeTypeName("#define WINHTTP_ENABLE_SPN_SERVER_PORT 0x00000001")]
        public const int WINHTTP_ENABLE_SPN_SERVER_PORT = 0x00000001;

        [NativeTypeName("#define WINHTTP_OPTION_SPN_MASK WINHTTP_ENABLE_SPN_SERVER_PORT")]
        public const int WINHTTP_OPTION_SPN_MASK = 0x00000001;

        [NativeTypeName("#define WINHTTP_HANDLE_TYPE_SESSION 1")]
        public const int WINHTTP_HANDLE_TYPE_SESSION = 1;

        [NativeTypeName("#define WINHTTP_HANDLE_TYPE_CONNECT 2")]
        public const int WINHTTP_HANDLE_TYPE_CONNECT = 2;

        [NativeTypeName("#define WINHTTP_HANDLE_TYPE_REQUEST 3")]
        public const int WINHTTP_HANDLE_TYPE_REQUEST = 3;

        [NativeTypeName("#define WINHTTP_AUTH_SCHEME_BASIC 0x00000001")]
        public const int WINHTTP_AUTH_SCHEME_BASIC = 0x00000001;

        [NativeTypeName("#define WINHTTP_AUTH_SCHEME_NTLM 0x00000002")]
        public const int WINHTTP_AUTH_SCHEME_NTLM = 0x00000002;

        [NativeTypeName("#define WINHTTP_AUTH_SCHEME_PASSPORT 0x00000004")]
        public const int WINHTTP_AUTH_SCHEME_PASSPORT = 0x00000004;

        [NativeTypeName("#define WINHTTP_AUTH_SCHEME_DIGEST 0x00000008")]
        public const int WINHTTP_AUTH_SCHEME_DIGEST = 0x00000008;

        [NativeTypeName("#define WINHTTP_AUTH_SCHEME_NEGOTIATE 0x00000010")]
        public const int WINHTTP_AUTH_SCHEME_NEGOTIATE = 0x00000010;

        [NativeTypeName("#define WINHTTP_AUTH_TARGET_SERVER 0x00000000")]
        public const int WINHTTP_AUTH_TARGET_SERVER = 0x00000000;

        [NativeTypeName("#define WINHTTP_AUTH_TARGET_PROXY 0x00000001")]
        public const int WINHTTP_AUTH_TARGET_PROXY = 0x00000001;

        [NativeTypeName("#define SECURITY_FLAG_SECURE 0x00000001")]
        public const int SECURITY_FLAG_SECURE = 0x00000001;

        [NativeTypeName("#define SECURITY_FLAG_STRENGTH_WEAK 0x10000000")]
        public const int SECURITY_FLAG_STRENGTH_WEAK = 0x10000000;

        [NativeTypeName("#define SECURITY_FLAG_STRENGTH_MEDIUM 0x40000000")]
        public const int SECURITY_FLAG_STRENGTH_MEDIUM = 0x40000000;

        [NativeTypeName("#define SECURITY_FLAG_STRENGTH_STRONG 0x20000000")]
        public const int SECURITY_FLAG_STRENGTH_STRONG = 0x20000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_REV_FAILED 0x00000001")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_REV_FAILED = 0x00000001;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CERT 0x00000002")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CERT = 0x00000002;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_REVOKED 0x00000004")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_REVOKED = 0x00000004;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CA 0x00000008")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_INVALID_CA = 0x00000008;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_CN_INVALID 0x00000010")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_CN_INVALID = 0x00000010;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_DATE_INVALID 0x00000020")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_DATE_INVALID = 0x00000020;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_CERT_WRONG_USAGE 0x00000040")]
        public const int WINHTTP_CALLBACK_STATUS_FLAG_CERT_WRONG_USAGE = 0x00000040;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_FLAG_SECURITY_CHANNEL_ERROR 0x80000000")]
        public const uint WINHTTP_CALLBACK_STATUS_FLAG_SECURITY_CHANNEL_ERROR = 0x80000000;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 0x00000008")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 = 0x00000008;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 0x00000020")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 = 0x00000020;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1 0x00000080")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1 = 0x00000080;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_1 0x00000200")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_1 = 0x00000200;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2 0x00000800")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2 = 0x00000800;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_3 0x00002000")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_3 = 0x00002000;

        [NativeTypeName("#define WINHTTP_FLAG_SECURE_PROTOCOL_ALL (WINHTTP_FLAG_SECURE_PROTOCOL_SSL2 | \\\r\n                                             WINHTTP_FLAG_SECURE_PROTOCOL_SSL3 | \\\r\n                                             WINHTTP_FLAG_SECURE_PROTOCOL_TLS1)")]
        public const int WINHTTP_FLAG_SECURE_PROTOCOL_ALL = (0x00000008 | 0x00000020 | 0x00000080);

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RESOLVING_NAME 0x00000001")]
        public const int WINHTTP_CALLBACK_STATUS_RESOLVING_NAME = 0x00000001;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_NAME_RESOLVED 0x00000002")]
        public const int WINHTTP_CALLBACK_STATUS_NAME_RESOLVED = 0x00000002;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER 0x00000004")]
        public const int WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER = 0x00000004;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER 0x00000008")]
        public const int WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER = 0x00000008;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SENDING_REQUEST 0x00000010")]
        public const int WINHTTP_CALLBACK_STATUS_SENDING_REQUEST = 0x00000010;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REQUEST_SENT 0x00000020")]
        public const int WINHTTP_CALLBACK_STATUS_REQUEST_SENT = 0x00000020;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE 0x00000040")]
        public const int WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE = 0x00000040;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED 0x00000080")]
        public const int WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED = 0x00000080;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION 0x00000100")]
        public const int WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION = 0x00000100;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED 0x00000200")]
        public const int WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED = 0x00000200;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HANDLE_CREATED 0x00000400")]
        public const int WINHTTP_CALLBACK_STATUS_HANDLE_CREATED = 0x00000400;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING 0x00000800")]
        public const int WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING = 0x00000800;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_DETECTING_PROXY 0x00001000")]
        public const int WINHTTP_CALLBACK_STATUS_DETECTING_PROXY = 0x00001000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REDIRECT 0x00004000")]
        public const int WINHTTP_CALLBACK_STATUS_REDIRECT = 0x00004000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE 0x00008000")]
        public const int WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE = 0x00008000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SECURE_FAILURE 0x00010000")]
        public const int WINHTTP_CALLBACK_STATUS_SECURE_FAILURE = 0x00010000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE 0x00020000")]
        public const int WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE = 0x00020000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE 0x00040000")]
        public const int WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE = 0x00040000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_READ_COMPLETE 0x00080000")]
        public const int WINHTTP_CALLBACK_STATUS_READ_COMPLETE = 0x00080000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE 0x00100000")]
        public const int WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE = 0x00100000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_REQUEST_ERROR 0x00200000")]
        public const int WINHTTP_CALLBACK_STATUS_REQUEST_ERROR = 0x00200000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE 0x00400000")]
        public const int WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE = 0x00400000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE 0x01000000")]
        public const int WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE = 0x01000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_CLOSE_COMPLETE 0x02000000")]
        public const int WINHTTP_CALLBACK_STATUS_CLOSE_COMPLETE = 0x02000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SHUTDOWN_COMPLETE 0x04000000")]
        public const int WINHTTP_CALLBACK_STATUS_SHUTDOWN_COMPLETE = 0x04000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SETTINGS_WRITE_COMPLETE 0x10000000")]
        public const int WINHTTP_CALLBACK_STATUS_SETTINGS_WRITE_COMPLETE = 0x10000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_STATUS_SETTINGS_READ_COMPLETE 0x20000000")]
        public const int WINHTTP_CALLBACK_STATUS_SETTINGS_READ_COMPLETE = 0x20000000;

        [NativeTypeName("#define API_RECEIVE_RESPONSE (1)")]
        public const int API_RECEIVE_RESPONSE = (1);

        [NativeTypeName("#define API_QUERY_DATA_AVAILABLE (2)")]
        public const int API_QUERY_DATA_AVAILABLE = (2);

        [NativeTypeName("#define API_READ_DATA (3)")]
        public const int API_READ_DATA = (3);

        [NativeTypeName("#define API_WRITE_DATA (4)")]
        public const int API_WRITE_DATA = (4);

        [NativeTypeName("#define API_SEND_REQUEST (5)")]
        public const int API_SEND_REQUEST = (5);

        [NativeTypeName("#define API_GET_PROXY_FOR_URL (6)")]
        public const int API_GET_PROXY_FOR_URL = (6);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_RESOLVE_NAME (WINHTTP_CALLBACK_STATUS_RESOLVING_NAME | WINHTTP_CALLBACK_STATUS_NAME_RESOLVED)")]
        public const int WINHTTP_CALLBACK_FLAG_RESOLVE_NAME = (0x00000001 | 0x00000002);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_CONNECT_TO_SERVER (WINHTTP_CALLBACK_STATUS_CONNECTING_TO_SERVER | WINHTTP_CALLBACK_STATUS_CONNECTED_TO_SERVER)")]
        public const int WINHTTP_CALLBACK_FLAG_CONNECT_TO_SERVER = (0x00000004 | 0x00000008);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SEND_REQUEST (WINHTTP_CALLBACK_STATUS_SENDING_REQUEST | WINHTTP_CALLBACK_STATUS_REQUEST_SENT)")]
        public const int WINHTTP_CALLBACK_FLAG_SEND_REQUEST = (0x00000010 | 0x00000020);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_RECEIVE_RESPONSE (WINHTTP_CALLBACK_STATUS_RECEIVING_RESPONSE | WINHTTP_CALLBACK_STATUS_RESPONSE_RECEIVED)")]
        public const int WINHTTP_CALLBACK_FLAG_RECEIVE_RESPONSE = (0x00000040 | 0x00000080);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_CLOSE_CONNECTION (WINHTTP_CALLBACK_STATUS_CLOSING_CONNECTION | WINHTTP_CALLBACK_STATUS_CONNECTION_CLOSED)")]
        public const int WINHTTP_CALLBACK_FLAG_CLOSE_CONNECTION = (0x00000100 | 0x00000200);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_HANDLES (WINHTTP_CALLBACK_STATUS_HANDLE_CREATED | WINHTTP_CALLBACK_STATUS_HANDLE_CLOSING)")]
        public const int WINHTTP_CALLBACK_FLAG_HANDLES = (0x00000400 | 0x00000800);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_DETECTING_PROXY WINHTTP_CALLBACK_STATUS_DETECTING_PROXY")]
        public const int WINHTTP_CALLBACK_FLAG_DETECTING_PROXY = 0x00001000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_REDIRECT WINHTTP_CALLBACK_STATUS_REDIRECT")]
        public const int WINHTTP_CALLBACK_FLAG_REDIRECT = 0x00004000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_INTERMEDIATE_RESPONSE WINHTTP_CALLBACK_STATUS_INTERMEDIATE_RESPONSE")]
        public const int WINHTTP_CALLBACK_FLAG_INTERMEDIATE_RESPONSE = 0x00008000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SECURE_FAILURE WINHTTP_CALLBACK_STATUS_SECURE_FAILURE")]
        public const int WINHTTP_CALLBACK_FLAG_SECURE_FAILURE = 0x00010000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_SENDREQUEST_COMPLETE WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE")]
        public const int WINHTTP_CALLBACK_FLAG_SENDREQUEST_COMPLETE = 0x00400000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_HEADERS_AVAILABLE WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE")]
        public const int WINHTTP_CALLBACK_FLAG_HEADERS_AVAILABLE = 0x00020000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_DATA_AVAILABLE WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE")]
        public const int WINHTTP_CALLBACK_FLAG_DATA_AVAILABLE = 0x00040000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_READ_COMPLETE WINHTTP_CALLBACK_STATUS_READ_COMPLETE")]
        public const int WINHTTP_CALLBACK_FLAG_READ_COMPLETE = 0x00080000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_WRITE_COMPLETE WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE")]
        public const int WINHTTP_CALLBACK_FLAG_WRITE_COMPLETE = 0x00100000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_REQUEST_ERROR WINHTTP_CALLBACK_STATUS_REQUEST_ERROR")]
        public const int WINHTTP_CALLBACK_FLAG_REQUEST_ERROR = 0x00200000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_GETPROXYFORURL_COMPLETE WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE")]
        public const int WINHTTP_CALLBACK_FLAG_GETPROXYFORURL_COMPLETE = 0x01000000;

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_ALL_COMPLETIONS (WINHTTP_CALLBACK_STATUS_SENDREQUEST_COMPLETE   \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_HEADERS_AVAILABLE     \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_DATA_AVAILABLE        \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_READ_COMPLETE         \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_WRITE_COMPLETE        \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_REQUEST_ERROR         \\\r\n                                                        | WINHTTP_CALLBACK_STATUS_GETPROXYFORURL_COMPLETE)")]
        public const int WINHTTP_CALLBACK_FLAG_ALL_COMPLETIONS = (0x00400000 | 0x00020000 | 0x00040000 | 0x00080000 | 0x00100000 | 0x00200000 | 0x01000000);

        [NativeTypeName("#define WINHTTP_CALLBACK_FLAG_ALL_NOTIFICATIONS 0xffffffff")]
        public const uint WINHTTP_CALLBACK_FLAG_ALL_NOTIFICATIONS = 0xffffffff;

        [NativeTypeName("#define WINHTTP_QUERY_MIME_VERSION 0")]
        public const int WINHTTP_QUERY_MIME_VERSION = 0;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_TYPE 1")]
        public const int WINHTTP_QUERY_CONTENT_TYPE = 1;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_TRANSFER_ENCODING 2")]
        public const int WINHTTP_QUERY_CONTENT_TRANSFER_ENCODING = 2;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_ID 3")]
        public const int WINHTTP_QUERY_CONTENT_ID = 3;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_DESCRIPTION 4")]
        public const int WINHTTP_QUERY_CONTENT_DESCRIPTION = 4;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LENGTH 5")]
        public const int WINHTTP_QUERY_CONTENT_LENGTH = 5;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LANGUAGE 6")]
        public const int WINHTTP_QUERY_CONTENT_LANGUAGE = 6;

        [NativeTypeName("#define WINHTTP_QUERY_ALLOW 7")]
        public const int WINHTTP_QUERY_ALLOW = 7;

        [NativeTypeName("#define WINHTTP_QUERY_PUBLIC 8")]
        public const int WINHTTP_QUERY_PUBLIC = 8;

        [NativeTypeName("#define WINHTTP_QUERY_DATE 9")]
        public const int WINHTTP_QUERY_DATE = 9;

        [NativeTypeName("#define WINHTTP_QUERY_EXPIRES 10")]
        public const int WINHTTP_QUERY_EXPIRES = 10;

        [NativeTypeName("#define WINHTTP_QUERY_LAST_MODIFIED 11")]
        public const int WINHTTP_QUERY_LAST_MODIFIED = 11;

        [NativeTypeName("#define WINHTTP_QUERY_MESSAGE_ID 12")]
        public const int WINHTTP_QUERY_MESSAGE_ID = 12;

        [NativeTypeName("#define WINHTTP_QUERY_URI 13")]
        public const int WINHTTP_QUERY_URI = 13;

        [NativeTypeName("#define WINHTTP_QUERY_DERIVED_FROM 14")]
        public const int WINHTTP_QUERY_DERIVED_FROM = 14;

        [NativeTypeName("#define WINHTTP_QUERY_COST 15")]
        public const int WINHTTP_QUERY_COST = 15;

        [NativeTypeName("#define WINHTTP_QUERY_LINK 16")]
        public const int WINHTTP_QUERY_LINK = 16;

        [NativeTypeName("#define WINHTTP_QUERY_PRAGMA 17")]
        public const int WINHTTP_QUERY_PRAGMA = 17;

        [NativeTypeName("#define WINHTTP_QUERY_VERSION 18")]
        public const int WINHTTP_QUERY_VERSION = 18;

        [NativeTypeName("#define WINHTTP_QUERY_STATUS_CODE 19")]
        public const int WINHTTP_QUERY_STATUS_CODE = 19;

        [NativeTypeName("#define WINHTTP_QUERY_STATUS_TEXT 20")]
        public const int WINHTTP_QUERY_STATUS_TEXT = 20;

        [NativeTypeName("#define WINHTTP_QUERY_RAW_HEADERS 21")]
        public const int WINHTTP_QUERY_RAW_HEADERS = 21;

        [NativeTypeName("#define WINHTTP_QUERY_RAW_HEADERS_CRLF 22")]
        public const int WINHTTP_QUERY_RAW_HEADERS_CRLF = 22;

        [NativeTypeName("#define WINHTTP_QUERY_CONNECTION 23")]
        public const int WINHTTP_QUERY_CONNECTION = 23;

        [NativeTypeName("#define WINHTTP_QUERY_ACCEPT 24")]
        public const int WINHTTP_QUERY_ACCEPT = 24;

        [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_CHARSET 25")]
        public const int WINHTTP_QUERY_ACCEPT_CHARSET = 25;

        [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_ENCODING 26")]
        public const int WINHTTP_QUERY_ACCEPT_ENCODING = 26;

        [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_LANGUAGE 27")]
        public const int WINHTTP_QUERY_ACCEPT_LANGUAGE = 27;

        [NativeTypeName("#define WINHTTP_QUERY_AUTHORIZATION 28")]
        public const int WINHTTP_QUERY_AUTHORIZATION = 28;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_ENCODING 29")]
        public const int WINHTTP_QUERY_CONTENT_ENCODING = 29;

        [NativeTypeName("#define WINHTTP_QUERY_FORWARDED 30")]
        public const int WINHTTP_QUERY_FORWARDED = 30;

        [NativeTypeName("#define WINHTTP_QUERY_FROM 31")]
        public const int WINHTTP_QUERY_FROM = 31;

        [NativeTypeName("#define WINHTTP_QUERY_IF_MODIFIED_SINCE 32")]
        public const int WINHTTP_QUERY_IF_MODIFIED_SINCE = 32;

        [NativeTypeName("#define WINHTTP_QUERY_LOCATION 33")]
        public const int WINHTTP_QUERY_LOCATION = 33;

        [NativeTypeName("#define WINHTTP_QUERY_ORIG_URI 34")]
        public const int WINHTTP_QUERY_ORIG_URI = 34;

        [NativeTypeName("#define WINHTTP_QUERY_REFERER 35")]
        public const int WINHTTP_QUERY_REFERER = 35;

        [NativeTypeName("#define WINHTTP_QUERY_RETRY_AFTER 36")]
        public const int WINHTTP_QUERY_RETRY_AFTER = 36;

        [NativeTypeName("#define WINHTTP_QUERY_SERVER 37")]
        public const int WINHTTP_QUERY_SERVER = 37;

        [NativeTypeName("#define WINHTTP_QUERY_TITLE 38")]
        public const int WINHTTP_QUERY_TITLE = 38;

        [NativeTypeName("#define WINHTTP_QUERY_USER_AGENT 39")]
        public const int WINHTTP_QUERY_USER_AGENT = 39;

        [NativeTypeName("#define WINHTTP_QUERY_WWW_AUTHENTICATE 40")]
        public const int WINHTTP_QUERY_WWW_AUTHENTICATE = 40;

        [NativeTypeName("#define WINHTTP_QUERY_PROXY_AUTHENTICATE 41")]
        public const int WINHTTP_QUERY_PROXY_AUTHENTICATE = 41;

        [NativeTypeName("#define WINHTTP_QUERY_ACCEPT_RANGES 42")]
        public const int WINHTTP_QUERY_ACCEPT_RANGES = 42;

        [NativeTypeName("#define WINHTTP_QUERY_SET_COOKIE 43")]
        public const int WINHTTP_QUERY_SET_COOKIE = 43;

        [NativeTypeName("#define WINHTTP_QUERY_COOKIE 44")]
        public const int WINHTTP_QUERY_COOKIE = 44;

        [NativeTypeName("#define WINHTTP_QUERY_REQUEST_METHOD 45")]
        public const int WINHTTP_QUERY_REQUEST_METHOD = 45;

        [NativeTypeName("#define WINHTTP_QUERY_REFRESH 46")]
        public const int WINHTTP_QUERY_REFRESH = 46;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_DISPOSITION 47")]
        public const int WINHTTP_QUERY_CONTENT_DISPOSITION = 47;

        [NativeTypeName("#define WINHTTP_QUERY_AGE 48")]
        public const int WINHTTP_QUERY_AGE = 48;

        [NativeTypeName("#define WINHTTP_QUERY_CACHE_CONTROL 49")]
        public const int WINHTTP_QUERY_CACHE_CONTROL = 49;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_BASE 50")]
        public const int WINHTTP_QUERY_CONTENT_BASE = 50;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_LOCATION 51")]
        public const int WINHTTP_QUERY_CONTENT_LOCATION = 51;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_MD5 52")]
        public const int WINHTTP_QUERY_CONTENT_MD5 = 52;

        [NativeTypeName("#define WINHTTP_QUERY_CONTENT_RANGE 53")]
        public const int WINHTTP_QUERY_CONTENT_RANGE = 53;

        [NativeTypeName("#define WINHTTP_QUERY_ETAG 54")]
        public const int WINHTTP_QUERY_ETAG = 54;

        [NativeTypeName("#define WINHTTP_QUERY_HOST 55")]
        public const int WINHTTP_QUERY_HOST = 55;

        [NativeTypeName("#define WINHTTP_QUERY_IF_MATCH 56")]
        public const int WINHTTP_QUERY_IF_MATCH = 56;

        [NativeTypeName("#define WINHTTP_QUERY_IF_NONE_MATCH 57")]
        public const int WINHTTP_QUERY_IF_NONE_MATCH = 57;

        [NativeTypeName("#define WINHTTP_QUERY_IF_RANGE 58")]
        public const int WINHTTP_QUERY_IF_RANGE = 58;

        [NativeTypeName("#define WINHTTP_QUERY_IF_UNMODIFIED_SINCE 59")]
        public const int WINHTTP_QUERY_IF_UNMODIFIED_SINCE = 59;

        [NativeTypeName("#define WINHTTP_QUERY_MAX_FORWARDS 60")]
        public const int WINHTTP_QUERY_MAX_FORWARDS = 60;

        [NativeTypeName("#define WINHTTP_QUERY_PROXY_AUTHORIZATION 61")]
        public const int WINHTTP_QUERY_PROXY_AUTHORIZATION = 61;

        [NativeTypeName("#define WINHTTP_QUERY_RANGE 62")]
        public const int WINHTTP_QUERY_RANGE = 62;

        [NativeTypeName("#define WINHTTP_QUERY_TRANSFER_ENCODING 63")]
        public const int WINHTTP_QUERY_TRANSFER_ENCODING = 63;

        [NativeTypeName("#define WINHTTP_QUERY_UPGRADE 64")]
        public const int WINHTTP_QUERY_UPGRADE = 64;

        [NativeTypeName("#define WINHTTP_QUERY_VARY 65")]
        public const int WINHTTP_QUERY_VARY = 65;

        [NativeTypeName("#define WINHTTP_QUERY_VIA 66")]
        public const int WINHTTP_QUERY_VIA = 66;

        [NativeTypeName("#define WINHTTP_QUERY_WARNING 67")]
        public const int WINHTTP_QUERY_WARNING = 67;

        [NativeTypeName("#define WINHTTP_QUERY_EXPECT 68")]
        public const int WINHTTP_QUERY_EXPECT = 68;

        [NativeTypeName("#define WINHTTP_QUERY_PROXY_CONNECTION 69")]
        public const int WINHTTP_QUERY_PROXY_CONNECTION = 69;

        [NativeTypeName("#define WINHTTP_QUERY_UNLESS_MODIFIED_SINCE 70")]
        public const int WINHTTP_QUERY_UNLESS_MODIFIED_SINCE = 70;

        [NativeTypeName("#define WINHTTP_QUERY_PROXY_SUPPORT 75")]
        public const int WINHTTP_QUERY_PROXY_SUPPORT = 75;

        [NativeTypeName("#define WINHTTP_QUERY_AUTHENTICATION_INFO 76")]
        public const int WINHTTP_QUERY_AUTHENTICATION_INFO = 76;

        [NativeTypeName("#define WINHTTP_QUERY_PASSPORT_URLS 77")]
        public const int WINHTTP_QUERY_PASSPORT_URLS = 77;

        [NativeTypeName("#define WINHTTP_QUERY_PASSPORT_CONFIG 78")]
        public const int WINHTTP_QUERY_PASSPORT_CONFIG = 78;

        [NativeTypeName("#define WINHTTP_QUERY_MAX 78")]
        public const int WINHTTP_QUERY_MAX = 78;

        [NativeTypeName("#define WINHTTP_QUERY_EX_ALL_HEADERS WINHTTP_QUERY_RAW_HEADERS")]
        public const int WINHTTP_QUERY_EX_ALL_HEADERS = 21;

        [NativeTypeName("#define WINHTTP_QUERY_CUSTOM 65535")]
        public const int WINHTTP_QUERY_CUSTOM = 65535;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_REQUEST_HEADERS 0x80000000")]
        public const uint WINHTTP_QUERY_FLAG_REQUEST_HEADERS = 0x80000000;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_SYSTEMTIME 0x40000000")]
        public const int WINHTTP_QUERY_FLAG_SYSTEMTIME = 0x40000000;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_NUMBER 0x20000000")]
        public const int WINHTTP_QUERY_FLAG_NUMBER = 0x20000000;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_NUMBER64 0x08000000")]
        public const int WINHTTP_QUERY_FLAG_NUMBER64 = 0x08000000;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_TRAILERS 0x02000000")]
        public const int WINHTTP_QUERY_FLAG_TRAILERS = 0x02000000;

        [NativeTypeName("#define WINHTTP_QUERY_FLAG_WIRE_ENCODING 0x01000000")]
        public const int WINHTTP_QUERY_FLAG_WIRE_ENCODING = 0x01000000;

        [NativeTypeName("#define HTTP_STATUS_CONTINUE 100")]
        public const int HTTP_STATUS_CONTINUE = 100;

        [NativeTypeName("#define HTTP_STATUS_SWITCH_PROTOCOLS 101")]
        public const int HTTP_STATUS_SWITCH_PROTOCOLS = 101;

        [NativeTypeName("#define HTTP_STATUS_OK 200")]
        public const int HTTP_STATUS_OK = 200;

        [NativeTypeName("#define HTTP_STATUS_CREATED 201")]
        public const int HTTP_STATUS_CREATED = 201;

        [NativeTypeName("#define HTTP_STATUS_ACCEPTED 202")]
        public const int HTTP_STATUS_ACCEPTED = 202;

        [NativeTypeName("#define HTTP_STATUS_PARTIAL 203")]
        public const int HTTP_STATUS_PARTIAL = 203;

        [NativeTypeName("#define HTTP_STATUS_NO_CONTENT 204")]
        public const int HTTP_STATUS_NO_CONTENT = 204;

        [NativeTypeName("#define HTTP_STATUS_RESET_CONTENT 205")]
        public const int HTTP_STATUS_RESET_CONTENT = 205;

        [NativeTypeName("#define HTTP_STATUS_PARTIAL_CONTENT 206")]
        public const int HTTP_STATUS_PARTIAL_CONTENT = 206;

        [NativeTypeName("#define HTTP_STATUS_WEBDAV_MULTI_STATUS 207")]
        public const int HTTP_STATUS_WEBDAV_MULTI_STATUS = 207;

        [NativeTypeName("#define HTTP_STATUS_AMBIGUOUS 300")]
        public const int HTTP_STATUS_AMBIGUOUS = 300;

        [NativeTypeName("#define HTTP_STATUS_MOVED 301")]
        public const int HTTP_STATUS_MOVED = 301;

        [NativeTypeName("#define HTTP_STATUS_REDIRECT 302")]
        public const int HTTP_STATUS_REDIRECT = 302;

        [NativeTypeName("#define HTTP_STATUS_REDIRECT_METHOD 303")]
        public const int HTTP_STATUS_REDIRECT_METHOD = 303;

        [NativeTypeName("#define HTTP_STATUS_NOT_MODIFIED 304")]
        public const int HTTP_STATUS_NOT_MODIFIED = 304;

        [NativeTypeName("#define HTTP_STATUS_USE_PROXY 305")]
        public const int HTTP_STATUS_USE_PROXY = 305;

        [NativeTypeName("#define HTTP_STATUS_REDIRECT_KEEP_VERB 307")]
        public const int HTTP_STATUS_REDIRECT_KEEP_VERB = 307;

        [NativeTypeName("#define HTTP_STATUS_PERMANENT_REDIRECT 308")]
        public const int HTTP_STATUS_PERMANENT_REDIRECT = 308;

        [NativeTypeName("#define HTTP_STATUS_BAD_REQUEST 400")]
        public const int HTTP_STATUS_BAD_REQUEST = 400;

        [NativeTypeName("#define HTTP_STATUS_DENIED 401")]
        public const int HTTP_STATUS_DENIED = 401;

        [NativeTypeName("#define HTTP_STATUS_PAYMENT_REQ 402")]
        public const int HTTP_STATUS_PAYMENT_REQ = 402;

        [NativeTypeName("#define HTTP_STATUS_FORBIDDEN 403")]
        public const int HTTP_STATUS_FORBIDDEN = 403;

        [NativeTypeName("#define HTTP_STATUS_NOT_FOUND 404")]
        public const int HTTP_STATUS_NOT_FOUND = 404;

        [NativeTypeName("#define HTTP_STATUS_BAD_METHOD 405")]
        public const int HTTP_STATUS_BAD_METHOD = 405;

        [NativeTypeName("#define HTTP_STATUS_NONE_ACCEPTABLE 406")]
        public const int HTTP_STATUS_NONE_ACCEPTABLE = 406;

        [NativeTypeName("#define HTTP_STATUS_PROXY_AUTH_REQ 407")]
        public const int HTTP_STATUS_PROXY_AUTH_REQ = 407;

        [NativeTypeName("#define HTTP_STATUS_REQUEST_TIMEOUT 408")]
        public const int HTTP_STATUS_REQUEST_TIMEOUT = 408;

        [NativeTypeName("#define HTTP_STATUS_CONFLICT 409")]
        public const int HTTP_STATUS_CONFLICT = 409;

        [NativeTypeName("#define HTTP_STATUS_GONE 410")]
        public const int HTTP_STATUS_GONE = 410;

        [NativeTypeName("#define HTTP_STATUS_LENGTH_REQUIRED 411")]
        public const int HTTP_STATUS_LENGTH_REQUIRED = 411;

        [NativeTypeName("#define HTTP_STATUS_PRECOND_FAILED 412")]
        public const int HTTP_STATUS_PRECOND_FAILED = 412;

        [NativeTypeName("#define HTTP_STATUS_REQUEST_TOO_LARGE 413")]
        public const int HTTP_STATUS_REQUEST_TOO_LARGE = 413;

        [NativeTypeName("#define HTTP_STATUS_URI_TOO_LONG 414")]
        public const int HTTP_STATUS_URI_TOO_LONG = 414;

        [NativeTypeName("#define HTTP_STATUS_UNSUPPORTED_MEDIA 415")]
        public const int HTTP_STATUS_UNSUPPORTED_MEDIA = 415;

        [NativeTypeName("#define HTTP_STATUS_RETRY_WITH 449")]
        public const int HTTP_STATUS_RETRY_WITH = 449;

        [NativeTypeName("#define HTTP_STATUS_SERVER_ERROR 500")]
        public const int HTTP_STATUS_SERVER_ERROR = 500;

        [NativeTypeName("#define HTTP_STATUS_NOT_SUPPORTED 501")]
        public const int HTTP_STATUS_NOT_SUPPORTED = 501;

        [NativeTypeName("#define HTTP_STATUS_BAD_GATEWAY 502")]
        public const int HTTP_STATUS_BAD_GATEWAY = 502;

        [NativeTypeName("#define HTTP_STATUS_SERVICE_UNAVAIL 503")]
        public const int HTTP_STATUS_SERVICE_UNAVAIL = 503;

        [NativeTypeName("#define HTTP_STATUS_GATEWAY_TIMEOUT 504")]
        public const int HTTP_STATUS_GATEWAY_TIMEOUT = 504;

        [NativeTypeName("#define HTTP_STATUS_VERSION_NOT_SUP 505")]
        public const int HTTP_STATUS_VERSION_NOT_SUP = 505;

        [NativeTypeName("#define HTTP_STATUS_FIRST HTTP_STATUS_CONTINUE")]
        public const int HTTP_STATUS_FIRST = 100;

        [NativeTypeName("#define HTTP_STATUS_LAST HTTP_STATUS_VERSION_NOT_SUP")]
        public const int HTTP_STATUS_LAST = 505;

        [NativeTypeName("#define ICU_NO_ENCODE 0x20000000")]
        public const int ICU_NO_ENCODE = 0x20000000;

        [NativeTypeName("#define ICU_DECODE 0x10000000")]
        public const int ICU_DECODE = 0x10000000;

        [NativeTypeName("#define ICU_NO_META 0x08000000")]
        public const int ICU_NO_META = 0x08000000;

        [NativeTypeName("#define ICU_ENCODE_SPACES_ONLY 0x04000000")]
        public const int ICU_ENCODE_SPACES_ONLY = 0x04000000;

        [NativeTypeName("#define ICU_BROWSER_MODE 0x02000000")]
        public const int ICU_BROWSER_MODE = 0x02000000;

        [NativeTypeName("#define ICU_ENCODE_PERCENT 0x00001000")]
        public const int ICU_ENCODE_PERCENT = 0x00001000;

        [NativeTypeName("#define ICU_ESCAPE 0x80000000")]
        public const uint ICU_ESCAPE = 0x80000000;

        [NativeTypeName("#define ICU_ESCAPE_AUTHORITY 0x00002000")]
        public const int ICU_ESCAPE_AUTHORITY = 0x00002000;

        [NativeTypeName("#define ICU_REJECT_USERPWD 0x00004000")]
        public const int ICU_REJECT_USERPWD = 0x00004000;

        [NativeTypeName("#define WINHTTP_ACCESS_TYPE_DEFAULT_PROXY 0")]
        public const int WINHTTP_ACCESS_TYPE_DEFAULT_PROXY = 0;

        [NativeTypeName("#define WINHTTP_ACCESS_TYPE_NO_PROXY 1")]
        public const int WINHTTP_ACCESS_TYPE_NO_PROXY = 1;

        [NativeTypeName("#define WINHTTP_ACCESS_TYPE_NAMED_PROXY 3")]
        public const int WINHTTP_ACCESS_TYPE_NAMED_PROXY = 3;

        [NativeTypeName("#define WINHTTP_ACCESS_TYPE_AUTOMATIC_PROXY 4")]
        public const int WINHTTP_ACCESS_TYPE_AUTOMATIC_PROXY = 4;

        [NativeTypeName("#define WINHTTP_NO_PROXY_NAME NULL")]
        public const int WINHTTP_NO_PROXY_NAME = 0;

        [NativeTypeName("#define WINHTTP_NO_PROXY_BYPASS NULL")]
        public const int WINHTTP_NO_PROXY_BYPASS = 0;

        [NativeTypeName("#define WINHTTP_NO_CLIENT_CERT_CONTEXT NULL")]
        public const int WINHTTP_NO_CLIENT_CERT_CONTEXT = 0;

        [NativeTypeName("#define WINHTTP_NO_REFERER NULL")]
        public const int WINHTTP_NO_REFERER = 0;

        [NativeTypeName("#define WINHTTP_DEFAULT_ACCEPT_TYPES NULL")]
        public const int WINHTTP_DEFAULT_ACCEPT_TYPES = 0;

        [NativeTypeName("#define WINHTTP_ADDREQ_INDEX_MASK 0x0000FFFF")]
        public const int WINHTTP_ADDREQ_INDEX_MASK = 0x0000FFFF;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAGS_MASK 0xFFFF0000")]
        public const uint WINHTTP_ADDREQ_FLAGS_MASK = 0xFFFF0000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_ADD_IF_NEW 0x10000000")]
        public const int WINHTTP_ADDREQ_FLAG_ADD_IF_NEW = 0x10000000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_ADD 0x20000000")]
        public const int WINHTTP_ADDREQ_FLAG_ADD = 0x20000000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA 0x40000000")]
        public const int WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA = 0x40000000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE_WITH_SEMICOLON 0x01000000")]
        public const int WINHTTP_ADDREQ_FLAG_COALESCE_WITH_SEMICOLON = 0x01000000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_COALESCE WINHTTP_ADDREQ_FLAG_COALESCE_WITH_COMMA")]
        public const int WINHTTP_ADDREQ_FLAG_COALESCE = 0x40000000;

        [NativeTypeName("#define WINHTTP_ADDREQ_FLAG_REPLACE 0x80000000")]
        public const uint WINHTTP_ADDREQ_FLAG_REPLACE = 0x80000000;

        [NativeTypeName("#define WINHTTP_EXTENDED_HEADER_FLAG_UNICODE 0x00000001")]
        public const int WINHTTP_EXTENDED_HEADER_FLAG_UNICODE = 0x00000001;

        [NativeTypeName("#define WINHTTP_READ_DATA_EX_FLAG_FILL_BUFFER 0x0000000000000001ull")]
        public const ulong WINHTTP_READ_DATA_EX_FLAG_FILL_BUFFER = 0x0000000000000001UL;

        [NativeTypeName("#define WINHTTP_IGNORE_REQUEST_TOTAL_LENGTH 0")]
        public const int WINHTTP_IGNORE_REQUEST_TOTAL_LENGTH = 0;

        [NativeTypeName("#define WINHTTP_NO_ADDITIONAL_HEADERS NULL")]
        public const int WINHTTP_NO_ADDITIONAL_HEADERS = 0;

        [NativeTypeName("#define WINHTTP_NO_REQUEST_DATA NULL")]
        public const int WINHTTP_NO_REQUEST_DATA = 0;

        [NativeTypeName("#define WINHTTP_HEADER_NAME_BY_INDEX NULL")]
        public const int WINHTTP_HEADER_NAME_BY_INDEX = 0;

        [NativeTypeName("#define WINHTTP_NO_OUTPUT_BUFFER NULL")]
        public const int WINHTTP_NO_OUTPUT_BUFFER = 0;

        [NativeTypeName("#define WINHTTP_NO_HEADER_INDEX NULL")]
        public const int WINHTTP_NO_HEADER_INDEX = 0;

        [NativeTypeName("#define WINHTTP_ERROR_BASE 12000")]
        public const int WINHTTP_ERROR_BASE = 12000;

        [NativeTypeName("#define ERROR_WINHTTP_OUT_OF_HANDLES (WINHTTP_ERROR_BASE + 1)")]
        public const int ERROR_WINHTTP_OUT_OF_HANDLES = (12000 + 1);

        [NativeTypeName("#define ERROR_WINHTTP_TIMEOUT (WINHTTP_ERROR_BASE + 2)")]
        public const int ERROR_WINHTTP_TIMEOUT = (12000 + 2);

        [NativeTypeName("#define ERROR_WINHTTP_INTERNAL_ERROR (WINHTTP_ERROR_BASE + 4)")]
        public const int ERROR_WINHTTP_INTERNAL_ERROR = (12000 + 4);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_URL (WINHTTP_ERROR_BASE + 5)")]
        public const int ERROR_WINHTTP_INVALID_URL = (12000 + 5);

        [NativeTypeName("#define ERROR_WINHTTP_UNRECOGNIZED_SCHEME (WINHTTP_ERROR_BASE + 6)")]
        public const int ERROR_WINHTTP_UNRECOGNIZED_SCHEME = (12000 + 6);

        [NativeTypeName("#define ERROR_WINHTTP_NAME_NOT_RESOLVED (WINHTTP_ERROR_BASE + 7)")]
        public const int ERROR_WINHTTP_NAME_NOT_RESOLVED = (12000 + 7);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_OPTION (WINHTTP_ERROR_BASE + 9)")]
        public const int ERROR_WINHTTP_INVALID_OPTION = (12000 + 9);

        [NativeTypeName("#define ERROR_WINHTTP_OPTION_NOT_SETTABLE (WINHTTP_ERROR_BASE + 11)")]
        public const int ERROR_WINHTTP_OPTION_NOT_SETTABLE = (12000 + 11);

        [NativeTypeName("#define ERROR_WINHTTP_SHUTDOWN (WINHTTP_ERROR_BASE + 12)")]
        public const int ERROR_WINHTTP_SHUTDOWN = (12000 + 12);

        [NativeTypeName("#define ERROR_WINHTTP_LOGIN_FAILURE (WINHTTP_ERROR_BASE + 15)")]
        public const int ERROR_WINHTTP_LOGIN_FAILURE = (12000 + 15);

        [NativeTypeName("#define ERROR_WINHTTP_OPERATION_CANCELLED (WINHTTP_ERROR_BASE + 17)")]
        public const int ERROR_WINHTTP_OPERATION_CANCELLED = (12000 + 17);

        [NativeTypeName("#define ERROR_WINHTTP_INCORRECT_HANDLE_TYPE (WINHTTP_ERROR_BASE + 18)")]
        public const int ERROR_WINHTTP_INCORRECT_HANDLE_TYPE = (12000 + 18);

        [NativeTypeName("#define ERROR_WINHTTP_INCORRECT_HANDLE_STATE (WINHTTP_ERROR_BASE + 19)")]
        public const int ERROR_WINHTTP_INCORRECT_HANDLE_STATE = (12000 + 19);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CONNECT (WINHTTP_ERROR_BASE + 29)")]
        public const int ERROR_WINHTTP_CANNOT_CONNECT = (12000 + 29);

        [NativeTypeName("#define ERROR_WINHTTP_CONNECTION_ERROR (WINHTTP_ERROR_BASE + 30)")]
        public const int ERROR_WINHTTP_CONNECTION_ERROR = (12000 + 30);

        [NativeTypeName("#define ERROR_WINHTTP_RESEND_REQUEST (WINHTTP_ERROR_BASE + 32)")]
        public const int ERROR_WINHTTP_RESEND_REQUEST = (12000 + 32);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED (WINHTTP_ERROR_BASE + 44)")]
        public const int ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED = (12000 + 44);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_BEFORE_OPEN (WINHTTP_ERROR_BASE + 100)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_BEFORE_OPEN = (12000 + 100);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_BEFORE_SEND (WINHTTP_ERROR_BASE + 101)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_BEFORE_SEND = (12000 + 101);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_AFTER_SEND (WINHTTP_ERROR_BASE + 102)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_AFTER_SEND = (12000 + 102);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_AFTER_OPEN (WINHTTP_ERROR_BASE + 103)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_AFTER_OPEN = (12000 + 103);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_NOT_FOUND (WINHTTP_ERROR_BASE + 150)")]
        public const int ERROR_WINHTTP_HEADER_NOT_FOUND = (12000 + 150);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_SERVER_RESPONSE (WINHTTP_ERROR_BASE + 152)")]
        public const int ERROR_WINHTTP_INVALID_SERVER_RESPONSE = (12000 + 152);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_HEADER (WINHTTP_ERROR_BASE + 153)")]
        public const int ERROR_WINHTTP_INVALID_HEADER = (12000 + 153);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_QUERY_REQUEST (WINHTTP_ERROR_BASE + 154)")]
        public const int ERROR_WINHTTP_INVALID_QUERY_REQUEST = (12000 + 154);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_ALREADY_EXISTS (WINHTTP_ERROR_BASE + 155)")]
        public const int ERROR_WINHTTP_HEADER_ALREADY_EXISTS = (12000 + 155);

        [NativeTypeName("#define ERROR_WINHTTP_REDIRECT_FAILED (WINHTTP_ERROR_BASE + 156)")]
        public const int ERROR_WINHTTP_REDIRECT_FAILED = (12000 + 156);

        [NativeTypeName("#define ERROR_WINHTTP_AUTO_PROXY_SERVICE_ERROR (WINHTTP_ERROR_BASE + 178)")]
        public const int ERROR_WINHTTP_AUTO_PROXY_SERVICE_ERROR = (12000 + 178);

        [NativeTypeName("#define ERROR_WINHTTP_BAD_AUTO_PROXY_SCRIPT (WINHTTP_ERROR_BASE + 166)")]
        public const int ERROR_WINHTTP_BAD_AUTO_PROXY_SCRIPT = (12000 + 166);

        [NativeTypeName("#define ERROR_WINHTTP_UNABLE_TO_DOWNLOAD_SCRIPT (WINHTTP_ERROR_BASE + 167)")]
        public const int ERROR_WINHTTP_UNABLE_TO_DOWNLOAD_SCRIPT = (12000 + 167);

        [NativeTypeName("#define ERROR_WINHTTP_UNHANDLED_SCRIPT_TYPE (WINHTTP_ERROR_BASE + 176)")]
        public const int ERROR_WINHTTP_UNHANDLED_SCRIPT_TYPE = (12000 + 176);

        [NativeTypeName("#define ERROR_WINHTTP_SCRIPT_EXECUTION_ERROR (WINHTTP_ERROR_BASE + 177)")]
        public const int ERROR_WINHTTP_SCRIPT_EXECUTION_ERROR = (12000 + 177);

        [NativeTypeName("#define ERROR_WINHTTP_NOT_INITIALIZED (WINHTTP_ERROR_BASE + 172)")]
        public const int ERROR_WINHTTP_NOT_INITIALIZED = (12000 + 172);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_FAILURE (WINHTTP_ERROR_BASE + 175)")]
        public const int ERROR_WINHTTP_SECURE_FAILURE = (12000 + 175);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_DATE_INVALID (WINHTTP_ERROR_BASE + 37)")]
        public const int ERROR_WINHTTP_SECURE_CERT_DATE_INVALID = (12000 + 37);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_CN_INVALID (WINHTTP_ERROR_BASE + 38)")]
        public const int ERROR_WINHTTP_SECURE_CERT_CN_INVALID = (12000 + 38);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_INVALID_CA (WINHTTP_ERROR_BASE + 45)")]
        public const int ERROR_WINHTTP_SECURE_INVALID_CA = (12000 + 45);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_REV_FAILED (WINHTTP_ERROR_BASE + 57)")]
        public const int ERROR_WINHTTP_SECURE_CERT_REV_FAILED = (12000 + 57);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CHANNEL_ERROR (WINHTTP_ERROR_BASE + 157)")]
        public const int ERROR_WINHTTP_SECURE_CHANNEL_ERROR = (12000 + 157);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_INVALID_CERT (WINHTTP_ERROR_BASE + 169)")]
        public const int ERROR_WINHTTP_SECURE_INVALID_CERT = (12000 + 169);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_REVOKED (WINHTTP_ERROR_BASE + 170)")]
        public const int ERROR_WINHTTP_SECURE_CERT_REVOKED = (12000 + 170);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_WRONG_USAGE (WINHTTP_ERROR_BASE + 179)")]
        public const int ERROR_WINHTTP_SECURE_CERT_WRONG_USAGE = (12000 + 179);

        [NativeTypeName("#define ERROR_WINHTTP_AUTODETECTION_FAILED (WINHTTP_ERROR_BASE + 180)")]
        public const int ERROR_WINHTTP_AUTODETECTION_FAILED = (12000 + 180);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_COUNT_EXCEEDED (WINHTTP_ERROR_BASE + 181)")]
        public const int ERROR_WINHTTP_HEADER_COUNT_EXCEEDED = (12000 + 181);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_SIZE_OVERFLOW (WINHTTP_ERROR_BASE + 182)")]
        public const int ERROR_WINHTTP_HEADER_SIZE_OVERFLOW = (12000 + 182);

        [NativeTypeName("#define ERROR_WINHTTP_CHUNKED_ENCODING_HEADER_SIZE_OVERFLOW (WINHTTP_ERROR_BASE + 183)")]
        public const int ERROR_WINHTTP_CHUNKED_ENCODING_HEADER_SIZE_OVERFLOW = (12000 + 183);

        [NativeTypeName("#define ERROR_WINHTTP_RESPONSE_DRAIN_OVERFLOW (WINHTTP_ERROR_BASE + 184)")]
        public const int ERROR_WINHTTP_RESPONSE_DRAIN_OVERFLOW = (12000 + 184);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_CERT_NO_PRIVATE_KEY (WINHTTP_ERROR_BASE + 185)")]
        public const int ERROR_WINHTTP_CLIENT_CERT_NO_PRIVATE_KEY = (12000 + 185);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_CERT_NO_ACCESS_PRIVATE_KEY (WINHTTP_ERROR_BASE + 186)")]
        public const int ERROR_WINHTTP_CLIENT_CERT_NO_ACCESS_PRIVATE_KEY = (12000 + 186);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED_PROXY (WINHTTP_ERROR_BASE + 187)")]
        public const int ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED_PROXY = (12000 + 187);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_FAILURE_PROXY (WINHTTP_ERROR_BASE + 188)")]
        public const int ERROR_WINHTTP_SECURE_FAILURE_PROXY = (12000 + 188);

        [NativeTypeName("#define ERROR_WINHTTP_RESERVED_189 (WINHTTP_ERROR_BASE + 189)")]
        public const int ERROR_WINHTTP_RESERVED_189 = (12000 + 189);

        [NativeTypeName("#define ERROR_WINHTTP_HTTP_PROTOCOL_MISMATCH (WINHTTP_ERROR_BASE + 190)")]
        public const int ERROR_WINHTTP_HTTP_PROTOCOL_MISMATCH = (12000 + 190);

        [NativeTypeName("#define ERROR_WINHTTP_GLOBAL_CALLBACK_FAILED (WINHTTP_ERROR_BASE + 191)")]
        public const int ERROR_WINHTTP_GLOBAL_CALLBACK_FAILED = (12000 + 191);

        [NativeTypeName("#define ERROR_WINHTTP_FEATURE_DISABLED (WINHTTP_ERROR_BASE + 192)")]
        public const int ERROR_WINHTTP_FEATURE_DISABLED = (12000 + 192);

        [NativeTypeName("#define WINHTTP_ERROR_LAST ERROR_WINHTTP_FEATURE_DISABLED")]
        public const int WINHTTP_ERROR_LAST = (12000 + 192);

        [NativeTypeName("#define WINHTTP_RESET_STATE 0x00000001")]
        public const int WINHTTP_RESET_STATE = 0x00000001;

        [NativeTypeName("#define WINHTTP_RESET_SWPAD_CURRENT_NETWORK 0x00000002")]
        public const int WINHTTP_RESET_SWPAD_CURRENT_NETWORK = 0x00000002;

        [NativeTypeName("#define WINHTTP_RESET_SWPAD_ALL 0x00000004")]
        public const int WINHTTP_RESET_SWPAD_ALL = 0x00000004;

        [NativeTypeName("#define WINHTTP_RESET_SCRIPT_CACHE 0x00000008")]
        public const int WINHTTP_RESET_SCRIPT_CACHE = 0x00000008;

        [NativeTypeName("#define WINHTTP_RESET_ALL 0x0000FFFF")]
        public const int WINHTTP_RESET_ALL = 0x0000FFFF;

        [NativeTypeName("#define WINHTTP_RESET_NOTIFY_NETWORK_CHANGED 0x00010000")]
        public const int WINHTTP_RESET_NOTIFY_NETWORK_CHANGED = 0x00010000;

        [NativeTypeName("#define WINHTTP_RESET_OUT_OF_PROC 0x00020000")]
        public const int WINHTTP_RESET_OUT_OF_PROC = 0x00020000;

        [NativeTypeName("#define WINHTTP_RESET_DISCARD_RESOLVERS 0x00040000")]
        public const int WINHTTP_RESET_DISCARD_RESOLVERS = 0x00040000;

        [NativeTypeName("#define WINHTTP_WEB_SOCKET_MAX_CLOSE_REASON_LENGTH 123")]
        public const int WINHTTP_WEB_SOCKET_MAX_CLOSE_REASON_LENGTH = 123;

        [NativeTypeName("#define WINHTTP_WEB_SOCKET_MIN_KEEPALIVE_VALUE 15000")]
        public const int WINHTTP_WEB_SOCKET_MIN_KEEPALIVE_VALUE = 15000;
    }
}
