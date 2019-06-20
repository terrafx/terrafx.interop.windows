// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
    [Unmanaged]
    public unsafe struct ID2D1SpriteBatch
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SpriteBatch* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SpriteBatch* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SpriteBatch* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SpriteBatch* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region Delegates
        /// <summary>Adds sprites to the end of the sprite batch.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddSprites(
            [In] ID2D1SpriteBatch* This,
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [In, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles,
            [In, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [In, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null,
            [In, NativeTypeName("UINT32")] uint destinationRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint sourceRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint colorsStride = 16,
            [In, NativeTypeName("UINT32")] uint transformsStride = 24
        );

        /// <summary>Set properties for existing sprites. All properties not specified are unmodified.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSprites(
            [In] ID2D1SpriteBatch* This,
            [In, NativeTypeName("UINT32")] uint startIndex,
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [In, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null,
            [In, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [In, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null,
            [In, NativeTypeName("UINT32")] uint destinationRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint sourceRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint colorsStride = 16,
            [In, NativeTypeName("UINT32")] uint transformsStride = 24
        );

        /// <summary>Retrieves sprite properties.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSprites(
            [In] ID2D1SpriteBatch* This,
            [In, NativeTypeName("UINT32")] uint startIndex,
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [Out, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null,
            [Out, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [Out, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null
        );

        /// <summary>Retrieves the number of sprites in the sprite batch.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetSpriteCount(
            [In] ID2D1SpriteBatch* This
        );

        /// <summary>Removes all sprites from the sprite batch.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Clear(
            [In] ID2D1SpriteBatch* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SpriteBatch* This = &this)
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
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SpriteBatch* This = &this)
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
            fixed (ID2D1SpriteBatch* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int AddSprites(
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [In, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles,
            [In, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [In, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null,
            [In, NativeTypeName("UINT32")] uint destinationRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint sourceRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint colorsStride = 16,
            [In, NativeTypeName("UINT32")] uint transformsStride = 24
        )
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return MarshalFunction<_AddSprites>(lpVtbl->AddSprites)(
                    This,
                    spriteCount,
                    destinationRectangles,
                    sourceRectangles,
                    colors,
                    transforms,
                    destinationRectanglesStride,
                    sourceRectanglesStride,
                    colorsStride,
                    transformsStride
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSprites(
            [In, NativeTypeName("UINT32")] uint startIndex,
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [In, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null,
            [In, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [In, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null,
            [In, NativeTypeName("UINT32")] uint destinationRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint sourceRectanglesStride = 16,
            [In, NativeTypeName("UINT32")] uint colorsStride = 16,
            [In, NativeTypeName("UINT32")] uint transformsStride = 24
        )
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return MarshalFunction<_SetSprites>(lpVtbl->SetSprites)(
                    This,
                    startIndex,
                    spriteCount,
                    destinationRectangles,
                    sourceRectangles,
                    colors,
                    transforms,
                    destinationRectanglesStride,
                    sourceRectanglesStride,
                    colorsStride,
                    transformsStride
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSprites(
            [In, NativeTypeName("UINT32")] uint startIndex,
            [In, NativeTypeName("UINT32")] uint spriteCount,
            [Out, NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null,
            [Out, NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null,
            [Out, NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null
        )
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return MarshalFunction<_GetSprites>(lpVtbl->GetSprites)(
                    This,
                    startIndex,
                    spriteCount,
                    destinationRectangles,
                    sourceRectangles,
                    colors,
                    transforms
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpriteCount()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return MarshalFunction<_GetSpriteCount>(lpVtbl->GetSpriteCount)(
                    This
                );
            }
        }

        public void Clear()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                MarshalFunction<_Clear>(lpVtbl->Clear)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
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

            #region Fields
            public IntPtr AddSprites;

            public IntPtr SetSprites;

            public IntPtr GetSprites;

            public IntPtr GetSpriteCount;

            public IntPtr Clear;
            #endregion
        }
        #endregion
    }
}
