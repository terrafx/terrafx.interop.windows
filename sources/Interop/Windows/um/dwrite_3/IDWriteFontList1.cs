// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontList interface represents a list of fonts.</summary>
    [Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADE")]
    public unsafe struct IDWriteFontList1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontList1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontList1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontList1* This);

        /// <summary>Gets the font collection that contains the fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the font collection object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteFontList1* This, IDWriteFontCollection** fontCollection);

        /// <summary>Gets the number of fonts in the font list.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontCount(IDWriteFontList1* This);

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="index">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont(IDWriteFontList1* This, [NativeTypeName("UINT32")] uint index, IDWriteFont** font);

        /// <summary>Gets the current locality of a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <remarks> The locality enumeration. For fully local files, the result will always be DWRITE_LOCALITY_LOCAL. For downloadable files, the result depends on how much of the file has been downloaded, and GetFont() fails if the locality is REMOTE and potentially fails if PARTIAL. The application can explicitly ask for the font to be enqueued for download via EnqueueFontDownloadRequest followed by BeginDownload().</remarks>
        /// <returns> The locality enumeration.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetFontLocality(IDWriteFontList1* This, [NativeTypeName("UINT32")] uint listIndex);

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns> Standard HRESULT error code. The function returns DWRITE_E_REMOTEFONT if it could not construct a remote font.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont1(IDWriteFontList1* This, [NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font);

        /// <summary>Gets a font face reference given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="fontFaceReference">Receives a pointer to the newly created font face reference object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference(IDWriteFontList1* This, [NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(This, fontCollection);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFont>(lpVtbl->GetFont)(This, index, font);
            }
        }

        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontLocality>(lpVtbl->GetFontLocality)(This, listIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont1([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFont1>(lpVtbl->GetFont1)(This, listIndex, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            fixed (IDWriteFontList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)(This, listIndex, fontFaceReference);
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

            public IntPtr GetFontLocality;

            public IntPtr GetFont1;

            public IntPtr GetFontFaceReference;
        }
    }
}
