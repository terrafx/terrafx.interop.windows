// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Font typography setting.</summary>
    [Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
    public unsafe partial struct IDWriteTypography
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTypography* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTypography* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTypography* This);

        /// <summary>Add font feature.</summary>
        /// <param name="fontFeature">The font feature to add.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFeature(IDWriteTypography* This, DWRITE_FONT_FEATURE fontFeature);

        /// <summary>Get the number of font features.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFeatureCount(IDWriteTypography* This);

        /// <summary>Get the font feature at the specified index.</summary>
        /// <param name="fontFeatureIndex">The zero-based index of the font feature to get.</param>
        /// <param name="fontFeature">The font feature.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFeature(IDWriteTypography* This, [NativeTypeName("UINT32")] uint fontFeatureIndex, DWRITE_FONT_FEATURE* fontFeature);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFeature(DWRITE_FONT_FEATURE fontFeature)
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddFontFeature>(lpVtbl->AddFontFeature)(This, fontFeature);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFeatureCount()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFeatureCount>(lpVtbl->GetFontFeatureCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFeature([NativeTypeName("UINT32")] uint fontFeatureIndex, DWRITE_FONT_FEATURE* fontFeature)
        {
            fixed (IDWriteTypography* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFeature>(lpVtbl->GetFontFeature)(This, fontFeatureIndex, fontFeature);
            }
        }

        public partial struct Vtbl
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
