// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1C0CA52-92A3-4F00-B4CE-F35691EFD9D9")]
    public unsafe partial struct ID2D1SvgStrokeDashArray
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            lpVtbl->GetElement((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return lpVtbl->Clone((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount)
        {
            return lpVtbl->RemoveDashesAtEnd((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->UpdateDashes((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->UpdateDashes1((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->GetDashes((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->GetDashes1((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return lpVtbl->GetDashesCount((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1SvgElement**, void> GetElement;

            [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, ID2D1SvgAttribute**, int> Clone;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, uint, int> RemoveDashesAtEnd;

            [NativeTypeName("HRESULT (const FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, float*, uint, uint, int> UpdateDashes;

            [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int> UpdateDashes1;

            [NativeTypeName("HRESULT (FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, float*, uint, uint, int> GetDashes;

            [NativeTypeName("HRESULT (D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int> GetDashes1;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgStrokeDashArray*, uint> GetDashesCount;
        }
    }
}
