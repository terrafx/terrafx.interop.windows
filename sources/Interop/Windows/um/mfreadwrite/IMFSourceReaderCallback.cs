// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DEEC8D99-FA1D-4D82-84C2-2C8969944867")]
    [NativeTypeName("struct IMFSourceReaderCallback : IUnknown")]
    public unsafe partial struct IMFSourceReaderCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, uint>)(lpVtbl[1]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, uint>)(lpVtbl[2]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnReadSample([NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, int, uint, uint, long, IMFSample*, int>)(lpVtbl[3]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, uint, int>)(lpVtbl[4]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSourceReaderCallback*, uint, IMFMediaEvent*, int>)(lpVtbl[5]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pEvent);
        }
    }
}
