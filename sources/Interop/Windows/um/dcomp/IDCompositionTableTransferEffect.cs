// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E82E2-69C5-4EB4-A5F5-A7033F5132CD")]
    [NativeTypeName("struct IDCompositionTableTransferEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionTableTransferEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint>)(lpVtbl[1]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint>)(lpVtbl[2]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(uint index, IUnknown* input, uint flags)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetRedTable([NativeTypeName("const float *")] float* tableValues, uint count)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[4]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetGreenTable([NativeTypeName("const float *")] float* tableValues, uint count)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[5]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetBlueTable([NativeTypeName("const float *")] float* tableValues, uint count)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[6]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetAlphaTable([NativeTypeName("const float *")] float* tableValues, uint count)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[7]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetRedDisable(BOOL redDisable)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int>)(lpVtbl[8]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGreenDisable(BOOL greenDisable)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int>)(lpVtbl[9]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetBlueDisable(BOOL blueDisable)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int>)(lpVtbl[10]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetAlphaDisable(BOOL alphaDisable)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int>)(lpVtbl[11]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetClampOutput(BOOL clampOutput)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int>)(lpVtbl[12]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetRedTableValue(uint index, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetRedTableValue(uint index, float value)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[14]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetGreenTableValue(uint index, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetGreenTableValue(uint index, float value)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[16]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetBlueTableValue(uint index, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetBlueTableValue(uint index, float value)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[18]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetAlphaTableValue(uint index, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetAlphaTableValue(uint index, float value)
        {
            return ((delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[20]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int> SetRedTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int> SetGreenTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int> SetBlueTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, float*, uint, int> SetAlphaTable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int> SetRedDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int> SetGreenDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int> SetBlueDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int> SetAlphaDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, BOOL, int> SetClampOutput;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetRedTableValue;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int> SetRedTableValue1;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetGreenTableValue;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int> SetGreenTableValue1;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetBlueTableValue;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int> SetBlueTableValue1;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetAlphaTableValue;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTableTransferEffect*, uint, float, int> SetAlphaTableValue1;
        }
    }
}
