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
    /// <summary>A built-in implementation of IDWriteFontFileLoader interface that operates on local font files and exposes local font file information from the font file reference key. Font file references created using CreateFontFileReference use this font file loader.</summary>
    [Guid("B2D9F3EC-C9FE-4A11-A2EC-D86208F7C0A2")]
    [Unmanaged]
    public unsafe struct IDWriteLocalFontFileLoader
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteLocalFontFileLoader* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteLocalFontFileLoader* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteLocalFontFileLoader* This
        );
        #endregion

        #region IDWriteFontFileLoader Delegates
        /// <summary>Creates a font file stream object that encapsulates an open file resource. The resource is closed when the last reference to fontFileStream is released.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStreamFromKey(
            [In] IDWriteLocalFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        );
        #endregion

        #region Delegates
        /// <summary>Obtains the length of the absolute file path from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="filePathLength">Length of the file path string not including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFilePathLengthFromKey(
            [In] IDWriteLocalFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out, NativeTypeName("UINT32")] uint* filePathLength
        );

        /// <summary>Obtains the absolute font file path from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="filePath">Character array that receives the local file path.</param>
        /// <param name="filePathSize">Size of the filePath array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFilePathFromKey(
            [In] IDWriteLocalFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out, NativeTypeName("WCHAR[]")] char* filePath,
            [In, NativeTypeName("UINT32")] uint filePathSize
        );

        /// <summary>Obtains the last write time of the file from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="lastWriteTime">Last modified time of the font file.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLastWriteTimeFromKey(
            [In] IDWriteLocalFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] FILETIME* lastWriteTime
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
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
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontFileLoader Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        )
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    fontFileStream
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFilePathLengthFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out, NativeTypeName("UINT32")] uint* filePathLength
        )
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_GetFilePathLengthFromKey>(lpVtbl->GetFilePathLengthFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    filePathLength
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilePathFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out, NativeTypeName("WCHAR[]")] char* filePath,
            [In, NativeTypeName("UINT32")] uint filePathSize
        )
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_GetFilePathFromKey>(lpVtbl->GetFilePathFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    filePath,
                    filePathSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTimeFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] FILETIME* lastWriteTime
        )
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return MarshalFunction<_GetLastWriteTimeFromKey>(lpVtbl->GetLastWriteTimeFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    lastWriteTime
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

            #region IDWriteFontFileLoader Fields
            public IntPtr CreateStreamFromKey;
            #endregion

            #region Fields
            public IntPtr GetFilePathLengthFromKey;

            public IntPtr GetFilePathFromKey;

            public IntPtr GetLastWriteTimeFromKey;
            #endregion
        }
        #endregion
    }
}
