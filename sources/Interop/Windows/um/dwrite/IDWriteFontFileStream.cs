// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface for loading font file data.</summary>
    [Guid("6D4865FE-0AB8-4D91-8F62-5DD6BE34A3E0")]
    public unsafe struct IDWriteFontFileStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDWriteFontFileStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDWriteFontFileStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDWriteFontFileStream* This
        );

        /// <summary>Reads a fragment from a file.</summary>
        /// <param name="fragmentStart">Receives the pointer to the start of the font file fragment.</param>
        /// <param name="fileOffset">Offset of the fragment from the beginning of the font file.</param>
        /// <param name="fragmentSize">Size of the fragment in bytes.</param>
        /// <param name="fragmentContext">The client defined context to be passed to the ReleaseFileFragment.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks>IMPORTANT: ReadFileFragment() implementations must check whether the requested file fragment is within the file bounds. Otherwise, an error should be returned from ReadFileFragment.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadFileFragment(
            [In] IDWriteFontFileStream* This,
            [Out] void** fragmentStart,
            [In, NativeTypeName("UINT64")] ulong fileOffset,
            [In, NativeTypeName("UINT64")] ulong fragmentSize,
            [Out] void** fragmentContext
        );

        /// <summary>Releases a fragment from a file.</summary>
        /// <param name="fragmentContext">The client defined context of a font fragment returned from ReadFileFragment.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFileFragment(
            [In] IDWriteFontFileStream* This,
            [In] void* fragmentContext
        );

        /// <summary>Obtains the total size of a file.</summary>
        /// <param name="fileSize">Receives the total size of the file.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks>Implementing GetFileSize() for asynchronously loaded font files may require downloading the complete file contents, therefore this method should only be used for operations that either require complete font file to be loaded (e.g., copying a font file) or need to make decisions based on the value of the file size (e.g., validation against a persisted file size).</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileSize(
            [In] IDWriteFontFileStream* This,
            [Out, NativeTypeName("UINT64")] ulong* fileSize
        );

        /// <summary>Obtains the last modified time of the file. The last modified time is used by DirectWrite font selection algorithms to determine whether one font resource is more up to date than another one.</summary>
        /// <param name="lastWriteTime">Receives the last modified time of the file in the format that represents the number of 100-nanosecond intervals since January 1, 1601 (UTC).</param>
        /// <returns>Standard HRESULT error code. For resources that don't have a concept of the last modified time, the implementation of GetLastWriteTime should return E_NOTIMPL.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastWriteTime(
            [In] IDWriteFontFileStream* This,
            [Out, NativeTypeName("UINT64")] ulong* lastWriteTime
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontFileStream* This = &this)
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
            fixed (IDWriteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment(
            [Out] void** fragmentStart,
            [In, NativeTypeName("UINT64")] ulong fileOffset,
            [In, NativeTypeName("UINT64")] ulong fragmentSize,
            [Out] void** fragmentContext
        )
        {
            fixed (IDWriteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReadFileFragment>(lpVtbl->ReadFileFragment)(
                    This,
                    fragmentStart,
                    fileOffset,
                    fragmentSize,
                    fragmentContext
                );
            }
        }

        public void ReleaseFileFragment(
            [In] void* fragmentContext
        )
        {
            fixed (IDWriteFontFileStream* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseFileFragment>(lpVtbl->ReleaseFileFragment)(
                    This,
                    fragmentContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize(
            [Out, NativeTypeName("UINT64")] ulong* fileSize
        )
        {
            fixed (IDWriteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileSize>(lpVtbl->GetFileSize)(
                    This,
                    fileSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime(
            [Out, NativeTypeName("UINT64")] ulong* lastWriteTime
        )
        {
            fixed (IDWriteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastWriteTime>(lpVtbl->GetLastWriteTime)(
                    This,
                    lastWriteTime
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ReadFileFragment;

            public IntPtr ReleaseFileFragment;

            public IntPtr GetFileSize;

            public IntPtr GetLastWriteTime;
        }
    }
}
