// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45D4D0B7-1BD4-454E-8894-2BFA68443033")]
    public unsafe partial struct IDCompositionGaussianBlurEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionGaussianBlurEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionGaussianBlurEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionGaussianBlurEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionGaussianBlurEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStandardDeviation(IDCompositionGaussianBlurEffect* pThis, float amount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStandardDeviation1(IDCompositionGaussianBlurEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBorderMode(IDCompositionGaussianBlurEffect* pThis, D2D1_BORDER_MODE mode);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation(float amount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStandardDeviation>(lpVtbl->SetStandardDeviation)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStandardDeviation1>(lpVtbl->SetStandardDeviation1)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(D2D1_BORDER_MODE mode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBorderMode>(lpVtbl->SetBorderMode)((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), mode);
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

            [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBorderMode;
        }
    }
}
