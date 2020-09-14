// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EF8A8135-5CC6-45FE-8825-C5A0724EB819")]
    [NativeTypeName("struct IDWriteTextRenderer : IDWritePixelSnapping")]
    public unsafe partial struct IDWriteTextRenderer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, uint>)(lpVtbl[1]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, uint>)(lpVtbl[2]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("BOOL *")] int* isDisabled)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, int*, int>)(lpVtbl[3]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, DWRITE_MATRIX*, int>)(lpVtbl[4]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT *")] float* pixelsPerDip)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float*, int>)(lpVtbl[5]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int>)(lpVtbl[6]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawUnderline([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_UNDERLINE*, IUnknown*, int>)(lpVtbl[7]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawStrikethrough([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_STRIKETHROUGH*, IUnknown*, int>)(lpVtbl[8]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawInlineObject([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, IDWriteInlineObject*, int, int, IUnknown*, int>)(lpVtbl[9]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        }
    }
}
