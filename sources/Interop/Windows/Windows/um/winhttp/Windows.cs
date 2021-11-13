// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
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

        [NativeTypeName("#define INTERNET_SCHEME_HTTP (1)")]
        public const int INTERNET_SCHEME_HTTP = (1);

        [NativeTypeName("#define INTERNET_SCHEME_HTTPS (2)")]
        public const int INTERNET_SCHEME_HTTPS = (2);

        [NativeTypeName("#define INTERNET_SCHEME_FTP (3)")]
        public const int INTERNET_SCHEME_FTP = (3);

        [NativeTypeName("#define INTERNET_SCHEME_SOCKS (4)")]
        public const int INTERNET_SCHEME_SOCKS = (4);

        [NativeTypeName("#define NETWORKING_KEY_BUFSIZE 128")]
        public const int NETWORKING_KEY_BUFSIZE = 128;

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
    }
}
