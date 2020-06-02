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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients)
        {
            return lpVtbl->SetCoefficients((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), coefficients);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampoutput)
        {
            return lpVtbl->SetClampOutput((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), clampoutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1(float Coeffcient1)
        {
            return lpVtbl->SetCoefficient1((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coeffcient1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCoefficient11((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2(float Coefficient2)
        {
            return lpVtbl->SetCoefficient2((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient2);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCoefficient21((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3(float Coefficient3)
        {
            return lpVtbl->SetCoefficient3((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient3);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCoefficient31((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4(float Coefficient4)
        {
            return lpVtbl->SetCoefficient4((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient4);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCoefficient41((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, D2D_VECTOR_4F*, int> SetCoefficients;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, int, int> SetClampOutput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, float, int> SetCoefficient1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int> SetCoefficient11;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, float, int> SetCoefficient2;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int> SetCoefficient21;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, float, int> SetCoefficient3;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int> SetCoefficient31;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, float, int> SetCoefficient4;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int> SetCoefficient41;
        }
    }
}
