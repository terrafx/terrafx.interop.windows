// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2296057-EA42-4099-983B-539FB6505426")]
    [NativeTypeName("struct ID2D1Bitmap : ID2D1Image")]
    public unsafe partial struct ID2D1Bitmap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Bitmap*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Bitmap*, uint>)(lpVtbl[1]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Bitmap*, uint>)(lpVtbl[2]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1Bitmap*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *((delegate* stdcall<ID2D1Bitmap*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[4]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *((delegate* stdcall<ID2D1Bitmap*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[5]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *((delegate* stdcall<ID2D1Bitmap*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[6]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* stdcall<ID2D1Bitmap*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return ((delegate* stdcall<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)(lpVtbl[8]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1RenderTarget *")] ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return ((delegate* stdcall<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)(lpVtbl[9]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
        {
            return ((delegate* stdcall<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
        }
    }
}
