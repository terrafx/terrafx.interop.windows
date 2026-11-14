// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.BINDF;
using static TerraFX.Interop.Windows.PARSEACTION;
using static TerraFX.Interop.Windows.PI_FLAGS;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMonikerEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetClassURL([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAsyncBindCtx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEFetc, IBindCtx** ppBC);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMonikerEx2"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAsyncBindCtxEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateAsyncBindCtxEx(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEnum, IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MkParseDisplayNameEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT MkParseDisplayNameEx(IBindCtx* pbc, [NativeTypeName("LPCWSTR")] char* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterBindStatusCallback"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb, IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeBindStatusCallback"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassFileOrMime"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] char* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetClassObjectFromURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] char* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] char* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEInstallScope"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FaultInIEFeature"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FaultInIEFeature(HWND hWnd, uCLSSPEC* pClassSpec, QUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetComponentIDFromCLSSPEC"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetComponentIDFromCLSSPEC(uCLSSPEC* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsAsyncMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IsAsyncMoniker(IMoniker* pmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterMediaTypes"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterMediaTypes(uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMediaType"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateFormatEnumerator(uint cfmtetc, FORMATETC* rgfmtetc, IEnumFORMATETC** ppenumfmtetc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterMediaTypeClass"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMediaTypeClass"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlMkSetSessionOption"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlMkGetSessionOption"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMimeFromData"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] char* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] char** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObtainUserAgentString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompareSecurityIds"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CompareSecurityIds(byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompatFlagsFromClsid"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetAccessForIEAppContainer"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT SetAccessForIEAppContainer(HANDLE hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUri([NativeTypeName("LPCWSTR")] char* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUriWithFragment"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUriWithFragment([NativeTypeName("LPCWSTR")] char* pwzURI, [NativeTypeName("LPCWSTR")] char* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUriFromMultiByteString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppUri);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIUriBuilder"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateIUriBuilder(IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkSimpleNavigateToString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] char* szTarget, [NativeTypeName("LPCWSTR")] char* szLocation, [NativeTypeName("LPCWSTR")] char* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkSimpleNavigateToMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkSimpleNavigateToMoniker(IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] char* szLocation, [NativeTypeName("LPCWSTR")] char* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenPullStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenPullStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToFileA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToFileW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPCWSTR")] char* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToCacheFileA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToCacheFileW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPWSTR")] char* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenBlockingStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenBlockingStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkGoBack"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkGoBack(IUnknown* pUnk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkGoForward"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkGoForward(IUnknown* pUnk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkNavigateString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigateString(IUnknown* pUnk, [NativeTypeName("LPCWSTR")] char* szTarget);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkNavigateMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigateMoniker(IUnknown* pUnk, IMoniker* pmkTarget);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetParseUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] char* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetParseIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetParseIUri(IUri* pIUri, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineUrlEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineUrlEx(IUri* pBaseUri, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineIUri(IUri* pBaseUri, IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCompareUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetProtocolFlags"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetQueryInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetQueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, QUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSession"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSecurityUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPWSTR *")] char** ppwszSecUrl, PSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AsyncInstallDistributionUnit"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("LPCWSTR")] char* szTYPE, [NativeTypeName("LPCWSTR")] char* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] char* szURL, IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSecurityUrlEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSecurityUrlEx(IUri* pUri, IUri** ppSecUri, PSUACTION psuAction, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetSetFeatureEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, BOOL fEnable);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabledForUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] char* szURL, IInternetSecurityManager* pSecMgr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabledForIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabledForIUri(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, IUri* pIUri, IInternetSecurityManagerEx2* pSecMgr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureZoneElevationEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] char* szFromURL, [NativeTypeName("LPCWSTR")] char* szToURL, IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyStgMedium"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CopyStgMedium([NativeTypeName("const STGMEDIUM *")] STGMEDIUM* pcstgmedSrc, STGMEDIUM* pstgmedDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyBindInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CopyBindInfo([NativeTypeName("const BINDINFO *")] BINDINFO* pcbiSrc, BINDINFO* pbiDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseBindInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern void ReleaseBindInfo(BINDINFO* pbindinfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEGetUserPrivateNamespaceName"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* IEGetUserPrivateNamespaceName();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCreateSecurityManager"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCreateSecurityManager(IServiceProvider* pSP, IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCreateZoneManager"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCreateZoneManager(IServiceProvider* pSP, IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSoftwareUpdateInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSoftwareUpdateAdvertisementState"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLoggingEnabledA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLoggingEnabledW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL IsLoggingEnabledW([NativeTypeName("LPCWSTR")] char* pwszUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteHitLogging"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] HIT_LOGGING_INFO* lpLogginginfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BINDF_DONTUSECACHE"]/*' />
    [NativeTypeName("#define BINDF_DONTUSECACHE BINDF_GETNEWESTVERSION")]
    public const BINDF BINDF_DONTUSECACHE = BINDF_GETNEWESTVERSION;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BINDF_DONTPUTINCACHE"]/*' />
    [NativeTypeName("#define BINDF_DONTPUTINCACHE BINDF_NOWRITECACHE")]
    public const BINDF BINDF_DONTPUTINCACHE = BINDF_NOWRITECACHE;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BINDF_NOCOPYDATA"]/*' />
    [NativeTypeName("#define BINDF_NOCOPYDATA BINDF_PULLDATA")]
    public const BINDF BINDF_NOCOPYDATA = BINDF_PULLDATA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INVALID_P_ROOT_SECURITY_ID"]/*' />
    [NativeTypeName("#define INVALID_P_ROOT_SECURITY_ID ((BYTE*)-1)")]
    public static byte* INVALID_P_ROOT_SECURITY_ID => unchecked((byte*)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PI_DOCFILECLSIDLOOKUP"]/*' />
    [NativeTypeName("#define PI_DOCFILECLSIDLOOKUP PI_CLSIDLOOKUP")]
    public const PI_FLAGS PI_DOCFILECLSIDLOOKUP = PI_CLSIDLOOKUP;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MKSYS_URLMONIKER"]/*' />
    [NativeTypeName("#define MKSYS_URLMONIKER 6")]
    public const int MKSYS_URLMONIKER = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIEF_FLAG_FORCE_JITUI"]/*' />
    [NativeTypeName("#define FIEF_FLAG_FORCE_JITUI 0x1")]
    public const int FIEF_FLAG_FORCE_JITUI = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIEF_FLAG_PEEK"]/*' />
    [NativeTypeName("#define FIEF_FLAG_PEEK 0x2")]
    public const int FIEF_FLAG_PEEK = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK"]/*' />
    [NativeTypeName("#define FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK 0x4")]
    public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 0x4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIEF_FLAG_RESERVED_0"]/*' />
    [NativeTypeName("#define FIEF_FLAG_RESERVED_0 0x8")]
    public const int FIEF_FLAG_RESERVED_0 = 0x8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_DEFAULT"]/*' />
    [NativeTypeName("#define FMFD_DEFAULT 0x00000000")]
    public const int FMFD_DEFAULT = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_URLASFILENAME"]/*' />
    [NativeTypeName("#define FMFD_URLASFILENAME 0x00000001")]
    public const int FMFD_URLASFILENAME = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_ENABLEMIMESNIFFING"]/*' />
    [NativeTypeName("#define FMFD_ENABLEMIMESNIFFING 0x00000002")]
    public const int FMFD_ENABLEMIMESNIFFING = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_IGNOREMIMETEXTPLAIN"]/*' />
    [NativeTypeName("#define FMFD_IGNOREMIMETEXTPLAIN 0x00000004")]
    public const int FMFD_IGNOREMIMETEXTPLAIN = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_SERVERMIME"]/*' />
    [NativeTypeName("#define FMFD_SERVERMIME 0x00000008")]
    public const int FMFD_SERVERMIME = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_RESPECTTEXTPLAIN"]/*' />
    [NativeTypeName("#define FMFD_RESPECTTEXTPLAIN 0x00000010")]
    public const int FMFD_RESPECTTEXTPLAIN = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_RETURNUPDATEDIMGMIMES"]/*' />
    [NativeTypeName("#define FMFD_RETURNUPDATEDIMGMIMES 0x00000020")]
    public const int FMFD_RETURNUPDATEDIMGMIMES = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_RESERVED_1"]/*' />
    [NativeTypeName("#define FMFD_RESERVED_1 0x00000040")]
    public const int FMFD_RESERVED_1 = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FMFD_RESERVED_2"]/*' />
    [NativeTypeName("#define FMFD_RESERVED_2 0x00000080")]
    public const int FMFD_RESERVED_2 = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UAS_EXACTLEGACY"]/*' />
    [NativeTypeName("#define UAS_EXACTLEGACY 0x00001000")]
    public const int UAS_EXACTLEGACY = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLMON_OPTION_USERAGENT"]/*' />
    [NativeTypeName("#define URLMON_OPTION_USERAGENT 0x10000001")]
    public const int URLMON_OPTION_USERAGENT = 0x10000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLMON_OPTION_USERAGENT_REFRESH"]/*' />
    [NativeTypeName("#define URLMON_OPTION_USERAGENT_REFRESH 0x10000002")]
    public const int URLMON_OPTION_USERAGENT_REFRESH = 0x10000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLMON_OPTION_URL_ENCODING"]/*' />
    [NativeTypeName("#define URLMON_OPTION_URL_ENCODING 0x10000004")]
    public const int URLMON_OPTION_URL_ENCODING = 0x10000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLMON_OPTION_USE_BINDSTRINGCREDS"]/*' />
    [NativeTypeName("#define URLMON_OPTION_USE_BINDSTRINGCREDS 0x10000008")]
    public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 0x10000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS"]/*' />
    [NativeTypeName("#define URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS 0x10000010")]
    public const int URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS = 0x10000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UriBuilder_USE_ORIGINAL_FLAGS"]/*' />
    [NativeTypeName("#define UriBuilder_USE_ORIGINAL_FLAGS 0x00000001")]
    public const int UriBuilder_USE_ORIGINAL_FLAGS = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WININETINFO_OPTION_LOCK_HANDLE"]/*' />
    [NativeTypeName("#define WININETINFO_OPTION_LOCK_HANDLE 65534")]
    public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOSTRM_USECACHEDCOPY_ONLY"]/*' />
    [NativeTypeName("#define URLOSTRM_USECACHEDCOPY_ONLY 0x1")]
    public const int URLOSTRM_USECACHEDCOPY_ONLY = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOSTRM_USECACHEDCOPY"]/*' />
    [NativeTypeName("#define URLOSTRM_USECACHEDCOPY 0x2")]
    public const int URLOSTRM_USECACHEDCOPY = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOSTRM_GETNEWESTVERSION"]/*' />
    [NativeTypeName("#define URLOSTRM_GETNEWESTVERSION 0x3")]
    public const int URLOSTRM_GETNEWESTVERSION = 0x3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenStream"]/*' />
    [NativeTypeName("#define URLOpenStream URLOpenStreamW")]
    public static delegate*<IUnknown*, char*, uint, IBindStatusCallback*, HRESULT> URLOpenStream => &URLOpenStreamW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenPullStream"]/*' />
    [NativeTypeName("#define URLOpenPullStream URLOpenPullStreamW")]
    public static delegate*<IUnknown*, char*, uint, IBindStatusCallback*, HRESULT> URLOpenPullStream => &URLOpenPullStreamW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToFile"]/*' />
    [NativeTypeName("#define URLDownloadToFile URLDownloadToFileW")]
    public static delegate*<IUnknown*, char*, char*, uint, IBindStatusCallback*, HRESULT> URLDownloadToFile => &URLDownloadToFileW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToCacheFile"]/*' />
    [NativeTypeName("#define URLDownloadToCacheFile URLDownloadToCacheFileW")]
    public static delegate*<IUnknown*, char*, char*, uint, uint, IBindStatusCallback*, HRESULT> URLDownloadToCacheFile => &URLDownloadToCacheFileW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenBlockingStream"]/*' />
    [NativeTypeName("#define URLOpenBlockingStream URLOpenBlockingStreamW")]
    public static delegate*<IUnknown*, char*, IStream**, uint, IBindStatusCallback*, HRESULT> URLOpenBlockingStream => &URLOpenBlockingStreamW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARSE_ENCODE"]/*' />
    [NativeTypeName("#define PARSE_ENCODE PARSE_ENCODE_IS_UNESCAPE")]
    public const PARSEACTION PARSE_ENCODE = PARSE_ENCODE_IS_UNESCAPE;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARSE_DECODE"]/*' />
    [NativeTypeName("#define PARSE_DECODE PARSE_DECODE_IS_ESCAPE")]
    public const PARSEACTION PARSE_DECODE = PARSE_DECODE_IS_ESCAPE;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetParseUrl"]/*' />
    [NativeTypeName("#define OInetParseUrl CoInternetParseUrl")]
    public static delegate*<char*, PARSEACTION, uint, char*, uint, uint*, uint, HRESULT> OInetParseUrl => &CoInternetParseUrl;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetCombineUrl"]/*' />
    [NativeTypeName("#define OInetCombineUrl CoInternetCombineUrl")]
    public static delegate*<char*, char*, uint, char*, uint, uint*, uint, HRESULT> OInetCombineUrl => &CoInternetCombineUrl;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetCombineUrlEx"]/*' />
    [NativeTypeName("#define OInetCombineUrlEx CoInternetCombineUrlEx")]
    public static delegate*<IUri*, char*, uint, IUri**, nuint, HRESULT> OInetCombineUrlEx => &CoInternetCombineUrlEx;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetCombineIUri"]/*' />
    [NativeTypeName("#define OInetCombineIUri CoInternetCombineIUri")]
    public static delegate*<IUri*, IUri*, uint, IUri**, nuint, HRESULT> OInetCombineIUri => &CoInternetCombineIUri;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetCompareUrl"]/*' />
    [NativeTypeName("#define OInetCompareUrl CoInternetCompareUrl")]
    public static delegate*<char*, char*, uint, HRESULT> OInetCompareUrl => &CoInternetCompareUrl;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetQueryInfo"]/*' />
    [NativeTypeName("#define OInetQueryInfo CoInternetQueryInfo")]
    public static delegate*<char*, QUERYOPTION, uint, void*, uint, uint*, uint, HRESULT> OInetQueryInfo => &CoInternetQueryInfo;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OInetGetSession"]/*' />
    [NativeTypeName("#define OInetGetSession CoInternetGetSession")]
    public static delegate*<uint, IInternetSession**, uint, HRESULT> OInetGetSession => &CoInternetGetSession;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROTOCOLFLAG_NO_PICS_CHECK"]/*' />
    [NativeTypeName("#define PROTOCOLFLAG_NO_PICS_CHECK 0x00000001")]
    public const int PROTOCOLFLAG_NO_PICS_CHECK = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLZONE_ESC_FLAG"]/*' />
    [NativeTypeName("#define URLZONE_ESC_FLAG 0x100")]
    public const int URLZONE_ESC_FLAG = 0x100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_FLAG_USAGE_EMAIL"]/*' />
    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_EMAIL 0x00000001")]
    public const int SOFTDIST_FLAG_USAGE_EMAIL = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_FLAG_USAGE_PRECACHE"]/*' />
    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_PRECACHE 0x00000002")]
    public const int SOFTDIST_FLAG_USAGE_PRECACHE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_FLAG_USAGE_AUTOINSTALL"]/*' />
    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_AUTOINSTALL 0x00000004")]
    public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_FLAG_DELETE_SUBSCRIPTION"]/*' />
    [NativeTypeName("#define SOFTDIST_FLAG_DELETE_SUBSCRIPTION 0x00000008")]
    public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_ADSTATE_NONE"]/*' />
    [NativeTypeName("#define SOFTDIST_ADSTATE_NONE 0x00000000")]
    public const int SOFTDIST_ADSTATE_NONE = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_ADSTATE_AVAILABLE"]/*' />
    [NativeTypeName("#define SOFTDIST_ADSTATE_AVAILABLE 0x00000001")]
    public const int SOFTDIST_ADSTATE_AVAILABLE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_ADSTATE_DOWNLOADED"]/*' />
    [NativeTypeName("#define SOFTDIST_ADSTATE_DOWNLOADED 0x00000002")]
    public const int SOFTDIST_ADSTATE_DOWNLOADED = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SOFTDIST_ADSTATE_INSTALLED"]/*' />
    [NativeTypeName("#define SOFTDIST_ADSTATE_INSTALLED 0x00000003")]
    public const int SOFTDIST_ADSTATE_INSTALLED = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLoggingEnabled"]/*' />
    [NativeTypeName("#define IsLoggingEnabled IsLoggingEnabledW")]
    public static delegate*<char*, BOOL> IsLoggingEnabled => &IsLoggingEnabledW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CONFIRMSAFETYACTION_LOADOBJECT"]/*' />
    [NativeTypeName("#define CONFIRMSAFETYACTION_LOADOBJECT 0x00000001")]
    public const int CONFIRMSAFETYACTION_LOADOBJECT = 0x00000001;
}
