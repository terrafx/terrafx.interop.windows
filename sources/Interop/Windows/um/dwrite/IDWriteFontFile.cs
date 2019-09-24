// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents a reference to a font file.</summary>
    [Guid("739D886A-CEF5-47DC-8769-1A8B41BEBBB0")]
    public unsafe struct IDWriteFontFile
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontFile* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontFile* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontFile* This
        );

        /// <summary>This method obtains the pointer to the reference key of a font file. The pointer is only valid until the object that refers to it is released.</summary>
        /// <param name="fontFileReferenceKey">Pointer to the font file reference key. IMPORTANT: The pointer value is valid until the font file reference object it is obtained from is released.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetReferenceKey(
            [In] IDWriteFontFile* This,
            [Out] void** fontFileReferenceKey,
            [Out, NativeTypeName("UINT32")] uint* fontFileReferenceKeySize
        );

        /// <summary>Obtains the file loader associated with a font file object.</summary>
        /// <param name="fontFileLoader">The font file loader associated with the font file object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLoader(
            [In] IDWriteFontFile* This,
            [Out] IDWriteFontFileLoader** fontFileLoader
        );

        /// <summary>Analyzes a file and returns whether it represents a font, and whether the font type is supported by the font system.</summary>
        /// <param name="isSupportedFontType">TRUE if the font type is supported by the font system, FALSE otherwise.</param>
        /// <param name="fontFileType">The type of the font file. Note that even if isSupportedFontType is FALSE, the fontFileType value may be different from DWRITE_FONT_FILE_TYPE_UNKNOWN.</param>
        /// <param name="fontFaceType">The type of the font face that can be constructed from the font file. Note that even if isSupportedFontType is FALSE, the fontFaceType value may be different from DWRITE_FONT_FACE_TYPE_UNKNOWN.</param>
        /// <param name="numberOfFaces">Number of font faces contained in the font file.</param>
        /// <returns>Standard HRESULT error code if there was a processing error during analysis.</returns>
        /// <remarks>IMPORTANT: certain font file types are recognized, but not supported by the font system. For example, the font system will recognize a file as a Type 1 font file, but will not be able to construct a font face object from it. In such situations, Analyze will set isSupportedFontType output parameter to FALSE.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Analyze(
            [In] IDWriteFontFile* This,
            [Out, NativeTypeName("BOOL")] int* isSupportedFontType,
            [Out] DWRITE_FONT_FILE_TYPE* fontFileType,
            [Out, Optional] DWRITE_FONT_FACE_TYPE* fontFaceType,
            [Out, NativeTypeName("UINT32")] uint* numberOfFaces
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontFile* This = &this)
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
            fixed (IDWriteFontFile* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFile* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReferenceKey(
            [Out] void** fontFileReferenceKey,
            [Out, NativeTypeName("UINT32")] uint* fontFileReferenceKeySize
        )
        {
            fixed (IDWriteFontFile* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReferenceKey>(lpVtbl->GetReferenceKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLoader(
            [Out] IDWriteFontFileLoader** fontFileLoader
        )
        {
            fixed (IDWriteFontFile* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLoader>(lpVtbl->GetLoader)(
                    This,
                    fontFileLoader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Analyze(
            [Out, NativeTypeName("BOOL")] int* isSupportedFontType,
            [Out] DWRITE_FONT_FILE_TYPE* fontFileType,
            [Out, Optional] DWRITE_FONT_FACE_TYPE* fontFaceType,
            [Out, NativeTypeName("UINT32")] uint* numberOfFaces
        )
        {
            fixed (IDWriteFontFile* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Analyze>(lpVtbl->Analyze)(
                    This,
                    isSupportedFontType,
                    fontFileType,
                    fontFaceType,
                    numberOfFaces
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetReferenceKey;

            public IntPtr GetLoader;

            public IntPtr Analyze;
        }
    }
}
