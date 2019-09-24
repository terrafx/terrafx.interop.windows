// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontList interface represents a list of fonts.</summary>
    [Guid("1A0D8438-1D97-4EC1-AEF9-A2FB86ED6ACB")]
    public unsafe struct IDWriteFontList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontList* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontList* This
        );

        /// <summary>Gets the font collection that contains the fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the font collection object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontCollection(
            [In] IDWriteFontList* This,
            [Out] IDWriteFontCollection** fontCollection
        );

        /// <summary>Gets the number of fonts in the font list.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontCount(
            [In] IDWriteFontList* This
        );

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="index">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFont(
            [In] IDWriteFontList* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFont** font
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontList* This = &this)
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
            fixed (IDWriteFontList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(
            [Out] IDWriteFontCollection** fontCollection
        )
        {
            fixed (IDWriteFontList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(
                    This,
                    fontCollection
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            fixed (IDWriteFontList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont(
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteFontList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFont>(lpVtbl->GetFont)(
                    This,
                    index,
                    font
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFontCollection;

            public IntPtr GetFontCount;

            public IntPtr GetFont;
        }
    }
}
