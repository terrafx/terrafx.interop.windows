// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6A7-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPaintSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLPaintSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, uint>)(lpVtbl[1]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, uint>)(lpVtbl[2]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidatePainterInfo()
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, int>)(lpVtbl[3]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateRect(RECT* prcInvalid)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, RECT*, int>)(lpVtbl[4]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), prcInvalid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateRegion([NativeTypeName("HRGN")] IntPtr rgnInvalid)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, IntPtr, int>)(lpVtbl[5]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), rgnInvalid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDrawInfo([NativeTypeName("LONG")] int lFlags, HTML_PAINT_DRAW_INFO* pDrawInfo)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, int, HTML_PAINT_DRAW_INFO*, int>)(lpVtbl[6]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), lFlags, pDrawInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int TransformGlobalToLocal(POINT ptGlobal, POINT* pptLocal)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, POINT, POINT*, int>)(lpVtbl[7]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), ptGlobal, pptLocal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int TransformLocalToGlobal(POINT ptLocal, POINT* pptGlobal)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, POINT, POINT*, int>)(lpVtbl[8]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), ptLocal, pptGlobal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetHitTestCookie([NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IHTMLPaintSite*, int*, int>)(lpVtbl[9]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), plCookie);
        }
    }
}
