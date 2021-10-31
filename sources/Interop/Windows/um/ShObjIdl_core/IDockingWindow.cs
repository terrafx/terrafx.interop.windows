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
    public unsafe partial struct IDockingWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDockingWindow*, IntPtr*, int>)(lpVtbl[3]))((IDockingWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDockingWindow*, BOOL, int>)(lpVtbl[4]))((IDockingWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ShowDW(BOOL fShow)
        {
            return ((delegate* unmanaged<IDockingWindow*, BOOL, int>)(lpVtbl[5]))((IDockingWindow*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CloseDW([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDockingWindow*, uint, int>)(lpVtbl[6]))((IDockingWindow*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved)
        {
            return ((delegate* unmanaged<IDockingWindow*, RECT*, IUnknown*, BOOL, int>)(lpVtbl[7]))((IDockingWindow*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
        }
    }
}
