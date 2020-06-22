// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71CE469C-F34B-49EA-A56B-2D2A10E51149")]
    public unsafe partial struct IMFByteStreamCacheControl2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, uint>)(lpVtbl[1]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, uint>)(lpVtbl[2]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int StopBackgroundTransfer()
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, int>)(lpVtbl[3]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetByteRanges([NativeTypeName("DWORD *")] uint* pcRanges, [NativeTypeName("MF_BYTE_STREAM_CACHE_RANGE **")] MF_BYTE_STREAM_CACHE_RANGE** ppRanges)
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, uint*, MF_BYTE_STREAM_CACHE_RANGE**, int>)(lpVtbl[4]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), pcRanges, ppRanges);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCacheLimit([NativeTypeName("QWORD")] ulong qwBytes)
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, ulong, int>)(lpVtbl[5]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), qwBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsBackgroundTransferActive([NativeTypeName("BOOL *")] int* pfActive)
        {
            return ((delegate* stdcall<IMFByteStreamCacheControl2*, int*, int>)(lpVtbl[6]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), pfActive);
        }
    }
}
