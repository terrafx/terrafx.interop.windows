// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1SolidColorBrush
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SolidColorBrush* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SolidColorBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SolidColorBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SolidColorBrush* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOpacity(ID2D1SolidColorBrush* pThis, [NativeTypeName("FLOAT")] float opacity);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1SolidColorBrush* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1SolidColorBrush* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1SolidColorBrush* pThis, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetColor(ID2D1SolidColorBrush* pThis, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public delegate DXGI_RGBA* _GetColor(ID2D1SolidColorBrush* pThis, DXGI_RGBA* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            Marshal.GetDelegateForFunctionPointer<_SetColor>(lpVtbl->SetColor)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("D2D1_COLOR_F")]
        public DXGI_RGBA GetColor()
        {
            DXGI_RGBA result;
            return *Marshal.GetDelegateForFunctionPointer<_GetColor>(lpVtbl->GetColor)((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), &result);
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

            [NativeTypeName("void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetColor;

            [NativeTypeName("D2D1_COLOR_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColor;
        }
    }
}
