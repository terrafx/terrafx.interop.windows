// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>IDWriteRemoteFontFileStream represents a font file stream parts of which may be non-local. Non-local data must be downloaded before it can be accessed using ReadFragment. The interface exposes methods to download font data and query the locality of font data.</summary>
    /// <remarks> For more information, see the description of IDWriteRemoteFontFileLoader.</remarks>
    [Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
    public unsafe partial struct IDWriteRemoteFontFileStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRemoteFontFileStream* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRemoteFontFileStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRemoteFontFileStream* This);

        /// <summary>Reads a fragment from a file.</summary>
        /// <param name="fragmentStart">Receives the pointer to the start of the font file fragment.</param>
        /// <param name="fileOffset">Offset of the fragment from the beginning of the font file.</param>
        /// <param name="fragmentSize">Size of the fragment in bytes.</param>
        /// <param name="fragmentContext">The client defined context to be passed to the ReleaseFileFragment.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks>IMPORTANT: ReadFileFragment() implementations must check whether the requested file fragment is within the file bounds. Otherwise, an error should be returned from ReadFileFragment.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadFileFragment(IDWriteRemoteFontFileStream* This, void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, void** fragmentContext);

        /// <summary>Releases a fragment from a file.</summary>
        /// <param name="fragmentContext">The client defined context of a font fragment returned from ReadFileFragment.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFileFragment(IDWriteRemoteFontFileStream* This, void* fragmentContext);

        /// <summary>Obtains the total size of a file.</summary>
        /// <param name="fileSize">Receives the total size of the file.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks>Implementing GetFileSize() for asynchronously loaded font files may require downloading the complete file contents, therefore this method should only be used for operations that either require complete font file to be loaded (e.g., copying a font file) or need to make decisions based on the value of the file size (e.g., validation against a persisted file size).</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileSize(IDWriteRemoteFontFileStream* This, [NativeTypeName("UINT64")] ulong* fileSize);

        /// <summary>Obtains the last modified time of the file. The last modified time is used by DirectWrite font selection algorithms to determine whether one font resource is more up to date than another one.</summary>
        /// <param name="lastWriteTime">Receives the last modified time of the file in the format that represents the number of 100-nanosecond intervals since January 1, 1601 (UTC).</param>
        /// <returns>Standard HRESULT error code. For resources that don't have a concept of the last modified time, the implementation of GetLastWriteTime should return E_NOTIMPL.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastWriteTime(IDWriteRemoteFontFileStream* This, [NativeTypeName("UINT64")] ulong* lastWriteTime);

        /// <summary>GetLocalFileSize returns the number of bytes of the font file that are currently local, which should always be less than or equal to the full file size returned by GetFileSize. If the locality is remote, the return value is zero. If the file is fully local, the return value must be the same as GetFileSize.</summary>
        /// <param name="localFileSize">Receives the local size of the file.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocalFileSize(IDWriteRemoteFontFileStream* This, [NativeTypeName("UINT64")] ulong* localFileSize);

        /// <summary>GetFileFragmentLocality returns information about the locality of a byte range (i.e., font fragment) within the font file stream.</summary>
        /// <param name="fileOffset">Offset of the fragment from the beginning of the font file.</param>
        /// <param name="fragmentSize">Size of the fragment in bytes.</param>
        /// <param name="isLocal">Receives TRUE if the first byte of the fragment is local, FALSE if not.</param>
        /// <param name="partialSize">Receives the number of contiguous bytes from the start of the fragment that have the same locality as the first byte.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileFragmentLocality(IDWriteRemoteFontFileStream* This, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL")] int* isLocal, [NativeTypeName("UINT64")] ulong* partialSize);

        /// <summary>Gets the current locality of the file.</summary>
        /// <returns> Returns the locality enumeration (i.e., remote, partial, or local).</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetLocality(IDWriteRemoteFontFileStream* This);

        /// <summary>BeginDownload begins downloading all or part of the font file.</summary>
        /// <param name="fileFragments">Array of public partial structures, each specifying a byte range to download.</param>
        /// <param name="fragmentCount">Number of elements in the fileFragments array. This can be zero to just download file information, such as the size.</param>
        /// <param name="asyncResult">Receives an object that can be used to wait for the asynchronous download to complete and to get the download result upon completion. The result may be NULL if the download completes synchronously. For example, this can happen if method determines that the requested data is already local.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDownload(IDWriteRemoteFontFileStream* This, [NativeTypeName("GUID")] Guid* downloadOperationID, [NativeTypeName("DWRITE_FILE_FRAGMENT[]")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, IDWriteAsyncResult** asyncResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment(void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, void** fragmentContext)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReadFileFragment>(lpVtbl->ReadFileFragment)(This, fragmentStart, fileOffset, fragmentSize, fragmentContext);
            }
        }

        public void ReleaseFileFragment(void* fragmentContext)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseFileFragment>(lpVtbl->ReleaseFileFragment)(This, fragmentContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64")] ulong* fileSize)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileSize>(lpVtbl->GetFileSize)(This, fileSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64")] ulong* lastWriteTime)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastWriteTime>(lpVtbl->GetLastWriteTime)(This, lastWriteTime);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileSize([NativeTypeName("UINT64")] ulong* localFileSize)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocalFileSize>(lpVtbl->GetLocalFileSize)(This, localFileSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL")] int* isLocal, [NativeTypeName("UINT64")] ulong* partialSize)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileFragmentLocality>(lpVtbl->GetFileFragmentLocality)(This, fileOffset, fragmentSize, isLocal, partialSize);
            }
        }

        public DWRITE_LOCALITY GetLocality()
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocality>(lpVtbl->GetLocality)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("GUID")] Guid* downloadOperationID, [NativeTypeName("DWRITE_FILE_FRAGMENT[]")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            fixed (IDWriteRemoteFontFileStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_BeginDownload>(lpVtbl->BeginDownload)(This, downloadOperationID, fileFragments, fragmentCount, asyncResult);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ReadFileFragment;

            public IntPtr ReleaseFileFragment;

            public IntPtr GetFileSize;

            public IntPtr GetLastWriteTime;

            public IntPtr GetLocalFileSize;

            public IntPtr GetFileFragmentLocality;

            public IntPtr GetLocality;

            public IntPtr BeginDownload;
        }
    }
}
