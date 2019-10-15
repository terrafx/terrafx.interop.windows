// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41343A53-E41A-49A2-91CD-21793BBB62E5")]
    public unsafe partial struct ID2D1BitmapBrush1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BitmapBrush1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1BitmapBrush1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOpacity(ID2D1BitmapBrush1* pThis, [NativeTypeName("FLOAT")] float opacity);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1BitmapBrush1* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1BitmapBrush1* pThis, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeX(ID2D1BitmapBrush1* pThis, D2D1_EXTEND_MODE extendModeX);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeY(ID2D1BitmapBrush1* pThis, D2D1_EXTEND_MODE extendModeY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInterpolationMode(ID2D1BitmapBrush1* pThis, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetBitmap(ID2D1BitmapBrush1* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeX(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeY(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_BITMAP_INTERPOLATION_MODE _GetInterpolationMode(ID2D1BitmapBrush1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetBitmap(ID2D1BitmapBrush1* pThis, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInterpolationMode1(ID2D1BitmapBrush1* pThis, D2D1_INTERPOLATION_MODE interpolationMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_INTERPOLATION_MODE _GetInterpolationMode1(ID2D1BitmapBrush1* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
        {
            Marshal.GetDelegateForFunctionPointer<_SetExtendModeX>(lpVtbl->SetExtendModeX)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), extendModeX);
        }

        public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
        {
            Marshal.GetDelegateForFunctionPointer<_SetExtendModeY>(lpVtbl->SetExtendModeY)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), extendModeY);
        }

        public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        public void SetBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap)
        {
            Marshal.GetDelegateForFunctionPointer<_SetBitmap>(lpVtbl->SetBitmap)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), bitmap);
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtendModeX>(lpVtbl->GetExtendModeX)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtendModeY>(lpVtbl->GetExtendModeY)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
        }

        public void GetBitmap([NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            Marshal.GetDelegateForFunctionPointer<_GetBitmap>(lpVtbl->GetBitmap)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), bitmap);
        }

        public void SetInterpolationMode1(D2D1_INTERPOLATION_MODE interpolationMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode1>(lpVtbl->SetInterpolationMode1)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode1()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterpolationMode1>(lpVtbl->GetInterpolationMode1)((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOpacity;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOpacity;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTransform;

            [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetExtendModeX;

            [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetExtendModeY;

            [NativeTypeName("void (D2D1_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInterpolationMode;

            [NativeTypeName("void (ID2D1Bitmap *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBitmap;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetExtendModeX;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetExtendModeY;

            [NativeTypeName("D2D1_BITMAP_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInterpolationMode;

            [NativeTypeName("void (ID2D1Bitmap **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBitmap;

            [NativeTypeName("void (D2D1_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInterpolationMode1;

            [NativeTypeName("D2D1_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInterpolationMode1;
        }
    }
}
