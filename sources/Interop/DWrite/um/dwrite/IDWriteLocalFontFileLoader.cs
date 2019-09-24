// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A built-in implementation of IDWriteFontFileLoader interface that operates on local font files and exposes local font file information from the font file reference key. Font file references created using CreateFontFileReference use this font file loader.</summary>
    [Guid("B2D9F3EC-C9FE-4A11-A2EC-D86208F7C0A2")]
    public unsafe struct IDWriteLocalFontFileLoader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteLocalFontFileLoader* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteLocalFontFileLoader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteLocalFontFileLoader* This);

        /// <summary>Creates a font file stream object that encapsulates an open file resource. The resource is closed when the last reference to fontFileStream is released.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStreamFromKey(IDWriteLocalFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream);

        /// <summary>Obtains the length of the absolute file path from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="filePathLength">Length of the file path string not including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilePathLengthFromKey(IDWriteLocalFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("UINT32")] uint* filePathLength);

        /// <summary>Obtains the absolute font file path from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="filePath">Character array that receives the local file path.</param>
        /// <param name="filePathSize">Size of the filePath array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilePathFromKey(IDWriteLocalFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("WCHAR[]")] char* filePath, [NativeTypeName("UINT32")] uint filePathSize);

        /// <summary>Obtains the last write time of the file from the font file reference key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the local font file within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="lastWriteTime">Last modified time of the font file.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastWriteTimeFromKey(IDWriteLocalFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, FILETIME* lastWriteTime);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilePathLengthFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("UINT32")] uint* filePathLength)
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFilePathLengthFromKey>(lpVtbl->GetFilePathLengthFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilePathFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("WCHAR[]")] char* filePath, [NativeTypeName("UINT32")] uint filePathSize)
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFilePathFromKey>(lpVtbl->GetFilePathFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTimeFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, FILETIME* lastWriteTime)
        {
            fixed (IDWriteLocalFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastWriteTimeFromKey>(lpVtbl->GetLastWriteTimeFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateStreamFromKey;

            public IntPtr GetFilePathLengthFromKey;

            public IntPtr GetFilePathFromKey;

            public IntPtr GetLastWriteTimeFromKey;
        }
    }
}
