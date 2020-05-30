// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AD18AC0-CFD2-4C2F-BB62-96E54FDB6879")]
    public unsafe partial struct IDCompositionShadowEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionShadowEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionShadowEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionShadowEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionShadowEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStandardDeviation(IDCompositionShadowEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStandardDeviation1(IDCompositionShadowEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColor(IDCompositionShadowEffect* pThis, [NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRed(IDCompositionShadowEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRed1(IDCompositionShadowEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreen(IDCompositionShadowEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreen1(IDCompositionShadowEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlue(IDCompositionShadowEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlue1(IDCompositionShadowEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlpha(IDCompositionShadowEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlpha1(IDCompositionShadowEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStandardDeviation>(lpVtbl->SetStandardDeviation)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStandardDeviation1>(lpVtbl->SetStandardDeviation1)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColor>(lpVtbl->SetColor)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRed(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRed>(lpVtbl->SetRed)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRed([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRed1>(lpVtbl->SetRed1)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreen(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreen>(lpVtbl->SetGreen)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreen([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreen1>(lpVtbl->SetGreen1)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlue(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlue>(lpVtbl->SetBlue)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlue([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlue1>(lpVtbl->SetBlue1)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlpha(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlpha>(lpVtbl->SetAlpha)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlpha([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlpha1>(lpVtbl->SetAlpha1)((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStandardDeviation;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStandardDeviation1;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetColor;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRed;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRed1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreen;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreen1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlue;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlue1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlpha;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlpha1;
        }
    }
}
