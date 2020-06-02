// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB1800DD-0C34-4CF9-BE90-31CC0A5653E1")]
    public unsafe partial struct ID2D1SourceTransform
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            return lpVtbl->MapOutputRectToInputRects((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
        {
            return lpVtbl->MapInputRectsToOutputRect((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
        {
            return lpVtbl->MapInvalidRect((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderInfo([NativeTypeName("ID2D1RenderInfo *")] ID2D1RenderInfo* renderInfo)
        {
            return lpVtbl->SetRenderInfo((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), renderInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("ID2D1Bitmap1 *")] ID2D1Bitmap1* target, [NativeTypeName("const D2D1_RECT_L *")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin)
        {
            return lpVtbl->Draw((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), target, drawRect, targetOrigin);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, uint> GetInputCount;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, D2D1_RECT_L *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, RECT*, RECT*, uint, int> MapOutputRectToInputRects;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, const D2D1_RECT_L *, UINT32, D2D1_RECT_L *, D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, RECT*, RECT*, uint, RECT*, RECT*, int> MapInputRectsToOutputRect;

            [NativeTypeName("HRESULT (UINT32, D2D1_RECT_L, D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, uint, RECT, RECT*, int> MapInvalidRect;

            [NativeTypeName("HRESULT (ID2D1RenderInfo *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, ID2D1RenderInfo*, int> SetRenderInfo;

            [NativeTypeName("HRESULT (ID2D1Bitmap1 *, const D2D1_RECT_L *, D2D1_POINT_2U) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SourceTransform*, ID2D1Bitmap1*, RECT*, D2D_POINT_2U, int> Draw;
        }
    }
}
