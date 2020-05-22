// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EF8A8135-5CC6-45FE-8825-C5A0724EB819")]
    public unsafe partial struct IDWriteTextRenderer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextRenderer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextRenderer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextRenderer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsPixelSnappingDisabled(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("BOOL *")] int* isDisabled);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentTransform(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelsPerDip(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT *")] float* pixelsPerDip);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGlyphRun(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawUnderline(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawStrikethrough(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawInlineObject(IDWriteTextRenderer* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("BOOL *")] int* isDisabled)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsPixelSnappingDisabled>(lpVtbl->IsPixelSnappingDisabled)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentTransform>(lpVtbl->GetCurrentTransform)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT *")] float* pixelsPerDip)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelsPerDip>(lpVtbl->GetPixelsPerDip)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawUnderline([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawUnderline>(lpVtbl->DrawUnderline)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawStrikethrough([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawStrikethrough>(lpVtbl->DrawStrikethrough)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawInlineObject([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawInlineObject>(lpVtbl->DrawInlineObject)((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (void *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsPixelSnappingDisabled;

            [NativeTypeName("HRESULT (void *, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCurrentTransform;

            [NativeTypeName("HRESULT (void *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelsPerDip;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGlyphRun;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_UNDERLINE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawUnderline;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_STRIKETHROUGH *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawStrikethrough;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, IDWriteInlineObject *, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawInlineObject;
        }
    }
}
