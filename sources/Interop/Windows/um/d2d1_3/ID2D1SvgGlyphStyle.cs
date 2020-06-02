// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    public unsafe partial struct ID2D1SvgGlyphStyle
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFill([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return lpVtbl->SetFill((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        public void GetFill([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush)
        {
            lpVtbl->GetFill((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStroke([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("const FLOAT *")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float dashOffset = 1.0f)
        {
            return lpVtbl->SetStroke((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            return lpVtbl->GetStrokeDashesCount((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetStroke([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush, [NativeTypeName("FLOAT *")] float* strokeWidth = null, [NativeTypeName("FLOAT *")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT *")] float* dashOffset = null)
        {
            lpVtbl->GetStroke((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush*, int> SetFill;

            [NativeTypeName("void (ID2D1Brush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush**, void> GetFill;

            [NativeTypeName("HRESULT (ID2D1Brush *, FLOAT, const FLOAT *, UINT32, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int> SetStroke;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, uint> GetStrokeDashesCount;

            [NativeTypeName("void (ID2D1Brush **, FLOAT *, FLOAT *, UINT32, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void> GetStroke;
        }
    }
}
