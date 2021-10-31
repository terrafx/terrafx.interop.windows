// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DEEC8D99-FA1D-4D82-84C2-2C8969944867")]
    [NativeTypeName("struct IMFSourceReaderCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceReaderCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, uint>)(lpVtbl[1]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, uint>)(lpVtbl[2]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnReadSample(HRESULT hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, HRESULT, uint, uint, long, IMFSample*, int>)(lpVtbl[3]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, uint, int>)(lpVtbl[4]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback*, uint, IMFMediaEvent*, int>)(lpVtbl[5]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pEvent);
        }
    }
}
