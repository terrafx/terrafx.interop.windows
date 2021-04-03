// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("05A9BF42-223F-4441-B5FB-8263685F55E9")]
    [NativeTypeName("struct IDWriteTextLayout4 : IDWriteTextLayout3")]
    public unsafe partial struct IDWriteTextLayout4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint>)(lpVtbl[1]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint>)(lpVtbl[2]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, int>)(lpVtbl[8]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float>)(lpVtbl[16]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint>)(lpVtbl[20]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float>)(lpVtbl[25]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint>)(lpVtbl[26]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, int>)(lpVtbl[28]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, int>)(lpVtbl[29]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int>)(lpVtbl[30]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[31]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(lpVtbl[32]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(lpVtbl[33]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(lpVtbl[34]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[35]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnderline([NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[36]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough([NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[37]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IUnknown*, DWRITE_TEXT_RANGE, int>)(lpVtbl[38]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int>)(lpVtbl[39]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteTypography*, DWRITE_TEXT_RANGE, int>)(lpVtbl[40]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[41]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float>)(lpVtbl[42]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float>)(lpVtbl[43]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[44]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[45]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[46]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[47]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[48]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[49]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[50]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[51]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[52]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[53]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[54]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[55]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[56]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[57]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_METRICS*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TEXT_METRICS*, int>)(lpVtbl[60]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[61]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), overhangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT *")] float* minWidth)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), minWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL *")] int* isTrailingHit, [NativeTypeName("BOOL *")] int* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, float, int*, int*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[64]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, int, float*, float*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[65]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning([NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[67]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* isPairKerningEnabled, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[68]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, float, float, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[69]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* leadingSpacing, [NativeTypeName("FLOAT *")] float* trailingSpacing, [NativeTypeName("FLOAT *")] float* minimumAdvanceWidth, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, float*, float*, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[70]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_TEXT_METRICS1* textMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_TEXT_METRICS1*, int>)(lpVtbl[71]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[72]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[73]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int, int>)(lpVtbl[74]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int>)(lpVtbl[75]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[76]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[77]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteFontFallback*, int>)(lpVtbl[78]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, IDWriteFontFallback**, int>)(lpVtbl[79]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateLayout()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, int>)(lpVtbl[80]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_SPACING*, int>)(lpVtbl[81]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_SPACING*, int>)(lpVtbl[82]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics(DWRITE_LINE_METRICS1* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_LINE_METRICS1*, uint, uint*, int>)(lpVtbl[83]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_TEXT_RANGE, int>)(lpVtbl[84]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount([NativeTypeName("UINT32")] uint currentPosition)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, uint>)(lpVtbl[85]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, uint, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[86]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), currentPosition, fontAxisValues, fontAxisValueCount, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes()
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_AUTOMATIC_FONT_AXES>)(lpVtbl[87]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes)
        {
            return ((delegate* unmanaged<IDWriteTextLayout4*, DWRITE_AUTOMATIC_FONT_AXES, int>)(lpVtbl[88]))((IDWriteTextLayout4*)Unsafe.AsPointer(ref this), automaticFontAxes);
        }
    }
}
