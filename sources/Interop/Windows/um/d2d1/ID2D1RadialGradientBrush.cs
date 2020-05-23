// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906AC-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1RadialGradientBrush
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1RadialGradientBrush* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1RadialGradientBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1RadialGradientBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFactory(ID2D1RadialGradientBrush* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetOpacity(ID2D1RadialGradientBrush* pThis, [NativeTypeName("FLOAT")] float opacity);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetTransform(ID2D1RadialGradientBrush* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1RadialGradientBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetTransform(ID2D1RadialGradientBrush* pThis, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetCenter(ID2D1RadialGradientBrush* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGradientOriginOffset(ID2D1RadialGradientBrush* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetRadiusX(ID2D1RadialGradientBrush* pThis, [NativeTypeName("FLOAT")] float radiusX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetRadiusY(ID2D1RadialGradientBrush* pThis, [NativeTypeName("FLOAT")] float radiusY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public delegate D2D_POINT_2F* _GetCenter(ID2D1RadialGradientBrush* pThis, D2D_POINT_2F* _result);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public delegate D2D_POINT_2F* _GetGradientOriginOffset(ID2D1RadialGradientBrush* pThis, D2D_POINT_2F* _result);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetRadiusX(ID2D1RadialGradientBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetRadiusY(ID2D1RadialGradientBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetGradientStopCollection(ID2D1RadialGradientBrush* pThis, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetCenter([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center)
        {
            Marshal.GetDelegateForFunctionPointer<_SetCenter>(lpVtbl->SetCenter)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), center);
        }

        public void SetGradientOriginOffset([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGradientOriginOffset>(lpVtbl->SetGradientOriginOffset)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), gradientOriginOffset);
        }

        public void SetRadiusX([NativeTypeName("FLOAT")] float radiusX)
        {
            Marshal.GetDelegateForFunctionPointer<_SetRadiusX>(lpVtbl->SetRadiusX)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), radiusX);
        }

        public void SetRadiusY([NativeTypeName("FLOAT")] float radiusY)
        {
            Marshal.GetDelegateForFunctionPointer<_SetRadiusY>(lpVtbl->SetRadiusY)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), radiusY);
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetCenter()
        {
            D2D_POINT_2F result;
            return *Marshal.GetDelegateForFunctionPointer<_GetCenter>(lpVtbl->GetCenter)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetGradientOriginOffset()
        {
            D2D_POINT_2F result;
            return *Marshal.GetDelegateForFunctionPointer<_GetGradientOriginOffset>(lpVtbl->GetGradientOriginOffset)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusX()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRadiusX>(lpVtbl->GetRadiusX)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusY()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRadiusY>(lpVtbl->GetRadiusY)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetGradientStopCollection([NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            Marshal.GetDelegateForFunctionPointer<_GetGradientStopCollection>(lpVtbl->GetGradientStopCollection)((ID2D1RadialGradientBrush*)Unsafe.AsPointer(ref this), gradientStopCollection);
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

            [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCenter;

            [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGradientOriginOffset;

            [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRadiusX;

            [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRadiusY;

            [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCenter;

            [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientOriginOffset;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRadiusX;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRadiusY;

            [NativeTypeName("void (ID2D1GradientStopCollection **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientStopCollection;
        }
    }
}
