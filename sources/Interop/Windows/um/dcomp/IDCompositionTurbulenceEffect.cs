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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionTurbulenceEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionTurbulenceEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffset(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBaseFrequency(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNumOctaves(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("UINT")] uint numOctaves);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSeed(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("UINT")] uint seed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNoise(IDCompositionTurbulenceEffect* pThis, D2D1_TURBULENCE_NOISE noise);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStitchable(IDCompositionTurbulenceEffect* pThis, [NativeTypeName("BOOL")] int stitchable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffset>(lpVtbl->SetOffset)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), offset);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBaseFrequency([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBaseFrequency>(lpVtbl->SetBaseFrequency)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), frequency);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumOctaves([NativeTypeName("UINT")] uint numOctaves)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNumOctaves>(lpVtbl->SetNumOctaves)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), numOctaves);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSeed([NativeTypeName("UINT")] uint seed)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSeed>(lpVtbl->SetSeed)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), seed);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoise(D2D1_TURBULENCE_NOISE noise)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNoise>(lpVtbl->SetNoise)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), noise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStitchable([NativeTypeName("BOOL")] int stitchable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStitchable>(lpVtbl->SetStitchable)((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), stitchable);
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

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffset;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBaseFrequency;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetNumOctaves;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSeed;

            [NativeTypeName("HRESULT (D2D1_TURBULENCE_NOISE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetNoise;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStitchable;
        }
    }
}
