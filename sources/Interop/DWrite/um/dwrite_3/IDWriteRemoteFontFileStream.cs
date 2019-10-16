// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
    public unsafe partial struct IDWriteRemoteFontFileStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRemoteFontFileStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRemoteFontFileStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadFileFragment(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("void **")] void** fragmentContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFileFragment(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("void *")] void* fragmentContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileSize(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("UINT64 *")] ulong* fileSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastWriteTime(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("UINT64 *")] ulong* lastWriteTime);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocalFileSize(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("UINT64 *")] ulong* localFileSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileFragmentLocality(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL *")] int* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetLocality(IDWriteRemoteFontFileStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDownload(IDWriteRemoteFontFileStream* pThis, [NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, [NativeTypeName("IDWriteAsyncResult **")] IDWriteAsyncResult** asyncResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("void **")] void** fragmentContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReadFileFragment>(lpVtbl->ReadFileFragment)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
        }

        public void ReleaseFileFragment([NativeTypeName("void *")] void* fragmentContext)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseFileFragment>(lpVtbl->ReleaseFileFragment)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileSize>(lpVtbl->GetFileSize)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastWriteTime>(lpVtbl->GetLastWriteTime)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocalFileSize>(lpVtbl->GetLocalFileSize)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL *")] int* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileFragmentLocality>(lpVtbl->GetFileFragmentLocality)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocality>(lpVtbl->GetLocality)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, [NativeTypeName("IDWriteAsyncResult **")] IDWriteAsyncResult** asyncResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginDownload>(lpVtbl->BeginDownload)((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const void **, UINT64, UINT64, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ReadFileFragment;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ReleaseFileFragment;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFileSize;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLastWriteTime;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocalFileSize;

            [NativeTypeName("HRESULT (UINT64, UINT64, BOOL *, UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFileFragmentLocality;

            [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocality;

            [NativeTypeName("HRESULT (const UUID *, const DWRITE_FILE_FRAGMENT *, UINT32, IDWriteAsyncResult **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BeginDownload;
        }
    }
}
