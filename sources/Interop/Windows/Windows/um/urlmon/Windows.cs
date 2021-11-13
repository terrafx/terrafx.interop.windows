// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.BINDF;
using static TerraFX.Interop.Windows.IID;
using static TerraFX.Interop.Windows.PARSEACTION;
using static TerraFX.Interop.Windows.PI_FLAGS;
using static TerraFX.Interop.Windows.Uri_PROPERTY;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetClassURL([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEFetc, IBindCtx** ppBC);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateAsyncBindCtxEx(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEnum, IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT MkParseDisplayNameEx(IBindCtx* pbc, [NativeTypeName("LPCWSTR")] ushort* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb, IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] ushort* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FaultInIEFeature(HWND hWnd, uCLSSPEC* pClassSpec, QUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetComponentIDFromCLSSPEC(uCLSSPEC* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IsAsyncMoniker(IMoniker* pmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterMediaTypes(uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateFormatEnumerator(uint cfmtetc, FORMATETC* rgfmtetc, IEnumFORMATETC** ppenumfmtetc);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CompareSecurityIds(byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT SetAccessForIEAppContainer(HANDLE hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUri([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUriWithFragment([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("LPCWSTR")] ushort* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppUri);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateIUriBuilder(IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] ushort* szTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkSimpleNavigateToMoniker(IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPCWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkGoBack(IUnknown* pUnk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkGoForward(IUnknown* pUnk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkNavigateString(IUnknown* pUnk, [NativeTypeName("LPCWSTR")] ushort* szTarget);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkNavigateMoniker(IUnknown* pUnk, IMoniker* pmkTarget);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetParseUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetParseIUri(IUri* pIUri, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineUrl([NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineUrlEx(IUri* pBaseUri, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineIUri(IUri* pBaseUri, IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCompareUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl1, [NativeTypeName("LPCWSTR")] ushort* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetQueryInfo([NativeTypeName("LPCWSTR")] ushort* pwzUrl, QUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPWSTR *")] ushort** ppwszSecUrl, PSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPCWSTR")] ushort* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szURL, IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSecurityUrlEx(IUri* pUri, IUri** ppSecUri, PSUACTION psuAction, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, BOOL fEnable);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* szURL, IInternetSecurityManager* pSecMgr);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabledForIUri(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, IUri* pIUri, IInternetSecurityManagerEx2* pSecMgr);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] ushort* szFromURL, [NativeTypeName("LPCWSTR")] ushort* szToURL, IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CopyStgMedium([NativeTypeName("const STGMEDIUM *")] STGMEDIUM* pcstgmedSrc, STGMEDIUM* pstgmedDest);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CopyBindInfo([NativeTypeName("const BINDINFO *")] BINDINFO* pcbiSrc, BINDINFO* pbiDest);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern void ReleaseBindInfo(BINDINFO* pbindinfo);

        [DllImport("urlmon", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* IEGetUserPrivateNamespaceName();

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCreateSecurityManager(IServiceProvider* pSP, IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCreateZoneManager(IServiceProvider* pSP, IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL IsLoggingEnabledW([NativeTypeName("LPCWSTR")] ushort* pwszUrl);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] HIT_LOGGING_INFO* lpLogginginfo);

        [NativeTypeName("#define BINDF_DONTUSECACHE BINDF_GETNEWESTVERSION")]
        public const BINDF BINDF_DONTUSECACHE = BINDF_GETNEWESTVERSION;

        [NativeTypeName("#define BINDF_DONTPUTINCACHE BINDF_NOWRITECACHE")]
        public const BINDF BINDF_DONTPUTINCACHE = BINDF_NOWRITECACHE;

        [NativeTypeName("#define BINDF_NOCOPYDATA BINDF_PULLDATA")]
        public const BINDF BINDF_NOCOPYDATA = BINDF_PULLDATA;

        [NativeTypeName("#define INVALID_P_ROOT_SECURITY_ID ((BYTE*)-1)")]
        public static byte* INVALID_P_ROOT_SECURITY_ID => unchecked((byte*)(-1));

        [NativeTypeName("#define PI_DOCFILECLSIDLOOKUP PI_CLSIDLOOKUP")]
        public const PI_FLAGS PI_DOCFILECLSIDLOOKUP = PI_CLSIDLOOKUP;

        [NativeTypeName("#define SZ_URLCONTEXT OLESTR(\"URL Context\")")]
        public const string SZ_URLCONTEXT = "URL Context";

        [NativeTypeName("#define SZ_ASYNC_CALLEE OLESTR(\"AsyncCallee\")")]
        public const string SZ_ASYNC_CALLEE = "AsyncCallee";

        [NativeTypeName("#define MKSYS_URLMONIKER 6")]
        public const int MKSYS_URLMONIKER = 6;

        [NativeTypeName("#define URL_MK_LEGACY 0")]
        public const int URL_MK_LEGACY = 0;

        [NativeTypeName("#define URL_MK_UNIFORM 1")]
        public const int URL_MK_UNIFORM = 1;

        [NativeTypeName("#define URL_MK_NO_CANONICALIZE 2")]
        public const int URL_MK_NO_CANONICALIZE = 2;

        [NativeTypeName("#define FIEF_FLAG_FORCE_JITUI 0x1")]
        public const int FIEF_FLAG_FORCE_JITUI = 0x1;

        [NativeTypeName("#define FIEF_FLAG_PEEK 0x2")]
        public const int FIEF_FLAG_PEEK = 0x2;

        [NativeTypeName("#define FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK 0x4")]
        public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 0x4;

        [NativeTypeName("#define FIEF_FLAG_RESERVED_0 0x8")]
        public const int FIEF_FLAG_RESERVED_0 = 0x8;

        [NativeTypeName("#define FMFD_DEFAULT 0x00000000")]
        public const int FMFD_DEFAULT = 0x00000000;

        [NativeTypeName("#define FMFD_URLASFILENAME 0x00000001")]
        public const int FMFD_URLASFILENAME = 0x00000001;

        [NativeTypeName("#define FMFD_ENABLEMIMESNIFFING 0x00000002")]
        public const int FMFD_ENABLEMIMESNIFFING = 0x00000002;

        [NativeTypeName("#define FMFD_IGNOREMIMETEXTPLAIN 0x00000004")]
        public const int FMFD_IGNOREMIMETEXTPLAIN = 0x00000004;

        [NativeTypeName("#define FMFD_SERVERMIME 0x00000008")]
        public const int FMFD_SERVERMIME = 0x00000008;

        [NativeTypeName("#define FMFD_RESPECTTEXTPLAIN 0x00000010")]
        public const int FMFD_RESPECTTEXTPLAIN = 0x00000010;

        [NativeTypeName("#define FMFD_RETURNUPDATEDIMGMIMES 0x00000020")]
        public const int FMFD_RETURNUPDATEDIMGMIMES = 0x00000020;

        [NativeTypeName("#define FMFD_RESERVED_1 0x00000040")]
        public const int FMFD_RESERVED_1 = 0x00000040;

        [NativeTypeName("#define UAS_EXACTLEGACY 0x00001000")]
        public const int UAS_EXACTLEGACY = 0x00001000;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT 0x10000001")]
        public const int URLMON_OPTION_USERAGENT = 0x10000001;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT_REFRESH 0x10000002")]
        public const int URLMON_OPTION_USERAGENT_REFRESH = 0x10000002;

        [NativeTypeName("#define URLMON_OPTION_URL_ENCODING 0x10000004")]
        public const int URLMON_OPTION_URL_ENCODING = 0x10000004;

        [NativeTypeName("#define URLMON_OPTION_USE_BINDSTRINGCREDS 0x10000008")]
        public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 0x10000008;

        [NativeTypeName("#define URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS 0x10000010")]
        public const int URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS = 0x10000010;

        [NativeTypeName("#define CF_NULL 0")]
        public const int CF_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_NULL NULL")]
        public const int CFSTR_MIME_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_TEXT (TEXT(\"text/plain\"))")]
        public const string CFSTR_MIME_TEXT = ("text/plain");

        [NativeTypeName("#define CFSTR_MIME_RICHTEXT (TEXT(\"text/richtext\"))")]
        public const string CFSTR_MIME_RICHTEXT = ("text/richtext");

        [NativeTypeName("#define CFSTR_MIME_MANIFEST (TEXT(\"text/cache-manifest\"))")]
        public const string CFSTR_MIME_MANIFEST = ("text/cache-manifest");

        [NativeTypeName("#define CFSTR_MIME_WEBVTT (TEXT(\"text/vtt\"))")]
        public const string CFSTR_MIME_WEBVTT = ("text/vtt");

        [NativeTypeName("#define CFSTR_MIME_X_BITMAP (TEXT(\"image/x-xbitmap\"))")]
        public const string CFSTR_MIME_X_BITMAP = ("image/x-xbitmap");

        [NativeTypeName("#define CFSTR_MIME_POSTSCRIPT (TEXT(\"application/postscript\"))")]
        public const string CFSTR_MIME_POSTSCRIPT = ("application/postscript");

        [NativeTypeName("#define CFSTR_MIME_AIFF (TEXT(\"audio/aiff\"))")]
        public const string CFSTR_MIME_AIFF = ("audio/aiff");

        [NativeTypeName("#define CFSTR_MIME_BASICAUDIO (TEXT(\"audio/basic\"))")]
        public const string CFSTR_MIME_BASICAUDIO = ("audio/basic");

        [NativeTypeName("#define CFSTR_MIME_WAV (TEXT(\"audio/wav\"))")]
        public const string CFSTR_MIME_WAV = ("audio/wav");

        [NativeTypeName("#define CFSTR_MIME_X_WAV (TEXT(\"audio/x-wav\"))")]
        public const string CFSTR_MIME_X_WAV = ("audio/x-wav");

        [NativeTypeName("#define CFSTR_MIME_GIF (TEXT(\"image/gif\"))")]
        public const string CFSTR_MIME_GIF = ("image/gif");

        [NativeTypeName("#define CFSTR_MIME_PJPEG (TEXT(\"image/pjpeg\"))")]
        public const string CFSTR_MIME_PJPEG = ("image/pjpeg");

        [NativeTypeName("#define CFSTR_MIME_JPEG (TEXT(\"image/jpeg\"))")]
        public const string CFSTR_MIME_JPEG = ("image/jpeg");

        [NativeTypeName("#define CFSTR_MIME_TIFF (TEXT(\"image/tiff\"))")]
        public const string CFSTR_MIME_TIFF = ("image/tiff");

        [NativeTypeName("#define CFSTR_MIME_JPEG_XR (TEXT(\"image/vnd.ms-photo\"))")]
        public const string CFSTR_MIME_JPEG_XR = ("image/vnd.ms-photo");

        [NativeTypeName("#define CFSTR_MIME_PNG (TEXT(\"image/png\"))")]
        public const string CFSTR_MIME_PNG = ("image/png");

        [NativeTypeName("#define CFSTR_MIME_DDS (TEXT(\"image/vnd.ms-dds\"))")]
        public const string CFSTR_MIME_DDS = ("image/vnd.ms-dds");

        [NativeTypeName("#define CFSTR_MIME_X_PNG (TEXT(\"image/x-png\"))")]
        public const string CFSTR_MIME_X_PNG = ("image/x-png");

        [NativeTypeName("#define CFSTR_MIME_X_ICON (TEXT(\"image/x-icon\"))")]
        public const string CFSTR_MIME_X_ICON = ("image/x-icon");

        [NativeTypeName("#define CFSTR_MIME_SVG_XML (TEXT(\"image/svg+xml\"))")]
        public const string CFSTR_MIME_SVG_XML = ("image/svg+xml");

        [NativeTypeName("#define CFSTR_MIME_BMP (TEXT(\"image/bmp\"))")]
        public const string CFSTR_MIME_BMP = ("image/bmp");

        [NativeTypeName("#define CFSTR_MIME_X_EMF (TEXT(\"image/x-emf\"))")]
        public const string CFSTR_MIME_X_EMF = ("image/x-emf");

        [NativeTypeName("#define CFSTR_MIME_X_WMF (TEXT(\"image/x-wmf\"))")]
        public const string CFSTR_MIME_X_WMF = ("image/x-wmf");

        [NativeTypeName("#define CFSTR_MIME_AVI (TEXT(\"video/avi\"))")]
        public const string CFSTR_MIME_AVI = ("video/avi");

        [NativeTypeName("#define CFSTR_MIME_MPEG (TEXT(\"video/mpeg\"))")]
        public const string CFSTR_MIME_MPEG = ("video/mpeg");

        [NativeTypeName("#define CFSTR_MIME_FRACTALS (TEXT(\"application/fractals\"))")]
        public const string CFSTR_MIME_FRACTALS = ("application/fractals");

        [NativeTypeName("#define CFSTR_MIME_RAWDATA (TEXT(\"application/octet-stream\"))")]
        public const string CFSTR_MIME_RAWDATA = ("application/octet-stream");

        [NativeTypeName("#define CFSTR_MIME_RAWDATASTRM (TEXT(\"application/octet-stream\"))")]
        public const string CFSTR_MIME_RAWDATASTRM = ("application/octet-stream");

        [NativeTypeName("#define CFSTR_MIME_PDF (TEXT(\"application/pdf\"))")]
        public const string CFSTR_MIME_PDF = ("application/pdf");

        [NativeTypeName("#define CFSTR_MIME_HTA (TEXT(\"application/hta\"))")]
        public const string CFSTR_MIME_HTA = ("application/hta");

        [NativeTypeName("#define CFSTR_MIME_APP_XML (TEXT(\"application/xml\"))")]
        public const string CFSTR_MIME_APP_XML = ("application/xml");

        [NativeTypeName("#define CFSTR_MIME_XHTML (TEXT(\"application/xhtml+xml\"))")]
        public const string CFSTR_MIME_XHTML = ("application/xhtml+xml");

        [NativeTypeName("#define CFSTR_MIME_X_AIFF (TEXT(\"audio/x-aiff\"))")]
        public const string CFSTR_MIME_X_AIFF = ("audio/x-aiff");

        [NativeTypeName("#define CFSTR_MIME_X_REALAUDIO (TEXT(\"audio/x-pn-realaudio\"))")]
        public const string CFSTR_MIME_X_REALAUDIO = ("audio/x-pn-realaudio");

        [NativeTypeName("#define CFSTR_MIME_XBM (TEXT(\"image/xbm\"))")]
        public const string CFSTR_MIME_XBM = ("image/xbm");

        [NativeTypeName("#define CFSTR_MIME_QUICKTIME (TEXT(\"video/quicktime\"))")]
        public const string CFSTR_MIME_QUICKTIME = ("video/quicktime");

        [NativeTypeName("#define CFSTR_MIME_X_MSVIDEO (TEXT(\"video/x-msvideo\"))")]
        public const string CFSTR_MIME_X_MSVIDEO = ("video/x-msvideo");

        [NativeTypeName("#define CFSTR_MIME_X_SGI_MOVIE (TEXT(\"video/x-sgi-movie\"))")]
        public const string CFSTR_MIME_X_SGI_MOVIE = ("video/x-sgi-movie");

        [NativeTypeName("#define CFSTR_MIME_X_MIXED_REPLACE (TEXT(\"multipart/x-mixed-replace\"))")]
        public const string CFSTR_MIME_X_MIXED_REPLACE = ("multipart/x-mixed-replace");

        [NativeTypeName("#define CFSTR_MIME_HTML (TEXT(\"text/html\"))")]
        public const string CFSTR_MIME_HTML = ("text/html");

        [NativeTypeName("#define CFSTR_MIME_XML (TEXT(\"text/xml\"))")]
        public const string CFSTR_MIME_XML = ("text/xml");

        [NativeTypeName("#define CFSTR_MIME_TTML (TEXT(\"application/ttml+xml\"))")]
        public const string CFSTR_MIME_TTML = ("application/ttml+xml");

        [NativeTypeName("#define CFSTR_MIME_TTAF (TEXT(\"application/ttaf+xml\"))")]
        public const string CFSTR_MIME_TTAF = ("application/ttaf+xml");

        [NativeTypeName("#define CFSTR_MIME_X_JAVASCRIPT (TEXT(\"application/x-javascript\"))")]
        public const string CFSTR_MIME_X_JAVASCRIPT = ("application/x-javascript");

        [NativeTypeName("#define CFSTR_MIME_TEXT_JSON (TEXT(\"text/json\"))")]
        public const string CFSTR_MIME_TEXT_JSON = ("text/json");

        [NativeTypeName("#define CFSTR_MIME_APPLICATION_JAVASCRIPT (TEXT(\"application/javascript\"))")]
        public const string CFSTR_MIME_APPLICATION_JAVASCRIPT = ("application/javascript");

        [NativeTypeName("#define MK_S_ASYNCHRONOUS _HRESULT_TYPEDEF_(0x000401E8L)")]
        public const int MK_S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define S_ASYNCHRONOUS MK_S_ASYNCHRONOUS")]
        public const int S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define INET_E_INVALID_URL _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_INVALID_URL = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_NO_SESSION _HRESULT_TYPEDEF_(0x800C0003L)")]
        public const int INET_E_NO_SESSION = unchecked((int)(0x800C0003));

        [NativeTypeName("#define INET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x800C0004L)")]
        public const int INET_E_CANNOT_CONNECT = unchecked((int)(0x800C0004));

        [NativeTypeName("#define INET_E_RESOURCE_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0005L)")]
        public const int INET_E_RESOURCE_NOT_FOUND = unchecked((int)(0x800C0005));

        [NativeTypeName("#define INET_E_OBJECT_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0006L)")]
        public const int INET_E_OBJECT_NOT_FOUND = unchecked((int)(0x800C0006));

        [NativeTypeName("#define INET_E_DATA_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x800C0007L)")]
        public const int INET_E_DATA_NOT_AVAILABLE = unchecked((int)(0x800C0007));

        [NativeTypeName("#define INET_E_DOWNLOAD_FAILURE _HRESULT_TYPEDEF_(0x800C0008L)")]
        public const int INET_E_DOWNLOAD_FAILURE = unchecked((int)(0x800C0008));

        [NativeTypeName("#define INET_E_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x800C0009L)")]
        public const int INET_E_AUTHENTICATION_REQUIRED = unchecked((int)(0x800C0009));

        [NativeTypeName("#define INET_E_NO_VALID_MEDIA _HRESULT_TYPEDEF_(0x800C000AL)")]
        public const int INET_E_NO_VALID_MEDIA = unchecked((int)(0x800C000A));

        [NativeTypeName("#define INET_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x800C000BL)")]
        public const int INET_E_CONNECTION_TIMEOUT = unchecked((int)(0x800C000B));

        [NativeTypeName("#define INET_E_INVALID_REQUEST _HRESULT_TYPEDEF_(0x800C000CL)")]
        public const int INET_E_INVALID_REQUEST = unchecked((int)(0x800C000C));

        [NativeTypeName("#define INET_E_UNKNOWN_PROTOCOL _HRESULT_TYPEDEF_(0x800C000DL)")]
        public const int INET_E_UNKNOWN_PROTOCOL = unchecked((int)(0x800C000D));

        [NativeTypeName("#define INET_E_SECURITY_PROBLEM _HRESULT_TYPEDEF_(0x800C000EL)")]
        public const int INET_E_SECURITY_PROBLEM = unchecked((int)(0x800C000E));

        [NativeTypeName("#define INET_E_CANNOT_LOAD_DATA _HRESULT_TYPEDEF_(0x800C000FL)")]
        public const int INET_E_CANNOT_LOAD_DATA = unchecked((int)(0x800C000F));

        [NativeTypeName("#define INET_E_CANNOT_INSTANTIATE_OBJECT _HRESULT_TYPEDEF_(0x800C0010L)")]
        public const int INET_E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)(0x800C0010));

        [NativeTypeName("#define INET_E_INVALID_CERTIFICATE _HRESULT_TYPEDEF_(0x800C0019L)")]
        public const int INET_E_INVALID_CERTIFICATE = unchecked((int)(0x800C0019));

        [NativeTypeName("#define INET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECT_FAILED = unchecked((int)(0x800C0014));

        [NativeTypeName("#define INET_E_REDIRECT_TO_DIR _HRESULT_TYPEDEF_(0x800C0015L)")]
        public const int INET_E_REDIRECT_TO_DIR = unchecked((int)(0x800C0015));

        [NativeTypeName("#define INET_E_CANNOT_LOCK_REQUEST _HRESULT_TYPEDEF_(0x800C0016L)")]
        public const int INET_E_CANNOT_LOCK_REQUEST = unchecked((int)(0x800C0016));

        [NativeTypeName("#define INET_E_USE_EXTEND_BINDING _HRESULT_TYPEDEF_(0x800C0017L)")]
        public const int INET_E_USE_EXTEND_BINDING = unchecked((int)(0x800C0017));

        [NativeTypeName("#define INET_E_TERMINATED_BIND _HRESULT_TYPEDEF_(0x800C0018L)")]
        public const int INET_E_TERMINATED_BIND = unchecked((int)(0x800C0018));

        [NativeTypeName("#define INET_E_RESERVED_1 _HRESULT_TYPEDEF_(0x800C001AL)")]
        public const int INET_E_RESERVED_1 = unchecked((int)(0x800C001A));

        [NativeTypeName("#define INET_E_BLOCKED_REDIRECT_XSECURITYID _HRESULT_TYPEDEF_(0x800C001BL)")]
        public const int INET_E_BLOCKED_REDIRECT_XSECURITYID = unchecked((int)(0x800C001B));

        [NativeTypeName("#define INET_E_DOMINJECTIONVALIDATION _HRESULT_TYPEDEF_(0x800C001CL)")]
        public const int INET_E_DOMINJECTIONVALIDATION = unchecked((int)(0x800C001C));

        [NativeTypeName("#define INET_E_VTAB_SWITCH_FORCE_ENGINE _HRESULT_TYPEDEF_(0x800C001DL)")]
        public const int INET_E_VTAB_SWITCH_FORCE_ENGINE = unchecked((int)(0x800C001D));

        [NativeTypeName("#define INET_E_HSTS_CERTIFICATE_ERROR _HRESULT_TYPEDEF_(0x800C001EL)")]
        public const int INET_E_HSTS_CERTIFICATE_ERROR = unchecked((int)(0x800C001E));

        [NativeTypeName("#define INET_E_RESERVED_2 _HRESULT_TYPEDEF_(0x800C001FL)")]
        public const int INET_E_RESERVED_2 = unchecked((int)(0x800C001F));

        [NativeTypeName("#define INET_E_RESERVED_3 _HRESULT_TYPEDEF_(0x800C0020L)")]
        public const int INET_E_RESERVED_3 = unchecked((int)(0x800C0020));

        [NativeTypeName("#define INET_E_RESERVED_4 _HRESULT_TYPEDEF_(0x800C0021L)")]
        public const int INET_E_RESERVED_4 = unchecked((int)(0x800C0021));

        [NativeTypeName("#define INET_E_RESERVED_5 _HRESULT_TYPEDEF_(0x800C0022L)")]
        public const int INET_E_RESERVED_5 = unchecked((int)(0x800C0022));

        [NativeTypeName("#define INET_E_ERROR_FIRST _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_ERROR_FIRST = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_CODE_DOWNLOAD_DECLINED _HRESULT_TYPEDEF_(0x800C0100L)")]
        public const int INET_E_CODE_DOWNLOAD_DECLINED = unchecked((int)(0x800C0100));

        [NativeTypeName("#define INET_E_RESULT_DISPATCHED _HRESULT_TYPEDEF_(0x800C0200L)")]
        public const int INET_E_RESULT_DISPATCHED = unchecked((int)(0x800C0200));

        [NativeTypeName("#define INET_E_CANNOT_REPLACE_SFP_FILE _HRESULT_TYPEDEF_(0x800C0300L)")]
        public const int INET_E_CANNOT_REPLACE_SFP_FILE = unchecked((int)(0x800C0300));

        [NativeTypeName("#define INET_E_CODE_INSTALL_SUPPRESSED _HRESULT_TYPEDEF_(0x800C0400L)")]
        public const int INET_E_CODE_INSTALL_SUPPRESSED = unchecked((int)(0x800C0400));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY _HRESULT_TYPEDEF_(0x800C0500L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY = unchecked((int)(0x800C0500));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE _HRESULT_TYPEDEF_(0x800C0501L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE = unchecked((int)(0x800C0501));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE _HRESULT_TYPEDEF_(0x800C0502L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE = unchecked((int)(0x800C0502));

        [NativeTypeName("#define INET_E_FORBIDFRAMING _HRESULT_TYPEDEF_(0x800C0503L)")]
        public const int INET_E_FORBIDFRAMING = unchecked((int)(0x800C0503));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_ARM _HRESULT_TYPEDEF_(0x800C0504L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_ARM = unchecked((int)(0x800C0504));

        [NativeTypeName("#define INET_E_BLOCKED_PLUGGABLE_PROTOCOL _HRESULT_TYPEDEF_(0x800C0505L)")]
        public const int INET_E_BLOCKED_PLUGGABLE_PROTOCOL = unchecked((int)(0x800C0505));

        [NativeTypeName("#define INET_E_BLOCKED_ENHANCEDPROTECTEDMODE _HRESULT_TYPEDEF_(0x800C0506L)")]
        public const int INET_E_BLOCKED_ENHANCEDPROTECTEDMODE = unchecked((int)(0x800C0506));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BITNESS _HRESULT_TYPEDEF_(0x800C0507L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BITNESS = unchecked((int)(0x800C0507));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_CSP _HRESULT_TYPEDEF_(0x800C0508L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_CSP = unchecked((int)(0x800C0508));

        [NativeTypeName("#define INET_E_ERROR_LAST INET_E_DOWNLOAD_BLOCKED_BY_CSP")]
        public const int INET_E_ERROR_LAST = unchecked((int)(0x800C0508));

        [NativeTypeName("#define Uri_HAS_ABSOLUTE_URI (1 << Uri_PROPERTY_ABSOLUTE_URI)")]
        public const int Uri_HAS_ABSOLUTE_URI = (1 << (int)(Uri_PROPERTY_ABSOLUTE_URI));

        [NativeTypeName("#define Uri_HAS_AUTHORITY (1 << Uri_PROPERTY_AUTHORITY)")]
        public const int Uri_HAS_AUTHORITY = (1 << (int)(Uri_PROPERTY_AUTHORITY));

        [NativeTypeName("#define Uri_HAS_DISPLAY_URI (1 << Uri_PROPERTY_DISPLAY_URI)")]
        public const int Uri_HAS_DISPLAY_URI = (1 << (int)(Uri_PROPERTY_DISPLAY_URI));

        [NativeTypeName("#define Uri_HAS_DOMAIN (1 << Uri_PROPERTY_DOMAIN)")]
        public const int Uri_HAS_DOMAIN = (1 << (int)(Uri_PROPERTY_DOMAIN));

        [NativeTypeName("#define Uri_HAS_EXTENSION (1 << Uri_PROPERTY_EXTENSION)")]
        public const int Uri_HAS_EXTENSION = (1 << (int)(Uri_PROPERTY_EXTENSION));

        [NativeTypeName("#define Uri_HAS_FRAGMENT (1 << Uri_PROPERTY_FRAGMENT)")]
        public const int Uri_HAS_FRAGMENT = (1 << (int)(Uri_PROPERTY_FRAGMENT));

        [NativeTypeName("#define Uri_HAS_HOST (1 << Uri_PROPERTY_HOST)")]
        public const int Uri_HAS_HOST = (1 << (int)(Uri_PROPERTY_HOST));

        [NativeTypeName("#define Uri_HAS_PASSWORD (1 << Uri_PROPERTY_PASSWORD)")]
        public const int Uri_HAS_PASSWORD = (1 << (int)(Uri_PROPERTY_PASSWORD));

        [NativeTypeName("#define Uri_HAS_PATH (1 << Uri_PROPERTY_PATH)")]
        public const int Uri_HAS_PATH = (1 << (int)(Uri_PROPERTY_PATH));

        [NativeTypeName("#define Uri_HAS_QUERY (1 << Uri_PROPERTY_QUERY)")]
        public const int Uri_HAS_QUERY = (1 << (int)(Uri_PROPERTY_QUERY));

        [NativeTypeName("#define Uri_HAS_RAW_URI (1 << Uri_PROPERTY_RAW_URI)")]
        public const int Uri_HAS_RAW_URI = (1 << (int)(Uri_PROPERTY_RAW_URI));

        [NativeTypeName("#define Uri_HAS_SCHEME_NAME (1 << Uri_PROPERTY_SCHEME_NAME)")]
        public const int Uri_HAS_SCHEME_NAME = (1 << (int)(Uri_PROPERTY_SCHEME_NAME));

        [NativeTypeName("#define Uri_HAS_USER_NAME (1 << Uri_PROPERTY_USER_NAME)")]
        public const int Uri_HAS_USER_NAME = (1 << (int)(Uri_PROPERTY_USER_NAME));

        [NativeTypeName("#define Uri_HAS_PATH_AND_QUERY (1 << Uri_PROPERTY_PATH_AND_QUERY)")]
        public const int Uri_HAS_PATH_AND_QUERY = (1 << (int)(Uri_PROPERTY_PATH_AND_QUERY));

        [NativeTypeName("#define Uri_HAS_USER_INFO (1 << Uri_PROPERTY_USER_INFO)")]
        public const int Uri_HAS_USER_INFO = (1 << (int)(Uri_PROPERTY_USER_INFO));

        [NativeTypeName("#define Uri_HAS_HOST_TYPE (1 << Uri_PROPERTY_HOST_TYPE)")]
        public const int Uri_HAS_HOST_TYPE = (1 << (int)(Uri_PROPERTY_HOST_TYPE));

        [NativeTypeName("#define Uri_HAS_PORT (1 << Uri_PROPERTY_PORT)")]
        public const int Uri_HAS_PORT = (1 << (int)(Uri_PROPERTY_PORT));

        [NativeTypeName("#define Uri_HAS_SCHEME (1 << Uri_PROPERTY_SCHEME)")]
        public const int Uri_HAS_SCHEME = (1 << (int)(Uri_PROPERTY_SCHEME));

        [NativeTypeName("#define Uri_HAS_ZONE (1 << Uri_PROPERTY_ZONE)")]
        public const int Uri_HAS_ZONE = (1 << (int)(Uri_PROPERTY_ZONE));

        [NativeTypeName("#define Uri_CREATE_ALLOW_RELATIVE 0x00000001")]
        public const int Uri_CREATE_ALLOW_RELATIVE = 0x00000001;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME 0x00000002")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME = 0x00000002;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME 0x00000004")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME = 0x00000004;

        [NativeTypeName("#define Uri_CREATE_NOFRAG 0x00000008")]
        public const int Uri_CREATE_NOFRAG = 0x00000008;

        [NativeTypeName("#define Uri_CREATE_NO_CANONICALIZE 0x00000010")]
        public const int Uri_CREATE_NO_CANONICALIZE = 0x00000010;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE 0x00000100")]
        public const int Uri_CREATE_CANONICALIZE = 0x00000100;

        [NativeTypeName("#define Uri_CREATE_FILE_USE_DOS_PATH 0x00000020")]
        public const int Uri_CREATE_FILE_USE_DOS_PATH = 0x00000020;

        [NativeTypeName("#define Uri_CREATE_DECODE_EXTRA_INFO 0x00000040")]
        public const int Uri_CREATE_DECODE_EXTRA_INFO = 0x00000040;

        [NativeTypeName("#define Uri_CREATE_NO_DECODE_EXTRA_INFO 0x00000080")]
        public const int Uri_CREATE_NO_DECODE_EXTRA_INFO = 0x00000080;

        [NativeTypeName("#define Uri_CREATE_CRACK_UNKNOWN_SCHEMES 0x00000200")]
        public const int Uri_CREATE_CRACK_UNKNOWN_SCHEMES = 0x00000200;

        [NativeTypeName("#define Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES 0x00000400")]
        public const int Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES = 0x00000400;

        [NativeTypeName("#define Uri_CREATE_PRE_PROCESS_HTML_URI 0x00000800")]
        public const int Uri_CREATE_PRE_PROCESS_HTML_URI = 0x00000800;

        [NativeTypeName("#define Uri_CREATE_NO_PRE_PROCESS_HTML_URI 0x00001000")]
        public const int Uri_CREATE_NO_PRE_PROCESS_HTML_URI = 0x00001000;

        [NativeTypeName("#define Uri_CREATE_IE_SETTINGS 0x00002000")]
        public const int Uri_CREATE_IE_SETTINGS = 0x00002000;

        [NativeTypeName("#define Uri_CREATE_NO_IE_SETTINGS 0x00004000")]
        public const int Uri_CREATE_NO_IE_SETTINGS = 0x00004000;

        [NativeTypeName("#define Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS 0x00008000")]
        public const int Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS = 0x00008000;

        [NativeTypeName("#define Uri_CREATE_NORMALIZE_INTL_CHARACTERS 0x00010000")]
        public const int Uri_CREATE_NORMALIZE_INTL_CHARACTERS = 0x00010000;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE_ABSOLUTE 0x00020000")]
        public const int Uri_CREATE_CANONICALIZE_ABSOLUTE = 0x00020000;

        [NativeTypeName("#define Uri_DISPLAY_NO_FRAGMENT 0x00000001")]
        public const int Uri_DISPLAY_NO_FRAGMENT = 0x00000001;

        [NativeTypeName("#define Uri_PUNYCODE_IDN_HOST 0x00000002")]
        public const int Uri_PUNYCODE_IDN_HOST = 0x00000002;

        [NativeTypeName("#define Uri_DISPLAY_IDN_HOST 0x00000004")]
        public const int Uri_DISPLAY_IDN_HOST = 0x00000004;

        [NativeTypeName("#define Uri_DISPLAY_NO_PUNYCODE 0x00000008")]
        public const int Uri_DISPLAY_NO_PUNYCODE = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 0x00000001")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 = 0x00000001;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_CP 0x00000002")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_CP = 0x00000002;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_IDN 0x00000004")]
        public const int Uri_ENCODING_HOST_IS_IDN = 0x00000004;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 0x00000008")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP 0x00000010")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP = 0x00000010;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 0x00000020")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 = 0x00000020;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP 0x00000040")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP = 0x00000040;

        [NativeTypeName("#define Uri_ENCODING_RFC (Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8)")]
        public const int Uri_ENCODING_RFC = (0x00000001 | 0x00000008 | 0x00000020);

        [NativeTypeName("#define UriBuilder_USE_ORIGINAL_FLAGS 0x00000001")]
        public const int UriBuilder_USE_ORIGINAL_FLAGS = 0x00000001;

        [NativeTypeName("#define WININETINFO_OPTION_LOCK_HANDLE 65534")]
        public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

        [NativeTypeName("#define SID_IBindHost IID_IBindHost")]
        public static ref readonly Guid SID_IBindHost => ref IID_IBindHost;

        [NativeTypeName("#define SID_SBindHost IID_IBindHost")]
        public static ref readonly Guid SID_SBindHost => ref IID_IBindHost;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY_ONLY 0x1")]
        public const int URLOSTRM_USECACHEDCOPY_ONLY = 0x1;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY 0x2")]
        public const int URLOSTRM_USECACHEDCOPY = 0x2;

        [NativeTypeName("#define URLOSTRM_GETNEWESTVERSION 0x3")]
        public const int URLOSTRM_GETNEWESTVERSION = 0x3;

        [NativeTypeName("#define URLOpenStream URLOpenStreamW")]
        public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenStream => &URLOpenStreamW;

        [NativeTypeName("#define URLOpenPullStream URLOpenPullStreamW")]
        public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenPullStream => &URLOpenPullStreamW;

        [NativeTypeName("#define URLDownloadToFile URLDownloadToFileW")]
        public static delegate*<IUnknown*, ushort*, ushort*, uint, IBindStatusCallback*, HRESULT> URLDownloadToFile => &URLDownloadToFileW;

        [NativeTypeName("#define URLDownloadToCacheFile URLDownloadToCacheFileW")]
        public static delegate*<IUnknown*, ushort*, ushort*, uint, uint, IBindStatusCallback*, HRESULT> URLDownloadToCacheFile => &URLDownloadToCacheFileW;

        [NativeTypeName("#define URLOpenBlockingStream URLOpenBlockingStreamW")]
        public static delegate*<IUnknown*, ushort*, IStream**, uint, IBindStatusCallback*, HRESULT> URLOpenBlockingStream => &URLOpenBlockingStreamW;

        [NativeTypeName("#define PARSE_ENCODE PARSE_ENCODE_IS_UNESCAPE")]
        public const PARSEACTION PARSE_ENCODE = PARSE_ENCODE_IS_UNESCAPE;

        [NativeTypeName("#define PARSE_DECODE PARSE_DECODE_IS_ESCAPE")]
        public const PARSEACTION PARSE_DECODE = PARSE_DECODE_IS_ESCAPE;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD 0x00000001")]
        public const int SET_FEATURE_ON_THREAD = 0x00000001;

        [NativeTypeName("#define SET_FEATURE_ON_PROCESS 0x00000002")]
        public const int SET_FEATURE_ON_PROCESS = 0x00000002;

        [NativeTypeName("#define SET_FEATURE_IN_REGISTRY 0x00000004")]
        public const int SET_FEATURE_IN_REGISTRY = 0x00000004;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_LOCALMACHINE 0x00000008")]
        public const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTRANET 0x00000010")]
        public const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_TRUSTED 0x00000020")]
        public const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTERNET 0x00000040")]
        public const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_RESTRICTED 0x00000080")]
        public const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD 0x00000001")]
        public const int GET_FEATURE_FROM_THREAD = 0x00000001;

        [NativeTypeName("#define GET_FEATURE_FROM_PROCESS 0x00000002")]
        public const int GET_FEATURE_FROM_PROCESS = 0x00000002;

        [NativeTypeName("#define GET_FEATURE_FROM_REGISTRY 0x00000004")]
        public const int GET_FEATURE_FROM_REGISTRY = 0x00000004;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_LOCALMACHINE 0x00000008")]
        public const int GET_FEATURE_FROM_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTRANET 0x00000010")]
        public const int GET_FEATURE_FROM_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_TRUSTED 0x00000020")]
        public const int GET_FEATURE_FROM_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTERNET 0x00000040")]
        public const int GET_FEATURE_FROM_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_RESTRICTED 0x00000080")]
        public const int GET_FEATURE_FROM_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define INET_E_USE_DEFAULT_PROTOCOLHANDLER _HRESULT_TYPEDEF_(0x800C0011L)")]
        public const int INET_E_USE_DEFAULT_PROTOCOLHANDLER = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_USE_DEFAULT_SETTING _HRESULT_TYPEDEF_(0x800C0012L)")]
        public const int INET_E_USE_DEFAULT_SETTING = unchecked((int)(0x800C0012));

        [NativeTypeName("#define INET_E_DEFAULT_ACTION INET_E_USE_DEFAULT_PROTOCOLHANDLER")]
        public const int INET_E_DEFAULT_ACTION = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_QUERYOPTION_UNKNOWN _HRESULT_TYPEDEF_(0x800C0013L)")]
        public const int INET_E_QUERYOPTION_UNKNOWN = unchecked((int)(0x800C0013));

        [NativeTypeName("#define INET_E_REDIRECTING _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECTING = unchecked((int)(0x800C0014));

        [NativeTypeName("#define OInetParseUrl CoInternetParseUrl")]
        public static delegate*<ushort*, PARSEACTION, uint, ushort*, uint, uint*, uint, HRESULT> OInetParseUrl => &CoInternetParseUrl;

        [NativeTypeName("#define OInetCombineUrl CoInternetCombineUrl")]
        public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint*, uint, HRESULT> OInetCombineUrl => &CoInternetCombineUrl;

        [NativeTypeName("#define OInetCombineUrlEx CoInternetCombineUrlEx")]
        public static delegate*<IUri*, ushort*, uint, IUri**, nuint, HRESULT> OInetCombineUrlEx => &CoInternetCombineUrlEx;

        [NativeTypeName("#define OInetCombineIUri CoInternetCombineIUri")]
        public static delegate*<IUri*, IUri*, uint, IUri**, nuint, HRESULT> OInetCombineIUri => &CoInternetCombineIUri;

        [NativeTypeName("#define OInetCompareUrl CoInternetCompareUrl")]
        public static delegate*<ushort*, ushort*, uint, HRESULT> OInetCompareUrl => &CoInternetCompareUrl;

        [NativeTypeName("#define OInetQueryInfo CoInternetQueryInfo")]
        public static delegate*<ushort*, QUERYOPTION, uint, void*, uint, uint*, uint, HRESULT> OInetQueryInfo => &CoInternetQueryInfo;

        [NativeTypeName("#define OInetGetSession CoInternetGetSession")]
        public static delegate*<uint, IInternetSession**, uint, HRESULT> OInetGetSession => &CoInternetGetSession;

        [NativeTypeName("#define PROTOCOLFLAG_NO_PICS_CHECK 0x00000001")]
        public const int PROTOCOLFLAG_NO_PICS_CHECK = 0x00000001;

        [NativeTypeName("#define SID_SInternetSecurityManager IID_IInternetSecurityManager")]
        public static ref readonly Guid SID_SInternetSecurityManager => ref IID_IInternetSecurityManager;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx IID_IInternetSecurityManagerEx")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx => ref IID_IInternetSecurityManagerEx;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx2 IID_IInternetSecurityManagerEx2")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx2 => ref IID_IInternetSecurityManagerEx2;

        [NativeTypeName("#define SID_SInternetHostSecurityManager IID_IInternetHostSecurityManager")]
        public static ref readonly Guid SID_SInternetHostSecurityManager => ref IID_IInternetHostSecurityManager;

        [NativeTypeName("#define MUTZ_NOSAVEDFILECHECK 0x00000001")]
        public const int MUTZ_NOSAVEDFILECHECK = 0x00000001;

        [NativeTypeName("#define MUTZ_ISFILE 0x00000002")]
        public const int MUTZ_ISFILE = 0x00000002;

        [NativeTypeName("#define MUTZ_ACCEPT_WILDCARD_SCHEME 0x00000080")]
        public const int MUTZ_ACCEPT_WILDCARD_SCHEME = 0x00000080;

        [NativeTypeName("#define MUTZ_ENFORCERESTRICTED 0x00000100")]
        public const int MUTZ_ENFORCERESTRICTED = 0x00000100;

        [NativeTypeName("#define MUTZ_RESERVED 0x00000200")]
        public const int MUTZ_RESERVED = 0x00000200;

        [NativeTypeName("#define MUTZ_REQUIRESAVEDFILECHECK 0x00000400")]
        public const int MUTZ_REQUIRESAVEDFILECHECK = 0x00000400;

        [NativeTypeName("#define MUTZ_DONT_UNESCAPE 0x00000800")]
        public const int MUTZ_DONT_UNESCAPE = 0x00000800;

        [NativeTypeName("#define MUTZ_DONT_USE_CACHE 0x00001000")]
        public const int MUTZ_DONT_USE_CACHE = 0x00001000;

        [NativeTypeName("#define MUTZ_FORCE_INTRANET_FLAGS 0x00002000")]
        public const int MUTZ_FORCE_INTRANET_FLAGS = 0x00002000;

        [NativeTypeName("#define MUTZ_IGNORE_ZONE_MAPPINGS 0x00004000")]
        public const int MUTZ_IGNORE_ZONE_MAPPINGS = 0x00004000;

        [NativeTypeName("#define MAX_SIZE_SECURITY_ID 512")]
        public const int MAX_SIZE_SECURITY_ID = 512;

        [NativeTypeName("#define URLPOLICY_ACTIVEX_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_ACTIVEX_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_SILENT_LOGON_OK 0x00000000")]
        public const int URLPOLICY_CREDENTIALS_SILENT_LOGON_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_MUST_PROMPT_USER 0x00010000")]
        public const int URLPOLICY_CREDENTIALS_MUST_PROMPT_USER = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT 0x00020000")]
        public const int URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY 0x00030000")]
        public const int URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY = 0x00030000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CLEARTEXT_OK 0x00000000")]
        public const int URLPOLICY_AUTHENTICATE_CLEARTEXT_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE 0x00010000")]
        public const int URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE = 0x00010000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_MUTUAL_ONLY 0x00030000")]
        public const int URLPOLICY_AUTHENTICATE_MUTUAL_ONLY = 0x00030000;

        [NativeTypeName("#define URLPOLICY_JAVA_PROHIBIT 0x00000000")]
        public const int URLPOLICY_JAVA_PROHIBIT = 0x00000000;

        [NativeTypeName("#define URLPOLICY_JAVA_HIGH 0x00010000")]
        public const int URLPOLICY_JAVA_HIGH = 0x00010000;

        [NativeTypeName("#define URLPOLICY_JAVA_MEDIUM 0x00020000")]
        public const int URLPOLICY_JAVA_MEDIUM = 0x00020000;

        [NativeTypeName("#define URLPOLICY_JAVA_LOW 0x00030000")]
        public const int URLPOLICY_JAVA_LOW = 0x00030000;

        [NativeTypeName("#define URLPOLICY_JAVA_CUSTOM 0x00800000")]
        public const int URLPOLICY_JAVA_CUSTOM = 0x00800000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT 0x00010000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PRECACHE 0x00020000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PRECACHE = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL 0x00030000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL = 0x00030000;

        [NativeTypeName("#define URLPOLICY_BEHAVIOR_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_BEHAVIOR_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLPOLICY_ALLOW 0x00")]
        public const int URLPOLICY_ALLOW = 0x00;

        [NativeTypeName("#define URLPOLICY_QUERY 0x01")]
        public const int URLPOLICY_QUERY = 0x01;

        [NativeTypeName("#define URLPOLICY_DISALLOW 0x03")]
        public const int URLPOLICY_DISALLOW = 0x03;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_ALLOW 0x10")]
        public const int URLPOLICY_NOTIFY_ON_ALLOW = 0x10;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_DISALLOW 0x20")]
        public const int URLPOLICY_NOTIFY_ON_DISALLOW = 0x20;

        [NativeTypeName("#define URLPOLICY_LOG_ON_ALLOW 0x40")]
        public const int URLPOLICY_LOG_ON_ALLOW = 0x40;

        [NativeTypeName("#define URLPOLICY_LOG_ON_DISALLOW 0x80")]
        public const int URLPOLICY_LOG_ON_DISALLOW = 0x80;

        [NativeTypeName("#define URLPOLICY_MASK_PERMISSIONS 0x0f")]
        public const int URLPOLICY_MASK_PERMISSIONS = 0x0f;

        [NativeTypeName("#define URLPOLICY_DONTCHECKDLGBOX 0x100")]
        public const int URLPOLICY_DONTCHECKDLGBOX = 0x100;

        [NativeTypeName("#define URLZONE_ESC_FLAG 0x100")]
        public const int URLZONE_ESC_FLAG = 0x100;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_EMAIL 0x00000001")]
        public const int SOFTDIST_FLAG_USAGE_EMAIL = 0x00000001;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_PRECACHE 0x00000002")]
        public const int SOFTDIST_FLAG_USAGE_PRECACHE = 0x00000002;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_AUTOINSTALL 0x00000004")]
        public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 0x00000004;

        [NativeTypeName("#define SOFTDIST_FLAG_DELETE_SUBSCRIPTION 0x00000008")]
        public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 0x00000008;

        [NativeTypeName("#define SOFTDIST_ADSTATE_NONE 0x00000000")]
        public const int SOFTDIST_ADSTATE_NONE = 0x00000000;

        [NativeTypeName("#define SOFTDIST_ADSTATE_AVAILABLE 0x00000001")]
        public const int SOFTDIST_ADSTATE_AVAILABLE = 0x00000001;

        [NativeTypeName("#define SOFTDIST_ADSTATE_DOWNLOADED 0x00000002")]
        public const int SOFTDIST_ADSTATE_DOWNLOADED = 0x00000002;

        [NativeTypeName("#define SOFTDIST_ADSTATE_INSTALLED 0x00000003")]
        public const int SOFTDIST_ADSTATE_INSTALLED = 0x00000003;

        [NativeTypeName("#define IsLoggingEnabled IsLoggingEnabledW")]
        public static delegate*<ushort*, BOOL> IsLoggingEnabled => &IsLoggingEnabledW;

        [NativeTypeName("#define CONFIRMSAFETYACTION_LOADOBJECT 0x00000001")]
        public const int CONFIRMSAFETYACTION_LOADOBJECT = 0x00000001;
    }
}
