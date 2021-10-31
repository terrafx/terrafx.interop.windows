// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79D16DE4-ABEE-4021-8D9D-9169B261D657")]
    [NativeTypeName("struct IDeskBand2 : IDeskBand")]
    [NativeInheritance("IDeskBand")]
    public unsafe partial struct IDeskBand2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeskBand2*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBand2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeskBand2*, uint>)(lpVtbl[1]))((IDeskBand2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeskBand2*, uint>)(lpVtbl[2]))((IDeskBand2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDeskBand2*, IntPtr*, int>)(lpVtbl[3]))((IDeskBand2*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[4]))((IDeskBand2*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ShowDW(BOOL fShow)
        {
            return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[5]))((IDeskBand2*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDeskBand2*, uint, int>)(lpVtbl[6]))((IDeskBand2*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved)
        {
            return ((delegate* unmanaged<IDeskBand2*, RECT*, IUnknown*, BOOL, int>)(lpVtbl[7]))((IDeskBand2*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBandInfo([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, DESKBANDINFO* pdbi)
        {
            return ((delegate* unmanaged<IDeskBand2*, uint, uint, DESKBANDINFO*, int>)(lpVtbl[8]))((IDeskBand2*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pdbi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CanRenderComposited(BOOL* pfCanRenderComposited)
        {
            return ((delegate* unmanaged<IDeskBand2*, BOOL*, int>)(lpVtbl[9]))((IDeskBand2*)Unsafe.AsPointer(ref this), pfCanRenderComposited);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCompositionState(BOOL fCompositionEnabled)
        {
            return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[10]))((IDeskBand2*)Unsafe.AsPointer(ref this), fCompositionEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCompositionState(BOOL* pfCompositionEnabled)
        {
            return ((delegate* unmanaged<IDeskBand2*, BOOL*, int>)(lpVtbl[11]))((IDeskBand2*)Unsafe.AsPointer(ref this), pfCompositionEnabled);
        }
    }
}
