// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
    public unsafe partial struct ID2D1Bitmap1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Bitmap1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Bitmap1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Bitmap1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1Bitmap1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(ID2D1Bitmap1* pThis, D2D_SIZE_F* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(ID2D1Bitmap1* pThis, D2D_SIZE_U* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(ID2D1Bitmap1* pThis, D2D1_PIXEL_FORMAT* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1Bitmap1* pThis, [NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromBitmap(ID2D1Bitmap1* pThis, [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromRenderTarget(ID2D1Bitmap1* pThis, [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1RenderTarget *")] ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromMemory(ID2D1Bitmap1* pThis, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetColorContext(ID2D1Bitmap1* pThis, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_BITMAP_OPTIONS _GetOptions(ID2D1Bitmap1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSurface(ID2D1Bitmap1* pThis, [NativeTypeName("IDXGISurface **")] IDXGISurface** dxgiSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID2D1Bitmap1* pThis, D2D1_MAP_OPTIONS options, [NativeTypeName("D2D1_MAPPED_RECT *")] D2D1_MAPPED_RECT* mappedRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unmap(ID2D1Bitmap1* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyFromBitmap>(lpVtbl->CopyFromBitmap)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1RenderTarget *")] ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyFromRenderTarget>(lpVtbl->CopyFromRenderTarget)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyFromMemory>(lpVtbl->CopyFromMemory)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
        }

        public void GetColorContext([NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            Marshal.GetDelegateForFunctionPointer<_GetColorContext>(lpVtbl->GetColorContext)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), colorContext);
        }

        public D2D1_BITMAP_OPTIONS GetOptions()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptions>(lpVtbl->GetOptions)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("IDXGISurface **")] IDXGISurface** dxgiSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSurface>(lpVtbl->GetSurface)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dxgiSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map(D2D1_MAP_OPTIONS options, [NativeTypeName("D2D1_MAPPED_RECT *")] D2D1_MAPPED_RECT* mappedRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), options, mappedRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelSize;

            [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelFormat;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDpi;

            [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1Bitmap *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CopyFromBitmap;

            [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1RenderTarget *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CopyFromRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CopyFromMemory;

            [NativeTypeName("void (ID2D1ColorContext **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorContext;

            [NativeTypeName("D2D1_BITMAP_OPTIONS () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOptions;

            [NativeTypeName("HRESULT (IDXGISurface **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSurface;

            [NativeTypeName("HRESULT (D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Map;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Unmap;
        }
    }
}
