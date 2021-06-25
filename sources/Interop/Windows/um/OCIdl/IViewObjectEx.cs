// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24292-0C96-11CE-A0CF-00AA00600AB8")]
    [NativeTypeName("struct IViewObjectEx : IViewObject2")]
    public unsafe partial struct IViewObjectEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewObjectEx*, Guid*, void**, int>)(lpVtbl[0]))((IViewObjectEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint>)(lpVtbl[1]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint>)(lpVtbl[2]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hdcTargetDev, [NativeTypeName("HDC")] IntPtr hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* unmanaged<nuint, int> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, IntPtr, RECTL*, RECTL*, delegate* unmanaged<nuint, int>, nuint, int>)(lpVtbl[3]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, LOGPALETTE** ppColorSet)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, LOGPALETTE**, int>)(lpVtbl[4]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, uint*, int>)(lpVtbl[5]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int>)(lpVtbl[6]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, uint, IAdviseSink*, int>)(lpVtbl[7]))((IViewObjectEx*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, IAdviseSink** ppAdvSink)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint*, uint*, IAdviseSink**, int>)(lpVtbl[8]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int, DVTARGETDEVICE*, SIZE*, int>)(lpVtbl[9]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, ptd, lpsizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPRECTL")] RECTL* pRect)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, RECTL*, int>)(lpVtbl[10]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint*, int>)(lpVtbl[11]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHitPoint([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, POINT ptlLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, RECT*, POINT, int, uint*, int>)(lpVtbl[12]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, ptlLoc, lCloseHint, pHitResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHitRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LPCRECT")] RECT* pRectLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, RECT*, RECT*, int, uint*, int>)(lpVtbl[13]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, pRectLoc, lCloseHint, pHitResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNaturalExtent([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, DVEXTENTINFO* pExtentInfo, [NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* unmanaged<IViewObjectEx*, uint, int, DVTARGETDEVICE*, IntPtr, DVEXTENTINFO*, SIZE*, int>)(lpVtbl[14]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, lindex, ptd, hicTargetDev, pExtentInfo, pSizel);
        }
    }
}
