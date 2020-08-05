// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("791E8298-3EF3-4230-9880-C9BDECC42064")]
    [NativeTypeName("struct IDWriteBitmapRenderTarget1 : IDWriteBitmapRenderTarget")]
    public unsafe partial struct IDWriteBitmapRenderTarget1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, uint>)(lpVtbl[1]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, uint>)(lpVtbl[2]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("COLORREF")] uint textColor, [NativeTypeName("RECT *")] RECT* blackBoxRect = null)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, uint, RECT*, int>)(lpVtbl[3]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        }

        [return: NativeTypeName("HDC")]
        public IntPtr GetMemoryDC()
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, IntPtr>)(lpVtbl[4]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetPixelsPerDip()
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, float>)(lpVtbl[5]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelsPerDip([NativeTypeName("FLOAT")] float pixelsPerDip)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, float, int>)(lpVtbl[6]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), pixelsPerDip);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int>)(lpVtbl[7]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int>)(lpVtbl[8]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("SIZE *")] SIZE* size)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, SIZE*, int>)(lpVtbl[9]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, uint, uint, int>)(lpVtbl[10]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), width, height);
        }

        public DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE>)(lpVtbl[11]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode)
        {
            return ((delegate* stdcall<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE, int>)(lpVtbl[12]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), antialiasMode);
        }
    }
}
