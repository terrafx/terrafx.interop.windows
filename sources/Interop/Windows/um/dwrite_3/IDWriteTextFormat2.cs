// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F67E0EDD-9E3D-4ECC-8C32-4183253DFE70")]
    public unsafe partial struct IDWriteTextFormat2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return lpVtbl->SetTextAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return lpVtbl->SetParagraphAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return lpVtbl->SetWordWrapping((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return lpVtbl->SetReadingDirection((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return lpVtbl->SetFlowDirection((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return lpVtbl->SetIncrementalTabStop((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return lpVtbl->SetTrimming((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return lpVtbl->SetLineSpacing((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return lpVtbl->GetTextAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return lpVtbl->GetParagraphAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return lpVtbl->GetWordWrapping((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return lpVtbl->GetReadingDirection((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return lpVtbl->GetFlowDirection((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return lpVtbl->GetIncrementalTabStop((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return lpVtbl->GetTrimming((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return lpVtbl->GetLineSpacing((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return lpVtbl->GetFontCollection((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return lpVtbl->GetFontFamilyNameLength((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return lpVtbl->GetFontFamilyName((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return lpVtbl->GetFontWeight((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return lpVtbl->GetFontStyle((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return lpVtbl->GetFontStretch((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return lpVtbl->GetFontSize((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return lpVtbl->GetLocaleNameLength((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return lpVtbl->GetLocaleName((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return lpVtbl->SetVerticalGlyphOrientation((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return lpVtbl->GetVerticalGlyphOrientation((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return lpVtbl->SetLastLineWrapping((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return lpVtbl->GetLastLineWrapping((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return lpVtbl->SetOpticalAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return lpVtbl->GetOpticalAlignment((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return lpVtbl->SetFontFallback((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return lpVtbl->GetFontFallback((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return lpVtbl->SetLineSpacing1((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return lpVtbl->GetLineSpacing1((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, uint> Release;

            [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_TEXT_ALIGNMENT, int> SetTextAlignment;

            [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_PARAGRAPH_ALIGNMENT, int> SetParagraphAlignment;

            [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_WORD_WRAPPING, int> SetWordWrapping;

            [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_READING_DIRECTION, int> SetReadingDirection;

            [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_FLOW_DIRECTION, int> SetFlowDirection;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, float, int> SetIncrementalTabStop;

            [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> SetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING_METHOD, float, float, int> SetLineSpacing;

            [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_TEXT_ALIGNMENT> GetTextAlignment;

            [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_PARAGRAPH_ALIGNMENT> GetParagraphAlignment;

            [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_WORD_WRAPPING> GetWordWrapping;

            [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_READING_DIRECTION> GetReadingDirection;

            [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_FLOW_DIRECTION> GetFlowDirection;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, float> GetIncrementalTabStop;

            [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> GetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> GetLineSpacing;

            [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, IDWriteFontCollection**, int> GetFontCollection;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, uint> GetFontFamilyNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, ushort*, uint, int> GetFontFamilyName;

            [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_WEIGHT> GetFontWeight;

            [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_STYLE> GetFontStyle;

            [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_STRETCH> GetFontStretch;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, float> GetFontSize;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, uint> GetLocaleNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, ushort*, uint, int> GetLocaleName;

            [NativeTypeName("HRESULT (DWRITE_VERTICAL_GLYPH_ORIENTATION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int> SetVerticalGlyphOrientation;

            [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_VERTICAL_GLYPH_ORIENTATION> GetVerticalGlyphOrientation;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, int, int> SetLastLineWrapping;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, int> GetLastLineWrapping;

            [NativeTypeName("HRESULT (DWRITE_OPTICAL_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_OPTICAL_ALIGNMENT, int> SetOpticalAlignment;

            [NativeTypeName("DWRITE_OPTICAL_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_OPTICAL_ALIGNMENT> GetOpticalAlignment;

            [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, IDWriteFontFallback*, int> SetFontFallback;

            [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, IDWriteFontFallback**, int> GetFontFallback;

            [NativeTypeName("HRESULT (const DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING*, int> SetLineSpacing1;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING*, int> GetLineSpacing1;
        }
    }
}
