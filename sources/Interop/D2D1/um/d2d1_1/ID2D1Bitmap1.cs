// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a bitmap that can be used as a surface for an ID2D1DeviceContext or mapped into system memory, and can contain additional color context information.</summary>
    [Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
    public unsafe struct ID2D1Bitmap1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Bitmap1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Bitmap1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Bitmap1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1Bitmap1* This, ID2D1Factory** factory);

        /// <summary>Returns the size of the bitmap in resolution independent units.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(ID2D1Bitmap1* This, D2D_SIZE_F* _result);

        /// <summary>Returns the size of the bitmap in resolution dependent units, (pixels).</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(ID2D1Bitmap1* This, D2D_SIZE_U* _result);

        /// <summary>Retrieve the format of the bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(ID2D1Bitmap1* This, D2D1_PIXEL_FORMAT* _result);

        /// <summary>Return the DPI of the bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1Bitmap1* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromBitmap(ID2D1Bitmap1* This, [Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromRenderTarget(ID2D1Bitmap1* This, [Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromMemory(ID2D1Bitmap1* This, [Optional, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* dstRect, void* srcData, [NativeTypeName("UINT32")] uint pitch);

        /// <summary>Retrieves the color context information associated with the bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetColorContext(ID2D1Bitmap1* This, ID2D1ColorContext** colorContext);

        /// <summary>Retrieves the bitmap options used when creating the API.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_BITMAP_OPTIONS _GetOptions(ID2D1Bitmap1* This);

        /// <summary>Retrieves the DXGI surface from the corresponding bitmap, if the bitmap was created from a device derived from a D3D device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSurface(ID2D1Bitmap1* This, IDXGISurface** dxgiSurface);

        /// <summary>Maps the given bitmap into memory. The bitmap must have been created with the D2D1_BITMAP_OPTIONS_CPU_READ flag.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID2D1Bitmap1* This, D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect);

        /// <summary>Unmaps the given bitmap from memory.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unmap(ID2D1Bitmap1* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D_SIZE_F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, &result);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D_SIZE_U result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)(This, &result);
            }
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D1_PIXEL_FORMAT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, &result);
            }
        }

        public void GetDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap([Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromBitmap>(lpVtbl->CopyFromBitmap)(This, destPoint, bitmap, srcRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget([Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromRenderTarget>(lpVtbl->CopyFromRenderTarget)(This, destPoint, renderTarget, srcRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory([Optional, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* dstRect, void* srcData, [NativeTypeName("UINT32")] uint pitch)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromMemory>(lpVtbl->CopyFromMemory)(This, dstRect, srcData, pitch);
            }
        }

        public void GetColorContext(ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetColorContext>(lpVtbl->GetColorContext)(This, colorContext);
            }
        }

        public D2D1_BITMAP_OPTIONS GetOptions()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOptions>(lpVtbl->GetOptions)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurface(IDXGISurface** dxgiSurface)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSurface>(lpVtbl->GetSurface)(This, dxgiSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect)
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)(This, options, mappedRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetSize;

            public IntPtr GetPixelSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetDpi;

            public IntPtr CopyFromBitmap;

            public IntPtr CopyFromRenderTarget;

            public IntPtr CopyFromMemory;

            public IntPtr GetColorContext;

            public IntPtr GetOptions;

            public IntPtr GetSurface;

            public IntPtr Map;

            public IntPtr Unmap;
        }
    }
}
