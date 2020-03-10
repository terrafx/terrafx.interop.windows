// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F174B49-0D8B-4CFB-8BCA-F1CCE9D06C67")]
    public unsafe partial struct IDWriteTextFormat1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextFormat1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAlignment(IDWriteTextFormat1* pThis, DWRITE_TEXT_ALIGNMENT textAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParagraphAlignment(IDWriteTextFormat1* pThis, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWordWrapping(IDWriteTextFormat1* pThis, DWRITE_WORD_WRAPPING wordWrapping);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetReadingDirection(IDWriteTextFormat1* pThis, DWRITE_READING_DIRECTION readingDirection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFlowDirection(IDWriteTextFormat1* pThis, DWRITE_FLOW_DIRECTION flowDirection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIncrementalTabStop(IDWriteTextFormat1* pThis, [NativeTypeName("FLOAT")] float incrementalTabStop);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTrimming(IDWriteTextFormat1* pThis, [NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing(IDWriteTextFormat1* pThis, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_WORD_WRAPPING _GetWordWrapping(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetReadingDirection(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetIncrementalTabStop(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTrimming(IDWriteTextFormat1* pThis, [NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing(IDWriteTextFormat1* pThis, [NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteTextFormat1* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyNameLength(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName(IDWriteTextFormat1* pThis, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_WEIGHT _GetFontWeight(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STYLE _GetFontStyle(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STRETCH _GetFontStretch(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetFontSize(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetLocaleNameLength(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextFormat1* pThis, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVerticalGlyphOrientation(IDWriteTextFormat1* pThis, DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_VERTICAL_GLYPH_ORIENTATION _GetVerticalGlyphOrientation(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLastLineWrapping(IDWriteTextFormat1* pThis, [NativeTypeName("BOOL")] int isLastLineWrappingEnabled);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetLastLineWrapping(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpticalAlignment(IDWriteTextFormat1* pThis, DWRITE_OPTICAL_ALIGNMENT opticalAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_OPTICAL_ALIGNMENT _GetOpticalAlignment(IDWriteTextFormat1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontFallback(IDWriteTextFormat1* pThis, [NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFallback(IDWriteTextFormat1* pThis, [NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVerticalGlyphOrientation>(lpVtbl->SetVerticalGlyphOrientation)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLastLineWrapping>(lpVtbl->SetLastLineWrapping)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastLineWrapping>(lpVtbl->GetLastLineWrapping)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOpticalAlignment>(lpVtbl->SetOpticalAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpticalAlignment>(lpVtbl->GetOpticalAlignment)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontFallback>(lpVtbl->SetFontFallback)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFallback>(lpVtbl->GetFontFallback)((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextAlignment;

            [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetParagraphAlignment;

            [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWordWrapping;

            [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetReadingDirection;

            [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFlowDirection;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetIncrementalTabStop;

            [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLineSpacing;

            [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextAlignment;

            [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParagraphAlignment;

            [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetWordWrapping;

            [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetReadingDirection;

            [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFlowDirection;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetIncrementalTabStop;

            [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLineSpacing;

            [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCollection;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyName;

            [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontWeight;

            [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStyle;

            [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStretch;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSize;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleName;

            [NativeTypeName("HRESULT (DWRITE_VERTICAL_GLYPH_ORIENTATION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetVerticalGlyphOrientation;

            [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVerticalGlyphOrientation;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLastLineWrapping;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLastLineWrapping;

            [NativeTypeName("HRESULT (DWRITE_OPTICAL_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOpticalAlignment;

            [NativeTypeName("DWRITE_OPTICAL_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOpticalAlignment;

            [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontFallback;

            [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFallback;
        }
    }
}
