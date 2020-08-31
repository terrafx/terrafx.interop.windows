// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E82E2-69C5-4EB4-A5F5-A7033F5132CD")]
    [NativeTypeName("struct IDCompositionTableTransferEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionTableTransferEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint>)(lpVtbl[1]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint>)(lpVtbl[2]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[4]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[5]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[6]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int>)(lpVtbl[7]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedDisable([NativeTypeName("BOOL")] int redDisable)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, int, int>)(lpVtbl[8]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenDisable([NativeTypeName("BOOL")] int greenDisable)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, int, int>)(lpVtbl[9]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueDisable([NativeTypeName("BOOL")] int blueDisable)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, int, int>)(lpVtbl[10]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaDisable([NativeTypeName("BOOL")] int alphaDisable)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, int, int>)(lpVtbl[11]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampOutput)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, int, int>)(lpVtbl[12]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[13]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[15]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[16]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[17]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[18]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int>)(lpVtbl[19]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int>)(lpVtbl[20]))((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }
    }
}
