// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
    [NativeTypeName("struct ID2D1SvgDocument : ID2D1Resource")]
    public unsafe partial struct ID2D1SvgDocument
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, uint>)(lpVtbl[1]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, uint>)(lpVtbl[2]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgDocument*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, D2D_SIZE_F, int>)(lpVtbl[4]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetViewportSize()
        {
            D2D_SIZE_F result;
            return *((delegate* stdcall<ID2D1SvgDocument*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[5]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRoot([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* root)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, ID2D1SvgElement*, int>)(lpVtbl[6]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetRoot([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** root)
        {
            ((delegate* stdcall<ID2D1SvgDocument*, ID2D1SvgElement**, void>)(lpVtbl[7]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindElementById([NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** svgElement)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[8]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("IStream *")] IStream* outputXmlStream, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* subtree = null)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)(lpVtbl[9]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deserialize([NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** subtree)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)(lpVtbl[10]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** paint)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, D2D1_SVG_PAINT_TYPE, DXGI_RGBA*, ushort*, ID2D1SvgPaint**, int>)(lpVtbl[11]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeDashArray([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, D2D1_SVG_LENGTH*, uint, ID2D1SvgStrokeDashArray**, int>)(lpVtbl[12]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePointCollection([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** pointCollection)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)(lpVtbl[13]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePathData([NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** pathData)
        {
            return ((delegate* stdcall<ID2D1SvgDocument*, float*, uint, D2D1_SVG_PATH_COMMAND*, uint, ID2D1SvgPathData**, int>)(lpVtbl[14]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
        }
    }
}
