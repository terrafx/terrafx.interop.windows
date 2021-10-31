// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27D7CE21-762D-48F3-86F3-40E2FD3749C4")]
    [NativeTypeName("struct IBrowserService3 : IBrowserService2")]
    [NativeInheritance("IBrowserService2")]
    public unsafe partial struct IBrowserService3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBrowserService3*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBrowserService3*, uint>)(lpVtbl[1]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBrowserService3*, uint>)(lpVtbl[2]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetParentSite(IOleInPlaceSite** ppipsite)
        {
            return ((delegate* unmanaged<IBrowserService3*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService3*)Unsafe.AsPointer(ref this), ppipsite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService3*)Unsafe.AsPointer(ref this), psv, pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService3*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetOleObject(IOleObject** ppobjv)
        {
            return ((delegate* unmanaged<IBrowserService3*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService3*)Unsafe.AsPointer(ref this), ppobjv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetTravelLog(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService3*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ShowControlWindow([NativeTypeName("UINT")] uint id, BOOL fShow)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, BOOL, int>)(lpVtbl[8]))((IBrowserService3*)Unsafe.AsPointer(ref this), id, fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsControlWindowShown([NativeTypeName("UINT")] uint id, BOOL* pfShown)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, BOOL*, int>)(lpVtbl[9]))((IBrowserService3*)Unsafe.AsPointer(ref this), id, pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT IEParseDisplayName([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService3*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DisplayParseError(HRESULT hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
        {
            return ((delegate* unmanaged<IBrowserService3*, HRESULT, ushort*, int>)(lpVtbl[12]))((IBrowserService3*)Unsafe.AsPointer(ref this), hres, pwszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetNavigateState(BNSTATE bnstate)
        {
            return ((delegate* unmanaged<IBrowserService3*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService3*)Unsafe.AsPointer(ref this), bnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetNavigateState(BNSTATE* pbnstate)
        {
            return ((delegate* unmanaged<IBrowserService3*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService3*)Unsafe.AsPointer(ref this), pbnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, ITEMIDLIST*, BOOL*, int>)(lpVtbl[16]))((IBrowserService3*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT UpdateWindowList()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[17]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT UpdateBackForwardState()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[18]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, uint, int>)(lpVtbl[19]))((IBrowserService3*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint*, int>)(lpVtbl[20]))((IBrowserService3*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CanNavigateNow()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[21]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService3*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint GetBrowserIndex()
        {
            return ((delegate* unmanaged<IBrowserService3*, uint>)(lpVtbl[24]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService3*)Unsafe.AsPointer(ref this), dwID, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
        {
            return ((delegate* unmanaged<IBrowserService3*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService3*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor)
        {
            return ((delegate* unmanaged<IBrowserService3*, IOleObject*, BOOL, int>)(lpVtbl[27]))((IBrowserService3*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT CacheOLEServer(IOleObject* pole)
        {
            return ((delegate* unmanaged<IBrowserService3*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService3*)Unsafe.AsPointer(ref this), pole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IBrowserService3*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService3*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, BOOL, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService3*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetPalette(HPALETTE* hpal)
        {
            return ((delegate* unmanaged<IBrowserService3*, HPALETTE*, int>)(lpVtbl[31]))((IBrowserService3*)Unsafe.AsPointer(ref this), hpal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT RegisterWindow(BOOL fForceRegister, int swc)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int, int>)(lpVtbl[32]))((IBrowserService3*)Unsafe.AsPointer(ref this), fForceRegister, swc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("LRESULT")]
        public nint WndProcBS(HWND hwnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService3*, HWND, uint, nuint, nint, nint>)(lpVtbl[33]))((IBrowserService3*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetAsDefFolderSettings()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[34]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetViewRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService3*, RECT*, int>)(lpVtbl[35]))((IBrowserService3*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT OnSize([NativeTypeName("WPARAM")] nuint wParam)
        {
            return ((delegate* unmanaged<IBrowserService3*, nuint, int>)(lpVtbl[36]))((IBrowserService3*)Unsafe.AsPointer(ref this), wParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT OnCreate([NativeTypeName("struct tagCREATESTRUCTW *")] CREATESTRUCTW* pcs)
        {
            return ((delegate* unmanaged<IBrowserService3*, CREATESTRUCTW*, int>)(lpVtbl[37]))((IBrowserService3*)Unsafe.AsPointer(ref this), pcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("LRESULT")]
        public nint OnCommand([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService3*, nuint, nint, nint>)(lpVtbl[38]))((IBrowserService3*)Unsafe.AsPointer(ref this), wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT OnDestroy()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[39]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("LRESULT")]
        public nint OnNotify([NativeTypeName("struct tagNMHDR *")] NMHDR* pnm)
        {
            return ((delegate* unmanaged<IBrowserService3*, NMHDR*, nint>)(lpVtbl[40]))((IBrowserService3*)Unsafe.AsPointer(ref this), pnm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT OnSetFocus()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[41]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT OnFrameWindowActivateBS(BOOL fActive)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int>)(lpVtbl[42]))((IBrowserService3*)Unsafe.AsPointer(ref this), fActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT ReleaseShellView()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[43]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT ActivatePendingView()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[44]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT CreateViewWindow(IShellView* psvNew, IShellView* psvOld, [NativeTypeName("LPRECT")] RECT* prcView, HWND* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, IShellView*, RECT*, HWND*, int>)(lpVtbl[45]))((IBrowserService3*)Unsafe.AsPointer(ref this), psvNew, psvOld, prcView, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT CreateBrowserPropSheetExt([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IBrowserService3*, Guid*, void**, int>)(lpVtbl[46]))((IBrowserService3*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT GetViewWindow(HWND* phwndView)
        {
            return ((delegate* unmanaged<IBrowserService3*, HWND*, int>)(lpVtbl[47]))((IBrowserService3*)Unsafe.AsPointer(ref this), phwndView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT GetBaseBrowserData([NativeTypeName("LPCBASEBROWSERDATA *")] BASEBROWSERDATA** pbbd)
        {
            return ((delegate* unmanaged<IBrowserService3*, BASEBROWSERDATA**, int>)(lpVtbl[48]))((IBrowserService3*)Unsafe.AsPointer(ref this), pbbd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("LPBASEBROWSERDATA")]
        public BASEBROWSERDATA* PutBaseBrowserData()
        {
            return ((delegate* unmanaged<IBrowserService3*, BASEBROWSERDATA*>)(lpVtbl[49]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT InitializeTravelLog(ITravelLog* ptl, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITravelLog*, uint, int>)(lpVtbl[50]))((IBrowserService3*)Unsafe.AsPointer(ref this), ptl, dw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT SetTopBrowser()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[51]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT Offline(int iCmd)
        {
            return ((delegate* unmanaged<IBrowserService3*, int, int>)(lpVtbl[52]))((IBrowserService3*)Unsafe.AsPointer(ref this), iCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT AllowViewResize(BOOL f)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int>)(lpVtbl[53]))((IBrowserService3*)Unsafe.AsPointer(ref this), f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT SetActivateState([NativeTypeName("UINT")] uint u)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, int>)(lpVtbl[54]))((IBrowserService3*)Unsafe.AsPointer(ref this), u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT UpdateSecureLockIcon(int eSecureLock)
        {
            return ((delegate* unmanaged<IBrowserService3*, int, int>)(lpVtbl[55]))((IBrowserService3*)Unsafe.AsPointer(ref this), eSecureLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT InitializeDownloadManager()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[56]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT InitializeTransitionSite()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[57]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT _Initialize(HWND hwnd, IUnknown* pauto)
        {
            return ((delegate* unmanaged<IBrowserService3*, HWND, IUnknown*, int>)(lpVtbl[58]))((IBrowserService3*)Unsafe.AsPointer(ref this), hwnd, pauto);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT _CancelPendingNavigationAsync()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[59]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT _CancelPendingView()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[60]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT _MaySaveChanges()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[61]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT _PauseOrResumeView(BOOL fPaused)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int>)(lpVtbl[62]))((IBrowserService3*)Unsafe.AsPointer(ref this), fPaused);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT _DisableModeless()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[63]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT _NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, uint, uint, int>)(lpVtbl[64]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl, grfHLNF, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT _TryShell2Rename(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
        {
            return ((delegate* unmanaged<IBrowserService3*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[65]))((IBrowserService3*)Unsafe.AsPointer(ref this), psv, pidlNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT _SwitchActivationNow()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[66]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT _ExecChildren(IUnknown* punkBar, BOOL fBroadcast, [NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargIn, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService3*, IUnknown*, BOOL, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(lpVtbl[67]))((IBrowserService3*)Unsafe.AsPointer(ref this), punkBar, fBroadcast, pguidCmdGroup, nCmdID, nCmdexecopt, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT _SendChildren(HWND hwndBar, BOOL fBroadcast, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService3*, HWND, BOOL, uint, nuint, nint, int>)(lpVtbl[68]))((IBrowserService3*)Unsafe.AsPointer(ref this), hwndBar, fBroadcast, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT GetFolderSetData([NativeTypeName("struct tagFolderSetData *")] FOLDERSETDATA* pfsd)
        {
            return ((delegate* unmanaged<IBrowserService3*, FOLDERSETDATA*, int>)(lpVtbl[69]))((IBrowserService3*)Unsafe.AsPointer(ref this), pfsd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT _OnFocusChange([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, int>)(lpVtbl[70]))((IBrowserService3*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT v_ShowHideChildWindows(BOOL fChildOnly)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int>)(lpVtbl[71]))((IBrowserService3*)Unsafe.AsPointer(ref this), fChildOnly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("UINT")]
        public uint _get_itbLastFocus()
        {
            return ((delegate* unmanaged<IBrowserService3*, uint>)(lpVtbl[72]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT _put_itbLastFocus([NativeTypeName("UINT")] uint itbLastFocus)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, int>)(lpVtbl[73]))((IBrowserService3*)Unsafe.AsPointer(ref this), itbLastFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT _UIActivateView([NativeTypeName("UINT")] uint uState)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, int>)(lpVtbl[74]))((IBrowserService3*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT _GetViewBorderRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService3*, RECT*, int>)(lpVtbl[75]))((IBrowserService3*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT _UpdateViewRectSize()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[76]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT _ResizeNextBorder([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, int>)(lpVtbl[77]))((IBrowserService3*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT _ResizeView()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[78]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT _GetEffectiveClientArea([NativeTypeName("LPRECT")] RECT* lprectBorder, HMONITOR hmon)
        {
            return ((delegate* unmanaged<IBrowserService3*, RECT*, HMONITOR, int>)(lpVtbl[79]))((IBrowserService3*)Unsafe.AsPointer(ref this), lprectBorder, hmon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public IStream* v_GetViewStream([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, uint, ushort*, IStream*>)(lpVtbl[80]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl, grfMode, pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("LRESULT")]
        public nint ForwardViewMsg([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, nuint, nint, nint>)(lpVtbl[81]))((IBrowserService3*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT SetAcceleratorMenu(HACCEL hacc)
        {
            return ((delegate* unmanaged<IBrowserService3*, HACCEL, int>)(lpVtbl[82]))((IBrowserService3*)Unsafe.AsPointer(ref this), hacc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public int _GetToolbarCount()
        {
            return ((delegate* unmanaged<IBrowserService3*, int>)(lpVtbl[83]))((IBrowserService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("LPTOOLBARITEM")]
        public TOOLBARITEM* _GetToolbarItem(int itb)
        {
            return ((delegate* unmanaged<IBrowserService3*, int, TOOLBARITEM*>)(lpVtbl[84]))((IBrowserService3*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT _SaveToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService3*, IStream*, int>)(lpVtbl[85]))((IBrowserService3*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT _LoadToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService3*, IStream*, int>)(lpVtbl[86]))((IBrowserService3*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT _CloseAndReleaseToolbars(BOOL fClose)
        {
            return ((delegate* unmanaged<IBrowserService3*, BOOL, int>)(lpVtbl[87]))((IBrowserService3*)Unsafe.AsPointer(ref this), fClose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT v_MayGetNextToolbarFocus([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("UINT")] uint itbNext, int citb, [NativeTypeName("LPTOOLBARITEM *")] TOOLBARITEM** pptbi, HWND* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService3*, MSG*, uint, int, TOOLBARITEM**, HWND*, int>)(lpVtbl[88]))((IBrowserService3*)Unsafe.AsPointer(ref this), lpMsg, itbNext, citb, pptbi, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT _ResizeNextBorderHelper([NativeTypeName("UINT")] uint itb, BOOL bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, BOOL, int>)(lpVtbl[89]))((IBrowserService3*)Unsafe.AsPointer(ref this), itb, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("UINT")]
        public uint _FindTBar(IUnknown* punkSrc)
        {
            return ((delegate* unmanaged<IBrowserService3*, IUnknown*, uint>)(lpVtbl[90]))((IBrowserService3*)Unsafe.AsPointer(ref this), punkSrc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT _SetFocus([NativeTypeName("LPTOOLBARITEM")] TOOLBARITEM* ptbi, HWND hwnd, [NativeTypeName("LPMSG")] MSG* lpMsg)
        {
            return ((delegate* unmanaged<IBrowserService3*, TOOLBARITEM*, HWND, MSG*, int>)(lpVtbl[91]))((IBrowserService3*)Unsafe.AsPointer(ref this), ptbi, hwnd, lpMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT v_MayTranslateAccelerator(MSG* pmsg)
        {
            return ((delegate* unmanaged<IBrowserService3*, MSG*, int>)(lpVtbl[92]))((IBrowserService3*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT _GetBorderDWHelper(IUnknown* punkSrc, [NativeTypeName("LPRECT")] RECT* lprectBorder, BOOL bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService3*, IUnknown*, RECT*, BOOL, int>)(lpVtbl[93]))((IBrowserService3*)Unsafe.AsPointer(ref this), punkSrc, lprectBorder, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT v_CheckZoneCrossing([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService3*, ITEMIDLIST*, int>)(lpVtbl[94]))((IBrowserService3*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT _PositionViewWindow(HWND hwnd, [NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService3*, HWND, RECT*, int>)(lpVtbl[95]))((IBrowserService3*)Unsafe.AsPointer(ref this), hwnd, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT IEParseDisplayNameEx([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService3*, uint, ushort*, uint, ITEMIDLIST**, int>)(lpVtbl[96]))((IBrowserService3*)Unsafe.AsPointer(ref this), uiCP, pwszPath, dwFlags, ppidlOut);
        }
    }
}
