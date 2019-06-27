// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a bitmap that can be used as a surface for an ID2D1DeviceContext or mapped into system memory, and can contain additional color context information.</summary>
    [Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
    public unsafe struct ID2D1Bitmap1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Bitmap1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Bitmap1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Bitmap1* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1Bitmap1* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Bitmap Delegates
        /// <summary>Returns the size of the bitmap in resolution independent units.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public /* static */ delegate D2D_SIZE_F* _GetSize(
            [In] ID2D1Bitmap1* This,
            [Out] D2D_SIZE_F* _result
        );

        /// <summary>Returns the size of the bitmap in resolution dependent units, (pixels).</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public /* static */ delegate D2D_SIZE_U* _GetPixelSize(
            [In] ID2D1Bitmap1* This,
            [Out] D2D_SIZE_U* _result
        );

        /// <summary>Retrieve the format of the bitmap.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(
            [In] ID2D1Bitmap1* This,
            [Out] D2D1_PIXEL_FORMAT* _result
        );

        /// <summary>Return the DPI of the bitmap.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDpi(
            [In] ID2D1Bitmap1* This,
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyFromBitmap(
            [In] ID2D1Bitmap1* This,
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1Bitmap* bitmap,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyFromRenderTarget(
            [In] ID2D1Bitmap1* This,
            [In, Optional, NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U* destPoint,
            [In] ID2D1RenderTarget* renderTarget,
            [In, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* srcRect = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyFromMemory(
            [In] ID2D1Bitmap1* This,
            [In, Optional, NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* dstRect,
            [In] void* srcData,
            [In, NativeTypeName("UINT32")] uint pitch
        );
        #endregion

        #region Delegates
        /// <summary>Retrieves the color context information associated with the bitmap.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetColorContext(
            [In] ID2D1Bitmap1* This,
            [Out] ID2D1ColorContext** colorContext
        );

        /// <summary>Retrieves the bitmap options used when creating the API.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_BITMAP_OPTIONS _GetOptions(
            [In] ID2D1Bitmap1* This
        );

        /// <summary>Retrieves the DXGI surface from the corresponding bitmap, if the bitmap was created from a device derived from a D3D device.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSurface(
            [In] ID2D1Bitmap1* This,
            [Out] IDXGISurface** dxgiSurface
        );

        /// <summary>Maps the given bitmap into memory. The bitmap must have been created with the D2D1_BITMAP_OPTIONS_CPU_READ flag.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Map(
            [In] ID2D1Bitmap1* This,
            [In] D2D1_MAP_OPTIONS options,
            [Out] D2D1_MAPPED_RECT* mappedRect
        );

        /// <summary>Unmaps the given bitmap from memory.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Unmap(
            [In] ID2D1Bitmap1* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Bitmap Methods
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D_SIZE_F result;
                return *MarshalFunction<_GetSize>(lpVtbl->GetSize)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D_SIZE_U result;
                return *MarshalFunction<_GetPixelSize>(lpVtbl->GetPixelSize)(
                    This,
                    &result
                );
            }
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                D2D1_PIXEL_FORMAT result;
                return *MarshalFunction<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
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
            fixed (ID2D1Bitmap1* This = &this)
            {
                MarshalFunction<_GetDpi>(lpVtbl->GetDpi)(
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
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_CopyFromBitmap>(lpVtbl->CopyFromBitmap)(
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
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_CopyFromRenderTarget>(lpVtbl->CopyFromRenderTarget)(
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
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_CopyFromMemory>(lpVtbl->CopyFromMemory)(
                    This,
                    dstRect,
                    srcData,
                    pitch
                );
            }
        }
        #endregion

        #region Methods
        public void GetColorContext(
            [Out] ID2D1ColorContext** colorContext
        )
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                MarshalFunction<_GetColorContext>(lpVtbl->GetColorContext)(
                    This,
                    colorContext
                );
            }
        }

        public D2D1_BITMAP_OPTIONS GetOptions()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_GetOptions>(lpVtbl->GetOptions)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurface(
            [Out] IDXGISurface** dxgiSurface
        )
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_GetSurface>(lpVtbl->GetSurface)(
                    This,
                    dxgiSurface
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Map(
            [In] D2D1_MAP_OPTIONS options,
            [Out] D2D1_MAPPED_RECT* mappedRect
        )
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_Map>(lpVtbl->Map)(
                    This,
                    options,
                    mappedRect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            fixed (ID2D1Bitmap1* This = &this)
            {
                return MarshalFunction<_Unmap>(lpVtbl->Unmap)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1Bitmap Fields
            public IntPtr GetSize;

            public IntPtr GetPixelSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetDpi;

            public IntPtr CopyFromBitmap;

            public IntPtr CopyFromRenderTarget;

            public IntPtr CopyFromMemory;
            #endregion

            #region Fields
            public IntPtr GetColorContext;

            public IntPtr GetOptions;

            public IntPtr GetSurface;

            public IntPtr Map;

            public IntPtr Unmap;
            #endregion
        }
        #endregion
    }
}
