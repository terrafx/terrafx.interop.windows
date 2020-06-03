// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
    public unsafe partial struct IDWriteRemoteFontFileStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, uint>)(lpVtbl[1]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, uint>)(lpVtbl[2]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("void **")] void** fragmentContext)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)(lpVtbl[3]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
        }

        public void ReleaseFileFragment([NativeTypeName("void *")] void* fragmentContext)
        {
            ((delegate* stdcall<IDWriteRemoteFontFileStream*, void*, void>)(lpVtbl[4]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[5]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[6]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[7]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL *")] int* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)(lpVtbl[8]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, DWRITE_LOCALITY>)(lpVtbl[9]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, [NativeTypeName("IDWriteAsyncResult **")] IDWriteAsyncResult** asyncResult)
        {
            return ((delegate* stdcall<IDWriteRemoteFontFileStream*, Guid*, DWRITE_FILE_FRAGMENT*, uint, IDWriteAsyncResult**, int>)(lpVtbl[10]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
        }
    }
}
