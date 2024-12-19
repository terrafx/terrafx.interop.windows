// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpInitialize"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpInitialize(HTTPAPI_VERSION Version, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PVOID")] void* pReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpTerminate"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpTerminate([NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PVOID")] void* pReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCreateHttpHandle"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateHttpHandle([NativeTypeName("PHANDLE")] HANDLE* RequestQueueHandle, [NativeTypeName("ULONG")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCreateRequestQueue"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateRequestQueue(HTTPAPI_VERSION Version, [NativeTypeName("PCWSTR")] char* Name, [NativeTypeName("PSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHANDLE")] HANDLE* RequestQueueHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCloseRequestQueue"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseRequestQueue(HANDLE RequestQueueHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSetRequestQueueProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetRequestQueueProperty(HANDLE RequestQueueHandle, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength, [NativeTypeName("ULONG")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpQueryRequestQueueProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryRequestQueueProperty(HANDLE RequestQueueHandle, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength, [NativeTypeName("ULONG")] uint Reserved1, [NativeTypeName("PULONG")] uint* ReturnLength, [NativeTypeName("PVOID")] void* Reserved2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSetRequestProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetRequestProperty(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_OPAQUE_ID")] ulong Id, HTTP_REQUEST_PROPERTY PropertyId, [NativeTypeName("PVOID")] void* Input, [NativeTypeName("ULONG")] uint InputPropertySize, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpShutdownRequestQueue"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpShutdownRequestQueue(HANDLE RequestQueueHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpReceiveClientCertificate"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveClientCertificate(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHTTP_SSL_CLIENT_CERT_INFO")] HTTP_SSL_CLIENT_CERT_INFO* SslClientCertInfo, [NativeTypeName("ULONG")] uint SslClientCertInfoSize, [NativeTypeName("PULONG")] uint* BytesReceived, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCreateServerSession"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateServerSession(HTTPAPI_VERSION Version, [NativeTypeName("PHTTP_SERVER_SESSION_ID")] ulong* ServerSessionId, [NativeTypeName("ULONG")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCloseServerSession"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseServerSession([NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpQueryServerSessionProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryServerSessionProperty([NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSetServerSessionProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetServerSessionProperty([NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpAddUrl"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddUrl(HANDLE RequestQueueHandle, [NativeTypeName("PCWSTR")] char* FullyQualifiedUrl, [NativeTypeName("PVOID")] void* Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpRemoveUrl"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpRemoveUrl(HANDLE RequestQueueHandle, [NativeTypeName("PCWSTR")] char* FullyQualifiedUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCreateUrlGroup"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateUrlGroup([NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId, [NativeTypeName("PHTTP_URL_GROUP_ID")] ulong* pUrlGroupId, [NativeTypeName("ULONG")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCloseUrlGroup"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseUrlGroup([NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpAddUrlToUrlGroup"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddUrlToUrlGroup([NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId, [NativeTypeName("PCWSTR")] char* pFullyQualifiedUrl, [NativeTypeName("HTTP_URL_CONTEXT")] ulong UrlContext, [NativeTypeName("ULONG")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpRemoveUrlFromUrlGroup"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpRemoveUrlFromUrlGroup([NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId, [NativeTypeName("PCWSTR")] char* pFullyQualifiedUrl, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSetUrlGroupProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetUrlGroupProperty([NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpQueryUrlGroupProperty"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryUrlGroupProperty([NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId, HTTP_SERVER_PROPERTY Property, [NativeTypeName("PVOID")] void* PropertyInformation, [NativeTypeName("ULONG")] uint PropertyInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpPrepareUrl"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint HttpPrepareUrl([NativeTypeName("PVOID")] void* Reserved, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PCWSTR")] char* Url, [NativeTypeName("PWSTR *")] char** PreparedUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpReceiveHttpRequest"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveHttpRequest(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHTTP_REQUEST")] HTTP_REQUEST_V2* RequestBuffer, [NativeTypeName("ULONG")] uint RequestBufferLength, [NativeTypeName("PULONG")] uint* BytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpReceiveRequestEntityBody"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveRequestEntityBody(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PVOID")] void* EntityBuffer, [NativeTypeName("ULONG")] uint EntityBufferLength, [NativeTypeName("PULONG")] uint* BytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSendHttpResponse"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSendHttpResponse(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHTTP_RESPONSE")] HTTP_RESPONSE_V2* HttpResponse, [NativeTypeName("PHTTP_CACHE_POLICY")] HTTP_CACHE_POLICY* CachePolicy, [NativeTypeName("PULONG")] uint* BytesSent, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("ULONG")] uint Reserved2, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped, [NativeTypeName("PHTTP_LOG_DATA")] HTTP_LOG_DATA* LogData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSendResponseEntityBody"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSendResponseEntityBody(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("ULONG")] uint Flags, ushort EntityChunkCount, [NativeTypeName("PHTTP_DATA_CHUNK")] HTTP_DATA_CHUNK* EntityChunks, [NativeTypeName("PULONG")] uint* BytesSent, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("ULONG")] uint Reserved2, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped, [NativeTypeName("PHTTP_LOG_DATA")] HTTP_LOG_DATA* LogData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpDeclarePush"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint HttpDeclarePush(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, HTTP_VERB Verb, [NativeTypeName("PCWSTR")] char* Path, [NativeTypeName("PCSTR")] sbyte* Query, [NativeTypeName("PHTTP_REQUEST_HEADERS")] HTTP_REQUEST_HEADERS* Headers);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpWaitForDisconnect"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDisconnect(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpWaitForDisconnectEx"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDisconnectEx(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId, [NativeTypeName("ULONG")] uint Reserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpCancelHttpRequest"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCancelHttpRequest(HANDLE RequestQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpWaitForDemandStart"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDemandStart(HANDLE RequestQueueHandle, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpIsFeatureSupported"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL HttpIsFeatureSupported(HTTP_FEATURE_ID FeatureId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpDelegateRequestEx"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint HttpDelegateRequestEx(HANDLE RequestQueueHandle, HANDLE DelegateQueueHandle, [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId, [NativeTypeName("HTTP_URL_GROUP_ID")] ulong DelegateUrlGroupId, [NativeTypeName("ULONG")] uint PropertyInfoSetSize, [NativeTypeName("PHTTP_DELEGATE_REQUEST_PROPERTY_INFO")] HTTP_DELEGATE_REQUEST_PROPERTY_INFO* PropertyInfoSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpFindUrlGroupId"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint HttpFindUrlGroupId([NativeTypeName("PCWSTR")] char* FullyQualifiedUrl, HANDLE RequestQueueHandle, [NativeTypeName("PHTTP_URL_GROUP_ID")] ulong* UrlGroupId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpFlushResponseCache"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpFlushResponseCache(HANDLE RequestQueueHandle, [NativeTypeName("PCWSTR")] char* UrlPrefix, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpAddFragmentToCache"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddFragmentToCache(HANDLE RequestQueueHandle, [NativeTypeName("PCWSTR")] char* UrlPrefix, [NativeTypeName("PHTTP_DATA_CHUNK")] HTTP_DATA_CHUNK* DataChunk, [NativeTypeName("PHTTP_CACHE_POLICY")] HTTP_CACHE_POLICY* CachePolicy, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpReadFragmentFromCache"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReadFragmentFromCache(HANDLE RequestQueueHandle, [NativeTypeName("PCWSTR")] char* UrlPrefix, [NativeTypeName("PHTTP_BYTE_RANGE")] HTTP_BYTE_RANGE* ByteRange, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength, [NativeTypeName("PULONG")] uint* BytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpSetServiceConfiguration"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetServiceConfiguration(HANDLE ServiceHandle, HTTP_SERVICE_CONFIG_ID ConfigId, [NativeTypeName("PVOID")] void* pConfigInformation, [NativeTypeName("ULONG")] uint ConfigInformationLength, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpUpdateServiceConfiguration"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern uint HttpUpdateServiceConfiguration(HANDLE Handle, HTTP_SERVICE_CONFIG_ID ConfigId, [NativeTypeName("PVOID")] void* ConfigInfo, [NativeTypeName("ULONG")] uint ConfigInfoLength, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpDeleteServiceConfiguration"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpDeleteServiceConfiguration(HANDLE ServiceHandle, HTTP_SERVICE_CONFIG_ID ConfigId, [NativeTypeName("PVOID")] void* pConfigInformation, [NativeTypeName("ULONG")] uint ConfigInformationLength, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpQueryServiceConfiguration"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryServiceConfiguration(HANDLE ServiceHandle, HTTP_SERVICE_CONFIG_ID ConfigId, [NativeTypeName("PVOID")] void* pInput, [NativeTypeName("ULONG")] uint InputLength, [NativeTypeName("PVOID")] void* pOutput, [NativeTypeName("ULONG")] uint OutputLength, [NativeTypeName("PULONG")] uint* pReturnLength, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HttpGetExtension"]/*' />
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpGetExtension(HTTPAPI_VERSION Version, [NativeTypeName("ULONG")] uint Extension, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferSize);
}
