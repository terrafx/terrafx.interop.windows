// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B67DFA8-E3DD-4E61-B640-46C2F3D739DC")]
    public unsafe partial struct IDCompositionArithmeticCompositeEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionArithmeticCompositeEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionArithmeticCompositeEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficients(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClampOutput(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("BOOL")] int clampoutput);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient1(IDCompositionArithmeticCompositeEffect* pThis, float Coeffcient1);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient11(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient2(IDCompositionArithmeticCompositeEffect* pThis, float Coefficient2);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient21(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient3(IDCompositionArithmeticCompositeEffect* pThis, float Coefficient3);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient31(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient4(IDCompositionArithmeticCompositeEffect* pThis, float Coefficient4);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCoefficient41(IDCompositionArithmeticCompositeEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficients>(lpVtbl->SetCoefficients)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), coefficients);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampoutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClampOutput>(lpVtbl->SetClampOutput)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), clampoutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1(float Coeffcient1)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient1>(lpVtbl->SetCoefficient1)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coeffcient1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient11>(lpVtbl->SetCoefficient11)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2(float Coefficient2)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient2>(lpVtbl->SetCoefficient2)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient2);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient21>(lpVtbl->SetCoefficient21)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3(float Coefficient3)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient3>(lpVtbl->SetCoefficient3)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient3);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient31>(lpVtbl->SetCoefficient31)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4(float Coefficient4)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient4>(lpVtbl->SetCoefficient4)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient4);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCoefficient41>(lpVtbl->SetCoefficient41)((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
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

            [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficients;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClampOutput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient11;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient2;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient21;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient3;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient31;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient4;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCoefficient41;
        }
    }
}
