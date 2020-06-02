// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("791E8298-3EF3-4230-9880-C9BDECC42064")]
    public unsafe partial struct IDWriteBitmapRenderTarget1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("COLORREF")] uint textColor, [NativeTypeName("RECT *")] RECT* blackBoxRect = null)
        {
            return lpVtbl->DrawGlyphRun((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        }

        [return: NativeTypeName("HDC")]
        public IntPtr GetMemoryDC()
        {
            return lpVtbl->GetMemoryDC((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetPixelsPerDip()
        {
            return lpVtbl->GetPixelsPerDip((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelsPerDip([NativeTypeName("FLOAT")] float pixelsPerDip)
        {
            return lpVtbl->SetPixelsPerDip((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), pixelsPerDip);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return lpVtbl->GetCurrentTransform((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return lpVtbl->SetCurrentTransform((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("SIZE *")] SIZE* size)
        {
            return lpVtbl->GetSize((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
        {
            return lpVtbl->Resize((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), width, height);
        }

        public DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return lpVtbl->GetTextAntialiasMode((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode)
        {
            return lpVtbl->SetTextAntialiasMode((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, uint> Release;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, IDWriteRenderingParams *, COLORREF, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, uint, RECT*, int> DrawGlyphRun;

            [NativeTypeName("HDC () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, IntPtr> GetMemoryDC;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, float> GetPixelsPerDip;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, float, int> SetPixelsPerDip;

            [NativeTypeName("HRESULT (DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int> GetCurrentTransform;

            [NativeTypeName("HRESULT (const DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int> SetCurrentTransform;

            [NativeTypeName("HRESULT (SIZE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, SIZE*, int> GetSize;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, uint, uint, int> Resize;

            [NativeTypeName("DWRITE_TEXT_ANTIALIAS_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE> GetTextAntialiasMode;

            [NativeTypeName("HRESULT (DWRITE_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE, int> SetTextAntialiasMode;
        }
    }
}
