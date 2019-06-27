// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>A bitmap brush allows a bitmap to be used to fill a geometry.</summary>
    [Guid("2CD906AA-12E2-11DC-9FED-001143A055F9")]
    public unsafe struct ID2D1BitmapBrush
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1BitmapBrush* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1BitmapBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1BitmapBrush* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1BitmapBrush* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Brush Delegates
        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1BitmapBrush* This,
            [In, NativeTypeName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1BitmapBrush* This,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1BitmapBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1BitmapBrush* This,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );
        #endregion

        #region Delegates
        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeX(
            [In] ID2D1BitmapBrush* This,
            [In] D2D1_EXTEND_MODE extendModeX
        );

        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeY(
            [In] ID2D1BitmapBrush* This,
            [In] D2D1_EXTEND_MODE extendModeY
        );

        /// <summary>Sets the interpolation mode used when this brush is used.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInterpolationMode(
            [In] ID2D1BitmapBrush* This,
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
        );

        /// <summary>Sets the bitmap associated as the source of this brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetBitmap(
            [In] ID2D1BitmapBrush* This,
            [In] ID2D1Bitmap* bitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeX(
            [In] ID2D1BitmapBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeY(
            [In] ID2D1BitmapBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_BITMAP_INTERPOLATION_MODE _GetInterpolationMode(
            [In] ID2D1BitmapBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetBitmap(
            [In] ID2D1BitmapBrush* This,
            [Out] ID2D1Bitmap** bitmap
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
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
            fixed (ID2D1BitmapBrush* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1BitmapBrush* This = &this)
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
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Brush Methods
        public void SetOpacity(
            [In, NativeTypeName("FLOAT")] float opacity
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetOpacity>(lpVtbl->SetOpacity)(
                    This,
                    opacity
                );
            }
        }

        public void SetTransform(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                return MarshalFunction<_GetOpacity>(lpVtbl->GetOpacity)(
                    This
                );
            }
        }

        public void GetTransform(
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }
        #endregion

        #region Methods
        public void SetExtendModeX(
            [In] D2D1_EXTEND_MODE extendModeX
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetExtendModeX>(lpVtbl->SetExtendModeX)(
                    This,
                    extendModeX
                );
            }
        }

        public void SetExtendModeY(
            [In] D2D1_EXTEND_MODE extendModeY
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetExtendModeY>(lpVtbl->SetExtendModeY)(
                    This,
                    extendModeY
                );
            }
        }

        public void SetInterpolationMode(
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)(
                    This,
                    interpolationMode
                );
            }
        }

        public void SetBitmap(
            [In] ID2D1Bitmap* bitmap = null
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_SetBitmap>(lpVtbl->SetBitmap)(
                    This,
                    bitmap
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                return MarshalFunction<_GetExtendModeX>(lpVtbl->GetExtendModeX)(
                    This
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                return MarshalFunction<_GetExtendModeY>(lpVtbl->GetExtendModeY)(
                    This
                );
            }
        }

        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                return MarshalFunction<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)(
                    This
                );
            }
        }

        public void GetBitmap(
            [Out] ID2D1Bitmap** bitmap
        )
        {
            fixed (ID2D1BitmapBrush* This = &this)
            {
                MarshalFunction<_GetBitmap>(lpVtbl->GetBitmap)(
                    This,
                    bitmap
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

            #region ID2D1Brush Fields
            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;
            #endregion

            #region Fields
            public IntPtr SetExtendModeX;

            public IntPtr SetExtendModeY;

            public IntPtr SetInterpolationMode;

            public IntPtr SetBitmap;

            public IntPtr GetExtendModeX;

            public IntPtr GetExtendModeY;

            public IntPtr GetInterpolationMode;

            public IntPtr GetBitmap;
            #endregion
        }
        #endregion
    }
}
