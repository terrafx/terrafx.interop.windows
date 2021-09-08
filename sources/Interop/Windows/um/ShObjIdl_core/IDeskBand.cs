// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB0FE172-1A3A-11D0-89B3-00A0C90A90AC")]
    [NativeTypeName("struct IDeskBand : IDockingWindow")]
    [NativeInheritance("IDockingWindow")]
    public unsafe partial struct IDeskBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeskBand*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeskBand*, uint>)(lpVtbl[1]))((IDeskBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeskBand*, uint>)(lpVtbl[2]))((IDeskBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDeskBand*, IntPtr*, int>)(lpVtbl[3]))((IDeskBand*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IDeskBand*, int, int>)(lpVtbl[4]))((IDeskBand*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ShowDW([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IDeskBand*, int, int>)(lpVtbl[5]))((IDeskBand*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CloseDW([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDeskBand*, uint, int>)(lpVtbl[6]))((IDeskBand*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, [NativeTypeName("BOOL")] int fReserved)
        {
            return ((delegate* unmanaged<IDeskBand*, RECT*, IUnknown*, int, int>)(lpVtbl[7]))((IDeskBand*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetBandInfo([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, DESKBANDINFO* pdbi)
        {
            return ((delegate* unmanaged<IDeskBand*, uint, uint, DESKBANDINFO*, int>)(lpVtbl[8]))((IDeskBand*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pdbi);
        }
    }
}
