// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CBFD91D9-51B2-45E4-B3DE-D19CCFB863C5")]
    [NativeTypeName("struct IDCompositionAnimation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDCompositionAnimation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, uint>)(lpVtbl[1]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, uint>)(lpVtbl[2]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAbsoluteBeginTime(LARGE_INTEGER beginTime)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, LARGE_INTEGER, int>)(lpVtbl[4]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, double, float, float, float, float, int>)(lpVtbl[5]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, double, float, float, float, float, int>)(lpVtbl[6]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, bias, amplitude, frequency, phase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddRepeat(double beginOffset, double durationToRepeat)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, double, double, int>)(lpVtbl[7]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, durationToRepeat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT End(double endOffset, float endValue)
        {
            return ((delegate* unmanaged<IDCompositionAnimation*, double, float, int>)(lpVtbl[8]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), endOffset, endValue);
        }
    }
}
