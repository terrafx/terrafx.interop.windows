// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>A bitmap brush allows a bitmap to be used to fill a geometry.  Interpolation mode is specified with D2D1_INTERPOLATION_MODE</summary>
    [Guid("41343A53-E41A-49A2-91CD-21793BBB62E5")]
    public unsafe struct ID2D1BitmapBrush1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1BitmapBrush1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1BitmapBrush1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1BitmapBrush1* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1BitmapBrush1* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1BitmapBrush1* This,
            [In, NativeTypeName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1BitmapBrush1* This,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1BitmapBrush1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1BitmapBrush1* This,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeX(
            [In] ID2D1BitmapBrush1* This,
            [In] D2D1_EXTEND_MODE extendModeX
        );

        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeY(
            [In] ID2D1BitmapBrush1* This,
            [In] D2D1_EXTEND_MODE extendModeY
        );

        /// <summary>Sets the interpolation mode used when this brush is used.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInterpolationMode(
            [In] ID2D1BitmapBrush1* This,
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
        );

        /// <summary>Sets the bitmap associated as the source of this brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetBitmap(
            [In] ID2D1BitmapBrush1* This,
            [In] ID2D1Bitmap* bitmap = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeX(
            [In] ID2D1BitmapBrush1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeY(
            [In] ID2D1BitmapBrush1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_BITMAP_INTERPOLATION_MODE _GetInterpolationMode(
            [In] ID2D1BitmapBrush1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetBitmap(
            [In] ID2D1BitmapBrush1* This,
            [Out] ID2D1Bitmap** bitmap
        );

        /// <summary>Sets the interpolation mode used when this brush is used.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInterpolationMode1(
            [In] ID2D1BitmapBrush1* This,
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_INTERPOLATION_MODE _GetInterpolationMode1(
            [In] ID2D1BitmapBrush1* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
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
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
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
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        public void SetOpacity(
            [In, NativeTypeName("FLOAT")] float opacity
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)(
                    This,
                    opacity
                );
            }
        }

        public void SetTransform(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)(
                    This
                );
            }
        }

        public void GetTransform(
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }

        public void SetExtendModeX(
            [In] D2D1_EXTEND_MODE extendModeX
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeX>(lpVtbl->SetExtendModeX)(
                    This,
                    extendModeX
                );
            }
        }

        public void SetExtendModeY(
            [In] D2D1_EXTEND_MODE extendModeY
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeY>(lpVtbl->SetExtendModeY)(
                    This,
                    extendModeY
                );
            }
        }

        public void SetInterpolationMode(
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)(
                    This,
                    interpolationMode
                );
            }
        }

        public void SetBitmap(
            [In] ID2D1Bitmap* bitmap = null
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetBitmap>(lpVtbl->SetBitmap)(
                    This,
                    bitmap
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeX>(lpVtbl->GetExtendModeX)(
                    This
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeY>(lpVtbl->GetExtendModeY)(
                    This
                );
            }
        }

        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)(
                    This
                );
            }
        }

        public void GetBitmap(
            [Out] ID2D1Bitmap** bitmap
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetBitmap>(lpVtbl->GetBitmap)(
                    This,
                    bitmap
                );
            }
        }

        public void SetInterpolationMode1(
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        )
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode1>(lpVtbl->SetInterpolationMode1)(
                    This,
                    interpolationMode
                );
            }
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode1()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode1>(lpVtbl->GetInterpolationMode1)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;

            public IntPtr SetExtendModeX;

            public IntPtr SetExtendModeY;

            public IntPtr SetInterpolationMode;

            public IntPtr SetBitmap;

            public IntPtr GetExtendModeX;

            public IntPtr GetExtendModeY;

            public IntPtr GetInterpolationMode;

            public IntPtr GetBitmap;

            public IntPtr SetInterpolationMode1;

            public IntPtr GetInterpolationMode1;
        }
    }
}
