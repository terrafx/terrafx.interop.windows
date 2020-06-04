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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, uint>)(lpVtbl[1]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, uint>)(lpVtbl[2]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgPaint*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            ((delegate* stdcall<ID2D1SvgPaint*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE, int>)(lpVtbl[6]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), paintType);
        }

        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE>)(lpVtbl[7]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, DXGI_RGBA*, int>)(lpVtbl[8]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        public void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            ((delegate* stdcall<ID2D1SvgPaint*, DXGI_RGBA*, void>)(lpVtbl[9]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("PCWSTR")] ushort* id)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, ushort*, int>)(lpVtbl[10]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount)
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, ushort*, uint, int>)(lpVtbl[11]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id, idCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            return ((delegate* stdcall<ID2D1SvgPaint*, uint>)(lpVtbl[12]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }
    }
}
