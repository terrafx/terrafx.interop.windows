// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IViewObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IViewObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewObject*, Guid*, void**, int>)(lpVtbl[0]))((IViewObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewObject*, uint>)(lpVtbl[1]))((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewObject*, uint>)(lpVtbl[2]))((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hdcTargetDev, HDC hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* unmanaged<nuint, BOOL> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, HDC, HDC, RECTL*, RECTL*, delegate* unmanaged<nuint, BOOL>, nuint, int>)(lpVtbl[3]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hicTargetDev, LOGPALETTE** ppColorSet)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, HDC, LOGPALETTE**, int>)(lpVtbl[4]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, uint*, int>)(lpVtbl[5]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int>)(lpVtbl[6]))((IViewObject*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink)
        {
            return ((delegate* unmanaged<IViewObject*, uint, uint, IAdviseSink*, int>)(lpVtbl[7]))((IViewObject*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, IAdviseSink** ppAdvSink)
        {
            return ((delegate* unmanaged<IViewObject*, uint*, uint*, IAdviseSink**, int>)(lpVtbl[8]))((IViewObject*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, HDC, LPCRECTL, LPCRECTL, BOOL (*)(ULONG_PTR) __attribute__((stdcall)), ULONG_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, HDC, HDC, RECTL*, RECTL*, delegate* unmanaged<nuint, BOOL>, nuint, int> Draw;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, LOGPALETTE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, HDC, LOGPALETTE**, int> GetColorSet;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint, int, void*, uint*, int> Freeze;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint, int> Unfreeze;

            [NativeTypeName("HRESULT (DWORD, DWORD, IAdviseSink *) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint, uint, IAdviseSink*, int> SetAdvise;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, IAdviseSink **) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewObject*, uint*, uint*, IAdviseSink**, int> GetAdvise;
        }
    }
}
