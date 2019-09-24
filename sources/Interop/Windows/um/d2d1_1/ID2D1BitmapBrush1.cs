// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A bitmap brush allows a bitmap to be used to fill a geometry.  Interpolation mode is specified with D2D1_INTERPOLATION_MODE</summary>
    [Guid("41343A53-E41A-49A2-91CD-21793BBB62E5")]
    public unsafe struct ID2D1BitmapBrush1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BitmapBrush1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BitmapBrush1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BitmapBrush1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1BitmapBrush1* This, ID2D1Factory** factory);

        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOpacity(ID2D1BitmapBrush1* This, [NativeTypeName("FLOAT")] float opacity);

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1BitmapBrush1* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1BitmapBrush1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1BitmapBrush1* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeX(ID2D1BitmapBrush1* This, D2D1_EXTEND_MODE extendModeX);

        /// <summary>Sets how the bitmap is to be treated outside of its natural extent on the X axis.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeY(ID2D1BitmapBrush1* This, D2D1_EXTEND_MODE extendModeY);

        /// <summary>Sets the interpolation mode used when this brush is used.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInterpolationMode(ID2D1BitmapBrush1* This, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);

        /// <summary>Sets the bitmap associated as the source of this brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetBitmap(ID2D1BitmapBrush1* This, ID2D1Bitmap* bitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeX(ID2D1BitmapBrush1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeY(ID2D1BitmapBrush1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_BITMAP_INTERPOLATION_MODE _GetInterpolationMode(ID2D1BitmapBrush1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetBitmap(ID2D1BitmapBrush1* This, ID2D1Bitmap** bitmap);

        /// <summary>Sets the interpolation mode used when this brush is used.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInterpolationMode1(ID2D1BitmapBrush1* This, D2D1_INTERPOLATION_MODE interpolationMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_INTERPOLATION_MODE _GetInterpolationMode1(ID2D1BitmapBrush1* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)(This, opacity);
            }
        }

        public void SetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(This, transform);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)(This);
            }
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(This, transform);
            }
        }

        public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeX>(lpVtbl->SetExtendModeX)(This, extendModeX);
            }
        }

        public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeY>(lpVtbl->SetExtendModeY)(This, extendModeY);
            }
        }

        public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)(This, interpolationMode);
            }
        }

        public void SetBitmap(ID2D1Bitmap* bitmap = null)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetBitmap>(lpVtbl->SetBitmap)(This, bitmap);
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeX>(lpVtbl->GetExtendModeX)(This);
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeY>(lpVtbl->GetExtendModeY)(This);
            }
        }

        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)(This);
            }
        }

        public void GetBitmap(ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetBitmap>(lpVtbl->GetBitmap)(This, bitmap);
            }
        }

        public void SetInterpolationMode1(D2D1_INTERPOLATION_MODE interpolationMode)
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode1>(lpVtbl->SetInterpolationMode1)(This, interpolationMode);
            }
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode1()
        {
            fixed (ID2D1BitmapBrush1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode1>(lpVtbl->GetInterpolationMode1)(This);
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
