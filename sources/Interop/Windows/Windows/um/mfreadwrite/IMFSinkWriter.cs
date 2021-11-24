// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3137F1CD-FE5E-4805-A5D8-FB477448CB3D")]
[NativeTypeName("struct IMFSinkWriter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSinkWriter : IMFSinkWriter.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint>)(lpVtbl[1]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint>)(lpVtbl[2]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddStream(IMFMediaType* pTargetMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, IMFMediaType*, uint*, int>)(lpVtbl[3]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), pTargetMediaType, pdwStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pInputMediaType, IMFAttributes* pEncodingParameters)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, IMFMediaType*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pInputMediaType, pEncodingParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginWriting()
    {
        return ((delegate* unmanaged<IMFSinkWriter*, int>)(lpVtbl[5]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, IMFSample*, int>)(lpVtbl[6]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pSample);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendStreamTick([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LONGLONG")] long llTimestamp)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, long, int>)(lpVtbl[7]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, llTimestamp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PlaceMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, void*, int>)(lpVtbl[8]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, int>)(lpVtbl[9]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, int>)(lpVtbl[10]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Finalize()
    {
        return ((delegate* unmanaged<IMFSinkWriter*, int>)(lpVtbl[11]))((IMFSinkWriter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, Guid*, Guid*, void**, int>)(lpVtbl[12]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStatistics([NativeTypeName("DWORD")] uint dwStreamIndex, MF_SINK_WRITER_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IMFSinkWriter*, uint, MF_SINK_WRITER_STATISTICS*, int>)(lpVtbl[13]))((IMFSinkWriter*)Unsafe.AsPointer(ref this), dwStreamIndex, pStats);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddStream(IMFMediaType* pTargetMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamIndex);

        [VtblIndex(4)]
        HRESULT SetInputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pInputMediaType, IMFAttributes* pEncodingParameters);

        [VtblIndex(5)]
        HRESULT BeginWriting();

        [VtblIndex(6)]
        HRESULT WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, IMFSample* pSample);

        [VtblIndex(7)]
        HRESULT SendStreamTick([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LONGLONG")] long llTimestamp);

        [VtblIndex(8)]
        HRESULT PlaceMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext);

        [VtblIndex(9)]
        HRESULT NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(10)]
        HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(11)]
        HRESULT Finalize();

        [VtblIndex(12)]
        HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [VtblIndex(13)]
        HRESULT GetStatistics([NativeTypeName("DWORD")] uint dwStreamIndex, MF_SINK_WRITER_STATISTICS* pStats);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint> Release;

        [NativeTypeName("HRESULT (IMFMediaType *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, IMFMediaType*, uint*, int> AddStream;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, IMFMediaType*, IMFAttributes*, int> SetInputMediaType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, int> BeginWriting;

        [NativeTypeName("HRESULT (DWORD, IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, IMFSample*, int> WriteSample;

        [NativeTypeName("HRESULT (DWORD, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, long, int> SendStreamTick;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, void*, int> PlaceMarker;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, int> NotifyEndOfSegment;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, int> Flush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, int> Finalize;

        [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, Guid*, Guid*, void**, int> GetServiceForStream;

        [NativeTypeName("HRESULT (DWORD, MF_SINK_WRITER_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSinkWriter*, uint, MF_SINK_WRITER_STATISTICS*, int> GetStatistics;
    }
}
