// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B0D941A0-85E7-4D8B-9FD3-5CED9934482A")]
    public unsafe partial struct IDWriteTextAnalysisSink1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScriptAnalysis([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis)
        {
            return lpVtbl->SetScriptAnalysis((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, scriptAnalysis);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineBreakpoints([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")] DWRITE_LINE_BREAKPOINT* lineBreakpoints)
        {
            return lpVtbl->SetLineBreakpoints((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, lineBreakpoints);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBidiLevel([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel)
        {
            return lpVtbl->SetBidiLevel((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, explicitLevel, resolvedLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution)
        {
            return lpVtbl->SetNumberSubstitution((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("UINT8")] byte adjustedBidiLevel, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft)
        {
            return lpVtbl->SetGlyphOrientation((IDWriteTextAnalysisSink1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways, isRightToLeft);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint> Release;

            [NativeTypeName("HRESULT (UINT32, UINT32, const DWRITE_SCRIPT_ANALYSIS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint, uint, DWRITE_SCRIPT_ANALYSIS*, int> SetScriptAnalysis;

            [NativeTypeName("HRESULT (UINT32, UINT32, const DWRITE_LINE_BREAKPOINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint, uint, DWRITE_LINE_BREAKPOINT*, int> SetLineBreakpoints;

            [NativeTypeName("HRESULT (UINT32, UINT32, UINT8, UINT8) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint, uint, byte, byte, int> SetBidiLevel;

            [NativeTypeName("HRESULT (UINT32, UINT32, IDWriteNumberSubstitution *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint, uint, IDWriteNumberSubstitution*, int> SetNumberSubstitution;

            [NativeTypeName("HRESULT (UINT32, UINT32, DWRITE_GLYPH_ORIENTATION_ANGLE, UINT8, BOOL, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalysisSink1*, uint, uint, DWRITE_GLYPH_ORIENTATION_ANGLE, byte, int, int, int> SetGlyphOrientation;
        }
    }
}
