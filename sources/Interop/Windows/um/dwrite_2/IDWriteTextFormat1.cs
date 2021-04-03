// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F174B49-0D8B-4CFB-8BCA-F1CCE9D06C67")]
    [NativeTypeName("struct IDWriteTextFormat1 : IDWriteTextFormat")]
    public unsafe partial struct IDWriteTextFormat1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[1]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[2]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, float, int>)(lpVtbl[8]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, float>)(lpVtbl[16]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[20]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, float>)(lpVtbl[25]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[26]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[28]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[29]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, int, int>)(lpVtbl[30]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, int>)(lpVtbl[31]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[32]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[33]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
        }
    }
}
