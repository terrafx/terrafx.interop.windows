// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F67E0EDD-9E3D-4ECC-8C32-4183253DFE70")]
    [NativeTypeName("struct IDWriteTextFormat2 : IDWriteTextFormat1")]
    public unsafe partial struct IDWriteTextFormat2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, uint>)(lpVtbl[1]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, uint>)(lpVtbl[2]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, float, int>)(lpVtbl[8]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, float>)(lpVtbl[16]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, uint>)(lpVtbl[20]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, float>)(lpVtbl[25]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, uint>)(lpVtbl[26]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[28]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[29]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, int, int>)(lpVtbl[30]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, int>)(lpVtbl[31]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[32]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[33]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING*, int>)(lpVtbl[36]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* stdcall<IDWriteTextFormat2*, DWRITE_LINE_SPACING*, int>)(lpVtbl[37]))((IDWriteTextFormat2*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }
    }
}
