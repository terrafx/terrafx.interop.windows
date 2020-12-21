// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3137F1CD-FE5E-4805-A5D8-FB477448CB3D")]
    [NativeTypeName("struct IMFSinkWriter : IUnknown")]
    public unsafe partial struct IMFSinkWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint>)(lpVtbl[1]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint>)(lpVtbl[2]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("IMFMediaType *")] IMFMediaType* pTargetMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, IMFMediaType*, uint*, int>)(lpVtbl[3]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), pTargetMediaType, pdwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pInputMediaType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pEncodingParameters)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, IMFMediaType*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pInputMediaType, pEncodingParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginWriting()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, int>)(lpVtbl[5]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, IMFSample*, int>)(lpVtbl[6]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendStreamTick([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LONGLONG")] long llTimestamp)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, long, int>)(lpVtbl[7]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, llTimestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PlaceMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, void*, int>)(lpVtbl[8]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, int>)(lpVtbl[9]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, int>)(lpVtbl[10]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finalize()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, int>)(lpVtbl[11]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, Guid*, Guid*, void**, int>)(lpVtbl[12]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatistics([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("MF_SINK_WRITER_STATISTICS *")] MF_SINK_WRITER_STATISTICS* pStats)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriter*, uint, MF_SINK_WRITER_STATISTICS*, int>)(lpVtbl[13]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pStats);
        }
    }
}
