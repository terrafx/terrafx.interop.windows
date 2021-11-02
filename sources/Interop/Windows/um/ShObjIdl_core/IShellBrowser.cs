// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E2-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellBrowser : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IShellBrowser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellBrowser*, Guid*, void**, int>)(lpVtbl[0]))((IShellBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellBrowser*, uint>)(lpVtbl[1]))((IShellBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellBrowser*, uint>)(lpVtbl[2]))((IShellBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IShellBrowser*, HWND*, int>)(lpVtbl[3]))((IShellBrowser*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IShellBrowser*, BOOL, int>)(lpVtbl[4]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InsertMenusSB(HMENU hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths)
        {
            return ((delegate* unmanaged<IShellBrowser*, HMENU, OLEMENUGROUPWIDTHS*, int>)(lpVtbl[5]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetMenuSB(HMENU hmenuShared, [NativeTypeName("HOLEMENU")] HGLOBAL holemenuRes, HWND hwndActiveObject)
        {
            return ((delegate* unmanaged<IShellBrowser*, HMENU, HGLOBAL, HWND, int>)(lpVtbl[6]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, holemenuRes, hwndActiveObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveMenusSB(HMENU hmenuShared)
        {
            return ((delegate* unmanaged<IShellBrowser*, HMENU, int>)(lpVtbl[7]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetStatusTextSB([NativeTypeName("LPCWSTR")] ushort* pszStatusText)
        {
            return ((delegate* unmanaged<IShellBrowser*, ushort*, int>)(lpVtbl[8]))((IShellBrowser*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnableModelessSB(BOOL fEnable)
        {
            return ((delegate* unmanaged<IShellBrowser*, BOOL, int>)(lpVtbl[9]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT TranslateAcceleratorSB(MSG* pmsg, [NativeTypeName("WORD")] ushort wID)
        {
            return ((delegate* unmanaged<IShellBrowser*, MSG*, ushort, int>)(lpVtbl[10]))((IShellBrowser*)Unsafe.AsPointer(ref this), pmsg, wID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT BrowseObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint wFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, ITEMIDLIST*, uint, int>)(lpVtbl[11]))((IShellBrowser*)Unsafe.AsPointer(ref this), pidl, wFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetViewStateStream([NativeTypeName("DWORD")] uint grfMode, IStream** ppStrm)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, IStream**, int>)(lpVtbl[12]))((IShellBrowser*)Unsafe.AsPointer(ref this), grfMode, ppStrm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetControlWindow(uint id, HWND* phwnd)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, HWND*, int>)(lpVtbl[13]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SendControlMsg(uint id, uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* pret)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, uint, WPARAM, LPARAM, LRESULT*, int>)(lpVtbl[14]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, uMsg, wParam, lParam, pret);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT QueryActiveShellView(IShellView** ppshv)
        {
            return ((delegate* unmanaged<IShellBrowser*, IShellView**, int>)(lpVtbl[15]))((IShellBrowser*)Unsafe.AsPointer(ref this), ppshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT OnViewWindowActive(IShellView* pshv)
        {
            return ((delegate* unmanaged<IShellBrowser*, IShellView*, int>)(lpVtbl[16]))((IShellBrowser*)Unsafe.AsPointer(ref this), pshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetToolbarItems([NativeTypeName("LPTBBUTTONSB")] void* lpButtons, uint nButtons, uint uFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, void*, uint, uint, int>)(lpVtbl[17]))((IShellBrowser*)Unsafe.AsPointer(ref this), lpButtons, nButtons, uFlags);
        }
    }
}
