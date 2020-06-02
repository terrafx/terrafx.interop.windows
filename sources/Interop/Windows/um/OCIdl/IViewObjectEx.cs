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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IViewObjectEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IViewObjectEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hdcTargetDev, [NativeTypeName("HDC")] IntPtr hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* stdcall<nuint, int> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return lpVtbl->Draw((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, [NativeTypeName("LOGPALETTE **")] LOGPALETTE** ppColorSet)
        {
            return lpVtbl->GetColorSet((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return lpVtbl->Freeze((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return lpVtbl->Unfreeze((IViewObjectEx*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink)
        {
            return lpVtbl->SetAdvise((IViewObjectEx*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, [NativeTypeName("IAdviseSink **")] IAdviseSink** ppAdvSink)
        {
            return lpVtbl->GetAdvise((IViewObjectEx*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel)
        {
            return lpVtbl->GetExtent((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, ptd, lpsizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPRECTL")] RECTL* pRect)
        {
            return lpVtbl->GetRect((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetViewStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return lpVtbl->GetViewStatus((IViewObjectEx*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryHitPoint([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, POINT ptlLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return lpVtbl->QueryHitPoint((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, ptlLoc, lCloseHint, pHitResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryHitRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LPCRECT")] RECT* pRectLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
        {
            return lpVtbl->QueryHitRect((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, pRectLoc, lCloseHint, pHitResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNaturalExtent([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, [NativeTypeName("DVEXTENTINFO *")] ExtentInfo* pExtentInfo, [NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return lpVtbl->GetNaturalExtent((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, lindex, ptd, hicTargetDev, pExtentInfo, pSizel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, HDC, LPCRECTL, LPCRECTL, BOOL (*)(ULONG_PTR) __attribute__((stdcall)), ULONG_PTR) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, IntPtr, RECTL*, RECTL*, delegate* stdcall<nuint, int>, nuint, int> Draw;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, LOGPALETTE **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, IntPtr, LOGPALETTE**, int> GetColorSet;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int, void*, uint*, int> Freeze;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int> Unfreeze;

            [NativeTypeName("HRESULT (DWORD, DWORD, IAdviseSink *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, uint, IAdviseSink*, int> SetAdvise;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, IAdviseSink **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint*, uint*, IAdviseSink**, int> GetAdvise;

            [NativeTypeName("HRESULT (DWORD, LONG, DVTARGETDEVICE *, LPSIZEL) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int, DVTARGETDEVICE*, SIZE*, int> GetExtent;

            [NativeTypeName("HRESULT (DWORD, LPRECTL) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, RECTL*, int> GetRect;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint*, int> GetViewStatus;

            [NativeTypeName("HRESULT (DWORD, LPCRECT, POINT, LONG, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, RECT*, POINT, int, uint*, int> QueryHitPoint;

            [NativeTypeName("HRESULT (DWORD, LPCRECT, LPCRECT, LONG, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, RECT*, RECT*, int, uint*, int> QueryHitRect;

            [NativeTypeName("HRESULT (DWORD, LONG, DVTARGETDEVICE *, HDC, DVEXTENTINFO *, LPSIZEL) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObjectEx*, uint, int, DVTARGETDEVICE*, IntPtr, ExtentInfo*, SIZE*, int> GetNaturalExtent;
        }
    }
}
