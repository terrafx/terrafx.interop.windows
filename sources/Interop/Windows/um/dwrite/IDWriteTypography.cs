// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Font typography setting.</summary>
    [Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
    public unsafe struct IDWriteTypography
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTypography* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTypography* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTypography* This
        );

        /// <summary>Add font feature.</summary>
        /// <param name="fontFeature">The font feature to add.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddFontFeature(
            [In] IDWriteTypography* This,
            [In] DWRITE_FONT_FEATURE fontFeature
        );

        /// <summary>Get the number of font features.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontFeatureCount(
            [In] IDWriteTypography* This
        );

        /// <summary>Get the font feature at the specified index.</summary>
        /// <param name="fontFeatureIndex">The zero-based index of the font feature to get.</param>
        /// <param name="fontFeature">The font feature.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFeature(
            [In] IDWriteTypography* This,
            [In, NativeTypeName("UINT32")] uint fontFeatureIndex,
            [Out] DWRITE_FONT_FEATURE* fontFeature
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTypography* This = &this)
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
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFeature(
            [In] DWRITE_FONT_FEATURE fontFeature
        )
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddFontFeature>(lpVtbl->AddFontFeature)(
                    This,
                    fontFeature
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFeatureCount()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFeatureCount>(lpVtbl->GetFontFeatureCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFeature(
            [In, NativeTypeName("UINT32")] uint fontFeatureIndex,
            [Out] DWRITE_FONT_FEATURE* fontFeature
        )
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFeature>(lpVtbl->GetFontFeature)(
                    This,
                    fontFeatureIndex,
                    fontFeature
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AddFontFeature;

            public IntPtr GetFontFeatureCount;

            public IntPtr GetFontFeature;
        }
    }
}
