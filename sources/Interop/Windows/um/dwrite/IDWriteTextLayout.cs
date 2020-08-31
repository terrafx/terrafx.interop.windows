// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53737037-6D14-410B-9BFE-0B182BB70961")]
    [NativeTypeName("struct IDWriteTextLayout : IDWriteTextFormat")]
    public unsafe partial struct IDWriteTextLayout
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint>)(lpVtbl[1]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint>)(lpVtbl[2]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float, int>)(lpVtbl[8]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float>)(lpVtbl[16]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint>)(lpVtbl[20]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float>)(lpVtbl[25]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint>)(lpVtbl[26]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float, int>)(lpVtbl[28]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float, int>)(lpVtbl[29]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection([NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int>)(lpVtbl[30]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[31]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(lpVtbl[32]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(lpVtbl[33]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(lpVtbl[34]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[35]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnderline([NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[36]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough([NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[37]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect([NativeTypeName("IUnknown *")] IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, IUnknown*, DWRITE_TEXT_RANGE, int>)(lpVtbl[38]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject([NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int>)(lpVtbl[39]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypography([NativeTypeName("IDWriteTypography *")] IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, IDWriteTypography*, DWRITE_TEXT_RANGE, int>)(lpVtbl[40]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[41]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float>)(lpVtbl[42]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float>)(lpVtbl[43]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[44]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[45]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[46]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_WEIGHT *")] DWRITE_FONT_WEIGHT* fontWeight, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[47]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STYLE *")] DWRITE_FONT_STYLE* fontStyle, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[48]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STRETCH *")] DWRITE_FONT_STRETCH* fontStretch, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[49]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[50]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasUnderline, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[51]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasStrikethrough, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[52]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IUnknown **")] IUnknown** drawingEffect, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[53]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** inlineObject, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[54]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[55]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[56]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[57]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics([NativeTypeName("DWRITE_LINE_METRICS *")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_LINE_METRICS*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics([NativeTypeName("DWRITE_TEXT_METRICS *")] DWRITE_TEXT_METRICS* textMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_TEXT_METRICS*, int>)(lpVtbl[60]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics([NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[61]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), overhangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics([NativeTypeName("DWRITE_CLUSTER_METRICS *")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT *")] float* minWidth)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), minWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL *")] int* isTrailingHit, [NativeTypeName("BOOL *")] int* isInside, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, float, float, int*, int*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[64]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, int, float*, float*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[65]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }
    }
}
