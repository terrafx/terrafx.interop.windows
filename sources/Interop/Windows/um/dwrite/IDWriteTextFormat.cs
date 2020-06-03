// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C906818-31D7-4FD3-A151-7C5E225DB55A")]
    public unsafe partial struct IDWriteTextFormat
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, uint>)(lpVtbl[1]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, uint>)(lpVtbl[2]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, float, int>)(lpVtbl[8]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, float>)(lpVtbl[16]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, uint>)(lpVtbl[20]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, float>)(lpVtbl[25]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* stdcall<IDWriteTextFormat*, uint>)(lpVtbl[26]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }
    }
}
