// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Builder used to create a font fallback definition by appending a series of fallback mappings, followed by a creation call.</summary>
    /// <remarks> This object may not be thread-safe.</remarks>
    [Guid("FD882D06-8ABA-4FB8-B849-8BE8B73E14DE")]
    public unsafe struct IDWriteFontFallbackBuilder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFallbackBuilder* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFallbackBuilder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFallbackBuilder* This);

        /// <summary>Appends a single mapping to the list. Call this once for each additional mapping.</summary>
        /// <param name="ranges">Unicode ranges that apply to this mapping.</param>
        /// <param name="rangesCount">Number of Unicode ranges.</param>
        /// <param name="localeName">Locale of the context (e.g. document locale).</param>
        /// <param name="baseFamilyName">Base family name to match against, if applicable.</param>
        /// <param name="fontCollection">Explicit font collection for this mapping (optional).</param>
        /// <param name="targetFamilyNames">List of target family name strings.</param>
        /// <param name="targetFamilyNamesCount">Number of target family names.</param>
        /// <param name="scale">Scale factor to multiply the result target font by.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddMapping(IDWriteFontFallbackBuilder* This, [NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("WCHAR[]")] char** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection = null, [NativeTypeName("WCHAR[]")] char* localeName = null, [NativeTypeName("WCHAR[]")] char* baseFamilyName = null, [NativeTypeName("FLOAT")] float scale = 1.0f);

        /// <summary>Appends all the mappings from an existing font fallback object.</summary>
        /// <param name="fontFallback">Font fallback to read mappings from.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddMappings(IDWriteFontFallbackBuilder* This, IDWriteFontFallback* fontFallback);

        /// <summary>Creates the finalized fallback object from the mappings added.</summary>
        /// <param name="fontFallback">Created fallback list.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFallback(IDWriteFontFallbackBuilder* This, IDWriteFontFallback** fontFallback);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMapping([NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("WCHAR[]")] char** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection = null, [NativeTypeName("WCHAR[]")] char* localeName = null, [NativeTypeName("WCHAR[]")] char* baseFamilyName = null, [NativeTypeName("FLOAT")] float scale = 1.0f)
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddMapping>(lpVtbl->AddMapping)(This, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMappings(IDWriteFontFallback* fontFallback)
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddMappings>(lpVtbl->AddMappings)(This, fontFallback);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFallback(IDWriteFontFallback** fontFallback)
        {
            fixed (IDWriteFontFallbackBuilder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFallback>(lpVtbl->CreateFontFallback)(This, fontFallback);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AddMapping;

            public IntPtr AddMappings;

            public IntPtr CreateFontFallback;
        }
    }
}
