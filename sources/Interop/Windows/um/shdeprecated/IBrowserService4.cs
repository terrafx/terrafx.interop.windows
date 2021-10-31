// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("639F1BFF-E135-4096-ABD8-E0F504D649A4")]
    [NativeTypeName("struct IBrowserService4 : IBrowserService3")]
    [NativeInheritance("IBrowserService3")]
    public unsafe partial struct IBrowserService4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBrowserService4*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBrowserService4*, uint>)(lpVtbl[1]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBrowserService4*, uint>)(lpVtbl[2]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentSite(IOleInPlaceSite** ppipsite)
        {
            return ((delegate* unmanaged<IBrowserService4*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService4*)Unsafe.AsPointer(ref this), ppipsite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService4*)Unsafe.AsPointer(ref this), psv, pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService4*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetOleObject(IOleObject** ppobjv)
        {
            return ((delegate* unmanaged<IBrowserService4*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService4*)Unsafe.AsPointer(ref this), ppobjv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetTravelLog(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService4*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ShowControlWindow([NativeTypeName("UINT")] uint id, BOOL fShow)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, BOOL, int>)(lpVtbl[8]))((IBrowserService4*)Unsafe.AsPointer(ref this), id, fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsControlWindowShown([NativeTypeName("UINT")] uint id, BOOL* pfShown)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, BOOL*, int>)(lpVtbl[9]))((IBrowserService4*)Unsafe.AsPointer(ref this), id, pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int IEParseDisplayName([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService4*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayParseError([NativeTypeName("HRESULT")] int hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
        {
            return ((delegate* unmanaged<IBrowserService4*, int, ushort*, int>)(lpVtbl[12]))((IBrowserService4*)Unsafe.AsPointer(ref this), hres, pwszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetNavigateState(BNSTATE bnstate)
        {
            return ((delegate* unmanaged<IBrowserService4*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService4*)Unsafe.AsPointer(ref this), bnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetNavigateState(BNSTATE* pbnstate)
        {
            return ((delegate* unmanaged<IBrowserService4*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService4*)Unsafe.AsPointer(ref this), pbnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, ITEMIDLIST*, BOOL*, int>)(lpVtbl[16]))((IBrowserService4*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateWindowList()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[17]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateBackForwardState()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[18]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, uint, int>)(lpVtbl[19]))((IBrowserService4*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint*, int>)(lpVtbl[20]))((IBrowserService4*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CanNavigateNow()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[21]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService4*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint GetBrowserIndex()
        {
            return ((delegate* unmanaged<IBrowserService4*, uint>)(lpVtbl[24]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService4*)Unsafe.AsPointer(ref this), dwID, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
        {
            return ((delegate* unmanaged<IBrowserService4*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService4*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor)
        {
            return ((delegate* unmanaged<IBrowserService4*, IOleObject*, BOOL, int>)(lpVtbl[27]))((IBrowserService4*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CacheOLEServer(IOleObject* pole)
        {
            return ((delegate* unmanaged<IBrowserService4*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService4*)Unsafe.AsPointer(ref this), pole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IBrowserService4*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService4*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, BOOL, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService4*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("HPALETTE *")] IntPtr* hpal)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr*, int>)(lpVtbl[31]))((IBrowserService4*)Unsafe.AsPointer(ref this), hpal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWindow(BOOL fForceRegister, int swc)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int, int>)(lpVtbl[32]))((IBrowserService4*)Unsafe.AsPointer(ref this), fForceRegister, swc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("LRESULT")]
        public nint WndProcBS([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr, uint, nuint, nint, nint>)(lpVtbl[33]))((IBrowserService4*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int SetAsDefFolderSettings()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[34]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService4*, RECT*, int>)(lpVtbl[35]))((IBrowserService4*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int OnSize([NativeTypeName("WPARAM")] nuint wParam)
        {
            return ((delegate* unmanaged<IBrowserService4*, nuint, int>)(lpVtbl[36]))((IBrowserService4*)Unsafe.AsPointer(ref this), wParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int OnCreate([NativeTypeName("struct tagCREATESTRUCTW *")] CREATESTRUCTW* pcs)
        {
            return ((delegate* unmanaged<IBrowserService4*, CREATESTRUCTW*, int>)(lpVtbl[37]))((IBrowserService4*)Unsafe.AsPointer(ref this), pcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("LRESULT")]
        public nint OnCommand([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService4*, nuint, nint, nint>)(lpVtbl[38]))((IBrowserService4*)Unsafe.AsPointer(ref this), wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int OnDestroy()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[39]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("LRESULT")]
        public nint OnNotify([NativeTypeName("struct tagNMHDR *")] NMHDR* pnm)
        {
            return ((delegate* unmanaged<IBrowserService4*, NMHDR*, nint>)(lpVtbl[40]))((IBrowserService4*)Unsafe.AsPointer(ref this), pnm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetFocus()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[41]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int OnFrameWindowActivateBS(BOOL fActive)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[42]))((IBrowserService4*)Unsafe.AsPointer(ref this), fActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseShellView()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[43]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int ActivatePendingView()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[44]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewWindow(IShellView* psvNew, IShellView* psvOld, [NativeTypeName("LPRECT")] RECT* prcView, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, IShellView*, RECT*, IntPtr*, int>)(lpVtbl[45]))((IBrowserService4*)Unsafe.AsPointer(ref this), psvNew, psvOld, prcView, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBrowserPropSheetExt([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IBrowserService4*, Guid*, void**, int>)(lpVtbl[46]))((IBrowserService4*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewWindow([NativeTypeName("HWND *")] IntPtr* phwndView)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr*, int>)(lpVtbl[47]))((IBrowserService4*)Unsafe.AsPointer(ref this), phwndView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetBaseBrowserData([NativeTypeName("LPCBASEBROWSERDATA *")] BASEBROWSERDATA** pbbd)
        {
            return ((delegate* unmanaged<IBrowserService4*, BASEBROWSERDATA**, int>)(lpVtbl[48]))((IBrowserService4*)Unsafe.AsPointer(ref this), pbbd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("LPBASEBROWSERDATA")]
        public BASEBROWSERDATA* PutBaseBrowserData()
        {
            return ((delegate* unmanaged<IBrowserService4*, BASEBROWSERDATA*>)(lpVtbl[49]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTravelLog(ITravelLog* ptl, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITravelLog*, uint, int>)(lpVtbl[50]))((IBrowserService4*)Unsafe.AsPointer(ref this), ptl, dw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopBrowser()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[51]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int Offline(int iCmd)
        {
            return ((delegate* unmanaged<IBrowserService4*, int, int>)(lpVtbl[52]))((IBrowserService4*)Unsafe.AsPointer(ref this), iCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int AllowViewResize(BOOL f)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[53]))((IBrowserService4*)Unsafe.AsPointer(ref this), f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int SetActivateState([NativeTypeName("UINT")] uint u)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, int>)(lpVtbl[54]))((IBrowserService4*)Unsafe.AsPointer(ref this), u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSecureLockIcon(int eSecureLock)
        {
            return ((delegate* unmanaged<IBrowserService4*, int, int>)(lpVtbl[55]))((IBrowserService4*)Unsafe.AsPointer(ref this), eSecureLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeDownloadManager()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[56]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTransitionSite()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[57]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int _Initialize([NativeTypeName("HWND")] IntPtr hwnd, IUnknown* pauto)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr, IUnknown*, int>)(lpVtbl[58]))((IBrowserService4*)Unsafe.AsPointer(ref this), hwnd, pauto);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int _CancelPendingNavigationAsync()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[59]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int _CancelPendingView()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[60]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int _MaySaveChanges()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[61]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int _PauseOrResumeView(BOOL fPaused)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[62]))((IBrowserService4*)Unsafe.AsPointer(ref this), fPaused);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int _DisableModeless()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[63]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int _NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, uint, uint, int>)(lpVtbl[64]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl, grfHLNF, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int _TryShell2Rename(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
        {
            return ((delegate* unmanaged<IBrowserService4*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[65]))((IBrowserService4*)Unsafe.AsPointer(ref this), psv, pidlNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int _SwitchActivationNow()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[66]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int _ExecChildren(IUnknown* punkBar, BOOL fBroadcast, [NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargIn, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService4*, IUnknown*, BOOL, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(lpVtbl[67]))((IBrowserService4*)Unsafe.AsPointer(ref this), punkBar, fBroadcast, pguidCmdGroup, nCmdID, nCmdexecopt, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int _SendChildren([NativeTypeName("HWND")] IntPtr hwndBar, BOOL fBroadcast, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr, BOOL, uint, nuint, nint, int>)(lpVtbl[68]))((IBrowserService4*)Unsafe.AsPointer(ref this), hwndBar, fBroadcast, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderSetData([NativeTypeName("struct tagFolderSetData *")] FOLDERSETDATA* pfsd)
        {
            return ((delegate* unmanaged<IBrowserService4*, FOLDERSETDATA*, int>)(lpVtbl[69]))((IBrowserService4*)Unsafe.AsPointer(ref this), pfsd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int _OnFocusChange([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, int>)(lpVtbl[70]))((IBrowserService4*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int v_ShowHideChildWindows(BOOL fChildOnly)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[71]))((IBrowserService4*)Unsafe.AsPointer(ref this), fChildOnly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("UINT")]
        public uint _get_itbLastFocus()
        {
            return ((delegate* unmanaged<IBrowserService4*, uint>)(lpVtbl[72]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int _put_itbLastFocus([NativeTypeName("UINT")] uint itbLastFocus)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, int>)(lpVtbl[73]))((IBrowserService4*)Unsafe.AsPointer(ref this), itbLastFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int _UIActivateView([NativeTypeName("UINT")] uint uState)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, int>)(lpVtbl[74]))((IBrowserService4*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int _GetViewBorderRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService4*, RECT*, int>)(lpVtbl[75]))((IBrowserService4*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int _UpdateViewRectSize()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[76]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeNextBorder([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, int>)(lpVtbl[77]))((IBrowserService4*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeView()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[78]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int _GetEffectiveClientArea([NativeTypeName("LPRECT")] RECT* lprectBorder, [NativeTypeName("HMONITOR")] IntPtr hmon)
        {
            return ((delegate* unmanaged<IBrowserService4*, RECT*, IntPtr, int>)(lpVtbl[79]))((IBrowserService4*)Unsafe.AsPointer(ref this), lprectBorder, hmon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public IStream* v_GetViewStream([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, uint, ushort*, IStream*>)(lpVtbl[80]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl, grfMode, pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("LRESULT")]
        public nint ForwardViewMsg([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, nuint, nint, nint>)(lpVtbl[81]))((IBrowserService4*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int SetAcceleratorMenu([NativeTypeName("HACCEL")] IntPtr hacc)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr, int>)(lpVtbl[82]))((IBrowserService4*)Unsafe.AsPointer(ref this), hacc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public int _GetToolbarCount()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[83]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("LPTOOLBARITEM")]
        public TOOLBARITEM* _GetToolbarItem(int itb)
        {
            return ((delegate* unmanaged<IBrowserService4*, int, TOOLBARITEM*>)(lpVtbl[84]))((IBrowserService4*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int _SaveToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService4*, IStream*, int>)(lpVtbl[85]))((IBrowserService4*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int _LoadToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService4*, IStream*, int>)(lpVtbl[86]))((IBrowserService4*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int _CloseAndReleaseToolbars(BOOL fClose)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[87]))((IBrowserService4*)Unsafe.AsPointer(ref this), fClose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int v_MayGetNextToolbarFocus([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("UINT")] uint itbNext, int citb, [NativeTypeName("LPTOOLBARITEM *")] TOOLBARITEM** pptbi, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService4*, MSG*, uint, int, TOOLBARITEM**, IntPtr*, int>)(lpVtbl[88]))((IBrowserService4*)Unsafe.AsPointer(ref this), lpMsg, itbNext, citb, pptbi, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeNextBorderHelper([NativeTypeName("UINT")] uint itb, BOOL bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, BOOL, int>)(lpVtbl[89]))((IBrowserService4*)Unsafe.AsPointer(ref this), itb, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("UINT")]
        public uint _FindTBar(IUnknown* punkSrc)
        {
            return ((delegate* unmanaged<IBrowserService4*, IUnknown*, uint>)(lpVtbl[90]))((IBrowserService4*)Unsafe.AsPointer(ref this), punkSrc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int _SetFocus([NativeTypeName("LPTOOLBARITEM")] TOOLBARITEM* ptbi, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPMSG")] MSG* lpMsg)
        {
            return ((delegate* unmanaged<IBrowserService4*, TOOLBARITEM*, IntPtr, MSG*, int>)(lpVtbl[91]))((IBrowserService4*)Unsafe.AsPointer(ref this), ptbi, hwnd, lpMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int v_MayTranslateAccelerator(MSG* pmsg)
        {
            return ((delegate* unmanaged<IBrowserService4*, MSG*, int>)(lpVtbl[92]))((IBrowserService4*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int _GetBorderDWHelper(IUnknown* punkSrc, [NativeTypeName("LPRECT")] RECT* lprectBorder, BOOL bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService4*, IUnknown*, RECT*, BOOL, int>)(lpVtbl[93]))((IBrowserService4*)Unsafe.AsPointer(ref this), punkSrc, lprectBorder, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int v_CheckZoneCrossing([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService4*, ITEMIDLIST*, int>)(lpVtbl[94]))((IBrowserService4*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int _PositionViewWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService4*, IntPtr, RECT*, int>)(lpVtbl[95]))((IBrowserService4*)Unsafe.AsPointer(ref this), hwnd, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int IEParseDisplayNameEx([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService4*, uint, ushort*, uint, ITEMIDLIST**, int>)(lpVtbl[96]))((IBrowserService4*)Unsafe.AsPointer(ref this), uiCP, pwszPath, dwFlags, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateView(BOOL fPendingView)
        {
            return ((delegate* unmanaged<IBrowserService4*, BOOL, int>)(lpVtbl[97]))((IBrowserService4*)Unsafe.AsPointer(ref this), fPendingView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int SaveViewState()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[98]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeAllBorders()
        {
            return ((delegate* unmanaged<IBrowserService4*, int>)(lpVtbl[99]))((IBrowserService4*)Unsafe.AsPointer(ref this));
        }
    }
}
