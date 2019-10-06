// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by the client to provide needed information to the text analyzer, such as the text and associated text properties. If any of these callbacks returns an error, the analysis functions will stop prematurely and return a callback error.</summary>
    [Guid("639CFAD8-0FB4-4B21-A58A-067920120009")]
    public unsafe partial struct IDWriteTextAnalysisSource1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalysisSource1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalysisSource1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalysisSource1* This);

        /// <summary>Get a block of text starting at the specified text position. Returning NULL indicates the end of text - the position is after the last character. This function is called iteratively for each consecutive block, tying together several fragmented blocks in the backing store into a virtual contiguous string.</summary>
        /// <param name="textPosition">First position of the piece to obtain. All positions are in UTF16 code-units, not whole characters, which matters when supplementary characters are used.</param>
        /// <param name="textString">Address that receives a pointer to the text block at the specified position.</param>
        /// <param name="textLength">Number of UTF16 units of the retrieved chunk. The returned length is not the length of the block, but the length remaining in the block, from the given position until its end. So querying for a position that is 75 positions into a 100 position block would return 25.</param>
        /// <returns>Pointer to the first character at the given text position. NULL indicates no chunk available at the specified position, either because textPosition >= the entire text content length or because the queried position is not mapped into the app's backing store.</returns>
        /// <remarks> Although apps can implement sparse textual content that only maps part of the backing store, the app must map any text that is in the range passed to any analysis functions.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextAtPosition(IDWriteTextAnalysisSource1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("WCHAR[]")] ushort** textString, [NativeTypeName("UINT32")] uint* textLength);

        /// <summary>Get a block of text immediately preceding the specified position.</summary>
        /// <param name="textPosition">Position immediately after the last position of the chunk to obtain.</param>
        /// <param name="textString">Address that receives a pointer to the text block at the specified position.</param>
        /// <param name="textLength">Number of UTF16 units of the retrieved block. The length returned is from the given position to the front of the block.</param>
        /// <returns>Pointer to the first character at (textPosition - textLength). NULL indicates no chunk available at the specified position, either because textPosition == 0,the textPosition > the entire text content length, or the queried position is not mapped into the app's backing store.</returns>
        /// <remarks> Although apps can implement sparse textual content that only maps part of the backing store, the app must map any text that is in the range passed to any analysis functions.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextBeforePosition(IDWriteTextAnalysisSource1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("WCHAR[]")] ushort** textString, [NativeTypeName("UINT32")] uint* textLength);

        /// <summary>Get paragraph reading direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetParagraphReadingDirection(IDWriteTextAnalysisSource1* This);

        /// <summary>Get locale name on the range affected by it.</summary>
        /// <param name="textPosition">Position to get the locale name of.</param>
        /// <param name="textLength">Receives the length from the given position up to the next differing locale.</param>
        /// <param name="localeName">Address that receives a pointer to the locale at the specified position.</param>
        /// <remarks> The localeName pointer must remain valid until the next call or until the analysis returns.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextAnalysisSource1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, [NativeTypeName("WCHAR[]")] ushort** localeName);

        /// <summary>Get number substitution on the range affected by it.</summary>
        /// <param name="textPosition">Position to get the number substitution of.</param>
        /// <param name="textLength">Receives the length from the given position up to the next differing number substitution.</param>
        /// <param name="numberSubstitution">Address that receives a pointer to the number substitution at the specified position.</param>
        /// <remarks> Any implementation should return the number substitution with an incremented ref count, and the analysis will release when finished with it (either before the next call or before it returns). However, the sink callback may hold onto it after that.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNumberSubstitution(IDWriteTextAnalysisSource1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, IDWriteNumberSubstitution** numberSubstitution);

        /// <summary>The text analyzer calls back to this to get the desired glyph orientation and resolved bidi level, which it uses along with the script properties of the text to determine the actual orientation of each character, which it reports back to the client via the sink SetGlyphOrientation method.</summary>
        /// <param name="textPosition">First position of the piece to obtain. All positions are in UTF-16 code-units, not whole characters, which matters when supplementary characters are used.</param>
        /// <param name="textLength">Number of UTF-16 units of the retrieved chunk. The returned length is not the length of the block, but the length remaining in the block, from the given position until its end. So querying for a position that is 75 positions into a 100 postition block would return 25.</param>
        /// <param name="glyphOrientation">The type of glyph orientation the client wants for this range, up to the returned text length.</param>
        /// <param name="bidiLevel">The bidi level for this range up to the returned text length, which comes from an earlier bidirectional analysis.</param>
        /// <returns> Standard HRESULT error code. Returning an error will abort the analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVerticalGlyphOrientation(IDWriteTextAnalysisSource1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8")] byte* bidiLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextAtPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("WCHAR[]")] ushort** textString, [NativeTypeName("UINT32")] uint* textLength)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAtPosition>(lpVtbl->GetTextAtPosition)(This, textPosition, textString, textLength);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextBeforePosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("WCHAR[]")] ushort** textString, [NativeTypeName("UINT32")] uint* textLength)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextBeforePosition>(lpVtbl->GetTextBeforePosition)(This, textPosition, textString, textLength);
            }
        }

        public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParagraphReadingDirection>(lpVtbl->GetParagraphReadingDirection)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, [NativeTypeName("WCHAR[]")] ushort** localeName)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(This, textPosition, textLength, localeName);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumberSubstitution>(lpVtbl->GetNumberSubstitution)(This, textPosition, textLength, numberSubstitution);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8")] byte* bidiLevel)
        {
            fixed (IDWriteTextAnalysisSource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)(This, textPosition, textLength, glyphOrientation, bidiLevel);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetTextAtPosition;

            public IntPtr GetTextBeforePosition;

            public IntPtr GetParagraphReadingDirection;

            public IntPtr GetLocaleName;

            public IntPtr GetNumberSubstitution;

            public IntPtr GetVerticalGlyphOrientation;
        }
    }
}
