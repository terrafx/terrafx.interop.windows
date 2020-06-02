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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("void **")] void** fragmentContext)
        {
            return lpVtbl->ReadFileFragment((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
        }

        public void ReleaseFileFragment([NativeTypeName("void *")] void* fragmentContext)
        {
            lpVtbl->ReleaseFileFragment((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
        {
            return lpVtbl->GetFileSize((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
        {
            return lpVtbl->GetLastWriteTime((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
        {
            return lpVtbl->GetLocalFileSize((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL *")] int* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize)
        {
            return lpVtbl->GetFileFragmentLocality((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return lpVtbl->GetLocality((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, [NativeTypeName("IDWriteAsyncResult **")] IDWriteAsyncResult** asyncResult)
        {
            return lpVtbl->BeginDownload((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, uint> Release;

            [NativeTypeName("HRESULT (const void **, UINT64, UINT64, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int> ReadFileFragment;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, void*, void> ReleaseFileFragment;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int> GetFileSize;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int> GetLastWriteTime;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, ulong*, int> GetLocalFileSize;

            [NativeTypeName("HRESULT (UINT64, UINT64, BOOL *, UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int> GetFileFragmentLocality;

            [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, DWRITE_LOCALITY> GetLocality;

            [NativeTypeName("HRESULT (const UUID *, const DWRITE_FILE_FRAGMENT *, UINT32, IDWriteAsyncResult **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRemoteFontFileStream*, Guid*, DWRITE_FILE_FRAGMENT*, uint, IDWriteAsyncResult**, int> BeginDownload;
        }
    }
}
