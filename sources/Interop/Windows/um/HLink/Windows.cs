// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromMoniker(IMoniker* pimkTrgt, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromString([NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromData(IDataObject* piDataObj, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkQueryCreateFromData(IDataObject* piDataObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkClone(IHlink* pihl, [NativeTypeName("const IID &")] Guid* riid, IHlinkSite* pihlsiteForClone, [NativeTypeName("DWORD")] uint dwSiteData, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateBrowseContext(IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateToStringReference([NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IHlinkFrame* pihlframe, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pibc, IBindStatusCallback* pibsc, IHlinkBrowseContext* pihlbc);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigate(IHlink* pihl, IHlinkFrame* pihlframe, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pbc, IBindStatusCallback* pibsc, IHlinkBrowseContext* pihlbc);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkOnNavigate(IHlinkFrame* pihlframe, IHlinkBrowseContext* pihlbc, [NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("ULONG *")] uint* puHLID);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkUpdateStackItem(IHlinkFrame* pihlframe, IHlinkBrowseContext* pihlbc, [NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTrgt, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkOnRenameDocument([NativeTypeName("DWORD")] uint dwReserved, IHlinkBrowseContext* pihlbc, IMoniker* pimkOld, IMoniker* pimkNew);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveMonikerForData([NativeTypeName("LPMONIKER")] IMoniker* pimkReference, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("ULONG")] uint cFmtetc, FORMATETC* rgFmtetc, IBindStatusCallback* pibsc, [NativeTypeName("LPMONIKER")] IMoniker* pimkBase);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveStringForData([NativeTypeName("LPCWSTR")] ushort* pwzReference, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("ULONG")] uint cFmtetc, FORMATETC* rgFmtetc, IBindStatusCallback* pibsc, [NativeTypeName("LPMONIKER")] IMoniker* pimkBase);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkParseDisplayName([NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("LPCWSTR")] ushort* pwzDisplayName, [NativeTypeName("BOOL")] int fNoForceAbs, [NativeTypeName("ULONG *")] uint* pcchEaten, IMoniker** ppimk);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateExtensionServices([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders, [NativeTypeName("HWND")] IntPtr phwnd, [NativeTypeName("LPCWSTR")] ushort* pszUsername, [NativeTypeName("LPCWSTR")] ushort* pszPassword, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkPreprocessMoniker([NativeTypeName("LPBC")] IBindCtx* pibc, IMoniker* pimkIn, IMoniker** ppimkOut);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int OleSaveToStreamEx(IUnknown* piunk, IStream* pistm, [NativeTypeName("BOOL")] int fClearDirty);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSetSpecialReference([NativeTypeName("ULONG")] uint uReference, [NativeTypeName("LPCWSTR")] ushort* pwzReference);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGetSpecialReference([NativeTypeName("ULONG")] uint uReference, [NativeTypeName("LPWSTR *")] ushort** ppwzReference);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcut([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, IHlink* pihl, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcutFromMoniker([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcutFromString([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, [NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcut([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcutToMoniker([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, IMoniker** ppimkTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcutToString([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkIsShortcut([NativeTypeName("LPCWSTR")] ushort* pwzFileName);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGetValueFromParams([NativeTypeName("LPCWSTR")] ushort* pwzParams, [NativeTypeName("LPCWSTR")] ushort* pwzName, [NativeTypeName("LPWSTR *")] ushort** ppwzValue);

        [DllImport("Hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkTranslateURL([NativeTypeName("LPCWSTR")] ushort* pwzURL, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzTranslatedURL);

        [NativeTypeName("#define SID_SHlinkFrame IID_IHlinkFrame")]
        public static readonly Guid SID_SHlinkFrame = IID_IHlinkFrame;

        [NativeTypeName("#define IID_IHlinkSource IID_IHlinkTarget")]
        public static readonly Guid IID_IHlinkSource = IID_IHlinkTarget;

        [NativeTypeName("#define HLINK_E_FIRST (OLE_E_LAST+1)")]
        public const int HLINK_E_FIRST = unchecked(((int)(0x800400FF)) + 1);

        [NativeTypeName("#define HLINK_S_FIRST (OLE_S_LAST+1)")]
        public const int HLINK_S_FIRST = (((int)(0x000400FF)) + 1);

        [NativeTypeName("#define HLINK_S_DONTHIDE (HLINK_S_FIRST)")]
        public const int HLINK_S_DONTHIDE = ((((int)(0x000400FF)) + 1));

        [NativeTypeName("#define CFSTR_HYPERLINK (TEXT(\"Hyperlink\"))")]
        public const string CFSTR_HYPERLINK = ("Hyperlink");

        public static readonly Guid IID_IHlink = new Guid(0x79EAC9C3, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IHlinkSite = new Guid(0x79EAC9C2, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IHlinkTarget = new Guid(0x79EAC9C4, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IHlinkFrame = new Guid(0x79EAC9C5, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IEnumHLITEM = new Guid(0x79EAC9C6, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IHlinkBrowseContext = new Guid(0x79EAC9C7, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);

        public static readonly Guid IID_IExtensionServices = new Guid(0x79EAC9CB, 0xBAF9, 0x11CE, 0x8C, 0x82, 0x00, 0xAA, 0x00, 0x4B, 0xA9, 0x0B);
    }
}
