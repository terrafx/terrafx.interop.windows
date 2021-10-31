// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("02BA3B52-0547-11D1-B833-00C04FC9B31F")]
    [NativeTypeName("struct IBrowserService : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBrowserService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBrowserService*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[1]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[2]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentSite(IOleInPlaceSite** ppipsite)
        {
            return ((delegate* unmanaged<IBrowserService*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService*)Unsafe.AsPointer(ref this), ppipsite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IBrowserService*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
        {
            return ((delegate* unmanaged<IBrowserService*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetOleObject(IOleObject** ppobjv)
        {
            return ((delegate* unmanaged<IBrowserService*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService*)Unsafe.AsPointer(ref this), ppobjv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetTravelLog(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<IBrowserService*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ShowControlWindow([NativeTypeName("UINT")] uint id, BOOL fShow)
        {
            return ((delegate* unmanaged<IBrowserService*, uint, BOOL, int>)(lpVtbl[8]))((IBrowserService*)Unsafe.AsPointer(ref this), id, fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsControlWindowShown([NativeTypeName("UINT")] uint id, BOOL* pfShown)
        {
            return ((delegate* unmanaged<IBrowserService*, uint, BOOL*, int>)(lpVtbl[9]))((IBrowserService*)Unsafe.AsPointer(ref this), id, pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int IEParseDisplayName([NativeTypeName("UINT")] uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IBrowserService*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayParseError([NativeTypeName("HRESULT")] int hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
        {
            return ((delegate* unmanaged<IBrowserService*, int, ushort*, int>)(lpVtbl[12]))((IBrowserService*)Unsafe.AsPointer(ref this), hres, pwszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
        {
            return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetNavigateState(BNSTATE bnstate)
        {
            return ((delegate* unmanaged<IBrowserService*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService*)Unsafe.AsPointer(ref this), bnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetNavigateState(BNSTATE* pbnstate)
        {
            return ((delegate* unmanaged<IBrowserService*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService*)Unsafe.AsPointer(ref this), pbnstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse)
        {
            return ((delegate* unmanaged<IBrowserService*, IShellView*, ITEMIDLIST*, BOOL*, int>)(lpVtbl[16]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateWindowList()
        {
            return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[17]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateBackForwardState()
        {
            return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[18]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
        {
            return ((delegate* unmanaged<IBrowserService*, uint, uint, int>)(lpVtbl[19]))((IBrowserService*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IBrowserService*, uint*, int>)(lpVtbl[20]))((IBrowserService*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CanNavigateNow()
        {
            return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[21]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint GetBrowserIndex()
        {
            return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[24]))((IBrowserService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IBrowserService*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService*)Unsafe.AsPointer(ref this), dwID, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
        {
            return ((delegate* unmanaged<IBrowserService*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor)
        {
            return ((delegate* unmanaged<IBrowserService*, IOleObject*, BOOL, int>)(lpVtbl[27]))((IBrowserService*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CacheOLEServer(IOleObject* pole)
        {
            return ((delegate* unmanaged<IBrowserService*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService*)Unsafe.AsPointer(ref this), pole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IBrowserService*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
        {
            return ((delegate* unmanaged<IBrowserService*, IShellView*, BOOL, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("HPALETTE *")] IntPtr* hpal)
        {
            return ((delegate* unmanaged<IBrowserService*, IntPtr*, int>)(lpVtbl[31]))((IBrowserService*)Unsafe.AsPointer(ref this), hpal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWindow(BOOL fForceRegister, int swc)
        {
            return ((delegate* unmanaged<IBrowserService*, BOOL, int, int>)(lpVtbl[32]))((IBrowserService*)Unsafe.AsPointer(ref this), fForceRegister, swc);
        }
    }
}
