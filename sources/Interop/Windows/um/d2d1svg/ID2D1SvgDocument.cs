// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
    public unsafe partial struct ID2D1SvgDocument
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
        {
            return lpVtbl->SetViewportSize((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetViewportSize()
        {
            D2D_SIZE_F result;
            return *lpVtbl->GetViewportSize((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRoot([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* root)
        {
            return lpVtbl->SetRoot((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        public void GetRoot([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** root)
        {
            lpVtbl->GetRoot((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindElementById([NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** svgElement)
        {
            return lpVtbl->FindElementById((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("IStream *")] IStream* outputXmlStream, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* subtree = null)
        {
            return lpVtbl->Serialize((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
        }

        [return: NativeTypeName("HRESULT")]
        public int Deserialize([NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** subtree)
        {
            return lpVtbl->Deserialize((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** paint)
        {
            return lpVtbl->CreatePaint((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeDashArray([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            return lpVtbl->CreateStrokeDashArray((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePointCollection([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** pointCollection)
        {
            return lpVtbl->CreatePointCollection((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathData([NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** pathData)
        {
            return lpVtbl->CreatePathData((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (D2D1_SIZE_F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, D2D_SIZE_F, int> SetViewportSize;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, D2D_SIZE_F*, D2D_SIZE_F*> GetViewportSize;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, ID2D1SvgElement*, int> SetRoot;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, ID2D1SvgElement**, void> GetRoot;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, ushort*, ID2D1SvgElement**, int> FindElementById;

            [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int> Serialize;

            [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int> Deserialize;

            [NativeTypeName("HRESULT (D2D1_SVG_PAINT_TYPE, const D2D1_COLOR_F *, PCWSTR, ID2D1SvgPaint **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, D2D1_SVG_PAINT_TYPE, DXGI_RGBA*, ushort*, ID2D1SvgPaint**, int> CreatePaint;

            [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, ID2D1SvgStrokeDashArray **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, D2D1_SVG_LENGTH*, uint, ID2D1SvgStrokeDashArray**, int> CreateStrokeDashArray;

            [NativeTypeName("HRESULT (const D2D1_POINT_2F *, UINT32, ID2D1SvgPointCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int> CreatePointCollection;

            [NativeTypeName("HRESULT (const FLOAT *, UINT32, const D2D1_SVG_PATH_COMMAND *, UINT32, ID2D1SvgPathData **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgDocument*, float*, uint, D2D1_SVG_PATH_COMMAND*, uint, ID2D1SvgPathData**, int> CreatePathData;
        }
    }
}
