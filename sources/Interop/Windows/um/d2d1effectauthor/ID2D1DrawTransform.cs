// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36BFDCB6-9739-435D-A30D-A653BEFF6A6F")]
    public unsafe partial struct ID2D1DrawTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, uint>)(lpVtbl[1]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, uint>)(lpVtbl[2]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, uint>)(lpVtbl[3]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, RECT*, RECT*, uint, int>)(lpVtbl[4]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, RECT*, RECT*, uint, RECT*, RECT*, int>)(lpVtbl[5]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, uint, RECT, RECT*, int>)(lpVtbl[6]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawInfo([NativeTypeName("ID2D1DrawInfo *")] ID2D1DrawInfo* drawInfo)
        {
            return ((delegate* stdcall<ID2D1DrawTransform*, ID2D1DrawInfo*, int>)(lpVtbl[7]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), drawInfo);
        }
    }
}
