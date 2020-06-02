// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
    public unsafe partial struct ID2D1SvgPaint
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            lpVtbl->GetElement((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return lpVtbl->Clone((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
        {
            return lpVtbl->SetPaintType((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), paintType);
        }

        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            return lpVtbl->GetPaintType((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return lpVtbl->SetColor((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        public void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            lpVtbl->GetColor((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("PCWSTR")] ushort* id)
        {
            return lpVtbl->SetId((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount)
        {
            return lpVtbl->GetId((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id, idCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            return lpVtbl->GetIdLength((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, ID2D1SvgElement**, void> GetElement;

            [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, ID2D1SvgAttribute**, int> Clone;

            [NativeTypeName("HRESULT (D2D1_SVG_PAINT_TYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE, int> SetPaintType;

            [NativeTypeName("D2D1_SVG_PAINT_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE> GetPaintType;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, DXGI_RGBA*, int> SetColor;

            [NativeTypeName("void (D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, DXGI_RGBA*, void> GetColor;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, ushort*, int> SetId;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, ushort*, uint, int> GetId;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPaint*, uint> GetIdLength;
        }
    }
}
