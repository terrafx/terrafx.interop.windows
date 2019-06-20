// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by the text analyzer's client to provide text to the analyzer. It allows the separation between the logical view of text as a continuous stream of characters identifiable by unique text positions, and the actual memory layout of potentially discrete blocks of text in the client's backing store. If any of these callbacks returns an error, the analysis functions will stop prematurely and return a callback error. Rather than return E_NOTIMPL, an application should stub the method and return a constant/null and S_OK.</summary>
    [Guid("688E1A58-5094-47C8-ADC8-FBCEA60AE92B")]
    [Unmanaged]
    public unsafe struct IDWriteTextAnalysisSource
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTextAnalysisSource* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTextAnalysisSource* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTextAnalysisSource* This
        );
        #endregion

        #region Delegates
        /// <summary>Get a block of text starting at the specified text position. Returning NULL indicates the end of text - the position is after the last character. This function is called iteratively for each consecutive block, tying together several fragmented blocks in the backing store into a virtual contiguous string.</summary>
        /// <param name="textPosition">First position of the piece to obtain. All positions are in UTF16 code-units, not whole characters, which matters when supplementary characters are used.</param>
        /// <param name="textString">Address that receives a pointer to the text block at the specified position.</param>
        /// <param name="textLength">Number of UTF16 units of the retrieved chunk. The returned length is not the length of the block, but the length remaining in the block, from the given position until its end. So querying for a position that is 75 positions into a 100 position block would return 25.</param>
        /// <returns>Pointer to the first character at the given text position. NULL indicates no chunk available at the specified position, either because textPosition >= the entire text content length or because the queried position is not mapped into the app's backing store.</returns>
        /// <remarks> Although apps can implement sparse textual content that only maps part of the backing store, the app must map any text that is in the range passed to any analysis functions.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTextAtPosition(
            [In] IDWriteTextAnalysisSource* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("WCHAR[]")] char** textString,
            [Out, NativeTypeName("UINT32")] uint* textLength
        );

        /// <summary>Get a block of text immediately preceding the specified position.</summary>
        /// <param name="textPosition">Position immediately after the last position of the chunk to obtain.</param>
        /// <param name="textString">Address that receives a pointer to the text block at the specified position.</param>
        /// <param name="textLength">Number of UTF16 units of the retrieved block. The length returned is from the given position to the front of the block.</param>
        /// <returns>Pointer to the first character at (textPosition - textLength). NULL indicates no chunk available at the specified position, either because textPosition == 0,the textPosition > the entire text content length, or the queried position is not mapped into the app's backing store.</returns>
        /// <remarks> Although apps can implement sparse textual content that only maps part of the backing store, the app must map any text that is in the range passed to any analysis functions.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTextBeforePosition(
            [In] IDWriteTextAnalysisSource* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("WCHAR[]")] char** textString,
            [Out, NativeTypeName("UINT32")] uint* textLength
        );

        /// <summary>Get paragraph reading direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_READING_DIRECTION _GetParagraphReadingDirection(
            [In] IDWriteTextAnalysisSource* This
        );

        /// <summary>Get locale name on the range affected by it.</summary>
        /// <param name="textPosition">Position to get the locale name of.</param>
        /// <param name="textLength">Receives the length from the given position up to the next differing locale.</param>
        /// <param name="localeName">Address that receives a pointer to the locale at the specified position.</param>
        /// <remarks> The localeName pointer must remain valid until the next call or until the analysis returns.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocaleName(
            [In] IDWriteTextAnalysisSource* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("UINT32")] uint* textLength,
            [Out, NativeTypeName("WCHAR[]")] char** localeName
        );

        /// <summary>Get number substitution on the range affected by it.</summary>
        /// <param name="textPosition">Position to get the number substitution of.</param>
        /// <param name="textLength">Receives the length from the given position up to the next differing number substitution.</param>
        /// <param name="numberSubstitution">Address that receives a pointer to the number substitution at the specified position.</param>
        /// <remarks> Any implementation should return the number substitution with an incremented ref count, and the analysis will release when finished with it (either before the next call or before it returns). However, the sink callback may hold onto it after that.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetNumberSubstitution(
            [In] IDWriteTextAnalysisSource* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("UINT32")] uint* textLength,
            [Out] IDWriteNumberSubstitution** numberSubstitution
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetTextAtPosition(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("WCHAR[]")] char** textString,
            [Out, NativeTypeName("UINT32")] uint* textLength
        )
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_GetTextAtPosition>(lpVtbl->GetTextAtPosition)(
                    This,
                    textPosition,
                    textString,
                    textLength
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextBeforePosition(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("WCHAR[]")] char** textString,
            [Out, NativeTypeName("UINT32")] uint* textLength
        )
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_GetTextBeforePosition>(lpVtbl->GetTextBeforePosition)(
                    This,
                    textPosition,
                    textString,
                    textLength
                );
            }
        }

        public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_GetParagraphReadingDirection>(lpVtbl->GetParagraphReadingDirection)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("UINT32")] uint* textLength,
            [Out, NativeTypeName("WCHAR[]")] char** localeName
        )
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_GetLocaleName>(lpVtbl->GetLocaleName)(
                    This,
                    textPosition,
                    textLength,
                    localeName
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberSubstitution(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [Out, NativeTypeName("UINT32")] uint* textLength,
            [Out] IDWriteNumberSubstitution** numberSubstitution
        )
        {
            fixed (IDWriteTextAnalysisSource* This = &this)
            {
                return MarshalFunction<_GetNumberSubstitution>(lpVtbl->GetNumberSubstitution)(
                    This,
                    textPosition,
                    textLength,
                    numberSubstitution
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr GetTextAtPosition;

            public IntPtr GetTextBeforePosition;

            public IntPtr GetParagraphReadingDirection;

            public IntPtr GetLocaleName;

            public IntPtr GetNumberSubstitution;
            #endregion
        }
        #endregion
    }
}
