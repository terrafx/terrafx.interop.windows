// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68BD21CC-438B-11D2-A560-00A0C92DBFE8")]
    [NativeTypeName("struct IBrowserService2 : IBrowserService")]
    public unsafe partial struct IBrowserService2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBrowserService2*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[1]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[2]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentSite(IOleInPlaceSite** ppipsite)
        {
            return ((delegate* unmanaged<IBrowserService2*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppipsite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOleObject(IOleObject** ppobjv)
        {
            return ((delegate* unmanaged<IBrowserService2*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppobjv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTravelLog(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService2*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowControlWindow([NativeTypeName("UINT")] uint id, [NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int, int>)(lpVtbl[8]))((IBrowserService2*)Unsafe.AsPointer(ref this), id, fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsControlWindowShown([NativeTypeName("UINT")] uint id, [NativeTypeName("BOOL *")] int* pfShown)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int*, int>)(lpVtbl[9]))((IBrowserService2*)Unsafe.AsPointer(ref this), id, pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IEParseDisplayName([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService2*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayParseError([NativeTypeName("HRESULT")] int hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, ushort*, int>)(lpVtbl[12]))((IBrowserService2*)Unsafe.AsPointer(ref this), hres, pwszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNavigateState(BNSTATE bnstate)
        {
            return ((delegate* unmanaged<IBrowserService2*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService2*)Unsafe.AsPointer(ref this), bnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNavigateState(BNSTATE* pbnstate)
        {
            return ((delegate* unmanaged<IBrowserService2*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService2*)Unsafe.AsPointer(ref this), pbnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("BOOL *")] int* pfDidBrowse)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, int*, int>)(lpVtbl[16]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateWindowList()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[17]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateBackForwardState()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[18]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, uint, int>)(lpVtbl[19]))((IBrowserService2*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint*, int>)(lpVtbl[20]))((IBrowserService2*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanNavigateNow()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[21]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetBrowserIndex()
        {
            return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[24]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService2*)Unsafe.AsPointer(ref this), dwID, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
        {
            return ((delegate* unmanaged<IBrowserService2*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHistoryObject(IOleObject* pole, [NativeTypeName("BOOL")] int fIsLocalAnchor)
        {
            return ((delegate* unmanaged<IBrowserService2*, IOleObject*, int, int>)(lpVtbl[27]))((IBrowserService2*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CacheOLEServer(IOleObject* pole)
        {
            return ((delegate* unmanaged<IBrowserService2*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService2*)Unsafe.AsPointer(ref this), pole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IBrowserService2*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService2*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnHttpEquiv(IShellView* psv, [NativeTypeName("BOOL")] int fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, int, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("HPALETTE *")] IntPtr* hpal)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr*, int>)(lpVtbl[31]))((IBrowserService2*)Unsafe.AsPointer(ref this), hpal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWindow([NativeTypeName("BOOL")] int fForceRegister, int swc)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int, int>)(lpVtbl[32]))((IBrowserService2*)Unsafe.AsPointer(ref this), fForceRegister, swc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public nint WndProcBS([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr, uint, nuint, nint, nint>)(lpVtbl[33]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAsDefFolderSettings()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[34]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService2*, RECT*, int>)(lpVtbl[35]))((IBrowserService2*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSize([NativeTypeName("WPARAM")] nuint wParam)
        {
            return ((delegate* unmanaged<IBrowserService2*, nuint, int>)(lpVtbl[36]))((IBrowserService2*)Unsafe.AsPointer(ref this), wParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCreate([NativeTypeName("struct tagCREATESTRUCTW *")] CREATESTRUCTW* pcs)
        {
            return ((delegate* unmanaged<IBrowserService2*, CREATESTRUCTW*, int>)(lpVtbl[37]))((IBrowserService2*)Unsafe.AsPointer(ref this), pcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public nint OnCommand([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService2*, nuint, nint, nint>)(lpVtbl[38]))((IBrowserService2*)Unsafe.AsPointer(ref this), wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDestroy()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[39]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public nint OnNotify([NativeTypeName("struct tagNMHDR *")] NMHDR* pnm)
        {
            return ((delegate* unmanaged<IBrowserService2*, NMHDR*, nint>)(lpVtbl[40]))((IBrowserService2*)Unsafe.AsPointer(ref this), pnm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetFocus()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[41]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFrameWindowActivateBS([NativeTypeName("BOOL")] int fActive)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[42]))((IBrowserService2*)Unsafe.AsPointer(ref this), fActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseShellView()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[43]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivatePendingView()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[44]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewWindow(IShellView* psvNew, IShellView* psvOld, [NativeTypeName("LPRECT")] RECT* prcView, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, IShellView*, RECT*, IntPtr*, int>)(lpVtbl[45]))((IBrowserService2*)Unsafe.AsPointer(ref this), psvNew, psvOld, prcView, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBrowserPropSheetExt([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IBrowserService2*, Guid*, void**, int>)(lpVtbl[46]))((IBrowserService2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewWindow([NativeTypeName("HWND *")] IntPtr* phwndView)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr*, int>)(lpVtbl[47]))((IBrowserService2*)Unsafe.AsPointer(ref this), phwndView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBaseBrowserData([NativeTypeName("LPCBASEBROWSERDATA *")] BASEBROWSERDATALH** pbbd)
        {
            return ((delegate* unmanaged<IBrowserService2*, BASEBROWSERDATALH**, int>)(lpVtbl[48]))((IBrowserService2*)Unsafe.AsPointer(ref this), pbbd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPBASEBROWSERDATA")]
        public BASEBROWSERDATALH* PutBaseBrowserData()
        {
            return ((delegate* unmanaged<IBrowserService2*, BASEBROWSERDATALH*>)(lpVtbl[49]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTravelLog(ITravelLog* ptl, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITravelLog*, uint, int>)(lpVtbl[50]))((IBrowserService2*)Unsafe.AsPointer(ref this), ptl, dw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopBrowser()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[51]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Offline(int iCmd)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[52]))((IBrowserService2*)Unsafe.AsPointer(ref this), iCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllowViewResize([NativeTypeName("BOOL")] int f)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[53]))((IBrowserService2*)Unsafe.AsPointer(ref this), f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActivateState([NativeTypeName("UINT")] uint u)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[54]))((IBrowserService2*)Unsafe.AsPointer(ref this), u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSecureLockIcon(int eSecureLock)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[55]))((IBrowserService2*)Unsafe.AsPointer(ref this), eSecureLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeDownloadManager()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[56]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTransitionSite()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[57]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _Initialize([NativeTypeName("HWND")] IntPtr hwnd, IUnknown* pauto)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr, IUnknown*, int>)(lpVtbl[58]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwnd, pauto);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _CancelPendingNavigationAsync()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[59]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _CancelPendingView()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[60]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _MaySaveChanges()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[61]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _PauseOrResumeView([NativeTypeName("BOOL")] int fPaused)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[62]))((IBrowserService2*)Unsafe.AsPointer(ref this), fPaused);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _DisableModeless()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[63]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, uint, int>)(lpVtbl[64]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfHLNF, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _TryShell2Rename(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
        {
            return ((delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[65]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pidlNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _SwitchActivationNow()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[66]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _ExecChildren(IUnknown* punkBar, [NativeTypeName("BOOL")] int fBroadcast, [NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargIn, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService2*, IUnknown*, int, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(lpVtbl[67]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkBar, fBroadcast, pguidCmdGroup, nCmdID, nCmdexecopt, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _SendChildren([NativeTypeName("HWND")] IntPtr hwndBar, [NativeTypeName("BOOL")] int fBroadcast, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr, int, uint, nuint, nint, int>)(lpVtbl[68]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwndBar, fBroadcast, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderSetData([NativeTypeName("struct tagFolderSetData *")] tagFolderSetData* pfsd)
        {
            return ((delegate* unmanaged<IBrowserService2*, tagFolderSetData*, int>)(lpVtbl[69]))((IBrowserService2*)Unsafe.AsPointer(ref this), pfsd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _OnFocusChange([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[70]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int v_ShowHideChildWindows([NativeTypeName("BOOL")] int fChildOnly)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[71]))((IBrowserService2*)Unsafe.AsPointer(ref this), fChildOnly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint _get_itbLastFocus()
        {
            return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[72]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _put_itbLastFocus([NativeTypeName("UINT")] uint itbLastFocus)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[73]))((IBrowserService2*)Unsafe.AsPointer(ref this), itbLastFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _UIActivateView([NativeTypeName("UINT")] uint uState)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[74]))((IBrowserService2*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _GetViewBorderRect(RECT* prc)
        {
            return ((delegate* unmanaged<IBrowserService2*, RECT*, int>)(lpVtbl[75]))((IBrowserService2*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _UpdateViewRectSize()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[76]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeNextBorder([NativeTypeName("UINT")] uint itb)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[77]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeView()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[78]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _GetEffectiveClientArea([NativeTypeName("LPRECT")] RECT* lprectBorder, [NativeTypeName("HMONITOR")] IntPtr hmon)
        {
            return ((delegate* unmanaged<IBrowserService2*, RECT*, IntPtr, int>)(lpVtbl[79]))((IBrowserService2*)Unsafe.AsPointer(ref this), lprectBorder, hmon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IStream* v_GetViewStream([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, ushort*, IStream*>)(lpVtbl[80]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfMode, pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public nint ForwardViewMsg([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, nuint, nint, nint>)(lpVtbl[81]))((IBrowserService2*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAcceleratorMenu([NativeTypeName("HACCEL")] IntPtr hacc)
        {
            return ((delegate* unmanaged<IBrowserService2*, IntPtr, int>)(lpVtbl[82]))((IBrowserService2*)Unsafe.AsPointer(ref this), hacc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int _GetToolbarCount()
        {
            return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[83]))((IBrowserService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPTOOLBARITEM")]
        public SToolbarItem* _GetToolbarItem(int itb)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, SToolbarItem*>)(lpVtbl[84]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _SaveToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService2*, IStream*, int>)(lpVtbl[85]))((IBrowserService2*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _LoadToolbars(IStream* pstm)
        {
            return ((delegate* unmanaged<IBrowserService2*, IStream*, int>)(lpVtbl[86]))((IBrowserService2*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _CloseAndReleaseToolbars([NativeTypeName("BOOL")] int fClose)
        {
            return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[87]))((IBrowserService2*)Unsafe.AsPointer(ref this), fClose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int v_MayGetNextToolbarFocus([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("UINT")] uint itbNext, int citb, [NativeTypeName("LPTOOLBARITEM *")] SToolbarItem** pptbi, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IBrowserService2*, MSG*, uint, int, SToolbarItem**, IntPtr*, int>)(lpVtbl[88]))((IBrowserService2*)Unsafe.AsPointer(ref this), lpMsg, itbNext, citb, pptbi, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _ResizeNextBorderHelper([NativeTypeName("UINT")] uint itb, [NativeTypeName("BOOL")] int bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService2*, uint, int, int>)(lpVtbl[89]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint _FindTBar(IUnknown* punkSrc)
        {
            return ((delegate* unmanaged<IBrowserService2*, IUnknown*, uint>)(lpVtbl[90]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkSrc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _SetFocus([NativeTypeName("LPTOOLBARITEM")] SToolbarItem* ptbi, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPMSG")] MSG* lpMsg)
        {
            return ((delegate* unmanaged<IBrowserService2*, SToolbarItem*, IntPtr, MSG*, int>)(lpVtbl[91]))((IBrowserService2*)Unsafe.AsPointer(ref this), ptbi, hwnd, lpMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int v_MayTranslateAccelerator(MSG* pmsg)
        {
            return ((delegate* unmanaged<IBrowserService2*, MSG*, int>)(lpVtbl[92]))((IBrowserService2*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _GetBorderDWHelper(IUnknown* punkSrc, [NativeTypeName("LPRECT")] RECT* lprectBorder, [NativeTypeName("BOOL")] int bUseHmonitor)
        {
            return ((delegate* unmanaged<IBrowserService2*, IUnknown*, RECT*, int, int>)(lpVtbl[93]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkSrc, lprectBorder, bUseHmonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int v_CheckZoneCrossing([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int>)(lpVtbl[94]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl);
        }
    }
}
