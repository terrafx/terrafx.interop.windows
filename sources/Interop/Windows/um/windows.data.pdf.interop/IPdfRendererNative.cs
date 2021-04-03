// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D9DCD91-D277-4947-8527-07A0DAEDA94A")]
    [NativeTypeName("struct IPdfRendererNative : IUnknown")]
    public unsafe partial struct IPdfRendererNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPdfRendererNative*, Guid*, void**, int>)(lpVtbl[0]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPdfRendererNative*, uint>)(lpVtbl[1]))((IPdfRendererNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPdfRendererNative*, uint>)(lpVtbl[2]))((IPdfRendererNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderPageToSurface(IUnknown* pdfPage, IDXGISurface* pSurface, POINT offset, PDF_RENDER_PARAMS* pRenderParams)
        {
            return ((delegate* unmanaged<IPdfRendererNative*, IUnknown*, IDXGISurface*, POINT, PDF_RENDER_PARAMS*, int>)(lpVtbl[3]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), pdfPage, pSurface, offset, pRenderParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderPageToDeviceContext(IUnknown* pdfPage, ID2D1DeviceContext* pD2DDeviceContext, PDF_RENDER_PARAMS* pRenderParams)
        {
            return ((delegate* unmanaged<IPdfRendererNative*, IUnknown*, ID2D1DeviceContext*, PDF_RENDER_PARAMS*, int>)(lpVtbl[4]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), pdfPage, pD2DDeviceContext, pRenderParams);
        }
    }
}
