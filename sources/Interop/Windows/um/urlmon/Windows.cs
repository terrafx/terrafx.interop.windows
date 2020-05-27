// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("urlmon", EntryPoint = "CreateURLMoniker", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", EntryPoint = "CreateURLMonikerEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "GetClassURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetClassURL([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

        [DllImport("urlmon", EntryPoint = "CreateAsyncBindCtx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSCb, [NativeTypeName("IEnumFORMATETC *")] IEnumFORMATETC* pEFetc, [NativeTypeName("IBindCtx **")] IBindCtx** ppBC);

        [DllImport("urlmon", EntryPoint = "CreateURLMonikerEx2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "CreateAsyncBindCtxEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAsyncBindCtxEx([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSCb, [NativeTypeName("IEnumFORMATETC *")] IEnumFORMATETC* pEnum, [NativeTypeName("IBindCtx **")] IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", EntryPoint = "MkParseDisplayNameEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MkParseDisplayNameEx([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPCWSTR")] ushort* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", EntryPoint = "RegisterBindStatusCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSCb, [NativeTypeName("IBindStatusCallback **")] IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "RevokeBindStatusCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSCb);

        [DllImport("urlmon", EntryPoint = "GetClassFileOrMime", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("urlmon", EntryPoint = "IsValidURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoGetClassObjectFromURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] ushort* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("urlmon", EntryPoint = "IEInstallScope", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

        [DllImport("urlmon", EntryPoint = "FaultInIEFeature", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FaultInIEFeature([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("uCLSSPEC *")] uCLSSPEC* pClassSpec, [NativeTypeName("QUERYCONTEXT *")] QUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "GetComponentIDFromCLSSPEC", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetComponentIDFromCLSSPEC([NativeTypeName("uCLSSPEC *")] uCLSSPEC* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

        [DllImport("urlmon", EntryPoint = "IsAsyncMoniker", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsAsyncMoniker([NativeTypeName("IMoniker *")] IMoniker* pmk);

        [DllImport("urlmon", EntryPoint = "CreateURLBinding", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLBinding([NativeTypeName("LPCWSTR")] ushort* lpszUrl, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IBinding **")] IBinding** ppBdg);

        [DllImport("urlmon", EntryPoint = "RegisterMediaTypes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterMediaTypes([NativeTypeName("UINT")] uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", EntryPoint = "FindMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", EntryPoint = "CreateFormatEnumerator", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateFormatEnumerator([NativeTypeName("UINT")] uint cfmtetc, [NativeTypeName("FORMATETC *")] FORMATETC* rgfmtetc, [NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenumfmtetc);

        [DllImport("urlmon", EntryPoint = "RegisterFormatEnumerator", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("IEnumFORMATETC *")] IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", EntryPoint = "RevokeFormatEnumerator", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("IEnumFORMATETC *")] IEnumFORMATETC* pEFetc);

        [DllImport("urlmon", EntryPoint = "RegisterMediaTypeClass", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("UINT")] uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", EntryPoint = "FindMediaTypeClass", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", EntryPoint = "UrlMkSetSessionOption", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "UrlMkGetSessionOption", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "FindMimeFromData", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "ObtainUserAgentString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

        [DllImport("urlmon", EntryPoint = "CompareSecurityIds", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CompareSecurityIds([NativeTypeName("BYTE *")] byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, [NativeTypeName("BYTE *")] byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CompatFlagsFromClsid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

        [DllImport("urlmon", EntryPoint = "SetAccessForIEAppContainer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetAccessForIEAppContainer([NativeTypeName("HANDLE")] IntPtr hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

        [DllImport("urlmon", EntryPoint = "CreateUri", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUri([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppURI);

        [DllImport("urlmon", EntryPoint = "CreateUriWithFragment", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUriWithFragment([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("LPCWSTR")] ushort* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppURI);

        [DllImport("urlmon", EntryPoint = "CreateUriFromMultiByteString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppUri);

        [DllImport("urlmon", EntryPoint = "CreateIUriBuilder", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateIUriBuilder([NativeTypeName("IUri *")] IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUriBuilder **")] IUriBuilder** ppIUriBuilder);

        [DllImport("urlmon", EntryPoint = "HlinkSimpleNavigateToString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] ushort* szTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "HlinkSimpleNavigateToMoniker", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSimpleNavigateToMoniker([NativeTypeName("IMoniker *")] IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "URLOpenStreamA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", EntryPoint = "URLOpenStreamW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", EntryPoint = "URLOpenPullStreamA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", EntryPoint = "URLOpenPullStreamW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", EntryPoint = "URLDownloadToFileA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", EntryPoint = "URLDownloadToFileW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPCWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", EntryPoint = "URLDownloadToCacheFileA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", EntryPoint = "URLDownloadToCacheFileW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", EntryPoint = "URLOpenBlockingStreamA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", EntryPoint = "URLOpenBlockingStreamW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", EntryPoint = "HlinkGoBack", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGoBack([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("urlmon", EntryPoint = "HlinkGoForward", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGoForward([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("urlmon", EntryPoint = "HlinkNavigateString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateString([NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("LPCWSTR")] ushort* szTarget);

        [DllImport("urlmon", EntryPoint = "HlinkNavigateMoniker", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateMoniker([NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IMoniker *")] IMoniker* pmkTarget);

        [DllImport("urlmon", EntryPoint = "CoInternetParseUrl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetParseUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetParseIUri", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetParseIUri([NativeTypeName("IUri *")] IUri* pIUri, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetCombineUrl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineUrl([NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetCombineUrlEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineUrlEx([NativeTypeName("IUri *")] IUri* pBaseUri, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("IUri **")] IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetCombineIUri", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineIUri([NativeTypeName("IUri *")] IUri* pBaseUri, [NativeTypeName("IUri *")] IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("IUri **")] IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetCompareUrl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCompareUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl1, [NativeTypeName("LPCWSTR")] ushort* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "CoInternetGetProtocolFlags", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetQueryInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetQueryInfo([NativeTypeName("LPCWSTR")] ushort* pwzUrl, QUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetGetSession", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, [NativeTypeName("IInternetSession **")] IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetGetSecurityUrl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPWSTR *")] ushort** ppwszSecUrl, PSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "AsyncInstallDistributionUnit", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPCWSTR")] ushort* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

        [DllImport("urlmon", EntryPoint = "CoInternetGetSecurityUrlEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSecurityUrlEx([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("IUri **")] IUri** ppSecUri, PSUACTION psuAction, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetSetFeatureEnabled", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fEnable);

        [DllImport("urlmon", EntryPoint = "CoInternetIsFeatureEnabled", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "CoInternetIsFeatureEnabledForUrl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("IInternetSecurityManager *")] IInternetSecurityManager* pSecMgr);

        [DllImport("urlmon", EntryPoint = "CoInternetIsFeatureEnabledForIUri", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabledForIUri(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IUri *")] IUri* pIUri, [NativeTypeName("IInternetSecurityManagerEx2 *")] IInternetSecurityManagerEx2* pSecMgr);

        [DllImport("urlmon", EntryPoint = "CoInternetIsFeatureZoneElevationEnabled", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] ushort* szFromURL, [NativeTypeName("LPCWSTR")] ushort* szToURL, [NativeTypeName("IInternetSecurityManager *")] IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", EntryPoint = "CopyStgMedium", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyStgMedium([NativeTypeName("const STGMEDIUM *")] STGMEDIUM* pcstgmedSrc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmedDest);

        [DllImport("urlmon", EntryPoint = "CopyBindInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyBindInfo([NativeTypeName("const BINDINFO *")] BINDINFO* pcbiSrc, [NativeTypeName("BINDINFO *")] BINDINFO* pbiDest);

        [DllImport("urlmon", EntryPoint = "ReleaseBindInfo", ExactSpelling = true)]
        public static extern void ReleaseBindInfo([NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo);

        [DllImport("urlmon", EntryPoint = "IEGetUserPrivateNamespaceName", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* IEGetUserPrivateNamespaceName();

        [DllImport("urlmon", EntryPoint = "CoInternetCreateSecurityManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCreateSecurityManager([NativeTypeName("IServiceProvider *")] IServiceProvider* pSP, [NativeTypeName("IInternetSecurityManager **")] IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "CoInternetCreateZoneManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCreateZoneManager([NativeTypeName("IServiceProvider *")] IServiceProvider* pSP, [NativeTypeName("IInternetZoneManager **")] IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", EntryPoint = "GetSoftwareUpdateInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

        [DllImport("urlmon", EntryPoint = "SetSoftwareUpdateAdvertisementState", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

        [DllImport("urlmon", EntryPoint = "IsLoggingEnabledA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

        [DllImport("urlmon", EntryPoint = "IsLoggingEnabledW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsLoggingEnabledW([NativeTypeName("LPCWSTR")] ushort* pwszUrl);

        [DllImport("urlmon", EntryPoint = "WriteHitLogging", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] HIT_LOGGING_INFO* lpLogginginfo);
    }
}
