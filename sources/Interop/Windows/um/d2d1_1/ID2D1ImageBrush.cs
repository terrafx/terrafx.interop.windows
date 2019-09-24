// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Provides a brush that can take any effect, command list or bitmap and use it to fill a 2D shape.</summary>
    [Guid("FE9E984D-3F95-407C-B5DB-CB94D4E8F87C")]
    public unsafe struct ID2D1ImageBrush
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ImageBrush* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ImageBrush* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ImageBrush* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1ImageBrush* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1ImageBrush* This,
            [In, NativeTypeName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1ImageBrush* This,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1ImageBrush* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1ImageBrush* This,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetImage(
            [In] ID2D1ImageBrush* This,
            [In] ID2D1Image* image = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetExtendModeX(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_EXTEND_MODE extendModeX
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetExtendModeY(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_EXTEND_MODE extendModeY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetInterpolationMode(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetSourceRectangle(
            [In] ID2D1ImageBrush* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetImage(
            [In] ID2D1ImageBrush* This,
            [Out] ID2D1Image** image
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeX(
            [In] ID2D1ImageBrush* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeY(
            [In] ID2D1ImageBrush* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_INTERPOLATION_MODE _GetInterpolationMode(
            [In] ID2D1ImageBrush* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetSourceRectangle(
            [In] ID2D1ImageBrush* This,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }

        public void SetImage(
            [In] ID2D1Image* image = null
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetImage>(lpVtbl->SetImage)(
                    This,
                    image
                );
            }
        }

        public void SetExtendModeX(
            [In] D2D1_EXTEND_MODE extendModeX
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeY>(lpVtbl->SetExtendModeY)(
                    This,
                    extendModeY
                );
            }
        }

        public void SetInterpolationMode(
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)(
                    This,
                    interpolationMode
                );
            }
        }

        public void SetSourceRectangle(
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetSourceRectangle>(lpVtbl->SetSourceRectangle)(
                    This,
                    sourceRectangle
                );
            }
        }

        public void GetImage(
            [Out] ID2D1Image** image
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetImage>(lpVtbl->GetImage)(
                    This,
                    image
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeX>(lpVtbl->GetExtendModeX)(
                    This
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeY>(lpVtbl->GetExtendModeY)(
                    This
                );
            }
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)(
                    This
                );
            }
        }

        public void GetSourceRectangle(
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetSourceRectangle>(lpVtbl->GetSourceRectangle)(
                    This,
                    sourceRectangle
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

            public IntPtr SetImage;

            public IntPtr SetExtendModeX;

            public IntPtr SetExtendModeY;

            public IntPtr SetInterpolationMode;

            public IntPtr SetSourceRectangle;

            public IntPtr GetImage;

            public IntPtr GetExtendModeX;

            public IntPtr GetExtendModeY;

            public IntPtr GetInterpolationMode;

            public IntPtr GetSourceRectangle;
        }
    }
}
