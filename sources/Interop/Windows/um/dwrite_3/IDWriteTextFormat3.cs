// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D3B5641-E550-430D-A85B-B7BF48A93427")]
    [NativeTypeName("struct IDWriteTextFormat3 : IDWriteTextFormat2")]
    public unsafe partial struct IDWriteTextFormat3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[1]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[2]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, float, int>)(lpVtbl[8]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, float>)(lpVtbl[16]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[20]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, float>)(lpVtbl[25]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[26]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[28]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[29]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, int, int>)(lpVtbl[30]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, int>)(lpVtbl[31]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[32]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[33]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[36]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[37]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[38]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[39]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[40]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes()
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES>)(lpVtbl[41]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes)
        {
            return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES, int>)(lpVtbl[42]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), automaticFontAxes);
        }
    }
}
