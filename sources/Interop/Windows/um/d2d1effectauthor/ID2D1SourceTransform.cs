// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB1800DD-0C34-4CF9-BE90-31CC0A5653E1")]
    [NativeTypeName("struct ID2D1SourceTransform : ID2D1Transform")]
    public unsafe partial struct ID2D1SourceTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, uint>)(lpVtbl[1]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, uint>)(lpVtbl[2]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, uint>)(lpVtbl[3]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, RECT*, RECT*, uint, int>)(lpVtbl[4]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, RECT*, RECT*, uint, RECT*, RECT*, int>)(lpVtbl[5]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, uint, RECT, RECT*, int>)(lpVtbl[6]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderInfo([NativeTypeName("ID2D1RenderInfo *")] ID2D1RenderInfo* renderInfo)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)(lpVtbl[7]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), renderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("ID2D1Bitmap1 *")] ID2D1Bitmap1* target, [NativeTypeName("const D2D1_RECT_L *")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin)
        {
            return ((delegate* stdcall<ID2D1SourceTransform*, ID2D1Bitmap1*, RECT*, D2D_POINT_2U, int>)(lpVtbl[8]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), target, drawRect, targetOrigin);
        }
    }
}
