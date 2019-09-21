// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFont interface represents a physical font in a font collection.</summary>
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32738")]
    public unsafe struct IDWriteFont1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFont1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFont1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFont1* This
        );
        #endregion

        #region IDWriteFont Delegates
        /// <summary>Gets the font family to which the specified font belongs.</summary>
        /// <param name="fontFamily">Receives a pointer to the font family object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamily(
            [In] IDWriteFont1* This,
            [Out] IDWriteFontFamily** fontFamily
        );

        /// <summary>Gets the weight of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_WEIGHT _GetWeight(
            [In] IDWriteFont1* This
        );

        /// <summary>Gets the stretch (aka. width) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STRETCH _GetStretch(
            [In] IDWriteFont1* This
        );

        /// <summary>Gets the style (aka. slope) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STYLE _GetStyle(
            [In] IDWriteFont1* This
        );

        /// <summary>Returns TRUE if the font is a symbol font or FALSE if not.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsSymbolFont(
            [In] IDWriteFont1* This
        );

        /// <summary>Gets a localized strings collection containing the face names for the font (e.g., Regular or Bold), indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFaceNames(
            [In] IDWriteFont1* This,
            [Out] IDWriteLocalizedStrings** names
        );

        /// <summary>Gets a localized strings collection containing the specified informational strings, indexed by locale name.</summary>
        /// <param name="informationalStringID">Identifies the string to get.</param>
        /// <param name="informationalStrings">Receives a pointer to the newly created localized strings object.</param>
        /// <param name="exists">Receives the value TRUE if the font contains the specified string ID or FALSE if not.</param>
        /// <returns>Standard HRESULT error code. If the font does not contain the specified string, the return value is S_OK but informationalStrings receives a NULL pointer and exists receives the value FALSE.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetInformationalStrings(
            [In] IDWriteFont1* This,
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Gets a value that indicates what simulation are applied to the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_SIMULATIONS _GetSimulations(
            [In] IDWriteFont1* This
        );

        /// <summary>Gets the metrics for the font.</summary>
        /// <param name="fontMetrics">Receives the font metrics.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetMetrics(
            [In] IDWriteFont1* This,
            [Out] DWRITE_FONT_METRICS* fontMetrics
        );

        /// <summary>Determines whether the font supports the specified character.</summary>
        /// <param name="unicodeValue">Unicode (UCS-4) character value.</param>
        /// <param name="exists">Receives the value TRUE if the font supports the specified character or FALSE if not.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _HasCharacter(
            [In] IDWriteFont1* This,
            [In, NativeTypeName("UINT32")] uint unicodeValue,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Creates a font face object for the font.</summary>
        /// <param name="fontFace">Receives a pointer to the newly created font face object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontFace(
            [In] IDWriteFont1* This,
            [Out] IDWriteFontFace** fontFace
        );
        #endregion

        #region Delegates
        /// <summary>Gets common metrics for the font in design units. These metrics are applicable to all the glyphs within a font, and are used by applications for layout calculations.</summary>
        /// <param name="fontMetrics">Metrics public structure to fill in.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetMetrics1(
            [In] IDWriteFont1* This,
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        );

        /// <summary>Gets the PANOSE values from the font, used for font selection and matching.</summary>
        /// <param name="panose">PANOSE public structure to fill in.</param>
        /// <remarks> The function does not simulate these, such as substituting a weight or proportion inferred on other values. If the font does not specify them, they are all set to 'any' (0).</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetPanose(
            [In] IDWriteFont1* This,
            [Out] DWRITE_PANOSE* panose
        );

        /// <summary>Returns the list of character ranges supported by the font, which is useful for scenarios like character picking, glyph display, and efficient font selection lookup. This is similar to GDI's GetFontUnicodeRanges, except that it returns the full Unicode range, not just 16-bit UCS-2.</summary>
        /// <param name="maxRangeCount">Maximum number of character ranges passed in from the client.</param>
        /// <param name="unicodeRanges">Array of character ranges.</param>
        /// <param name="actualRangeCount">Actual number of character ranges, regardless of the maximum count.</param>
        /// <remarks> These ranges are from the cmap, not the OS/2::ulCodePageRange1.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetUnicodeRanges(
            [In] IDWriteFont1* This,
            [In, NativeTypeName("UINT32")] uint maxRangeCount,
            [Out, Optional, NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* unicodeRanges,
            [Out, NativeTypeName("UINT32")] uint* actualRangeCount
        );

        /// <summary>Returns true if the font is monospaced, meaning its characters are the same fixed-pitch width (non-proportional).</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsMonospacedFont(
            [In] IDWriteFont1* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFont Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily(
            [Out] IDWriteFontFamily** fontFamily
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamily>(lpVtbl->GetFontFamily)(
                    This,
                    fontFamily
                );
            }
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWeight>(lpVtbl->GetWeight)(
                    This
                );
            }
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStretch>(lpVtbl->GetStretch)(
                    This
                );
            }
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStyle>(lpVtbl->GetStyle)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsSymbolFont>(lpVtbl->IsSymbolFont)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(
            [Out] IDWriteLocalizedStrings** names
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFaceNames>(lpVtbl->GetFaceNames)(
                    This,
                    names
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInformationalStrings>(lpVtbl->GetInformationalStrings)(
                    This,
                    informationalStringID,
                    informationalStrings,
                    exists
                );
            }
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSimulations>(lpVtbl->GetSimulations)(
                    This
                );
            }
        }

        public void GetMetrics(
            [Out] DWRITE_FONT_METRICS* fontMetrics
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)(
                    This,
                    fontMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HasCharacter(
            [In, NativeTypeName("UINT32")] uint unicodeValue,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HasCharacter>(lpVtbl->HasCharacter)(
                    This,
                    unicodeValue,
                    exists
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(
            [Out] IDWriteFontFace** fontFace
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)(
                    This,
                    fontFace
                );
            }
        }
        #endregion

        #region Methods
        public void GetMetrics1(
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetMetrics1>(lpVtbl->GetMetrics1)(
                    This,
                    fontMetrics
                );
            }
        }

        public void GetPanose(
            [Out] DWRITE_PANOSE* panose
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetPanose>(lpVtbl->GetPanose)(
                    This,
                    panose
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges(
            [In, NativeTypeName("UINT32")] uint maxRangeCount,
            [Out, Optional, NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* unicodeRanges,
            [Out, NativeTypeName("UINT32")] uint* actualRangeCount
        )
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUnicodeRanges>(lpVtbl->GetUnicodeRanges)(
                    This,
                    maxRangeCount,
                    unicodeRanges,
                    actualRangeCount
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            fixed (IDWriteFont1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsMonospacedFont>(lpVtbl->IsMonospacedFont)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDWriteFont Fields
            public IntPtr GetFontFamily;

            public IntPtr GetWeight;

            public IntPtr GetStretch;

            public IntPtr GetStyle;

            public IntPtr IsSymbolFont;

            public IntPtr GetFaceNames;

            public IntPtr GetInformationalStrings;

            public IntPtr GetSimulations;

            public IntPtr GetMetrics;

            public IntPtr HasCharacter;

            public IntPtr CreateFontFace;
            #endregion

            #region Fields
            public IntPtr GetMetrics1;

            public IntPtr GetPanose;

            public IntPtr GetUnicodeRanges;

            public IntPtr IsMonospacedFont;
            #endregion
        }
        #endregion
    }
}
