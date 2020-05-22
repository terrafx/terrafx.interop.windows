// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D3B5641-E550-430D-A85B-B7BF48A93427")]
    public unsafe partial struct IDWriteTextFormat3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextFormat3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAlignment(IDWriteTextFormat3* pThis, DWRITE_TEXT_ALIGNMENT textAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParagraphAlignment(IDWriteTextFormat3* pThis, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWordWrapping(IDWriteTextFormat3* pThis, DWRITE_WORD_WRAPPING wordWrapping);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetReadingDirection(IDWriteTextFormat3* pThis, DWRITE_READING_DIRECTION readingDirection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFlowDirection(IDWriteTextFormat3* pThis, DWRITE_FLOW_DIRECTION flowDirection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIncrementalTabStop(IDWriteTextFormat3* pThis, [NativeTypeName("FLOAT")] float incrementalTabStop);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTrimming(IDWriteTextFormat3* pThis, [NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing(IDWriteTextFormat3* pThis, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_WORD_WRAPPING _GetWordWrapping(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetReadingDirection(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetIncrementalTabStop(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTrimming(IDWriteTextFormat3* pThis, [NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing(IDWriteTextFormat3* pThis, [NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteTextFormat3* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyNameLength(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName(IDWriteTextFormat3* pThis, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_WEIGHT _GetFontWeight(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STYLE _GetFontStyle(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STRETCH _GetFontStretch(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetFontSize(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetLocaleNameLength(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextFormat3* pThis, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVerticalGlyphOrientation(IDWriteTextFormat3* pThis, DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_VERTICAL_GLYPH_ORIENTATION _GetVerticalGlyphOrientation(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLastLineWrapping(IDWriteTextFormat3* pThis, [NativeTypeName("BOOL")] int isLastLineWrappingEnabled);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetLastLineWrapping(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpticalAlignment(IDWriteTextFormat3* pThis, DWRITE_OPTICAL_ALIGNMENT opticalAlignment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_OPTICAL_ALIGNMENT _GetOpticalAlignment(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontFallback(IDWriteTextFormat3* pThis, [NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFallback(IDWriteTextFormat3* pThis, [NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing1(IDWriteTextFormat3* pThis, [NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing1(IDWriteTextFormat3* pThis, [NativeTypeName("DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontAxisValues(IDWriteTextFormat3* pThis, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontAxisValueCount(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontAxisValues(IDWriteTextFormat3* pThis, [NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_AUTOMATIC_FONT_AXES _GetAutomaticFontAxes(IDWriteTextFormat3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAutomaticFontAxes(IDWriteTextFormat3* pThis, DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVerticalGlyphOrientation>(lpVtbl->SetVerticalGlyphOrientation)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLastLineWrapping>(lpVtbl->SetLastLineWrapping)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastLineWrapping>(lpVtbl->GetLastLineWrapping)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOpticalAlignment>(lpVtbl->SetOpticalAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpticalAlignment>(lpVtbl->GetOpticalAlignment)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontFallback>(lpVtbl->SetFontFallback)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFallback>(lpVtbl->GetFontFallback)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing1>(lpVtbl->SetLineSpacing1)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing1>(lpVtbl->GetLineSpacing1)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontAxisValues>(lpVtbl->SetFontAxisValues)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisValueCount>(lpVtbl->GetFontAxisValueCount)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisValues>(lpVtbl->GetFontAxisValues)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAutomaticFontAxes>(lpVtbl->GetAutomaticFontAxes)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAutomaticFontAxes>(lpVtbl->SetAutomaticFontAxes)((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), automaticFontAxes);
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

            [NativeTypeName("HRESULT (const DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLineSpacing1;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLineSpacing1;

            [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontAxisValues;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisValueCount;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisValues;

            [NativeTypeName("DWRITE_AUTOMATIC_FONT_AXES () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAutomaticFontAxes;

            [NativeTypeName("HRESULT (DWRITE_AUTOMATIC_FONT_AXES) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAutomaticFontAxes;
        }
    }
}
