// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24292-0C96-11CE-A0CF-00AA00600AB8")]
    public unsafe partial struct IViewObjectEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IViewObjectEx*, Guid*, void**, int>)(lpVtbl[0]))((IViewObjectEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IViewObjectEx*, uint>)(lpVtbl[1]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IViewObjectEx*, uint>)(lpVtbl[2]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hdcTargetDev, [NativeTypeName("HDC")] IntPtr hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* stdcall<nuint, int> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, IntPtr, RECTL*, RECTL*, delegate* stdcall<nuint, int>, nuint, int>)(lpVtbl[3]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, [NativeTypeName("LOGPALETTE **")] LOGPALETTE** ppColorSet)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, LOGPALETTE**, int>)(lpVtbl[4]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int, void*, uint*, int>)(lpVtbl[5]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int>)(lpVtbl[6]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, uint, IAdviseSink*, int>)(lpVtbl[7]))((IViewObjectEx*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, [NativeTypeName("IAdviseSink **")] IAdviseSink** ppAdvSink)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint*, uint*, IAdviseSink**, int>)(lpVtbl[8]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int, DVTARGETDEVICE*, SIZE*, int>)(lpVtbl[9]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, ptd, lpsizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPRECTL")] RECTL* pRect)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, RECTL*, int>)(lpVtbl[10]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetViewStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint*, int>)(lpVtbl[11]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryHitPoint([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, POINT ptlLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, RECT*, POINT, int, uint*, int>)(lpVtbl[12]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, ptlLoc, lCloseHint, pHitResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryHitRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LPCRECT")] RECT* pRectLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, RECT*, RECT*, int, uint*, int>)(lpVtbl[13]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, pRectLoc, lCloseHint, pHitResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNaturalExtent([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, [NativeTypeName("DVEXTENTINFO *")] DVEXTENTINFO* pExtentInfo, [NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* stdcall<IViewObjectEx*, uint, int, DVTARGETDEVICE*, IntPtr, DVEXTENTINFO*, SIZE*, int>)(lpVtbl[14]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, lindex, ptd, hicTargetDev, pExtentInfo, pSizel);
        }
    }
}
