// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B67DFA8-E3DD-4E61-B640-46C2F3D739DC")]
    [NativeTypeName("struct IDCompositionArithmeticCompositeEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionArithmeticCompositeEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[1]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[2]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, D2D_VECTOR_4F*, int>)(lpVtbl[4]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), coefficients);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetClampOutput(BOOL clampoutput)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, BOOL, int>)(lpVtbl[5]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), clampoutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetCoefficient1(float Coeffcient1)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[7]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coeffcient1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetCoefficient1(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetCoefficient2(float Coefficient2)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[9]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetCoefficient2(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetCoefficient3(float Coefficient3)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[11]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCoefficient3(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetCoefficient4(float Coefficient4)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[13]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetCoefficient4(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
