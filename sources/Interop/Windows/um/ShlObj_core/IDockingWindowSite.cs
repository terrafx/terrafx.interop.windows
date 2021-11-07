// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A342FC2-7B26-11D0-8CA9-00A0C92DBFE8")]
    [NativeTypeName("struct IDockingWindowSite : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDockingWindowSite : IDockingWindowSite.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, Guid*, void**, int>)(lpVtbl[0]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDockingWindowSite*, uint>)(lpVtbl[1]))((IDockingWindowSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDockingWindowSite*, uint>)(lpVtbl[2]))((IDockingWindowSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, HWND*, int>)(lpVtbl[3]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, BOOL, int>)(lpVtbl[4]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetBorderDW(IUnknown* punkObj, RECT* prcBorder)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[5]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, prcBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RequestBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[6]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, pbw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[7]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, pbw);
        }

        public interface Interface : IOleWindow.Interface
        {
            [VtblIndex(5)]
            HRESULT GetBorderDW(IUnknown* punkObj, RECT* prcBorder);

            [VtblIndex(6)]
            HRESULT RequestBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw);

            [VtblIndex(7)]
            HRESULT SetBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (IUnknown *, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int> GetBorderDW;

            [NativeTypeName("HRESULT (IUnknown *, LPCBORDERWIDTHS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int> RequestBorderSpaceDW;

            [NativeTypeName("HRESULT (IUnknown *, LPCBORDERWIDTHS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int> SetBorderSpaceDW;
        }
    }
}
