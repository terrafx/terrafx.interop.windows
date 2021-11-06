// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6A55BDA-C09C-49F3-9193-A41922C89715")]
    [NativeTypeName("struct IDCompositionTurbulenceEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionTurbulenceEffect : IDCompositionTurbulenceEffect.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[1]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[2]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(uint index, IUnknown* input, uint flags)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetBaseFrequency([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), frequency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[6]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNumOctaves(uint numOctaves)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[7]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), numOctaves);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetSeed(uint seed)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[8]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetNoise(D2D1_TURBULENCE_NOISE noise)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D1_TURBULENCE_NOISE, int>)(lpVtbl[9]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), noise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetStitchable(BOOL stitchable)
        {
            return ((delegate* unmanaged<IDCompositionTurbulenceEffect*, BOOL, int>)(lpVtbl[10]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), stitchable);
        }

        public interface Interface : IDCompositionFilterEffect.Interface
        {
            [VtblIndex(4)]
            HRESULT SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset);

            [VtblIndex(5)]
            HRESULT SetBaseFrequency([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency);

            [VtblIndex(6)]
            HRESULT SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size);

            [VtblIndex(7)]
            HRESULT SetNumOctaves(uint numOctaves);

            [VtblIndex(8)]
            HRESULT SetSeed(uint seed);

            [VtblIndex(9)]
            HRESULT SetNoise(D2D1_TURBULENCE_NOISE noise);

            [VtblIndex(10)]
            HRESULT SetStitchable(BOOL stitchable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetOffset;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetBaseFrequency;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, int> SetNumOctaves;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, uint, int> SetSeed;

            [NativeTypeName("HRESULT (D2D1_TURBULENCE_NOISE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, D2D1_TURBULENCE_NOISE, int> SetNoise;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTurbulenceEffect*, BOOL, int> SetStitchable;
        }
    }
}
