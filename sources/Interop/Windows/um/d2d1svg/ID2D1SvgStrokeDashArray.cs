// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1C0CA52-92A3-4F00-B4CE-F35691EFD9D9")]
    [NativeTypeName("struct ID2D1SvgStrokeDashArray : ID2D1SvgAttribute")]
    public unsafe partial struct ID2D1SvgStrokeDashArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, uint>)(lpVtbl[1]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, uint>)(lpVtbl[2]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            ((delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, uint, int>)(lpVtbl[6]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)(lpVtbl[9]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int>)(lpVtbl[10]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return ((delegate* stdcall<ID2D1SvgStrokeDashArray*, uint>)(lpVtbl[11]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }
    }
}
