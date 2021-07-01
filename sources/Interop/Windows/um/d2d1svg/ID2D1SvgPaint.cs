// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
    [NativeTypeName("struct ID2D1SvgPaint : ID2D1SvgAttribute")]
    public unsafe partial struct ID2D1SvgPaint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, uint>)(lpVtbl[1]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, uint>)(lpVtbl[2]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SvgPaint*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetElement(ID2D1SvgElement** element)
        {
            ((delegate* unmanaged<ID2D1SvgPaint*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ID2D1SvgAttribute** attribute)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE, int>)(lpVtbl[6]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), paintType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, D2D1_SVG_PAINT_TYPE>)(lpVtbl[7]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, DXGI_RGBA*, int>)(lpVtbl[8]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            ((delegate* unmanaged<ID2D1SvgPaint*, DXGI_RGBA*, void>)(lpVtbl[9]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("PCWSTR")] ushort* id)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, ushort*, int>)(lpVtbl[10]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount)
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, ushort*, uint, int>)(lpVtbl[11]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id, idCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            return ((delegate* unmanaged<ID2D1SvgPaint*, uint>)(lpVtbl[12]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }
    }
}
