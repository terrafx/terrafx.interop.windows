// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The format of text used for text layout.</summary>
    /// <remarks> This object may not be thread-safe and it may carry the state of text format change.</remarks>
    [Guid("9C906818-31D7-4FD3-A151-7C5E225DB55A")]
    public unsafe struct IDWriteTextFormat
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextFormat* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextFormat* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextFormat* This);

        /// <summary>Set alignment option of text relative to layout box's leading and trailing edge.</summary>
        /// <param name="textAlignment">Text alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAlignment(IDWriteTextFormat* This, DWRITE_TEXT_ALIGNMENT textAlignment);

        /// <summary>Set alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        /// <param name="paragraphAlignment">Paragraph alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParagraphAlignment(IDWriteTextFormat* This, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        /// <summary>Set word wrapping option.</summary>
        /// <param name="wordWrapping">Word wrapping option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWordWrapping(IDWriteTextFormat* This, DWRITE_WORD_WRAPPING wordWrapping);

        /// <summary>Set paragraph reading direction.</summary>
        /// <param name="readingDirection">Text reading direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetReadingDirection(IDWriteTextFormat* This, DWRITE_READING_DIRECTION readingDirection);

        /// <summary>Set paragraph flow direction.</summary>
        /// <param name="flowDirection">Paragraph flow direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFlowDirection(IDWriteTextFormat* This, DWRITE_FLOW_DIRECTION flowDirection);

        /// <summary>Set incremental tab stop position.</summary>
        /// <param name="incrementalTabStop">The incremental tab stop value</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIncrementalTabStop(IDWriteTextFormat* This, [NativeTypeName("FLOAT")] float incrementalTabStop);

        /// <summary>Set trimming options for any trailing text exceeding the layout width or for any far text exceeding the layout height.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Application-defined omission sign. This parameter may be NULL if no trimming sign is desired.</param>
        /// <remarks> Any inline object can be used for the trimming sign, but CreateEllipsisTrimmingSign provides a typical ellipsis symbol. Trimming is also useful vertically for hiding partial lines.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTrimming(IDWriteTextFormat* This, DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign = null);

        /// <summary>Set line spacing.</summary>
        /// <param name="lineSpacingMethod">How to determine line height.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline. A reasonable ratio to lineSpacing is 80%.</param>
        /// <remarks> For the default method, spacing depends solely on the content. For uniform spacing, the given line height will override the content.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing(IDWriteTextFormat* This, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline);

        /// <summary>Get alignment option of text relative to layout box's leading and trailing edge.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(IDWriteTextFormat* This);

        /// <summary>Get alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(IDWriteTextFormat* This);

        /// <summary>Get word wrapping option.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_WORD_WRAPPING _GetWordWrapping(IDWriteTextFormat* This);

        /// <summary>Get paragraph reading direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetReadingDirection(IDWriteTextFormat* This);

        /// <summary>Get paragraph flow direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(IDWriteTextFormat* This);

        /// <summary>Get incremental tab stop position.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetIncrementalTabStop(IDWriteTextFormat* This);

        /// <summary>Get trimming options for text overflowing the layout width.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Trimming omission sign. This parameter may be NULL.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTrimming(IDWriteTextFormat* This, DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign);

        /// <summary>Get line spacing.</summary>
        /// <param name="lineSpacingMethod">How line height is determined.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing(IDWriteTextFormat* This, DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT")] float* lineSpacing, [NativeTypeName("FLOAT")] float* baseline);

        /// <summary>Get the font collection.</summary>
        /// <param name="fontCollection">The current font collection.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteTextFormat* This, IDWriteFontCollection** fontCollection);

        /// <summary>Get the length of the font family name, in characters, not including the terminating NULL character.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyNameLength(IDWriteTextFormat* This);

        /// <summary>Get a copy of the font family name.</summary>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName(IDWriteTextFormat* This, [NativeTypeName("WCHAR[]")] char* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        /// <summary>Get the font weight.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_WEIGHT _GetFontWeight(IDWriteTextFormat* This);

        /// <summary>Get the font style.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STYLE _GetFontStyle(IDWriteTextFormat* This);

        /// <summary>Get the font stretch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STRETCH _GetFontStretch(IDWriteTextFormat* This);

        /// <summary>Get the font em height.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetFontSize(IDWriteTextFormat* This);

        /// <summary>Get the length of the locale name, in characters, not including the terminating NULL character.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetLocaleNameLength(IDWriteTextFormat* This);

        /// <summary>Get a copy of the locale name.</summary>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextFormat* This, [NativeTypeName("WCHAR[]")] char* localeName, [NativeTypeName("UINT32")] uint nameSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)(This, textAlignment);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)(This, paragraphAlignment);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)(This, wordWrapping);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)(This, readingDirection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)(This, flowDirection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)(This, incrementalTabStop);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign = null)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)(This, trimmingOptions, trimmingSign);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)(This, lineSpacingMethod, lineSpacing, baseline);
            }
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)(This);
            }
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)(This);
            }
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)(This);
            }
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)(This);
            }
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)(This, trimmingOptions, trimmingSign);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT")] float* lineSpacing, [NativeTypeName("FLOAT")] float* baseline)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)(This, lineSpacingMethod, lineSpacing, baseline);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(This, fontCollection);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR[]")] char* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)(This, fontFamilyName, nameSize);
            }
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)(This);
            }
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)(This);
            }
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR[]")] char* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            fixed (IDWriteTextFormat* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(This, localeName, nameSize);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetTextAlignment;

            public IntPtr SetParagraphAlignment;

            public IntPtr SetWordWrapping;

            public IntPtr SetReadingDirection;

            public IntPtr SetFlowDirection;

            public IntPtr SetIncrementalTabStop;

            public IntPtr SetTrimming;

            public IntPtr SetLineSpacing;

            public IntPtr GetTextAlignment;

            public IntPtr GetParagraphAlignment;

            public IntPtr GetWordWrapping;

            public IntPtr GetReadingDirection;

            public IntPtr GetFlowDirection;

            public IntPtr GetIncrementalTabStop;

            public IntPtr GetTrimming;

            public IntPtr GetLineSpacing;

            public IntPtr GetFontCollection;

            public IntPtr GetFontFamilyNameLength;

            public IntPtr GetFontFamilyName;

            public IntPtr GetFontWeight;

            public IntPtr GetFontStyle;

            public IntPtr GetFontStretch;

            public IntPtr GetFontSize;

            public IntPtr GetLocaleNameLength;

            public IntPtr GetLocaleName;
        }
    }
}
