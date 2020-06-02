// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D85573C-01E3-4F7D-BFD9-0D60608BF3C3")]
    public unsafe partial struct ID2D1ComputeTransform
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            return lpVtbl->MapOutputRectToInputRects((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
        {
            return lpVtbl->MapInputRectsToOutputRect((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
        {
            return lpVtbl->MapInvalidRect((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeInfo([NativeTypeName("ID2D1ComputeInfo *")] ID2D1ComputeInfo* computeInfo)
        {
            return lpVtbl->SetComputeInfo((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), computeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CalculateThreadgroups([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("UINT32 *")] uint* dimensionX, [NativeTypeName("UINT32 *")] uint* dimensionY, [NativeTypeName("UINT32 *")] uint* dimensionZ)
        {
            return lpVtbl->CalculateThreadgroups((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, dimensionX, dimensionY, dimensionZ);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, uint> GetInputCount;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, D2D1_RECT_L *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, RECT*, RECT*, uint, int> MapOutputRectToInputRects;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, const D2D1_RECT_L *, UINT32, D2D1_RECT_L *, D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, RECT*, RECT*, uint, RECT*, RECT*, int> MapInputRectsToOutputRect;

            [NativeTypeName("HRESULT (UINT32, D2D1_RECT_L, D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, uint, RECT, RECT*, int> MapInvalidRect;

            [NativeTypeName("HRESULT (ID2D1ComputeInfo *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int> SetComputeInfo;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, UINT32 *, UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ComputeTransform*, RECT*, uint*, uint*, uint*, int> CalculateThreadgroups;
        }
    }
}
