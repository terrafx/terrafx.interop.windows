// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF839FE6-8C2A-4DD2-B6EA-C22D6961AF05")]
    public unsafe partial struct IMFSourceReaderCallback2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, uint>)(lpVtbl[1]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, uint>)(lpVtbl[2]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnReadSample([NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, int, uint, uint, long, IMFSample*, int>)(lpVtbl[3]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, uint, int>)(lpVtbl[4]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, uint, IMFMediaEvent*, int>)(lpVtbl[5]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, pEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnTransformChange()
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, int>)(lpVtbl[6]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* stdcall<IMFSourceReaderCallback2*, uint, int, int>)(lpVtbl[7]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, hrStatus);
        }
    }
}
