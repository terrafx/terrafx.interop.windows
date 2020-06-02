// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E82E2-69C5-4EB4-A5F5-A7033F5132CD")]
    public unsafe partial struct IDCompositionTableTransferEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return lpVtbl->SetRedTable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return lpVtbl->SetGreenTable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return lpVtbl->SetBlueTable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return lpVtbl->SetAlphaTable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedDisable([NativeTypeName("BOOL")] int redDisable)
        {
            return lpVtbl->SetRedDisable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenDisable([NativeTypeName("BOOL")] int greenDisable)
        {
            return lpVtbl->SetGreenDisable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueDisable([NativeTypeName("BOOL")] int blueDisable)
        {
            return lpVtbl->SetBlueDisable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaDisable([NativeTypeName("BOOL")] int alphaDisable)
        {
            return lpVtbl->SetAlphaDisable((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampOutput)
        {
            return lpVtbl->SetClampOutput((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return lpVtbl->SetRedTableValue((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetRedTableValue1((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return lpVtbl->SetGreenTableValue((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetGreenTableValue1((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return lpVtbl->SetBlueTableValue((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBlueTableValue1((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return lpVtbl->SetAlphaTableValue((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAlphaTableValue1((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int> SetRedTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int> SetGreenTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int> SetBlueTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, float*, uint, int> SetAlphaTable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, int, int> SetRedDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, int, int> SetGreenDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, int, int> SetBlueDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, int, int> SetAlphaDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, int, int> SetClampOutput;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int> SetRedTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetRedTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int> SetGreenTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetGreenTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int> SetBlueTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetBlueTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, float, int> SetAlphaTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionTableTransferEffect*, uint, IDCompositionAnimation*, int> SetAlphaTableValue1;
        }
    }
}
