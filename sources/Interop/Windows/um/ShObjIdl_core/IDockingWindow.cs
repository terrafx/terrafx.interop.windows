// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("012DD920-7B26-11D0-8CA9-00A0C92DBFE8")]
    [NativeTypeName("struct IDockingWindow : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDockingWindow : IDockingWindow.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDockingWindow*, Guid*, void**, int>)(lpVtbl[0]))((IDockingWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDockingWindow*, uint>)(lpVtbl[1]))((IDockingWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDockingWindow*, uint>)(lpVtbl[2]))((IDockingWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IDockingWindow*, HWND*, int>)(lpVtbl[3]))((IDockingWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDockingWindow*, BOOL, int>)(lpVtbl[4]))((IDockingWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ShowDW(BOOL fShow)
        {
            return ((delegate* unmanaged<IDockingWindow*, BOOL, int>)(lpVtbl[5]))((IDockingWindow*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDockingWindow*, uint, int>)(lpVtbl[6]))((IDockingWindow*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved)
        {
            return ((delegate* unmanaged<IDockingWindow*, RECT*, IUnknown*, BOOL, int>)(lpVtbl[7]))((IDockingWindow*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
        }

        public interface Interface : IOleWindow.Interface
        {
            [VtblIndex(5)]
            HRESULT ShowDW(BOOL fShow);

            [VtblIndex(6)]
            HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved);

            [VtblIndex(7)]
            HRESULT ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, BOOL, int> ShowDW;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, uint, int> CloseDW;

            [NativeTypeName("HRESULT (LPCRECT, IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindow*, RECT*, IUnknown*, BOOL, int> ResizeBorderDW;
        }
    }
}
