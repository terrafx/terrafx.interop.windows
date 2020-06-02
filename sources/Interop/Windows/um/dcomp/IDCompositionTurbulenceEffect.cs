// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6A55BDA-C09C-49F3-9193-A41922C89715")]
    public unsafe partial struct IDCompositionTurbulenceEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset)
        {
            return lpVtbl->SetOffset((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), offset);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBaseFrequency([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency)
        {
            return lpVtbl->SetBaseFrequency((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), frequency);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size)
        {
            return lpVtbl->SetSize((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumOctaves([NativeTypeName("UINT")] uint numOctaves)
        {
            return lpVtbl->SetNumOctaves((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), numOctaves);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSeed([NativeTypeName("UINT")] uint seed)
        {
            return lpVtbl->SetSeed((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), seed);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoise(D2D1_TURBULENCE_NOISE noise)
        {
            return lpVtbl->SetNoise((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), noise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStitchable([NativeTypeName("BOOL")] int stitchable)
        {
            return lpVtbl->SetStitchable((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), stitchable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetOffset;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetBaseFrequency;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int> SetSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, uint, int> SetNumOctaves;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, uint, int> SetSeed;

            [NativeTypeName("HRESULT (D2D1_TURBULENCE_NOISE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, D2D1_TURBULENCE_NOISE, int> SetNoise;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTurbulenceEffect*, int, int> SetStitchable;
        }
    }
}
