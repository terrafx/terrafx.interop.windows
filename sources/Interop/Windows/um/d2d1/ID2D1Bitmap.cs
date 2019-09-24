// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Root bitmap resource, linearly scaled on a draw call.</summary>
    [Guid("A2296057-EA42-4099-983B-539FB6505426")]
    public unsafe struct ID2D1Bitmap
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1Bitmap* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1Bitmap* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1Bitmap* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(
            [In] ID2D1Bitmap* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Returns the size of the bitmap in resolution independent units.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(
            [In] ID2D1Bitmap* This,
            [Out, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* _result
        );

        /// <summary>Returns the size of the bitmap in resolution dependent units, (pixels).</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(
            [In] ID2D1Bitmap* This,
            [Out, NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U* _result
        );

        /// <summary>Retrieve the format of the bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(
            [In] ID2D1Bitmap* This,
            [Out] D2D1_PIXEL_FORMAT* _result
        );

        /// <summary>Return the DPI of the bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(
            [In] ID2D1Bitmap* This,
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromBitmap(
            [In] ID2D1Bitmap* This,
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1Bitmap* bitmap,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromRenderTarget(
            [In] ID2D1Bitmap* This,
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1RenderTarget* renderTarget,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyFromMemory(
            [In] ID2D1Bitmap* This,
            [In, Optional, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* dstRect,
            [In] void* srcData,
            [In, NativeTypeName("UINT32")] uint pitch
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                D2D_SIZE_F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                D2D_SIZE_U result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)(
                    This,
                    &result
                );
            }
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                D2D1_PIXEL_FORMAT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    &result
                );
            }
        }

        public void GetDpi(
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap(
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1Bitmap* bitmap,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromBitmap>(lpVtbl->CopyFromBitmap)(
                    This,
                    destPoint,
                    bitmap,
                    srcRect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget(
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1RenderTarget* renderTarget,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromRenderTarget>(lpVtbl->CopyFromRenderTarget)(
                    This,
                    destPoint,
                    renderTarget,
                    srcRect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory(
            [In, Optional, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* dstRect,
            [In] void* srcData,
            [In, NativeTypeName("UINT32")] uint pitch
        )
        {
            fixed (ID2D1Bitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyFromMemory>(lpVtbl->CopyFromMemory)(
                    This,
                    dstRect,
                    srcData,
                    pitch
                );
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
        }
    }
}
