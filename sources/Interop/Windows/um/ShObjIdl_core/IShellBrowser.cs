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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IShellBrowser*, IntPtr*, int>)(lpVtbl[3]))((IShellBrowser*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IShellBrowser*, int, int>)(lpVtbl[4]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int InsertMenusSB([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths)
        {
            return ((delegate* unmanaged<IShellBrowser*, IntPtr, OLEMENUGROUPWIDTHS*, int>)(lpVtbl[5]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetMenuSB([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("HOLEMENU")] IntPtr holemenuRes, [NativeTypeName("HWND")] IntPtr hwndActiveObject)
        {
            return ((delegate* unmanaged<IShellBrowser*, IntPtr, IntPtr, IntPtr, int>)(lpVtbl[6]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, holemenuRes, hwndActiveObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveMenusSB([NativeTypeName("HMENU")] IntPtr hmenuShared)
        {
            return ((delegate* unmanaged<IShellBrowser*, IntPtr, int>)(lpVtbl[7]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatusTextSB([NativeTypeName("LPCWSTR")] ushort* pszStatusText)
        {
            return ((delegate* unmanaged<IShellBrowser*, ushort*, int>)(lpVtbl[8]))((IShellBrowser*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModelessSB([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IShellBrowser*, int, int>)(lpVtbl[9]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorSB(MSG* pmsg, [NativeTypeName("WORD")] ushort wID)
        {
            return ((delegate* unmanaged<IShellBrowser*, MSG*, ushort, int>)(lpVtbl[10]))((IShellBrowser*)Unsafe.AsPointer(ref this), pmsg, wID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int BrowseObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("UINT")] uint wFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, ITEMIDLIST*, uint, int>)(lpVtbl[11]))((IShellBrowser*)Unsafe.AsPointer(ref this), pidl, wFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewStateStream([NativeTypeName("DWORD")] uint grfMode, IStream** ppStrm)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, IStream**, int>)(lpVtbl[12]))((IShellBrowser*)Unsafe.AsPointer(ref this), grfMode, ppStrm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlWindow([NativeTypeName("UINT")] uint id, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, IntPtr*, int>)(lpVtbl[13]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SendControlMsg([NativeTypeName("UINT")] uint id, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* pret)
        {
            return ((delegate* unmanaged<IShellBrowser*, uint, uint, nuint, nint, nint*, int>)(lpVtbl[14]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, uMsg, wParam, lParam, pret);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int QueryActiveShellView(IShellView** ppshv)
        {
            return ((delegate* unmanaged<IShellBrowser*, IShellView**, int>)(lpVtbl[15]))((IShellBrowser*)Unsafe.AsPointer(ref this), ppshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int OnViewWindowActive(IShellView* pshv)
        {
            return ((delegate* unmanaged<IShellBrowser*, IShellView*, int>)(lpVtbl[16]))((IShellBrowser*)Unsafe.AsPointer(ref this), pshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetToolbarItems([NativeTypeName("LPTBBUTTONSB")] void* lpButtons, [NativeTypeName("UINT")] uint nButtons, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, void*, uint, uint, int>)(lpVtbl[17]))((IShellBrowser*)Unsafe.AsPointer(ref this), lpButtons, nButtons, uFlags);
        }
    }
}
